# 🏪 Inventory Management System

![Inventory Management System](https://img.shields.io/badge/Windows%20Forms-.NET-blue?style=for-the-badge)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-green?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Backend-red?style=for-the-badge)
![Made at ITI](https://img.shields.io/badge/Made%20at-ITI%20Alexandria-orange?style=for-the-badge)

> 🏫 This project was developed as part of the **Entity Framework & Visual C# course** at **ITI Alexandria**.

An Inventory Management System built with **Windows Forms** and **Entity Framework Core** to manage warehouse operations including supply, withdrawal, and transfer of products. The system also supports product movement tracking, reporting functionalities, and monitoring warehouse stock levels with detailed reports.

---

## 📸 Database Diagram

Entity Relationship diagram generated from SQL Server.

![Screenshot 2025-06-20 154648](https://github.com/user-attachments/assets/4994f0ce-29c2-4a10-9011-913466344277)

---

## 📋 Features

- ✅ **Add, update, and delete**:
  - Products  
  - Clients and Suppliers (inherited from `Person`)  
  - Warehouses  
  - Supply Permits  
  - Withdraw Permits  
  - Transfer Permits (transfer products between warehouses)

- 🔄 **Track all product movements**, including:
  - Date  
  - Quantity  
  - Type  

- 📦 **Manage warehouse-specific inventory**:
  - Quantity  
  - Entry Date  
  - Production Date & Expiry Date

- 📊 **Generate reports**:
  - Products by stock  
  - Product aging (days in warehouse)  
  - Total quantity by warehouse/product/date  

- 📚 **Entity-based structure** with controller classes for each domain model  
- 💾 Uses **Entity Framework Core** for database interaction  
- 📋 **User-friendly interface** with dynamic control generation for permit entries  

---

## 🧱 Tech Stack

- **Frontend**: Windows Forms (.NET)  
- **Backend**: C#, Entity Framework Core  
- **Database**: SQL Server  
- **Design Pattern**: Simple controller-based architecture  

---

## 🏗️ Architecture

- **UI Layer**: Windows Forms with custom `UserControls` for each view  
- **Data Access Layer**: EF Core with `DbContext` using code-first approach  
- **Controllers**: Business logic for each entity  
  - e.g., `ProductController`, `WithdrawPermitController`  
- **Models**: Represent database entities  
  - e.g., `Product`, `Warehouse`, `ProductInWarehouse`, etc.

---

## 🧰 Technologies Used

| Technology    | Purpose                   |
| ------------- | ------------------------- |
| C# (.NET)     | Main programming language |
| Windows Forms | User Interface            |
| EF Core       | ORM & database management |
| SQL Server    | Backend database          |
| Visual Studio | IDE                       |

---

## 🔄 Permit Types Explained

- **Supply Permit**: Adds new stock to a warehouse.  
- **Withdraw Permit**: Removes stock from warehouse and tracks client info.  
- **Transfer Permit**: Moves stock between two warehouses.

Each permit is linked to detailed product entries with:
- Production/expiry dates  
- Movement logs  

---

## 📌 Important Notes

- Each permit automatically updates:
  - Stock levels in `ProductInWarehouse`  
  - Movement records in `ProductMovement`  
  - Related records like `SupplyPermitProduct` and `WithdrawPermitProduct` link the permit to stock entries  

- All quantity changes affect `ProductInWarehouse` and are reflected in the `ProductMovement` table.  
- **Transfer Permits** automatically:
  - Deduct from source warehouse  
  - Add to destination warehouse  

- Validation prevents over-withdrawing beyond available stock.  
- Nullable relationships are handled cautiously to avoid null reference issues.  

---

## 📁 Project Structure

```
InventoryManagementSystem/
│
├── Controllers/
│   └── ProductController.cs, SupplyPermitController.cs, ...
├── Models/
│   └── Product.cs, SupplyPermit.cs, ...
├── UserControllers/
│   └── UserControl1.cs - UserControl6.cs (forms for each operation)
├── Data/
│   └── ApplicationDbContext.cs
├── Forms/
│   └── MainForm.cs
└── README.md
```

---

## 🔧 How to Run

1. **Clone this repo**:
   ```bash
   git clone https://github.com/your-username/inventory-management-system.git
   ```

2. **Open the solution in Visual Studio**

3. **Run these commands in the Package Manager Console**:
   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```

4. **Build and run the project**

> **Note**: Ensure SQL Server LocalDB or another instance is running and configured in `appsettings.json` or `DbContext`.

---

## ✅ To-Do / Improvements

- [ ] Add authentication for admin access  
- [ ] Export reports to PDF/Excel  
- [ ] Add unit tests for controllers  
- [ ] Add dark mode UI theme  

---

## 📄 License

This project is licensed under the **MIT License**.  
Feel free to use and adapt it for your own projects.

---

## 📩 Contact

Feel free to reach out for feedback, improvements, or collaborations!

📧 Email: [mohab.wafaie@gmail.com](mailto:mohab.wafaie@gmail.com)

---

Made with ❤️ by **Mohab Wafaie** as part of the **ITI Alexandria Visual C# and Entity Frameword Course**.
