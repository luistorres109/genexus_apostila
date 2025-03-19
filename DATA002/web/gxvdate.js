function gxvdate( Elem, nDateLen, nDateFmt, nTimeLen, nTimeFmt, sIdiom, pMandatoryCentury, nBlankWhenEmpty)
{
	var bMandatoryCentury = pMandatoryCentury || false;	
	var reEmpty = /^([ ]*(\/[ ]*\/[ ]*((00|12)(:00(:00)?)?[ ]*(a|am)?)?)?)?[ ]*$/i;
	var reVDTime;

	var wasEmpty = false;
	var oldValue = Elem.value;

	if (reEmpty.test( Elem.value))
	{
		wasEmpty = true;
		Elem.value = "";
	}
	
	var controlValue = "";

	var sVDTime = "^[ ]*(";
	if (nDateLen > 0)
	{
		if (nDateLen == 8)
			sVDTime = sVDTime + "([0-9]{1,2})[\/]?([0-9]{1,2})[\/]?([0-9]{2})";
		else
		{
			if (nDateFmt == 0)
			{
				if (bMandatoryCentury)
					sVDTime = sVDTime + "([0-9]{1,2})[\/]?([0-9]{1,2})[\/]?([0-9]{4})";
				else
					sVDTime = sVDTime + "([0-9]{1,2})[\/]?([0-9]{1,2})[\/]?([0-9]{2,4})";
			}
			else
			{
				if (bMandatoryCentury)
					sVDTime = sVDTime + "([0-9]{4})[\/]?([0-9]{1,2})[\/]?([0-9]{1,2})";
				else
					sVDTime = sVDTime + "([0-9]{2,4})[\/]?([0-9]{1,2})[\/]?([0-9]{1,2})";
			}					
		}
	}
	else
		/* Extra parenthesis are added to maintain parameter numbers */
		sVDTime = sVDTime + "( )?( )?( )?";

	if (nTimeLen > 0)
	{
		sVDTime = sVDTime + "(";
		if (nDateLen > 0)
			sVDTime = sVDTime + "[ ]*";
		sVDTime = sVDTime + "([0-9]{2})";

		if (nTimeLen > 2)
			sVDTime = sVDTime + "(:?([0-9]{2}))?";
		else
			sVDTime = sVDTime + "(( )?)?";

		if (nTimeLen > 5)
			sVDTime = sVDTime + "(:?([0-9]{2}))?";
		else
			sVDTime = sVDTime + "(( )?)?";

		if ( nTimeFmt == 1)
			sVDTime = sVDTime + "[ ]*(a|am|p|pm)?";
		else
			sVDTime = sVDTime + "(( )?)?";

		sVDTime = sVDTime + ")?";
	}
	sVDTime = sVDTime + ")?[ ]*$";
	reVDTime = new RegExp( sVDTime, "i");

	if (reVDTime.test( Elem.value))
	{
		var sTokArr = Elem.value.match( reVDTime);

		if (nDateLen > 0)
		{
			if (sTokArr[2] == "" || sTokArr[2] == null)
			{
				if (nBlankWhenEmpty == 1)
					controlValue = "        ";				
				else
					controlValue = "  /  /  ";
				if(nDateLen == 10)
					controlValue += "  ";
			}
			else
			{
				controlValue = sTokArr[2] + "/" + sTokArr[3] + "/" + sTokArr[4];
			}
		}
		else
			controlValue = "";

		if (nTimeLen > 0)
		{
			if (nDateLen > 0)
				controlValue = controlValue + " ";
			if (nBlankWhenEmpty == 1 && (sTokArr[6] == "" || sTokArr[6] == null) && (sTokArr[8] == "" || sTokArr[8] == null) && (sTokArr[10] == "" || sTokArr[10] == null))
			{
				controlValue = controlValue + "        ";
			}
			else{

				if (sTokArr[6] == "" || sTokArr[6] == null)
				{
						if(wasEmpty)
						{
							var emptTokArr = oldValue.match( reEmpty);
							if (emptTokArr[4] != "" && emptTokArr[4] != null)
								controlValue = controlValue + emptTokArr[4];
							else
								controlValue = controlValue + "00";
						}
						else
							controlValue = controlValue + "00";
				}
				else
					controlValue = controlValue + sTokArr[6];

				if (nTimeLen > 2)
				{
					if (sTokArr[8] == "" || sTokArr[8] == null)
						controlValue = controlValue + ":00";
					else
						controlValue = controlValue + ":" + sTokArr[8];
				}

				if (nTimeLen > 5)
				{
					if (sTokArr[10] == "" || sTokArr[10] == null)
						controlValue = controlValue + ":00";
					else
						controlValue = controlValue + ":" + sTokArr[10];
				}

				if ( nTimeFmt == 1)
				{
					var x;
					if (sTokArr[11] == "" || sTokArr[11] == null)
						x = "a";
					else
						x = sTokArr[11].substr(0,1);
					if (x.toLowerCase() == "p")
					{
						controlValue = controlValue + " PM";
					}
					else
					{
						controlValue = controlValue + " AM";
					}
				}
			}
		}
		
		var testDate = new gxdate('', gxdate.SFmt);
		try
		{
			testDate.assign_string(controlValue, gxdate.SFmt, (nTimeLen <= 0), true);
		}
		catch (E)
		{
			GXAlert( Elem, message_text( sIdiom, "datefmt"));
			return false;
		}
		
		if (controlValue != oldValue)
		{
		  Elem.value = controlValue;
		  if (navigator.userAgent.indexOf("Firefox/2") != -1)
		    //WA For FF 2.0 bug (https://bugzilla.mozilla.org/show_bug.cgi?id=357684)
		    Elem.onchange();
		}
		return true;
	}
	GXAlert( Elem, message_text( sIdiom, "datefmt"));
	return false;
}

function monthMaxDays(month, year)
{
	switch ( month)
	{
		case 0: return 31;
		case 1:
			if ((year % 100 != 0) && (year % 4 == 0) || (year % 400 == 0))
				return 29;
			else
				return 28;
		case 2: return 31;
		case 3: return 30;
		case 4: return 31;
		case 5: return 30;
		case 6: return 31;
		case 7: return 31;
		case 8: return 30;
		case 9: return 31;
		case 10: return 30;
		case 11: return 31;
	}
}
