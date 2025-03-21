<?xml version='1.0'?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
<html>
<head>
</head>
<body>
	<TABLE cellSpacing="1" cellPadding="1" width="75%" border="0">
  
	  <TR>
	    <TD><STRONG><FONT color="darkred" size="6"><EM>GeneXus 
	      Programs</EM></FONT></STRONG></TD></TR>
	  <TR>
	    <TD>
	    	<UL>
	    		<xsl:apply-templates select="/Objects"/>
	    	</UL>
	    </TD>
	  </TR>
	</TABLE>
	
</body>
</html>
</xsl:template>

<xsl:template match="Objects">
	<xsl:apply-templates select="//Object"/>
		
	
</xsl:template>

<xsl:template match="Object">
	<LI>
		<TABLE><TR><TD><IMG style="CURSOR: hand" height="13" width="17">
<xsl:attribute name="src">
<!--<xsl:value-of select="/Objects/Path"/>gxxml/images/-->
<xsl:if test="ObjCls=0">transaction</xsl:if>
<xsl:if test="ObjCls=1">procedure</xsl:if>
<xsl:if test="ObjCls=2">report</xsl:if>
<xsl:if test="ObjCls=12">prompt</xsl:if>
<xsl:if test="ObjCls=13">web panel</xsl:if>
<xsl:if test="ObjCls=17">mbr</xsl:if>
.bmp</xsl:attribute></IMG></TD><TD>
<A><xsl:attribute name="href"><xsl:value-of select="ObjLink"/></xsl:attribute><xsl:value-of select="ObjDesc"/></A></TD></TR></TABLE>
	</LI>
</xsl:template>

</xsl:stylesheet>
