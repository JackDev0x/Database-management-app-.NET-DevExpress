Database management app (.NET + DevExpress)


Code peview only (without configure files, databases etc.)

****Introduction****

The application is based on DevExpress WinForms technology and allows users to log in to the system with control panel where it's possible to browse a database using a GridView with filtering and sorting capabilities, save filter and sorting preferences for each user, delete data from the MS SQL database by clicking on a GridView record and selecting "Delete" add records in a separate view and preview table prints. Additionally, all user actions, including login, logout, data deletion, and data addition, are monitored and recorded in an event history.

****Functionality****


**Login System: **
Users can log in to the system by providing valid authentication credentials.
Authentication credentials are verified against the database.
In case of invalid login credentials, the user receives an appropriate notification.

**Browsing the Database with GridView: **
The application displays a table in the form of a GridView, allowing users to browse the data.
Users can sort records by selected columns and also filter it by selecting filtering criteria for individual columns.
After applying filters, the table is refreshed and displayed according to the user's preferences.

**Saving Filter and Sorting Preferences: **
After applying filters and sorting, the application saves the user's preferences in the database.
Upon subsequent logins, the saved filter and sorting preferences are loaded for the user.

**Removing Data from the Database: **
Users can remove data by clicking on a record in the GridView and then using the "Delete" button.
Before deleting data, application displays a confirmation prompt.
After this process, the GridView is automatically refreshed to reflect the changes.

**Adding New Records: **
Users have the ability to add new records.
By navigating to a separate view, users can enter data for a new record.
After adding a record, the GridView is automatically refreshed to include new data.

**Table Print Preview: **
By clicking on the corresponding button, the application generates a print preview containing the table data.

**User Action Monitoring and Logging: **
Each user action, such as login, logout, data deletion, and data addition, is monitored and recorded in the event history.
The event history stores information about the user, timestamp, and action type.

**Technologies and Tools: **
The application is written in C# using the .NET platform.
The DevExpress WinForms library is used to create the user interface.
Data is stored in a Microsoft SQL Server database.

