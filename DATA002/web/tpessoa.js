/*
               File: Pessoa
        Description: Cadastro de Pessoas
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:39.37
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
this._Valid_Pescodigo=function()
{
   try {
      gxballoon = getGXBallon("PESCODIGO");
      AnyError = 0;

   }
   catch(e){}
   try {
      if (gxballoon == null) return true; return gxballoon.show();
   }
   catch(e){}
   return true ;
}
this._Valid_Pesdatnasc=function()
{
   try {
      gxballoon = getGXBallon("PESDATNASC");
      AnyError = 0;
      try {
         if ( ! ( (new gxdate("").compare(A15PesDatN)==0) || new gxdate( A15PesDatN ).compare( gxymdtod( 1753, 01, 01) ) >= 0 ) )
         {
            gxballoon.setError("Field Data de Nascimento da Pessoa is out of range");
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
this._Valid_Estcodigo=function()
{
   try {
      gxballoon = getGXBallon("ESTCODIGO");
      AnyError = 0;
      if ( AnyError == 0 && ( A23EstCodi != gxOldKey("A23EstCodiA24EstUF") ) )
      {
         gxajaxloadCrl('gxLoad_4',new Array("A23EstCodi"),new Array("A24EstUF","A25EstNome"));
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
this._Valid_Cidcodigo=function()
{
   try {
      gxballoon = getGXBallon("CIDCODIGO");
      AnyError = 0;
      if ( AnyError == 0 && ( A26CidCodi != gxOldKey("A26CidCodiA27CidNome") ) )
      {
         gxajaxloadCrl('gxLoad_3',new Array("A26CidCodi"),new Array("A27CidNome","A23EstCodi"));
         if ( GXLastAjaxSt == 101 )
         {
            if ( ! ( (0==A26CidCodi) ) )
            {
               gxballoon.setError("No matching 'Cadastro de Cidades'.");
               AnyError = 1 ;
               gxUnsetSetKey("A26CidCodiA27CidNome");
            }
         }
         else
         {
            gxSetKey("A26CidCodiA27CidNome","A26CidCodi");
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
this._pessoa=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =42;
_GXValidFnc[11]={lvl:0,grid:0,fnc:_Valid_Pescodigo,fld:"PESCODIGO",gxvar:"A12PesCodi",op:[],ip:[],nacdep:[],v2v:function(Value){A12PesCodi=gxint(Value)},v2c:function(){GXsetControlValue("PESCODIGO",A12PesCodi,0)},c2v:function(){A12PesCodi=GXgetIntegerValue("PESCODIGO")}};
_GXValidFnc[14]={lvl:0,grid:0,fnc:null,fld:"PESNOME",gxvar:"A13PesNome",op:[],ip:[],nacdep:[],v2v:function(Value){A13PesNome=Value},v2c:function(){GXsetControlValue("PESNOME",A13PesNome,0)},c2v:function(){A13PesNome=GXgetControlValue("PESNOME")}};
_GXValidFnc[16]={lvl:0,grid:0,fnc:null,fld:"PESCPF",gxvar:"A14PesCPF",op:[],ip:[],nacdep:[],v2v:function(Value){A14PesCPF=Value},v2c:function(){GXsetControlValue("PESCPF",A14PesCPF,0)},c2v:function(){A14PesCPF=GXgetControlValue("PESCPF")}};
_GXValidFnc[18]={lvl:0,grid:0,fnc:_Valid_Pesdatnasc,fld:"PESDATNASC",gxvar:"A15PesDatN",op:[],ip:[18],nacdep:[],v2v:function(Value){A15PesDatN=Value},v2c:function(){GXsetControlValue("PESDATNASC",A15PesDatN,0)},c2v:function(){A15PesDatN=GXgetControlValue("PESDATNASC")}};
_GXValidFnc[20]={lvl:0,grid:0,fnc:null,fld:"PESENDERECO",gxvar:"A16PesEnde",op:[],ip:[],nacdep:[],v2v:function(Value){A16PesEnde=Value},v2c:function(){GXsetControlValue("PESENDERECO",A16PesEnde,0)},c2v:function(){A16PesEnde=GXgetControlValue("PESENDERECO")}};
_GXValidFnc[22]={lvl:0,grid:0,fnc:null,fld:"PESENDNUMERO",gxvar:"A17PesEndN",op:[],ip:[],nacdep:[],v2v:function(Value){A17PesEndN=Value},v2c:function(){GXsetControlValue("PESENDNUMERO",A17PesEndN,0)},c2v:function(){A17PesEndN=GXgetControlValue("PESENDNUMERO")}};
_GXValidFnc[24]={lvl:0,grid:0,fnc:null,fld:"PESBAIRRO",gxvar:"A18PesBair",op:[],ip:[],nacdep:[],v2v:function(Value){A18PesBair=Value},v2c:function(){GXsetControlValue("PESBAIRRO",A18PesBair,0)},c2v:function(){A18PesBair=GXgetControlValue("PESBAIRRO")}};
_GXValidFnc[26]={lvl:0,grid:0,fnc:null,fld:"PESEMAIL",gxvar:"A19PesEmai",op:[],ip:[],nacdep:[],v2v:function(Value){A19PesEmai=Value},v2c:function(){GXsetControlValue("PESEMAIL",A19PesEmai,0)},c2v:function(){A19PesEmai=GXgetControlValue("PESEMAIL")}};
_GXValidFnc[28]={lvl:0,grid:0,fnc:null,fld:"PESTELEFONE",gxvar:"A20PesTele",op:[],ip:[],nacdep:[],v2v:function(Value){A20PesTele=Value},v2c:function(){GXsetControlValue("PESTELEFONE",A20PesTele,0)},c2v:function(){A20PesTele=GXgetControlValue("PESTELEFONE")}};
_GXValidFnc[30]={lvl:0,grid:0,fnc:null,fld:"PESCELULAR",gxvar:"A21PesCelu",op:[],ip:[],nacdep:[],v2v:function(Value){A21PesCelu=Value},v2c:function(){GXsetControlValue("PESCELULAR",A21PesCelu,0)},c2v:function(){A21PesCelu=GXgetControlValue("PESCELULAR")}};
_GXValidFnc[32]={lvl:0,grid:0,fnc:null,fld:"PESSITUACAO",gxvar:"A22PesSitu",op:[],ip:[],nacdep:[],v2v:function(Value){A22PesSitu=gxint(Value)},v2c:function(){GXsetComboBoxValue("PESSITUACAO",A22PesSitu)},c2v:function(){A22PesSitu=GXgetIntegerValue("PESSITUACAO")}};
_GXValidFnc[34]={lvl:0,grid:0,fnc:_Valid_Estcodigo,fld:"ESTCODIGO",gxvar:"A23EstCodi",op:[36,38],ip:[34,36,38],nacdep:[],v2v:function(Value){A23EstCodi=gxint(Value)},v2c:function(){GXsetControlValue("ESTCODIGO",A23EstCodi,0)},c2v:function(){A23EstCodi=GXgetIntegerValue("ESTCODIGO")}};
_GXValidFnc[36]={lvl:0,grid:0,fnc:null,fld:"ESTUF",gxvar:"A24EstUF",op:[],ip:[],nacdep:[],v2v:function(Value){A24EstUF=Value},v2c:function(){GXsetControlValue("ESTUF",A24EstUF,0)},c2v:function(){A24EstUF=GXgetControlValue("ESTUF")}};
_GXValidFnc[38]={lvl:0,grid:0,fnc:null,fld:"ESTNOME",gxvar:"A25EstNome",op:[],ip:[],nacdep:[],v2v:function(Value){A25EstNome=Value},v2c:function(){GXsetControlValue("ESTNOME",A25EstNome,0)},c2v:function(){A25EstNome=GXgetControlValue("ESTNOME")}};
_GXValidFnc[40]={lvl:0,grid:0,fnc:_Valid_Cidcodigo,fld:"CIDCODIGO",gxvar:"A26CidCodi",op:[42,34],ip:[40,42,34],nacdep:[],v2v:function(Value){A26CidCodi=gxint(Value)},v2c:function(){GXsetControlValue("CIDCODIGO",A26CidCodi,0)},c2v:function(){A26CidCodi=GXgetIntegerValue("CIDCODIGO")}};
_GXValidFnc[42]={lvl:0,grid:0,fnc:null,fld:"CIDNOME",gxvar:"A27CidNome",op:[],ip:[],nacdep:[],v2v:function(Value){A27CidNome=Value},v2c:function(){GXsetControlValue("CIDNOME",A27CidNome,0)},c2v:function(){A27CidNome=GXgetControlValue("CIDNOME")}};
this.A12PesCodi=0;
this.A13PesNome=0;
this.A14PesCPF=0;
this.A15PesDatN=0;
this.A16PesEnde=0;
this.A17PesEndN=0;
this.A18PesBair=0;
this.A19PesEmai=0;
this.A20PesTele=0;
this.A21PesCelu=0;
this.A22PesSitu=0;
this.A23EstCodi=0;
this.A24EstUF=0;
this.A25EstNome=0;
this.A26CidCodi=0;
this.A27CidNome=0;
_SetStandaloneVars( ) ;
