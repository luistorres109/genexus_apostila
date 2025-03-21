/*
               File: Gx0060
        Description: Selection List Cadastro de Mídias
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:35.3
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
this._gx0060=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =18;
_GXValidFnc[7]={lvl:0,grid:0,fnc:null,fld:"_CMIDCODIGO",gxvar:"AV5cMidCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV5cMidCod=gxint(Value)},v2c:function(){GXsetControlValue("_CMIDCODIGO",AV5cMidCod,0)},c2v:function(){AV5cMidCod=GXgetIntegerValue("_CMIDCODIGO")}};
_GXValidFnc[9]={lvl:0,grid:0,fnc:null,fld:"_CMIDTIPO",gxvar:"AV6cMidTip",op:[],ip:[],nacdep:[],v2v:function(Value){AV6cMidTip=gxint(Value)},v2c:function(){GXsetComboBoxValue("_CMIDTIPO",AV6cMidTip)},c2v:function(){AV6cMidTip=GXgetIntegerValue("_CMIDTIPO")}};
_GXValidFnc[11]={lvl:0,grid:0,fnc:null,fld:"_CMIDSITUACAO",gxvar:"AV7cMidSit",op:[],ip:[],nacdep:[],v2v:function(Value){AV7cMidSit=gxint(Value)},v2c:function(){GXsetComboBoxValue("_CMIDSITUACAO",AV7cMidSit)},c2v:function(){AV7cMidSit=GXgetIntegerValue("_CMIDSITUACAO")}};
_GXValidFnc[13]={lvl:0,grid:0,fnc:null,fld:"_CFILCODIGO",gxvar:"AV8cFilCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV8cFilCod=gxint(Value)},v2c:function(){GXsetControlValue("_CFILCODIGO",AV8cFilCod,0)},c2v:function(){AV8cFilCod=GXgetIntegerValue("_CFILCODIGO")}};
_GXValidFnc [ 15 ]={lvl: 2 ,grid: 19 ,pgrid: 0 ,fnc: null ,fld: "MIDCODIGO" ,gxvar: "A37MidCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A37MidCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("MIDCODIGO",GXCurrentRow[19],A37MidCodi,0) }, c2v:function(){ A37MidCodi=GXgetGridIntegerValue("MIDCODIGO",GXCurrentRow[19]) }, nac:function(){return  null }};
_GXValidFnc [ 16 ]={lvl: 2 ,grid: 19 ,pgrid: 0 ,fnc: null ,fld: "MIDTIPO" ,gxvar: "A35MidTipo" ,op:[  ],ip:[  ],v2v:function(Value){ A35MidTipo=gxint(Value) },v2c:function(){ GXsetGridComboBoxValue("MIDTIPO",GXCurrentRow[19],A35MidTipo) }, c2v:function(){ A35MidTipo=GXgetGridIntegerValue("MIDTIPO",GXCurrentRow[19]) }, nac:function(){return  null }};
_GXValidFnc [ 17 ]={lvl: 2 ,grid: 19 ,pgrid: 0 ,fnc: null ,fld: "MIDSITUACAO" ,gxvar: "A36MidSitu" ,op:[  ],ip:[  ],v2v:function(Value){ A36MidSitu=gxint(Value) },v2c:function(){ GXsetGridComboBoxValue("MIDSITUACAO",GXCurrentRow[19],A36MidSitu) }, c2v:function(){ A36MidSitu=GXgetGridIntegerValue("MIDSITUACAO",GXCurrentRow[19]) }, nac:function(){return  null }};
_GXValidFnc [ 18 ]={lvl: 2 ,grid: 19 ,pgrid: 0 ,fnc: null ,fld: "FILCODIGO" ,gxvar: "A28FilCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A28FilCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("FILCODIGO",GXCurrentRow[19],A28FilCodi,0) }, c2v:function(){ A28FilCodi=GXgetGridIntegerValue("FILCODIGO",GXCurrentRow[19]) }, nac:function(){return  null }};
this.AV5cMidCod=0;
this.AV6cMidTip=0;
this.AV7cMidSit=0;
this.AV8cFilCod=0;
_SetStandaloneVars( ) ;
