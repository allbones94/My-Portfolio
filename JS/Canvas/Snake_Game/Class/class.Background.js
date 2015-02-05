function Background(params){

Rectangle.apply(this,arguments);

this.draw = function(){
	
	  this.context.beginPath();
	  
			var line = 0;
			for(var i = 0; i < 13; i++){
				
				if (line % 2 == 0){
					this.x = -100;
					this.context.rect(this.x + (i*100), this.y +(line *50), this.w, this.h);
				}else{
					this.x = -50;
					this.context.rect(this.x + (i*100), this.y +(line *50), this.w, this.h);
				}
				
				if(i == 12 && line != 20){
					i = 0;
					line++;
				}
				
			}
		
		
      this.context.fillStyle = this.fillStyle;
      this.context.fill();
     
	}


}
