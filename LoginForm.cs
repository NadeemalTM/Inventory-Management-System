using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        // Connection string for SQL Server (Local Server)
        // Update the connection string based on your SQL Server configuration
        private string connectionString = @"Data Source=DESKTOP-GR89OKG\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;TrustServerCertificate=True";
        private bool passwordVisible = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        // Login Button Click Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", 
                    "Input Required", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Logins WHERE Username = @Username AND Password = @Password";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Login successful - Hide login form and show inventory form
                            MessageBox.Show("Login Successful!", 
                                "Success", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                            
                            this.Hide();
                            InventoryForm inventoryForm = new InventoryForm();
                            inventoryForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", 
                                "Invalid Login Details", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database Connection Error: " + sqlEx.Message, 
                    "Database Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // Exit Button Click Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", 
                "Confirm Exit", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Show/Hide Password Button Click Event
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            if (passwordVisible)
            {
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Text = "🙈";
            }
            else
            {
                txtPassword.PasswordChar = '●';
                btnShowPassword.Text = "👁";
            }
        }

        // Forgot Password Link Clicked Event
        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact your system administrator to reset your password.",
                "Password Recovery",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Login Button Mouse Enter Event
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(149, 96, 255);
        }

        // Login Button Mouse Leave Event
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(187, 134, 252);
        }

        // Close Button Mouse Enter Event
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(239, 71, 111);
            btnClose.ForeColor = Color.White;
        }

        // Close Button Mouse Leave Event
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(18, 18, 28);
            btnClose.ForeColor = Color.FromArgb(239, 71, 111);
        }

        // Form Load Event
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set focus to username textbox
            txtUsername.Focus();
            
            // Add shadow effect to panels
            panelUsername.Paint += Panel_Paint;
            panelPassword.Paint += Panel_Paint;
        }

        // Panel Paint Event for shadow effect
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                Color.FromArgb(58, 58, 94), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(58, 58, 94), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(58, 58, 94), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(58, 58, 94), 1, ButtonBorderStyle.Solid);
        }

        // PictureBox Logo Paint Event
        private void pictureBoxLogo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw a modern logo - circular gradient with text
            Rectangle rect = new Rectangle(10, 10, 130, 130);
            
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, 
                Color.FromArgb(187, 134, 252), 
                Color.FromArgb(106, 213, 166), 
                LinearGradientMode.ForwardDiagonal))
            {
                g.FillEllipse(brush, rect);
            }

            // Draw icon/text in center
            using (Font font = new Font("Segoe UI", 36, FontStyle.Bold))
            {
                string text = "IMS";
                SizeF textSize = g.MeasureString(text, font);
                PointF point = new PointF(
                    rect.X + (rect.Width - textSize.Width) / 2,
                    rect.Y + (rect.Height - textSize.Height) / 2);
                
                g.DrawString(text, font, Brushes.White, point);
            }
        }
    }
}
