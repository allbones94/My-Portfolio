<?php

class DT_Difference{
	
	private $output = '';
	
	public function __construct($dt_ref){
		
		$datetime1 = new DateTime();
		$datetime2 = new DateTime($dt_ref);
		$interval = $datetime1->diff($datetime2);
		
		$y = $interval->format('%y');
		$m = $interval->format('%m');
		$d = $interval->format('%d');
		$h = $interval->format('%h');
		$i = $interval->format('%i');
		$s = $interval->format('%s');
		
		$this->getDifference(array($y,$m,$d,$h,$i,$s));
		
	}
	
	public function getDifference($dt){
		
		$array_count = count($dt);
		$array_format = array("year","month","day","hour","minute","second");
		$ref_point = 0; //
		
		$i = 0;
		while($dt[$i] == 0){
			
			
					
			$i++;	
		}
		$ref_point = $i;
		
		
	$this->output = $this->addS($dt[$ref_point],$array_format[$ref_point]);
		
	}
	
	private function addS($val,$format){
			
		if ($val > 1){
			return $val." ".$format."s ago";	
		}else{
			return $val." ".$format." ago";
		}
	}
	
	public function output_difference(){
	return $this->output;	
	}
	
	
}
?>