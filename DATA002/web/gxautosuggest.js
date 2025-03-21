function AutoSuggestControl( oTextbox, oProvider, ControlRefresh, typeahead, suggestParms) 
{
    this.cur = -1;
    this.layer = null;
    this.provider = oProvider;
    this.textbox = oTextbox;
	if( this.textbox.GXonblur == undefined)
    	this.textbox.GXonblur = oTextbox.onblur;
    this.ControlRefresh = ControlRefresh;
    this.init();
    this.typeahead = typeahead;
    this.suggestParms = suggestParms || new Array();
}

AutoSuggestControl.prototype.pickvalue = function (Value)
{
    for (var i=0; i < this.aSuggestions.length; i++) 
    {
    	if (this.aSuggestions[i].d == Value)
    	{
			  this.textbox.value = Value;
			  gxExecuteOnChange( this.textbox);
			  return;
		  }
	  }
}

AutoSuggestControl.prototype.autosuggest = function (aSuggestions, bTypeAhead) 
{
  this.aSuggestions = aSuggestions;
	if (bTypeAhead & this.aSuggestions != null && this.aSuggestions.length == 1)
	{
    	this.typeAhead( this.aSuggestions[0].d); 
    	this.hideSuggestions();
  }
	else
	{
		if (this.textbox == GXLastFocusCtrlRef && this.aSuggestions != null && this.aSuggestions.length > 0)
		{
		  if ((this.aSuggestions.length == 1) && (this.aSuggestions[0].d != this.textbox) 
		    || (this.aSuggestions.length > 1)) 
		  {
		  	this.showSuggestions(this.aSuggestions);
		  	return;
		  }
		}
    this.hideSuggestions();
  }
};

AutoSuggestControl.prototype.createDropDown = function () {

    var oThis = this;

    this.layer = document.createElement("div");
    this.layer.className = "suggestions";
    this.layer.style.visibility = "hidden";
    this.layer.style.width = this.textbox.offsetWidth;
    this.layer.id = 'gxAutosuggestElement';
    
    this.layer.onmousedown = 
    this.layer.onmouseup = 
    this.layer.onmouseover = function (oEvent) {
        oEvent = oEvent || window.event;
        oTarget = oEvent.target || oEvent.srcElement;

        if (oEvent.type == "mousedown") {
            oThis.pickvalue(oTarget.firstChild.nodeValue);
            oThis.hideSuggestions();
            window.setTimeout(function(){gxSetControlFocus( oThis.textbox)}, 100);
        } else if (oEvent.type == "mouseover") {
            oThis.highlightSuggestion(oTarget);
        } else {
            oThis.textbox.focus();
        }
    };
    document.body.appendChild(this.layer);
};

AutoSuggestControl.prototype.getLeft = function (){

    var oNode = this.textbox;
    var iLeft = 0;
    
    while(oNode.tagName != "BODY") {
        iLeft += oNode.offsetLeft;
        oNode = oNode.offsetParent;
    }        
    oNode = this.textbox;
    while(oNode.tagName != "BODY") {
        iLeft -= oNode.scrollLeft;
        oNode = oNode.parentNode;
    }
    return iLeft;
};

AutoSuggestControl.prototype.getTop = function (){

    var oNode = this.textbox;
    var iTop = 0;

    while(oNode.tagName != "BODY") {
        iTop += oNode.offsetTop;
        oNode = oNode.offsetParent;
    }
    oNode = this.textbox;
    while(oNode.tagName != "BODY") {
        iTop -= oNode.scrollTop;
        oNode = oNode.parentNode;
    }
    return iTop;
};

AutoSuggestControl.prototype.handleKeyDown = function (oEvent) {
    switch(oEvent.keyCode) 
    {    	
        case 38: //up arrow
            this.previousSuggestion();
            break;
        case 40: //down arrow 
            this.nextSuggestion();
            break;
        case 13: //enter
            this.hideSuggestions();
            break;
    }
};

AutoSuggestControl.prototype.handleKeyUp = function (oEvent /*:Event*/) {
    var iKeyCode = oEvent.keyCode;

    if (iKeyCode == 9) 
    {
        this.hideSuggestions();
    }
	else
	{
	    if (iKeyCode == 8 || iKeyCode == 46) 
	    {
	        this.requestSuggestions(this, this.provider, false);
	    } 
	    else 
	    {
	    	if (iKeyCode < 32 || (iKeyCode >= 33 && iKeyCode < 46) || (iKeyCode >= 112 && iKeyCode <= 123))
	    	{
	    	} 
	    	else 
	    	{
	        	this.requestSuggestions(this, this.provider, this.typeahead);
	    	}
	    }
	}
};

function firesuggest( context, provider, typeahead, suggestParms){
	updateSuggestParms( suggestParms);
	if (context.textbox.value != "")
		provider.requestSuggestions( context, typeahead);
};

AutoSuggestControl.prototype.requestSuggestions = function( context, provider, typeahead) 
{
	var suggestParms = this.suggestParms;
	if (this.timer != undefined)
		window.clearTimeout( this.timer);
	this.timer = window.setTimeout(function(){firesuggest(context, provider, typeahead, suggestParms)}, 400);
};

AutoSuggestControl.prototype.hideSuggestions = function () 
{
	if (this.IFrameControl != undefined)
		this.IFrameControl.style.visibility = "hidden";
    this.layer.style.visibility = "hidden";
};

AutoSuggestControl.prototype.highlightSuggestion = function (oSuggestionNode) {
    
    for (var i=0; i < this.layer.childNodes.length; i++) {
        var oNode = this.layer.childNodes[i];
        if (oNode == oSuggestionNode) {
            oNode.className = "current"
        } else if (oNode.className == "current") {
            oNode.className = "";
        }
    }
};

AutoSuggestControl.prototype.init = function () {

    var oThis = this;
    
    this.textbox.onkeyup = function (oEvent) {
    
        if (!oEvent) {
            oEvent = window.event;
        }       
        oThis.handleKeyUp(oEvent);
    };
    this.textbox.onkeydown = function (oEvent) {
    
        if (!oEvent) {
            oEvent = window.event;
        }      
        oThis.handleKeyDown(oEvent);
    };
    
    this.textbox.onblur = function () {
        oThis.hideSuggestions();
        oThis.textbox.GXonblur();
    };
    
    this.createDropDown();
};

AutoSuggestControl.prototype.nextSuggestion = function () {
    var cSuggestionNodes = this.layer.childNodes;

    if (cSuggestionNodes.length > 0) 
    {
    	this.cur = (this.cur < cSuggestionNodes.length-1) ? this.cur + 1:0;
        var oNode = cSuggestionNodes[this.cur];
        this.highlightSuggestion(oNode);
        this.pickvalue( oNode.firstChild.nodeValue); 
    }
};

AutoSuggestControl.prototype.previousSuggestion = function () {
    var cSuggestionNodes = this.layer.childNodes;

    if (cSuggestionNodes.length > 0) 
    {
    	this.cur = (this.cur > 0) ? this.cur - 1:cSuggestionNodes.length-1;
        var oNode = cSuggestionNodes[this.cur];
        this.highlightSuggestion(oNode);
        this.pickvalue( oNode.firstChild.nodeValue);   
    }
};

AutoSuggestControl.prototype.selectRange = function (iStart /*:int*/, iLength /*:int*/) {

    if (this.textbox.createTextRange) {
        var oRange = this.textbox.createTextRange(); 
        oRange.moveStart("character", iStart); 
        oRange.moveEnd("character", iLength - this.textbox.value.length);      
        oRange.select();
        
    } else if (this.textbox.setSelectionRange) {
        this.textbox.setSelectionRange(iStart, iLength);
    }     

    this.textbox.focus();      
}; 

AutoSuggestControl.prototype.showSuggestions = function (aSuggestions) {
	this.cur = -1;
    var oDiv = null;
    this.layer.innerHTML = "";

	if (this.IFrameControl == undefined)
	{
		this.IFrameControl = document.createElement("IFRAME");
		this.IFrameControl.src = "about:blank";
		this.IFrameControl.style.zIndex = 1;
		this.IFrameControl.style.visibility = "hidden";
		this.IFrameControl.style.position = "absolute";
		this.IFrameControl.frameBorder= "0";
		document.body.appendChild( this.IFrameControl);
	}
    
    for (var i=0; i < aSuggestions.length; i++) {
        oDiv = document.createElement("div");
        oDiv.appendChild(document.createTextNode(aSuggestions[i].d));
		oDiv.style.width = this.textbox.offsetWidth;
        this.layer.appendChild(oDiv);
    }
    this.layer.style.left = this.getLeft() + "px";
    this.layer.style.top = (this.getTop()+this.textbox.offsetHeight) + "px";
    this.layer.style.visibility = "visible";
	this.layer.style.zIndex = 2;
	this.IFrameControl.style.top = this.layer.style.top;
	this.IFrameControl.style.left = this.layer.style.left;
	this.IFrameControl.style.height = this.layer.offsetHeight;
	this.IFrameControl.style.width = this.layer.offsetWidth;
    this.IFrameControl.style.visibility = "visible";		

};

AutoSuggestControl.prototype.typeAhead = function (sSuggestion) {

    if (this.textbox.createTextRange || this.textbox.setSelectionRange){
        var iLen = this.textbox.value.length; 
        this.pickvalue( sSuggestion); 
        if (iLen < sSuggestion.length)
       		this.selectRange(iLen, sSuggestion.length);
    }
};