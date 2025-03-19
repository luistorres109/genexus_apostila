var activeObject = null;
var enter = false;
var GXLastKeyCode;
var GXBShiftPressed;
var GXLastEvtControl = null;
var GXKeyListener = new Object;
var GXDefKeyListener = new Array;
var GXKeyHandler = new Object;
var GXKeyListenerContext = new Object;
var GXSkipOnEnter = false;

function setEnterEvent(event)
{
  document.forms[0]._EventName.value = GXWCP+'EENTER.';
	if (navigator.appName != "Netscape")
	activeObject = document.activeElement;
	if ((activeObject == undefined) && (event != undefined) && event.target)
		activeObject = event.target;
	enter=true;
}

function gxcancelEvent(event, cancel)
{
	if (event.preventDefault == undefined)
	{
		event.cancelBubble = cancel;
		event.returnValue = !cancel;
	}
	else
	{				
		if (cancel)
		{
			event.preventDefault();
			event.stopPropagation();
		}
	}
}

function gxSpecialKey( evtKeyCode)
{
  return  ((evtKeyCode > 0 && evtKeyCode <16) ||               // non printables
          (evtKeyCode> 16 && evtKeyCode <32) ||  // avoid shift
          (evtKeyCode> 32 && evtKeyCode <41) ||  // navigation keys
          evtKeyCode == 46)                 // Delete Key
}

function form_onkeypress(xevent, hasenter, skiponenter)
{
	if ((xevent==null) && (!window.event)) { return; }
	if ((xevent!=null) && (window.event)) { return; }
	var event = (xevent==null ? window.event : xevent);
	
	if (GXFormDisabled == true || (gxInvalidDSPKey(event) && isGXTrn() && window['Gx_mode'] == 'DSP'))
	{
		gxcancelEvent( event, true);
		if (window.event != undefined)
			event.keyCode = 0;
		return false;
	}

	var cancel;
	GXLastKeyCode = event.keyCode;
	GXShiftPressed = event.shiftKey;
	GXSkipOnEnter = skiponenter;
	
	if (gxChkFncKey(event) == true)
	  return false;
	
	activeObject = document.activeElement || event.target || GXLastFocusCtrlRef;

	gxUpdateLastFocus( activeObject);
	
	if (event.keyCode == 13)
	{
		if (skiponenter)
		{
			if (gxEnterBtnHasFocus() && (hasenter || GXWCP.length > 0))
				setEnterEvent(event);
			else
			{
				gxSkipFocus();
				gxcancelEvent(event, true);
				enter=false;
			}
		}
		else
		{
			if( hasenter || GXWCP.length > 0)
			{
				setEnterEvent(event);
			}
			else
			{
				cancel = true;

				if(activeObject != null)
				{
					if( activeObject.nodeName == "A" || activeObject.nodeName == "TEXTAREA")
					{
						cancel = false;
					}
					else if( activeObject.nodeName == "INPUT")
					{
						if(	activeObject.attributes.item('type').value == "submit" ||
						    activeObject.attributes.item('type').value == "image")
						{
							cancel = false;
						}
					}
				}

				gxcancelEvent(event, cancel);
				enter=false;
			}
		}
	}
  if (activeObject.nodeName == "TEXTAREA")
  { 
    if (!gxSpecialKey( event.keyCode))
    {
      if (activeObject.nodeName == "TEXTAREA")
      var MaxLength = activeObject.getAttribute("maxlength");
      if ( MaxLength > 0 && activeObject.value.length >= MaxLength && gxGetSelection().length == 0)
		    gxcancelEvent(event, true);
    }
  }
}

function gxInvalidDSPKey(evt)
{
	if (evt.keyCode == 13)
	{
		return true;
	}
	return false;
}

function gxUpdateLastFocus( Ctrl)
{
	if (Ctrl != null)
	{
		if ( Ctrl.nodeName == "A" || Ctrl.nodeName == "TEXTAREA" || Ctrl.nodeName == "INPUT" || Ctrl.nodeName == "IMG")
		{
			GXLastFocusCtrlRef = Ctrl;
		}
	}
}

function gxGetSelection()
{
	return (!!document.getSelection) ? document.getSelection() :
	       (!!window.getSelection)   ? window.getSelection() :
	       document.selection.createRange().text;
}

function GX_setevent( Name)
{
	var cancel;
	var triggerEvent = ctrlTriggersEvents();
	
	if(!document.forms[0]._EventName || ((enter == true) && !triggerEvent))
	{
		return;
	}

	cancel = true;

	if (enter && activeObject != null)
	{
		if( triggerEvent)
		{
			cancel = false;
		}
	}
	else
	{
		cancel = false;
	}
	if( !cancel)
	{
		document.forms[0]._EventName.value = Name;
	}
}

function ctrlTriggersEvents()
{
	if (activeObject != null)
	{
		if( activeObject.nodeName == "A" || activeObject.nodeName == "TEXTAREA")
		{
			return true;
		}
		else if(activeObject.nodeName == "INPUT")
		{
			if ( activeObject.attributes.item('type').value == "submit" || activeObject.attributes.item('type').value == "image")
			{
				return true;
			}
		}
	}
	return false;
}

function GX_setgridevent( GridId, RowId)
{
  document.forms[0]._EventGridId.value = GridId;
	document.forms[0]._EventRowId.value = RowId;
}

function gxaddKeyListener( EventName , nKey )
{
	if (nKey == 1)
		document.body.onhelp = function() {return false;}
	if (GXKeyListener[nKey] == undefined)
	  GXKeyListener[nKey] = new Array();
	GXKeyListener[nKey]['_'] = EventName;
	if (GXDefKeyListener[nKey] == undefined)
	  GXDefKeyListener[nKey] = {evt:EventName, ctx:''};
}

function gxaddKeyHandler( EventName , nKey )
{
	if (nKey == 1)
		document.body.onhelp = function() {return false;}
	if (GXKeyHandler[nKey] == undefined)
	  GXKeyHandler[nKey] = new Array();
	GXKeyHandler[nKey]['_'] = EventName;
}

function gxaddWCKeyListener( CmpContext, nKey, EventName )
{
	if (nKey == 1)
		document.body.onhelp = function() {return false;}
	if (GXKeyListener[nKey] == undefined)
	  GXKeyListener[nKey] = new Array();
	GXKeyListener[nKey][CmpContext] = EventName;
	if (GXDefKeyListener[nKey] == undefined)
	  GXDefKeyListener[nKey] = {evt:EventName, ctx:CmpContext};
}

function gxaddWCKeyHandler( CmpContext, nKey, EventName )
{
	if (nKey == 1)
		document.body.onhelp = function() {return false;}
	if (GXKeyHandler[nKey] == undefined)
	  GXKeyHandler[nKey] = new Array();
	GXKeyHandler[nKey][CmpContext] = EventName;
}

function gxFireEvent( event, EvtName)
{
	document.forms[0]._EventName.value = EvtName;
	gxcancelEvent(event, true);
  if (window.event != undefined)
		event.keyCode = 0;
	gxSubmit();
	return true;
}

function gxChkFncKey(event)
{
  var fnGXWCP = GXWCP;
  if (fnGXWCP == '')
    fnGXWCP = '_';
	var FncKey = GXLastKeyCode - 111;
	if (GXShiftPressed)
	  FncKey += 12;
	if (FncKey > 0 && FncKey <=  12 && (GXKeyListener[FncKey] != undefined))
	{
	  if (GXKeyListener[FncKey][fnGXWCP] != undefined)
	    return gxFireEvent( event, GXWCP + "E'"+GXKeyListener[FncKey][fnGXWCP] + "'.");
	  if (GXDefKeyListener[FncKey] != undefined)
	    return gxFireEvent( event, GXDefKeyListener[FncKey].ctx + "E'"+GXDefKeyListener[FncKey].evt + "'.");
	}
	if (FncKey > 0 && FncKey <=  24 && (GXKeyHandler[FncKey] != undefined))
	{
	  
	  if (GXKeyHandler[FncKey][fnGXWCP] != undefined)
	  {
	    if (GXKeyHandler[FncKey][fnGXWCP] == 'HELP')
	    {
	      var Ctrl = GXgetControlRef( "BTN_HELP");
        if (Ctrl == null)
          return false;
	      Ctrl.onclick();
      	gxcancelEvent(event, true);
    		if (window.event != undefined)
    			event.keyCode = 0;
      	return true
	    }
	    else
	    {
  	    if (GXKeyHandler[FncKey][fnGXWCP] == 'SELECT')
	      {
	        var Ctrl = GXgetControlRef( "BTN_SELECT");
	          if (Ctrl == null)
	            return false;
	        Ctrl.onclick();
      		gxcancelEvent(event, true);
  	  		if (window.event != undefined)
      		  event.keyCode = 0;
      		return true;
	      }
	      else
	      {
	        if (GXKeyHandler[FncKey][fnGXWCP] == 'CANCEL')
  	      {
	          var Ctrl = GXgetControlRef( "BTN_CANCEL");
	          if (Ctrl == null)
	            return false;
	          Ctrl.onclick();
        		gxcancelEvent(event, true);
  	  	  	if (window.event != undefined)
        		  event.keyCode = 0;
        		return true;
	        }
  	      else
      	    return gxFireEvent( event, GXWCP + "E"+GXKeyHandler[FncKey][fnGXWCP] + ".");
        }
      }
    }
  }
	return false;
}
