<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>PHP: Convert Distances</title>
</head>

<body>
<?php
require('class.ConvertDistances.php');

$conv = new distConverter();

echo $conv->km_to_miles(2)."<br/>";
echo $conv->miles_to_km(83)."<br/>";
?>
</body>
</html>