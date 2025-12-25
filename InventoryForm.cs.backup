using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class InventoryForm : Form
    {
        // Connection string for SQL Server (Local Server)
        // Update the connection string based on your SQL Server configuration
        private string connectionString = @"Data Source=DESKTOP-GR89OKG\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;TrustServerCertificate=True";

        public InventoryForm()
        {
            InitializeComponent();
        }

        // Form Load Event - Load data when form opens
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
            LoadItemCodes();
        }

        // Load all inventory data into DataGridView
        private void LoadInventoryData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ItemCode, ItemName, Category, Quantity, UnitPrice, Supplier, DateAdded FROM Inventory ORDER BY ItemCode";
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewInventory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory data: " + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Load ItemCodes into ComboBox for searching
        private void LoadItemCodes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ItemCode FROM Inventory ORDER BY ItemCode";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        cmbItemCode.Items.Clear();
                        
                        while (reader.Read())
                        {
                            cmbItemCode.Items.Add(reader["ItemCode"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item codes: " + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Register Button - Insert new record
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Inventory (ItemCode, ItemName, Category, Quantity, UnitPrice, Supplier, DateAdded) 
                                   VALUES (@ItemCode, @ItemName, @Category, @Quantity, @UnitPrice, @Supplier, @DateAdded)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemCode", int.Parse(cmbItemCode.Text));
                        cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(txtUnitPrice.Text));
                        cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@DateAdded", dateTimePickerDateAdded.Value.Date);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Added Successfully", 
                            "Success", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        
                        LoadInventoryData();
                        LoadItemCodes();
                        ClearFields();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627) // Primary key violation
                {
                    MessageBox.Show("Item Code already exists. Please use a different Item Code.", 
                        "Duplicate Entry", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Error: " + sqlEx.Message, 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Update Button - Update existing record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                MessageBox.Show("Please select an Item Code to update.", 
                    "Input Required", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Inventory 
                                   SET ItemName = @ItemName, 
                                       Category = @Category, 
                                       Quantity = @Quantity, 
                                       UnitPrice = @UnitPrice, 
                                       Supplier = @Supplier, 
                                       DateAdded = @DateAdded 
                                   WHERE ItemCode = @ItemCode";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemCode", int.Parse(cmbItemCode.Text));
                        cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(txtUnitPrice.Text));
                        cmd.Parameters.AddWithValue("@Supplier", txtSupplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@DateAdded", dateTimePickerDateAdded.Value.Date);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully", 
                                "Success", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                            LoadInventoryData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified Item Code.", 
                                "Not Found", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Delete Button - Delete record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                MessageBox.Show("Please select an Item Code to delete.", 
                    "Input Required", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", 
                "Confirm Delete", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Inventory WHERE ItemCode = @ItemCode";
                        
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ItemCode", int.Parse(cmbItemCode.Text));
                            
                            int rowsAffected = cmd.ExecuteNonQuery();
                            
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Deleted Successfully", 
                                    "Success", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                                LoadInventoryData();
                                LoadItemCodes();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified Item Code.", 
                                    "Not Found", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        // Clear Button - Clear all fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ComboBox SelectedIndexChanged - Auto-fill fields when ItemCode is selected
        private void cmbItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItemCode.SelectedIndex == -1)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Inventory WHERE ItemCode = @ItemCode";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ItemCode", int.Parse(cmbItemCode.Text));
                        
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        if (reader.Read())
                        {
                            txtItemName.Text = reader["ItemName"].ToString();
                            txtCategory.Text = reader["Category"].ToString();
                            txtQuantity.Text = reader["Quantity"].ToString();
                            txtUnitPrice.Text = reader["UnitPrice"].ToString();
                            txtSupplier.Text = reader["Supplier"].ToString();
                            dateTimePickerDateAdded.Value = Convert.ToDateTime(reader["DateAdded"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item details: " + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Logout Link - Return to Login Form
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", 
                "Confirm Logout", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        // Helper method to clear all input fields
        private void ClearFields()
        {
            cmbItemCode.SelectedIndex = -1;
            cmbItemCode.Text = "";
            txtItemName.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtSupplier.Clear();
            txtSupplierEmail.Clear();
            dateTimePickerDateAdded.Value = DateTime.Now;
            cmbItemCode.Focus();
        }

        // Helper method to validate inputs
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                MessageBox.Show("Please enter Item Code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbItemCode.Focus();
                return false;
            }

            int itemCode;
            if (!int.TryParse(cmbItemCode.Text, out itemCode))
            {
                MessageBox.Show("Item Code must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbItemCode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtItemName.Text.Trim()))
            {
                MessageBox.Show("Please enter Item Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCategory.Text.Trim()))
            {
                MessageBox.Show("Please enter Category.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            decimal unitPrice;
            if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Unit Price must be a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSupplier.Text.Trim()))
            {
                MessageBox.Show("Please enter Supplier name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplier.Focus();
                return false;
            }

            return true;
        }
    }
}
