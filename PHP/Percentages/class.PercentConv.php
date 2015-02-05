<?php
class percentConv{
	
	
	public function getNumber($init_val,$percentage){
		
		if (is_numeric($init_val) && is_numeric($percentage)){
		$output = ($init_val/100) * $percentage;
			return "{$percentage}% of {$init_val} is {$output}";
		}else{
			return "ERROR: One of your numbers are not numeric";	
		}
	}
	
	public function getPercentage($init_val,$number){
		$percentage = ($number/$init_val)*100;	
		
		if (is_numeric($init_val)&& is_numeric($number)){
			return "{$number} is {$percentage}% of {$init_val}";
		}
	}
}
?>