# Contact List App

Two Windows Forms contact managers in C#, built for a lab at Collège LaSalle (September 2025). One keeps contacts in memory and saves them to XML; the other stores them in a SQL Server LocalDB database.

## Projects

### `ContactListSolution`: in-memory list with XML files
- Add, delete, search and list contacts.
- Each contact has a number, first and last name, email, a contact type (an enum) and a meeting date and time.
- Write the list to an XML file and read it back.
- Code is split into a business layer (`bus/`: `Contact`, `DateTimeCustom`, `EnumType`) and a UI layer (`user/`). A class diagram is in `bus/BusDiagram.cd`.

### `WinFormsContactList_Solution`: SQL Server database
- Add, update and delete contacts, with the list shown in a data grid that refreshes after each change.
- Clicking a row fills the form so it can be edited.
- Uses ADO.NET (`SqlConnection`, `SqlCommand`) and a typed DataSet with a table adapter.
- The table schema is in `Contact.sql`.

## Tech
C#, .NET Framework 4.7.2, Windows Forms, ADO.NET, SQL Server LocalDB, XML

## Run it
Requires Windows and Visual Studio with the .NET desktop development workload (LocalDB is included).

1. Clone the repository.
2. Open `ContactListSolution/ContactListSolution.sln` or `WinFormsContactList_Solution/WinFormsContactList_Solution.sln`.
3. Press **F5**.

The database project attaches `Database1.mdf` from the project folder through `(LocalDB)\MSSQLLocalDB`; the connection string is in `App.config`.

## Author
Abdulrahman (Aoof) Mousa · [aoof.ca](https://aoof.ca)
