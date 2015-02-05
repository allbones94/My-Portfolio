<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>PHP: Bank Account</title>
</head>

<body>
<?php
require('class.Bank.php');
$account = new Bank_Account("£");
$account->deposit(50);
$account->withdraw(100);
$account->withdraw(10);
$account->deposit(33.7);
?>
</body>
</html>