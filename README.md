StudentDataProgram
This is a simple desktop application for managing student data. The application allows the user to add new students, view existing students, and edit or delete student records.

Requirements
.NET Framework 4.7.2 or higher
FluentValidation package
Usage
Clone the repository or download the source code as a ZIP file and extract it to your local machine.
Open the solution file StudentDataProgram.sln in Visual Studio.
Build and run the application.
Use the "Add Student" button to add a new student. You must enter the student's ID, name, surname, university, department, and grade. You can also upload a photo of the student.
Use the "View Students" button to view a list of all students that have been added to the system. You can sort the list by ID, name, surname, university, department, or grade.
Use the "Edit" button to edit the details of a student record. You can change any of the fields except for the student ID.
Use the "Delete" button to delete a student record.
Code
The application is written in C# using the Windows Forms framework. The Form1 class contains the main logic of the application. The RefreshStudents method reads all student records from the Students folder and displays them in a DataGridView. The btnAdd_Click method is called when the user clicks the "Add Student" button. It creates a new Student object and validates it using the StudentValid class. If the validation succeeds, the student record is written to a text file in the Students folder and the DataGridView is updated to show the new student record.

License
This project is licensed under the MIT License. See the LICENSE file for details.
