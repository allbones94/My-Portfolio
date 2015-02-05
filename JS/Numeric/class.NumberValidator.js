var numberValidator = function(){
	var number;
	
	this.validate = function(val){
		this.number = val;
		if(!isNaN(val)){
			return true;
		}else{
			return false;
		}
	}
}