var gxBallonList = new Array();
var timerRunning = false;

function isUnset( id)
{
  this.element = document.getElementById( id);
  if (element.innerHTML == "unset")
    return true;
  if (element.innerHTML == "")
    return true;
  return false;
}

function GXgetMessage( Code)
{
	if (Code == "inex")
		return "Inexistente";
		
	switch (Code) 
	{
   		case "inex" : message = "Codigo inexistente";
	      	break;
	   	
	   	default : message = "Error";
	}
	return message;	
}

function gxBalloon()
{
	this.init = function( id)
	{
		this.hide();
		this.id = id;	
		this.balloonid = id + "_Balloon";
		this.hasMessage = false;
		this.messageErr = '';
		this.messageWar = '';
		this.isError = false;
	}
	
	this.setMessage = function(message)
	{
		this.messageWar += message+'<BR>';
		this.hasMessage = true;
	}

	this.setError = function(message)
	{
		this.messageErr += message+'<BR>';
		this.isError = true;
		this.hasMessage = true;
	}

	this.show = function()
	{
		if (document.readyState != undefined && document.readyState != 'complete')
			return;
		try
		{
			if (this.hasMessage == false)
				return true;
			var BalloonControl = document.getElementById( this.balloonid);
			Control = GXgetControlRef_impl( this.id);
			if(Control.type == 'hidden')
			{
				var spanControl = GXgetControlRef_impl( 'span_' + this.id);
				if(spanControl != null)
					Control = spanControl;
			}
			if (BalloonControl == null)
			{
				BalloonControl = document.createElement("SPAN");
				BalloonControlShadow = document.createElement("SPAN");
				BalloonControlShadow2 = document.createElement("SPAN");
				IFrameControl = document.createElement("IFRAME");
				BalloonControl.id = this.balloonid;
				BalloonControlShadow.id = this.balloonid + "Shadow";
				BalloonControlShadow2.id = this.balloonid + "Shadow2";
				IFrameControl.id= this.balloonid + "GXiFrameIEHack";
				IFrameControl.src = "javascript:undefined";
				IFrameControl.style.zIndex = 1;
				IFrameControl.style.visibility = "hidden";
				IFrameControl.style.position = "absolute";
				IFrameControl.frameBorder= "0";
			
				document.body.appendChild( BalloonControl);
				document.body.appendChild( BalloonControlShadow);
				document.body.appendChild( BalloonControlShadow2);
				document.body.appendChild( IFrameControl);
				
			}
			var Coord = GXgetPosition( Control);
			var CoordTop = parseInt(Coord.top);
			var CoordLeft = parseInt(Coord.left);
			
			var sHTML;
			sHTML = "<span style='white-space:nowrap;position: absolute; top:" +  CoordTop + "px; left:" + CoordLeft + "px;z-index:3' >"
			if (this.messageErr.length > 0)
			{
				sHTML += "<div class='ErrorMessages'>";
				sHTML += this.messageErr;
				sHTML +="</div><span style='height:4px;overflow:hidden'></span>";
			}
			if (this.messageWar.length > 0)
			{
				sHTML += "<div class='WarningMessages'>";
				sHTML += this.messageWar;
				sHTML +="</div>";
			}
			sHTML +="</span>";

			BalloonControl.innerHTML = sHTML;
			
			var shadowWidth = 2;
			
			CoordTop -= BalloonControl.lastChild.offsetHeight - shadowWidth;
			
			sHTML = "<span style='white-space:nowrap;position: absolute; top:" +  CoordTop + "px; left:" + CoordLeft + "px;z-index:3' >"
			if (this.messageErr.length > 0)
			{
				sHTML += "<div class='ErrorMessages'>";
				sHTML += this.messageErr;
				sHTML +="</div><span style='height:4px;overflow:hidden'></span>";
			}
			if (this.messageWar.length > 0)
			{
				sHTML += "<div class='WarningMessages'>";
				sHTML += this.messageWar;
				sHTML +="</div>";
			}
			sHTML +="</span>";

			BalloonControl.innerHTML = sHTML;
			
			IFrameControl.style.visibility = "visible";		
			IFrameControl.style.height = BalloonControl.firstChild.firstChild.offsetHeight;
			IFrameControl.style.width = BalloonControl.lastChild.offsetWidth;
			IFrameControl.style.top	= CoordTop;
			IFrameControl.style.left = CoordLeft;
			
			CoordTop += shadowWidth;
			CoordLeft += shadowWidth;
			
			if (this.messageErr.length > 0)
			{
				sHTML ="<span style='position: absolute;border-style:none;";
				sHTML += "top:" +  CoordTop + "px; left:" + CoordLeft + "px;";
				sHTML += "width:" + BalloonControl.lastChild.offsetWidth + "px;" + " height:" + BalloonControl.firstChild.firstChild.offsetHeight + "px;";  
				sHTML += "z-index:2;background-color:ThreeDDarkShadow;' class='ErrorMessages'></span>";
				BalloonControlShadow.innerHTML = sHTML;
				CoordTop += BalloonControl.firstChild.firstChild.offsetHeight + 4;
			}

			if (this.messageWar.length > 0)
			{
				sHTML ="<span style='position: absolute;border-style:none;";
				sHTML += "top:" +  CoordTop + "px; left:" + CoordLeft + "px;";
				sHTML += "width:" + BalloonControl.lastChild.offsetWidth + "px;" + " height:" + BalloonControl.firstChild.lastChild.offsetHeight + "px;";  
				sHTML += "z-index:2;background-color:ThreeDDarkShadow;' class='ErrorMessages'></span>";
				BalloonControlShadow2.innerHTML = sHTML;
			}
			
			if (timerRunning == false)
			{
				timerRunning = true;
				this.timerId = setTimeout( "GXTimeoutTip()", 4000);
			}
		}
		catch (E){}
		return !this.isError;
	}

	this.hide = function()
	{
		try
		{
			ctrl = document.getElementById( this.balloonid+"Shadow");
			if (ctrl != null)
				GXRemoveElement( ctrl);
			ctrl = document.getElementById( this.balloonid+"Shadow2");
			if (ctrl != null)
				GXRemoveElement( ctrl);
			ctrl = document.getElementById( this.balloonid);
			if (ctrl != null)
				GXRemoveElement( ctrl);
			ctrl = document.getElementById( this.balloonid + "GXiFrameIEHack");
			if (ctrl != null)
				GXRemoveElement( ctrl);
		}
		catch (e){
			}
	}
}

function GXRemoveElement( ctrl)
{
	if (document.createRange == null)
		ctrl.removeNode( true);
	else
	{
		range = document.createRange();
		if (ctrl)
		{
			range.selectNode( ctrl);
			range.deleteContents();
		}	
	}
}

function GXTimeoutTip()
{
	timerRunning = false;
	while (DelBalloon = gxBallonList.pop())
		DelBalloon.hide();
}

function getGXGridBallon(id, RowId)
{
	return getGXBallon(id + "_" + RowId)
}

function getGXBallon(Id)
{
	Id = GXCmpControlId( Id);
	singlegxBallon = new gxBalloon();
	gxBallonList.push(singlegxBallon);
	singlegxBallon.init(Id);
	return singlegxBallon;
}

function GXgetPosition( Ctrl)
{
	var XCtrl = Ctrl;
	var LeftCoord = 0;
	var TopCoord = 0;
	while( XCtrl.tagName != "BODY")
	{
		LeftCoord += XCtrl.offsetLeft;
		TopCoord += XCtrl.offsetTop;
		XCtrl = XCtrl.offsetParent;	
	}
	XCtrl = Ctrl;
	while( XCtrl.tagName != "BODY")
	{
        LeftCoord -= XCtrl.scrollLeft;
        TopCoord -= XCtrl.scrollTop;
        XCtrl = XCtrl.parentNode;
    }
	return {left:LeftCoord, top:TopCoord};
}