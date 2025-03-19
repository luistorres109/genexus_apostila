var GXLastValidRow;
var GXInvalidCtrlNum = '';
var GXFromValid=0;
var GXToValid=0;
var GXLastFocusCtrl=0;
var GXLastCurrentGrid=0;
var GXFocusCtrl;
var GXInvalidCtrl;
var GXInvalidFrmtCtrl;
var GXLastFocusCtrlRef=null;
var GXOldValue = new Array();
var GXCurrentRow = new Array();
var GXOldKeyValue = new Array();
var GXWCP = '';
var WCSV_ctx = '_';
var GXDisableFocus = false;
var GXNewRow = new Array();
var GXModifiedRows = new Array();
var gxSuggestControls = new Array();
var gxAttachedControls = [];
var gxDisabledControls = new Object;
var GXUserFocus=null;
var GXLastEvtControl=null;
var GXFormDisabled = false;
var GXOnchageTriggered = new Array();
var GXDomCache = [];
var GXModalNode = null;

function gxGetCachedCtrl( CtrlId)
{
	for (var j=0; j<GXDomCache.length; j++)
      {
      	  var aCtrl = GXDomCache[j];
            if (aCtrl.id == CtrlId)
                  return aCtrl.ctrl;
      }
      return null;
}

function gxAddCachedCtrl(CtrlId, Ctrl)
{
	GXDomCache.push( {id:CtrlId, ctrl:Ctrl});
}

function gxChangeCachedCtrl( CtrlId, Ctrl)
{
	for (var j=0; j<GXDomCache.length; j++)
      {
      	  var aCtrl = GXDomCache[j];
            if (aCtrl.id == CtrlId)
            {
                  aCtrl.ctrl = Ctrl;
                  break;
            }
      }
}

function gxpushElement( O, Element, Key)
{
	if (typeof(O[Key]) == "undefined")
			O[Key] = Element;
}

var gxCtrlKeyCode = [ 	0x03, 0x06, 0x08, 0x09, 0x0C, 0x0D, 0x0E, 0x10, 0x11, 0x12, 0x13, 
						0x14, 0x1B, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 
						0x2C, 0x2D, 0x2E];
 							
function isCtrlKeyCode( Code)
{
	for (var i=0; i<gxCtrlKeyCode.length;i++)
	{
		if (Code == gxCtrlKeyCode[i])
			return true;
	}
	return false;
}
function valid_decimal( Elem, ThSep, DecPoint, Dec)
{
	var ctrlValue = Elem.value;
	var pointIdx = ctrlValue.lastIndexOf(DecPoint);
	if (DecPoint==',' && pointIdx==-1)
	{	
		ctrlValue = ctrlValue.replace( '.', DecPoint);
	}
	var gx_DecRegExp = new RegExp("^[ ]*([+-]?[0-9]*(\\" + ThSep + "[0-9]{3})*(\\" + DecPoint + "[0-9]*)?)?[ ]*$");
	if (gx_DecRegExp.test( ctrlValue))
	{
		pointIdx = ctrlValue.lastIndexOf(DecPoint);
		if (pointIdx != -1)
		{
			var newvalue = ctrlValue.slice( 0, pointIdx + parseInt(Dec,10) + 1);
			if (DecPoint != '.' && Elem.tagName == 'SELECT')
			{
				newvalue = newvalue.replace( DecPoint, '.');
			}
			if (newvalue!=Elem.value)
			{
				Elem.value = newvalue;
				if (navigator.userAgent.indexOf("Firefox/2") != -1)
					//WA For FF 2.0 bug (https://bugzilla.mozilla.org/show_bug.cgi?id=357684)
					Elem.onchange();
			}
		}
	}
	else
	{
		GXAlert( Elem, GXBadNumMsg);
	}
}

function valid_integer( Elem, ThSep)
{
	var gx_IntRegExp = new RegExp("^[ ]*([+-]?[0-9]*(\\" + ThSep + "[0-9]{3})*)?[ ]*$");
	if (! gx_IntRegExp.test( Elem.value))
	{ 
		GXAlert( Elem, GXBadNumMsg);
	}
}

function GX_js_close()
{
	var callerUrl = (document.forms[0].sCallerURL != undefined)?document.forms[0].sCallerURL.value:"";
	//FF Sends referer header for open function
	var isPopup = (window.opener != undefined);
	var sameparentcaller = false;
	if (isPopup)
	{
		var pLoc = opener.location.href;
		if (pLoc == callerUrl)
			sameparentcaller = true;
	}
	var hasCaller = (callerUrl != "");
	
	if ((!hasCaller || sameparentcaller) && isPopup)
	{
		window.close();
	}
	else
	{
		if (hasCaller)
			window.location.assign(callerUrl);
		else if (navigator.userAgent.indexOf("Firefox") == -1)
			window.close();
		else
			window.location.assign("about:blank");
	}
}

function GXsetGridCheckBoxValue(ControlId, sRow, Value, Checked)
{
	GXsetCheckBoxValue( ControlId + "_" + sRow, Value, Checked)
}
function GXsetGridDecimalValue(ControlId, sRow, Value, Dec, DecPoint)
{
	Value = Value.toString().replace( DecPoint, '.');
	Value = Number( Value).toFixed( Dec);
	Value = Value.replace( '.', DecPoint);
	return GXsetGridControlValue( ControlId, sRow, Value);
}


function GXsetGridControlValue( ControlId, sRow, PValue, GXCtrlFormat)
{
	return GXsetControlValue( ControlId + "_" + sRow, PValue, GXCtrlFormat);
}

function GXsetControlsValues( ControlsId, ControlsValue)
{
	for (var i=0; i<ControlsId.length;i++)
		GXsetControlValue( ControlsId[i], ControlsValue[i]);
}

function GXsetVarValues( VarIds, VarValues)
{
	for (var i=0; i<VarIds.length;i++)
	{
		var validStruct = gxControlStructForVar(VarIds[i]);
		if(validStruct != null)
		{
			validStruct.v2v(gxEncodeValue( VarValues[i]));
		}
		else
		{
			eval( VarIds[i] + '="' + gxEncodeValue( VarValues[i]) + '"');
		}
	}
}

function gxEncodeValue( Value)
{
	return gxCharReplace( Value, ['"',"'",'\r','\n'], ['\\042','\\047','\\015','\\012']);
}

function gxDecodeValue( Value)
{
	Value = gxReplaceAll(Value, "\\042", "\"");
	return gxReplaceAll(Value, "\\015\\012", "\r\n");
}

function gxEncodeHtml( Value)
{
	Value = gxCharReplace( Value, [' '], ['&nbsp;']);
	return gxReplaceAll(Value, "\\015\\012", "<br/>");
}

function gxReplaceAll( Value, ToReplace, ReplaceWith)
{
	return String(Value).split(ToReplace).join(ReplaceWith);
}

function gxCharReplace( Value, Chars, Repls)
{
	var Ret = '';
	for (var i=0;i<Value.length;i++)
	{
		var bFixed = false;
		for (var c=0;c<Chars.length;c++)
		{
			if ( Value.charAt(i) == Chars[c])
			{
				if (c < Repls.length)
				{
					Ret += Repls[c];
					bFixed = true;
					break;
				}
			}
		}
		if (bFixed == false)
			Ret += Value.charAt(i);
	}
	return Ret;
}

function GXsetControlValue( ControlId, Value, GXCtrlFormat)
{
	ControlId = GXCmpControlId( ControlId);
	setControlValue( ControlId, Value, GXCtrlFormat);
}


function GXsetDecimalValue(ControlId, Value, Dec, DecPoint)
{
	Value = Value.toString().replace( DecPoint, '.');
	Value = Number( Value).toFixed( Dec);
	Value = Value.replace( '.', DecPoint);
	GXsetControlValue( ControlId, Value);
}
function GXtoDecimalValue( Value, Dec, DecPoint)
{
	return gxparseFloat(Value, Dec, DecPoint);
}

function GXCmpControlId( ControlId)
{	
	if (ControlId.indexOf(GXWCP) == 0)
		return ControlId;
	return GXWCP + ControlId;
}

function GXsetCheckBoxValue( ControlId, Value, Checked)
{
	try
	{
		var Control = document.forms[0][ControlId];
		if (Control == null)
			Control = document.getElementById(ControlId);
		Control.checked = (Value==Checked);
	}
	catch(e) {}
}

function setControlValue( ControlId, Value, GXCtrlFormat)
{
	if (Value instanceof gxdate)
	{
		var dateString = (Value.HasDatePart)?Value.getString():"";
		var timeString = (Value.HasTimePart)?" " + Value.getTimeString():"";
		Value = dateString + timeString;
	}
	var CtrlFormat = GXCtrlFormat || 0;
	var Control = GXgetControlRef_impl( ControlId);	
	setControlValue_impl( Control, Value, GXCtrlFormat);
}

function setControlValue_impl( Control, ctrlValue, GXCtrlFormat)
{
	if(typeof(Control) == 'string')
		Control = GXgetControlRef_impl( Control);
	if (ctrlValue instanceof gxdate)
	{
		ctrlValue = ctrlValue.getString();
	}
  if (Control != null)
  {
  	if ((Control != null) && (typeof(Control.length) != "undefined") && (Control[0].type == 'radio'))
  	{
	  	gxSetRadioValue( Control, ctrlValue);
	  	return;
	  }
  		if(Control.type == "text" || Control.type == "textarea")
			Control.value = gxDecodeValue( ctrlValue);
		else
		{
			Control.value = ctrlValue;
		}
		if (Control.type == "hidden" || Control.type == "text" || Control.type == "textarea")
		{
	    		setControlValue_span( Control, ctrlValue, GXCtrlFormat);
		}
	}
}

function setControlValue_span( Control, ctrlValue, GXCtrlFormat)
{
	Control = document.getElementById( "span_"+gxSafeId(Control));
  if (Control != null)
	{
		if( GXCtrlFormat == 1 )
			Control.innerHTML = gxEncodeHtml( ctrlValue);
		else
		{
			if( GXCtrlFormat == 0 && typeof(ctrlValue) == 'string')
				ctrlValue = ctrlValue.replace( / +/g, ' ');
			if(Control.childNodes.length == 0)
				Control.appendChild( document.createTextNode(""));
			Control = Control.childNodes[0];
			Control.nodeValue = ctrlValue;
		}
	}
}


function gxClearControlValue( Control)
{
	if (Control == null)
		return;
	if (Control.nodeName == "SPAN")
	{
		var Childs = Control.childNodes;
		for( var i=0;i<Childs.length;i++)
			Control.removeChild( Childs[i]);
		return;
	}
    if (Control != null)
		Control.value = '';
}

function change_control( newValue, checkCtrl)
{
	if (checkCtrl.value != newValue && checkCtrl.type == "checkbox" )
		checkCtrl.checked = !checkCtrl.checked;
}

function GXReturnAutosuggestValues( Var, adata)
{
	return adata;
}

function GXsetHideCode( ControlIds, adata)
{
	GXsetVarValues( ControlIds, adata);
}

function GXsetGridComboBoxValue(ControlId, sRow, Value)
{
	GXsetComboBoxValue(ControlId + "_" + sRow, Value);
}
 
function GXsetComboBoxValue(ControlId, Value)
{
	ControlId = GXCmpControlId( ControlId);
	var Ctrl = document.forms[0][ControlId];
	if (Ctrl == null)
		Ctrl = document.getElementById(ControlId);
	if (Ctrl == null)
		return;
	var descText = Value;
	try
	{
		if (Ctrl.tagName == 'SELECT')
		{
			for ( var i=0;i<Ctrl.options.length;i++)
			{
				if (Ctrl.options[i].value == Value)
				{
				    if (typeof(Ctrl.options[i].innerText) != 'undefined')
					    descText = Ctrl.options[i].innerText;
				    else
					    descText = Ctrl.options[i].text;
					Ctrl.selectedIndex=i;
    				selected = true;
    				break;
				}
			}
    		if (!selected)
	    		Ctrl.selectedIndex=0;
		}
		else if (Ctrl.type == 'hidden')
		{
			Ctrl.value = Value;
		}
		setControlValue_span( Ctrl, descText, 0);
	}catch(e){}
}

function GXsetGridComboValues( ControlId, adata)
{
	ControlId = GXCmpControlId( ControlId);
	var ctrlGrid = gxControlGrid( ControlId);
	if( ctrlGrid == 0)
		GXsetComboValues_impl( ControlId, adata);
	else
	{
		for (var i=1; i < 999; i++) 
		{	
			var currentRowStr = gxrpadwc( i.toString(), 4, '0');
			var Control = GXgetControlRef_impl( ControlId + "_" + currentRowStr);
			if( Control == null)
				break;
			GXsetComboValues_impl( Control.name, adata);
		}
	}
}
	

function GXsetComboValues( ControlId, adata)
{
  ControlId = GXCmpControlId( ControlId);
  GXsetComboValues_impl( ControlId, adata);
}

function GXsetComboValues_impl( ControlId, adata)
{
	var Ctrl = GXgetControlRef_impl( ControlId);
	if (Ctrl == null)
		return;
	var currValue = '';
	if (Ctrl.selectedIndex != -1)
		currValue = Ctrl.options[Ctrl.selectedIndex].value;
	while( Ctrl.options.length > adata.length)
		Ctrl.remove( Ctrl.options.length - 1);
	while( adata.length > Ctrl.options.length)
	{
		var E = document.createElement("OPTION");
		Ctrl.options.add( E);
	}
	for ( var i=0;i<adata.length;i++)
	{
		var E = Ctrl.options[i];
		E.value = adata[i].c;
		E.text = adata[i].d;
		if (E.value == currValue)
			Ctrl.selectedIndex=i;
	}
	if (Ctrl.options.length  == 0)
		Ctrl.selectedIndex = -1;
	else
	{
		if (Ctrl.selectedIndex == -1 || Ctrl.selectedIndex > Ctrl.options.length - 1)
		{
			Ctrl.options[0].selected = true;
		}
	}
}

function GXgetControlRef( ControlId)
{
	ControlId = GXCmpControlId( ControlId);
	var Control = GXgetControlRef_impl( "span_"+ControlId);
    if (Control != null)
    	return Control;
	Control = GXgetControlRef_impl( ControlId);
    if (Control != null)
    	return Control;
	Control = GXgetControlRef_impl( "_"+ControlId);
    if (Control != null)
    	return Control;
	return null;
}

function GXScreen_CtrlRef( ControlId)
{
	var Control = GXgetControlGridRef( ControlId, gxControlGrid( ControlId));
	if (Control.type == 'hidden')
		Control = GXgetControlRef_impl( "span_"+gxSafeId(Control));	
	return Control;
}

function GXgetControlRef_impl( ControlId)
{
	if ( ControlId == '')
		return null;
	var Control = gxGetCachedCtrl( ControlId);
	if (Control != null)
	{
		return Control;
	}
	else
	{
		Control = document.forms[0][ControlId];
		if (Control != null)
		{
			if (Control instanceof Array)
				Control = Control[0];
		}
		else
		{
			Control = document.getElementById(ControlId);
			if (gxIsEmptyObject(Control))
			{
				ControlList = document.getElementsByName( ControlId);
				if (ControlList != null)
					Control = ControlList[0];
			}
		}
	}
	if (!gxIsEmptyObject(Control))
	{
		gxAddCachedCtrl( ControlId, Control);
	}
	return Control;
}

function GXgetControlRef_list( ControlId)
{
	var ControlList = document.getElementsByName( ControlId);
	if (ControlList != null)
		return ControlList; 
	var Control = document.getElementById(ControlId);
	if (Control != null)
		return [Control];
	return null;
}


function gxCurrentGridRow( GridId)
{
	try
	{
		return GXCurrentRow[GridId];
	}
	catch(e){}
	return undefined;
}

function GXCurrentGridRow( GridId)
{
	var Ret = gxCurrentGridRow( GridId);
	return (typeof(Ret) == "undefined")?'0001':Ret;
}

function GXgetControlGridRef( ControlId, GridId, CurrentRow)
{
	ControlId = GXCmpControlId( ControlId);
	try
	{
		if (GridId == 0)
			return GXgetControlRef_impl( ControlId);
		if (typeof(CurrentRow) == "undefined")
			CurrentRow = GXCurrentGridRow( GridId);
		return GXgetControlRef_impl( ControlId + "_" + CurrentRow);
	}
	catch(e){}
}

function GXCheckRowChange( Ctrl)
{
	var GridId = 0;
	try
	{
		var GridId = GXValidStruct(Ctrl).grid;
		var GXValidRow = gxCurrentGridRow( GridId);
		if (GXValidRow != 0 && GXValidRow != GXLastValidRow && GXValidRow.length > 1 && GXLastValidRow.length > 1)
		{
			if (gxValidGridRowChange( GridId, GXValidRow) == true)
				eval( "GXCurrentRow[GridId]='" + GXValidRow + "'");
			return true;
		}
	}
	catch(e){}
	if (typeof(GXValidRow) != "undefined")
		eval( "GXCurrentRow[GridId]='" + GXValidRow + "'");
	return false;
}

function gxValidGridRow( GridId, GXValidRow)
{
	if (typeof(GXValidRow) != "undefined")
		eval( "GXCurrentRow[GridId]='" + GXValidRow + "'");
	var firstGridCtrl = gxFirstGridControl( GridId);
	var lastGridCtrl = gxLastGridControl( GridId);
	return GXValidControls( firstGridCtrl, lastGridCtrl + 1, true);
}

function gxValidGridRowChange( GridId, GXValidRow)
{
	if (typeof(GXLastValidRow) != "undefined")
		eval( "GXCurrentRow[GridId]='" + GXLastValidRow + "'");
	var firstGridCtrl = gxFirstGridControl( GridId);
	var lastGridCtrl = gxLastGridControl( GridId);
	var bRet = GXValidControls( firstGridCtrl, lastGridCtrl + 1, true);
	if (bRet)
		gxChangeGridRow( GridId, firstGridCtrl, GXValidRow);
	return bRet;
}

function gxChangeGridRow( GridId, firstGridCtrl, GXValidRow)
{
	var bRowisMod = GXGridRowIsMod( gxGridLvl( GridId), GXLastValidRow);
	if (bRowisMod)
		gxsetNewRow( GridId, GXLastValidRow, false);
	GXLastFocusCtrl = firstGridCtrl;
	if (GXFromValid > firstGridCtrl)
		GXFromValid = firstGridCtrl;
	GXLastValidRow = GXValidRow;
}

function gxFirstGridControl( GridId)
{
	for(i=0;i<=GXLastCtrlId();i++)
	{
		var _GXValidStruct = GXValidStruct(i);
		if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.grid == GridId)
			return i;
	}
	return -1;
}

function gxLastGridControl( GridId)
{
	for(i=GXLastCtrlId();i>=0;i--)
	{
		var _GXValidStruct = GXValidStruct(i);
		if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.grid == GridId)
			return i;
	}
	return -1;	
}

function GXgetGridDecimalValue(ControlId, sRow, ThSep, DecPoint)
{
	return GXgetDecimalValue( ControlId + "_" + sRow, ThSep, DecPoint);
}

function GXgetGridIntegerValue(ControlId, sRow)
{
	return GXgetIntegerValue( ControlId + "_" + sRow);
}

function GXgetGridControlValue( ControlId, sRow)
{
	return GXgetControlValue( ControlId + "_" + sRow);
}

function GXgetGridCheckBoxValue(ControlId,sRow,Checked,Unchecked)
{
	return GXgetCheckBoxValue( ControlId + "_" + sRow, Checked, Unchecked)
}

function GXgetCheckBoxValue( ControlId, Checked, Unchecked)
{
	ControlId = GXCmpControlId( ControlId);
	Control = document.forms[0][ControlId];
	if (Control == null)
	{
		ControlList = document.getElementsByName( ControlId);
		if (ControlList != null)
			Control = ControlList[0];
	}
	if (Control == null)
		return 0;
	if (Control.checked)
		return Checked;
	return Unchecked;
}

function GXgetControlValue( ControlId)
{
		return GXgetControlValue_impl( GXCmpControlId( ControlId));
}

function gxSetRadioValue( Control, Value)
{
	for (var i=0;i<Control.length;i++)
	{
		if (gxltrim(Control[i].value) == gxltrim(Value))
		{
			Control[i].checked = true;
			return;
		}
	}
}

function gxGetRadioValue( Control)
{
	for (var i=0;i<Control.length;i++)
	{
		if (Control[i].checked)
			return Control[i].value;
	}
}

function GXgetControlValue_impl( ControlId)
{
	try
	{
		var Control = GXgetControlRef_impl( ControlId);
		if (Control != null)
		{
			if ((Control.type == "hidden") || (Control.type == "text") || (Control.type == "textarea") || (Control.nodeName == "SELECT"))
						return Control.value;
		}
		Control = GXgetControlRef_impl( "span_"+ControlId);
        if (Control != null)
        	return Control.nodeValue;
        	Control = gxGetCachedCtrl( ControlId);
        	if (Control != null)
        	{
        		return gxGetControlValue( Control);
        	}
        	Control = gxGetCachedCtrl( "_"+ControlId);
        	if (Control != null)
        	{
        		return gxGetControlValue( Control);
        	}
		Control = document.forms[0][ControlId];
		if (Control != null)
		{
			gxAddCachedCtrl( ControlId, Control);
			return gxGetControlValue( Control);
		}
		Control = document.getElementById( "_"+ControlId);
		if (Control != null)
		{
			gxAddCachedCtrl( "_"+ControlId, Control);
       		return Control.value;
       	}
		ControlList = document.getElementsByName( ControlId);
		if (ControlList && ControlList.length == 0)
			ControlList = document.getElementsByName( "_"+ControlId);
		if (ControlList != null)
		{
			for (var i=0;i<ControlList.length;i++)
			{
				Control = ControlList[i];
				if (Control != null)
				{
					gxAddCachedCtrl( "_"+ControlId, Control);
					return gxGetControlValue( Control);
				}
		    	}
		    	Control = ControlList[0];
		    	if (Control)
		    	{
		    		gxAddCachedCtrl( "_"+ControlId, Control);
		    		return Control.value;
		    	}
	    }
	}
	catch(e){}
	return "";
}

function gxGetControlValue( Control)
{
	if ((typeof(Control.length) != "undefined") && (Control[0].type == 'radio'))
		return gxGetRadioValue( Control);
	if (Control.type == "checkbox")
		return Control.checked;
	return Control.value;
}

function GXgetDateValue( ControlId)
{
	try
	{
		var Control = GXgetControlRef_impl( GXCmpControlId( ControlId));
		if(Control != null)
		{
			if(Control.type == "hidden")
			{
				var SDate = Control.value;
				return new gxdate( SDate, "Y4MD");
			}
		}
		return new gxdate( GXgetControlValue(ControlId), gxdate.SFmt);
	}
	catch(e){}
	return "";
}

function GXgetIntegerValue( ControlId)
{
	var nIntVal = parseInt( GXgetControlValue( ControlId),10);
	return isNaN( nIntVal) ? 0:nIntVal;
}

function GXgetDecimalValue( ControlId, ThSep, DecPoint)
{
	var nDecVal = gxparseFloat( GXgetControlValue( ControlId), ThSep, DecPoint);
	return isNaN( nDecVal) ? 0:nDecVal;
}

function GXCtrlSum( ControlId, ThSep, DecPoint, ParentGridId)
{
	gxControlStruct( ControlId).v2c();
	var GridId = gxControlGrid( ControlId);
	var gridRow = GXCurrentRow[ParentGridId];
	var ParentGridRow = (typeof(gridRow) != "undefined")?gridRow:'';
	ControlId = GXCmpControlId( ControlId);
	var retVal = 0;
	for (var i=1; i < 999; i++) 
	{	
		var currentRowStr = gxrpadwc( i.toString(), 4, '0');
		var CellCtrl = GXgetControlRef_impl( ControlId + '_' + currentRowStr + ParentGridRow);
		if (CellCtrl == null)
		{
			if (i == 1)
				throw "GXGridCtrlNotFound"
			break;
		}
		var IsRemoved = gxIsRowRemoved( GridId, currentRowStr + ParentGridRow);
		if (IsRemoved != true)
			retVal += gxparseFloat( CellCtrl.value, ThSep, DecPoint);
	}
	return retVal;
}

function GXCtrlCount( ControlId, ParentGridId)
{
	var GridId = gxControlGrid( ControlId);
	var gridRow = GXCurrentRow[ParentGridId];
	var ParentGridRow = (typeof(gridRow) != "undefined")?gridRow:'';
	var Lvl = gxControlLvl( ControlId);
	ControlId = GXCmpControlId( ControlId);
	var retVal = 0;
	for (var i=1; i < 999; i++) 
	{	
		var currentRowStr = gxrpadwc( i.toString(), 4, '0');
		var CellCtrl = GXgetControlRef_impl( ControlId + '_' + currentRowStr + ParentGridRow);
		if (CellCtrl == null)
		{
			if (i == 1)
				throw "GXGridCtrlNotFound"
			break;
		}
		var IsRemoved = gxIsRowRemoved( GridId, currentRowStr + ParentGridRow);
		var RecordExists = GXgetControlValue( "nRcdExists_" + Lvl + '_' + currentRowStr + ParentGridRow);
		var RecordIsMod = GXgetControlValue( "nIsMod_" + Lvl + '_' + currentRowStr + ParentGridRow);
		if (IsRemoved != true && ( RecordExists == "1" || RecordIsMod == "1"))
			retVal += 1;
	}
	return retVal;
}

function gxCheckControlConds( Control, Prefix, GridId, DepIds, IsMod)
{
	var gridRow = null;
	if (GridId > 0 && IsMod)
	{
		var isModExp = /^nIsMod_([0-9]{1,4})_((?:[0-9]{4})*)/i;
		gridRow = isModExp.exec(gxSafeId(IsMod));
		if (gridRow != null)
		{
			gridRow = gridRow[2];
		}
	}
	if (gridRow != null)
	{
		for (var i=0; i<DepIds.length; i++)
		{
			var validStruct = GXValidStruct_Prefix(Prefix, DepIds[i]);
			if (validStruct)
			{
				var ctrlId = GXWCP + validStruct.fld + ((gridRow != null)?('_'+gridRow):'');
				if (!GXgetCtrlProperty( ctrlId, 'Enabled'))
				{
					return false;
				}
			}
		}
	}
	return true;
}

function GXsetCtrlProperty( ControlId, Property, PValue)
{
	Control = GXScreen_CtrlRef( ControlId);
	if (Control == null)
		return;
	Control.gxid = ControlId;
	gxsetCtrlProperty( Control, Property, PValue);
}

function GXsetGridCtrlProperty( ControlId, Property, PValue)
{
	Control = GXScreen_CtrlRef( ControlId);
	if (Control == null)
		return;
	Control.gxid = ControlId;
	gxsetCtrlProperty( Control, Property, PValue);
	var Cell = Control.parentNode;
	if (Cell.tagName != 'TD')
		return;
	gxsetCtrlProperty( Cell, Property, PValue);	
}

function gxDisplaybyType( NodeName)
{
	if (NodeName == 'TABLE' || NodeName == 'P'|| NodeName == 'DIV')
		return "block";
	return "inline";	
}

function gxsetCtrlProperty( Control, Property, PValue)
{
	if (Control == null)
		return;
	var ControlId = (Control.gxid != undefined)?Control.gxid:Control.id;
	switch( Property)
	{	
		case "Tooltiptext":	Control.title = PValue;
			break;
		case "Visible":	Control.style.display = (PValue == 0)?"none":gxDisplaybyType( Control.nodeName);
		      gxCheckAttachedProperty( WCSV_ctx, ControlId, Property, PValue);
			break;
		case "Enabled":	
			{
			  try
			  {
			    if (Control.tagName == "A")
			    {
			      if (PValue)
			      {
			      	if (Control.gxhref != undefined)
			      	{
		  			      Control.href = Control.gxhref;
		  			      Control.gxhref = "";
		  			 }
  			    }
  			    else
  			    {
  			      Control.gxhref = Control.href;
	  		      Control.href= "#";
	  		    }
			      return;
			    }
			    if (Control.tagName == "IMG" && Control.parentNode.tagName == "A")
			      return gxsetCtrlProperty( Control.parentNode, Property, PValue);
			  }
			  catch(e){}
				if (Control.type == "hidden")
					return;
				gxpushElement( gxDisabledControls, Control, gxSafeId(Control));
				Control.gxusrdisabled = (PValue == 0);
				if (Control.gxdisabled)
				{
					if (Control.gxdisabled == true)
						Control.disabled = true;
					else
						Control.disabled = Control.gxusrdisabled;
				}
				else
					Control.disabled = Control.gxusrdisabled;
				if (Control.type == "text" || Control.type == "textarea" || Control.tagName=="SELECT")
				{
					if (PValue == 1)
					{
						var spanVal = GXgetControlRef_impl( 'span_' + Control.id);
						if (spanVal)
						{
							spanVal.style.display = (PValue == 1)?"none":"inline";
							Control.style.display = (PValue == 0)?"none":"inline";
						}
					}
					gxCheckAttachedProperty( WCSV_ctx, ControlId, Property, PValue);
				}
				break;
			}
		case "Link":	
				GXsetCtrlLink( Control, PValue);
				break;
		case "Backcolor":
				Control.style.backgroundColor = '#' + gxrpadwc( PValue.toString(16), 6, '0');
				break;
		case "Forecolor":
				Control.style.color = '#' + gxrpadwc( PValue.toString(16), 6, '0');
				break;
	}
	var propHidden = GXgetControlRef_impl(Control.id + Property);
	if(propHidden != null)
		propHidden.value = PValue;
}

function GXgetCtrlProperty( ControlId, Property)
{
	Control = GXScreen_CtrlRef( ControlId);
	if (Control == null)
		return;
  return GXgetCtrlProperty_impl( Control, Property, true);
}


function GXgetCtrlProperty_impl( Control, Property, Recursive)
{
	if (Control == null)
		return "";
	switch( Property)
	{	
		case "Tooltiptext":	return Control.title;
		case "Visible": if (Recursive) return gxVisible( Control); else return gxControlIsVisible( Control);
		case "Enabled": return gxControlIsAccepted( Control, Recursive) ? !Control.disabled:false;
		case "Backcolor": return css_color( Control.style.backgroundColor);
		case "Forecolor": return css_color( Control.style.color);
	}
}

function css_color( Color)
{
	if (Color.substring(0,3) == 'rgb')
		return eval(Color);
	return (Color.charAt(0) == '#') ? parseInt( Color.substring(1), 16) : 0;
}

function GXsetCtrlLink( Control, Link)
{
	if (Control == null)
		return;
	if (Link == "")
	{
		GXunsetCtrlLink( Control);
		return;
	}
	var ParentTag = Control.parentNode;
	if (ParentTag.tagName == "A")
		ParentTag.href = Link;
	else
	{
		var newA = document.createElement("A");
		newA.href = Link;
		ParentTag.replaceChild( newA, Control);
		newA.appendChild( Control);
	}	
}

function GXunsetCtrlLink( Control)
{
	if (Control == null)
		return;
	var ParentTag = Control.parentNode;
	if (ParentTag.tagName == "A")
	{
		var ChildNode = ParentTag.firstChild;
		ParentTag2 = ParentTag.parentNode;
		if (ParentTag2 != null)
		{
			while( ChildNode != null)
			{
				ParentTag2.insertBefore( ChildNode,ParentTag);
				ChildNode = ParentTag.firstChild;					
			}
			ParentTag2.removeChild( ParentTag);
		}
	}
}

function GXAssignPromptField( PNum, PValue)
{
	changed = true;
	change_control( PValue, opener.GXPARAMETERS[PNum].Ctrl)
	if (opener.GXPARAMETERS[PNum].Ctrl.value != PValue && opener.GXPARAMETERS[PNum].isKey)
		opener.GXPkIsDirty = true;
	setControlValue_impl( opener.GXPARAMETERS[PNum].Ctrl, PValue, 0);
	var spanObj; 
	var spanChild; 
	spanObj = opener.document.getElementById( 'span_' + opener.GXPARAMETERS[PNum].Ctrl.name); 
	if(spanObj != null) 
	{	
		if(spanObj.childNodes.length == 0) 
			spanObj.appendChild( opener.document.createTextNode(""));
		spanChild = spanObj.childNodes[0]; 
		spanChild.nodeValue = PValue;
	}
}

function GXLastValidationControl()
{
	var LastCtrl = -1;
	for (i=0;i<=GXLastCtrlId();i++)
	{
		var _GXValidStruct = GXValidStruct(i);
		if (typeof(_GXValidStruct) != "undefined")
		{
			try
			{
				Control = GXgetControlGridRef( _GXValidStruct.fld, _GXValidStruct.grid);
				if (gxControlIsAccepted( Control))
					LastCtrl = i;
			}
			catch(e){}
		}			
	}
	return LastCtrl;
}

function gxControlIsVisible( Control)
{
	if ((Control.tagName == "INPUT") || (Control.tagName == "SELECT")|| (Control.tagName == "TEXTAREA"))
	{
		if( GXgetControlRef_impl( "span_"+gxSafeId(Control)))
			return true;
	}
	if ( Control.style && (Control.style.visibility == 'hidden' || Control.style.display == 'none'))
		return false;
	if ( Control.type == 'hidden')
		return false;
	return true;
}

function gxVisible( Control)
{
	try
	{
		while (Control)
		{
			if ( gxControlIsVisible( Control) == false)
				return false;
			Control = Control.parentNode;
		}
	}
	catch( e) {}
	return true;
}

function gxRefreshVars( validStruct)
{
	for( var i=0;i<validStruct.ip.length;i++)
	{
		try	
		{
			GXValidStruct(validStruct.ip[i]).c2v();
		}
		catch(e){}
	}
}

function gxRefreshControls( validStruct)
{
	for( var i=0;i<validStruct.op.length;i++)
	{
		try
		{
			GXValidStruct(validStruct.op[i]).v2c();
		}catch(e){}
	}
}

function gxcheckNacConditions( validStruct)
{
	if(typeof(validStruct.nacdep) != "undefined")
	{
		for (var i=0; i<validStruct.nacdep.length;i++)
		{
			var depValidStruct = GXValidStruct( validStruct.nacdep[i]);
			if ((typeof(depValidStruct) != "undefined") && (typeof(depValidStruct.nac) != "undefined"))
			{
				var Disabled = depValidStruct.nac();
				if (Disabled != null)
				{
					var ControlId = GXCmpControlId( depValidStruct.fld);
					if (depValidStruct.grid == 0)
					{
						var Control = GXgetControlRef_impl( ControlId);
						gxsetCtrlProperty( Control, "Enabled", Disabled?0:1);
					}
					else
					{
						var currentRowStr = gxCurrentGridRow(depValidStruct.grid);
						if (currentRowStr != undefined)
						{
							var Control = GXgetControlRef_impl( ControlId + "_" + currentRowStr);
							if( Control != null)
							{
								Control.gxid = ControlId;
								gxsetCtrlProperty( Control, "Enabled", Disabled?0:1);
							}
						}
					}
				}
			}
		}
	}
}

function GXVControl( Ctrl, i, bForceCheck)
{
	if (i != -1)
	{
		var validStruct = GXValidStruct(i);
		if ((typeof(validStruct) != "undefined") && (validStruct.fnc != null))
		{
			return GXVC( Ctrl, validStruct, bForceCheck);
		}
	}
	return true;
}

function GXVC( Ctrl, validStruct, bForceCheck)
{
	if (typeof(validStruct) == "undefined" || validStruct.fnc == null)
		return true;
	try
	{
		var jsCode = '';
		if (bForceCheck || (Ctrl.gxvalid != 1))
		{
			gxRefreshVars( validStruct);
			var validRet = validStruct.fnc();
			gxRefreshControls( validStruct);
			gxcheckNacConditions( validStruct);
			if (validRet == true)
			{
				if (gxControlIsAccepted( Ctrl))
					Ctrl.gxvalid = 1;
				else
					Ctrl.gxvalid =0;
			}
			return validRet;
		}
	}
	catch(e){}
	return true;
}

function GXValidControls( FromControl, TargetControl, bForceCheck)
{
	var bRet = true;
	var bFailedCtrl = -1;
	try
	{
		GXInvalidCtrlNum = 0;
		var RowMode = "";
		var GXValidRow = null;
		var rowModified = false;
		var rowIsRemoved = false;
		var lstValidGrid = 0;
		for (var i=FromControl;i<TargetControl;i++)
		{
			var validStruct = GXValidStruct(i);
			if (typeof(validStruct) != "undefined")
			{
				if ((validStruct.grid != 0) && (validStruct.grid != lstValidGrid))
				{
						lstValidGrid = validStruct.grid;
						GXValidRow = GXCurrentGridRow( validStruct.grid);
						if (typeof(GXValidRow) != "undefined")
							GXCurrentRow[validStruct.grid] = GXValidRow;
						RowMode = gxGetGridRowMode( validStruct.lvl, validStruct.grid);
						rowIsRemoved = gxIsRowRemoved( validStruct.grid);
						rowModified = gxRowIsModified( validStruct.grid) && gxRowIsModifiedNow( validStruct.grid);
				}
				validStruct.c2v();
				if (validStruct.fnc != null)
				{
					try
					{
						if (validStruct.lvl == 0 || validStruct.force || rowModified ||  ((validStruct.grid != 0) && (RowMode=='UPD') && gxControlHasHidecode(validStruct.fld, validStruct.grid)))
						{
							var Control = GXgetControlGridRef( validStruct.fld, validStruct.grid, GXValidRow);
							var bValid = GXVC( Control, validStruct, bForceCheck);
							if (!bValid && rowIsRemoved)
								continue;
							if (bValid)
							{
				        				if (GXInvalidCtrl == Control)
					        				GXInvalidCtrl = null;
					        			if (validStruct.force)
					        				GXsetRowModValue( validStruct.lvl, GXValidRow);
							}
						  else
						  {
  							if (bRet)
  							{	
  								GXInvalidCtrl = Control;
  								GXInvalidCtrlNum = i;
  								bFailedCtrl = i;
  								bRet = false;
  							}
  						}
							if (gxControlIsAccepted( Control) == false)
							{
								gxExecuteOnBlur(i);

								if (Control.gxhiddenonchange != Control.value)
								{
									Control.gxhiddenonchange = Control.value;
									gxExecuteOnChange( Control);
								}
							}
						}
					}
					catch(e){}
				}
			  else
				  gxcheckNacConditions( validStruct);
			}
		}
		if ( bFailedCtrl != -1)
		{
			Control = GXgetControlGridRef( GXValidStruct(bFailedCtrl).fld, GXValidStruct(bFailedCtrl).grid);
			GXDisableFocus = true;
			if (gxControlIsAccepted(Control))
				gxSetControlFocus( Control);
			else
				gxSetControlFocus( GXLastEvtControl);
		}
	}
	catch (e){}
	return bRet;
}

function gxControlHasHidecode( ctrlId, gridId)
{
	var controlId = "GXHC" + ctrlId;
	if( gridId != 0)
		controlId += "_" + GXCurrentGridRow( gridId);
	var hidecodeCtrl = GXgetControlRef_impl( controlId);
	if (hidecodeCtrl != null)
		return true;
	return false;
}

function GXsetRowModValue( Lvl, Row)
{
	GXsetControlValue( GXWCP + "nIsMod_" + Lvl + "_" + Row, 1);
}

function GXGridRowIsMod( Lvl, Row)
{
	var bRet;
	try
	{
		bRet = eval( "document.forms[0]." + GXWCP + "nIsMod_" + Lvl + "_" + Row + ".value == 1");
	}
	catch(e)
	{
		bRet = false;
	}
	return bRet;
}

function gxExecuteOnBlur(gxCurrentFocusControl)
{
	var gxLastFocusCtrl = GXLastFocusCtrl;
	var gxFocusCtrl = GXFocusCtrl;
	
	GXFocusCtrl = gxCurrentFocusControl;
	GXOnBlur(GXFocusCtrl);
	
	GXFocusCtrl = gxFocusCtrl;
	GXLastFocusCtrl = gxLastFocusCtrl;
}

function GXOnBlur(gxLastFocusCtrl)
{
	var validStruct = GXValidStruct(GXFocusCtrl);
	var CurrentRow = "";
	try
	{
		var GridId = validStruct.grid;
		if (GridId != 0)
		{
			CurrentRow = "_" + GXCurrentGridRow( GridId);
			eval( WCSV_ctx + 'SubfileToVariables'+GridId+'()');
		}
		eval( WCSV_ctx + 'ControlsToVariables()');
	}catch(e){}
	if ((validStruct != null) && (navigator.userAgent.indexOf("Firefox") != -1))
	{
	 	var Ctrl = GXgetControlRef_impl( validStruct.fld + CurrentRow);
	 	gxAutocompleteOnchange(Ctrl);
	}
	GXLastFocusCtrl = gxLastFocusCtrl;
	try
	{
		var Elem = GXLastFocusCtrlRef;
		var MaxLength = Elem.getAttribute("maxlength");
		if ( MaxLength > 0 && Elem.value.length >= MaxLength)
			Elem.value = Elem.value.substring( 0, MaxLength)
	}
	catch(e){};
}

function gxAutocompleteOnchange(Ctrl)
{
	if ((Ctrl != null) && (Ctrl.type == "text") && (Ctrl.getAttribute( "autocomplete") != "off"))
	{
		if (Ctrl.defaultValue != Ctrl.value)
		{
			gxonchange( Ctrl);
			var ctrlId = gxSafeId(Ctrl);
			GXOnchageTriggered[ GXWCP+ctrlId] = true;
		}
	}
}

function GXValidLast()
{
	try
	{
		if (GXValidStruct(GXFocusCtrl).grid != 0)
			return;
	}
	catch(e){}	
	try
	{
		var LastValidationCtrl = GXLastValidationControl();
		if (LastValidationCtrl == GXFocusCtrl)
		{
			GXValidControls( LastValidationCtrl, LastValidationCtrl + 1, true)
		}
	}
	catch(e){}
}

function GXVF( evt)
{	
	try
	{
		GXValidControls( GXFromValid, GXToValid, true);
		if (GXInvalidCtrl == null)
			GXFromValid = GXToValid;			
	}
	catch(e){}
}

function GXVFTail( evt)
{	
	try
	{
		GXValidControls( GXFocusCtrl, GXLastCtrlId() + 1, true);
	}
	catch(e){}
}

function GXValidForm()
{
	gxdisableformnvis();
	var bRet = true;
	try
	{
		if (GXgetControlValue( "IsConfirmed") != "1" && document.forms[0]._EventName.value == "EENTER.")
			bRet = GXValidControls( GXLastFocusCtrl, GXLastCtrlId() + 1, false);
	}
	catch(e){}
	if (bRet)
	{
		gxSetModalNodeOpacity(50);
		ForceEnableControls();
	}
	else
	{
		gxenableform();
		gxSetModalNodeOpacity(50);
	}
	return bRet;
}

function ForceEnableControls()
{
	for( var Ctrl in gxDisabledControls)
	{
		Ctrl = GXgetControlRef_list( Ctrl);
		for( var i=0;i<Ctrl.length;i++)
		{
			try{
				if (Ctrl[i].type != 'button' && Ctrl[i].type != 'submit')
					Ctrl[i].disabled=false;
			}catch(e){}
		}
	}
}

var dbgwindow = null;
function writedbg( texto)
{
	try
	{
	if (dbgwindow == null)
		dbgwindow = window.open( "", "debug","scrollbars=1,height=900,width=900");
	dbgwindow.document.write( texto + '<BR>');
	}
	catch (e){}
	
}

function GXAlert( Ctrl, Message)
{
	try
	{
		gxballoon = getGXBallon(Ctrl.id);
		gxballoon.setError( Message);
		gxballoon.show();
		GXInvalidFrmtCtrl = Ctrl;
	}
	catch (e)
	{
		alert( Message);
	}
}

function GXAddGridRow( GridId, sRowCount)
{
	var Ctrl = GXgetControlRef( GridId);
	if (Ctrl == null)
		return;
	var Node = Ctrl.firstChild;
	var nRowCount = parseInt( GXgetControlValue( sRowCount),10) + 1;
	GXsetControlValue( sRowCount, nRowCount);
	var sNewRowId = gxrpadwc( nRowCount.toString(), 4, '0');
	while( Node != null)
	{
		if (Node.nodeName == "TBODY")
		{
			var firstRow = Node.firstChild;
			while( firstRow != null)
			{
				if ((firstRow.nodeName == "TR") && gxHasChild( firstRow, "TD"))
				{
					var newRow = firstRow.cloneNode( true);
					gxResetRowValues( newRow);
					Node.appendChild( newRow);
					//newRow.innerHTML = 	newRow.innerHTML.replace( /0001/g, sNewRowId);
					return;
				}
				firstRow = firstRow.nextSibling;
			}
		}
		Node = Node.nextSibling;
	}
}

function gxResetRowValues( Row)
{
	var TD= Row.firstChild;
	while( TD != null)
	{
		var Childs = TD.childNodes;
		for( var i=0;i<Childs.length;i++)
			gxClearControlValue( Childs[i]);
		TD = TD.nextSibling;	
	}
}

function gxHasChild( Control, nodeName)
{
	var child = Control.firstChild;
	while( child != null)
	{
		if (child.nodeName == nodeName)
			return true;
		child = child.nextSibling;
	}
	return false;
}

function gxGetGridRowMode( GXLvl, GridId)
{
	var CurrentRow = GXCurrentGridRow( GridId);
	var IsRemoved = gxIsRowRemoved( GridId, CurrentRow);
	var RecordExists = GXgetControlValue( "nRcdExists_" + GXLvl + '_' + CurrentRow);
	if (RecordExists == "0")
		return "INS";
	if (IsRemoved == "1")
		return "DLT";
	return "UPD";
}

function gxonload()
{
	if (!document.all)
		for(var i=0;i<document.forms[0].elements.length;i++)
			document.forms[0].elements[i].gxIndex = i;
	var LastActiveControl = window.document.activeElement;
	window.document.forms[0].reset();
	gxgetModalDOMNode();
	gxdelayedsuggest();
	if (GXUserFocus)
	{
  	if (GXUserFocus != "notset")
	  	gxSetControlFocusOnload(GXUserFocus);
	}
	else
	{
		if (LastActiveControl && gxControlIsAccepted(LastActiveControl))
			gxSetControlFocusOnload(LastActiveControl);
		else
			gxSetControlFocusOnload(gxGetFirstAcceptedFormElement());
	}
	setTimeout("gxDoAttachs()", 1);
	try{GXOnloadUsr()}catch(e){}
}

function gxdelayedsuggest()
{
	for ( var C=0;C<gxSuggestControls.length;C++)
		gxinstallsuggest(gxSuggestControls[C]);
}

function gxinstallsuggest(Ctrl)
{	
	var jsCode;
	if (typeof(document.readyState) != "undefined" && document.readyState != "complete")
	{
		gxSuggestControls.push(Ctrl);
		return;
	}
	try
	{
		jsCode = Ctrl.attributes["gxsgprm"].value;
		if (jsCode != '')
		{
			var gxsgprm = eval( jsCode);
			gxajaxSuggest( gxsgprm[1], Ctrl.id, gxsgprm[0], gxsgprm[2], gxsgprm[3]);
			Ctrl.removeAttribute("gxsgprm");
		}
	}catch(e){}
}

function updateSuggestParms( suggestParms) {
	if( typeof(suggestParms) != "undefined")
	{
		for( var i=0; i<suggestParms.length; i++)
		{
			var validStruct = GXValidStruct(suggestParms[i]);
			if( typeof(validStruct) != "undefined" && validStruct != null)
				validStruct.c2v();
		}
	}
}

function gxChangeComponentContext()
{
	try{
		eval('this.'+ WCSV_ctx + 'SetStandaloneVars()')
	}catch(e){}
}

function gxDisableFocusCondition()
{
  if (typeof(GXValidStruct(GXFocusCtrl)) == "undefined")
    return false;
  try
  {
    if (GXLastCurrentGrid > 0)
      Gx_mode = gxGetGridRowMode( gxGridLvl( GXLastCurrentGrid), GXLastCurrentGrid);
    if (GXValidStruct(GXFocusCtrl).nac() == true)
    {
		  cn = gxSearchControlOnForm(GXLastFocusCtrlRef) + 1;
  	  NextFocus = gxSearchNextFocus(cn);
	    if(NextFocus != null)
			  gxSetControlFocus( NextFocus);
			 return true;
		}
  }
  catch(e){}
  return false;
}

var GXLastCurrentRow = new Array();

function gxUpdateCurrentRowsControl( Control)
{
	gxUpdateComponentContext( Control);
	var fldName = Control.name;
	var gxCurrentRow = gxGetControlRow( Control);
	if( gxCurrentRow == '')
		return;
	var rowIdx = fldName.length - gxCurrentRow.length;
	fldName = fldName.substring(0, rowIdx-1);
	var validStruct = gxControlStructForField(fldName);
	if ((validStruct != null) && (validStruct.grid != 0))
		gxUpdateCurrentRows( fldName, gxCurrentRow, validStruct.grid, validStruct);
}

function gxUpdateCurrentRows( Ctrl, gxCurrentRow, gxCurrentGrid, auxValidStruct)
{
	if( gxCurrentRow == '')
		return;
	GXCurrentRow[gxCurrentGrid] = gxCurrentRow;
	if ( GXLastCurrentRow[gxCurrentGrid] != gxCurrentRow)
	{
		GXLastCurrentRow[gxCurrentGrid] = gxCurrentRow;
		var rows = getCurrentRowsSplited( gxCurrentRow);
		var validStruct = (typeof(auxValidStruct)=="undefined")?GXValidStruct(Ctrl):auxValidStruct;
		var i = 1;
		while ((validStruct != null) && ( typeof(validStruct.pgrid) != "undefined") && ( validStruct.pgrid != 0) && (i < rows.length))
		{
			GXCurrentRow[validStruct.pgrid] = rows[i];
			validStruct = gxControlStructForGrid(validStruct.pgrid);
			gxsetNewRow( validStruct.grid, rows[i], false);
			i++;
		}
	}
}

function getCurrentRowsSplited( gxCurrentRow)
{
	var rows = new Array();
	var currIdx = 0;
	var strLen = gxCurrentRow.length;
	if ( strLen <= 4)
	{
		rows[0] = gxCurrentRow;
		return rows;
	}
	var rowsQty = strLen / 4;
	for( var i=0; i< rowsQty; i++)
	{
		rows[rows.length] = gxCurrentRow;
		gxCurrentRow = gxCurrentRow.substring(4);
	}
	return rows;
}

function gxUpdateComponentContext( Control)
{
	try
	{
		WCSV_ctx = Control.attributes["gxctx"].value;
	}
	catch(e){WCSV_ctx = '_';}
}

function gxGetControlRow( Control)
{
	var gxCurrentRow = '';
	try
	{
		gxCurrentRow = Control.attributes["gxrow"].value;
	}
	catch(e) { gxCurrentRow = ''; }
	return gxCurrentRow;
}

function gxonfocus2(Ctrl, gxFocusCtrl, gxWCP, gxCurrentGrid, gxAddLines)
{
	var gxCurrentRow = gxGetControlRow( Ctrl);
	gxonfocus(Ctrl, gxFocusCtrl, gxWCP, gxCurrentRow, gxCurrentGrid, gxAddLines);
}

function gxResetOnchange( gxWCP, Ctrl)
{
	var ctrId = gxSafeId(Ctrl);
	Ctrl.setAttribute( "gxoldvalue", GXgetControlValue( ctrId));
	GXOnchageTriggered[ gxWCP+ctrId] = false;
}

function gxonfocus(Ctrl, gxFocusCtrl, gxWCP, gxCurrentRow, gxCurrentGrid, gxAddLines)
{
	gxResetOnchange( gxWCP, Ctrl);
	gxUpdateComponentContext( Ctrl);
	GXLastFocusCtrlRef = Ctrl;
	gxinstallsuggest(Ctrl);
	gxUpdateCurrentRows( gxFocusCtrl, gxCurrentRow, gxCurrentGrid);
	var NewComponentContext = false;
	if (GXLastCurrentGrid != gxCurrentGrid)
	{
		if(!gxAddLines)
		{
			GXLastCurrentGrid = gxCurrentGrid;
			var firstGridCtrl = gxFirstGridControl( GXLastCurrentGrid);
			if(GXFromValid > firstGridCtrl)
				GXFromValid = firstGridCtrl;
		}
	}
	if (GXWCP != gxWCP)
	{
		NewComponentContext = true;
		GXFromValid = 0;
	}
	GXWCP = gxWCP;
	if (NewComponentContext)
		gxChangeComponentContext();
	GXFocusCtrl = gxFocusCtrl;
	
	if (GXDisableFocus)
	{
		GXDisableFocus = false;
		return true;
	}
	try
	{
		if (document.forms[0].Mode.value == 'DLT' || document.forms[0].Mode.value == 'DSP')
			return true;
		if (Ctrl.type == 'submit' && !gxIsEventEnterControl(Ctrl, gxWCP) && !gxIsEventCheckControl(Ctrl, gxWCP) && !gxAddLines)
			return true;	
	}
	catch(e){}
	if ( isGXTrn())
	{
		if(Ctrl.gxdisabled && GXLastFocusCtrlRef != null)
		{
			cn = gxSearchControlOnForm(Ctrl) + 1;
			if(cn != -1)
			{
				NextFocus = gxSearchNextFocus(cn);
				if(NextFocus != null)
				{
					gxSetControlFocus( NextFocus);
					return true;	
				}
			}
			gxSetControlFocus( GXLastFocusCtrlRef);
			return true;	
		}
	}
	if ( isGXTrn())
	{
		if (GXInvalidFrmtCtrl)
		{
			gxSetControlFocus( GXInvalidFrmtCtrl);
			GXInvalidFrmtCtrl = null;
			return true;	
		}
	}
	if (GXInvalidCtrl != null && GXInvalidCtrl != Ctrl && GXFocusCtrl >= GXInvalidCtrlNum)
	{
		if (GXInvalidCtrl == Ctrl && GXVControl( GXInvalidCtrl, GXInvalidCtrlNum, false))
		{
			GXInvalidCtrl = null;
			return true;
		}
	}
	Ctrl.gxvalid = 0;
	if(gxAddLines)
	{
		GXFromValid = gxFirstGridControl( GXLastCurrentGrid);
		GXToValid = gxFirstCtrlAfterGrid( GXFromValid, GXLastCurrentGrid);
		GXFocusCtrl = GXToValid;
	}
	else
	{
		GXToValid = GXFocusCtrl;
		if (GXFocusCtrl < GXFromValid)
		{
			GXFromValid = GXFocusCtrl;
		}
	}
	if(typeof(GXLastValidRow)=="undefined" && gxCurrentGrid != 0)
		GXLastValidRow = gxCurrentRow;
	GXCheckRowChange( GXLastFocusCtrl);
	if ( GXFocusCtrl >= GXLastFocusCtrl)
		GXVF();
	else
		GXToValid = GXFocusCtrl;
	if (GXInvalidCtrl == null)
		gxSetControlSelection( Ctrl);
	gxDisableFocusCondition();
	return false;
}

function gxonchange(Ctrl) 
{ 	
	GXLastEvtControl = Ctrl;
	var ctrlId = gxSafeId(Ctrl);
	if (GXOnchageTriggered[ GXWCP+ctrlId] == true)
		return;
	var CtrlValue = GXgetControlValue( ctrlId);
	if (Ctrl.getAttribute( "gxoldvalue") != CtrlValue);
	{
	    GXsetControlValue( "IsModified", "1")
		var jsCode = ''; 
		var bRet = true;
		if (Ctrl.type == "select-one" || Ctrl.type == "checkbox" || Ctrl.type == "radio")
		{
			if (GXVControl( Ctrl, GXFocusCtrl, false))
			{
				if (GXInvalidCtrl == Ctrl)
					GXInvalidCtrl = null;
			}
			else
				bRet = false;
		}
		Ctrl.setAttribute( "gxoldvalue", CtrlValue);
		if (bRet)
			gxExecuteOnChange( Ctrl);
		return gxExecuteUsrOnChange( Ctrl);
	}
	return true;
}

function gxExecuteUsrOnChange( Ctrl)
{	var jsCode = '';
	try{jsCode = Ctrl.attributes["gxoch0"].value;} 
	catch(e)
	{
		return true;
	}
	var fnc = new Function(jsCode);
	var ret = fnc.call();
	return ret;
}


function gxExecuteOnChange( Ctrl)
{
	var jsCode = ''; 
	try{jsCode += Ctrl.attributes["gxoch1"].value + ';';} catch(e){}
	if (gxControlIsAccepted( Ctrl))
		try{jsCode += Ctrl.attributes["gxoch2"].value + ';';} catch(e){}
	if (jsCode != '')
	{
		var changeFunc = new Function( jsCode);
		changeFunc();
	}
	Ctrl.gxvalid = 0;
	Ctrl.gxctrlchanged = 1;
}

function gxSetControlFocus( Control)
{
	if (Control)
	{
		  if (Control instanceof Array)
		    Control = Control[0];
		  else if (typeof(Control.Ctrl) != "undefined")
		  		Control = Control.Ctrl;
		try
		{
			try{document.getElementById(Control.id).focus();}
			catch(e){Control.focus()}
			gxSetControlSelection( Control);
		}
		catch(e){}
	}
}


function GXSetUserFocus( Control)
{
	GXUserFocus = Control;
}

function gxSetControlFocusOnload( Control)
{
	if (Control)
	{
		try
		{
			if (gxControlIsAccepted( Control))
			{
				gxUpdateCurrentRowsControl( Control);
				gxSetControlFocus( Control);
			}
		}
		catch(e){}
	}
}

function gxSetControlSelection( Control)
{
	if (Control)
	{
		try
		{
			if (Control.type == "text" || Control.type == "password" || Control.type == "file")
				Control.select();
			else if (Control.type == "textarea")
				Control.focus();
			else
				if( typeof(document.selection) != "undefined")
					document.selection.empty();
		}
		catch(e){}
	}
}

function gxControlIsAccepted( Control, Recursive)
{ 
	if (typeof(Recursive)== "undefined")
		Recursive = true;
	if ((Control == null) || (Control.type == "hidden") || (Control.tagName == "A"))
		return false;
	if ((Recursive && gxVisible(Control) == false)  || (!Recursive && gxControlIsVisible(Control)== false))
		return false;
	if ((Control.tagName == "INPUT") && (Control.type == "text") && gxControlIsVisible( Control))
	{
		if ( Control.style && (Control.style.visibility == 'hidden' || Control.style.display == 'none'))
			return false;
	}
	if (Control.disabled == true)
		return false;
	if ((Control.tagName == "INPUT") || (Control.tagName == "SELECT")|| (Control.tagName == "TEXTAREA"))
	{
		var roSpan = GXgetControlRef_impl( "span_"+gxSafeId(Control));
		if( roSpan && gxControlIsVisible( roSpan))
			return false;
		else
			return true;
	}
	return false;
}


var bGXAutoskip = false;
function form_onkeyup(domevent)
{
	var event = window.event?window.event:domevent;
	var evel = (event.target || event.srcElement);
	var maxlen = evel.getAttribute("maxlength");
	var value = typeof(evel.value)=="undefined"?"":evel.value;
	if ((evel.type == "" && GXLastKeyCode == 9) || ( bGXAutoskip && evel.type != "" && !isCtrlKeyCode( GXLastKeyCode) && value.length >= maxlen))
	{
		if (isTextWithLink( evel))
		{
			return;
		}
		var el = gxSearchControlOnForm( GXInvalidCtrl?GXInvalidCtrl:GXLastFocusCtrlRef);
		if (el == -1)
			return true;
		var Control = gxSearchFocus( GXShiftPressed?el-1:el+1, !GXShiftPressed);
		gxSetControlFocus( Control);
	}
}

function isTextWithLink( Control)
{
	if (Control != null)
	{
		if ((Control.tagName == "A") && Control.childNodes && (Control.childNodes.length > 0))
		{
			var childNode = Control.firstChild;
			if ( innerChildIsText( childNode))
				return true;
			
		}
	}
	return false;
}

function innerChildIsText( childNode)
{
	while (childNode != null)
	{
		if (childNode.nodeName && (childNode.nodeName == "#text"))
			return true;
		childNode = childNode.firstChild;
	}
	return false;
}

function gxEnterBtnHasFocus()
{
	GXLastFocusCtrlRef;
	if (GXLastFocusCtrlRef == null)
		return false;
	return GXLastFocusCtrlRef.type == 'submit' && gxIsEventEnterControl(GXLastFocusCtrlRef, GXWCP);
}

function gxSkipFocus()
{
	var el = gxSearchControlOnForm( GXLastFocusCtrlRef);
	if (el == -1)
		return true;
	var Control;
	for (Control = gxSearchFocus( ++el, true);;Control = gxSearchFocus( ++el, true))
	{
		if (Control == null || el == document.forms[0].elements.length)
			el = -1;
		else
		{
		    if (GXSkipOnEnter)
		        break;
			if (Control.type == 'submit' && !gxIsEventEnterControl(Control, GXWCP))
				break;
			if (Control.type != 'submit' && Control.type != 'button')
				break;
		}
	}
	gxSetControlFocus( Control);	
}

function gxSearchControlOnForm( Ctrl)
{
	var i_max = document.forms[0].elements.length -1;
	var i_min = 0;
	el = getControlIndex(Ctrl,i_min,i_max);	
	return el;
}


function getControlIndex( Ctrl,i_min,i_max)
{
	if (!document.all)
	{
		return Ctrl.gxIndex;
	}
	else
	{	
		var i_minsi = document.forms[0].elements[i_min].sourceIndex;
		var i_maxsi = document.forms[0].elements[i_max].sourceIndex;
		var i_med = parseInt(i_min + ((i_max - i_min)/2)) + 1;
		var i_medsi = document.forms[0].elements[i_med].sourceIndex;
		if ((i_min == i_max) && (Ctrl.sourceIndex == i_minsi) && (Ctrl.sourceIndex == i_maxsi))
			return i_min;
		
		if (Ctrl.sourceIndex == i_minsi)
			return i_min;
		if (Ctrl.sourceIndex == i_maxsi)
			return i_max;
		if (Ctrl.sourceIndex == i_medsi)
			return i_med;

		if ((Ctrl.sourceIndex > i_medsi) && (Ctrl.sourceIndex < i_maxsi))
			return getControlIndex(Ctrl,i_med+1,i_max-1);
			
		if ((Ctrl.sourceIndex > i_minsi) && (Ctrl.sourceIndex < i_medsi))
			return getControlIndex(Ctrl,i_min+1,i_med-1);
	}	
}

function gxSearchFocus( el, Forward)
{
	if ( Forward)
		return gxSearchNextFocus( el);
	return gxSearchPrevFocus( el);
}

function gxDOMCtrlList()
{
  return document.forms[0].elements;
}

function gxSearchPrevFocus( el)
{
  var arr = gxDOMCtrlList();
	for(var i=el;i>=0;i--)
	{
		if (gxControlIsAccepted( arr[i]))
			return arr[i];
	}
	return null;
}

function gxSearchNextFocus( el)
{
  var arr = gxDOMCtrlList();
	for(var i=el;i<arr.length;i++)
	{
		if (gxControlIsAccepted( arr[i]))
			return arr[i];
	}
	return null;
}

function gxControlGrid( Fld)
{
	try
	{
		for (i=0;i<=GXLastCtrlId();i++)
		{
		  var _GXValidStruct = GXValidStruct(i);
			if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.fld == Fld)
				return _GXValidStruct.grid;
		}
	}
	catch(e){}
	return 0;
}

function gxGridLvl( GridId)
{
	try
	{
		for (i=GXLastCtrlId();i>=0;i--)
		{
		    var _GXValidStruct = GXValidStruct(i);
			if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.grid == GridId)
				return _GXValidStruct.lvl;
		}
	}
	catch(e){}
	return 0;
}

function gxLvlGrid( Lvl)
{
	try
	{
		for (i=GXLastCtrlId();i>=0;i--)
		{
		    var _GXValidStruct = GXValidStruct(i);
			if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.lvl == Lvl)
				return _GXValidStruct.grid;
		}
	}
	catch(e){}
	return 0;
}


function gxControlLvl( Fld)
{
	var GridId = 0;
	try
	{
		for (i=0;i<=GXLastCtrlId();i++)
		{
			var _GXValidStruct = GXValidStruct(i);
			if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.fld == Fld)
			{
				GridId = _GXValidStruct.lvl;
				break;
			}
		}
	}
	catch(e){}
	return GridId;
}

function gxOld( Fld, Var)
{
	try
	{
		var Control = GXgetControlGridRef( Var, gxControlGrid( Fld));
		var ctrlId = gxSafeId( Control);
		if (GXOldValue[ctrlId] == null)
		{
			if (Control != null)
				GXOldValue[ctrlId] = Control.value;
		}
		return GXOldValue[ctrlId];
	}
	catch(e){}
	return '';
}

function gxControlStruct( CtrlId)
{
  return gxControlStruct_Prefix( WCSV_ctx, CtrlId);
}

function gxControlStruct_Prefix( Prefix, CtrlId)
{
	try
	{
	  var LastCtrl = GXLastCtrlId_Prefix(Prefix);
		for (i=0;i<=LastCtrl;i++)
		{
		  var validStruct = GXValidStruct_Prefix(Prefix, i);
			if (typeof(validStruct) != "undefined" && validStruct.fld == CtrlId)
				return validStruct;
		}
	}
	catch(e){}
	return null;
}


function gxControlStructForVar( GXVarName)
{
	try
	{
		for (i=0;i<=GXLastCtrlId();i++)
		{
			var _GXValidStruct = GXValidStruct(i);
			if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.gxvar == GXVarName)
			{
				return _GXValidStruct;
			}
		}
	}
	catch(e){}
	return null;
}

function gxControlStructForGrid( GridId)
{
	try
	{
		for (i=0;i<=GXLastCtrlId();i++)
		{
			var _GXValidStruct = GXValidStruct(i);
			if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.grid == GridId)
			{
				return _GXValidStruct;
			}
		}
	}
	catch(e){}
	return null;
}

function gxControlStructForField( Fld)
{
	try
	{
		for (i=0;i<=GXLastCtrlId();i++)
		{
			var _GXValidStruct = GXValidStruct(i);
			if (typeof(_GXValidStruct) != "undefined" && _GXValidStruct.fld == Fld)
			{
				return _GXValidStruct;
			}
		}
	}
	catch(e){}
	return null;
}

function gxFirstCtrlAfterGrid(fromCtrl, gridId)
{
	var lastCtrl = GXLastCtrlId();
	for(var i=fromCtrl; i<lastCtrl; i++)
	{
		var validStruct = GXValidStruct(i);
		if(typeof(validStruct) != "undefined" && validStruct.grid != gridId)
			return i;
	}
	return lastCtrl;
}

function gxSafeId( Control)
{
	return ((typeof(Control.id) == "undefined" || Control.id == '')? Control.name : Control.id);
}

function gxOldKey( Fld)
{
	try
	{
		return GXOldKeyValue[Fld];
	}
	catch(e){}
	return '';
}

function gxOldGridKey( Fld, GridId)
{
	try
	{
		return GXOldKeyValue[Fld + GXCurrentGridRow( GridId)];
	}
	catch(e){}
	return '';
}


function gxOldInteger( Fld, Var)
{	
	var nIntVal = parseInt( gxOld( Fld, Var),10);
	return isNaN( nIntVal) ? 0:nIntVal;
}

function gxOldDecimal( Fld, Var)
{
	var nDecVal = gxparseFloat( gxOld( Fld, Var), gxThSep, gxDecPoint);
	return isNaN( nDecVal) ? 0:nDecVal;
}

function gxSetKey( Fld, Var)
{
	if (Fld != null)
	{
		var sAssignCode = 'GXOldKeyValue["' + Fld +'"]=' + Var ;
		eval( sAssignCode);
	}
}

function gxUnsetSetKey( Fld)
{
	if (Fld != null)
	{
		var sAssignCode = 'GXOldKeyValue["' + Fld +'"]=null;' ;
		eval( sAssignCode);
	}
}

function gxSetGridKey( Fld, GridId, Var)
{
	if (Fld != null)
	{
		var sAssignCode = 'GXOldKeyValue["' + Fld + GXCurrentGridRow( GridId) +'"]=' + Var ;
		eval( sAssignCode);
	}
}

function gxUnsetSetGridKey( Fld, GridId)
{
	if (Fld != null)
	{
		var sAssignCode = 'GXOldKeyValue["' + Fld + GXCurrentGridRow( GridId) +'"]=null;' ;
		eval( sAssignCode);
	}
}

function gxSetOld( Fld, Ctrl, Var)
{
	var Control = GXgetControlGridRef( Ctrl, gxControlGrid( Fld));
	if (Control != null)
	{
		var ctrlId = gxSafeId( Control);
		var sAssignCode = 'GXOldValue["' + ctrlId + '"]=' + Var ;
		eval( sAssignCode);
	}
}

function gxRmvGridRow(CurrentRow, GridId)
{
	var IsRemoved = gxIsRowRemoved( GridId, CurrentRow);
	try
	{
		for (var i=GXLastCtrlId();i>=0;i--)
		{
			var _GXValidStruct = GXValidStruct(i);
			if ( typeof(_GXValidStruct) != "undefined" && _GXValidStruct.grid == GridId)
			{
				var Ctrl = GXgetControlRef_impl( _GXValidStruct.fld + "_" + CurrentRow);
				if (Ctrl != null && !gxIsGxRemove(Ctrl))
				{
					Ctrl.gxdisabled = IsRemoved;
				}
			}
		}
	}
	catch(e){}
	setTimeout( "gxValidGridRow("+ GridId+", '"+CurrentRow+"')", 1);
}

function gxIsGxRemove( Ctrl)
{
	if(Ctrl != null)
		return (Ctrl.name.indexOf("_GXREMOVE") != -1);
	return false;
}

function gxIsEventEnterControl(Ctrl, gxWCP)
{
	var eventAtt = Ctrl.attributes["gxevent"];
	if(eventAtt)
		return (eventAtt.value == (gxWCP+'EENTER.'));
	return false;
}

function gxIsEventCheckControl(Ctrl, gxWCP)
{
	var eventAtt = Ctrl.attributes["gxevent"];
	if(eventAtt)
		return (eventAtt.value == (gxWCP+'ECHECK.'));
	return false;
}

function gxArrayToSource( Arr)
{
	if (Arr.toSource != null)
		return Arr.toSource();
	var Result = "[";
	var size = Arr.length - 1;
	for (var i in Arr)
	{
		Result += gxObjectToSource(Arr[i]);
		if (i < size)
			Result += ',';
    }
	Result += ']';
	return Result;
}

function gxObjectToSource( Obj)
{
	if (typeof( Obj) == "object")
	{
		var Result = '{';
		var Sep = '';
   		for (var i in Obj)
   		{
      		Result += Sep;
      		Result += i + ":\'" + gxEncodeValue(Obj[i]) + "\'";
      		Sep = ',';
      	}
      	Result += '}';
   		return Result;
	}
	return '\'' + gxEncodeValue(Obj.toString()) + '\'';
}

function gxFormat()
{
	var msg = arguments[0];
	for (var i=1;i<arguments.length; i++)
		msg = msg.replace( '%'+i, gxtrim(arguments[i].toString()));
	return msg;
}

function gxNewLine()
{
	return '<BR>';	
}

function gxtostring( str)
{
	return str.toString();	
}
function gxtoformattedstring( str)
{
	return str.toString();	
}

function gxSubmit()
{
	gxdisableformnvis();
	ForceEnableControls();
	var doSubmit = true;
	if (typeof(document.forms[0].onsubmit) == 'function')
		doSubmit = document.forms[0].onsubmit();
	if (doSubmit)
		document.forms[0].submit();
}

function isGXTrn()
{
	return typeof(ClearNonKeyFields) != 'undefined';
}

function GXValidStruct(Ctrl)
{
  return GXValidStruct_Prefix(WCSV_ctx, Ctrl);
}

function GXValidStruct_Prefix(Prefix, Ctrl)
{
	try
	{
		return this[Prefix + 'GXValidFnc'][Ctrl];
	}
	catch(e){}
	return undefined;
}


function GXLastCtrlId()
{
  return GXLastCtrlId_Prefix(WCSV_ctx);
}


function GXLastCtrlId_Prefix(Prefix)
{
	try
	{
		return this[Prefix + 'GXLastCtrlId'];
	}
	catch(e){}
	return undefined;
}

function gxGetFormElements()
{
	return this[WCSV_ctx + 'GXValidFnc'];
}

function gxGetFirstAcceptedFormElement()
{
	try
	{
		var Elements = gxGetFormElements();
		for( var i=0;i<Elements.length;i++)
		{
			var Element = Elements[i];
			if (Elements[i] != null)
			{
				if ( Elements[i].lvl != 0)
					break;
				if (gxControlIsAccepted( GXgetControlRef( Elements[i].fld)))
					return Control;
			}
		}
	}
	catch(e){}
	return null;
}

var gxGridSerials = new Array();

function gxGetSerialId( ParentGridId, GridId)
{
	var serialId = GridId.toString();
	if( ParentGridId != 0)
	{
		var CurrentRow = GXCurrentGridRow( ParentGridId);
		serialId += CurrentRow;
	}
	return serialId;
}

function gxInitSerialCounter( serialId, LastCountCtrl, ParentGridId)
{
	var ctrlValue = 0;
	try
	{
		if( ParentGridId != 0)
		{
			var parentRow = GXCurrentGridRow( ParentGridId);
			ctrlValue = parseInt(GXgetGridControlValue( LastCountCtrl, parentRow));
		}
		else
		{
			ctrlValue = parseInt(GXgetControlValue( LastCountCtrl));
		}
	}
	catch(e) {}
	if(typeof(gxGridSerials[serialId]) == "undefined")
	{
		gxGridSerials[serialId]  = ctrlValue;
	}
}

function gxGetLastSerial( LastCountCtrl, ParentGridId, GridId)
{
	var serialId = gxGetSerialId( ParentGridId, GridId);
	gxInitSerialCounter( serialId, LastCountCtrl, ParentGridId);
	return gxGridSerials[serialId];
}

function gxSetLastSerial( ParentGridId, GridId, LastCount)
{
	var serialId = gxGetSerialId( ParentGridId, GridId);
	gxGridSerials[serialId] = LastCount;
}

function GXCtrlSerial( LastCountCtrl, CountAtt , PGridId, GridId , Inc )
{
	var LastCountAtt = gxGetLastSerial( LastCountCtrl, PGridId, GridId);
	var CurrentRow = GXCurrentGridRow( GridId);
	var gridLvl = gxGridLvl( GridId);
	var RowMode = gxGetGridRowMode( gridLvl, GridId);
	if (RowMode != 'INS' || gxgetNewRow( GridId, CurrentRow) == false)
		return eval(LastCountAtt);
	gxsetNewRow( GridId, CurrentRow, false);	
	sAssignCode = CountAtt + '=' + LastCountAtt + '+' + Inc;
	eval( sAssignCode);
	var currentCount = eval(CountAtt);
	gxSetLastSerial( PGridId, GridId, currentCount);
	return currentCount;
}

function gxsetNewRow( GridId, GXValidRow, state)
{
	if (GXNewRow[GridId] == null)
		GXNewRow[GridId] = new Array();
	GXNewRow[GridId][GXValidRow] = state;
}

function gxgetNewRow( GridId, GXValidRow)
{
	try
	{
		return GXNewRow[GridId][GXValidRow];
	}
	catch(e)
	{
		return true;
	}
}

function gxRowIsModified( GridId, Row)
{
	if (GridId != 0)
	{
		var gridLvl = gxGridLvl( GridId);
		if  ((typeof(Row) == "undefined") || (Row == null))
		{
			Row = GXCurrentGridRow( GridId);
		}
		return GXGridRowIsMod( gridLvl, Row);
	}
	return false;
}

function gxRowIsModifiedNow( GridId, Row)
{
	if (GridId == 0)
		return false;
	if( GXModifiedRows[GridId] == null)
		return false;
	if  ((typeof(Row) == "undefined") || (Row == null))
	{
		Row = GXCurrentGridRow( GridId);
	}
	if( GXModifiedRows[ GridId][Row] == true)
		return true;
}

function GXSetRowModified( IsModCtrl)
{
	try
	{
		var IsModCtrlName = IsModCtrl;
		var isModExp = /^nIsMod_([0-9]{1,4})_((?:[0-9]{4})*)/i;
		if ((typeof(IsModCtrl) != "string") && (IsModCtrl.name != undefined))
		{
			IsModCtrlName = IsModCtrl.name;
			IsModCtrl.value = 1;
		}
		else
			GXsetControlValue( IsModCtrlName, 1);
		var lvlRow = isModExp.exec(IsModCtrlName);
		if (lvlRow != null)
		{
			var GridLvl = lvlRow[1];
			var Row = lvlRow[2];
			var GridId = gxLvlGrid( GridLvl);
			if (GridId != 0)
			{
				if( GXModifiedRows[GridId] == null)
					GXModifiedRows[GridId] = new Array();
				GXModifiedRows[ GridId][Row] = true;
				gxEnableGxRemove( GridId, Row);
			}
		}
	} catch(e) {}
}

function gxEnableGxRemove( GridId, Row)
{
	var ParentGrid = gxGridParentGrid( GridId);
	var gridRow = (ParentGrid != null)?GXCurrentRow[ParentGrid]:'';
	var ParentGridRow = (typeof(gridRow) != "undefined")?gridRow:'';
	var ControlId = "_GXREMOVE" + GridId.toString() + "_" + Row + ParentGridRow;
	var Control = GXgetControlRef_impl( ControlId);
	if ((Control != null) && (Control.parentNode != null))
	{
		Control = Control.parentNode;
		Control.style.position = "relative";
		Control.style.display = "block";
		gxRedrawControl( Control);
		gxChangeCachedCtrl( ControlId, document.getElementById(ControlId));
	}
}

function gxGridParentGrid( GridId)
{
	for (var i=0;i<=GXLastCtrlId();i++)
	{
		var _GXValidStruct = GXValidStruct(i);
		if ((_GXValidStruct != undefined) && (_GXValidStruct.grid == GridId))
		{
			if (_GXValidStruct.pgrid != undefined)
				return _GXValidStruct.pgrid;
			else
				break;
		}
	}
	return null;
}

function gxIsRowRemoved( GridId, Row)
{
	if (GridId == 0)
		return false;
	if  ((typeof(Row) == "undefined") || (Row == null))
	{
		Row = GXCurrentGridRow( GridId);
	}
	var IsRemoved = GXgetControlValue( "_GXREMOVE" + GridId + '_' + Row);
	return IsRemoved;
}

function gxRedrawControl( Control)
{
	Control.outerHTML = Control.outerHTML;
}

function GXDisableCtrl(ControlId)
{
	var Control = GXgetControlRef_list( ControlId);
	if (Control == null)
		return;
	for( var i=0;i<Control.length;i++)
		gxsetCtrlProperty( Control[i], "Enabled", 0);
}

function gxGetAttachedCtrl( ControlId)
{
	for (var j=0; j<gxAttachedControls.length; j++)
      {
      	  var aCtrl = gxAttachedControls[j];
            if (aCtrl.id == ControlId)
                  return aCtrl;
      }
      return null;
}

function gxAttachCtrl(ControlId, CtrlInfo)
{
	 var ctrl = gxGetAttachedCtrl( ControlId);
      if (ctrl == null)
            gxAttachedControls.push( {id:ControlId, info:CtrlInfo});
}

function gxDoAttachs()
{
	for (var j=0; j<gxAttachedControls.length; j++)
      {
		var aCtrl = gxAttachedControls[j];
		var Prefix = aCtrl.info.prefix;
		var ArrCtrl = aCtrl.info.controls;
		for( var i=0;i<ArrCtrl.length;i++)
		{
			gxAddAttach( Prefix, ArrCtrl[i], aCtrl.id);
			var validStruct = GXValidStruct_Prefix(Prefix, ArrCtrl[i]);
			if (validStruct == null)
				return;
			gxCheckAttachedProperty2( validStruct, Prefix, "Visible", false);
			gxCheckAttachedProperty2( validStruct, Prefix, "Enabled", false);
		}
	}
}

function gxAddAttach( Prefix, i, ref)
{
  var validStruct = GXValidStruct_Prefix(Prefix, i);
  if (gxIsEmptyObject(validStruct))
    return;
  if (gxIsEmptyObject(validStruct.attachedCtrls))
    validStruct.attachedCtrls = new Array();
  validStruct.attachedCtrls.push( ref);
}

function gxIsEmptyObject( obj)
{
	if (obj == null || typeof(obj) == 'undefined' || String(obj) == '' || (typeof(obj) == 'number' && isNaN(obj)))
		return true;
	return false;
}

function gxCheckAttachedProperty( Prefix, FieldId, Property, Enable)
{
  var validStruct = gxControlStruct_Prefix( Prefix, FieldId);
  if (gxIsEmptyObject(validStruct))
  	return;
  gxCheckAttachedProperty2( validStruct, Prefix, Property, Enable);
}

function gxCheckAttachedProperty2( validStruct, Prefix, Property, Enable)
{
	if (gxIsEmptyObject(validStruct))
		return;
	if (gxIsEmptyObject(validStruct.attachedCtrls))
		return;
	var attachedCtrls = validStruct.attachedCtrls;
	for( var i=0;i<attachedCtrls.length;i++)
		gxCheckAttachedControlProperty( attachedCtrls[i], Property, Enable)
}

function gxCheckAttachedControlProperty( ControlId, Property, Enable)
{
	var attachedCtrls = gxGetAttachedCtrl( ControlId);
	if (attachedCtrls != null)
	{
		attachedCtrls = attachedCtrls.info;
		var GridId = attachedCtrls.grid;
		if (GridId == 0)
		{
			var Control = GXgetControlRef_impl( ControlId);
			var realAttachCtrls = gxGetRealAttachedControls( attachedCtrls);
			gxSetAttachedProperty( Control, realAttachCtrls, Property, Enable);
		}
		else
		{
			gxCheckAttachedGridControlProperty( attachedCtrls, ControlId, Property, Enable);
		}
	}
}

function gxGetRealAttachedControls( AttachedControls, GridId, CurrentRow)
{
	var realAttCtrls = new Array();
	var Prefix = AttachedControls.prefix;
	var ArrCtrl = AttachedControls.controls;
	var WC = AttachedControls.wc;
	for( var i=0;i<ArrCtrl.length;i++)
	{
		var validStruct = GXValidStruct_Prefix(Prefix, ArrCtrl[i]);
		var controlRef = null;
		if ((validStruct.grid != 0) && (validStruct.grid == GridId))
			controlRef = GXgetControlGridRef( WC+validStruct.fld, validStruct.grid, CurrentRow);
		else
			controlRef = GXgetControlGridRef( WC+validStruct.fld, validStruct.grid);
		realAttCtrls.push( controlRef);
	}
	return realAttCtrls;
}

function gxSetAttachedProperty( Control, AttachedControls, Property, Enable)
{
	var canSetProperty = false;
	for( var i=0;i<AttachedControls.length;i++)
	{
		if ( GXgetCtrlProperty_impl( AttachedControls[i], Property, false) == Enable)
		{
			if( Enable == true)
			{
				canSetProperty = true;
				break;
			}
			else if (( Enable == false) && (i == AttachedControls.length-1))
				canSetProperty = true;
		}
		else if( Enable == false)
			break;
	}
	if (canSetProperty)
		gxsetCtrlProperty( Control, Property, Enable);
}

function gxCheckAttachedGridControlProperty( AttachedControls, ControlId, Property, Enable)
{
	var GridId = AttachedControls.grid;
	var currentRowStr = gxCurrentGridRow(GridId);
	if (currentRowStr != undefined)
	{
		var Control = GXgetControlRef_impl( ControlId + "_" + currentRowStr);
		if( Control != null)
		{
			var realAttachCtrls = gxGetRealAttachedControls( AttachedControls, GridId, currentRowStr);
			gxSetAttachedProperty( Control, realAttachCtrls, Property, Enable);
		}
	}
}

function gxgetViewportWidth()
{
  return document.body.clientWidth;
}

function gxgetViewportHeight()
{
  return document.body.clientHeight;
}

function gxgetModalDOMNode()
{
	if (GXModalNode == null)
	{
		var ModalNode = document.getElementById('gxModalWindowDiv');
		if (!ModalNode)
		{
			ModalNode = document.createElement('DIV');
			ModalNode.innerHTML = '<div id="gxModalWindowDiv" style="display:none;text-align: right; vertical-align: top;background-color: #BEBEBE;filter: alpha(opacity=50); opacity: 0.5; position: absolute; width:'+gxgetViewportWidth()+'px; height:'+gxgetViewportHeight()+'px; top: 0px; left: 0px"><div id="gxModalNodeClose" onclick="gxenableform()" style="display:none;cursor:hand;font-size:9"><u>Enable Form</u></div></div>';
			document.body.appendChild( ModalNode);
			ModalNode = ModalNode.childNodes[0];
		}
		GXModalNode = ModalNode;
	}
	return GXModalNode;
}

function moveModalNode()
{
	var modalNode = gxgetModalDOMNode();
	var y=parseInt(modalNode.style.top);
	var sy=document.body.scrollTop;
	var newY = ((sy-y-10)/3+3)+y;
	modalNode.style.top=newY+'px';
}

function resizeModalNode()
{
	var modalNode = gxgetModalDOMNode();
	modalNode.style.width = gxgetViewportWidth()+'px';
	modalNode.style.height = gxgetViewportHeight()+'px';
}

var modalNodeInterval = null;

function showModalNodeClose()
{
	var modalNodeClose = document.getElementById("gxModalNodeClose");
	modalNodeClose.style.display = "block";
}

function hideModalNodeClose()
{
	var modalNodeClose = document.getElementById("gxModalNodeClose");
	modalNodeClose.style.display = "none";
}

function gxSetModalNodeOpacity(Opacity)
{
	var nodeDiv = gxgetModalDOMNode();
	var styleObj = nodeDiv.style; 
    styleObj.opacity = (Opacity / 100); 
    styleObj.MozOpacity = (Opacity / 100); 
    styleObj.filter = "alpha(opacity=" + Opacity + ")";
}

function gxdisableformnvis()
{
    try
    {
	gxSetModalNodeOpacity(0);
	gxdisableform();
	}
	catch(e){}

}

function gxdisableform()
{
 GXFormDisabled = true;
  gxgetModalDOMNode().style.display = 'block';
  modalNodeInterval = setInterval('moveModalNode()', 50);
  window.onresize=resizeModalNode;
  setTimeout('showModalNodeClose()', 5000);
}

function gxenableform()
{
  GXFormDisabled = false;
  gxgetModalDOMNode().style.display = 'none';
  clearInterval(modalNodeInterval);
  modalNodeInterval = null;
  window.onresize=null;
  hideModalNodeClose();
}

function GXsetGridSdtValue(ControlId, sRow, Value)
{
  GXsetGridControlValue( ControlId, sRow, Value)
}

function GXsetSdtValue(ControlId, Value)
{
  GXsetControlValue( ControlId, Value, 0);
}
