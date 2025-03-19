/*
               File: Gx0020
        Description: Selection List Cadastro de Filmes
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:33.89
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
}
this._StandaloneModal=function()
{
}
this._gx0020=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =12;
_GXValidFnc[7]={lvl:0,grid:0,fnc:null,fld:"_CFILCODIGO",gxvar:"AV5cFilCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV5cFilCod=gxint(Value)},v2c:function(){GXsetControlValue("_CFILCODIGO",AV5cFilCod,0)},c2v:function(){AV5cFilCod=GXgetIntegerValue("_CFILCODIGO")}};
_GXValidFnc[9]={lvl:0,grid:0,fnc:null,fld:"_CFILNOME",gxvar:"AV6cFilNom",op:[],ip:[],nacdep:[],v2v:function(Value){AV6cFilNom=Value},v2c:function(){GXsetControlValue("_CFILNOME",AV6cFilNom,0)},c2v:function(){AV6cFilNom=GXgetControlValue("_CFILNOME")}};
_GXValidFnc [ 11 ]={lvl: 2 ,grid: 13 ,pgrid: 0 ,fnc: null ,fld: "FILCODIGO" ,gxvar: "A28FilCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A28FilCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("FILCODIGO",GXCurrentRow[13],A28FilCodi,0) }, c2v:function(){ A28FilCodi=GXgetGridIntegerValue("FILCODIGO",GXCurrentRow[13]) }, nac:function(){return  null }};
_GXValidFnc [ 12 ]={lvl: 2 ,grid: 13 ,pgrid: 0 ,fnc: null ,fld: "FILNOME" ,gxvar: "A29FilNome" ,op:[  ],ip:[  ],v2v:function(Value){ A29FilNome=Value },v2c:function(){ GXsetGridControlValue("FILNOME",GXCurrentRow[13],A29FilNome,0) }, c2v:function(){ A29FilNome=GXgetGridControlValue("FILNOME",GXCurrentRow[13]) }, nac:function(){return  null }};
this.AV5cFilCod=0;
this.AV6cFilNom=0;
_SetStandaloneVars( ) ;
