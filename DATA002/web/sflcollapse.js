function tablestatus(tableName, flag, image, imgExpand, imgCollapse)
{
	table = document.getElementById(tableName);
	if( table.style.display == "none")
	{
		table.style.display = "inline";
		image.src = imgCollapse;
		flag.value = "0";
	}
	else
	{
		table.style.display = "none";
		image.src = imgExpand;
		flag.value = "1";
	}
}
