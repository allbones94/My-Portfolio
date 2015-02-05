<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Users Starting With <?php echo $_GET['q'];?></title>
</head>

<body>
<?php 
require('class.Search.php');

$q = new Search($_GET['q']);
?>
</body>
</html>