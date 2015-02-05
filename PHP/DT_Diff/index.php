<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>PHP: Date Time Label</title>
</head>

<body>
<?php
require('class.DT_Difference.php');
$dt = new DT_Difference('2014-11-15 19:13:00');

echo $dt->output_difference()." since 2014-11-15 19:13:00";
?>
</body>
</html>