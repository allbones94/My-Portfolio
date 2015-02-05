// JavaScript Document
function required(form_name){

this.requiredItems = [];
this.valid = false;
this.countValid = 0;
this.form = form_name;
this.addRequired = function(id){
	
	this.requiredItems.push(document.getElementById(id));
}

this.checkRequired = function(){
	
	var length = this.requiredItems.length;
	
	for (var i = 0; i < length;i++){
	
		if (this.requiredItems[i].value.trim() != ""){
			this.countValid++;
			
		}
	}
	
	if (length !== this.countValid){
		alert("You have not filled out all required fields");	
	}else{
		document.getElementsByName(this.form)[0].submit();
	}
}


}