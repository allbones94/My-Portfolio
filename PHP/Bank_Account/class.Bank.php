<?php
class Bank_Account{
	
private $money = 0;
private $currency = "£";

public function __construct($cc){
	
$this->currency = $cc;	
}
public function deposit($value){
	$this->money+=$value;
	$format = number_format($value, 2, '.', '');
	echo "<p>Deposited {$this->currency}{$format}<br/>Current Balance:{$this->getBalance()}</p>";
}

public function withdraw($value){
	$format = number_format($value, 2, '.', '');
	
	if($this->money < $value){
		echo "<p>Insufficient Funds for {$this->currency}{$format} Withdraw<br/>Current Balance: {$this->getBalance()}</p>";
	}else{
		$this->money -= $value;
		echo  " <p>Withdrawn {$this->currency}{$format}<br/>Current Balance: {$this->getBalance()}</p>";	
	}
}

private function getBalance(){
	return $this->currency.number_format($this->money,2,'.','');	
}

}
?>