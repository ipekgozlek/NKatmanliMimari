# 👨‍💼 N-Layer Architecture Personnel Management System

## 📌 About the Project

This project is a **Personnel Management System** developed using **C# Windows Forms** and **N-Layer Architecture**.

The main purpose of the project is to demonstrate how a desktop application can be structured using separate layers for **data access, business logic, and entity management**.

The application allows users to perform basic CRUD operations on personnel records.

## 🏗️ N-Layer Architecture

The project is structured into three main layers:

### 🗃️ Entity Layer

The **Entity Layer** contains the classes that represent the data models used throughout the application.

For example:

- `EntityPersonel`

The `EntityPersonel` class contains personnel information such as:

- ID
- Name
- Surname
- City
- Salary
- Position

### 🗄️ Data Access Layer

The **Data Access Layer (DAL)** is responsible for database-related operations.

This layer handles operations such as:

- Listing personnel
- Adding personnel
- Deleting personnel
- Updating personnel

The presentation layer does not directly communicate with the database. Instead, database operations are handled through the Data Access Layer.

### ⚙️ Logic Layer

The **Logic Layer (BLL)** contains the business logic of the application.

It acts as a bridge between the Presentation Layer and Data Access Layer.

For example:

- `LLPersonelListesi()`
- `LLPersonelEkle()`
- `LLPersonelSil()`
- `LLPersonelGuncelle()`

This structure helps separate business logic from the user interface and database operations.

### 🖥️ Presentation Layer

The **Presentation Layer** is the Windows Forms application.

It provides the user interface and allows users to interact with personnel records.

The main form communicates with the Logic Layer instead of directly accessing the database.

## 🚀 Features

### 📋 List Personnel

Users can retrieve personnel records from the database and display them in a `DataGridView`.

### ➕ Add Personnel

Users can add a new personnel record by entering:

- Name
- Surname
- City
- Salary
- Position

### ✏️ Update Personnel

Existing personnel records can be updated using their ID.

### 🗑️ Delete Personnel

Personnel records can be deleted by entering the corresponding personnel ID.

## 🔄 CRUD Operations

The application demonstrates the basic CRUD operations:

- **Create** → Add a new personnel
- **Read** → List personnel
- **Update** → Update personnel information
- **Delete** → Delete a personnel

## 🛠️ Technologies

- **C#**
- **.NET Framework 4.8**
- **Windows Forms**
- **N-Layer Architecture**
- **SQL Server**
- **Visual Studio**

## 📂 Project Structure

```text
NKatmanliMimari
│
├── NKatmanliMimari
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   └── App.config
│
├── EntityLayer
│   └── EntityPersonel.cs
│
├── DataAccessLayer
│   └── Personnel Data Access Operations
│
└── LogicLayer
    └── LogicPersonel.cs
