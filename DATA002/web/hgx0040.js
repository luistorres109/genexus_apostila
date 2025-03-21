/*
               File: Gx0040
        Description: Selection List Cadastro de Estados
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:34.40
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
this._gx0040=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =12;
_GXValidFnc[7]={lvl:0,grid:0,fnc:null,fld:"_CESTCODIGO",gxvar:"AV5cEstCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV5cEstCod=gxint(Value)},v2c:function(){GXsetControlValue("_CESTCODIGO",AV5cEstCod,0)},c2v:function(){AV5cEstCod=GXgetIntegerValue("_CESTCODIGO")}};
_GXValidFnc[9]={lvl:0,grid:0,fnc:null,fld:"_CESTUF",gxvar:"AV6cEstUF",op:[],ip:[],nacdep:[],v2v:function(Value){AV6cEstUF=Value},v2c:function(){GXsetControlValue("_CESTUF",AV6cEstUF,0)},c2v:function(){AV6cEstUF=GXgetControlValue("_CESTUF")}};
_GXValidFnc [ 11 ]={lvl: 2 ,grid: 13 ,pgrid: 0 ,fnc: null ,fld: "ESTCODIGO" ,gxvar: "A23EstCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A23EstCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("ESTCODIGO",GXCurrentRow[13],A23EstCodi,0) }, c2v:function(){ A23EstCodi=GXgetGridIntegerValue("ESTCODIGO",GXCurrentRow[13]) }, nac:function(){return  null }};
_GXValidFnc [ 12 ]={lvl: 2 ,grid: 13 ,pgrid: 0 ,fnc: null ,fld: "ESTUF" ,gxvar: "A24EstUF" ,op:[  ],ip:[  ],v2v:function(Value){ A24EstUF=Value },v2c:function(){ GXsetGridControlValue("ESTUF",GXCurrentRow[13],A24EstUF,0) }, c2v:function(){ A24EstUF=GXgetGridControlValue("ESTUF",GXCurrentRow[13]) }, nac:function(){return  null }};
this.AV5cEstCod=0;
this.AV6cEstUF=0;
_SetStandaloneVars( ) ;
