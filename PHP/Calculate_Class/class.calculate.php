<?php
class calculate
{

	private $num1;
	private $num2;

	

	public function add($a,$b)
	{
		$ans = $a + $b;
		
		echo "{$a} + {$b} = {$ans}";
	}
	
	public function sub($a,$b)
	{
		$ans = $a - $b;
		
		echo "{$a} - {$b} = {$ans}";
	}
	
	public function multi($a,$b)
	{
		$ans = $a * $b;
		
		echo "{$a} x {$b} = {$ans}";
	}
	
	public function div($a,$b)
	{
		$ans = $a/$b;
		
		echo "{$a} / {$b} = {$ans}";
	}
	
	
	
}
?>