/*
               File: Estado
        Description: Cadastro de Estados
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:36.67
       Program type: Callable routine
          Main DBMS: sqlserver
*/
{gxsetDateFormat( "MDY" );
gxsetTimeFormat( 12 );
gxsetFirstYearCentury( 40 );
this.gxDecPoint =  "." ;
this.gxThSep =  "," ;}
 bGXAutoskip = false;
this._SetStandaloneVars=function()
{
   Gx_mode=GXgetControlValue("MODE");
}
this._Valid_Estcodigo=function()
{
   try {
      gxballoon = getGXBallon("ESTCODIGO");
      AnyError = 0;

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._estado=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =16;
_GXValidFnc[11]={lvl:0,grid:0,fnc:_Valid_Estcodigo,fld:"ESTCODIGO",gxvar:"A23EstCodi",op:[],ip:[],nacdep:[],v2v:function(Value){A23EstCodi=gxint(Value)},v2c:function(){GXsetControlValue("ESTCODIGO",A23EstCodi,0)},c2v:function(){A23EstCodi=GXgetIntegerValue("ESTCODIGO")}};
_GXValidFnc[14]={lvl:0,grid:0,fnc:null,fld:"ESTUF",gxvar:"A24EstUF",op:[],ip:[],nacdep:[],v2v:function(Value){A24EstUF=Value},v2c:function(){GXsetControlValue("ESTUF",A24EstUF,0)},c2v:function(){A24EstUF=GXgetControlValue("ESTUF")}};
_GXValidFnc[16]={lvl:0,grid:0,fnc:null,fld:"ESTNOME",gxvar:"A25EstNome",op:[],ip:[],nacdep:[],v2v:function(Value){A25EstNome=Value},v2c:function(){GXsetControlValue("ESTNOME",A25EstNome,0)},c2v:function(){A25EstNome=GXgetControlValue("ESTNOME")}};
this.A23EstCodi=0;
this.A24EstUF=0;
this.A25EstNome=0;
_SetStandaloneVars( ) ;
