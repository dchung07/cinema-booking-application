# Cinema Booking System

Welcome to the Github for our assignment!
FYI visual studio has built-in capability with github so you can try linking it up to make things a bit easier.

Have a poke around the files ~~~ At the top of all the cs files I've added the following comment:

```
// University of Technology Sydney Spring Session 2023
// 31927 - Application Development With .NET
//
// Assignment 2: Windows Forms Application
// Cinema Booking System - {INSERT SHORT DESCRIPTION OF FILE HERE}
//
// Written by Justin Widjaya - 13602091,  
//            David Chung - 14288397,
//            Rosa Long - 98137351
//
```
If you guys end up making more forms please add this to the file for consistency.

As a general overview, the text files are basically our databases. Each one stores the thing it is named after. This is done in columns separated by tabs.
For example:
```
// Credentials.txt data format:
// Three columns separated by tab character:
// Column 0 is ID
// Column 1 is Password
// Column 2 is Character Denoting Usertype: C, S, A (Customer, Staff, Admin)

Ctest  test  C
Stest  test  S
Atest  test  A
Vtest  test  V
```
Generally this will also be in line with how they are implemented in the code as a class - though some have not been implemented completely yet :P

As we go along if there are any fields/properties missing feel free to add them or change things around  just make sure you update the class, text files and any code reading/writing to them.

# Patterns to use
A couple recurring patterns that may be useful to use/modify.

READ from file:
```
string line = "";
StreamReader r = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "Patients.txt")); // <-- Opens a stream for this file

while ((line = r.ReadLine()) != null) { // Iterates through file line by line
    string[] data = line.Split('\t'); // Splits the current line into an array of strings using tab spaces as a delimiter

    output.text = data[0]; // Changes a label to whatever is on the 1st column of the current line in the text file 
}
r.Close(); // Closes stream - not neccessary but best practice apparently
```


WRITE to file:
```
// Adds Doctor information to Doctors.txt file
// Assuming spaces are tabs, format is:
// ID FirstName Lastname Email PhoneNumber StreetNumber Street City State
StreamWriter w = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "Doctors.txt"));
w.WriteLine($"{ID}\t{FirstName}\t{LastName}\t{Email}\t{PhoneNumber}\t{StreetNumber}\t{Street}\t{City}\t{State}\t");
w.Close();
```
