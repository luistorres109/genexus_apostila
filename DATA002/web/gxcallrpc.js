var GXLastAjaxSt = 0;

function gxgetXMLHTTP()
{
  var A=null;
  try
  {
    A=new ActiveXObject("Msxml2.XMLHTTP")
  }
  catch(e)
  {
    try
    {
      A=new ActiveXObject("Microsoft.XMLHTTP")
    } 
    catch(oc)
    {
      A=null
    }
  }
  if(!A && typeof XMLHttpRequest != "undefined") 
  {
    A=new XMLHttpRequest()
  }
  return A
}

function gxcallRPC( sURL)
{
	gxcallajaxbackend( '', sURL, '', false);
}

function gxcallajaxbackend( backcall, sURL, sufix, ExecAtFail)
{
  var GXAjaxResult;
  var _xmlHttp = gxgetXMLHTTP();
  if(_xmlHttp)
  {
  	try
  	{
		var res = _xmlHttp.open("GET",sURL,false);
		_xmlHttp.send(null);
	}
	catch(e)
	{
		window.status = 'GXAjax HTTP error: '+ e.message;
		return null;
	}	
	window.status = '';
	if ((_xmlHttp.readyState != 4) || (_xmlHttp.status != 200))
	{
		window.status = 'GXAjax HTTP error: ('+ _xmlHttp.status + ') - ' + _xmlHttp.statusText;
	}
	else
	{
		if(_xmlHttp.responseText && _xmlHttp.responseText.length > 0 && _xmlHttp.responseText.charAt(0) != '<')
		{
			GXLastAjaxSt = 0;
        	eval( 'Response =' + _xmlHttp.responseText);
        	try
        	{
				GXAjaxResult = Response[0];
        		GXLastAjaxSt = Response[1];
        		if (GXLastAjaxSt == undefined)
        			GXLastAjaxSt = 0;
        		if (backcall && (ExecAtFail || GXLastAjaxSt == null || GXLastAjaxSt == 0))
	        		return eval( backcall + gxArrayToSource(GXAjaxResult) + sufix);
    	    }
        	catch(e){}
        }
    	else
			window.status = 'GXAjax HTTP error: (bad response format)';
    }
  }
  return GXAjaxResult;
}

function gxSuggestProvider(ControlId, ControlRefresh, CtrlSvc) 
{
	this.ControlId = ControlId;
	this.ControlRefresh = ControlRefresh;
	this.CtrlSvc = CtrlSvc;
}

gxSuggestProvider.prototype.requestSuggestions = function(oAutoSuggestControl, bTypeAhead) 
{
	var backcall = "GXReturnAutosuggestValues('" + this.VarRefresh + "',";
	var sURL = getObjectUrl() + '?' + 'gxajaxSuggest_' + this.CtrlSvc;
	for (var i=0; i<this.ControlId.length;i++)
		sURL += ',' + encodeURIComponent( eval(this.ControlId[i]));
	sURL += ',' + encodeURIComponent( GXgetControlValue_impl(this.ControlRefresh));
  oAutoSuggestControl.autosuggest(gxcallajaxbackend( backcall, sURL, ')', false), bTypeAhead);
}

function gxajaxSuggest( ControlId, ControlRefresh, CtrlSvc, bTypeAhead, suggParms)
{
	var CtrlId = ControlRefresh;
	var SuggestProvider = new gxSuggestProvider( ControlId, ControlRefresh, CtrlSvc);
	var oTextbox = new AutoSuggestControl( GXScreen_CtrlRef( ControlRefresh), SuggestProvider, CtrlId, bTypeAhead, suggParms);
}

function gxajaxHideCode( InputParms, ControlId, ControlRefresh)
{
	var backcall = "GXsetHideCode(" + gxArrayToSource(ControlRefresh) + ",";
	var sURL = getObjectUrl() + '?' + 'gxajaxHideCode_' + ControlId;
	for (var i=0; i<InputParms.length;i++)
		sURL += ',' + encodeURIComponent( eval(InputParms[i]));
	gxcallajaxbackend( backcall, sURL, ')', true);
	return GXLastAjaxSt;
}

function gxajaxCallCrl( ActionParameters, ControlRefresh, RefreshGrid)
{
	var funcCall = RefreshGrid?"GXsetGridComboValues":"GXsetComboValues";
	var ctrlName = RefreshGrid?ControlRefresh:GXScreen_CtrlRef( ControlRefresh).name;
	var backcall = funcCall + "('" + ctrlName + "',";
	sURL = getObjectUrl() + '?' + 'gxajaxCallCrl_' + ControlRefresh + ",";
	sURL += arrayToUrl( ActionParameters);
	gxcallajaxbackend( backcall, sURL, ')', true);
}


function gxajaxloadCrl( GXAction, ActionParameters, ActionResults)
{
	if (GXgetControlValue( "IsConfirmed") == "1")
	{
		GXLastAjaxSt = 0;
		return;
	}
	var backcall = "GXsetVarValues(" + gxArrayToSource(ActionResults) + ",";
	sURL = getObjectUrl() + '?' + 'gxajaxExecAct_' + GXAction + ',';
	sURL += arrayToUrl( ActionParameters);
	gxcallajaxbackend( backcall, sURL, ')', true);
}

function gxUDP( GXAction, InputParameters, OutputParameters)
{
	var backcall = "GXsetVarValues(" + gxArrayToSource(OutputParameters) + ",";
	sURL = getObjectUrl() + '?' + GXAction + ',';
	sURL += arrayToUrl( InputParameters);
	gxcallajaxbackend( backcall, sURL, ')', true);
}

function gxAggSel( ControlId, Act, ActionParameters)
{
	sURL = getObjectUrl() + '?' + 'gxajaxAggSel'+Act+'_' + ControlId + ",";
	sURL += arrayToUrl( ActionParameters);
	var GXAjaxResult = gxcallajaxbackend( null, sURL, '', false);
	return GXAjaxResult[0];
}

function gxAggSelDecimal( ControlId, Act, ThSep, DecPoint, ActionParameters)
{
	return gxparseFloat( gxAggSel( ControlId, Act, ActionParameters), ThSep, DecPoint);
}

function gxAggSelInteger( ControlId, Act, ActionParameters)
{
	return parseInt( gxAggSel( ControlId, Act, ActionParameters), 10);
}

function gxajaxloadGrid( GXAction, GridId, ActionParameters, RowVars)
{
	var loc = location;
	var backcall = "GXsetGridValues(" + GridId + "," + gxArrayToSource(RowVars) + ",";
	var sURL = 'http://localhost:8080/test/servlet/afillfacstub?';
	sURL += arrayToUrl( ActionParameters);
	gxcallajaxbackend( backcall, sURL, ')', false);
}

function GXsetGridValues( GridId, RowVars, AllRowsValues)
{
	var RefreshVarMethod = 'variablesToSubfile' + GridId + '()';
	var CurrRowVar = 'GXCurrentRow' + GridId;
	for (var i=0; i<AllRowsValues.length;i++)
	{
		var RowId = gxrpadwc( (i + 1).toString(), 4, '0');
		var sAssignCode = CurrRowVar + "='" + RowId + "'";
		eval( sAssignCode);
		var RowValues = AllRowsValues[i];
		GXsetVarValues( RowVars, RowValues);
		eval(RefreshVarMethod);
	}
}

function arrayToUrl( Parameters)
{
	var sURL = '';
	for (var i=0; i<Parameters.length;i++)
	{
		var parm = Parameters[i];
		if (window[parm] instanceof gxdate)
		{
			sURL += encodeURIComponent(window[parm].getUrlVal()) + ',';
		}
		else
		{
			var sValueCode = " encodeURIComponent(" + parm + ".toString())";
			sURL += eval( sValueCode) + ',';
		}
	}
	return sURL;
}

function getObjectUrl()
{
	var pathname = location.pathname;
	if (GXWCP != '')
	{
		var Component = GXgetControlRef_impl( GXWCP + '_CMPPGM');
		if (Component != null)
		{
			var parts = location.pathname.split('/');
			pathname = '';
			for (var i=1;i<parts.length-1;i++)
				pathname += '/' + parts[i];
			pathname += '/' + Component.value;
		}
	}
	return location.protocol + '//' + location.host + pathname;
}
