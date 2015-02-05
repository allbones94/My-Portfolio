<!doctype html>
<head>
	<title>PHP: Standard form</title>
</head>

<body>

<form action = '' method = 'post'>
<label for='number'>Type a number to convert to standard form (validated to numeric only) </label><input type = 'text' name = 'number'>
<input type = 'submit' value = 'Convert'>
</form>
	<?php
		require('class.StandardForm.php');
		require('class.checkNumeric.php');
	
		if($_POST){
			$sf = new StandardForm(new checkNumeric(array($_POST['number'])));
		}
	
	?>
</body>

</html>