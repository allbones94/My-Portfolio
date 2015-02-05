

function Button(params){

Rectangle.apply(this,arguments);

this.text = params.text;
this.background = "#FF0000";
this.background_up = "#FF0000";
this.background_over = "#0000FF";

	this.draw = function(){

		this.context.beginPath();
		this.context.rect(this.x, this.y, this.w, this.h);
		this.context.fillStyle = this.background;
		
		this.context.fill();
		
		this.context.font = "20px Arial";
		this.context.fillStyle = "#FFF";
		this.context.fillText(this.text, this.x+15, this.y+40);
		this.context.fill;
		
		
	}
	
	
	this.hovercheck = function(mouseX,mouseY){
		if(mouseX > this.x && this.x + this.w+9 >= mouseX && mouseY > this.y && this.y + this.h+9 > mouseY){
			this.background = this.background_over;
			return true;
		}else{
			
			this.background = this.background_up;
			return false;
		}
	}
	
	this.clickButtonCheck = function(mouseX,mouseY){
		if (this.hovercheck(mouseX,mouseY) == true){
			return true;
		}else{
			return false;
		}
	}

	
}
