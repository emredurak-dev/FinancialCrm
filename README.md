## Financial CRM Project 🚀💼

Financial CRM is a specialized software designed to help businesses in the financial sector effectively manage customer relationships and interactions. This project caters to the unique needs of financial institutions such as banks, insurance companies, and investment management firms. Below is an overview of the features and implementation of the project. 👇

## Features 📋

## Login Screen 🔒

User Authentication: Users must enter the credentials provided to them to access the Dashboard.

Validation:

If incorrect or incomplete login details are entered, the system displays an error message and prompts the user to retry.

Fields cannot be left blank; attempting to do so will trigger a warning message.

Successful Login: Grants access to the Dashboard panel after validation.

![logn](https://github.com/user-attachments/assets/c6167a3e-9d57-466e-8a7b-af855e118b72)

## Dashboard Screen 📊

The Dashboard is the central hub of the application, offering a comprehensive overview of key financial metrics and features:

Navigation Menu: A sidebar menu provides easy access to various functionalities.

Total Balance Overview: Displays the total account balance.

Recurring Bills: A rotating display of upcoming bills and their amounts.

Recent Transactions: Highlights the most recent incoming wire transfer and its amount.

Visual Insights:

Bank Balances: Graphical representation of balances across different banks.

Bills Summary: Graphical breakdown of bill names and their corresponding amounts.

https://github.com/user-attachments/assets/62bcaa48-73b3-4f8a-9158-1117c14f75c0

## Category Screen 📃

CRUD Operations: Users can perform Create, Read, Update, and Delete operations on financial categories.

Create: Add new categories.

Read: View a list of all categories.

Update: Modify existing categories.

Delete: Remove unwanted categories.

This screen empowers users to organize and manage their financial categories effectively.

![kategori](https://github.com/user-attachments/assets/8ae8b105-c3a3-4efd-8925-b47c3aba0840)

## Banks Screen 📃

Total Balances: Displays the total balances across all connected banks.

Recent Transactions: Users can view details of the last 8 bank transactions.

Provides users with a clear and concise view of their financial activity and bank details.

![bankalar](https://github.com/user-attachments/assets/748690cc-28e5-4d11-bb7b-62eeee7e892c)

## Invoices Screen 📃

CRUD Operations: Users can Create, Read, Update, and Delete their payment records on this screen.

Payments Classification: Payments can be categorized by title, amount, and frequency.

This screen helps users efficiently manage and track their payments.

![fatura](https://github.com/user-attachments/assets/03b71a11-fee2-42fd-aeee-fbef1100ebb5)

## Expenses Screen 📃

Expense Tracking: Users can categorize their expenses and perform CRUD operations:

Create: Add new expenses.

Read: View a list of all expenses.

Update: Modify existing expense records.

Delete: Remove unwanted expense records.

This screen ensures better organization of expenditures.

![giders](https://github.com/user-attachments/assets/1c62ec8d-e270-4696-971b-6bb9dea44294)

## Bank Transactions Screen 📃

Transaction Details: Users can view all incoming wire transfers to their accounts on this screen.

Provides a detailed history of financial activities across all linked accounts.

![bankahareketi](https://github.com/user-attachments/assets/53c70d71-fe97-40df-9937-8e9283c77e82)

## Settings Panel ⚙️

User Management:

Users can update their username and password directly from this panel.

This feature ensures better account security and customization.

https://github.com/user-attachments/assets/a2e6d5a5-f20e-43c0-aee5-8d678b65185e

## Database Design 💾

To enable efficient data management, the project uses a structured database with the following key tables:

Users: Stores user information for login and authentication.

Categories: Manages financial categories for expenses and income.

Expenses: Tracks individual expenditures.

Invoices: Stores invoice details and amounts.

Banks: Manages bank details.

Bank Transactions: Logs transactions associated with each bank.

## Implementation Details 🛠️

Entity Framework: An ADO.NET Entity Data Model was created to integrate the database into the application.

Tables and Data Access: This model facilitates seamless interaction with the tables and their associated data.

## Tech Stack ⚙️

Language: C#

Framework: .NET Framework

Database: SQL Server

ORM: ADO.NET Entity Framework

## Happy Coding! 💻✨
