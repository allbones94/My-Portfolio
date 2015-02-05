<?php 		require('class.SessionHandler.php');session_start();
?>
<!doctype html>
<head>
	<title>PHP: Session Class</title>
</head>
<style>
.form2{margin:7em 0em 2em 0em}
</style>
<body>
	<form action = '' method = 'post'>
		<p>New Session Name <input type = 'text' name = 'addSessionName'></p>
		<p>New Session Value <input type = 'text' name = 'addSessionValue'></p>
		<input type = 'submit' value = 'Create Session Variable'>
	</form>
	
	<form action = '' method = 'post' class = 'form2'>
	Get Session Variable <input type = 'text' name = 'getSession'> <input type = 'submit' value = 'Get Session Variable'>
	</form>
	
	<?php 

		if($_POST){
				
					$sh = new SessionCollection();
				if(isset($_POST['addSessionName'])){
				
					$sh->addSession($_POST['addSessionValue'],$_POST['addSessionName']);
					
				}	else if(isset($_POST['getSession'])){
					
					echo $sh->getSession($_POST['getSession']);
				}
		}
		
		
	?>
</body>

</html>