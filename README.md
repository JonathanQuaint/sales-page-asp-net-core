# Sales Page ASP.NET Core

A modern sales page built with ASP.NET Core to showcase products and facilitate online sales.

---

## Overview

This project provides a platform for displaying products, managing a shopping cart, handling user authentication, and processing orders. It is designed to be responsive and cater to both mobile and desktop users.

### Key Features

- **Product Catalog**: Display products with images and descriptions.
- **Shopping Cart**: Add, remove, and update items in the cart.
- **User Management**: Register, login, and manage user profiles.
- **Order Processing**: Handle and track user orders.
- **Payment Integration**: Integrate with payment gateways for transactions.
- **Responsive Design**: Optimized for mobile and desktop views.

---

## Technologies

- **Backend**: ASP.NET Core (C#)
- **Frontend**: HTML, CSS, JavaScript

---

## Setup Instructions

### Prerequisites

- .NET SDK
- SQL Server or another compatible database

### Installation Steps

1. **Clone the Repository**
   ```bash
   git clone https://github.com/JonathanQuaint/sales-page-asp-net-core.git
   cd sales-page-asp-net-core
   ```

2. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

3. **Database Configuration**
   - Update the connection string in `appsettings.json`.

4. **Build and Run**
   ```bash
   dotnet build
   dotnet run
   ```

---

## API Endpoints

### Product Management

- **Get All Products**
  - `GET /api/products`
  - Returns a list of all products.

- **Get Product by ID**
  - `GET /api/products/{id}`
  - Returns a specific product by ID.

- **Create Product**
  - `POST /api/products`
  - Adds a new product.
  - Parameters: `ProductCreateDTO`

- **Update Product**
  - `PUT /api/products/{id}`
  - Updates an existing product.
  - Parameters: `ProductUpdateDTO`

- **Delete Product**
  - `DELETE /api/products/{id}`
  - Deletes a product by ID.

### User Management

- **Register User**
  - `POST /api/users/register`
  - Registers a new user.
  - Parameters: `UserRegisterDTO`

- **Login User**
  - `POST /api/users/login`
  - Authenticates a user.
  - Parameters: `UserLoginDTO`

### Order Management

- **Create Order**
  - `POST /api/orders`
  - Creates a new order.
  - Parameters: `OrderCreateDTO`

- **Get Order by ID**
  - `GET /api/orders/{id}`
  - Returns a specific order by ID.

### Shopping Cart

- **Add to Cart**
  - `POST /api/cart`
  - Adds an item to the cart.
  - Parameters: `CartItemDTO`

- **Get Cart**
  - `GET /api/cart`
  - Returns the current user's cart.

---
