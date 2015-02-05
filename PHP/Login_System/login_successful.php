<?php if (!$_COOKIE){
header('location:http://localhost/JA.CO.UK/Tutorials/PHP/Login_System/');
}
?>
<!doctype html>
<head><title>PHP 1: Login System</title></head>
<body>
<?php echo "Hi {$_COOKIE['first_name']} you have logged in successfully";
?>

<p><a href = 'logout.php'>Click Here to logout sucessfully</a></p>
</form>
</body>
</html>