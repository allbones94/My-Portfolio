<?php

class URLValidator{
	
	private $required;
	private $url;
	public $errorMessage = '';
	
	public function __construct($url,$required = false){
		$this->url = $url;
		$this->required = $required;
		
		$this->Validation();
	}
	
	private function Validation(){
		
		if($this->IsRequired() === true){
			
			if($this->valueBlank() === false){
				
				if($this->IsValid() === true){
					$this->errorMessage =  "Is Valid URL";
				}else{
					$this->errorMessage = "Not a valid URL";
				}
				
			}else{
				$this->errorMessage = "This is a required Field";
			}
			
		}else{
		
			if($this->IsValid() === true){
					$this->errorMessage =  "Is Valid URL";
			}else{
					$this->errorMessage = "Not a valid URL";
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
		
		if(!filter_var($this->url, FILTER_VALIDATE_URL)){
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