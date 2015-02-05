function SS(params){

this.counter = 0;
this.images = params.images;
this.max = this.images.length - 1;
this.test = document.getElementById(params.SSoutput);
this.test.src = params.imagePath+this.images[this.counter];
this.prevBtn = document.getElementById(params.prevBtn);
this.nextBtn = document.getElementById(params.nextBtn);
this.prevBtn.disabled = true;

	this.slideRight = function(){
		this.counter++;
		this.test.src = params.imagePath+params.images[this.counter];
		
		if (this.counter == this.max){
			this.nextBtn.disabled = true;
			this.prevBtn.disabled = false;
		}
		
	}
	
	this.slideLeft = function(){
		this.counter--;
		this.test.src = params.imagePath+params.images[this.counter];
		
		
		if (this.counter == 0){
			this.prevBtn.disabled = true;
			this.nextBtn.disabled = false;
		}
		
	}
	
	
}