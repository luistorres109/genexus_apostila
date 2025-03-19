Date.prototype.equalsNoTime = gxEqualsNoTime;
Date.prototype.clone = gxClone;

function gxClone()
{
  return new Date(this.getTime());
}

function gxEqualsNoTime( date2)
{
	if(this.getDay() == date2.getDay()
		&& this.getMonth() == date2.getMonth()
			&& this.getYear() == date2.getYear())
				return true;
	return false;
}

function gxdate( SDate, XSFmt)
{
	this.mapCTODFormatToPattern = function(nFormat)
	{
		switch (nFormat)
		{
			case 0:	return "Y4MD";
			case 1:	return "YMD";
			case 2:	return "MDY";
			case 3:	return "DMY";
			case 4:	return "MDY4";
			case 5:	return "DMY4";
			case 6:	return "Y4MD";
		}
		return "Y4MD";
	}

	this.getStringWithFmt = function( sDateFormat)
	{
		var sDate = sDateFormat;
		var sDay = gxrpadwc( this.Value.getDate().toString(), 2, '0');
		var sMonth = gxrpadwc( (this.Value.getMonth() + 1).toString(), 2, '0');
		var sYear = gxrpadwc( this.Value.getFullYear().toString(), 4, '0');
		var Pos = this.FormatPos(sDateFormat);
		sDate = sDate.replace('D', sDay + ((Pos.DPos < 3) ? '/':''));
		sDate = sDate.replace('M', sMonth + ((Pos.MPos < 3) ? '/':''));
		if (sDateFormat.indexOf("Y4") == -1)
		{
			sYear = sYear.slice( 2,4);
			sDate = sDate.replace('Y', sYear + ((Pos.YPos < 3) ? '/':''));
		}
		else
			sDate = sDate.replace('Y4', sYear + ((Pos.YPos < 3) ? '/':''));
		return sDate;		
	}

	this.getString = function()
	{
		if (this.Value - new Date( 0, 0, 0, 0, 0, 0, 0) == 0)
			return '  /  /  ';
		return this.getStringWithFmt( gxdate.SFmt);
	}
	
	this.gxdtoc = function( nDateFormat, sSeparator)
	{
		var sDate = this.getStringWithFmt( this.mapCTODFormatToPattern( nDateFormat));
		return sDate.replace( '/', sSeparator);
	}

	this.getUrlVal = function()
	{
		var sDate = gxdate.SFmt;
		var sDay = gxrpadwc( this.Value.getDate().toString(), 2, '0');
		var sMonth = gxrpadwc( (this.Value.getMonth() + 1).toString(), 2, '0');
		var sYear = gxrpadwc( this.Value.getFullYear().toString(), 4, '0');
		var sHour = this.HasTimePart?gxrpadwc(this.Value.getHours().toString(),2,'0'):'';
		var sMin = 	this.HasTimePart?gxrpadwc(this.Value.getMinutes().toString(),2,'0'):'';
		var sSec = this.HasTimePart?gxrpadwc(this.Value.getSeconds().toString(),2,'0'):'';
		return sYear + sMonth + sDay + sHour + sMin + sSec;
	}

	this.getTimeString = function(WithSec)
	{
		var amPm = "";
		var iHour = this.Value.getHours();
		if ((TimeFmt == 12) && (iHour >= 12))
		{
			if (iHour > 12)
				iHour = iHour - 12;
			amPm = " PM";
		}
		else if (TimeFmt == 12)
			amPm = " AM";
		var sHour = this.HasTimePart?gxrpadwc(iHour.toString(),2,'0'):'';
		var sMin = 	this.HasTimePart?gxrpadwc(this.Value.getMinutes().toString(),2,'0'):'';
		var sSec = this.HasTimePart?gxrpadwc(this.Value.getSeconds().toString(),2,'0'):'';
		if (WithSec)
			return sHour +':'+ sMin + ':' + sSec + amPm;
		return sHour +':'+ sMin + amPm;
	}
	
	this.FormatPos = function( SFmt)
	{
		if ( SFmt == "ANSI")
		{
			YPos = 3;
			MPos = 2;
			DPos = 1;
		}
		else
		{
			Y4Pos = SFmt.indexOf("Y4");
			YPos = (Y4Pos == -1) ? SFmt.indexOf("Y") + 1 : Y4Pos + 1;
			MPos = SFmt.indexOf("M");
			if (Y4Pos != 0) MPos++;
			DPos = SFmt.indexOf("D");
			if (Y4Pos != 0) DPos++;
		}
		return {YPos:YPos,MPos:MPos,DPos:DPos};
	}		

	this.assign_date = function( DateValue)
	{
		if ( DateValue instanceof gxdate)
			this.Value = DateValue.Value;
		else
			this.Value = DateValue;
	}
	
	this.assign_string = function( SDate, SFmt, IgnoreTime, ThrowExc)
	{
		ANSIDateExp = /([0-9]{1,4})\/?-?([0-9]{1,2})\/?-?([0-9]{2,4})\s?([0-9]{2})?:?([0-9]{2})?:?([0-9]{2})?:?([0-9]{2})?\s?(AM|PM)?/i;
		DateParts = ANSIDateExp.exec(SDate);
		var datePartsLen = 0;
		this.HasDatePart = true;
		if (DateParts == null)
		{
			this.HasDatePart = false;
			if(SDate.indexOf("  /  /  ") != -1)
				IgnoreTime = true;
		}
		else
		{
			for( var i=1; i<DateParts.length;i++)
			{
				if(!gxIsEmptyObject(DateParts[i])) datePartsLen ++;
			}
		}
		var Pos = this.FormatPos(SFmt);		
		YY = 0;	MM = 0;	DD = 0;	Ho = 0; Mi = 0; Se = 0; Ce = 0;
		try
		{
			if ((Pos.DPos + Pos.MPos + Pos.YPos == 6) && (DateParts != null) && (DateParts.length >= 3))
			{
				if (DateParts[Pos.YPos] != null)
					YY = parseInt( DateParts[Pos.YPos], 10);
				if (isNaN( YY)) throw "InvalidDate";
				if (YY < gxdate.FYearOfCentury)
					YY += 2000;
				else if (YY < 100)
					YY += 1900;
				else if (YY < 1000)
					YY += 1000;
				if (DateParts[Pos.MPos] != null)
					MM = parseInt( DateParts[Pos.MPos],10) - 1;
				if (isNaN( MM) || (MM < 0) || (MM > 11)) throw "InvalidDate";
				if (DateParts[Pos.DPos] != null)
					DD = parseInt( DateParts[Pos.DPos], 10);
				if (isNaN( DD) || (DD < 0) || (DD > monthMaxDays(MM, YY))) throw "InvalidDate";
				this.HasDatePart = true;
			}
			this.HasTimePart = false;
			var TimeOffSet = 0;
			if (DateParts == null)
			{
				ANSIDateExp = /([0-9]{2}):?([0-9]{2}):?([0-9]{2})?:?([0-9]{2})?\s?(AM|PM)?/i;
				DateParts = ANSIDateExp.exec(SDate);
				if ( DateParts != null)
				{
					TimeOffSet = 1;
					//Has time part
					this.HasTimePart = true;
				}
			}
			else
			{
				if ( datePartsLen > 3)
				{
					TimeOffSet = 4;
					//Has time part
					this.HasTimePart = true;
				}
			}
			if (this.HasTimePart && !IgnoreTime)
			{
				if (DateParts[TimeOffSet] != null)
					Ho = parseInt( DateParts[TimeOffSet], 10);
				if (isNaN( Ho)) throw "InvalidHour";
				if ((SDate.indexOf("PM") != -1 || SDate.indexOf("pm") != -1) && ( Ho < 12))
					Ho += 12;
				if (DateParts[TimeOffSet + 1] != null)
					Mi = parseInt( DateParts[TimeOffSet + 1], 10);
				if (isNaN( Mi)) Mi = 0;
				if (DateParts[TimeOffSet + 2] != null)
					Se = parseInt( DateParts[TimeOffSet + 2], 10);
				if (isNaN( Se)) Se = 0;
				if (DateParts[TimeOffSet + 3] != null)
					Ce = parseInt( DateParts[TimeOffSet + 3], 10);
				if (isNaN( Ce)) Ce = 0;
			}
		}
		catch (E)
		{
			if (ThrowExc)
			{
				throw E;
			}
			else
			{
				if (E == "InvalidDate")
				{
					YY = 0;	MM = 0;	DD = 0;	Ho = 0; Mi = 0; Se = 0; Ce = 0;
				}
				if (E == "InvalidHour")
				{
					Ho = 0; Mi = 0; Se = 0; Ce = 0;
				}
			}
		}
		this.Value = new Date(YY, MM, DD, Ho, Mi, Se, Ce);
	}

	this.compare = function( DateValue)
	{
		if ( typeof(DateValue) == "string")
			return this.compare_string( DateValue);
		return this.compare_date( DateValue);
	}

	this.compare_string = function( SDate)
	{
		DateValue = new gxdate( SDate);
		return this.compare_date( DateValue);
	}
	
	this.compare_date = function( DateValue)
	{
		var Val;
		var parmHasTime = false;
		if ( DateValue instanceof gxdate)
		{
			parmHasTime = DateValue.HasTimePart;
			Val = DateValue.Value;
		}
		else
		{
			Val = DateValue;
		}
		if (this.HasTimePart || parmHasTime)
			return this.Value - Val;
		else
		{
			if (this.Value.getFullYear() > Val.getFullYear())
				return 1;
			else if (this.Value.getFullYear() < Val.getFullYear())
				return -1;
			else
			{
				if (this.Value.getMonth() > Val.getMonth())
					return 1;
				else if (this.Value.getMonth() < Val.getMonth())
					return -1;
				else
				{
					if (this.Value.getDate() > Val.getDate())
						return 1;
					else if (this.Value.getDate() < Val.getDate())
						return -1;
					else
						return 0;
				}
			}
		}
	}
	
	var TimeFmt = gxdate.TimeFmt;
	var SFmt = XSFmt || gxdate.SFmt;
	if ( typeof(SDate) == "string")
		this.assign_string( SDate, SFmt);
	else
		this.assign_date( SDate);		
	var FYearOfCentury = gxdate.FYearOfCentury || 40;
}

function gxgetDateObject( date)
{
	if ( date instanceof gxdate)
		return date.Value.clone();
	if ( typeof(date) == "string")
		return new gxdate( date).Value;
	if ( date instanceof Date)
		return date.clone();
	return new Date();
}

function gxgetgxateObject( date)
{
	if ( date instanceof gxdate)
		return date;
	if ( typeof(date) == "string")
		return new gxdate( date);
	if ( date instanceof Date)
	{
		var newDate = new gxdate( "");
		newDate.assign_date(date);
		return newDate;
	}
	return new gxdate("");
}

function gxnewClonedDate( gxDateObj, realDateObj)
{
	var newdate = new gxdate("");
	newdate.assign_date( realDateObj);
	if (gxDateObj instanceof gxdate)
	{
		newdate.SFmt = gxDateObj.SFmt;
		newdate.HasTimePart = gxDateObj.HasTimePart;
	}
	return newdate;
}

function gxgetNullDate()
{
	return new gxdate("").Value;
}

function gxnow()
{
	return new Date();
}

function gxlength( String)
{
	return String.length;	
}

function gxtoupper( String)
{
	return String.toUpperCase();	
}

function gxtolower( String)
{
	return String.toLowerCase();	
}

function gxtoday()
{
	day = new gxdate('');
	day.assign_date(new Date());
	return day;
}

function gxctot(SDate, SFmt)
{
	return new gxdate(SDate, SFmt);
}

function gxctod(SDate, SFmt)
{
	day = new gxdate(SDate, SFmt);
	day.Value.setHours( 0, 0, 0, 0);
	return day;
}

function gxymdtod( Y, M, D)
{
	day = new gxdate(D + '/' + M + '/' + Y, 'ANSI');
	day.Value.setHours( 0, 0, 0, 0);
	return day;
}

function gxymdhmstot( Y, M, D, H, Mi, S)
{
	day = new gxdate(D + '/' + M + '/' + Y + ' ' + H + ':' + Mi + ':' + S, 'ANSI');
	return day;
}


function gxgethour(SDate)
{
	return (new gxdate(SDate)).Value.getHours();
}

function gxgetminute(SDate)
{
	return (new gxdate(SDate)).Value.getMinutes();
}

function gxgetsecond(SDate)
{
	return (new gxdate(SDate)).Value.getSeconds();
}

function gxgetday(SDate)
{
	return (new gxdate(SDate)).Value.getDate();	
}

function gxgetmonth(SDate)
{
	return (new gxdate(SDate)).Value.getMonth() + 1;	
}

function gxgetyear(SDate)
{
	return (new gxdate(SDate)).Value.getFullYear();	
}

function gxsetDateFormat( SFmt)
{
	gxdate.SFmt = new String(SFmt);
}

function gxsetTimeFormat( TFmt)
{
	gxdate.TimeFmt = TFmt;
}

function gxsetFirstYearCentury( FYear)
{
	gxdate.FYearOfCentury = FYear;
}

function gxparseFloat( S, ThSep, DecPoint)
{
	if ( typeof(S) == "number")
		return S;	
	var N = S.replace( ThSep, '');
	N = N.replace( DecPoint, '.');
	return parseFloat( N);	
}

function gxInvalidFunc(StringCode)
{
	throw "gxInvalidFunc: " + StringCode;	
}


function gxrpadwc( val, len, padc)
{
	var xlen = val.length;
	var diff = len - xlen;
	if (diff < 1)
		return val;
	var xval='';
	for (var i=0;i<diff;i++)
		xval += padc;
	xval += val;
	return xval;
}

function gxDateAddDays( sdate, inc)
{
	return gxDateAddMill( sdate, gxDaytoMillisec( inc));
}


function gxDateAddSec( sdate, inc)
{
	return gxDateAddMill( sdate, gxSectoMillisec( inc));
}

function gxDateAddMill( sdate, inc)
{
	var date = gxgetDateObject( sdate).clone();
	var xdate = new gxdate();
	xdate.assign_date( date);
	var mill = date.getMilliseconds();
	date.setMilliseconds( mill + inc);
	return xdate.getString();
}


function gxDateSecDiff( date1, date2)
{
	var val = gxMillisecToSec( gxDateMilliDiff( date1, date2));
	return val;
}

function gxDateDaysDiff( date1, date2)
{
	var val = gxMillisecToDay( gxDateMilliDiff( date1, date2));
	return val;
}

function gxDateMilliDiff( date1, date2)
{
	var xdate1 = gxdateparm( date1);
	var xdate2 = gxdateparm( date2);
	var date1 = xdate1.Value.valueOf();
	var date2 = xdate2.Value.valueOf();
	return date1 - date2;
}

function gxDaytoMillisec( Days)
{
	return Days * 24 * 60 * 60 * 1000;
}

function gxSectoMillisec( Sec)
{
	return Sec * 1000;
}

function gxMillisecToDay( Mill)
{
	return Mill / 24 /60 / 60 / 1000;
}

function gxMillisecToSec( Mill)
{
	return Mill / 1000;
}

function gxdateparm( sdate)
{
	if ( typeof(sdate) == "string")
		return new gxdate( sdate);
	return sdate;	
}

function gxurlvaluedate( Control, sFmt)
{
  var value = (Control.value != undefined) ? Control.value:Control;
	var date = new gxdate( value, sFmt);
	return date.Value.getFullYear().toString() 
			+ gxrpadwc((date.Value.getMonth() + 1).toString(),2,'0') 
			+ gxrpadwc(date.Value.getDate().toString(),2,'0');
}

function gxurlvaluedatetime( Control, sFmt)
{
  var value = (Control.value != undefined) ? Control.value:Control;
	var date = new gxdate( value, sFmt);
	return 	date.Value.getFullYear().toString() + 
			gxrpadwc((date.Value.getMonth() + 1).toString(),2,'0') + 
			gxrpadwc(date.Value.getDate().toString(),2,'0') +
			gxrpadwc(date.Value.getHours().toString(),2,'0') +
			gxrpadwc(date.Value.getMinutes().toString(),2,'0') +
			gxrpadwc(date.Value.getSeconds().toString(),2,'0');
}

function gxurlvaluedecimal( Control, ThSep, DecPoint)
{
	var value = (Control.value != undefined) ? Control.value:Control;
	value = gxparseFloat( value, ThSep, DecPoint);
	return value.toString();
}

function gxdtoc( SDate, nDateFormat, sSeparator)
{
	var Date = new gxdate( SDate);
	return Date.gxdtoc( nDateFormat, sSeparator);
}

function gxdttoc(SDate, nLen, nDec)
{
	var Date = new gxdate(SDate);
	var sFmt = gxdate.SFmt;
	if ((nLen > 8) && (sFmt.indexOf("Y4") == -1))
		sFmt = sFmt.replace('Y', 'Y4');
	var DatePart = Date.getStringWithFmt( sFmt);
	if (nDec > 0)
		return DatePart + ' ' + Date.getTimeString(nDec==8);	
	return DatePart;	
}

function gxurlvalue( Control)
{
	return encodeURIComponent( (Control.value != undefined) ? Control.value:Control);
}

function gxltrim( str)
{
	return str.toString().replace(/^ */, '');
}

function gxrtrim( str)
{
	return str.toString().replace(/ *$/, '');
}

function gxtrim( str)
{
	return 	gxrtrim( gxltrim(str));
}

function gxstr( num)
{
	return num.toString();
}

function gxchr( num)
{
	return String.fromCharCode(num);
}

function gxaddyr( date, inc)
{
	return gxaddmth( date, 12 * inc);
}

function gxaddmth( date, inc)
{
	var origDate = gxgetgxateObject(date);
	date = gxgetDateObject( date);
	inc += date.getMonth();	
	var years = parseInt( inc/12);
	var months = parseInt( inc%12);
	date.setFullYear( date.getFullYear() + years);
	date.setMonth( months);
	return gxnewClonedDate( origDate, date);
}

function gxdtadd( date, inc)
{
	var origDate = gxgetgxateObject(date);
	inc = inc * 1000;
	date = gxgetDateObject( date);
	var millis = date.getMilliseconds();
	date.setMilliseconds( millis + inc);
	return gxnewClonedDate( origDate, date);
}

function gxdtdiff( date1, date2)
{
	date1 = gxgetDateObject( date1);
	date2 = gxgetDateObject( date2);
	return (date1 - date2) / 1000;
}

function gxeom( date)
{
	var origDate = gxgetgxateObject(date);
	date = gxgetDateObject( date);
	var lastDay = monthMaxDays( date.getMonth(), date.getYear());
	date.setDate( lastDay);
	return gxnewClonedDate( origDate, date);
}

function gxdow( date)
{
	date = gxgetDateObject( date);
	if( date.equalsNoTime( gxgetNullDate()))
		return 0;
	return date.getDay() + 1;
}

function gxage( date1, date2)
{
	 var dtAsOfDate;
	 var dtBirth;
	 var dtAnniversary;
	 var intSpan;
	 var intYears;
	 var intMonths;
	
	 dtBirth = gxgetDateObject( date1);
	 dtAsOfDate = gxgetDateObject( date2);
	 
	 var nullDate = gxgetNullDate();
	 if( dtBirth.equalsNoTime( nullDate) || dtAsOfDate.equalsNoTime( nullDate) 
	 			|| dtBirth.equalsNoTime( dtAsOfDate))
		return 0;
	
	 // if as of date is on or after born date
	 if ( dtAsOfDate >= dtBirth )
	 {
	    // get time span between as of time and birth time
	    intSpan = ( dtAsOfDate.getUTCHours() * 3600000 +
	                dtAsOfDate.getUTCMinutes() * 60000 +
	                dtAsOfDate.getUTCSeconds() * 1000    ) -
	              ( dtBirth.getUTCHours() * 3600000 +
	                dtBirth.getUTCMinutes() * 60000 +
	                dtBirth.getUTCSeconds() * 1000       )
	    // start at as of date and look backwards for anniversary 
	
	    // if as of day (date) is after birth day (date) or
	    //    as of day (date) is birth day (date) and
	    //    as of time is on or after birth time
	    if ( dtAsOfDate.getUTCDate() > dtBirth.getUTCDate() ||
	         ( dtAsOfDate.getUTCDate() == dtBirth.getUTCDate() && intSpan >= 0 ) )
	    {
	       // most recent day (date) anniversary is in as of month
	       dtAnniversary = 
	          new Date( Date.UTC( dtAsOfDate.getUTCFullYear(),
	                              dtAsOfDate.getUTCMonth(),
	                              dtBirth.getUTCDate(),
	                              dtBirth.getUTCHours(),
	                              dtBirth.getUTCMinutes(),
	                              dtBirth.getUTCSeconds() ) );
	
	    }
	    // if as of day (date) is before birth day (date) or
	    //    as of day (date) is birth day (date) and
	    //    as of time is before birth time
	    else
	    {
	       // most recent day (date) anniversary is in month before as of month
	       dtAnniversary = 
	          new Date( Date.UTC( dtAsOfDate.getUTCFullYear(),
	                              dtAsOfDate.getUTCMonth() - 1,
	                              dtBirth.getUTCDate(),
	                              dtBirth.getUTCHours(),
	                              dtBirth.getUTCMinutes(),
	                              dtBirth.getUTCSeconds() ) );
	
	       // get previous month
	       intMonths = dtAsOfDate.getUTCMonth() - 1;
	       if ( intMonths == -1 )
	          intMonths = 11;
	
	       // while month is not what it is supposed to be (it will be higher)
	       while ( dtAnniversary.getUTCMonth() != intMonths )
	          // move back one day
	          dtAnniversary.setUTCDate( dtAnniversary.getUTCDate() - 1 );
	    }
	    // if anniversary month is on or after birth month
	    if ( dtAnniversary.getUTCMonth() >= dtBirth.getUTCMonth() )
	    {
	       // years elapsed is anniversary year - birth year
	       intYears = dtAnniversary.getUTCFullYear() - dtBirth.getUTCFullYear();
	    }
	    // if birth month is after anniversary month
	    else
	    {
	       // years elapsed is year before anniversary year - birth year
	       intYears = (dtAnniversary.getUTCFullYear() - 1) - dtBirth.getUTCFullYear();
	    }
			return intYears;
	 }
	 return 0;
}

function gxconcat( str1, str2, sep)
{
	return gxrtrim( str1) + sep + str2;
}

function gxspace( n)
{
	var buffer = "";
	for (var i = 0; i < n; i++)
	{
		buffer += " ";
	}
	return buffer;
}

function gxint( num)
{
	var result = parseInt( num);
	if( isNaN( result))
		result = 0;
	return result;
}

function gxval( str)
{
	str = gxtrim( str).replace( ',', '.');
	var result = parseFloat(str);
	if( isNaN( result))
			result = 0;
	return result;
}

function gxtrunc( num, dec)
{
	var result = num;
	num = num.toString();
	
	var len = num.length;
	
	var decSep = num.indexOf('.');
	
	if(decSep != -1)
	{ 
		var intPart = num.substring(0, decSep);
		
		if( dec == 0)
			return intPart;
			
		var floatPart = "";
		if( decSep + dec <= len)
			floatPart = num.substring(decSep + 1, decSep + 1 + dec);
		
		num = intPart + '.' + floatPart;
		
		result = parseFloat( num);
		if( isNaN( result))
			result = 0;
	}
	return result;
}

function gxround( n, d)
{
	n = n.toString();
	var xx = n.indexOf('.');
	var zstr = '0000000000000000000000';
	var theInt = '';
	var theFrac = '';
	var theNo = '';
	var nx = 0;
	var xt = parseInt(d) + 1;
	var rstr = '' + zstr.substring(1,xt);
	var rfac = '.' + rstr + '5';
	var rfacx = parseFloat(rfac);
	if (xx == -1 ) 	{
		theFrac = zstr;
		theInt = "" + n;
	}
	else if (xx == 0) {
		theInt = '0';
		nx = 0 + parseFloat(n) + parseFloat(rfacx);
		n = nx + zstr;
		theFrac = '' + n.substring(1, n.length);
	}
	else {
		if(d == 0)
		{
			theInt = n.substring(0,xx);
			var result = parseInt(theInt);
			var firstFrac = parseInt(n.substring(xx+1, xx+2));
			if( isNaN( result))
				return 0;
			if( !isNaN( firstFrac) && firstFrac >= 5)
				result++;
			return result;
		}
		nx = parseFloat(n) + rfacx;
		theInt = nx.toString().substring(0,xx);
		n = '' + nx + zstr;
		theFrac = '' + n.substring(xx+1,xx + 1 + parseInt(d));
	}
	theFrac = theFrac.substring(0,parseInt(d));
	theNo = theInt + '.' + theFrac;
	var result = parseFloat( theNo);
		if( isNaN( result))
			result = 0;
	return result;
}

function gxsubstring( str, from, len)
{
	return str.toString().substring( from - 1, from - 1 + len);
}

function rgb( r, g, b)
{
	return gxrgb( r,g,b);
}

function gxrgb( r, g, b)
{
	return (r * 256 * 256) + g * 256 + b;
}
