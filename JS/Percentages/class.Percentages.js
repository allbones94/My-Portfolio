// JavaScript Document

function Percentages(){
	
	this.getNumber = function(id,init_val,percentage){
	var output = document.getElementById(id);
	var output_number = (init_val/100) * percentage;
	
	output.innerHTML = percentage+"% of "+init_val+" is "+output_number;
	}
	
	this.getPercentage = function(id,init_val,number){
		var output = document.getElementById(id);
		var output_percentage = (number/init_val)*100;
		
		output.innerHTML = number+" is "+output_percentage+"% of "+init_val;
	}
}