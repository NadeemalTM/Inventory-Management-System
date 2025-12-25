namespace InventoryManagementSystem
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelTotalItems = new System.Windows.Forms.Panel();
            this.lblTotalItemsValue = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.panelLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.panelTotalValue = new System.Windows.Forms.Panel();
            this.lblTotalValueAmount = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.lblCategoriesValue = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.groupBoxItemRegistration = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateAdded = new System.Windows.Forms.DateTimePicker();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cmbItemCode = new System.Windows.Forms.ComboBox();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.groupBoxItemDetails = new System.Windows.Forms.GroupBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.groupBoxSupplierDetails = new System.Windows.Forms.GroupBox();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.groupBoxControlPanel = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelTotalItems.SuspendLayout();
            this.panelLowStock.SuspendLayout();
            this.panelTotalValue.SuspendLayout();
            this.panelCategories.SuspendLayout();
            this.groupBoxItemRegistration.SuspendLayout();
            this.groupBoxItemDetails.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.groupBoxSupplierDetails.SuspendLayout();
            this.groupBoxControlPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTop.Controls.Add(this.linkLabelLogout);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📦 Inventory Management System";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.linkLabelLogout.LinkColor = System.Drawing.Color.White;
            this.linkLabelLogout.Location = new System.Drawing.Point(1200, 20);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(80, 20);
            this.linkLabelLogout.TabIndex = 1;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "🚪 Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.panelDashboard.Controls.Add(this.panelCategories);
            this.panelDashboard.Controls.Add(this.panelTotalValue);
            this.panelDashboard.Controls.Add(this.panelLowStock);
            this.panelDashboard.Controls.Add(this.panelTotalItems);
            this.panelDashboard.Controls.Add(this.lblDashboardTitle);
            this.panelDashboard.Location = new System.Drawing.Point(20, 80);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1260, 120);
            this.panelDashboard.TabIndex = 1;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(10, 10);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(95, 21);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // panelTotalItems
            // 
            this.panelTotalItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panelTotalItems.Controls.Add(this.lblTotalItemsValue);
            this.panelTotalItems.Controls.Add(this.lblTotalItems);
            this.panelTotalItems.Location = new System.Drawing.Point(20, 45);
            this.panelTotalItems.Name = "panelTotalItems";
            this.panelTotalItems.Size = new System.Drawing.Size(280, 60);
            this.panelTotalItems.TabIndex = 1;
            // 
            // lblTotalItemsValue
            // 
            this.lblTotalItemsValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalItemsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalItemsValue.Location = new System.Drawing.Point(10, 20);
            this.lblTotalItemsValue.Name = "lblTotalItemsValue";
            this.lblTotalItemsValue.Size = new System.Drawing.Size(100, 32);
            this.lblTotalItemsValue.TabIndex = 1;
            this.lblTotalItemsValue.Text = "0";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalItems.ForeColor = System.Drawing.Color.White;
            this.lblTotalItems.Location = new System.Drawing.Point(10, 5);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(80, 19);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "Total Items";
            // 
            // panelLowStock
            // 
            this.panelLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.panelLowStock.Controls.Add(this.lblLowStockValue);
            this.panelLowStock.Controls.Add(this.lblLowStock);
            this.panelLowStock.Location = new System.Drawing.Point(320, 45);
            this.panelLowStock.Name = "panelLowStock";
            this.panelLowStock.Size = new System.Drawing.Size(280, 60);
            this.panelLowStock.TabIndex = 2;
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLowStockValue.ForeColor = System.Drawing.Color.White;
            this.lblLowStockValue.Location = new System.Drawing.Point(10, 20);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Size = new System.Drawing.Size(100, 32);
            this.lblLowStockValue.TabIndex = 1;
            this.lblLowStockValue.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLowStock.ForeColor = System.Drawing.Color.White;
            this.lblLowStock.Location = new System.Drawing.Point(10, 5);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(122, 19);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "Low Stock Items";
            // 
            // panelTotalValue
            // 
            this.panelTotalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.panelTotalValue.Controls.Add(this.lblTotalValueAmount);
            this.panelTotalValue.Controls.Add(this.lblTotalValue);
            this.panelTotalValue.Location = new System.Drawing.Point(620, 45);
            this.panelTotalValue.Name = "panelTotalValue";
            this.panelTotalValue.Size = new System.Drawing.Size(280, 60);
            this.panelTotalValue.TabIndex = 3;
            // 
            // lblTotalValueAmount
            // 
            this.lblTotalValueAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalValueAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalValueAmount.Location = new System.Drawing.Point(10, 20);
            this.lblTotalValueAmount.Name = "lblTotalValueAmount";
            this.lblTotalValueAmount.Size = new System.Drawing.Size(260, 32);
            this.lblTotalValueAmount.TabIndex = 1;
            this.lblTotalValueAmount.Text = "$0.00";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalValue.Location = new System.Drawing.Point(10, 5);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(119, 19);
            this.lblTotalValue.TabIndex = 0;
            this.lblTotalValue.Text = "Total Stock Value";
            // 
            // panelCategories
            // 
            this.panelCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.panelCategories.Controls.Add(this.lblCategoriesValue);
            this.panelCategories.Controls.Add(this.lblCategories);
            this.panelCategories.Location = new System.Drawing.Point(920, 45);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(280, 60);
            this.panelCategories.TabIndex = 4;
            // 
            // lblCategoriesValue
            // 
            this.lblCategoriesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCategoriesValue.ForeColor = System.Drawing.Color.White;
            this.lblCategoriesValue.Location = new System.Drawing.Point(10, 20);
            this.lblCategoriesValue.Name = "lblCategoriesValue";
            this.lblCategoriesValue.Size = new System.Drawing.Size(100, 32);
            this.lblCategoriesValue.TabIndex = 1;
            this.lblCategoriesValue.Text = "0";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location = new System.Drawing.Point(10, 5);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(76, 19);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Categories";
            // 
            // groupBoxItemRegistration
            // 
            this.groupBoxItemRegistration.Controls.Add(this.dateTimePickerDateAdded);
            this.groupBoxItemRegistration.Controls.Add(this.txtUnitPrice);
            this.groupBoxItemRegistration.Controls.Add(this.txtQuantity);
            this.groupBoxItemRegistration.Controls.Add(this.txtCategory);
            this.groupBoxItemRegistration.Controls.Add(this.txtItemName);
            this.groupBoxItemRegistration.Controls.Add(this.cmbItemCode);
            this.groupBoxItemRegistration.Controls.Add(this.lblDateAdded);
            this.groupBoxItemRegistration.Controls.Add(this.lblUnitPrice);
            this.groupBoxItemRegistration.Controls.Add(this.lblQuantity);
            this.groupBoxItemRegistration.Controls.Add(this.lblCategory);
            this.groupBoxItemRegistration.Controls.Add(this.lblItemName);
            this.groupBoxItemRegistration.Controls.Add(this.lblItemCode);
            this.groupBoxItemRegistration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxItemRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.groupBoxItemRegistration.Location = new System.Drawing.Point(20, 220);
            this.groupBoxItemRegistration.Name = "groupBoxItemRegistration";
            this.groupBoxItemRegistration.Size = new System.Drawing.Size(420, 300);
            this.groupBoxItemRegistration.TabIndex = 2;
            this.groupBoxItemRegistration.TabStop = false;
            this.groupBoxItemRegistration.Text = "📝 Item Registration";
            // 
            // cmbItemCode
            // 
            this.cmbItemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbItemCode.FormattingEnabled = true;
            this.cmbItemCode.Location = new System.Drawing.Point(150, 40);
            this.cmbItemCode.Name = "cmbItemCode";
            this.cmbItemCode.Size = new System.Drawing.Size(250, 25);
            this.cmbItemCode.TabIndex = 1;
            this.cmbItemCode.SelectedIndexChanged += new System.EventHandler(this.cmbItemCode_SelectedIndexChanged);
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblItemCode.Location = new System.Drawing.Point(20, 43);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(73, 17);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "Item Code:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtItemName.Location = new System.Drawing.Point(150, 85);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(250, 25);
            this.txtItemName.TabIndex = 2;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblItemName.Location = new System.Drawing.Point(20, 88);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(79, 17);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCategory.Location = new System.Drawing.Point(150, 130);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(250, 25);
            this.txtCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCategory.Location = new System.Drawing.Point(20, 133);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQuantity.Location = new System.Drawing.Point(150, 175);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(250, 25);
            this.txtQuantity.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblQuantity.Location = new System.Drawing.Point(20, 178);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 17);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUnitPrice.Location = new System.Drawing.Point(150, 220);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(250, 25);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 223);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(70, 17);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // dateTimePickerDateAdded
            // 
            this.dateTimePickerDateAdded.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePickerDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateAdded.Location = new System.Drawing.Point(150, 260);
            this.dateTimePickerDateAdded.Name = "dateTimePickerDateAdded";
            this.dateTimePickerDateAdded.Size = new System.Drawing.Size(250, 25);
            this.dateTimePickerDateAdded.TabIndex = 6;
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDateAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblDateAdded.Location = new System.Drawing.Point(20, 266);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(85, 17);
            this.lblDateAdded.TabIndex = 5;
            this.lblDateAdded.Text = "Date Added:";
            // 
            // groupBoxItemDetails
            // 
            this.groupBoxItemDetails.Controls.Add(this.dataGridViewInventory);
            this.groupBoxItemDetails.Controls.Add(this.panelSearch);
            this.groupBoxItemDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxItemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.groupBoxItemDetails.Location = new System.Drawing.Point(460, 220);
            this.groupBoxItemDetails.Name = "groupBoxItemDetails";
            this.groupBoxItemDetails.Size = new System.Drawing.Size(820, 300);
            this.groupBoxItemDetails.TabIndex = 3;
            this.groupBoxItemDetails.TabStop = false;
            this.groupBoxItemDetails.Text = "📊 Item Details";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnExport);
            this.panelSearch.Controls.Add(this.btnRefresh);
            this.panelSearch.Location = new System.Drawing.Point(15, 25);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(790, 40);
            this.panelSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSearch.Location = new System.Drawing.Point(10, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍 Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(75, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(600, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(695, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 30);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "📥 Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(15, 75);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInventory.Size = new System.Drawing.Size(790, 210);
            this.dataGridViewInventory.TabIndex = 1;
            this.dataGridViewInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellClick);
            // 
            // groupBoxSupplierDetails
            // 
            this.groupBoxSupplierDetails.Controls.Add(this.txtSupplierEmail);
            this.groupBoxSupplierDetails.Controls.Add(this.txtSupplier);
            this.groupBoxSupplierDetails.Controls.Add(this.lblSupplierEmail);
            this.groupBoxSupplierDetails.Controls.Add(this.lblSupplier);
            this.groupBoxSupplierDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxSupplierDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.groupBoxSupplierDetails.Location = new System.Drawing.Point(20, 540);
            this.groupBoxSupplierDetails.Name = "groupBoxSupplierDetails";
            this.groupBoxSupplierDetails.Size = new System.Drawing.Size(420, 130);
            this.groupBoxSupplierDetails.TabIndex = 4;
            this.groupBoxSupplierDetails.TabStop = false;
            this.groupBoxSupplierDetails.Text = "🏢 Supplier Details";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSupplier.Location = new System.Drawing.Point(150, 40);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(250, 25);
            this.txtSupplier.TabIndex = 7;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblSupplier.Location = new System.Drawing.Point(20, 43);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(62, 17);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Supplier:";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSupplierEmail.Location = new System.Drawing.Point(150, 85);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(250, 25);
            this.txtSupplierEmail.TabIndex = 8;
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSupplierEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.lblSupplierEmail.Location = new System.Drawing.Point(20, 88);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(100, 17);
            this.lblSupplierEmail.TabIndex = 1;
            this.lblSupplierEmail.Text = "Supplier Email:";
            // 
            // groupBoxControlPanel
            // 
            this.groupBoxControlPanel.Controls.Add(this.btnClear);
            this.groupBoxControlPanel.Controls.Add(this.btnDelete);
            this.groupBoxControlPanel.Controls.Add(this.btnUpdate);
            this.groupBoxControlPanel.Controls.Add(this.btnRegister);
            this.groupBoxControlPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxControlPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.groupBoxControlPanel.Location = new System.Drawing.Point(460, 540);
            this.groupBoxControlPanel.Name = "groupBoxControlPanel";
            this.groupBoxControlPanel.Size = new System.Drawing.Size(820, 130);
            this.groupBoxControlPanel.TabIndex = 5;
            this.groupBoxControlPanel.TabStop = false;
            this.groupBoxControlPanel.Text = "🎮 Control Panel";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(40, 50);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 50);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "✅ Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(230, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 50);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "🔄 Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(420, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 50);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "❌ Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(10)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnClear.Location = new System.Drawing.Point(610, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 50);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "🗑️ Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 688);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1300, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripStatusTime
            // 
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            this.toolStripStatusTime.Size = new System.Drawing.Size(1246, 17);
            this.toolStripStatusTime.Spring = true;
            this.toolStripStatusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1300, 710);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxControlPanel);
            this.Controls.Add(this.groupBoxSupplierDetails);
            this.Controls.Add(this.groupBoxItemDetails);
            this.Controls.Add(this.groupBoxItemRegistration);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System - Dashboard";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelTotalItems.ResumeLayout(false);
            this.panelTotalItems.PerformLayout();
            this.panelLowStock.ResumeLayout(false);
            this.panelLowStock.PerformLayout();
            this.panelTotalValue.ResumeLayout(false);
            this.panelTotalValue.PerformLayout();
            this.panelCategories.ResumeLayout(false);
            this.panelCategories.PerformLayout();
            this.groupBoxItemRegistration.ResumeLayout(false);
            this.groupBoxItemRegistration.PerformLayout();
            this.groupBoxItemDetails.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.groupBoxSupplierDetails.ResumeLayout(false);
            this.groupBoxSupplierDetails.PerformLayout();
            this.groupBoxControlPanel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel panelTotalItems;
        private System.Windows.Forms.Label lblTotalItemsValue;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Panel panelLowStock;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Panel panelTotalValue;
        private System.Windows.Forms.Label lblTotalValueAmount;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.Label lblCategoriesValue;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.GroupBox groupBoxItemRegistration;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAdded;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox cmbItemCode;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.GroupBox groupBoxItemDetails;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.GroupBox groupBoxSupplierDetails;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.GroupBox groupBoxControlPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
