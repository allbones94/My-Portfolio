function SS(params){

this.counter = 0;


this.sleep = params.milliseconds;
this.test = document.getElementById(params.SSoutput);
this.test.src = params.imagePath+params.images[0];



	this.startSlideShow = function(){
		
		var counter = 0;
		var images = params.images;
		var max = images.length - 1;
		var image = document.getElementById(params.SSoutput);
		
		setInterval(function(){
		counter++;
		image.src = params.imagePath+params.images[counter];
		
		
		
		if (counter == max){
			counter = 0;
			
		}
		
		},this.sleep);
		
	}
	
	this.startSlideShow();
	
	
}