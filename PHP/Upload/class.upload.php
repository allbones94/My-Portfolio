<?php
class UploadItem{

public $checkSize;
public $checkType;

public function __construct($name,$type,$size,$myAcceptedTypes,$myAcceptedSize)
{

	$this->checkFileType($type,$myAcceptedTypes);
	$this->checkSize($size,$myAcceptedSize);
	
}

public function checkFileType($mytype,$acceptedTypes)
{

	if (in_array($mytype,$acceptedTypes))
	{
		$this->checkType = 1;
	}
	else
	{
		$this->checkType = 0;
	}
}

public function checkSize($mysize,$acceptedSize)
{

	if ($mysize <= $acceptedSize)
	{
		$this->checkSize = 1;
	}
	else
	{
		$this->checkSize = 0;
	}
}

}
?>