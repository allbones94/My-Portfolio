var ScreenData = function(){

	this.width = window.innerWidth;
	this.height = window.innerHeight;
	
	this.getOrientation = function(){
	
		if(this.width > this.height){
			return "Landscape";
		}else{
			return "Portrait";
		}
	}
}