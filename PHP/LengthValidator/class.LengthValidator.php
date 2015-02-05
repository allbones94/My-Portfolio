<?php

class LengthValidator{
	
	private $required;
	private $min;
	private $max;
	private $value;
	public $errorMessage = '';
	
	public function __construct($value,$maxlength,$minlength = 0,$required = false){
		$this->value = $value;
		$this->required = $required;
		$this->max = $maxlength;
		$this->min = $minlength;
		$this->Validation();
	}
	
	private function Validation(){
		
		if($this->IsRequired() === true){
			
			if($this->valueBlank() === false){
				
				if($this->IsValid() === true){
					$this->errorMessage =  "Ok";
				}else{
					$this->errorMessage = "Make sure the string is between {$this->min} and {$this->max} characters";
				}
				
			}else{
				
				$this->errorMessage = "This is a required Field";
			}
			
		}else{
		
			if($this->IsValid() === true){
					$this->errorMessage =  "Ok";
			}else{
					$this->errorMessage = "Make sure the string is between {$this->min} and {$this->max} characters";
			}
				
		}
	}
	
	private function IsRequired(){
		return $this->required;
	}
	
	private function valueBlank(){
		
		$test = trim($this->value);
		
		if (strlen($test) > 0){
			return false;
		}else{
			return true;
		}
	}
	
	private function IsValid(){
		
		$length = strlen($this->value);
		
		if($length >= $this->min && $length <= $this->max){
			return true;
		}else{
			return false;
		}
	}
	
	public function getErrorMessage(){
		return $this->errorMessage;
	}	
}

?>