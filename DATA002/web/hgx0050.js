/*
               File: Gx0050
        Description: Selection List Cadastro de Cidades
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:34.67
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
this._gx0050=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =12;
_GXValidFnc[7]={lvl:0,grid:0,fnc:null,fld:"_CCIDCODIGO",gxvar:"AV5cCidCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV5cCidCod=gxint(Value)},v2c:function(){GXsetControlValue("_CCIDCODIGO",AV5cCidCod,0)},c2v:function(){AV5cCidCod=GXgetIntegerValue("_CCIDCODIGO")}};
_GXValidFnc[9]={lvl:0,grid:0,fnc:null,fld:"_CESTCODIGO",gxvar:"AV6cEstCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV6cEstCod=gxint(Value)},v2c:function(){GXsetControlValue("_CESTCODIGO",AV6cEstCod,0)},c2v:function(){AV6cEstCod=GXgetIntegerValue("_CESTCODIGO")}};
_GXValidFnc [ 11 ]={lvl: 2 ,grid: 13 ,pgrid: 0 ,fnc: null ,fld: "CIDCODIGO" ,gxvar: "A26CidCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A26CidCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("CIDCODIGO",GXCurrentRow[13],A26CidCodi,0) }, c2v:function(){ A26CidCodi=GXgetGridIntegerValue("CIDCODIGO",GXCurrentRow[13]) }, nac:function(){return  null }};
_GXValidFnc [ 12 ]={lvl: 2 ,grid: 13 ,pgrid: 0 ,fnc: null ,fld: "ESTCODIGO" ,gxvar: "A23EstCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A23EstCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("ESTCODIGO",GXCurrentRow[13],A23EstCodi,0) }, c2v:function(){ A23EstCodi=GXgetGridIntegerValue("ESTCODIGO",GXCurrentRow[13]) }, nac:function(){return  null }};
this.AV5cCidCod=0;
this.AV6cEstCod=0;
_SetStandaloneVars( ) ;
