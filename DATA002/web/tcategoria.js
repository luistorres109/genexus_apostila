/*
               File: Categoria
        Description: Cadastro de Categorias
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:35.50
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
this._Valid_Catcodigo=function()
{
   try {
      gxballoon = getGXBallon("CATCODIGO");
      AnyError = 0;

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._categoria=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =14;
_GXValidFnc[11]={lvl:0,grid:0,fnc:_Valid_Catcodigo,fld:"CATCODIGO",gxvar:"A33CatCodi",op:[],ip:[],nacdep:[],v2v:function(Value){A33CatCodi=gxint(Value)},v2c:function(){GXsetControlValue("CATCODIGO",A33CatCodi,0)},c2v:function(){A33CatCodi=GXgetIntegerValue("CATCODIGO")}};
_GXValidFnc[14]={lvl:0,grid:0,fnc:null,fld:"CATNOME",gxvar:"A34CatNome",op:[],ip:[],nacdep:[],v2v:function(Value){A34CatNome=Value},v2c:function(){GXsetControlValue("CATNOME",A34CatNome,0)},c2v:function(){A34CatNome=GXgetControlValue("CATNOME")}};
this.A33CatCodi=0;
this.A34CatNome=0;
_SetStandaloneVars( ) ;
