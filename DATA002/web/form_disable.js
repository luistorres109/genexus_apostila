function DisableAll() {
    var i;
    var TagName;
    var Disable;
    var Type;
    var TotItems;
    window.document.forms[0].style.cursor = "wait";
    removeAnchors();
    disableImages(); 
    TotItems = window.document.forms[0].elements.length;
    for (i=0; i < TotItems; i++) {
        TagName = window.document.forms[0].elements.item(i).tagName;
        switch (TagName) {
            case "INPUT":
                Type = window.document.forms[0].elements.item(i).type;
                if (Type == "submit" || Type == "image" || Type == "hidden")
                    Disable = true;
                else
                    Disable = false;
                break;
            default:
                Disable = false
                break;
        }
        if (Disable) {
            window.document.forms[0].elements.item(i).disabled = true;
            window.document.forms[0].elements.item(i).style.cursor="wait"
        }
    }
}
 
function removeAnchors() {
    var i;
    for (i=0; i < window.document.links.length; i++) {
 removeAnchor(window.document.links.item(i));
    }
}
 
function removeAnchor(aElement) {
 //The anchor to remove is passed as an argument
 //Create a Text Range object.
 var tr = aElement.parentTextEdit.createTextRange();
 //Locate the Anchor element in the Text Range.
 tr.moveToElementText(aElement);
 //Execute a command to remove the Anchor element.
 tr.execCommand("Unlink", false);
}
 
function disableImages() {
    var i;
    for (i=0; i < window.document.images.length; i++) {
        window.document.images.item(i).disabled = true;
        window.document.images.item(i).style.cursor="wait";
    }
}
