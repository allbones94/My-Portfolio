<?php $email = $_POST['email']; $password = $_POST['password']; ?>
<!doctype html>
<head><title>PHP 1: Login System</title></head>
<body>
<?php require_once('../db_connection.php');
$sql = "SELECT * FROM `users` WHERE `email` = '{$email}' AND `password` = '{$password}'";
$query = mysqli_query($db_connection,$sql) or die(mysqli_error());
$items_in_query = mysqli_num_rows($query);
$data = mysqli_fetch_assoc($query);

if ($items_in_query == 1){
setcookie('first_name',$data['first_name'],time()*3600);
header('location:http://localhost/JA.CO.UK/Tutorials/PHP/Login_System/login_successful.php');
}else{
echo "Login Unsuccessful";
}
?>
</form>
</body>
</html>