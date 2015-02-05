<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>PHP: checkNumeric class</title>
</head>

<body>
This Class can check mulitple values rather than have an if 'isNumeric()' statement for each one
<form action = '' method = 'post'>
	<input type = 'test' name = 'value' placeholder = 'Enter a number or Word'>
    
    <input type = 'test' name = 'value2' placeholder = 'Enter a number or Word'>
    
	<input type="submit">
</form>
<?php
require('class.checkNumeric.php');

if ($_POST){
	$numbers = new checkNumeric(array($_POST['value'],$_POST['value2']));
	
	if($numbers->isPassed() === true){
		echo "All values numeric";
	}else{
		echo "Not all values are numeric";
	}
}



?>
</body>
</html>