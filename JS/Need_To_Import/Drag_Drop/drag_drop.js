function dragDrop(params){
this.obj = document.getElementById("dragMe");

var bodyRect = document.body.getBoundingClientRect(),
    elemRect = this.obj.getBoundingClientRect();
	

this.width = this.obj.offsetWidth;
this.height = this.obj.offsetHeight;
this.x = (elemRect.left - bodyRect.left) + 8;
this.y = (elemRect.top - bodyRect.top) +8;
console.log(this.obj);

console.log("width :"+this.width);
console.log("height :"+this.height);
console.log("x :"+this.x);
console.log("y :"+this.y);

this.hitDetection = function(mouseX,mouseY){

	if (mouseX > this.x && (this.x + this.width) > mouseX && mouseY > this.y && (this.y + this.height) > mouseY){
		this.obj.style.background = "#00FF00";
		console.log(this.obj.style.top);
		this.obj.style.top = mouseY+"px";
		this.obj.style.left = mouseX+"px";
		this.x = mouseX;
		this.y = mouseY;
	}
}

    




}