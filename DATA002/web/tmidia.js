/*
               File: Midia
        Description: Cadastro de Mídias
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:38.15
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
this._Valid_Midcodigo=function()
{
   try {
      gxballoon = getGXBallon("MIDCODIGO");
      AnyError = 0;

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._Valid_Filcodigo=function()
{
   try {
      gxballoon = getGXBallon("FILCODIGO");
      AnyError = 0;
      if ( AnyError == 0 && ( A28FilCodi != gxOldKey("A28FilCodiA29FilNome") ) )
      {
         gxajaxloadCrl('gxLoad_2',new Array("A28FilCodi"),new Array("A29FilNome"));
         if ( GXLastAjaxSt == 101 )
         {
            if ( ! ( (0==A28FilCodi) ) )
            {
               gxballoon.setError("No matching 'Cadastro de Filmes'.");
               AnyError = 1 ;
               gxUnsetSetKey("A28FilCodiA29FilNome");
            }
         }
         else
         {
            gxSetKey("A28FilCodiA29FilNome","A28FilCodi");
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
this._midia=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =20;
_GXValidFnc[11]={lvl:0,grid:0,fnc:_Valid_Midcodigo,fld:"MIDCODIGO",gxvar:"A37MidCodi",op:[],ip:[],nacdep:[],v2v:function(Value){A37MidCodi=gxint(Value)},v2c:function(){GXsetControlValue("MIDCODIGO",A37MidCodi,0)},c2v:function(){A37MidCodi=GXgetIntegerValue("MIDCODIGO")}};
_GXValidFnc[14]={lvl:0,grid:0,fnc:null,fld:"MIDTIPO",gxvar:"A35MidTipo",op:[],ip:[],nacdep:[],v2v:function(Value){A35MidTipo=gxint(Value)},v2c:function(){GXsetComboBoxValue("MIDTIPO",A35MidTipo)},c2v:function(){A35MidTipo=GXgetIntegerValue("MIDTIPO")}};
_GXValidFnc[16]={lvl:0,grid:0,fnc:null,fld:"MIDSITUACAO",gxvar:"A36MidSitu",op:[],ip:[],nacdep:[],v2v:function(Value){A36MidSitu=gxint(Value)},v2c:function(){GXsetComboBoxValue("MIDSITUACAO",A36MidSitu)},c2v:function(){A36MidSitu=GXgetIntegerValue("MIDSITUACAO")}};
_GXValidFnc[18]={lvl:0,grid:0,fnc:_Valid_Filcodigo,fld:"FILCODIGO",gxvar:"A28FilCodi",op:[20],ip:[18,20],nacdep:[],v2v:function(Value){A28FilCodi=gxint(Value)},v2c:function(){GXsetControlValue("FILCODIGO",A28FilCodi,0)},c2v:function(){A28FilCodi=GXgetIntegerValue("FILCODIGO")}};
_GXValidFnc[20]={lvl:0,grid:0,fnc:null,fld:"FILNOME",gxvar:"A29FilNome",op:[],ip:[],nacdep:[],v2v:function(Value){A29FilNome=Value},v2c:function(){GXsetControlValue("FILNOME",A29FilNome,0)},c2v:function(){A29FilNome=GXgetControlValue("FILNOME")}};
this.A37MidCodi=0;
this.A35MidTipo=0;
this.A36MidSitu=0;
this.A28FilCodi=0;
this.A29FilNome=0;
_SetStandaloneVars( ) ;
