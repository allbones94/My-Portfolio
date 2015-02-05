<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>PHP: Convert Temperature</title>
</head>

<body>
<?php require('class.Temperature.php');
	$conv = new tempConv();
	
	echo $conv->c_to_f(1);
?>
</body>
</html>