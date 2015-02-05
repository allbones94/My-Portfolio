<?php
class sentMessage{

public function __construct($myUser,$myMessage){

require('../db_connection.php');
$sql = "INSERT INTO `chat-messages` (`ID`,`User`,`Message`) VALUES ('','{$myUser}','{$myMessage}')";

mysqli_query($db_connection,$sql) or die (mysqli_error());}

}

?>