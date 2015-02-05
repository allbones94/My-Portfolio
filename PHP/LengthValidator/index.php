<!doctype html>
<head>
<title>PHP: LengthValidator class</title>
</head>
<body>
<h1>This will validate a string length (it will be required)</h1>

<form action = '' method = 'post'>
	<label for = 'name'>Type a value between 5 and 20 characters long</label> <input type = 'text' name = 'name'>
<input type=  'submit' value = 'Check'>
<?php
	require('class.LengthValidator.php');
	if($_POST){
		$str = new LengthValidator($_POST['name'],20,5,true);
		
		echo $str->getErrorMessage();
	}
	
?>
</body>
</html>