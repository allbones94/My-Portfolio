<?php
class tempConv{
	
	public function getConv($val,$one_equals,$from,$to){
		 $conv = $val*$one_equals;
		 return "{$val} {$from} = {$conv} {$to}";
	}
	
	public function c_to_f($celcius){
		return $this->getConv($celcius,33.8,"&deg;C","&deg;F");
	}
}
?>