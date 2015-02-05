<?php


class Chatroom{

private $name;
private $message;

public function getMessages(){

require('../db_connection.php');

$sql = "SELECT * FROM `chat-messages`";
$query = mysqli_query($db_connection,$sql) or die(mysql_error());
$output = ""; 

while ($data = mysqli_fetch_assoc($query)){

echo "<p>{$data['User']} : {$data['Message']}</p>";
}

}

}
?>