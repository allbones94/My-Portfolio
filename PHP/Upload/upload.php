<?php 
$name = $_FILES['uploadFile']['name']; $size = $_FILES['uploadFile']['size']; $type = explode(".",$name); $type = $type[1];
?>
<!doctype html>
<head><title>PHP: Uploading File</title></head>
<body>
<?php
require_once('class.upload.php');
$file = new UploadItem($name,$type,$size,array('jpg','bmp','jpeg','png'),3000000);

	if($file->checkSize == 1 && $file->checkType == 1)
	{
		echo "Yes";
	}
	else
	{
		echo "NO";
	}
?>
</body>
</html>