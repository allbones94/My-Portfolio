<!doctype html>
<head>
<title>PHP: URLValidator class</title>
</head>
<body>
<h1>This will validate a URL (it will be required)</h1>
<form action = '' method = 'post'>
<label for = 'URL'>Type a URL (or not) </label><input type = 'text' name = 'url' placeholder = 'http://www.example.com'>
<input type=  'submit' value = 'Check'>

<?php
	require('class.URLValidator.php');
	
	if($_POST){
		$url = new URLValidator($_POST['url'],true);
		echo $url->getErrorMessage();
	}
	
	
?>
</form>

</body>
</html>