/*
               File: Gx0030
        Description: Selection List Cadastro de Categorias
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:34.14
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
this._gx0030=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =9;
_GXValidFnc[7]={lvl:0,grid:0,fnc:null,fld:"_CCATCODIGO",gxvar:"AV5cCatCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV5cCatCod=gxint(Value)},v2c:function(){GXsetControlValue("_CCATCODIGO",AV5cCatCod,0)},c2v:function(){AV5cCatCod=GXgetIntegerValue("_CCATCODIGO")}};
_GXValidFnc [ 9 ]={lvl: 2 ,grid: 10 ,pgrid: 0 ,fnc: null ,fld: "CATCODIGO" ,gxvar: "A33CatCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A33CatCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("CATCODIGO",GXCurrentRow[10],A33CatCodi,0) }, c2v:function(){ A33CatCodi=GXgetGridIntegerValue("CATCODIGO",GXCurrentRow[10]) }, nac:function(){return  null }};
this.AV5cCatCod=0;
_SetStandaloneVars( ) ;
