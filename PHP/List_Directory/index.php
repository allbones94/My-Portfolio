<!doctype html>
<head><title>PHP 3: List directory</title></head>
<body>
<?php echo "Files in ".__DIR__;?>
<ul>
<?php
if ($dir = opendir(__DIR__)) {

    while (false !== ($file = readdir($dir))) {

        if ($file != "." && $file != "..") {

            echo "<li><a href = '{$file}'>$file</a></li>";
        }
    }

    closedir($dir);
}
 ?>
</ul>
</body>
</html>