<!doctype html>
<head>
<title>PHP: EmailValidator class</title>
</head>
<body>
<h1>This will validate an Email (it will be required)</h1>
<form action = '' method = 'post'>
<label for = 'Email'>Type an Email (or not) </label><input type = 'text' name = 'email' placeholder = 'myemail@example.co.uk'>
<input type=  'submit' value = 'Check'>

<?php
	require('class.EmailValidator.php');
	
	if($_POST){
		$url = new EmailValidator($_POST['email'],true);
		echo $url->getErrorMessage();
	}
	
	
?>
</form>

</body>
</html>