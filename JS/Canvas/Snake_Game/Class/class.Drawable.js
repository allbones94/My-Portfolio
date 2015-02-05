function Drawable(params){

	this.context = params.context;
	this.x = params.x;
	this.y = params.y;

	function pick(a,b){
	
		if(typeof a === 'undefined'){
			return b;
		}else{
			return a;
		}
	
	}

}