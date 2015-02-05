<?php

class EmailValidator{
	
	private $required;
	private $email;
	public $errorMessage = '';
	
	public function __construct($email,$required = false){
		$this->url = $email;
		$this->required = $required;
		
		$this->Validation();
	}
	
	private function Validation(){
		
		if($this->IsRequired() === true){
			
			if($this->valueBlank() === false){
				
				if($this->IsValid() === true){
					$this->errorMessage =  "Is Valid Email";
				}else{
					$this->errorMessage = "Not a valid Email";
				}
				
			}else{
				$this->errorMessage = "This is a required Field";
			}
			
		}else{
		
			if($this->IsValid() === true){
					$this->errorMessage =  "Is Valid Email";
			}else{
					$this->errorMessage = "Not a valid Email";
			}
				
		}
	}
	
	private function IsRequired(){
		return $this->required;
	}
	
	private function valueBlank(){
		
		$test = trim($this->url);
		
		if (strlen($test) > 0){
			return false;
		}else{
			return true;
		}
	}
	
	private function IsValid(){
		
		if(!filter_var($this->url, FILTER_VALIDATE_EMAIL)){
			return false;
		}else{
			return true;
		}
	}
	
	public function getErrorMessage(){
		return $this->errorMessage;
	}	
}

?>