function Rectangle(params){
	Drawable.apply(this,arguments);
	this.w = params.w;
	this.h = params.h;
	this.fillStyle = pick(params.bg,"#FF0000");
	this.strokeStyle = pick(params.bg,"#FF0000");
	
	this.draw = function(){
	
	  this.context.beginPath();
      this.context.rect(this.x, this.y, this.w, this.h);
      this.context.fillStyle = this.fillStyle;
      this.context.fill();
      this.context.lineWidth = 1;
      this.context.strokeStyle = this.strokeStyle;
      this.context.stroke();
	}
	
	function pick(a,b){
	
		if(typeof a === 'undefined'){
			return b;
		}else{
			return a;
		}
	
	}
	
	
}
