
function obstacle(params){
	
	Rectangle.apply(this,arguments);
	MoveObject.apply(this,arguments);
	
	this.min = params.min;
	
	this.moveLogic = function(){
		
		if (this.direction == 'left'){
			if(this.x <= this.min){
				this.x += 8;
				this.direction = 'right';
			}else{
				this.x += -8;
			}
		}
		
		if (this.direction == 'right'){
			if(this.x + this.w >= canvas.width){
				this.x += -8;
				this.direction = 'left';
			}else{
				this.x += 8;
			}
		
		}
		
		if (this.direction == 'down'){
			if(this.y +this.h >= canvas.height){
				this.y += -10;
				this.direction = 'up';
			}else{
				this.y += 10;
			}
		
		}
		
		if (this.direction == 'up'){
			if(this.y <= this.min){
				this.y += 10;
				this.direction = 'down';
			}else{
				this.y += -10;
			}
		
		}
		
	}
}

