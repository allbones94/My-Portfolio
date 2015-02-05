<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>PHP: Percentage Convertor</title>
</head>

<body>
<?php
require('class.PercentConv.php');
$pc_conv = new percentConv();

echo "<p>{$pc_conv->getNumber(50,10)}</p>";
echo "<p>{$pc_conv->getPercentage(50,1)}</p>";
?>
</body>
</html>