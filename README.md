# Budget Tracker Application

## Overview
This is a simple **Budget Tracking** application that allows users to add, edit, delete, and view their expenses. The application categorizes expenses into four main types:

- **Needs**
- **Wants**
- **Culture**
- **Unexpected**

Built using **ASP.NET MVC**, the application provides a clean and intuitive interface for managing personal finances.

## Features
- **Add Expenses**: Users can add new expenses by selecting a category and entering details like name and price.
- **Edit Expenses**: Modify existing expenses to update incorrect information.
- **Delete Expenses**: Remove unwanted expenses from the list.
- **View Expenses**: List of all expenses grouped by category, with totals calculated for each category.
  
## Categories
Expenses are divided into four categories using an `enum`:

1. **Needs**: Essential items such as rent, utilities, groceries.
2. **Wants**: Non-essential items like entertainment or dining out.
3. **Culture**: Cultural activities such as museum visits or books.
4. **Unexpected**: Emergency or unforeseen expenses.

## Technologies
- **ASP.NET MVC**
- **Entity Framework** (optional for database integration)
- **Bootstrap** for UI design
- **C#**

## How to Run
1. Clone the repository:

    ```bash
    git clone https://github.com/didemkavlak/BudgetManagement
    ```

2. Open the project in **Visual Studio**.
3. Restore the NuGet packages.
4. Build the project.
5. Run the application by starting the IIS Express or your desired hosting option.

## Usage
1. Navigate to the **Add Expense** page to input a new expense.
2. Use the **Edit** button to update an existing expense.
3. Use the **Delete** button to remove an expense.
4. View total spending under each category on the **Expense Listing** page.

## Future Improvements
- **User Authentication**: Allow users to log in and track personal expenses.
- **Expense Graphs**: Add visual representation of monthly and yearly expenses.
- **Reports**: Generate detailed reports for analysis.


