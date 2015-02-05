
function MoveObject(params){
	
	this.direction = params.direction;	
	
	this.move = function(){
				
		this.moveLogic();	
		this.draw();
	}
	
	
	
}