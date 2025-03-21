var lastRow;
var lastSelRow;
var lastTable;
var lastSelTable;
var timeoutID;
var evenColor;
var oddColor;

function markrow(color, tableName, oldRowCtrl, row) 
{
	var oldRow;
	if( row != lastSelRow || tableName != lastSelTable)
	{
		initcolor( tableName, row);
		paintrow(tableName, row, color);
		oldRow = parseInt(document.getElementsByName(oldRowCtrl).item(0).value, 10);
		document.getElementsByName(oldRowCtrl).item(0).value = row;
		if (oldRow > 0 && oldRow < document.getElementById(tableName).rows.length) 
			paintrow(tableName, oldRow, origcolor( lastSelRow));
		lastSelRow = row;
		lastSelTable = tableName;
	}
}

function enterrow(color, tableName, oldRowCtrl, row) 
{
	if( row != lastSelRow || tableName != lastSelTable)
	{
		initcolor( tableName, row);
		if(navigator.appName == "Netscape" && tableName == lastTable)
		{
			leaverow(tableName, oldRowCtrl, lastRow);
		}
		if( row != parseInt(document.getElementsByName(oldRowCtrl).item(0).value, 10))
		{
			paintrow(tableName, row, color);
		}
		if(navigator.appName == "Netscape")
		{
			if( tableName == lastTable)
			{
				clearTimeout( timeoutID);
			}
			timeoutID = setTimeout('checkLeave("' + tableName + '", "' + oldRowCtrl + '", ' + row + ')', 1000);
		}
		lastRow = row;
		lastTable = tableName;
	}
}

function initcolor( tableName, row)
{
 	if ( evenColor == null & (row % 2 == 0))
 		evenColor = getRowBackcolor(tableName, row); 	
 	if ( oddColor == null & (row % 2 != 0))
 		oddColor = getRowBackcolor(tableName, row); 	
}

function getRowBackcolor(tableName, row)
{
	var tableRow = document.getElementById(tableName).rows[row];
	var color = tableRow.cells[0].bgColor;
	if(color == "")
		color = tableRow.bgColor;
	if(color == "")
		color = tableRow.style.backgroundColor;
	return color;
}

function checkLeave(tableName, oldRowCtrl, row)
{
	leaverow( tableName, oldRowCtrl, row);
}

function origcolor( row)
{
	if ( row % 2 == 0)
		return evenColor;
	else
		return oddColor;
}

function leaverow(tableName, oldRowCtrl, row) 
{
	if( row != parseInt(document.getElementsByName(oldRowCtrl).item(0).value, 10))
	{
		paintrow(tableName, row, origcolor( row));
	}
}

function paintrow(tableName, row, color)
{
	var i, j, table;

	table = document.getElementById(tableName);
	table.rows.item(row).style.backgroundColor = color;
	for(i = 0; i < table.rows.item(row).cells.length; i++)
	{
		table.rows.item(row).cells.item(i).style.backgroundColor = color;
		for(j = 0; j < table.rows.item(row).cells.item(i).childNodes.length; j++)
		{
			if( table.rows.item(row).cells.item(i).childNodes.item(j).nodeName == "SPAN")
			{
				table.rows.item(row).cells.item(i).childNodes.item(j).style.backgroundColor = color;
			}
		}
	}
}
