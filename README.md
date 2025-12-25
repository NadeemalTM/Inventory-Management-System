# 🏢 Inventory Management System
### Professional C# Windows Forms Application with Colorful Dark Theme

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=.net)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Express%202025-CC2927?logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D6?logo=windows)](https://docs.microsoft.com/dotnet/desktop/winforms/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

## 📋 Table of Contents
- [Project Overview](#-project-overview)
- [Features](#-features)
- [Version History](#-version-history)
- [Screenshots](#-screenshots)
- [Technical Stack](#-technical-stack)
- [Database Schema](#-database-schema)
- [Installation Guide](#-installation-guide)
- [Usage Guide](#-usage-guide)
- [Dark Theme Details](#-dark-theme-details)
- [Project Structure](#-project-structure)
- [Security Features](#-security-features)
- [System Requirements](#-system-requirements)
- [Troubleshooting](#-troubleshooting)
- [Future Enhancements](#-future-enhancements)
- [Contributing](#-contributing)
- [License](#-license)
- [Author](#-author)

## 🎯 Project Overview

A **professional-grade Inventory Management System** built with C# Windows Forms, featuring a stunning **colorful dark theme** with vibrant neon accents. This application provides comprehensive inventory tracking, real-time dashboard statistics, advanced search capabilities, and CSV export functionality. Designed for modern businesses requiring efficient stock management with an eye-catching, user-friendly interface.

### Key Highlights
- 🎨 **Stunning Colorful Dark Theme** - Deep navy backgrounds with vibrant purple, blue, pink, green, and yellow accents
- 📊 **Real-Time Dashboard** - Live statistics cards showing total items, low stock alerts, total value, and categories
- 🔐 **Secure Authentication** - SQL Server-based login system with password protection
- 💾 **Complete CRUD Operations** - Create, Read, Update, and Delete inventory records seamlessly
- 🔍 **Advanced Search & Filter** - Multi-field filtering with instant results
- 📤 **CSV Export** - Export inventory data with automatic timestamping
- 💰 **Currency Support** - Displays prices in Indian Rupees (Rs.)
- ⚡ **Low Stock Alerts** - Automatic highlighting of items with quantity below 10
- 📱 **Modern UI/UX** - Sleek, borderless design with smooth hover effects and animations

## ✨ Features

### 1. 🔐 Modern Login System (Dark Theme)
- **Simplified Single-Panel Design**: Centered login panel (550x600px) with deep navy background
- **Custom Branding**: Clean professional login interface
- **Password Visibility Toggle**: Eye icon button to show/hide password (👁/🙈)
- **Remember Me Checkbox**: User convenience feature for persistent login
- **Forgot Password Link**: Display admin contact information
- **Secure Authentication**: SQL Server database validation with parameterized queries
- **Smooth Hover Effects**: Interactive buttons with color transitions
- **Error Handling**: User-friendly error messages for invalid credentials
- **Dark Theme Colors**: 
  - Background: Deep Navy `#12121C` (18, 18, 28)
  - Panel: Dark Purple-Gray `#1E1E2E` (30, 30, 46)
  - Accent: Neon Purple `#BB86FC` (187, 134, 252)
  - Text: Light Gray `#E0E0E0` (224, 224, 224)

**Default Credentials:**
- **Username**: `Admin`
- **Password**: `StockUser123`

### 2. 📊 Inventory Dashboard (Dark Theme)
#### Colorful Real-Time Statistics Cards
- 🔵 **Total Items Card**: Electric Blue `#3A86FF` - Displays total inventory count
- 🔴 **Low Stock Alerts Card**: Hot Pink `#EF476F` - Shows items with quantity < 10
- 🟢 **Total Value Card**: Cyber Green `#06D6A0` - Displays total inventory value in Rs.
- 🟣 **Categories Card**: Neon Purple `#BB86FC` - Shows unique product categories

#### Dark-Themed DataGridView
- **Background**: Dark Purple-Gray `#1E1E2E`
- **Text Color**: Light Gray `#E0E0E0` for maximum readability
- **Header Style**: Blue `#8AB4F8` with bold text
- **Alternating Rows**: Subtle contrast for better data readability
- **Low Stock Highlighting**: Hot pink text on dark maroon background
- **Grid Lines**: Subtle dark lines for clean separation
- **Selection Style**: Electric blue highlight

#### Comprehensive Inventory Management
- ✅ **Register New Items**: Add products with validation
- 🔄 **Update Existing Items**: Modify inventory details
- ❌ **Delete Items**: Remove products with confirmation dialog
- 🗑️ **Clear Form**: Reset all input fields
- 🔍 **Search & Filter**: Multi-field filtering with instant results
- 📤 **CSV Export**: Export data with timestamp (format: `Inventory_yyyyMMdd_HHmmss.csv`)
- 📊 **Auto-Refresh**: Dashboard updates automatically after each operation
- 💰 **Currency Display**: All prices shown in Indian Rupees (Rs.)

#### Colorful Action Buttons
- **Register**: Cyber Green `#06D6A0` - Add new inventory items
- **Update**: Electric Blue `#3A86FF` - Modify existing records
- **Delete**: Hot Pink `#EF476F` - Remove items (with confirmation)
- **Clear**: Bright Yellow `#FFD60A` with dark text - Reset form
- **Export**: Neon Purple `#BB86FC` - Export to CSV
- **Logout**: Soft Blue `#8AB4F8` - Return to login screen

### 3. 🔍 Advanced Search & Filtering
- **ItemCode Dropdown**: Auto-populated with all inventory codes
- **Auto-Fill Form**: Selecting an ItemCode automatically fills all fields
- **Instant DataGridView Update**: Shows selected item details immediately
- **Validation**: Prevents invalid selections and operations

### 4. 📤 CSV Export Functionality
- **One-Click Export**: Export button with purple accent color
- **Automatic Timestamping**: Files saved as `Inventory_20251225_143022.csv`
- **Complete Data Export**: All inventory fields included
- **User Confirmation**: Success message with file path
- **Error Handling**: Graceful error messages if export fails

### 5. ⚠️ Low Stock Alert System
- **Automatic Detection**: Highlights items with quantity < 10
- **Visual Indicators**: Hot pink text on dark maroon background
- **Dashboard Card**: Real-time count of low stock items
- **Threshold Configurable**: Easy to modify in code

## 📜 Version History

### Version 2.2 (Current) - December 25, 2025
- 🧹 **Project Cleanup**: Removed all backup files and unnecessary documentation
- 🎯 **Simplified Login**: Removed decorative left panel, reduced form to 550x600px
- 💰 **Currency Localization**: Changed from $ to Rs. (Indian Rupees)
- 📝 **Streamlined Codebase**: Cleaner project structure with essential files only

### Version 2.1 - December 24, 2025
- 🎨 **Colorful Dark Theme**: Complete UI transformation with vibrant neon accents
- 🌙 **Deep Navy Background**: Primary background `#12121C` throughout
- ✨ **Vibrant Accent Colors**: Purple, Blue, Pink, Green, Yellow highlights
- 📊 **Dark DataGridView**: Sleek table design with high-contrast text
- 🎯 **Color-Coded Buttons**: Each action button has distinct vibrant color
- 📈 **Dashboard Cards**: Colorful statistics cards with live data

### Version 2.0 - December 23, 2025
- 🔐 **Modern Login Page**: Two-panel layout with logo and welcome message
- 👁️ **Show/Hide Password**: Toggle button with eye icons
- ✅ **Remember Me Checkbox**: User convenience feature
- 📊 **Enhanced Dashboard**: Real-time statistics with colorful cards
- 🔍 **Advanced Search**: Multi-field filtering with instant results
- 📤 **CSV Export**: Export inventory data with timestamp
- 🎨 **Professional UI**: Flat design with hover effects

### Version 1.0 - Initial Release
- ✅ Basic login system with SQL Server authentication
- ✅ CRUD operations for inventory management
- ✅ DataGridView for inventory display
- ✅ Basic form validation

## 📸 Screenshots

### Login Screen (Dark Theme)
- **Simplified Clean Design**: Single centered login panel (550x600px)
- **Deep Navy Background**: `#12121C` with purple accents
- **Modern Input Fields**: Rounded borders with hover effects
- **Password Toggle**: Eye icon to show/hide password
- **Professional Branding**: Clean title and subtitle

### Inventory Dashboard (Dark Theme)
- **Colorful Statistics Cards**: Four vibrant cards (Blue, Pink, Green, Purple)
- **Dark DataGridView**: High-contrast table with blue headers
- **Input Forms**: Four organized GroupBoxes (Item Registration, Item Details, Supplier Details, Control Panel)
- **Action Buttons**: Color-coded buttons for easy identification
- **Status Bar**: Dark bar with real-time clock display

## 🛠️ Technical Stack

### Core Technologies
| Component | Technology | Version |
|-----------|-----------|---------|
| **Language** | C# | 5.0 |
| **Framework** | .NET Framework | 4.7.2 |
| **UI Framework** | Windows Forms | WinForms |
| **Database** | Microsoft SQL Server | Express 2025 |
| **Compiler** | Microsoft Visual C# | 4.8.9232.0 |

### Development Tools
| Tool | Purpose |
|------|---------|
| **Visual Studio** | Primary IDE / Code Editor |
| **Command Line Compiler** | Alternative compilation method |
| **SQL Server Management Studio** | Database management and query execution |
| **Git/GitHub** | Version control and repository hosting |
| **PowerShell** | Build automation and scripting |

### Architecture Pattern
- **Design Pattern**: Two-Tier Architecture (Presentation Layer + Data Layer)
- **UI Pattern**: Windows Forms with manual designer code
- **Data Access**: ADO.NET with SqlConnection, SqlCommand, SqlDataAdapter
- **Security**: Parameterized SQL queries to prevent SQL injection

## 🗄️ Database Schema

### Database: `InventoryDB`

#### **Logins Table**
Stores user authentication credentials.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| `Username` | VARCHAR(50) | PRIMARY KEY | Unique username for login |
| `Password` | VARCHAR(50) | NOT NULL | User password (plain text for demo) |

**Sample Data:**
```sql
Username: 'Admin'
Password: 'StockUser123'
```

#### **Inventory Table**
Stores complete product inventory information.

| Column Name | Data Type | Constraints | Description |
|-------------|-----------|-------------|-------------|
| `ItemCode` | INT | PRIMARY KEY | Unique item identifier |
| `ItemName` | VARCHAR(100) | NOT NULL | Product name |
| `Category` | VARCHAR(50) | NOT NULL | Product category (Electronics, Clothing, etc.) |
| `Quantity` | INT | NOT NULL | Current stock quantity |
| `UnitPrice` | DECIMAL(18,2) | NOT NULL | Price per unit in Rupees |
| `Supplier` | VARCHAR(100) | NOT NULL | Supplier name |
| `DateAdded` | DATE | NOT NULL | Date item was added to inventory |

**Sample Data:**
```sql
ItemCode: 101
ItemName: 'Laptop'
Category: 'Electronics'
Quantity: 15
UnitPrice: 45000.00
Supplier: 'TechWorld Suppliers'
DateAdded: '2024-01-15'
```

### Database Relationships
- No foreign key relationships (simple two-table design)
- Both tables are independent
- `Logins` table handles authentication
- `Inventory` table manages stock data

### Low Stock Threshold
- Items with `Quantity < 10` are automatically highlighted in hot pink
- Low stock count displayed on dashboard alert card

## 🚀 Installation Guide

### Prerequisites
Before installing, ensure you have:
- ✅ Windows 10/11 (64-bit recommended)
- ✅ .NET Framework 4.7.2 or later
- ✅ Microsoft SQL Server (Express Edition is sufficient)
- ✅ SQL Server Management Studio (SSMS) - Optional but recommended
- ✅ Git (for cloning repository)

### Step-by-Step Installation

#### **Step 1: Clone the Repository**
```bash
git clone https://github.com/NadeemalTM/Inventory-Management-System.git
cd Inventory-Management-System
```

Or download ZIP file from GitHub and extract it.

#### **Step 2: Set Up SQL Server Database**

**Option A: Using SQL Server Management Studio (SSMS)**
1. Open **SQL Server Management Studio**
2. Connect to your SQL Server instance
   - Server Name: `localhost` or `localhost\SQLEXPRESS` (for Express edition)
   - Authentication: Windows Authentication (recommended)
3. Open the `DatabaseSetup.sql` file from the project folder
4. Click **Execute** (F5) to run the script
5. Verify the database was created:
   - Expand **Databases** in Object Explorer
   - You should see **InventoryDB**
   - Expand **InventoryDB** → **Tables**
   - You should see **Logins** and **Inventory** tables

**Option B: Using Command Line (sqlcmd)**
```bash
sqlcmd -S localhost\SQLEXPRESS -E -i DatabaseSetup.sql
```

**Verify Database Creation:**
```bash
sqlcmd -S localhost\SQLEXPRESS -E -d InventoryDB -Q "SELECT * FROM Logins; SELECT * FROM Inventory;"
```

#### **Step 3: Configure Connection String**
The application connects to SQL Server using a connection string. By default, it uses:
```
Data Source=DESKTOP-GR89OKG\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True
```

**To customize for your system:**

1. Open `LoginForm.cs`
2. Find line with `connectionString` variable (around line 13)
3. Update the connection string:

**For local SQL Server Express with Windows Authentication:**
```csharp
private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True";
```

**For SQL Server with SQL Authentication:**
```csharp
private string connectionString = @"Data Source=localhost;Initial Catalog=InventoryDB;User Id=YourUsername;Password=YourPassword";
```

**For named SQL Server instance:**
```csharp
private string connectionString = @"Data Source=YOUR_PC_NAME\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True";
```

4. Repeat the same changes in `InventoryForm.cs` (around line 17)

#### **Step 4: Build the Application**

**Option A: Using Visual Studio**
1. Double-click `InventoryManagementSystem.csproj` to open in Visual Studio
2. Go to **Build** → **Build Solution** (Ctrl+Shift+B)
3. Wait for build to complete (check Output window)
4. Run the application by pressing **F5** or clicking **Start**

**Option B: Using Command Line Compiler**
```bash
# Navigate to project directory
cd "path\to\Inventory-Management-System"

# Compile the application
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /target:winexe /out:InventoryManagementSystem.exe /reference:System.dll /reference:System.Data.dll /reference:System.Windows.Forms.dll /reference:System.Drawing.dll Program.cs LoginForm.cs LoginForm.Designer.cs InventoryForm.cs InventoryForm.Designer.cs "Properties\AssemblyInfo.cs" "Properties\Resources.Designer.cs" "Properties\Settings.Designer.cs"

# Run the application
.\InventoryManagementSystem.exe
```

**Option C: Quick Build PowerShell Script**
```powershell
# Save this as build.ps1 in the project root
$compiler = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe"
$output = "InventoryManagementSystem.exe"
$sources = @(
    "Program.cs",
    "LoginForm.cs",
    "LoginForm.Designer.cs",
    "InventoryForm.cs",
    "InventoryForm.Designer.cs",
    "Properties\AssemblyInfo.cs",
    "Properties\Resources.Designer.cs",
    "Properties\Settings.Designer.cs"
)

& $compiler /target:winexe /out:$output `
    /reference:System.dll `
    /reference:System.Data.dll `
    /reference:System.Windows.Forms.dll `
    /reference:System.Drawing.dll `
    /nologo $sources

if ($LASTEXITCODE -eq 0) {
    Write-Host "Build successful!" -ForegroundColor Green
    Start-Process $output
} else {
    Write-Host "Build failed!" -ForegroundColor Red
}
```

Run with: `.\build.ps1`

#### **Step 5: First Run**
1. Launch `InventoryManagementSystem.exe`
2. You should see the dark-themed login screen
3. Enter default credentials:
   - **Username**: `Admin`
   - **Password**: `StockUser123`
4. Click **Login**
5. You should now see the Inventory Dashboard with sample data

### Troubleshooting Installation

#### ❌ "Login failed for user" Error
**Solution:**
- Verify SQL Server is running: Open **Services** (services.msc) → Find **SQL Server (SQLEXPRESS)** → Ensure it's **Running**
- Check connection string matches your SQL Server instance name
- Try using Windows Authentication (`Integrated Security=True`)

#### ❌ "Cannot open database" Error
**Solution:**
- Verify `DatabaseSetup.sql` was executed successfully
- Check if **InventoryDB** exists in SQL Server Management Studio
- Re-run the database setup script

#### ❌ "The application failed to initialize properly" Error
**Solution:**
- Install .NET Framework 4.7.2 or later
- Download from: https://dotnet.microsoft.com/download/dotnet-framework

#### ❌ Compiler not found (csc.exe)
**Solution:**
- Install .NET Framework Developer Pack 4.7.2
- Or use Visual Studio to build the project

#### ❌ "Could not load file or assembly" Error
**Solution:**
- Ensure all DLL references are correct
- Rebuild the solution in Visual Studio
- Check that System.Data.dll, System.Windows.Forms.dll, System.Drawing.dll are referenced

## 📖 Usage Guide

### 🔐 Logging In

1. **Launch the Application**
   - Double-click `InventoryManagementSystem.exe`
   - The dark-themed login screen will appear

2. **Enter Credentials**
   - **Username**: `Admin` (case-sensitive)
   - **Password**: `StockUser123`

3. **Additional Options**
   - ☑️ **Remember Me**: Check this box to stay logged in (functionality placeholder)
   - 🔗 **Forgot Password?**: Click to see admin contact info

4. **Login**
   - Click the **Login** button or press **Enter**
   - If credentials are correct, you'll be taken to the Inventory Dashboard
   - If incorrect, an error message will display

5. **Password Visibility**
   - Click the **eye icon** (👁️) to toggle password visibility
   - Click again to hide the password

### 📊 Dashboard Overview

Upon successful login, you'll see:

**Top Section - Statistics Cards** (Auto-updating)
- 🔵 **Total Items**: Total number of products in inventory
- 🔴 **Low Stock Alerts**: Items with quantity below 10
- 🟢 **Total Value**: Combined value of all inventory (Rs.)
- 🟣 **Categories**: Number of unique product categories

**Middle Section - Input Forms** (Four GroupBoxes)
- **Item Registration**: ItemCode dropdown
- **Item Details**: ItemName, Category, Quantity fields
- **Supplier Details**: Supplier name, UnitPrice fields
- **Control Panel**: DateAdded picker and action buttons

**Bottom Section - DataGridView**
- Displays all inventory items in a dark-themed table
- Columns: ItemCode, ItemName, Category, Quantity, UnitPrice (Rs.), Supplier, DateAdded
- Low stock items highlighted in hot pink

**Status Bar**
- Bottom bar showing current date and time

### ➕ Adding New Items

1. **Enter ItemCode**
   - Type a unique numeric ItemCode (e.g., 105)
   - Must not already exist in database

2. **Fill in Item Details**
   - **ItemName**: Product name (e.g., "Wireless Mouse")
   - **Category**: Product category (e.g., "Electronics")
   - **Quantity**: Stock quantity (numeric, e.g., 50)

3. **Enter Supplier Information**
   - **Supplier**: Supplier name (e.g., "TechSupply Co.")
   - **UnitPrice**: Price per unit in Rupees (e.g., 599.00)
   - **DateAdded**: Select date from calendar picker

4. **Register Item**
   - Click the green **Register** button
   - Success message will appear
   - Dashboard and DataGridView will auto-update
   - Form will clear for next entry

**Validation Rules:**
- All fields are required
- ItemCode must be unique
- Quantity must be a positive integer
- UnitPrice must be a valid decimal number

### ✏️ Updating Existing Items

1. **Select Item**
   - Open the **ItemCode** dropdown in "Item Registration" GroupBox
   - Select the ItemCode you want to update
   - All fields will auto-populate with current data

2. **Modify Fields**
   - Change any field except ItemCode (primary key)
   - Update ItemName, Category, Quantity, UnitPrice, Supplier, or DateAdded

3. **Save Changes**
   - Click the blue **Update** button
   - Confirm the update in the popup dialog
   - Success message will appear
   - DataGridView and dashboard will refresh

### 🗑️ Deleting Items

1. **Select Item**
   - Open the **ItemCode** dropdown
   - Select the item you want to delete
   - Fields will auto-populate to show what will be deleted

2. **Delete Item**
   - Click the pink **Delete** button
   - Confirmation dialog will appear: "Are you sure you want to delete this item?"
   - Click **Yes** to confirm deletion
   - Click **No** to cancel

3. **Result**
   - Success message appears
   - Item removed from DataGridView and database
   - Dashboard statistics update
   - Form clears

### 🔍 Searching & Filtering

**Quick Search:**
1. Open the **ItemCode** dropdown
2. Select any ItemCode
3. All related fields populate instantly
4. DataGridView highlights the selected item

**Manual Filtering:**
- Type in any search field
- DataGridView updates in real-time
- Shows matching records

### 📤 Exporting to CSV

1. **Export Data**
   - Click the purple **Export to CSV** button
   - File save dialog will appear

2. **Choose Location**
   - Select where to save the file
   - Default name: `Inventory_YYYYMMDD_HHmmss.csv`
   - Example: `Inventory_20251225_143052.csv`

3. **File Format**
   - CSV file with headers
   - Columns: ItemCode, ItemName, Category, Quantity, UnitPrice, Supplier, DateAdded
   - Compatible with Excel, Google Sheets, etc.

### 🧹 Clearing the Form

- Click the yellow **Clear** button
- All input fields reset to empty
- DataGridView remains unchanged
- Useful for starting a fresh entry

### 🚪 Logging Out

- Click the **Logout** link in the top-right corner
- Returns to login screen
- Database connection closes
- All forms reset

## 🎨 Dark Theme Details

### Color Palette

The application uses a carefully crafted dark theme with vibrant neon accents:

#### Primary Colors
| Color Name | Hex Code | RGB | Usage |
|------------|----------|-----|-------|
| **Deep Navy** | `#12121C` | (18, 18, 28) | Primary background, form background |
| **Dark Purple-Gray** | `#1E1E2E` | (30, 30, 46) | Secondary background, panels, DataGridView |
| **Neon Purple** | `#BB86FC` | (187, 134, 252) | Primary accent, buttons, headers |

#### Accent Colors
| Color Name | Hex Code | RGB | Usage |
|------------|----------|-----|-------|
| **Electric Blue** | `#3A86FF` | (58, 134, 255) | Total Items card, Update button |
| **Hot Pink** | `#EF476F` | (239, 71, 111) | Low Stock card, Delete button, alerts |
| **Cyber Green** | `#06D6A0` | (6, 214, 160) | Total Value card, Register button |
| **Bright Yellow** | `#FFD60A` | (255, 214, 10) | Clear button (with dark text) |

#### Text Colors
| Color Name | Hex Code | RGB | Usage |
|------------|----------|-----|-------|
| **Light Gray** | `#E0E0E0` | (224, 224, 224) | Primary text, labels, DataGridView text |
| **Accent Blue** | `#8AB4F8` | (138, 180, 248) | Links, secondary text, DataGridView headers |
| **Secondary Gray** | `#B0BEC5` | (176, 190, 197) | Disabled text, placeholders |

### Low Stock Alert Colors
| Element | Background | Foreground |
|---------|------------|------------|
| **Low Stock Row** | `#3D1F1F` (Dark Maroon) | `#EF476F` (Hot Pink) |

### Button Color Coding
Each action button has a distinct color for easy identification:
- **Green** = Create/Add (Register)
- **Blue** = Update/Edit
- **Pink** = Delete/Remove
- **Yellow** = Clear/Reset
- **Purple** = Export/Special Action

### Design Philosophy
- **High Contrast**: Light text on dark backgrounds for maximum readability
- **Reduced Eye Strain**: Dark backgrounds reduce blue light emission
- **Color Psychology**: Each color chosen for its psychological association with the action
- **Modern Aesthetic**: Inspired by modern gaming UIs and tech interfaces
- **Accessibility**: Vibrant colors ensure visibility for most users

### Theme Implementation
The dark theme is implemented via the `SetupDarkTheme()` method in `InventoryForm.cs`:
```csharp
private void SetupDarkTheme()
{
    Color bgDark = Color.FromArgb(18, 18, 28);      // Deep Navy
    Color bgPanel = Color.FromArgb(30, 30, 46);     // Dark Purple-Gray
    Color textLight = Color.FromArgb(224, 224, 224); // Light Gray
    // ... theme application code
}
```

For complete theme implementation details, see [DARK_THEME_GUIDE.md](DARK_THEME_GUIDE.md).

For complete theme implementation details, see [DARK_THEME_GUIDE.md](DARK_THEME_GUIDE.md).

## 📁 Project Structure

```
Inventory-Management-System/
│
├── 📄 Program.cs                          # Application entry point (Main method)
├── 🔐 LoginForm.cs                        # Login form logic and event handlers
├── 🔐 LoginForm.Designer.cs               # Login form UI design (auto-generated)
├── 🔐 LoginForm.resx                      # Login form resources
├── 📊 InventoryForm.cs                    # Inventory management logic
├── 📊 InventoryForm.Designer.cs           # Inventory form UI design
├── 📊 InventoryForm.resx                  # Inventory form resources
│
├── 🗄️ DatabaseSetup.sql                   # SQL script for database creation
├── ⚙️ App.config                          # Application configuration file
├── 📦 InventoryManagementSystem.csproj    # Visual Studio project file
├── 📘 README.md                           # This comprehensive documentation
├── 🎨 DARK_THEME_GUIDE.md                 # Detailed dark theme implementation guide
│
├── 📂 Properties/
│   ├── AssemblyInfo.cs                   # Assembly metadata and version info
│   ├── Resources.resx                    # Application-wide resources
│   ├── Resources.Designer.cs             # Generated resource accessor code
│   ├── Settings.settings                 # Application settings configuration
│   └── Settings.Designer.cs              # Generated settings accessor code
│
├── 🚀 InventoryManagementSystem.exe       # Compiled executable (after build)
└── 📂 .git/                               # Git version control directory
```

### File Descriptions

#### Core Application Files
- **Program.cs** (Entry Point)
  - Contains `Main()` method that starts the application
  - Initializes Windows Forms
  - Sets `LoginForm` as the startup form
  - Enables visual styles and text rendering

- **LoginForm.cs** (Login Logic)
  - Handles user authentication against SQL Server database
  - Password visibility toggle functionality
  - Remember Me checkbox handler
  - Form validation and error handling
  - Navigates to InventoryForm on successful login

- **LoginForm.Designer.cs** (Login UI)
  - Auto-generated UI code for login form
  - Defines all controls: TextBoxes, Buttons, Labels, etc.
  - Sets dark theme colors and layout
  - 550x600px borderless form design

- **InventoryForm.cs** (Inventory Logic)
  - CRUD operations: Register, Update, Delete inventory items
  - Dashboard statistics calculation (Total Items, Low Stock, Total Value, Categories)
  - DataGridView population and refresh
  - CSV export functionality with timestamp
  - Low stock item highlighting (<10 quantity)
  - Dark theme setup via `SetupDarkTheme()` method
  - Input validation and error handling

- **InventoryForm.Designer.cs** (Inventory UI)
  - Auto-generated UI code for inventory dashboard
  - Four GroupBoxes for organized input
  - DataGridView for inventory display
  - Colorful dashboard cards
  - Action buttons with color coding
  - Status bar with real-time clock

#### Database Script
- **DatabaseSetup.sql**
  - Creates `InventoryDB` database
  - Creates `Logins` table with default admin credentials
  - Creates `Inventory` table with proper schema
  - Inserts sample inventory data (4 items)
  - Sets up PRIMARY KEY constraints

#### Configuration Files
- **App.config**
  - .NET Framework configuration
  - Startup settings
  - Runtime version bindings

- **InventoryManagementSystem.csproj**
  - Visual Studio project file
  - Defines build configuration
  - Lists all source files and references
  - Specifies target framework (.NET 4.7.2)

#### Properties Folder
- **AssemblyInfo.cs**
  - Application metadata (title, description, version)
  - Company and product information
  - Copyright notice
  - Assembly version: 1.0.0.0

- **Resources.resx**
  - Embedded resources (images, icons, strings)
  - Localization support structure

- **Settings.settings**
  - Application settings storage
  - User preferences
  - Connection strings (optional)

### Code Organization

#### Login Form Architecture
```
LoginForm
├── Authentication Logic
│   ├── ValidateCredentials() - SQL Server query
│   ├── btnLogin_Click() - Login button handler
│   └── Error handling with MessageBox
├── UI Events
│   ├── btnShowPassword_Click() - Toggle password visibility
│   ├── lblForgotPassword_Click() - Show admin contact
│   └── btnClose_Click() - Exit application
└── Form Initialization
    ├── InitializeComponent() - UI setup
    └── Dark theme colors applied
```

#### Inventory Form Architecture
```
InventoryForm
├── Dashboard Module
│   ├── LoadDashboardData() - Calculate statistics
│   ├── UpdateTotalItemsCard() - Total count
│   ├── UpdateLowStockCard() - Items with qty < 10
│   ├── UpdateTotalValueCard() - Sum of (qty * price)
│   └── UpdateCategoriesCard() - Distinct categories count
├── CRUD Operations
│   ├── btnRegister_Click() - Insert new item (INSERT)
│   ├── btnUpdate_Click() - Modify existing item (UPDATE)
│   ├── btnDelete_Click() - Remove item (DELETE)
│   └── btnClear_Click() - Reset form fields
├── Data Display
│   ├── LoadInventoryData() - Populate DataGridView (SELECT)
│   ├── cmbItemCode_SelectedIndexChanged() - Auto-fill form
│   └── HighlightLowStockItems() - Apply pink highlighting
├── Utilities
│   ├── btnExport_Click() - Export to CSV
│   ├── SetupDarkTheme() - Apply dark colors
│   ├── timer1_Tick() - Update status bar clock
│   └── lnkLogout_LinkClicked() - Return to login
└── Form Initialization
    ├── InitializeComponent() - UI setup
    ├── LoadComboBoxData() - Populate ItemCode dropdown
    └── LoadInventoryData() - Initial DataGridView load
```

### Database Connection Architecture
```
Application Layer (Windows Forms)
        ↓
ADO.NET Components
        ↓
    SqlConnection → Opens connection to SQL Server
        ↓
    SqlCommand → Executes SQL queries (parameterized)
        ↓
    SqlDataAdapter → Fills DataTable with query results
        ↓
    DataTable → Binds to DataGridView for display
        ↓
SQL Server Database (InventoryDB)
    ├── Logins Table (Authentication)
    └── Inventory Table (Product Data)
```

## 🔒 Security Features

### 1. SQL Injection Prevention
- **Parameterized Queries**: All SQL queries use `SqlParameter` objects
- **No String Concatenation**: User input never directly concatenated into SQL strings

Example:
```csharp
// ❌ VULNERABLE (Never do this)
string query = "SELECT * FROM Logins WHERE Username='" + username + "'";

// ✅ SECURE (Always use parameters)
string query = "SELECT * FROM Logins WHERE Username=@Username";
SqlCommand cmd = new SqlCommand(query, conn);
cmd.Parameters.AddWithValue("@Username", username);
```

### 2. Password Security
- **Masked Input**: Password field uses `PasswordChar = '*'`
- **Toggle Visibility**: Optional show/hide password button
- **Note**: Current implementation stores plain text passwords (for educational purposes only)

**⚠️ Production Recommendation:**
- Hash passwords using BCrypt, Argon2, or PBKDF2
- Never store plain text passwords in production databases
- Implement password strength requirements
- Add salt to password hashes

### 3. Input Validation
- **Type Checking**: Quantity and UnitPrice validated as numbers
- **Required Fields**: All fields checked before database operations
- **Duplicate Prevention**: ItemCode uniqueness enforced by PRIMARY KEY
- **Error Handling**: Try-catch blocks around all database operations

### 4. User Confirmation
- **Delete Operations**: Confirmation dialog before deletion
- **Update Operations**: Confirmation dialog before modifications
- **Exit Application**: Confirmation when closing

### 5. Connection Security
- **Windows Authentication**: Recommended over SQL authentication
- **Connection Pooling**: Automatic connection management
- **Proper Disposal**: Connections closed in `finally` blocks or using statements

### 6. Error Handling
- **User-Friendly Messages**: Technical errors not exposed to users
- **Logging**: Errors displayed via MessageBox (extend for file logging)
- **Graceful Degradation**: Application continues running after errors

## 💻 System Requirements

### Minimum Requirements
| Component | Requirement |
|-----------|-------------|
| **Operating System** | Windows 7 SP1 or later (32-bit/64-bit) |
| **.NET Framework** | 4.7.2 or later |
| **Processor** | 1 GHz or faster |
| **RAM** | 512 MB (1 GB recommended) |
| **Hard Disk Space** | 50 MB for application + 100 MB for SQL Server |
| **Display** | 1024x768 resolution, 16-bit color |
| **SQL Server** | Express 2012 or later |

### Recommended Requirements
| Component | Recommendation |
|-----------|----------------|
| **Operating System** | Windows 10/11 (64-bit) |
| **.NET Framework** | 4.8 |
| **Processor** | Multi-core 2 GHz or faster |
| **RAM** | 4 GB or more |
| **Hard Disk Space** | 500 MB free space |
| **Display** | 1920x1080 resolution, 32-bit color (for optimal dark theme) |
| **SQL Server** | Express 2019/2022/2025 |

### Software Dependencies
- **Required:**
  - .NET Framework 4.7.2 Runtime
  - SQL Server (any edition: Express, Standard, Enterprise)
  - Windows authentication or SQL Server authentication configured

- **Optional:**
  - Visual Studio 2017 or later (for development)
  - SQL Server Management Studio (for database management)
  - Git (for version control)

### Network Requirements
- No internet connection required (fully offline application)
- Local network access only if SQL Server is on a different machine

## 🔧 Troubleshooting

### Common Issues and Solutions

#### 🔴 Login Issues

**Problem:** "Login failed for user" or "Cannot open database"
**Solutions:**
1. Verify SQL Server is running:
   ```powershell
   Get-Service | Where-Object {$_.Name -like "*SQL*"}
   ```
2. Check connection string matches your SQL Server instance name
3. Ensure Windows Authentication is enabled in SQL Server
4. Verify InventoryDB database exists:
   ```sql
   sqlcmd -S localhost\SQLEXPRESS -E -Q "SELECT name FROM sys.databases"
   ```

**Problem:** "Invalid username or password"
**Solutions:**
1. Verify credentials: Username = `Admin`, Password = `StockUser123` (case-sensitive)
2. Check Logins table has the admin user:
   ```sql
   sqlcmd -S localhost\SQLEXPRESS -E -d InventoryDB -Q "SELECT * FROM Logins"
   ```
3. Re-run DatabaseSetup.sql if needed

#### 🔴 Database Connection Issues

**Problem:** "A network-related or instance-specific error occurred"
**Solutions:**
1. Verify SQL Server service is running:
   - Open Services (services.msc)
   - Find "SQL Server (SQLEXPRESS)" or "SQL Server (MSSQLSERVER)"
   - Ensure Status = "Running"
2. Enable TCP/IP protocol:
   - Open SQL Server Configuration Manager
   - SQL Server Network Configuration → Protocols
   - Enable TCP/IP protocol
   - Restart SQL Server service
3. Check firewall settings (if accessing remote SQL Server)

**Problem:** "Timeout expired" error
**Solutions:**
1. Increase connection timeout in connection string:
   ```csharp
   connectionString += ";Connect Timeout=30";
   ```
2. Check SQL Server is not overloaded
3. Verify network connectivity to SQL Server

#### 🔴 Data Issues

**Problem:** "Violation of PRIMARY KEY constraint"
**Solutions:**
- ItemCode must be unique
- Choose a different ItemCode that doesn't exist
- Check existing ItemCodes in the dropdown or DataGridView

**Problem:** "Cannot insert NULL value" error
**Solutions:**
- All fields are required in the Inventory table
- Ensure all TextBoxes and ComboBoxes have values
- Check DateTimePicker has a valid date selected

**Problem:** DataGridView not displaying data
**Solutions:**
1. Verify Inventory table has data:
   ```sql
   sqlcmd -S localhost\SQLEXPRESS -E -d InventoryDB -Q "SELECT * FROM Inventory"
   ```
2. Check for errors in `LoadInventoryData()` method
3. Verify connection string is correct
4. Try clicking "Clear" button to refresh

#### 🔴 UI/Display Issues

**Problem:** Dark theme colors not showing correctly
**Solutions:**
1. Ensure display is set to at least 16-bit color
2. Update graphics drivers
3. Check Windows high contrast mode is disabled
4. Verify `SetupDarkTheme()` method is being called in InventoryForm constructor

**Problem:** Buttons or controls not responding
**Solutions:**
1. Check for modal dialogs in the background
2. Verify event handlers are properly attached in Designer.cs
3. Try restarting the application
4. Check for exceptions in try-catch blocks

**Problem:** Form appears off-screen or wrong size
**Solutions:**
1. LoginForm size is 550x600, InventoryForm size varies (check Designer.cs)
2. Check `StartPosition = CenterScreen` in form properties
3. Reset form location:
   ```csharp
   this.StartPosition = FormStartPosition.CenterScreen;
   ```

#### 🔴 Build/Compilation Issues

**Problem:** "The name 'XYZ' does not exist in the current context"
**Solutions:**
1. Verify all using statements are present:
   ```csharp
   using System;
   using System.Data;
   using System.Data.SqlClient;
   using System.Windows.Forms;
   using System.Drawing;
   ```
2. Check references are added (System.Data.dll, System.Windows.Forms.dll, etc.)
3. Rebuild solution (Ctrl+Shift+B in Visual Studio)

**Problem:** "Could not find file or assembly" error
**Solutions:**
1. Clean and rebuild solution
2. Delete bin/ and obj/ folders
3. Verify .NET Framework 4.7.2 is installed
4. Check all .cs files are included in the project

**Problem:** Command line compilation fails
**Solutions:**
1. Verify csc.exe path is correct:
   ```
   C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe
   ```
2. Ensure all source files are listed in the command
3. Check file paths don't contain special characters
4. Use quotes around paths with spaces

#### 🔴 Export Issues

**Problem:** CSV export fails or file is empty
**Solutions:**
1. Verify write permissions to the target directory
2. Close the CSV file if it's open in Excel
3. Check DataGridView has data before exporting
4. Ensure file path doesn't contain invalid characters

**Problem:** CSV file doesn't open correctly in Excel
**Solutions:**
1. Save with proper CSV format (comma-separated)
2. Use Excel's "Text Import Wizard"
3. Verify commas in data are properly escaped

### Debug Mode

To enable detailed error messages for debugging:

1. Open `InventoryForm.cs` or `LoginForm.cs`
2. Modify exception handling:
```csharp
catch (Exception ex)
{
    // Show detailed error (for debugging only)
    MessageBox.Show($"Error: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", 
                    "Debug Info", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
}
```

### Getting Help

If you encounter issues not covered here:
1. Check the code comments in each .cs file
2. Review [DARK_THEME_GUIDE.md](DARK_THEME_GUIDE.md) for theme-specific issues
3. Verify DatabaseSetup.sql was executed successfully
4. Check SQL Server error logs:
   - Location: `C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Log\ERRORLOG`
5. Enable SQL Server logging for connection issues

## 🚀 Future Enhancements

### Planned Features
- [ ] **User Management System**
  - Multi-user support with roles (Admin, Manager, Viewer)
  - User registration and password reset functionality
  - Activity logging and audit trails

- [ ] **Enhanced Security**
  - Password hashing with BCrypt/Argon2
  - Session management and auto-logout
  - Two-factor authentication (2FA)
  - Role-based access control (RBAC)

- [ ] **Advanced Inventory Features**
  - Barcode scanning integration
  - Product images upload and display
  - Batch import/export (Excel, CSV, JSON)
  - Inventory tracking by location/warehouse
  - Stock movement history
  - Reorder point notifications
  - Automated purchase order generation

- [ ] **Reporting & Analytics**
  - Sales reports with charts
  - Inventory turnover analysis
  - Profit/loss calculations
  - Trend analysis and forecasting
  - PDF report generation
  - Email report scheduling

- [ ] **UI/UX Improvements**
  - Additional theme options (Light theme, High contrast)
  - Customizable dashboard cards
  - Drag-and-drop interface
  - Keyboard shortcuts
  - Responsive resizing
  - Multi-language support (localization)

- [ ] **Database Enhancements**
  - SQL Server stored procedures
  - Database backup/restore functionality
  - Data encryption at rest
  - Full-text search capability
  - Database migration tools

- [ ] **Integration & APIs**
  - REST API for mobile app integration
  - Email notifications (low stock alerts)
  - SMS notifications
  - Integration with accounting software
  - Cloud backup support

- [ ] **Performance Optimizations**
  - Lazy loading for large datasets
  - Pagination in DataGridView
  - Caching frequently accessed data
  - Asynchronous database operations
  - Connection pooling optimization

### Contribution Ideas
- Add unit tests (NUnit, xUnit)
- Implement design patterns (Repository, Factory)
- Create installer using WiX or InstallShield
- Develop mobile companion app (Xamarin, MAUI)
- Add real-time notifications using SignalR
- Implement print functionality for reports

## 🤝 Contributing

Contributions are welcome! If you'd like to improve this project:

1. **Fork the Repository**
   ```bash
   git clone https://github.com/NadeemalTM/Inventory-Management-System.git
   cd Inventory-Management-System
   ```

2. **Create a Feature Branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make Your Changes**
   - Follow existing code style
   - Add comments for complex logic
   - Test thoroughly before committing

4. **Commit Your Changes**
   ```bash
   git add .
   git commit -m "Add: Brief description of your changes"
   ```

5. **Push to Your Fork**
   ```bash
   git push origin feature/your-feature-name
   ```

6. **Create a Pull Request**
   - Go to the original repository on GitHub
   - Click "New Pull Request"
   - Describe your changes in detail

### Coding Standards
- Use meaningful variable and method names
- Follow C# naming conventions (PascalCase for methods, camelCase for variables)
- Add XML documentation comments for public methods
- Keep methods focused and under 50 lines when possible
- Use try-catch blocks for error-prone operations

### Testing Guidelines
- Test all CRUD operations after changes
- Verify dark theme applies correctly
- Test with different screen resolutions
- Check database connection with various configurations
- Test edge cases (empty fields, invalid input, SQL injection attempts)

## 📄 License

This project is licensed under the **MIT License**.

```
MIT License

Copyright (c) 2025 Inventory Management System

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

## 👤 Author

**Nadeemal TM**
- GitHub: [@NadeemalTM](https://github.com/NadeemalTM)
- Repository: [Inventory-Management-System](https://github.com/NadeemalTM/Inventory-Management-System)

## 🙏 Acknowledgments

- **Microsoft** - For .NET Framework and SQL Server
- **C# Community** - For extensive documentation and support
- **Windows Forms** - For the UI framework
- **Dark Theme Inspiration** - Modern gaming and tech interfaces

## 📞 Support

For questions, issues, or suggestions:
- 📧 Create an issue on GitHub
- 📝 Submit a pull request with improvements
- ⭐ Star the repository if you find it useful!

---

### 📊 Project Statistics

- **Total Lines of Code**: ~3,500 lines
- **Languages**: C# (100%)
- **Files**: 14 source files
- **Database Tables**: 2 (Logins, Inventory)
- **Forms**: 2 (LoginForm, InventoryForm)
- **Version**: 2.2
- **Last Updated**: December 25, 2025

---

### 🎯 Quick Links

- [Installation Guide](#-installation-guide)
- [Usage Guide](#-usage-guide)
- [Dark Theme Guide](DARK_THEME_GUIDE.md)
- [DatabaseSetup.sql](DatabaseSetup.sql)
- [Troubleshooting](#-troubleshooting)
- [Contributing](#-contributing)

---

**⭐ If you found this project helpful, please consider giving it a star on GitHub!**

**🔗 Repository**: https://github.com/NadeemalTM/Inventory-Management-System

---

*Built with ❤️ using C# and Windows Forms | December 2025*
1. Open **SQL Server Management Studio (SSMS)**
