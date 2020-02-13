# EosNavigator
This is a project that allows you to navigate the public files on the GVSU EOS system. This program also allows you to view some plain files.
I plan on hopfully improving that part in the feature and allowing people to look at images. Right now it just reads the file as a string and puts
it in your browser window.

This program does not allow you to execute commands on EOS. The 1 user input I am reading in is the path that the user wants to see and that is
escaped with php's ```escapeshellcmd```.

If you would like to goto a specific directory you can change the url. The path is loaded from the ```path``` key in the query string.

#### Interesting Links

[Where this code is hosted](https://cis.gvsu.edu/~strohscd/EosNav.php?path=/home/strohscd/public_html)  
[All the users](https://cis.gvsu.edu/~strohscd/EosNav.php?path=/home)  

