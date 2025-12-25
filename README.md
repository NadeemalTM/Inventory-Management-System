# Inventory Management System - C# Windows Forms Application

## Project Overview
This is a complete Windows Forms Application for Inventory Management built using C#, .NET Framework, and Microsoft SQL Server. Version 2.1 features a stunning colorful dark theme with vibrant accents and modern professional appearance.

## Version 2.1 - Colorful Dark Theme 🌙
- **🎨 Stunning Dark UI**: Deep navy backgrounds with vibrant neon accents
- **✨ Vibrant Colors**: Purple, Blue, Pink, Green, and Yellow highlights
- **🌟 Modern Aesthetic**: Gaming/tech-inspired professional look
- **👁️ Reduced Eye Strain**: Perfect for long work sessions
- **🎯 Color-Coded Actions**: Each button has distinct vibrant color
- **📊 Dark DataGridView**: Sleek table with high-contrast text

## Previous Features (v2.0)
- **Modern Login Page**: Two-panel layout with show/hide password, remember me
- **Enhanced Dashboard**: Real-time statistics with colorful cards
- **Advanced Search**: Multi-field filtering with instant results
- **CSV Export**: Export inventory data with timestamp
- **Professional UI**: Flat design with hover effects

## Technical Stack
- **Language**: C# (.NET Framework 4.7.2)
- **UI Framework**: Windows Forms (WinForms)
- **Database**: Microsoft SQL Server Express 2025
- **IDE**: Visual Studio / Command Line Compiler
- **Database Management**: SQL Server Management Studio (SSMS)
- **Version Control**: Git/GitHub
- **Theme**: Custom Colorful Dark Theme

## Features

### 1. Modern Login System 🔐 (Dark Theme)
- **Two-Panel Design**: Dark purple panel with deep navy login panel
- **Custom Logo**: Purple-to-green gradient circular logo (IMS badge)
- **Show/Hide Password**: Toggle button with eye/hide icons (👁/🙈)
- **Remember Me**: Checkbox for user convenience
- **Forgot Password**: Link with admin contact information
- **Secure Authentication**: SQL Server database validation
- **Hover Effects**: Interactive buttons with smooth color transitions
- **Dark Theme**: Deep navy `#12121C` with purple accents `#BB86FC`
- **Borderless Form**: Modern 900x600px design
- Default Admin credentials: Username = `Admin`, Password = `StockUser123`

### 2. Inventory Management Dashboard 📊 (Dark Theme)
- **Colorful Dashboard Cards**:
  - 🔵 **Total Items**: Electric Blue `#3A86FF`
  - 🔴 **Low Stock Alerts**: Hot Pink `#EF476F`
  - 🟢 **Total Value**: Cyber Green `#06D6A0`
  - 🟣 **Categories**: Neon Purple `#BB86FC`
- **Dark DataGridView**: Dark purple background with light text and blue headers
- **Low Stock Highlighting**: Pink text on dark maroon background
- **Status Bar**: Dark with cyan time display
- **CRUD Operations**: Create, Read, Update, Delete inventory records
- **Advanced Search**: Multi-field filtering with dark themed search box
- **CSV Export**: Export filtered data with timestamp
- **Input Validation**: Comprehensive validation for all input fields
- **Colorful Action Buttons**:
  - ✅ **Register**: Cyber Green
  - 🔄 **Update**: Electric Blue
  - ❌ **Delete**: Hot Pink
  - 🗑️ **Clear**: Bright Yellow with dark text
- **Dark Form**: Deep navy background `#12121C` throughout

## Database Schema

### Logins Table
| Column   | Type        | Description          |
|----------|-------------|----------------------|
| Username | VARCHAR(50) | Primary Key          |
| Password | VARCHAR(50) | User password        |

### Inventory Table
| Column     | Type          | Description              |
|------------|---------------|--------------------------|
| ItemCode   | INT           | Primary Key              |
| ItemName   | VARCHAR(100)  | Name of the item         |
| Category   | VARCHAR(50)   | Product category         |
| Quantity   | INT           | Stock quantity           |
| UnitPrice  | DECIMAL(18,2) | Price per unit           |
| Supplier   | VARCHAR(100)  | Supplier name            |
| DateAdded  | DATE          | Date item was added      |

## Setup Instructions

### Step 1: Database Setup
1. Open **SQL Server Management Studio (SSMS)**
2. Connect to your SQL Server instance
3. Open the `DatabaseSetup.sql` file
4. Execute the script to create:
   - InventoryDB database
   - Logins table with default admin user
   - Inventory table with sample data

### Step 2: Configure Connection String
Update the connection string in both `LoginForm.cs` and `InventoryForm.cs`:

```csharp
// For local SQL Server with Windows Authentication
private string connectionString = @"Data Source=localhost;Initial Catalog=InventoryDB;Integrated Security=True";

// For SQL Server with SQL Authentication
private string connectionString = @"Data Source=localhost;Initial Catalog=InventoryDB;User Id=yourUsername;Password=yourPassword";

// For named SQL Server instance
private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True";
```

### Step 3: Build and Run
1. Open the project in **Visual Studio**
2. Build the solution (Ctrl+Shift+B)
3. Run the application (F5)

## Usage Guide

### Login
1. Launch the application
2. Enter Username: `Admin`
3. Enter Password: `StockUser123`
4. Click **Login**

### Adding New Items
1. Enter a unique ItemCode
2. Fill in all required fields (ItemName, Category, Quantity, UnitPrice, Supplier, DateAdded)
3. Click **Register**
4. Success message will appear

### Updating Items
1. Select an ItemCode from the dropdown
2. The form will auto-fill with existing data
3. Modify the fields as needed
4. Click **Update**

### Deleting Items
1. Select an ItemCode from the dropdown
2. Click **Delete**
3. Confirm the deletion

### Searching Items
- Select any ItemCode from the ComboBox dropdown
- All fields will automatically populate with the item's data

### Clear Form
- Click **Clear** to reset all input fields

### Logout
- Click the **Logout** link to return to the login screen

## Project Structure
```
InventoryManagementSystem/
│
├── DatabaseSetup.sql              # SQL script for database creation
├── Program.cs                     # Application entry point
├── LoginForm.cs                   # Login form logic
├── LoginForm.Designer.cs          # Login form UI design
├── LoginForm.resx                 # Login form resources
├── InventoryForm.cs               # Inventory form logic
├── InventoryForm.Designer.cs      # Inventory form UI design
├── InventoryForm.resx             # Inventory form resources
├── App.config                     # Application configuration
├── InventoryManagementSystem.csproj  # Project file
└── Properties/
    ├── AssemblyInfo.cs           # Assembly information
    ├── Resources.resx            # Application resources
    ├── Resources.Designer.cs     # Generated resource code
    ├── Settings.settings         # Application settings
    └── Settings.Designer.cs      # Generated settings code
```

## Key Features Implemented

### Login Form (Form1)
✅ PictureBox for logo  
✅ GroupBox containing login controls  
✅ Username and Password TextBoxes  
✅ Password masking with '*'  
✅ Clear, Login, and Exit buttons  
✅ Database authentication  
✅ Error handling with appropriate messages  
✅ Confirmation dialog for exit  

### Inventory Form (Form2)
✅ 4 GroupBoxes (Item Registration, Item Details, Supplier Details, Control Panel)  
✅ ItemCode ComboBox with search/auto-fill functionality  
✅ All required input fields with proper labels  
✅ DateTimePicker for DateAdded  
✅ DataGridView for displaying inventory  
✅ CRUD operations (Register, Update, Delete)  
✅ Input validation  
✅ Confirmation dialogs for destructive operations  
✅ Logout functionality  
✅ Clear button to reset form  

## Error Handling
- Database connection errors with user-friendly messages
- Input validation for all fields
- Duplicate ItemCode detection
- SQL exception handling
- Try-catch blocks for all database operations

## Security Features
- Parameterized SQL queries to prevent SQL injection
- Password field masking
- Confirmation dialogs for critical operations

## Default Login Credentials
- **Username**: Admin
- **Password**: StockUser123

## Notes
- The connection string uses Windows Authentication by default
- Modify the connection string based on your SQL Server configuration
- The application uses .NET Framework 4.7.2
- All database operations include proper error handling

## Requirements
- Visual Studio 2017 or later
- .NET Framework 4.7.2 or later
- Microsoft SQL Server (any edition)
- SQL Server Management Studio (SSMS)

## Support
For issues or questions, refer to the code comments in each file for detailed implementation guidance.

---
**Developed**: December 24, 2025  
**Framework**: .NET Framework 4.7.2  
**Database**: Microsoft SQL Server
#   I n v e n t o r y - M a n a g e m e n t - S y s t e m 
 
 