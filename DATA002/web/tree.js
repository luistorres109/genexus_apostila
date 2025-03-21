// Tree class

itNbr = 0;
	
Tree.prototype.Add = TreeAdd;
Tree.prototype.LoadXML = TreeLoadXML;

function Tree( id, text, gxId)
{
	this.id = id;
	if (gxId)
		this.gxId = gxId;
	else
		this.gxId = id;
	this.text = text;
	this.itemsCount = 0;
	this.items = new Array;
}

function TreeAdd( id, text, gxId ) 
{
	var newItem;
	if (typeof( eval("this."+id)) != "undefined") {
		document.write("Error: "+id+" property already defined.");
		return;
	}
	newItem = new Tree( id, text, gxId);
	this.items[this.itemsCount] = newItem;
	this.itemsCount = this.itemsCount + 1;
	eval("this."+id+"=newItem")
	return newItem;
}

function subTree(treeBranch) 
{
	var i=0;
	var currTree = "";
	var currId="";
	var currBranch = treeBranch;
	var currCaption = "";
	while (this.cursor<=this.source.length) {
		var start=this.cursor;
		var tagStart=this.source.indexOf('<',this.cursor);
		if (tagStart==-1) return "";
		var tagEnd=this.source.indexOf('>',tagStart);
		this.cursor=tagEnd+1;
		var tag=this.source.substr(tagStart+1,tagEnd-tagStart-1);
		if (tag.charAt(0)=='/') // found end tag
			if (i==0) // no child-elements, there was chardata
				return this.source.substr(start,tagStart-start);
			else 
				return "";
		else if (tag == 'id') {
			currId = this.parseAsString('id');
			currTree = "mo_"+itNbr+"_"+currId;
			itNbr++;
			currBranch = treeBranch+"."+currTree;
		}
		else if (tag == 'caption') {
			currCaption = this.parseAsString('caption');
			eval( treeBranch+".Add('"+currTree+"','"+currCaption+"','"+currId+"')");
			}
		else if (tag.charAt(tag.length-1)=='/') 
			i++; // found empty tag
		else {// found start tag, parse childnodes
			i++;
			this.subTree(currBranch);
		}
	}
}

function parseAsString(parsedTag) 
{
	var start=this.cursor;
	var endTag='</'+parsedTag+'>'
	var end = this.source.indexOf(endTag,this.cursor);
	if (end==-1) return "";
	this.cursor=end+endTag.length;
	return this.source.substr(start,end-start);
}


function TreeLoadXML(source) {
	this.subTree = subTree;
	this.parseAsString = parseAsString;
	this.source=source;
	this.cursor=0;
	this.subTree(this.id);
}

