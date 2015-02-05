<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>PHP: Get Sum and Average</title>
</head>

<body>
<?php require('class.Number.php');

$collection = new Numbers();

$collection->addNumber(2);
$collection->addNumber(10);
$collection->addNumber(14);
$collection->addNumber(4);
$collection->addNumber(20);

echo "<p>The Average of 2,10,14,4,20 is {$collection->getAverage()}</p>";

echo "<p>The Sum of 2,10,14,4,20 is {$collection->getSum()}</p>";

echo "<p>There are {$collection->itemsInArray()} item(s) in the array</p>";
?>
</body>
</html>