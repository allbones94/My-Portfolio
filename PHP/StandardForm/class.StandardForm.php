<?php

class StandardForm{

private $startNo;
private $number;
private $standardForm;
public function __construct(checkNumeric $number){
	
	if($number->IsPassed() === true){
		$this->number = $number->numbers[0];
		$this->startNo = $number->numbers[0];
	}else{
		$this->number = null;
		
	}
	
	echo $this->convertToSF();
}

private function convertToSF(){
	
	if($this->number !== null){
		
		if($this->number > 10){
			return $this->createSF();
		}else{
			return $this->number;
		}
	}else{
		return "Input Invalid (not numeric)";
	}
}

private function createSF(){

	while($this->number > 10){
	
		$this->number = $this->number/10;
		$this->standardForm++;
	}
		return "{$this->startNo} = {$this->number} x 10 ({$this->standardForm})";
	
}


}

?>