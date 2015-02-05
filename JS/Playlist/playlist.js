// JavaScript Document
function Playlist(params){
this.counter = 0;

this.init = function(){
this.video = document.getElementById(params.video_area);
this.songList = params.items;
this.videoOutput = document.getElementById(params.video_src);
this.listSongs = "";
this.playlistOutput = document.getElementById(params.playlist_output);

this.video.innerHTML = "<video controls autoplay width = '600' height = '400' onEnded='playlist.changeTrack();'><source id = 'src_mp4' src = '"+this.songList[this.counter][1]+"'></video>";

//Makes the List of Songs In The Playlist
for(var i = 0; i < this.songList.length;i++){
	
	if (i == this.counter){
		this.listSongs += "<li>Currently Playing: "+this.songList[i][0]+"</li>";  
	}else{
		this.listSongs += "<li>"+this.songList[i][0]+"</li>";
	}
}

this.playlistOutput.innerHTML = "<ul>"+this.listSongs+"</ul>";
}

this.changeTrack = function(){
	
	if (this.counter !== this.songList.length - 1){ 
		this.counter++;
	}else{
		this.counter = 0;	
	}
	this.init();	
}

}