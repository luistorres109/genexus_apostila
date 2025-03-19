/*
               File: Cidade
        Description: Cadastro de Cidades
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:36.17
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
this._Valid_Cidcodigo=function()
{
   try {
      gxballoon = getGXBallon("CIDCODIGO");
      AnyError = 0;

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._Valid_Estcodigo=function()
{
   try {
      gxballoon = getGXBallon("ESTCODIGO");
      AnyError = 0;
      if ( AnyError == 0 && ( A23EstCodi != gxOldKey("A23EstCodiA24EstUF") ) )
      {
         gxajaxloadCrl('gxLoad_2',new Array("A23EstCodi"),new Array("A24EstUF","A25EstNome"));
         if ( GXLastAjaxSt == 101 )
         {
            if ( ! ( (0==A23EstCodi) ) )
            {
               gxballoon.setError("No matching 'Cadastro de Estados'.");
               AnyError = 1 ;
               gxUnsetSetKey("A23EstCodiA24EstUF");
            }
         }
         else
         {
            gxSetKey("A23EstCodiA24EstUF","A23EstCodi");
         }
      }

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._cidade=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =20;
_GXValidFnc[11]={lvl:0,grid:0,fnc:_Valid_Cidcodigo,fld:"CIDCODIGO",gxvar:"A26CidCodi",op:[],ip:[],nacdep:[],v2v:function(Value){A26CidCodi=gxint(Value)},v2c:function(){GXsetControlValue("CIDCODIGO",A26CidCodi,0)},c2v:function(){A26CidCodi=GXgetIntegerValue("CIDCODIGO")}};
_GXValidFnc[14]={lvl:0,grid:0,fnc:null,fld:"CIDNOME",gxvar:"A27CidNome",op:[],ip:[],nacdep:[],v2v:function(Value){A27CidNome=Value},v2c:function(){GXsetControlValue("CIDNOME",A27CidNome,0)},c2v:function(){A27CidNome=GXgetControlValue("CIDNOME")}};
_GXValidFnc[16]={lvl:0,grid:0,fnc:_Valid_Estcodigo,fld:"ESTCODIGO",gxvar:"A23EstCodi",op:[18,20],ip:[16,18,20],nacdep:[],v2v:function(Value){A23EstCodi=gxint(Value)},v2c:function(){GXsetControlValue("ESTCODIGO",A23EstCodi,0)},c2v:function(){A23EstCodi=GXgetIntegerValue("ESTCODIGO")}};
_GXValidFnc[18]={lvl:0,grid:0,fnc:null,fld:"ESTUF",gxvar:"A24EstUF",op:[],ip:[],nacdep:[],v2v:function(Value){A24EstUF=Value},v2c:function(){GXsetControlValue("ESTUF",A24EstUF,0)},c2v:function(){A24EstUF=GXgetControlValue("ESTUF")}};
_GXValidFnc[20]={lvl:0,grid:0,fnc:null,fld:"ESTNOME",gxvar:"A25EstNome",op:[],ip:[],nacdep:[],v2v:function(Value){A25EstNome=Value},v2c:function(){GXsetControlValue("ESTNOME",A25EstNome,0)},c2v:function(){A25EstNome=GXgetControlValue("ESTNOME")}};
this.A26CidCodi=0;
this.A27CidNome=0;
this.A23EstCodi=0;
this.A24EstUF=0;
this.A25EstNome=0;
_SetStandaloneVars( ) ;
