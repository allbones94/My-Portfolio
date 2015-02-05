<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>
</head>

<body>
<?php 

class Search{

public function __construct($term)
{
	require('../db_connection.php');

	$sql = "SELECT `first_name`,`last_name` FROM `users` WHERE `first_name` LIKE '{$term}%' ORDER BY `last_name` ASC";

	$q = mysqli_query($db_connection,$sql);
	$num = mysqli_num_rows($q);
	
	echo "<h1>{$num} Result(s) Found</h1> <ul>";
	
	while( $data = mysqli_fetch_assoc($q)){
		echo "<li>{$data['first_name']} {$data['last_name']}</li>";

	}
	echo "</ul>";
}

}
?>

</body>
</html>