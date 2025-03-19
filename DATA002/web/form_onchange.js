var Gx_mode = "";

function form_onchange( Mode, IsConfirmed, IsKey, Button, sIdiom)
{
	Gx_mode = Mode.value;
	if (Mode.value == "UPD")
	{
		if (IsConfirmed.value == "1")
		{
			if (IsKey)
			{
				if (Button != null)
					Button.value = message_text( sIdiom, "captionadd");
				if( gxControlIsAccepted( GXLastEvtControl))
					ClearNonKeyFields();
			}
			else
			{
				if (Button != null)
					Button.value = message_text( sIdiom, "captionupdate");
			}
			IsConfirmed.value = "0";
		}
		else
		{
			if (IsKey)
			{
				if (Button != null)
					Button.value = message_text( sIdiom, "captionadd");
				if( gxControlIsAccepted( GXLastEvtControl))
					ClearNonKeyFields();
			}
		}
	}
	else if (Mode.value == "INS")
	{
		if (IsConfirmed.value == "1")
		{
			if (Button != null)
				Button.value = message_text( sIdiom, "captionadd");
			IsConfirmed.value = "0";
		}
	}
}
