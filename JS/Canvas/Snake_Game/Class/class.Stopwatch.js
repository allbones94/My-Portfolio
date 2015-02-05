function Stopwatch(){

	this.start = function(){

		var seconds = 0;
		var minutes = 0;

		this.interval = setInterval(function(){
	
			if (seconds >= 59){
				seconds = 0;
				minutes++;
				console.log("hi");
			}else{
				seconds++;
			}
	
			this.addZeroes = function(number){
				if(number < 10){
					return "0"+number;
				}else{
					return number;
				}
	}
	
			document.getElementById("score").innerHTML = this.addZeroes(minutes)+":"+this.addZeroes(seconds);
		},1000);

	}


	this.stop = function(){
		clearInterval(this.interval);
	}

}