function TabControl(Element_Class){

this.elemClass = Element_Class;

this.showContent = function(number){

	var items = document.getElementsByClassName(this.elemClass);
	

	for(var i = 0; i < items.length;i++)
	{
		items[i].style.display = "none";
	}
	
	var changeElem = document.getElementsByClassName(this.elemClass)[number-1];
	changeElem.style.display = "inline-block";

};


}