/*
               File: Filme
        Description: Cadastro de Filmes
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:37.46
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
this._Valid_Filcodigo=function()
{
   try {
      gxballoon = getGXBallon("FILCODIGO");
      AnyError = 0;

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._Valid_Fildata=function()
{
   try {
      gxballoon = getGXBallon("FILDATA");
      AnyError = 0;
      try {
         if ( ! ( (new gxdate("").compare(A31FilData)==0) || new gxdate( A31FilData ).compare( gxymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            gxballoon.setError("Field Data do Filme is out of range");
            AnyError = 1 ;
         }
      }
      catch(e){}

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._Valid_Catcodigo=function()
{
   try {
      gxballoon = getGXBallon("CATCODIGO");
      AnyError = 0;
      if ( AnyError == 0 && ( A33CatCodi != gxOldKey("A33CatCodiA34CatNome") ) )
      {
         gxajaxloadCrl('gxLoad_3',new Array("A33CatCodi"),new Array("A34CatNome"));
         if ( GXLastAjaxSt == 101 )
         {
            if ( ! ( (0==A33CatCodi) ) )
            {
               gxballoon.setError("No matching 'Cadastro de Categorias'.");
               AnyError = 1 ;
               gxUnsetSetKey("A33CatCodiA34CatNome");
            }
         }
         else
         {
            gxSetKey("A33CatCodiA34CatNome","A33CatCodi");
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
this._filme=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =24;
_GXValidFnc[11]={lvl:0,grid:0,fnc:_Valid_Filcodigo,fld:"FILCODIGO",gxvar:"A28FilCodi",op:[],ip:[],nacdep:[],v2v:function(Value){A28FilCodi=gxint(Value)},v2c:function(){GXsetControlValue("FILCODIGO",A28FilCodi,0)},c2v:function(){A28FilCodi=GXgetIntegerValue("FILCODIGO")}};
_GXValidFnc[14]={lvl:0,grid:0,fnc:null,fld:"FILNOME",gxvar:"A29FilNome",op:[],ip:[],nacdep:[],v2v:function(Value){A29FilNome=Value},v2c:function(){GXsetControlValue("FILNOME",A29FilNome,0)},c2v:function(){A29FilNome=GXgetControlValue("FILNOME")}};
_GXValidFnc[16]={lvl:0,grid:0,fnc:null,fld:"FILSITUACAO",gxvar:"A30FilSitu",op:[],ip:[],nacdep:[],v2v:function(Value){A30FilSitu=gxint(Value)},v2c:function(){GXsetComboBoxValue("FILSITUACAO",A30FilSitu)},c2v:function(){A30FilSitu=GXgetIntegerValue("FILSITUACAO")}};
_GXValidFnc[18]={lvl:0,grid:0,fnc:_Valid_Fildata,fld:"FILDATA",gxvar:"A31FilData",op:[],ip:[18],nacdep:[],v2v:function(Value){A31FilData=Value},v2c:function(){GXsetControlValue("FILDATA",A31FilData,0)},c2v:function(){A31FilData=GXgetControlValue("FILDATA")}};
_GXValidFnc[20]={lvl:0,grid:0,fnc:null,fld:"FILDESCRICAO",gxvar:"A32FIlDesc",op:[],ip:[],nacdep:[],v2v:function(Value){A32FIlDesc=Value},v2c:function(){GXsetControlValue("FILDESCRICAO",A32FIlDesc,0)},c2v:function(){A32FIlDesc=GXgetControlValue("FILDESCRICAO")}};
_GXValidFnc[22]={lvl:0,grid:0,fnc:_Valid_Catcodigo,fld:"CATCODIGO",gxvar:"A33CatCodi",op:[24],ip:[22,24],nacdep:[],v2v:function(Value){A33CatCodi=gxint(Value)},v2c:function(){GXsetControlValue("CATCODIGO",A33CatCodi,0)},c2v:function(){A33CatCodi=GXgetIntegerValue("CATCODIGO")}};
_GXValidFnc[24]={lvl:0,grid:0,fnc:null,fld:"CATNOME",gxvar:"A34CatNome",op:[],ip:[],nacdep:[],v2v:function(Value){A34CatNome=Value},v2c:function(){GXsetControlValue("CATNOME",A34CatNome,0)},c2v:function(){A34CatNome=GXgetControlValue("CATNOME")}};
this.A28FilCodi=0;
this.A29FilNome=0;
this.A30FilSitu=0;
this.A31FilData=0;
this.A32FIlDesc=0;
this.A33CatCodi=0;
this.A34CatNome=0;
_SetStandaloneVars( ) ;
