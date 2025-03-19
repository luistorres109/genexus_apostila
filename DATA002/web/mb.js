var MnuOptionWidth = 100;
var MnuOptionHeight = 22;
var MnuTimeoutID;
var MnuLayersCollection = new Array();	
var MnuLMaxW = 0;
var MnuLMaxH = 0;

///////////////////////Browser functions
var agt=navigator.userAgent.toLowerCase();
var is_major = parseInt(navigator.appVersion);
var isNS = ((agt.indexOf('mozilla')!=-1) && (agt.indexOf('spoofer')==-1) 
                && (agt.indexOf('compatible') == -1) && (agt.indexOf('opera')==-1) 
                && (agt.indexOf('webtv')==-1)); 
var isNS4 = (isNS && (is_major == 4)); 
var isNS5up = (isNS && (is_major >= 5)); 
var isIE = (agt.indexOf("msie") != -1); 
var is_majorIE = agt.substr( agt.indexOf('msie')+5,3);
var isIE3 = (isIE && (is_majorIE < 4)); 
var isIE4 = (isIE && (is_majorIE == 4)); 
var isIE5up = (isIE  && !isIE3 && !isIE4);


///////////////////////Style for menus
document.write( "<STYLE type=text/css>"+
				".MenuOptionPad { background-color:#0066cc; color:#FFFFFF; font-family:Arial; font-size:10pt}"+
				".MenuOptionSelected { background-color:#000000; color:#FFFFFF; font-family:Arial; font-size:10pt}"+
				"</STYLE>");

///////////////////////Build Tree
function tBuildMenuPad( tree, orient, x, y)
{
	startMasterLayer( tree, orient);
	tBuildPadHTML( tree, 0);
	endMasterLayer();

	MnuLayersCollection = setLayersCollection( MnuLayersCollection, getLayersCollection(tree));
	tSetMenuPad( tree, toNumber(x), toNumber(y), orient, tree.id);
	tSetMasterLayer( tree, MnuLMaxW, MnuLMaxH, orient);
	showLayer( getLayer(tree.id));
}

// tree = menu tree instance
// zorder = zorder in screen
function tBuildPadHTML( tree, zorder)
{
	var str, i;
	if (tree.items.length == 0 ) return;
	str = startLayer( tree.id, MnuOptionWidth, -1, zorder, 0);
	for (i=0;i<tree.items.length;i++) {
		str+=tBuildOptionHTML( "Option"+tree.items[i].id, tree.items[i].text);
		tBuildPadHTML( tree.items[i], zorder+1);
	}
	str += endLayer();
	document.write( str);
}

// x = x pad pos
// y = y pad pos
// orient = "H"-hor; "V"-vert
function tSetMenuPad( tree, x, y, orient, mainTreeName)
{
	var i, supLayer, currLayer;
	if (tree.items.length == 0 ) return;
	supLayer = getLayer(tree.id);
	moveLayer( supLayer, x, y);
	if (orient == "H")
		clipLayer( supLayer, 0, 0, MnuOptionWidth* tree.items.length, MnuOptionHeight);
	else if (orient == "V")
		clipLayer( supLayer, 0,0,MnuOptionWidth,MnuOptionHeight * tree.items.length);
	for (i=0;i<tree.items.length;i++) {
		// Position "option" layer
		setOption( i, tree, supLayer, orient, mainTreeName); 
		currLayer = getLayer(tree.items[i].id);
		if (currLayer){		// has pad
			currLayer.parentMenu = supLayer;
			if (orient == "H") {
				tSetMenuPad( tree.items[i], x+i*MnuOptionWidth, y+MnuOptionHeight, "V", mainTreeName);
				if (MnuLMaxW < x + i*MnuOptionWidth) MnuLMaxW = x + i*MnuOptionWidth;
				if (MnuLMaxH < y) MnuLMaxH = y;
			}
			else if (orient == "V") {
				tSetMenuPad( tree.items[i], x+MnuOptionWidth, y+i*MnuOptionHeight, "V", mainTreeName);
				if (MnuLMaxW < x) MnuLMaxW = x;
				if (MnuLMaxH < y + i*MnuOptionHeight) MnuLMaxH = y + i*MnuOptionHeight;
			}
		}
	}
}

function tBuildOptionHTML( optName, optText )
{
	var str;
	// Hilighted layer
	str = startLayer( 'H'+optName, MnuOptionWidth, -1, '2', 0)+
			'<table border=0 cellpadding=0 cellspacing=0 width="'+MnuOptionWidth+'" height="'+MnuOptionHeight+'" class="MenuOptionSelected"><tr><td>'+
			'<span class="MenuOptionSelected" >'+optText+'</span>'+
			'</td></tr></table>'+
	endLayer();
	// Normal layer
	str += startLayer( 'N'+optName, MnuOptionWidth, -1, '1', -1)+
			'<table border=0 cellpadding=0 cellspacing=0 width="'+MnuOptionWidth+'" height="'+MnuOptionHeight+'" class="MenuOptionPad"><tr><td>'+
			'<span class="MenuOptionPad" >'+optText+'</span>'+
			'</td></tr></table>'+
	endLayer();
	// Dummy layer (for mouse events)
	str += startLayer( 'M'+optName, MnuOptionWidth, MnuOptionHeight, '3', 1)+endLayer();
	return str;
}

function setOption( i, tree, supLayer, orient, mainTreeName)
{
	var lyr;
	if (orient == "H")
		setOptionLayers( supLayer, tree.items[i].id, i*MnuOptionWidth, 0);
	else if (orient == "V")
		setOptionLayers( supLayer, tree.items[i].id, 0, i*MnuOptionHeight);
	// Set mouse layer events
	lyr = getLayer( "MOption"+tree.items[i].id, supLayer);
	setEvents( lyr);
	if (tree.items[i].itemsCount == 0 && tree.items[i].gxId.substr(0,6) != "GxSep_")
		setMouseDown( lyr, optionSelected, tree.items[i].gxId , mainTreeName);
	lyr.gxPad = getLayer(tree.items[i].id);
	lyr.gxContainerPad = supLayer;
	lyr.gxHilightedLayer = getLayer( "HOption"+tree.items[i].id, supLayer);

}

function setOptionLayers( supLayer, layerName, x, y)
{
	var layer;
	layer = getLayer( "HOption"+layerName, supLayer);
	clipLayer( layer, 0, 0, MnuOptionWidth, MnuOptionHeight);
	moveLayer( layer, x, y);
	layer = getLayer( "NOption"+layerName, supLayer);
	clipLayer( layer, 0, 0, MnuOptionWidth, MnuOptionHeight);
	moveLayer( layer, x, y);
	layer = getLayer( "MOption"+layerName, supLayer);
	clipLayer( layer, 0, 0, MnuOptionWidth, MnuOptionHeight);
	moveLayer( layer, x, y);
}

////////////////////////////////////////////////////////////////

function hidePad() 
{
	if (!MnuTimeoutID)
		MnuTimeoutID = setTimeout( hideAll, 500);
	hideLayer( this.gxHilightedLayer);
}

function showPad() 
{
	if (MnuTimeoutID) {
		clearTimeout( MnuTimeoutID);
		MnuTimeoutID = 0;
	}
	hideAll();
	showBranch( this.gxContainerPad );
	if (this.gxPad)
		showLayer( this.gxPad);
	showLayer( this.gxHilightedLayer);
}

function optionSelected()
{
	if (this.gxOptId == "") return;
	//status = 'document.MAINFORM.menu'+this.gxMBName+'.value ="'+this.gxOptId+'"';
	if (document.MAINFORM) {
//		eval( 'document.MAINFORM.menu'+this.gxMBName+'.value ="'+this.gxOptId+'"');
		eval( 'document.MAINFORM._EventName.value = "EMENUBAR.'+this.gxOptId.toUpperCase()+'."');
		document.MAINFORM.submit();
	}
}

function showBranch( lyr) 
{
	showLayer( lyr);
	if (lyr.parentMenu)
		showBranch( lyr.parentMenu);
}

function hideAll()
{
	var i;
	for(i=0;i<MnuLayersCollection.length;i++)
		if (MnuLayersCollection[i].parentMenu)
			hideLayer( MnuLayersCollection[i]);
}

function moveLayer(lyr, x, y) 
{
	if( isIE5up || isNS5up ) {
		lyr.style.left = x;
		lyr.style.top  = y;
	}
	else if( isNS4 )
		lyr.moveTo(x, y);
	if (MnuLMaxW < x) MnuLMaxW = x;
	if (MnuLMaxH < y) MnuLMaxH = y;
		
}

function hideLayer( lyr)
{
	if( isIE5up || isNS5up )
		lyr.style.visibility = 'hidden';
	else if( isNS4 )
		lyr.visibility = 'hidden';
}

function showLayer( lyr)
{
	if( isIE5up || isNS5up)
		lyr.style.visibility = 'visible';
	else if( isNS4 )
		lyr.visibility = 'show';
}

function clipLayer( lyr, x1, y1, x2, y2)
{

	if( isIE5up || isNS5up )
		lyr.style.clip = 'rect(' + y1 + ' ' +  x2 + ' ' + y2 + ' ' + x1 +')';
	else if( isNS4 ) {
		lyr.clip.left=x1;
		lyr.clip.top=y1;
		lyr.clip.right=x2;
		lyr.clip.bottom=y2;
	}
}

function getLayer( lyrName, prnt)
{
	var lyr, i, lyrVec;
	if( isIE5up ) {
		if (arguments.length == 2)
			lyr = prnt.document.all[lyrName];
		else
			lyr = document.all[lyrName];
	}
	else if( isNS5up )
		lyr = document.getElementById(lyrName);
	else if( isNS4 ) {
		if (arguments.length == 2)
			lyrVec = prnt.document.layers;
		else
			lyrVec = MnuLayersCollection;
			//lyr = MnuLayersCollection[lyrName];
			////for(i=0;i<MnuLayersCollection.length && ! lyr ;i++)
			////	if (MnuLayersCollection[i].id = lyrName)
			////		lyr = MnuLayersCollection[i];
		for(i=0;i<lyrVec.length && ! lyr ;i++)
			if (lyrVec[i].id == lyrName)
				lyr = lyrVec[i];
	}

	if (lyr)
		return lyr;
	else
		return 0;
}

function getLayersCollection(tree)
{
	var mnuLayers;
	if( isIE5up || isNS5up ) {
		mnuLayers = new Array();
		getElementLayers( mnuLayers, tree);
		return mnuLayers;
	}
	else if( isNS4 ){
		var arr = new Array();
		var layColl = document.layers['GXMB'+tree.id].document.layers;
		for( i=0; i<layColl.length;i++)  
			arr[arr.length] = layColl[i];
		return arr;
	}
}

function setLayersCollection( layerArr, layerArr1 )
{
	if( isIE5up || isNS5up )
		return layerArr.concat( layerArr1 );
	else if( isNS4 ){
		if ( layerArr.length > 0 )
			return layerArr.concat( layerArr1 );
		else
			return layerArr1;
	}
}

function getElementLayers( arr, tree )
{
	var mnuLayer;
	mnuLayer = document.getElementById(tree.id); 
	if ( ! mnuLayer)
	   return;
	arr[arr.length] = mnuLayer;
	for (var i = 0; i < tree.itemsCount; i++)
	{
		getElementLayers( arr, tree.items[i] );
	}
}

function getMasterLayer(treeName)
{
	if( isIE5up )
		return document.all['GXMB'+treeName];
	else if( isNS5up )
		return document.getElementById('GXMB'+treeName);
	else if( isNS4 )
		return document.layers['GXMB'+treeName];
}

function setEvents( lyr)
{
	if( isIE5up || isNS4) { 
		lyr.onmouseover = showPad;
		lyr.onmouseout = hidePad;
	}
	else if (isNS5up) {
		lyr.addEventListener("mouseover", showPad, false);
		lyr.addEventListener("mouseout", hidePad, false);
	}
}

function setMouseDown( lyr, mouseOverFunc, menuOptionId, mainTreeName)
{
	var obj;
	if( isIE5up || isNS5up )
		obj = lyr; 
	else if( isNS4 )
		obj = lyr.document;
	
	if( isIE5up || isNS4)
		obj.onmousedown = mouseOverFunc;
	else if( isNS5up)
		obj.addEventListener("mousedown", mouseOverFunc, false);
		
	obj.gxOptId = menuOptionId;
	obj.gxMBName = mainTreeName;
}

////////////////////////////////////////////////////////////////

function startLayer( LName, LWidth, LHeight, LZindex, LVis)
{
	var LHeight1;
	var LVis;
	
	if( isIE5up || isNS5up )
	{
		(LHeight != -1) ? LHeight1 = '; height="'+LHeight+'"' : LHeight1 = '';
		if (LVis >= 0)
			(LVis == 1) ? LVis1 = 'visibility:show' : 	LVis1 = 'visibility:hidden';
		else
			LVis1 = '';
		return '<div id="'+LName+'" style="position:absolute; '+LVis1+'; z-index:'+LZindex+'; width:'+LWidth+'; height:'+LHeight+'">';
	}
	else if( isNS4 )
	{
		(LHeight != -1) ? LHeight1 = ' height='+LHeight : LHeight1 = '';
		if (LVis >= 0) 
			(LVis == 1) ? LVis1 = ' visibility="show"' : LVis1 = ' visibility="hidden"';
		else
			LVis1 = '';
		return '<layer name="'+LName+'" width='+LWidth+LHeight1+' z-index='+LZindex+LVis1+' position="relative" >';
	}
	else
		return '';
}

function endLayer()
{
	if( isIE5up || isNS5up )
		return '</div>';
	else if( isNS4 )
		return '</layer>';
	else
		return '';
}

function startMasterLayer(tree, orient)
{
	var LMaxWidth;
	var LMaxHeight;
	
	if (orient == "H"){
		LMaxWidth = tree.items.length* MnuOptionWidth;
		LMaxHeight = MnuOptionHeight;
	} else if (orient == "V"){
		LMaxWidth = MnuOptionWidth;
		LMaxHeight = tree.items.length * MnuOptionHeight;
	}
	if( isIE5up || isNS5up )
		document.write('<div id="GXMB'+tree.id+'" style="position:relative; top:0; width:'+LMaxWidth+'; height:'+LMaxHeight+'">');
	else if( isNS4 )
		document.write('<ilayer name="GXMB'+tree.id+'" top=0 width='+LMaxWidth+' height='+LMaxHeight+' >');
}

function endMasterLayer()
{
	if( isIE5up || isNS5up )
		document.write('</div>');
	else if( isNS4 )
		document.write('</ilayer>');
}

function tSetMasterLayer( tree, LMaxWidth, LMaxHeight, orient)
{
	var mlyr;
	mlyr = getMasterLayer(tree.id);
	clipLayer(mlyr, 0, 0, LMaxWidth+MnuOptionWidth, LMaxWidth+MnuOptionHeight);
}

function toNumber( xx)
{
	var xx1;
	if (xx == "")
		return 0;
	xx1 = parseInt( xx);
	if ( isNaN( xx1))
		return 0;
	return xx1;
}
	
	