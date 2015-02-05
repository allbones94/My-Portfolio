function Player(params){

	Rectangle.apply(this,arguments);
	MoveObject.apply(this,arguments);
	
	this.startPoint = [params.x,params.y,params.direction];
	this.level = 0.5;
	
	
	this.moveLogic = function(){
		
		if (this.direction == 'left'){
		
			if(this.x <= 0){
			
				this.x += 7;
				this.direction = 'right';
				
			}else{
			
				this.x += -7;
				
			}
		}
		
		if (this.direction == 'right'){
			if(this.x + this.w >= canvas.width){
			
				this.level++;
				this.x = 0;
				this.direction = 'right';
				
			}else{
			
				this.x += 7;
				
			}
		
		}
		
		if (this.direction == 'down'){
		
			if(this.y +this.h >= canvas.height){
			
				this.restart();
				
			}else{
			
				this.y += 7;
				
			}
		
		}
		
		if (this.direction == 'up'){
			if(this.y <= 0){
			
				this.restart();
				
			}else{
			
				this.y += -7;
				
			}
		
		}
		
	}
	
	this.restart = function(){
	
		this.x = this.startPoint[0];
		this.y = this.startPoint[1];
		this.direction = this.startPoint[2];
		
	}
	
}
	
