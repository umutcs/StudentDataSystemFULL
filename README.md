# StudentDataSystemFULL

It is an example that explains Fluent Validation and file operations. The program currently saves student information to .txt file and dataGridView. I will create SQL Database with updates.



#Here's the story about the program

Students who choose a university will be added to a system made by the state.
Necessary actions are taken by a principal for the student to be registered in the system.

#What does the program do when it runs ?

So what are these transactions?
The student's name is entered and a school number is manually assigned to the student.
Enter the school the student is studying, the department he/she has chosen, and the grade he/she is in, then click "ADD" and select his/her photo and the student is registered in the system. There are some rules for the student's name and number when adding a student, and these are specified in the StudentValid.cs file.
The student is saved in a special folder with the school number under the "Students" folder and these records are displayed in the dataGridView every second.
