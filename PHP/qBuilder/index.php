<!doctype html>
<head>
<title>PHP: qBuilder class</title>
</head>
<body>
	<?php  require('class.qBuilder.php');$q = new qBuilder();
		$q->build("SELECT * FROM `my-portfolio`",true);
		echo $q->getAffectedRows()." Rows affected by SQL";
	?>
</body>
</html>