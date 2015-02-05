function compoundMoveable(moveObject){

	this.init = function(){
		for (var i = 0; i < moveObject.length; i++){
			moveObject[i].move();
		}
	}
}

function compoundDrawable(Objects){

	this.init = function(){
		for (var i = 0; i < Objects.length; i++){
			Objects[i].draw();
		}	
	}
}