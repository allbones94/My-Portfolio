<?php
require('class.sentMessage.php');
$nm = new sentMessage($_GET['user'],$_GET['message']);
?>