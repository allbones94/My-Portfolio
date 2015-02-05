<?php

class LikeDislikes{

private $no_likes,$no_dislikes,$l_colour,$d_colour,$per_likes,$per_dislikes;
private $width = 400; 
private $height = 10;


public function __construct($likes,$dislikes,$like_colour = "#00FF00",$dislike_colour="#FF0000"){
	$this->no_likes = $likes;
	$this->no_dislikes = $dislikes;
	$this->l_colour = $like_colour;
	$this->d_colour = $dislike_colour;
}

public function setDimensions($width,$height){
		$this->width = $width;
		$this->height = $height;
}

public function outputBar(){
	$total = $this->no_likes + $this->no_dislikes;
	$percentage_likes = ($this->no_likes/$total) * 100; $this->per_likes = $percentage_likes;
	$percentage_dislikes = ($this->no_dislikes/$total) *100; $this->per_dislikes = $percentage_dislikes;
	
	if($this->valuesNumeric() === true){
		return "<div id = 'LDBar' style='height:{$this->height}px; width:{$this->width}px'>
		<div id = 'likes' style='display:inline-block;float:left;height:{$this->height}px;width:{$percentage_likes}%;background:{$this->l_colour}'></div>
		<div id = 'likes' style='display:inline-block;float:left;height:{$this->height}px; width:{$percentage_dislikes}%;background:{$this->d_colour};'></div>
		</div>";
	
	}else{
		return "Invalid data entered";
	}
	
	
}

private function valuesNumeric(){

if(is_numeric($this->no_likes) === true && is_numeric($this->no_dislikes) === true){
	return true;
}else{
	return false;
}

}

public function getLikes(){
	if($this->valuesNumeric() === true){
		return $this->no_likes;
	}
}

public function getDislikes(){
	if($this->valuesNumeric() === true){
		return $this->no_dislikes;
	}
}

public function getLikePercentage(){
	if($this->valuesNumeric() === true){
		return $this->per_likes."%";
	}
}

public function getDislikePercentage(){
	if($this->valuesNumeric() === true){
		return $this->per_dislikes."%";
	}
}


}

?>