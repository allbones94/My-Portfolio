<?php
class distConverter{
	
	public function getConv($val,$one_equals,$from,$to){
		 $conv = $val*$one_equals;
		 return "{$val} {$from} = {$conv} {$to}";
	}
	public function km_to_miles($value){
		return $this->getConv($value,0.621371192,"km","miles");
	}
	
	public function miles_to_km($value){
		return $this->getConv($value,1.609344,"miles","km");
	}
	
	public function meters_to_feet($value){
		return $this->getConv($value,3.2808399,"meters","ft");
	}
	
	public function feet_to_meters($value){
		return $this->getConv($value,0.3048,"ft","meters");
	}
	
}
?>