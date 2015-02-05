function Bitmap(params){
	Drawable.apply(this,arguments);
	
	this.img = document.getElementById(params.id);

	this.draw = function(){
		this.context.drawImage(this.img,this.x,this.y);
	}
}