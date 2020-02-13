<?php
echo(shell_exec('./DirectoryScanner ' . escapeshellcmd($_GET["path"])));
?>
