using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Linq;

namespace InventoryManagementSystem
{
    public partial class InventoryForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-GR89OKG\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;TrustServerCertificate=True";
        private DataTable inventoryDataTable;
        private Timer statusTimer;

        public InventoryForm()
        {
            InitializeComponent();
            SetupToolTips();
            SetupStatusTimer();
            SetupDarkTheme();
        }

        private void SetupDarkTheme()
        {
            // DataGridView Dark Theme
            dataGridViewInventory.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 46);
            dataGridViewInventory.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            dataGridViewInventory.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dataGridViewInventory.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(58, 134, 255);
            dataGridViewInventory.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewInventory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            dataGridViewInventory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(138, 180, 248);
            dataGridViewInventory.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            dataGridViewInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 24, 38);
            dataGridViewInventory.GridColor = System.Drawing.Color.FromArgb(58, 58, 94);
            dataGridViewInventory.EnableHeadersVisualStyles = false;

            // StatusStrip Dark Theme
            statusStrip.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            statusStrip.ForeColor = System.Drawing.Color.FromArgb(176, 190, 197);
            toolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(176, 190, 197);
            toolStripStatusTime.ForeColor = System.Drawing.Color.FromArgb(138, 180, 248);

            // TextBox and ComboBox Dark Theme
            foreach (Control ctrl in groupBoxItemRegistration.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
                    ctrl.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
                    ctrl.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
                }
                else if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 30, 46);
                    dtp.CalendarForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
                }
            }

            foreach (Control ctrl in groupBoxSupplierDetails.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
                    ctrl.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
                }
            }

            // Search TextBox
            txtSearch.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);

            // Panel Search
            panelSearch.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
            LoadItemCodes();
            UpdateDashboard();
            UpdateStatusBar("Application loaded successfully");
        }

        private void SetupToolTips()
        {
            toolTip.SetToolTip(btnRegister, "Add a new item to inventory");
            toolTip.SetToolTip(btnUpdate, "Update selected item details");
            toolTip.SetToolTip(btnDelete, "Delete selected item from inventory");
            toolTip.SetToolTip(btnClear, "Clear all input fields");
            toolTip.SetToolTip(btnRefresh, "Refresh the inventory list");
            toolTip.SetToolTip(btnExport, "Export inventory data to CSV file");
            toolTip.SetToolTip(txtSearch, "Search by item name, code, category, or supplier");
        }

        private void SetupStatusTimer()
        {
            statusTimer = new Timer();
            statusTimer.Interval = 1000;
            statusTimer.Tick += (s, e) => toolStripStatusTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy - hh:mm:ss tt");
            statusTimer.Start();
        }

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
                        inventoryDataTable = new DataTable();
                        adapter.Fill(inventoryDataTable);
                        dataGridViewInventory.DataSource = inventoryDataTable;
                        
                        // Format DataGridView
                        if (dataGridViewInventory.Columns.Count > 0)
                        {
                            dataGridViewInventory.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
                            dataGridViewInventory.Columns["DateAdded"].DefaultCellStyle.Format = "yyyy-MM-dd";
                            
                            // Color code low stock items
                            foreach (DataGridViewRow row in dataGridViewInventory.Rows)
                            {
                                if (row.Cells["Quantity"].Value != null)
                                {
                                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                                    if (quantity < 10)
                                    {
                                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 20, 30);
                                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(239, 71, 111);
                                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                                    }
                                }
                            }
                        }
                    }
                }
                UpdateStatusBar("Inventory data loaded successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatusBar("Error loading data");
            }
        }

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
                MessageBox.Show("Error loading item codes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDashboard()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    // Total Items
                    string queryTotal = "SELECT COUNT(*) FROM Inventory";
                    using (SqlCommand cmd = new SqlCommand(queryTotal, conn))
                    {
                        lblTotalItemsValue.Text = cmd.ExecuteScalar().ToString();
                    }
                    
                    // Low Stock Items (less than 10)
                    string queryLowStock = "SELECT COUNT(*) FROM Inventory WHERE Quantity < 10";
                    using (SqlCommand cmd = new SqlCommand(queryLowStock, conn))
                    {
                        int lowStock = Convert.ToInt32(cmd.ExecuteScalar());
                        lblLowStockValue.Text = lowStock.ToString();
                        
                        if (lowStock > 0)
                        {
                            lblLowStockValue.ForeColor = System.Drawing.Color.Yellow;
                        }
                    }
                    
                    // Total Stock Value
                    string queryTotalValue = "SELECT ISNULL(SUM(Quantity * UnitPrice), 0) FROM Inventory";
                    using (SqlCommand cmd = new SqlCommand(queryTotalValue, conn))
                    {
                        decimal totalValue = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalValueAmount.Text = totalValue.ToString("C2");
                    }
                    
                    // Total Categories
                    string queryCategories = "SELECT COUNT(DISTINCT Category) FROM Inventory";
                    using (SqlCommand cmd = new SqlCommand(queryCategories, conn))
                    {
                        lblCategoriesValue.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
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
                        MessageBox.Show("✅ Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadInventoryData();
                        LoadItemCodes();
                        UpdateDashboard();
                        ClearFields();
                        UpdateStatusBar("New item registered successfully");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("❌ Item Code already exists. Please use a different Item Code.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateStatusBar("Error: Failed to register item");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatusBar("Error: Failed to register item");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                MessageBox.Show("⚠️ Please select an Item Code to update.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            MessageBox.Show("✅ Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadInventoryData();
                            UpdateDashboard();
                            ClearFields();
                            UpdateStatusBar("Item updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("❌ No record found with the specified Item Code.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatusBar("Error: Failed to update item");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                MessageBox.Show("⚠️ Please select an Item Code to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("❓ Are you sure, Do you really want to Delete this Record...?", 
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
                                MessageBox.Show("✅ Record Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadInventoryData();
                                LoadItemCodes();
                                UpdateDashboard();
                                ClearFields();
                                UpdateStatusBar("Item deleted successfully");
                            }
                            else
                            {
                                MessageBox.Show("❌ No record found with the specified Item Code.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateStatusBar("Error: Failed to delete item");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            UpdateStatusBar("Form cleared");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryData();
            LoadItemCodes();
            UpdateDashboard();
            txtSearch.Clear();
            UpdateStatusBar("Data refreshed");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "CSV File|*.csv";
                saveDialog.Title = "Export Inventory Data";
                saveDialog.FileName = "Inventory_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    
                    // Add headers
                    sb.AppendLine("ItemCode,ItemName,Category,Quantity,UnitPrice,Supplier,DateAdded");
                    
                    // Add data
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM Inventory ORDER BY ItemCode";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6}",
                                    reader["ItemCode"],
                                    reader["ItemName"],
                                    reader["Category"],
                                    reader["Quantity"],
                                    reader["UnitPrice"],
                                    reader["Supplier"],
                                    Convert.ToDateTime(reader["DateAdded"]).ToString("yyyy-MM-dd")));
                            }
                        }
                    }
                    
                    File.WriteAllText(saveDialog.FileName, sb.ToString());
                    MessageBox.Show("✅ Data exported successfully to:\n" + saveDialog.FileName, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateStatusBar("Data exported to CSV");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatusBar("Error: Failed to export data");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (inventoryDataTable != null)
                {
                    string searchText = txtSearch.Text.Trim();
                    
                    if (string.IsNullOrEmpty(searchText))
                    {
                        dataGridViewInventory.DataSource = inventoryDataTable;
                    }
                    else
                    {
                        DataView dv = inventoryDataTable.DefaultView;
                        dv.RowFilter = string.Format("ItemCode LIKE '%{0}%' OR ItemName LIKE '%{0}%' OR Category LIKE '%{0}%' OR Supplier LIKE '%{0}%'", searchText);
                        dataGridViewInventory.DataSource = dv.ToTable();
                    }
                    UpdateStatusBar("Search results: " + dataGridViewInventory.Rows.Count + " items found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewInventory.Rows[e.RowIndex];
                    cmbItemCode.Text = row.Cells["ItemCode"].Value.ToString();
                    txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                    txtCategory.Text = row.Cells["Category"].Value.ToString();
                    txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                    txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                    txtSupplier.Text = row.Cells["Supplier"].Value.ToString();
                    dateTimePickerDateAdded.Value = Convert.ToDateTime(row.Cells["DateAdded"].Value);
                    UpdateStatusBar("Item selected: " + txtItemName.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
                MessageBox.Show("Error loading item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("🚪 Are you sure you want to logout?", 
                "Confirm Logout", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                statusTimer.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

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

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(cmbItemCode.Text))
            {
                MessageBox.Show("⚠️ Please enter Item Code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbItemCode.Focus();
                return false;
            }

            int itemCode;
            if (!int.TryParse(cmbItemCode.Text, out itemCode))
            {
                MessageBox.Show("⚠️ Item Code must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbItemCode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtItemName.Text.Trim()))
            {
                MessageBox.Show("⚠️ Please enter Item Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCategory.Text.Trim()))
            {
                MessageBox.Show("⚠️ Please enter Category.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("⚠️ Quantity must be a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            decimal unitPrice;
            if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("⚠️ Unit Price must be a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSupplier.Text.Trim()))
            {
                MessageBox.Show("⚠️ Please enter Supplier name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplier.Focus();
                return false;
            }

            return true;
        }

        private void UpdateStatusBar(string message)
        {
            toolStripStatusLabel.Text = message;
        }
    }
}
