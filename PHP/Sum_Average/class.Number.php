<?php
class Numbers{
	
	private $num = array();
	
	public function addNumber($new_number){
	
		if (is_numeric($new_number)){
			array_push($this->num,$new_number);
		}
	}
	
	public function getAverage(){
		$val = $this->getSum();
		$counter = $this->itemsInArray();
		$average = $val/$counter;
		
		return $average;
	}
	
	public function itemsInArray(){
		$item_count = count($this->num);
		
		return $item_count;
	}

	public function getSum(){
		
		$sum = 0;
		$counter = $this->itemsInArray();
		
		for($i = 0;$i < $counter;$i++){
			$sum += $this->num[$i];
		}
		
		return $sum;
	}

}

?>