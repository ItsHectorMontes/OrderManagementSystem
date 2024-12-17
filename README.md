
# Order Management System 📦

A robust **Order Management System** developed in **C# (.NET 8)**. This project demonstrates advanced software architecture principles including **SOLID**, dependency injection, generic repositories, and validation utilities. It is designed for educational purposes and to showcase clean, scalable code.

---

## 🚀 **Features**

- **SOLID Principles**: Clean architecture design adhering to SRP, OCP, LSP, ISP, and DIP.  
- **Generic Repository**: A reusable repository pattern for data management.  
- **Dependency Injection**: Loose coupling achieved via interface-driven design.  
- **LINQ Queries**: Advanced querying for filtering and calculations.  
- **Input Validation**: Ensures data consistency and avoids runtime errors.  
- **Clear Architecture**: Entities, services, repositories, and utilities are well-organized.  

---

## 📂 **Project Structure**

```
OrderManagementSystem/
│-- Entities/
│    ├── Order.cs          # Order entity with total calculation
│    ├── Product.cs        # Product entity with stock management
│    └── Customer.cs       # Customer entity
│-- Interfaces/
│    ├── IOrderService.cs  # Interface for order operations
│    ├── IProductService.cs # Interface for product operations
│    └── IRepository.cs    # Generic repository interface
│-- Repositories/
│    └── GenericRepository.cs # Generic repository implementation
│-- Services/
│    ├── OrderService.cs   # Manages order operations
│    └── ProductService.cs # Manages product operations
│-- Utilities/
│    └── Validator.cs      # Helper for input validations
│-- Program.cs             # Application entry point
```

---

## 💻 **Technologies Used**

- **Language**: C# (.NET 8)
- **Architecture**: SOLID Principles, Generic Repository
- **Tools**: Visual Studio 2022, .NET CLI  
- **Frameworks**: .NET 8.0

---

## ⚙️ **Installation**

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/OrderManagementSystem.git
   cd OrderManagementSystem
   ```

2. **Open the project in Visual Studio 2022** or any IDE compatible with .NET 8.  

3. **Run the application**:
   - Use `F5` to run the project.  

---

## 📘 **How to Use**

1. **Add Products**:
   - Products are initialized in the `Program.cs` file with predefined stock and prices.  

2. **Create an Order**:
   - Select products to include in the order.  
   - The system will automatically deduct stock and calculate the total price.

3. **View Orders**:
   - All orders will be displayed in the console with their details, including total amounts.

---

## 🧩 **Examples**

**Output after running the program**:

```text
Order created for customer: John Doe, Total: $1500

All Orders:
ID: 1, Customer: John Doe, Total: $1500
```

---

## 🛠️ **Extensibility**

This project can be extended further with the following features:
- **Persistence**: Save data using a database (SQL Server, SQLite, etc.) or JSON files.  
- **Unit Testing**: Add tests with **xUnit** or **NUnit** for services and repositories.  
- **REST API**: Convert the console application into an ASP.NET Core Web API.  
- **Frontend UI**: Develop a frontend using React, Angular, or Blazor.  

---

## 📜 **License**

This project is open-source and available under the [MIT License](LICENSE).

---

## 🙌 **Contributions**

Contributions are welcome! Feel free to fork the repository, submit issues, or create pull requests.

---

## 🔗 **Contact**

- **Your Name**  
- **Email**: hector.montesp@gmail.com
- **GitHub**: [ItsHectorMontes](https://github.com/ItsHectorMontes)  

---

**⭐ If you find this project helpful, don't forget to star the repository!**
