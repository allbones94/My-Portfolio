<?php

class SessionCollection{

	private $write;
	
	public function __construct($writeable = true){
		$this->write = $writeable;
	}
	
	public function addSession($value,$key = null){
		
			if($this->sessionVarExists($key) === false || $key == null){
				echo "Session Variable {$key} set to {$value}";
				$_SESSION["{$key}"] = $value; 
			}else{
				
				if($this->write === false){
					echo "Err: Session Variable already exists";
				}else{
					echo "Session Variable {$key} changed to {$value}";
					$_SESSION["{$key}"] = $value; 
				}
			}
		}
		
		public function sessionVarExists($value){
		
			if(!isset($_SESSION[$value])){
				return false;
			}else{
				return true;
			}
		}
		
		public function getSession($key){
			if($this->sessionVarExists($key) === true){
				return $_SESSION[$key];
			}else{
				return "Err: Session variable $key doesn't exist";
			}
		}
}
?>