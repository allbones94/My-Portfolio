this.canvas = document.getElementById('myCanvas');
this.ctx = canvas.getContext('2d');
var stopwatch = new Stopwatch();

//Start Menu
var btn_play = new Button({context:ctx,w:150,h:60,x:500,y:400,text:"PLAY GAME"});
var logo = new Bitmap({context:ctx,x:100,y:200,id:"logo_pic"});
var background = new Background({context:ctx,w:50,h:50,x:0,y:0,bg:"#DFDFD0"});


//level 1 Obstacles;
var lvl_1_ob1 = new obstacle({context:ctx, x:200,y:50,w:100,h:20,min:0,direction:"down"});
var lvl_1_ob2 = new obstacle({context:ctx, x:390,y:100,w:100,h:20,min:0,direction:"down"});
var lvl_1_ob3 = new obstacle({context:ctx, x:570,y:150,w:100,h:20,min:0,direction:"down"});
var lvl_1_ob4 = new obstacle({context:ctx, x:740,y:200,w:100,h:20,min:0,direction:"down"});
var lvl_1_ob5 = new obstacle({context:ctx, x:900,y:250,w:100,h:20,min:0,direction:"down"});
var lvl_1_ob6 = new obstacle({context:ctx, x:1100,y:300,w:100,h:20,min:0,direction:"down"});


//level 2 Obstacles
var lvl_2_ob1 = new obstacle({context:ctx, x:500,y:0,w:20,h:100,min:200,direction:"left"});
var lvl_2_ob2 = new obstacle({context:ctx, x:250,y:150,w:20,h:100,min:200,direction:"right"});
var lvl_2_ob3 = new obstacle({context:ctx, x:500,y:300,w:20,h:100,min:200,direction:"left"});
var lvl_2_ob4 = new obstacle({context:ctx, x:250,y:450,w:20,h:100,min:200,direction:"right"});
var lvl_2_ob5 = new obstacle({context:ctx, x:500,y:0,w:20,h:100,min:200,direction:"right"});
var lvl_2_ob6 = new obstacle({context:ctx, x:400,y:150,w:20,h:100,min:200,direction:"left"});
var lvl_2_ob7 = new obstacle({context:ctx, x:500,y:300,w:20,h:100,min:200,direction:"right"});
var lvl_2_ob8 = new obstacle({context:ctx, x:400,y:450,w:20,h:100,min:200,direction:"left"});
var lvl_2_ob9 = new obstacle({context:ctx, x:500,y:0,w:100,h:100,min:0,direction:"up"});
var lvl_2_ob10 = new obstacle({context:ctx, x:750,y:450,w:100,h:100,min:0,direction:"down"});

//End Game Objects only 
var btn_playagain = new Button({context:ctx,w:450,h:60,x:400,y:400,text:"IT TOOK 00:00 TO COMPLETE, PLAY AGAIN?"});

//player
var player = new Player({context:ctx, x:0,y:300,w:30,h:30,direction:"right",bg:"#0000FF"});


//event listener detects which arrow key has been pressed and acts accordingly
document.addEventListener("keydown",function(e){
	if (e.keyCode == 37 && player.direction != "right"){
		player.direction = "left";
	}
	else if(e.keyCode == 38 && player.direction != "down"){
		player.direction = "up";
	}
	else if(e.keyCode == 39 && player.direction != "left"){
		player.direction = "right";
	}
	else if(e.keyCode == 40 && player.direction != "up"){
		player.direction = "down";
	}

});


canvas.addEventListener("mousemove",function(e){

	mouseX = e.pageX;
	mouseY = e.pageY;
	btn_play.hovercheck(mouseX,mouseY);
	btn_playagain.hovercheck(mouseX,mouseY);
	
});

canvas.addEventListener("click",function(e){
	
	//Uses return of obj,hovercheck() method 
	if (btn_play.clickButtonCheck(mouseX,mouseY) == true || btn_playagain.clickButtonCheck(mouseX,mouseY) == true ){
		player.level = 1;
		stopwatch.start();
	};
	
});

function collisionTest(player,obstacles){

	var pl_width = player["w"], pl_height = player["h"], pl_x=player["x"], pl_y= player["y"];

	for (var i = 0; i < obstacles.length; i++){
		var ob_width = obstacles[i]["w"], ob_height = obstacles[i]["h"], ob_x=obstacles[i]["x"], ob_y= obstacles[i]["y"];

		if (pl_y + pl_height >= ob_y && pl_x + pl_width >= ob_x && pl_y <= ob_y + ob_height && pl_x <= ob_x + ob_width){
		player.restart();
		}
	}
}

function gameLoop(){
  // Clear canvas for redraw
  ctx.clearRect(0, 0, canvas.width, canvas.height);
  
  background.draw();
  var start_screen = new compoundDrawable([btn_play,logo]);
  var level1 = new compoundMoveable([player,lvl_1_ob1,lvl_1_ob2,lvl_1_ob3,lvl_1_ob4,lvl_1_ob5,lvl_1_ob6]);
  var level2  = new compoundMoveable([player,lvl_2_ob1,lvl_2_ob2,lvl_2_ob3,lvl_2_ob4,lvl_2_ob5,lvl_2_ob6,lvl_2_ob7,lvl_2_ob8,lvl_2_ob9,lvl_2_ob10]);
  
  
  //Checks level of player and sets scene accordingly;
  if(player.level == 0.5){
		
		start_screen.init();
	
	}else if(player.level == 1){
		
		level1.init();
		collisionTest(player,[lvl_1_ob1,lvl_1_ob2,lvl_1_ob3,lvl_1_ob4,lvl_1_ob5,lvl_1_ob6]);

	}else if(player.level == 2){
	
		level2.init();
		collisionTest(player,[lvl_2_ob1,lvl_2_ob2,lvl_2_ob3,lvl_2_ob4,lvl_2_ob5,lvl_2_ob6,lvl_2_ob7,lvl_2_ob8,lvl_2_ob9,lvl_2_ob10]);
		
	}else{
		
		stopwatch.stop();
		btn_playagain.text = "IT TOOK "+document.getElementById("score").innerHTML+" TO COMPLETE, PLAY AGAIN?";
		btn_playagain.draw();
		logo.draw();
		
	}
 // Wait, then repeat
  requestAnimFrame(gameLoop);
}
gameLoop();

