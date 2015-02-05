<!doctype html>
<head>
	<title>PHP: Like/Dislike Bar</title>
</head>

<body>

Form for Testing Purposes

<form action = '' method = 'post'>
	<label for='likes'>Likes</label><input type = 'text' name = 'likes'></br/>
	<label for='likes'>Dislikes</label><input type = 'text' name = 'dislikes'><br/>
	<input type = 'submit' value = 'Create Bar'>
</form>

<?php
	
	require('class.LikeDislikes.php');
	if($_POST){
			$ld = new LikeDislikes($_POST['likes'],$_POST['dislikes']);
			$ld->setDimensions(800,10);
			echo $ld->outputBar();
			echo "<p>Number of Likes {$ld->getLikes()} ({$ld->getLikePercentage()})</p>";
			echo "<p>Number of Dislikes {$ld->getDislikes()} ({$ld->getDislikePercentage()})</p>";
	}

?>

</body>
</html>