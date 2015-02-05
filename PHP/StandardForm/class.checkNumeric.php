<?php
class checkNumeric{

	private $array_count = 0;
	private $valid = 0;
	public $numbers;
	
	public function __construct($number_list){
		$this->numbers = $number_list;
		$this->array_count = count($number_list);

		foreach($number_list as $n){
			if (is_numeric($n)){
				$this->valid++;
			}
			
			
		}

		
	}

	public function isPassed(){
		if($this->array_count === $this->valid){
			return true;
		}else{
			
			return false;
		}
	}
}

?>