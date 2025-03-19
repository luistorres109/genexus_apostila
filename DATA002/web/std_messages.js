function message_text( sIdiom, sMsgCode)
{
	switch (sIdiom)
	{
		case "jap":
			switch (sMsgCode)
			{
				case "captionadd":
					return "追加";
				case "captionupdate":
					return "更新";
				case "datefmt":
					return "日付 または 時刻 の形式が誤っています。";
				default:
					return "メッセージコード '"+sMsgCode+"', が不明です。";
			}
			break;

		case "spa":
			switch (sMsgCode)
			{
				case "captionadd":
					return "Agregar";
				case "captionupdate":
					return "Actualizar";
				case "datefmt":
					return "El formato de la fecha u hora no es correcto.";
				default:
					return "Código de mensaje '"+sMsgCode+"', desconocido.";
			}
			break;

		case "por":
			switch (sMsgCode)
			{
				case "captionadd":
					return "Inserir";
				case "captionupdate":
					return "Atualizar";
				case "datefmt":
					return "O formato da data ou hora nao e correto.";
				default:
					return "Codigo de mensajem '"+sMsgCode+"' nao conhecido.";
			}
			break;

		case "ita":
			switch (sMsgCode)
			{
				case "captionadd":
					return "Inserire";
				case "captionupdate":
					return "Aggiornare";
				case "datefmt":
					return "Il formato della data/ora non e' valido.";
				default:
					return "Codice messaggio "+sMsgCode+"' non riconosciuto.";
			}
			break;

		default:
			switch (sMsgCode)
			{
				case "captionadd":
					return "Add";
				case "captionupdate":
					return "Update";
				case "datefmt":
					return "Date or time format is not correct.";
				default:
					return "Message code '"+sMsgCode+"' unknown.";
			}
			break;
	}
}
