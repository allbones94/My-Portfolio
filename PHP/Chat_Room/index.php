<?php 
$user = "User".rand(1,10000);
?>
<!doctype html>
<head><title>PHP 4: Chatroom</title></head>

<body>
<form name = 'My_message'>
Logged in as <?php echo $user; ?> <input type = 'hidden' name = 'user' value = '<?php echo $user; ?>' ?>
<p>
<textarea cols  = '40' rows = '5' name = 'message' placeholder = 'Enter a message'></textarea>
</p>
</form>
<button onclick ='sendMessage()'>Send</button>

<div id = 'message_area'>
</div>
<div id = 'myDiv'>&nbsp;</div>
<script src='chatroom.js'></script>
<script>chatInterval();</script>
</body>
</html>