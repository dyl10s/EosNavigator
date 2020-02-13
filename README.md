# EosNavigator
This is a project that allows me to navigate the public files on the GVSU EOS system. 

This program does not allow you to execute commands on EOS. The 1 user input I am reading in is the path that the user wants to see and that is
escaped with php's ```escapeshellcmd```.

If you would like to goto a specific directory you can change the url. The path is loaded from the ```path``` key in the query string.

### Output
Selecting a folder allows you to navigate the system. You can also preview some files by clicking on them.

![Program Output](/Output.PNG)
