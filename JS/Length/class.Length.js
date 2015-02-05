// JavaScript Document

function checkLength(min_length,max_length){
	this.items = [];
	this.valid = 0;
	this.minL = min_length;
	this.maxL = max_length;
	
	this.addItem = function(val){
		this.items.push(val);
	}
	
	this.check = function(){
		
		var array_length = this.items.length;
		
		for(var i=0;i < array_length;i++){
			
			if(this.items[i].length >= min_length && this.items[i].length <= max_length){
				this.valid++;
			}
			
			
		}
		
		
		if(this.valid !== array_length){
				alert("ERROR: Values need to be between "+this.minL+" and "+this.maxL);	
		}
	}
	
	
}