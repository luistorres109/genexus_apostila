/*
               File: Gx0010
        Description: Selection List Cadastro de Pessoas
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:33.62
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
this._gx0010=function()
{
}
this._init=function()
{
}
_GXValidFnc = new Array();
this._GXLastCtrlId =23;
_GXValidFnc[7]={lvl:0,grid:0,fnc:null,fld:"_CPESCODIGO",gxvar:"AV5cPesCod",op:[],ip:[],nacdep:[],v2v:function(Value){AV5cPesCod=gxint(Value)},v2c:function(){GXsetControlValue("_CPESCODIGO",AV5cPesCod,0)},c2v:function(){AV5cPesCod=GXgetIntegerValue("_CPESCODIGO")}};
_GXValidFnc[9]={lvl:0,grid:0,fnc:null,fld:"_CPESCPF",gxvar:"AV6cPesCPF",op:[],ip:[],nacdep:[],v2v:function(Value){AV6cPesCPF=Value},v2c:function(){GXsetControlValue("_CPESCPF",AV6cPesCPF,0)},c2v:function(){AV6cPesCPF=GXgetControlValue("_CPESCPF")}};
_GXValidFnc[11]={lvl:0,grid:0,fnc:null,fld:"_CPESDATNASC",gxvar:"AV7cPesDat",op:[],ip:[],nacdep:[],v2v:function(Value){AV7cPesDat=Value},v2c:function(){GXsetControlValue("_CPESDATNASC",AV7cPesDat,0)},c2v:function(){AV7cPesDat=GXgetControlValue("_CPESDATNASC")}};
_GXValidFnc[13]={lvl:0,grid:0,fnc:null,fld:"_CPESENDNUMERO",gxvar:"AV8cPesEnd",op:[],ip:[],nacdep:[],v2v:function(Value){AV8cPesEnd=Value},v2c:function(){GXsetControlValue("_CPESENDNUMERO",AV8cPesEnd,0)},c2v:function(){AV8cPesEnd=GXgetControlValue("_CPESENDNUMERO")}};
_GXValidFnc[15]={lvl:0,grid:0,fnc:null,fld:"_CPESTELEFONE",gxvar:"AV9cPesTel",op:[],ip:[],nacdep:[],v2v:function(Value){AV9cPesTel=Value},v2c:function(){GXsetControlValue("_CPESTELEFONE",AV9cPesTel,0)},c2v:function(){AV9cPesTel=GXgetControlValue("_CPESTELEFONE")}};
_GXValidFnc[17]={lvl:0,grid:0,fnc:null,fld:"_CPESCELULAR",gxvar:"AV10cPesCe",op:[],ip:[],nacdep:[],v2v:function(Value){AV10cPesCe=Value},v2c:function(){GXsetControlValue("_CPESCELULAR",AV10cPesCe,0)},c2v:function(){AV10cPesCe=GXgetControlValue("_CPESCELULAR")}};
_GXValidFnc[19]={lvl:0,grid:0,fnc:null,fld:"_CPESSITUACAO",gxvar:"AV11cPesSi",op:[],ip:[],nacdep:[],v2v:function(Value){AV11cPesSi=gxint(Value)},v2c:function(){GXsetComboBoxValue("_CPESSITUACAO",AV11cPesSi)},c2v:function(){AV11cPesSi=GXgetIntegerValue("_CPESSITUACAO")}};
_GXValidFnc [ 21 ]={lvl: 2 ,grid: 24 ,pgrid: 0 ,fnc: null ,fld: "PESCODIGO" ,gxvar: "A12PesCodi" ,op:[  ],ip:[  ],v2v:function(Value){ A12PesCodi=gxint(Value) },v2c:function(){ GXsetGridControlValue("PESCODIGO",GXCurrentRow[24],A12PesCodi,0) }, c2v:function(){ A12PesCodi=GXgetGridIntegerValue("PESCODIGO",GXCurrentRow[24]) }, nac:function(){return  null }};
_GXValidFnc [ 22 ]={lvl: 2 ,grid: 24 ,pgrid: 0 ,fnc: null ,fld: "PESCPF" ,gxvar: "A14PesCPF" ,op:[  ],ip:[  ],v2v:function(Value){ A14PesCPF=Value },v2c:function(){ GXsetGridControlValue("PESCPF",GXCurrentRow[24],A14PesCPF,0) }, c2v:function(){ A14PesCPF=GXgetGridControlValue("PESCPF",GXCurrentRow[24]) }, nac:function(){return  null }};
_GXValidFnc [ 23 ]={lvl: 2 ,grid: 24 ,pgrid: 0 ,fnc: null ,fld: "PESDATNASC" ,gxvar: "A15PesDatN" ,op:[  ],ip:[  ],v2v:function(Value){ A15PesDatN=Value },v2c:function(){ GXsetGridControlValue("PESDATNASC",GXCurrentRow[24],A15PesDatN,0) }, c2v:function(){ A15PesDatN=GXgetGridControlValue("PESDATNASC",GXCurrentRow[24]) }, nac:function(){return  null }};
this.AV5cPesCod=0;
this.AV6cPesCPF=0;
this.AV7cPesDat=0;
this.AV8cPesEnd=0;
this.AV9cPesTel=0;
this.AV10cPesCe=0;
this.AV11cPesSi=0;
_SetStandaloneVars( ) ;
