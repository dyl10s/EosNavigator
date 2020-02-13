<?php
// outputs the username that owns the running php/httpd process
// (on a system with the "whoami" executable in the path)
echo(shell_exec('./DirectoryScanner ' . escapeshellcmd($_GET["path"])));
?>