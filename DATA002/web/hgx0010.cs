/*
               File: Gx0010
        Description: Selection List Cadastro de Pessoas
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:33.18
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class hgx0010 : GXHttpHandler
   {
      public hgx0010( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public hgx0010( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pPesCodigo )
      {
         this.AV12pPesCo = 0 ;
         executePrivate();
         aP0_pPesCodigo=this.AV12pPesCo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCpessituacao = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initpars( ) ;
         gxajaxcallmode = 0 ;
         if ( ( nGotPars == 0 ) )
         {
            gxfirstwebparm = GetNextPar( ) ;
            AV12pPesCo = (int)(NumberUtil.Val( gxfirstwebparm, "")) ;
         }
      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
         INITWEB( ) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            PA072( ) ;
            if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS072( ) ;
               if ( ( gxajaxcallmode == 0 ) )
               {
                  WE072( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         wbTemp = context.ResponseContentType( "text/html") ;
         wbTemp = context.SetHeader( "pragma", "no-cache") ;
         WriteHtmlTextNl( "<html>") ;
         WriteHtmlTextNl( "<head>") ;
         idxLst = 1 ;
         while ( ( idxLst <= Form.Meta.ItemCount ) )
         {
            WriteHtmlText( "<meta name=\""+StringUtil.RTrim( Form.Meta.getItemValue((short)(idxLst)))+"\" content=\"") ;
            SendWebValue( StringUtil.RTrim( Form.Meta.getItemText((short)(idxLst)))) ;
            WriteHtmlTextNl( "\"/>") ;
            idxLst = (int)(idxLst+1) ;
         }
         WriteHtmlTextNl( "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=EmulateIE7\"/>") ;
         idxLst = 1 ;
         addContentType = true ;
         while ( ( idxLst <= Form.Metaequiv.ItemCount ) )
         {
            if ( ( String.CompareOrdinal(StringUtil.Lower( Form.Metaequiv.getItemValue((short)(idxLst))).TrimEnd(' '), "content-type".TrimEnd(' ') ) == 0 ) )
            {
               addContentType = false ;
               wbTemp = context.ResponseContentType( Form.Metaequiv.getItemText((short)(idxLst))) ;
            }
            idxLst = (int)(idxLst+1) ;
         }
         if ( addContentType )
         {
            WriteHtmlTextNl( "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"/>") ;
         }
         idxLst = 1 ;
         while ( ( idxLst <= Form.Metaequiv.ItemCount ) )
         {
            WriteHtmlText( "<meta http-equiv=\""+StringUtil.RTrim( Form.Metaequiv.getItemValue((short)(idxLst)))+"\" content=\"") ;
            SendWebValue( StringUtil.RTrim( Form.Metaequiv.getItemText((short)(idxLst)))) ;
            WriteHtmlTextNl( "\"/>") ;
            idxLst = (int)(idxLst+1) ;
         }
      }

      protected void RenderHtmlOpenForm( )
      {
         WriteHtmlText( "<title>") ;
         WriteHtmlText( "Selection List Cadastro de Pessoas") ;
         WriteHtmlTextNl( "</title>") ;
         if ( ( StringUtil.Len( sDynURL) > 0 ) )
         {
            WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxtypes.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxballoon.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxfwddcl.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxfrmutl.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxcallrpc.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxautosuggest.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "setevent.js")+"\"></script>") ;
         WriteHtmlText( "") ;
         WriteHtmlTextNl( "</head>") ;
         FormProcess = (true ? " onload=\"gxonload();"+"\""+" onkeyup=\"form_onkeyup(event)\" onkeypress=\"form_onkeypress(event,true,false)\" onkeydown=\"form_onkeypress(null,true,false)\"" : "") ;
         WriteHtmlText( "<body") ;
         if ( ! ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( "").TrimEnd(' ') )==0)) ) )
         {
            WriteHtmlText( " background=\""+convertURL( "")+"\"") ;
         }
         WriteHtmlText( " "+"class"+" "+" bgcolor=\""+context.BuildHTMLColor( (int)(0xFFFFFF))+"\""+FormProcess+">") ;
         skipLines(1);
         WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return GXValidForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" ACTION=\""+formatLink("hgx0010.aspx") + "?" + UrlEncode("" +AV12pPesCo)+"\""+">") ;
         gx_hidden_field( "_EventName", "");
         gx_hidden_field( "_EventGridId", "");
         gx_hidden_field( "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm072( )
      {
         /* Send hidden variables. */
         gx_hidden_field( "GXH__CPESCODIGO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5cPesCod), 9, 0, ".", "")));
         gx_hidden_field( "GXH__CPESCPF", StringUtil.RTrim( AV6cPesCPF));
         gx_hidden_field( "GXH__CPESDATNASC", StringUtil.Format(AV7cPesDat, "99/99/99"));
         gx_hidden_field( "GXH__CPESENDNUMERO", StringUtil.RTrim( AV8cPesEnd));
         gx_hidden_field( "GXH__CPESTELEFONE", StringUtil.RTrim( AV9cPesTel));
         gx_hidden_field( "GXH__CPESCELULAR", StringUtil.RTrim( AV10cPesCe));
         gx_hidden_field( "GXH__CPESSITUACAO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cPesSi), 1, 0, ".", "")));
         /* Send saved values. */
         gx_hidden_field( "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         gx_hidden_field( "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         gx_hidden_field( "Grid1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(Grid1_nFirstRecordOnPage), 6, 0, ".", "")));
         gx_hidden_field( "Grid1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(Grid1_nEOF), 1, 0, ".", "")));
         WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         WriteHtmlTextNl( "</body>") ;
         WriteHtmlTextNl( "</html>") ;
      }

      protected void WB070( )
      {
         if ( ( wbLoad == false ) )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            WriteHtmlText( "<BODY>") ;
            wb_table1_3_072( true) ;
         }
         else
         {
            wb_table1_3_072( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_072e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</BODY>") ;
         }
         wbLoad = true ;
      }

      protected void START072( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         wbTemp = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "9_0_7-910", 0) ;
         Form.Meta.addItem("Description", "Selection List Cadastro de Pessoas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( ( String.CompareOrdinal(context.GetRequestMethod( ).TrimEnd(' '), "POST".TrimEnd(' ') ) == 0 ) )
         {
            context.sCallerURL = cgiGet( "sCallerURL") ;
         }
         else
         {
            context.sCallerURL = context.GetReferer( ) ;
         }
         wbErr = false ;
         STRUP070( ) ;
      }

      protected void WS072( )
      {
         START072( ) ;
         EVT072( ) ;
      }

      protected void EVT072( )
      {
         if ( ( String.CompareOrdinal(context.GetRequestMethod( ).TrimEnd(' '), "POST".TrimEnd(' ') ) == 0 ) )
         {
            if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( context.wjLoc).TrimEnd(' ') )==0)) && ( context.nUserReturn != 1 ) && ( wbErr == false ) )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( ( StringUtil.Len( sEvt) > 0 ) )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( ( NumberUtil.CToN( cgiGet( "GXH__CPESCODIGO"), "", "") != Convert.ToDecimal( AV5cPesCod )) )
                  {
                     Grid1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( String.CompareOrdinal(cgiGet( "GXH__CPESCPF").TrimEnd(' '), AV6cPesCPF.TrimEnd(' ') ) != 0 ) )
                  {
                     Grid1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( DateTimeUtil.CToD( cgiGet( "GXH__CPESDATNASC"), 1) != AV7cPesDat ) )
                  {
                     Grid1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( String.CompareOrdinal(cgiGet( "GXH__CPESENDNUMERO").TrimEnd(' '), AV8cPesEnd.TrimEnd(' ') ) != 0 ) )
                  {
                     Grid1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( String.CompareOrdinal(cgiGet( "GXH__CPESTELEFONE").TrimEnd(' '), AV9cPesTel.TrimEnd(' ') ) != 0 ) )
                  {
                     Grid1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( String.CompareOrdinal(cgiGet( "GXH__CPESCELULAR").TrimEnd(' '), AV10cPesCe.TrimEnd(' ') ) != 0 ) )
                  {
                     Grid1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( NumberUtil.CToN( cgiGet( "GXH__CPESSITUACAO"), "", "") != Convert.ToDecimal( AV11cPesSi )) )
                  {
                     Grid1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( String.CompareOrdinal(sEvtType.TrimEnd(' '), "E".TrimEnd(' ') ) == 0 ) )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( ( String.CompareOrdinal(sEvtType.TrimEnd(' '), ".".TrimEnd(' ') ) == 0 ) )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "RFR".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "REFRESH".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "'GXM_FIRST'".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11072 */
                           E11072 ();
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "'GXM_PREVIOUS'".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12072 */
                           E12072 ();
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "'GXM_NEXT'".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E13072 */
                           E13072 ();
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "'GXM_LAST'".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E14072 */
                           E14072 ();
                           /* No code required for Help button. It is implemented at the Browser level. */
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void WE072( )
      {
         if ( ( context.nUserReturn == 1 ) )
         {
            if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( context.sCallerURL).TrimEnd(' ') )==0)) )
            {
               WriteHtmlText( "<html><head><title>Close window</title></head><body><script language=\"JavaScript\" type=\"text/javascript\">self.close();</script></body></html>") ;
            }
            else
            {
               context.Redirect( context.sCallerURL );
            }
         }
         else if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( context.wjLoc).TrimEnd(' ') )==0)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "" ;
         }
         else
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ( context.nUserReturn == 1 ) )
            {
               if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( context.sCallerURL).TrimEnd(' ') )==0)) )
               {
                  WriteHtmlText( "<html><head><title>Close window</title></head><body><script language=\"JavaScript\" type=\"text/javascript\">self.close();</script></body></html>") ;
               }
               else
               {
                  context.Redirect( context.sCallerURL );
               }
            }
            else if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( context.wjLoc).TrimEnd(' ') )==0)) )
            {
               context.Redirect( context.wjLoc );
               context.wjLoc = "" ;
            }
            else
            {
               RenderHtmlCloseForm072( ) ;
            }
         }
      }

      protected void PA072( )
      {
         if ( ( nDonePA == 0 ) )
         {
            lblTextblock1_Name = "Textblock1" ;
            lblTextblock2_Name = "Textblock2" ;
            lblTextblock3_Name = "Textblock3" ;
            lblTextblock4_Name = "Textblock4" ;
            lblTextblock5_Name = "Textblock5" ;
            lblTextblock6_Name = "Textblock6" ;
            lblTextblock7_Name = "Textblock7" ;
            cmbavCpessituacao.Name = "_CPESSITUACAO" ;
            cmbavCpessituacao.Height = 1 ;
            cmbavCpessituacao.WebTags = "" ;
            cmbavCpessituacao.addItem(StringUtil.Str( (decimal)(1), 1, 0), "Ativo", 0);
            cmbavCpessituacao.addItem(StringUtil.Str( (decimal)(2), 1, 0), "Inativo", 0);
            initialize_properties( ) ;
            GX_FocusControl = edtavCpescodigo_Internalname ;
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void sendrow_242( )
      {
         WB070( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_24_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            if ( ( subGrid1_Backcolorstyle == 0 ) )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
            }
            else if ( ( subGrid1_Backcolorstyle == 1 ) )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
            }
            else if ( ( subGrid1_Backcolorstyle == 2 ) )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               subGrid1_Backcolor = (int)(0xFFFFFF) ;
            }
            else if ( ( subGrid1_Backcolorstyle == 3 ) )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ( 1 <= 0 ) )
               {
                  subGrid1_Backcolor = (int)(0xFFFFFF) ;
               }
               else if ( ( 1 == 1 ) )
               {
                  if ( ( ((int)(nGXsfl_24_idx) % (2)) == 0 ) )
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
                  else
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
               }
               else
               {
                  if ( ( ((int)(nGXsfl_24_idx/ (decimal)(1)) % (2)) - 1 == 0 ) )
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
                  else
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
               }
            }
            sClassString = "S1" ;
            sStyleString = ((subGrid1_Backcolorstyle==0) ? "background:transparent;" : "") + "" ;
            WriteHtmlText( "<tr") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( sClassString) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            /* Subfile cell */
            sStyleString = ((1==0) ? "display:none;" : "") ;
            WriteHtmlText( "<td valign=top align=\""+"RIGHT"+"\"") ;
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            /* Single line edit */
            ClassString = "S2" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") + "" ;
            ROClassString = ClassString ;
            edtPesCodigo_Link = "javascript:GX_js_return"+"("+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A12PesCodi), 9, 0, ".", "")))+"')" ;
            gx_single_line_edit2( edtPesCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12PesCodi), 9, 0, ".", "")), 18, 9, 1, 0, 0, 0, 0, 0, edtPesCodigo_Link, "", StyleString, ClassString, ROClassString, StringUtil.Format( (decimal)(A12PesCodi), "ZZZZZZZZ9"), "", 0, edtPesCodigo_Jsonclick, "", 24, 0, 1, "'HLP_HGx0010.htm'");
            WriteHtmlTextNl( "</td>") ;
            /* Subfile cell */
            sStyleString = ((1==0) ? "display:none;" : "") ;
            WriteHtmlText( "<td valign=top align=\""+"LEFT"+"\"") ;
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            /* Single line edit */
            ClassString = "S2" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") + "" ;
            ROClassString = ClassString ;
            gx_single_line_edit2( edtPesCPF_Internalname, StringUtil.RTrim( A14PesCPF), 15, 14, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, ROClassString, StringUtil.RTrim( StringUtil.Format( A14PesCPF, "999.999.999-99")), "", 0, edtPesCPF_Jsonclick, "", 24, 0, 1, "'HLP_HGx0010.htm'");
            WriteHtmlTextNl( "</td>") ;
            /* Subfile cell */
            sStyleString = ((1==0) ? "display:none;" : "") ;
            WriteHtmlText( "<td valign=top align=\""+"LEFT"+"\"") ;
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            /* Single line edit */
            ClassString = "S2" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") + "" ;
            ROClassString = ClassString ;
            if ( ( 0 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
            {
               WriteHtmlText( "<table id=\""+edtPesDatNasc_Internalname+"_dp_container\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>") ;
            }
            gx_single_line_edit2( edtPesDatNasc_Internalname, StringUtil.Format(A15PesDatN, "99/99/99"), 31, 8, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, ROClassString, StringUtil.Format( A15PesDatN, "99/99/99"), "", 0, edtPesDatNasc_Jsonclick, "", 24, 0, 1, "'HLP_HGx0010.htm'");
            if ( ( 0 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
            {
               WriteHtmlTextNl( "</td><td>") ;
               WriteHtmlText( "<img src=\""+convertURL( "calendar-img.gif")+"\" id=\""+edtPesDatNasc_Internalname+"_dp_trigger\" style=\"cursor: pointer;\" title=\"Date selector\" onmouseover=\"this.style.background='red';\" onmouseout=\"this.style.background=''\"/>") ;
               WriteHtmlTextNl( "</td></tr></table>") ;
               if ( ( gxCalCtrlInc == 0 ) )
               {
                  gxCalCtrlInc = 1 ;
                  WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "calendar.js")+"\"></script>") ;
                  WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "calendar-setup.js")+"\"></script>") ;
                  WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "calendar-en.js")+"\"></script>") ;
               }
               WriteHtmlTextNl( "<script language=\"JavaScript\" type=\"text/javascript\">") ;
               WriteHtmlTextNl( "document.write('<link rel=\"stylesheet\" type=\"text/css\" href=\""+convertURL( "calendar-system.css")+"\" title=\"calendar-css\">');") ;
               WriteHtmlText( "Calendar.setup( {inputField:\""+edtPesDatNasc_Internalname+"\""+",showsTime: false "+",weekNumbers: false "+",mondayFirst: false "+",ifFormat:\""+"%m/%d/%y"+"\",") ;
               WriteHtmlText( "button:\""+edtPesDatNasc_Internalname+"_dp_trigger\""+",onSelect: dateChanged_"+edtPesDatNasc_Internalname+",") ;
               WriteHtmlTextNl( "align:\"Bl\",singleClick:true});") ;
               WriteHtmlText( "function dateChanged_"+edtPesDatNasc_Internalname+"(calendar, date) { if (calendar && calendar.dateClicked){") ;
               if ( ( 0 == 1 ) )
               {
                  WriteHtmlText( " document.getElementById(\""+edtPesDatNasc_Internalname+"\").value"+"="+"calendar.date.print(\""+"%m/%d/%y"+"\");"+"calendar.callCloseHandler();") ;
               }
               else
               {
                  WriteHtmlText( "calendar.parseDate("+" document.forms[0]."+edtPesDatNasc_Internalname+".value);"+"calendar.callCloseHandler();") ;
               }
               WriteHtmlText( "}}") ;
               GXCCtl = "PESDATNASC_" + sGXsfl_24_idx ;
               WriteHtmlTextNl( "</script>") ;
            }
            WriteHtmlTextNl( "</td>") ;
            WriteHtmlTextNl( "</tr>") ;
            nGXsfl_24_idx = (short)(nGXsfl_24_idx+1) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtPesCodigo_Internalname = "PESCODIGO_"+sGXsfl_24_idx ;
            edtPesCPF_Internalname = "PESCPF_"+sGXsfl_24_idx ;
            edtPesDatNasc_Internalname = "PESDATNASC_"+sGXsfl_24_idx ;
         }
         /* End function sendrow_242 */
      }

      protected void Refresh( )
      {
         RF072( ) ;
         /* End function Refresh */
      }

      protected void RF072( )
      {
         wbStart = 24 ;
         nGXsfl_24_idx = 1 ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtPesCodigo_Internalname = "PESCODIGO_"+sGXsfl_24_idx ;
         edtPesCPF_Internalname = "PESCPF_"+sGXsfl_24_idx ;
         edtPesDatNasc_Internalname = "PESDATNASC_"+sGXsfl_24_idx ;
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( context.wjLoc).TrimEnd(' ') )==0)) && ( context.nUserReturn != 1 ) )
         {
            lV6cPesCPF = StringUtil.PadR( StringUtil.RTrim( AV6cPesCPF), 14, "%") ;
            lV8cPesEnd = StringUtil.PadR( StringUtil.RTrim( AV8cPesEnd), 20, "%") ;
            lV9cPesTel = StringUtil.PadR( StringUtil.RTrim( AV9cPesTel), 14, "%") ;
            lV10cPesCe = StringUtil.PadR( StringUtil.RTrim( AV10cPesCe), 14, "%") ;
            /* Using cursor H00072 */
            pr_default.execute(0, new Object[] {AV5cPesCod, lV6cPesCPF, AV7cPesDat, lV8cPesEnd, lV9cPesTel, lV10cPesCe, AV11cPesSi});
            nGXsfl_24_idx = 1 ;
            Grid1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( nGXsfl_24_idx <= subGrid1_Recordsperpage( ) ) ) ) )
            {
               A17PesEndN = H00072_A17PesEndN[0] ;
               n17PesEndN = H00072_n17PesEndN[0] ;
               A20PesTele = H00072_A20PesTele[0] ;
               n20PesTele = H00072_n20PesTele[0] ;
               A21PesCelu = H00072_A21PesCelu[0] ;
               n21PesCelu = H00072_n21PesCelu[0] ;
               A22PesSitu = H00072_A22PesSitu[0] ;
               n22PesSitu = H00072_n22PesSitu[0] ;
               A15PesDatN = H00072_A15PesDatN[0] ;
               n15PesDatN = H00072_n15PesDatN[0] ;
               A14PesCPF = H00072_A14PesCPF[0] ;
               n14PesCPF = H00072_n14PesCPF[0] ;
               A12PesCodi = H00072_A12PesCodi[0] ;
               /* Execute user event: E15072 */
               E15072 ();
               pr_default.readNext(0);
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               Grid1_nEOF = 1 ;
            }
            pr_default.close(0);
            wbEnd = 24 ;
            WB070( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         Grid1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( ((int)(Grid1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 ) )
         {
            return (int)(NumberUtil.Int( (long)(Grid1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(Grid1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV6cPesCPF = StringUtil.PadR( StringUtil.RTrim( AV6cPesCPF), 14, "%") ;
         lV8cPesEnd = StringUtil.PadR( StringUtil.RTrim( AV8cPesEnd), 20, "%") ;
         lV9cPesTel = StringUtil.PadR( StringUtil.RTrim( AV9cPesTel), 14, "%") ;
         lV10cPesCe = StringUtil.PadR( StringUtil.RTrim( AV10cPesCe), 14, "%") ;
         /* Using cursor H00073 */
         pr_default.execute(1, new Object[] {AV5cPesCod, lV6cPesCPF, AV7cPesDat, lV8cPesEnd, lV9cPesTel, lV10cPesCe, AV11cPesSi});
         Grid1_nRecordCount = H00073_AGrid1_nRe[0] ;
         pr_default.close(1);
         return Grid1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( ( 10 > 0 ) )
         {
            if ( ( 1 > 0 ) )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected short subgrid1_firstpage( )
      {
         Grid1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         if ( ( nRC_Grid1 >= subGrid1_Recordsperpage( ) ) && ( Grid1_nEOF == 0 ) )
         {
            Grid1_nFirstRecordOnPage = (int)(Grid1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( ( Grid1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) ) )
         {
            Grid1_nFirstRecordOnPage = (int)(Grid1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         Grid1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( Grid1_nRecordCount > subGrid1_Recordsperpage( ) ) )
         {
            if ( ( ((int)(Grid1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 ) )
            {
               Grid1_nFirstRecordOnPage = (int)(Grid1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               Grid1_nFirstRecordOnPage = (int)(Grid1_nRecordCount-((int)(Grid1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            Grid1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected void STRUP070( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( ( String.CompareOrdinal(context.GetRequestMethod( ).TrimEnd(' '), "POST".TrimEnd(' ') ) == 0 ) )
         {
            /* Read saved values. */
            nRC_Grid1 = (short)(NumberUtil.CToN( cgiGet( "nRC_Grid1"), "", "")) ;
            context.sCallerURL = GXUtil.ValueDecode( cgiGet( "sCallerURL")) ;
            Grid1_nFirstRecordOnPage = (int)(NumberUtil.CToN( cgiGet( "Grid1_nFirstRecordOnPage"), "", "")) ;
            Grid1_nEOF = (short)(NumberUtil.CToN( cgiGet( "Grid1_nEOF"), "", "")) ;
            /* Read subfile selected row values. */
            /* Read variables values. */
            if ( ( ( NumberUtil.CToN( cgiGet( edtavCpescodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtavCpescodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
               GX_FocusControl = edtavCpescodigo_Internalname ;
               wbErr = true ;
               AV5cPesCod = (int)(0M) ;
            }
            else
            {
               AV5cPesCod = (int)(NumberUtil.CToN( cgiGet( edtavCpescodigo_Internalname), "", "")) ;
            }
            AV6cPesCPF = cgiGet( edtavCpescpf_Internalname) ;
            if ( ( DateTimeUtil.VCDate( cgiGet( edtavCpesdatnasc_Internalname), 1) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("faildate", new   object[]  {"Data de Nascimento da Pessoa"}), 1);
               GX_FocusControl = edtavCpesdatnasc_Internalname ;
               wbErr = true ;
               AV7cPesDat = (DateTime)(DateTime.MinValue) ;
            }
            else
            {
               AV7cPesDat = DateTimeUtil.CToD( cgiGet( edtavCpesdatnasc_Internalname), 1) ;
            }
            AV8cPesEnd = cgiGet( edtavCpesendnumero_Internalname) ;
            AV9cPesTel = cgiGet( edtavCpestelefone_Internalname) ;
            AV10cPesCe = cgiGet( edtavCpescelular_Internalname) ;
            cmbavCpessituacao.Name = cmbavCpessituacao_Internalname ;
            cmbavCpessituacao.CurrentValue = cgiGet( cmbavCpessituacao_Internalname) ;
            AV11cPesSi = (short)(NumberUtil.Val( cgiGet( cmbavCpessituacao_Internalname), ".")) ;
            /* Read hidden variables. */
            /* Read hidden properties. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E16072 */
         E16072 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E16072( )
      {
         /* Enter Routine */
         AV12pPesCo = A12PesCodi ;
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void E11072( )
      {
         /* 'GXM_first' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E12072( )
      {
         /* 'GXM_previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E13072( )
      {
         /* 'GXM_next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E14072( )
      {
         /* 'GXM_last' Routine */
         subgrid1_lastpage( ) ;
      }

      private void E15072( )
      {
         /* Load Routine */
         if ( ( 10 == 0 ) || ( ( Grid1_nCurrentRecord >= Grid1_nFirstRecordOnPage ) && ( Grid1_nCurrentRecord < Grid1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_242( ) ;
         }
         Grid1_nCurrentRecord = (int)(Grid1_nCurrentRecord+1) ;
      }

      protected void wb_table1_3_072( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            /* Table start */
            WriteHtmlText( "<table") ;
            if ( ! ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( tblTable1_Internalname).TrimEnd(' ') )==0)) ) )
            {
               WriteHtmlText( " id=\""+tblTable1_Internalname+"\"") ;
            }
            sStyleString = "" ;
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               sStyleString = sStyleString + "BACKGROUND-IMAGE: url(" + convertURL( "") + ");" ;
            }
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " title=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            WriteHtmlText( " cellpadding=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(1), 10, 0))) ;
            WriteHtmlText( "\"") ;
            WriteHtmlText( " cellspacing=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(2), 10, 0))) ;
            WriteHtmlText( "\"") ;
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) && ( String.CompareOrdinal("".TrimEnd(' '), "none".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " rules=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD colspan=2>") ;
            ClassString = "S3" ;
            StyleString = "" + "" ;
            gx_msg_list2( "", context.GX_msglist.DisplayMode, StyleString, ClassString, false);
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD colspan=2>") ;
            wb_table2_5_072( true) ;
         }
         else
         {
            wb_table2_5_072( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_072e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "26" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_first_Internalname, "|<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_first_Jsonclick, "E\\'GXM_FIRST\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(24), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)+");", "", "'HLP_HGx0010.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "27" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_previous_Internalname, "<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_previous_Jsonclick, "E\\'GXM_PREVIOUS\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(24), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)+");", "", "'HLP_HGx0010.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "28" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_next_Internalname, ">", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_next_Jsonclick, "E\\'GXM_NEXT\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(24), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)+");", "", "'HLP_HGx0010.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "29" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_last_Internalname, ">|", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_last_Jsonclick, "E\\'GXM_LAST\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(24), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)+");", "", "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD align=right>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "30" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_cancel_Internalname, "Close", "", "", StyleString, ClassString, 1, 1, 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(24), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)+");", "", "'HLP_HGx0010.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "31" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_help_Internalname, "Help", "", "", StyleString, ClassString, 1, 1, 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(24), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)+");", "", "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table1_3_072e( true) ;
         }
         else
         {
            wb_table1_3_072e( false) ;
         }
      }

      protected void wb_table2_5_072( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            /* Table start */
            WriteHtmlText( "<table") ;
            if ( ! ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( tblTable2_Internalname).TrimEnd(' ') )==0)) ) )
            {
               WriteHtmlText( " id=\""+tblTable2_Internalname+"\"") ;
            }
            sStyleString = "" ;
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               sStyleString = sStyleString + "BACKGROUND-IMAGE: url(" + convertURL( "") + ");" ;
            }
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " title=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            WriteHtmlText( " cellpadding=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(1), 10, 0))) ;
            WriteHtmlText( "\"") ;
            WriteHtmlText( " cellspacing=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(2), 10, 0))) ;
            WriteHtmlText( "\"") ;
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) && ( String.CompareOrdinal("".TrimEnd(' '), "none".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " rules=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock1_Internalname, 1, 1, 0, "Codigo da Pessoa", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_24_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "7" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtavCpescodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5cPesCod), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(AV5cPesCod), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(7);\"", 0, edtavCpescodigo_Jsonclick, "", 0, 0, 1, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock2_Internalname, 1, 1, 0, "CPF da Pessoa", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_24_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "9" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtavCpescpf_Internalname, StringUtil.RTrim( AV6cPesCPF), 14, 14, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( AV6cPesCPF, "999.999.999-99")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(9);\"", 0, edtavCpescpf_Jsonclick, "", 0, 0, 1, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock3_Internalname, 1, 1, 0, "Data de Nascimento da Pessoa", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_24_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "11" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            if ( ( 1 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
            {
               WriteHtmlText( "<table id=\""+edtavCpesdatnasc_Internalname+"_dp_container\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>") ;
            }
            gx_single_line_edit2( edtavCpesdatnasc_Internalname, StringUtil.Format(AV7cPesDat, "99/99/99"), 8, 8, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( AV7cPesDat, "99/99/99"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"gxvdate( this, 8,0,0,1,'eng',false,0);;GXOnBlur(11);\"", 0, edtavCpesdatnasc_Jsonclick, "", 0, 0, 1, "'HLP_HGx0010.htm'");
            if ( ( 1 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
            {
               WriteHtmlTextNl( "</td><td>") ;
               WriteHtmlText( "<img src=\""+convertURL( "calendar-img.gif")+"\" id=\""+edtavCpesdatnasc_Internalname+"_dp_trigger\" style=\"cursor: pointer;\" title=\"Date selector\" onmouseover=\"this.style.background='red';\" onmouseout=\"this.style.background=''\"/>") ;
               WriteHtmlTextNl( "</td></tr></table>") ;
               if ( ( gxCalCtrlInc == 0 ) )
               {
                  gxCalCtrlInc = 1 ;
                  WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "calendar.js")+"\"></script>") ;
                  WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "calendar-setup.js")+"\"></script>") ;
                  WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "calendar-en.js")+"\"></script>") ;
               }
               WriteHtmlTextNl( "<script language=\"JavaScript\" type=\"text/javascript\">") ;
               WriteHtmlTextNl( "document.write('<link rel=\"stylesheet\" type=\"text/css\" href=\""+convertURL( "calendar-system.css")+"\" title=\"calendar-css\">');") ;
               WriteHtmlText( "Calendar.setup( {inputField:\""+edtavCpesdatnasc_Internalname+"\""+",showsTime: false "+",weekNumbers: false "+",mondayFirst: false "+",ifFormat:\""+"%m/%d/%y"+"\",") ;
               WriteHtmlText( "button:\""+edtavCpesdatnasc_Internalname+"_dp_trigger\""+",onSelect: dateChanged_"+edtavCpesdatnasc_Internalname+",") ;
               WriteHtmlTextNl( "align:\"Bl\",singleClick:true});") ;
               WriteHtmlText( "function dateChanged_"+edtavCpesdatnasc_Internalname+"(calendar, date) { if (calendar && calendar.dateClicked){") ;
               if ( ( 1 == 1 ) )
               {
                  WriteHtmlText( " document.getElementById(\""+edtavCpesdatnasc_Internalname+"\").value"+"="+"calendar.date.print(\""+"%m/%d/%y"+"\");"+"calendar.callCloseHandler();") ;
               }
               else
               {
                  WriteHtmlText( "calendar.parseDate("+" document.forms[0]."+edtavCpesdatnasc_Internalname+".value);"+"calendar.callCloseHandler();") ;
               }
               WriteHtmlText( "}}") ;
               WriteHtmlTextNl( "</script>") ;
            }
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock4_Internalname, 1, 1, 0, "Número do Endereço da Pessoa", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_24_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "13" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtavCpesendnumero_Internalname, StringUtil.RTrim( AV8cPesEnd), 20, 20, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( AV8cPesEnd, "")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(13);\"", 0, edtavCpesendnumero_Jsonclick, "", 0, 0, 1, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock5_Internalname, 1, 1, 0, "Telefone Residencial da Pessoa", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_24_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "15" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtavCpestelefone_Internalname, StringUtil.RTrim( AV9cPesTel), 15, 15, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( AV9cPesTel, "(99) 9999-9999")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(15);\"", 0, edtavCpestelefone_Jsonclick, "", 0, 0, 1, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock6_Internalname, 1, 1, 0, "Telefone Celular da Pessoa", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_24_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "17" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtavCpescelular_Internalname, StringUtil.RTrim( AV10cPesCe), 15, 15, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( AV10cPesCe, "(99) 9999-9999")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(17);\"", 0, edtavCpescelular_Jsonclick, "", 0, 0, 1, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock7_Internalname, 1, 1, 0, "Situação da Pessoa", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_24_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "19" + "," + "''" + "," + "24" + ")\"" ;
            cmbavCpessituacao.CurrentValue = StringUtil.Str( (decimal)(AV11cPesSi), 1, 0) ;
            /* ComboBox */
            gx_combobox_ctrl( cmbavCpessituacao, cmbavCpessituacao_Internalname, StringUtil.Str( (decimal)(AV11cPesSi), 1, 0), "int", 1, 1, 1, 2, StyleString, ClassString, "", 0, cmbavCpessituacao_Jsonclick, "", TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(19);\"", "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD align=right>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "20" + "," + "''" + "," + "24" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_refresh_Internalname, "Search", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_refresh_Jsonclick, "EREFRESH.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(24), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)+");", "", "'HLP_HGx0010.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD colspan=3>") ;
         }
         if ( ( wbStart == 24 ) )
         {
            wbStart = -1 ;
            /* Subfile start */
            if ( ( subGrid1_Backcolorstyle == 0 ) )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
            }
            else if ( ( subGrid1_Backcolorstyle == 1 ) )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
            }
            else if ( ( subGrid1_Backcolorstyle == 2 ) )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               subGrid1_Backcolor = (int)(0xFFFFFF) ;
            }
            else if ( ( subGrid1_Backcolorstyle == 3 ) )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ( 1 <= 0 ) )
               {
                  subGrid1_Backcolor = (int)(0xFFFFFF) ;
               }
               else if ( ( 1 == 1 ) )
               {
                  if ( ( ((int)(nGXsfl_24_idx) % (2)) == 0 ) )
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
                  else
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
               }
               else
               {
                  if ( ( ((int)(nGXsfl_24_idx/ (decimal)(1)) % (2)) - 1 == 0 ) )
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
                  else
                  {
                     subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  }
               }
            }
            WriteHtmlText( "<table id=\""+subGrid1_Internalname+"\"") ;
            sStyleString = "" ;
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               sStyleString = sStyleString + "BACKGROUND-IMAGE: url(" + convertURL( "") + ");" ;
            }
            if ( ( String.CompareOrdinal("".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " title=\"") ;
               WriteHtmlText( "") ;
               WriteHtmlText( "\"") ;
            }
            WriteHtmlText( " cellpadding=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(1), 10, 0))) ;
            WriteHtmlText( "\"") ;
            WriteHtmlText( " cellspacing=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(0), 10, 0))) ;
            WriteHtmlText( "\"") ;
            if ( ( String.CompareOrdinal("all".TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) && ( String.CompareOrdinal("all".TrimEnd(' '), "none".TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " rules=\"") ;
               WriteHtmlText( "all") ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlTextNl( ">") ;
            /* Subfile titles */
            WriteHtmlText( "<tr") ;
            WriteHtmlTextNl( ">") ;
            if ( ( subGrid1_Backcolorstyle == 0 ) )
            {
               subGrid1_Titlebackstyle = 0 ;
               if ( ( StringUtil.Len( subGrid1_Class) > 0 ) )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Title" ;
               }
            }
            else
            {
               subGrid1_Titlebackstyle = 1 ;
               if ( ( subGrid1_Backcolorstyle == 1 ) )
               {
                  subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                  if ( ( StringUtil.Len( subGrid1_Class) > 0 ) )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                  }
               }
               else
               {
                  if ( ( StringUtil.Len( subGrid1_Class) > 0 ) )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
            }
            sStyleString = ((1==0) ? "display:none;" : "") + ((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "") + "" ;
            sClassString = "S7" ;
            WriteHtmlText( "<th align=\""+"RIGHT"+"\""+" nowrap") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( sClassString) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            SendWebValue( "Codigo da Pessoa") ;
            WriteHtmlTextNl( "</th>") ;
            sStyleString = ((1==0) ? "display:none;" : "") + ((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "") + "" ;
            sClassString = "S7" ;
            WriteHtmlText( "<th align=\""+"LEFT"+"\""+" nowrap") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( sClassString) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            SendWebValue( "CPF da Pessoa") ;
            WriteHtmlTextNl( "</th>") ;
            sStyleString = ((1==0) ? "display:none;" : "") + ((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "") + "" ;
            sClassString = "S7" ;
            WriteHtmlText( "<th align=\""+"LEFT"+"\""+" nowrap") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( sClassString) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            SendWebValue( "Data de Nascimento da Pessoa") ;
            WriteHtmlTextNl( "</th>") ;
            WriteHtmlTextNl( "</tr>") ;
         }
         if ( ( wbEnd == 24 ) )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_24_idx-1) ;
            /* Subfile end */
            WriteHtmlText( "</table>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table2_5_072e( true) ;
         }
         else
         {
            wb_table2_5_072e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pPesCo = Convert.ToInt32(obj[0]) ;
      }

      public override String getresponse( String sGXDynURL )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         PA072( ) ;
         WS072( ) ;
         WE072( ) ;
         this.cleanup();
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         WriteHtmlTextNl( "<link rel=\"stylesheet\" type=\"text/css\" href=\""+convertURL( "styles.css")+"\"/>") ;
         idxLst = 1 ;
         while ( ( idxLst <= Form.Jscriptsrc.Count ) )
         {
            WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)))+"\"></script>") ;
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         WriteHtmlTextNl( "<script language=\"JavaScript\" type=\"text/javascript\">") ;
         WriteHtmlTextNl( "function GX_js_return( pPesCodigo) {if (opener != null) {if (opener.GXPARAMETERS != null) {") ;
         WriteHtmlTextNl( "GXAssignPromptField(0,pPesCodigo);") ;
         WriteHtmlTextNl( "if (opener.GXISGET) {") ;
         WriteHtmlTextNl( "opener.document.MAINFORM._EventName.value += 'EGET.';opener.document.MAINFORM.submit();") ;
         WriteHtmlTextNl( "} else {") ;
         WriteHtmlTextNl( "if (opener.GXPARAMETERS[0].Ctrl.type != 'hidden') {") ;
         WriteHtmlTextNl( "gxSetControlFocus(opener.GXPARAMETERS[0]); }") ;
         WriteHtmlTextNl( "if (typeof(opener.GXPromptCloseHandler) != \"undefined\"){opener.GXPromptCloseHandler();}") ;
         WriteHtmlTextNl( "} } self.close();} }") ;
         WriteHtmlTextNl( "var GXBadNumMsg = \"The value is not a valid number.\";") ;
         if ( ( context.nUserReturn == 0 ) )
         {
            WriteHtmlTextNl( "var GXPARAMETERS = new Array();") ;
            /* Set focus on 'active' control (if any). */
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( GX_FocusControl).TrimEnd(' ') )==0)) )
            {
               WriteHtmlTextNl( "GXSetUserFocus(document.forms[0]."+GX_FocusControl+");") ;
            }
         }
         else
         {
            WriteHtmlTextNl( "if (opener != null)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "if (opener.GXPARAMETERS != null)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "if (opener.GXISGET)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "opener.document.MAINFORM._EventName.value += 'EGET.';opener.document.MAINFORM.submit();") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "else") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "opener.GXPARAMETERS[0].Ctrl.focus();") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "if (typeof(opener.GXPromptCloseHandler) != \"undefined\"){opener.GXPromptCloseHandler();}") ;
            WriteHtmlTextNl( "self.close();") ;
            WriteHtmlTextNl( "}") ;
         }
         WriteHtmlTextNl( "</script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxvdate.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "std_messages.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gx_help.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "hgx0010.js")+"\"></script>") ;
         /* End function include_jscripts */
      }

      void gx_hidden_field( String sCtrlName ,
                            String sValue )
      {
         skipLines(1);
         WriteHtmlText( "<input type=\"hidden\"") ;
         WriteHtmlText( " name=\"") ;
         WriteHtmlText( sCtrlName) ;
         WriteHtmlText( "\" value=\"") ;
         SendWebValue( sValue) ;
         WriteHtmlText( "\"/>") ;
      }

      void gx_single_line_edit( String sCtrlName ,
                                String sValue ,
                                int nSize ,
                                int nLength ,
                                int nVisible ,
                                int nEnabled ,
                                int nRTEnabled ,
                                short nIsPassword ,
                                short nFormat ,
                                String sLinkURL ,
                                String sLinkTarget ,
                                String sStyleString ,
                                String sClassString ,
                                String sROClassString ,
                                String sFormatedValue ,
                                String sTags ,
                                int nJScriptCode ,
                                String sUserOnClickCode ,
                                String sEventName ,
                                int nParentId ,
                                short bHasTheme ,
                                short nAutoComplete ,
                                String sCallerPgm )
      {
         gx_single_line_edit2( sCtrlName, sValue, nSize, nLength, nVisible, 1, nEnabled, nRTEnabled, nIsPassword, nFormat, sLinkURL, sLinkTarget, sStyleString, sClassString, sROClassString, sFormatedValue, sTags, nJScriptCode, sUserOnClickCode, sEventName, nParentId, bHasTheme, nAutoComplete, sCallerPgm) ;
      }

      void gx_single_line_edit2( String sCtrlName ,
                                 String sValue ,
                                 int nSize ,
                                 int nLength ,
                                 int nVisible ,
                                 int nRTVisible ,
                                 int nEnabled ,
                                 int nRTEnabled ,
                                 short nIsPassword ,
                                 short nFormat ,
                                 String sLinkURL ,
                                 String sLinkTarget ,
                                 String sStyleString ,
                                 String sClassString ,
                                 String sROClassString ,
                                 String sFormatedValue ,
                                 String sTags ,
                                 int nJScriptCode ,
                                 String sUserOnClickCode ,
                                 String sEventName ,
                                 int nParentId ,
                                 short bHasTheme ,
                                 short nAutoComplete ,
                                 String sCallerPgm )
      {
         String sOStyle ;
         String sEventJsCode ;
         String ClassHTML ;
         sEventJsCode = "" ;
         sOStyle = sStyleString ;
         sStyleString = sStyleString + ((nVisible==0)||((nEnabled==0)&&(nRTEnabled==1)) ? ";display:none;" : "") ;
         if ( ( nRTEnabled != 0 ) || ( nEnabled != 0 ) )
         {
            if ( ( nVisible != 0 ) || ( ( nVisible == 0 ) && ( nRTVisible != 0 ) ) )
            {
               /* Control allows input */
               WriteHtmlText( "<input type=") ;
               if ( ( nIsPassword != 0 ) )
               {
                  WriteHtmlText( "\"password\"") ;
               }
               else
               {
                  WriteHtmlText( "\"text\"") ;
               }
               WriteHtmlText( " id=\"") ;
               WriteHtmlText( sCtrlName) ;
               WriteHtmlText( "\"") ;
               WriteHtmlText( " name=\"") ;
               WriteHtmlText( sCtrlName) ;
               WriteHtmlText( "\"") ;
               WriteHtmlText( " value=\"") ;
               SendWebValue( sValue) ;
               WriteHtmlText( "\"") ;
               if ( ( nAutoComplete == 0 ) )
               {
                  WriteHtmlText( " autocomplete=off") ;
               }
               WriteHtmlText( " size=\"") ;
               WriteHtmlText( StringUtil.FormatLong( nSize)) ;
               WriteHtmlText( "\"") ;
               WriteHtmlText( " maxlength=\"") ;
               WriteHtmlText( StringUtil.FormatLong( nLength)) ;
               WriteHtmlText( "\"") ;
               if ( ( StringUtil.Len( sClassString) > 0 ) )
               {
                  WriteHtmlText( " class=\"") ;
                  WriteHtmlText( sClassString) ;
                  WriteHtmlText( "\"") ;
               }
               if ( ( StringUtil.Len( sStyleString) > 0 ) )
               {
                  WriteHtmlText( " style=\"") ;
                  WriteHtmlText( sStyleString) ;
                  WriteHtmlText( "\" ") ;
               }
               WriteHtmlText( sTags) ;
               WriteHtmlText( ">") ;
            }
            else
            {
               gx_hidden_field( sCtrlName, sValue);
               WriteHtmlText( "<span style=\"display:none;\">&nbsp;</span>") ;
            }
         }
         if ( ( nEnabled == 0 ) )
         {
            /* Control is read only */
            if ( ( nRTEnabled == 0 ) )
            {
               gx_hidden_field( sCtrlName, sValue);
            }
            if ( ( nVisible != 0 ) || ( ( nVisible == 0 ) && ( nRTVisible != 0 ) ) )
            {
               if ( ( bHasTheme == 0 ) )
               {
                  ClassHTML = sClassString ;
               }
               else
               {
                  if ( ( nParentId == 0 ) )
                  {
                     if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
                     {
                        ClassHTML = "Readonly" + sClassString ;
                     }
                     else
                     {
                        ClassHTML = sClassString ;
                     }
                  }
                  else
                  {
                     if ( ( StringUtil.Len( sROClassString) != 0 ) && ( StringUtil.StringSearch( sROClassString, "Readonly", 1) != 1 ) )
                     {
                        ClassHTML = "Readonly" + sROClassString ;
                     }
                     else
                     {
                        ClassHTML = sROClassString ;
                     }
                  }
               }
               if ( ( nFormat != 2 ) )
               {
                  sOStyle = sOStyle + ((nVisible==0) ? ";display:none;" : "") ;
                  WriteHtmlText( "<span"+" id=\"span_"+sCtrlName+"\"") ;
                  if ( ( StringUtil.Len( ClassHTML) > 0 ) )
                  {
                     WriteHtmlText( " class=\"") ;
                     WriteHtmlText( ClassHTML) ;
                     WriteHtmlText( "\"") ;
                  }
                  if ( ( StringUtil.Len( sOStyle) > 0 ) )
                  {
                     WriteHtmlText( " style=\"") ;
                     WriteHtmlText( sOStyle) ;
                     WriteHtmlText( "\" ") ;
                  }
                  WriteHtmlText( ">") ;
                  /* Initialize internal JScript code according to EventNo */
                  if ( ( nJScriptCode == 1 ) )
                  {
                     sEventJsCode = "GX_js_close();" ;
                  }
                  else if ( ( nJScriptCode == 2 ) )
                  {
                     sEventJsCode = "ClearForm( this.form);" ;
                  }
                  else if ( ( nJScriptCode == 3 ) )
                  {
                     sEventJsCode = "GX_help(" + "''" + "," + StringUtil.Lower( sCallerPgm) + ");" ;
                  }
                  else if ( ( nJScriptCode == 5 ) )
                  {
                     sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" + "gxSubmit();" ;
                  }
                  else if ( ( nJScriptCode == 0 ) )
                  {
                     sEventJsCode = "" ;
                  }
                  else
                  {
                     sEventJsCode = "" ;
                  }
                  gx_start_js_anchor( sEventJsCode, sUserOnClickCode, sLinkURL, sLinkTarget);
               }
               if ( ( nIsPassword == 0 ) )
               {
                  if ( ( nFormat == 0 ) )
                  {
                     SendWebValue( sFormatedValue) ;
                  }
                  else
                  {
                     if ( ( nFormat == 3 ) )
                     {
                        SendWebValueSpace( sFormatedValue) ;
                     }
                     else
                     {
                        WriteHtmlText( sFormatedValue) ;
                     }
                  }
               }
               else
               {
                  SendWebValue( StringUtil.PadR( "", (short)(nSize), "*")) ;
               }
               if ( ( nFormat != 2 ) )
               {
                  gx_end_js_anchor( sEventJsCode, sUserOnClickCode, sLinkURL);
                  WriteHtmlText( "</span>") ;
               }
            }
            else
            {
               WriteHtmlText( "<span style=\"display:none;\">&nbsp;</span>") ;
            }
         }
      }

      void gx_link_start( String sLinkURL ,
                          String sTargetWnd )
      {
         if ( ( String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sLinkURL).TrimEnd(' ') ) != 0 ) )
         {
            WriteHtmlText( "<a href=\"") ;
            WriteHtmlText( StringUtil.RTrim( sLinkURL)) ;
            WriteHtmlText( "\"") ;
            if ( ( String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sTargetWnd).TrimEnd(' ') ) != 0 ) )
            {
               WriteHtmlText( " target=\"") ;
               WriteHtmlText( StringUtil.RTrim( sTargetWnd)) ;
               WriteHtmlText( "\"") ;
            }
            WriteHtmlText( ">") ;
         }
      }

      void gx_link_end( String sLinkURL )
      {
         if ( ( String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sLinkURL).TrimEnd(' ') ) != 0 ) )
         {
            WriteHtmlText( "</a>") ;
         }
      }

      void gx_msg_list( String sCtrlName ,
                        int nDisplayMode ,
                        String sStyleString ,
                        String sClassString )
      {
         gx_msg_list2( sCtrlName, nDisplayMode, sStyleString, sClassString, false) ;
      }

      void gx_msg_list2( String sCtrlName ,
                         int nDisplayMode ,
                         String sStyleString ,
                         String sClassString ,
                         bool bUseClasses )
      {
         int i ;
         if ( ( context.GX_msglist.ItemCount > 0 ) )
         {
            WriteHtmlText( "<span") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( sClassString) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            if ( ( nDisplayMode == 2 ) )
            {
               i = 1 ;
               while ( ( i <= context.GX_msglist.ItemCount ) )
               {
                  if ( bUseClasses && ( context.GX_msglist.getItemType((short)(i)) == 1 ) )
                  {
                     WriteHtmlText( "<span class=\"ErrorMessages\">") ;
                  }
                  else
                  {
                     if ( bUseClasses )
                     {
                        WriteHtmlText( "<span class=\"WarningMessages\">") ;
                     }
                  }
                  WriteHtmlText( context.GX_msglist.getItemText((short)(i))) ;
                  if ( bUseClasses )
                  {
                     WriteHtmlText( "</span>") ;
                  }
                  WriteHtmlText( "<br/>") ;
                  i = (int)(i+1) ;
               }
            }
            else
            {
               WriteHtmlText( "<menu>") ;
               i = 1 ;
               while ( ( i <= context.GX_msglist.ItemCount ) )
               {
                  WriteHtmlText( "<li>") ;
                  if ( bUseClasses && ( context.GX_msglist.getItemType((short)(i)) == 1 ) )
                  {
                     WriteHtmlText( "<span class=\"ErrorMessages\">") ;
                  }
                  else
                  {
                     if ( bUseClasses )
                     {
                        WriteHtmlText( "<span class=\"WarningMessages\">") ;
                     }
                  }
                  WriteHtmlText( context.GX_msglist.getItemText((short)(i))) ;
                  if ( bUseClasses )
                  {
                     WriteHtmlText( "</span>") ;
                  }
                  WriteHtmlText( "</li>") ;
                  i = (int)(i+1) ;
               }
               WriteHtmlText( "</menu>") ;
            }
            context.GX_msglist.removeAllItems();
            WriteHtmlText( "</span>") ;
         }
      }

      void gx_button_ctrl( int nReset ,
                           String sCtrlName ,
                           String sCaption ,
                           String sAccesskey ,
                           String sStyleString ,
                           String sClassString ,
                           int nVisible ,
                           int nEnabled ,
                           int nJScriptCode ,
                           String sUserOnClickCode ,
                           String sEventName ,
                           String sTags ,
                           String sJsCode ,
                           String sJsDynCode ,
                           String sCallerPgm )
      {
         gx_button_ctrl2( nReset, sCtrlName, sCaption, "", sAccesskey, sStyleString, sClassString, nVisible, nEnabled, nJScriptCode, sUserOnClickCode, sEventName, sTags, sJsCode, sJsDynCode, sCallerPgm) ;
      }

      void gx_button_ctrl2( int nReset ,
                            String sCtrlName ,
                            String sCaption ,
                            String sTooltipText ,
                            String sAccesskey ,
                            String sStyleString ,
                            String sClassString ,
                            int nVisible ,
                            int nEnabled ,
                            int nJScriptCode ,
                            String sUserOnClickCode ,
                            String sEventName ,
                            String sTags ,
                            String sJsCode ,
                            String sJsDynCode ,
                            String sCallerPgm )
      {
         String sEventJsCode ;
         String sCapAKey ;
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;") ;
         WriteHtmlText( "<input type=") ;
         if ( ( nReset == 1 ) )
         {
            WriteHtmlText( "SUBMIT") ;
         }
         else if ( ( nReset == 0 ) )
         {
            WriteHtmlText( "RESET") ;
         }
         else
         {
            WriteHtmlText( "BUTTON") ;
         }
         sCapAKey = GXUtil.AccessKey( sCaption) ;
         sCaption = GXUtil.AccessKeyCaption( sCaption) ;
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sCapAKey).TrimEnd(' ') )==0)) )
         {
            sCapAKey = GXUtil.AccessKey( sTooltipText) ;
            sTooltipText = GXUtil.AccessKeyCaption( sTooltipText) ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sCapAKey).TrimEnd(' ') )==0)) )
         {
            sAccesskey = sCapAKey ;
         }
         WriteHtmlText( " name=\"") ;
         WriteHtmlText( sCtrlName) ;
         WriteHtmlText( "\"") ;
         WriteHtmlText( " value=\"") ;
         WriteHtmlText( sCaption) ;
         WriteHtmlText( "\"") ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sTooltipText).TrimEnd(' ') )==0)) )
         {
            WriteHtmlText( " title=\"") ;
            WriteHtmlText( sTooltipText) ;
            WriteHtmlText( "\"") ;
         }
         if ( ( StringUtil.Len( sAccesskey) != 0 ) )
         {
            WriteHtmlText( " accesskey=\"") ;
            WriteHtmlText( sAccesskey) ;
            WriteHtmlText( "\"") ;
         }
         if ( ( StringUtil.Len( sClassString) > 0 ) )
         {
            WriteHtmlText( " class=\"") ;
            WriteHtmlText( sClassString) ;
            WriteHtmlText( "\"") ;
         }
         if ( ( StringUtil.Len( sStyleString) > 0 ) )
         {
            WriteHtmlText( " style=\"") ;
            WriteHtmlText( sStyleString) ;
            WriteHtmlText( "\" ") ;
         }
         WriteHtmlText( " gxevent=\""+sEventName+"\" ") ;
         if ( ( nEnabled == 0 ) )
         {
            if ( ( context.GetBrowserType( ) == 1 ) || ( ( context.GetBrowserType( ) == 2 ) && ( String.CompareOrdinal(context.GetBrowserVersion( ).TrimEnd(' '), "5.0".TrimEnd(' ') ) >= 0 ) ) )
            {
               WriteHtmlText( " DISABLED") ;
            }
            else
            {
               WriteHtmlText( " onclick=\"return false;\"") ;
            }
         }
         else
         {
            /* Initialize internal JScript code according to EventNo */
            if ( ( nJScriptCode == 1 ) )
            {
               sEventJsCode = "GX_js_close();" + "return false;" ;
            }
            else if ( ( nJScriptCode == 2 ) )
            {
               sEventJsCode = "ClearForm( this.form);" + "return false;" ;
            }
            else if ( ( nJScriptCode == 3 ) )
            {
               sEventJsCode = "GX_help(" + "''" + "," + StringUtil.Lower( sCallerPgm) + ");" + "return false;" ;
            }
            else if ( ( nJScriptCode == 5 ) )
            {
               sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" ;
            }
            else if ( ( nJScriptCode == 0 ) )
            {
               sEventJsCode = "" ;
            }
            else
            {
               sEventJsCode = "" ;
            }
            sEventJsCode = sJsCode + sEventJsCode ;
            gx_on_js_event( "onclick", sEventJsCode, sUserOnClickCode);
         }
         WriteHtmlText( " ") ;
         WriteHtmlText( sTags) ;
         WriteHtmlText( ">") ;
      }

      void gx_on_js_event( String sEventName ,
                           String sEventJsCode ,
                           String sUserOnClickCode )
      {
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sUserOnClickCode).TrimEnd(' ') )==0)) )
         {
            WriteHtmlText( " ") ;
            WriteHtmlText( sEventName) ;
            WriteHtmlText( "=\"if( ") ;
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sEventJsCode).TrimEnd(' ') )==0)) )
            {
               WriteHtmlText( sUserOnClickCode) ;
               WriteHtmlText( ") {") ;
               WriteHtmlText( sEventJsCode) ;
               WriteHtmlText( "} else return false;\"") ;
            }
            else
            {
               WriteHtmlText( "!(") ;
               WriteHtmlText( sUserOnClickCode) ;
               WriteHtmlText( ")) return false;\"") ;
            }
         }
         else
         {
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sEventJsCode).TrimEnd(' ') )==0)) )
            {
               WriteHtmlText( " ") ;
               WriteHtmlText( sEventName) ;
               WriteHtmlText( "=\"") ;
               WriteHtmlText( sEventJsCode) ;
               WriteHtmlText( "\"") ;
            }
         }
      }

      void gx_label_ctrl( String sInternalName ,
                          int nVisible ,
                          int nEnabled ,
                          short nFormat ,
                          String sCaption ,
                          String sLinkURL ,
                          String sLinkTarget ,
                          int nJScriptCode ,
                          String sUserOnClickCode ,
                          String sEventName ,
                          String sTags ,
                          String sClassString ,
                          String sCallerPgm )
      {
         String sEventJsCode ;
         String sStyle ;
         sStyle = ((nVisible!=0) ? "" : ";display:none;") + sTags ;
         if ( ( nFormat != 2 ) )
         {
            WriteHtmlText( "<span"+" id=\""+sInternalName+"\"") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( sClassString) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyle) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyle) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
         }
         if ( ( nEnabled != 0 ) )
         {
            /* Initialize internal JScript code according to EventNo */
            if ( ( nJScriptCode == 1 ) )
            {
               sEventJsCode = "GX_js_close();" ;
            }
            else if ( ( nJScriptCode == 2 ) )
            {
               sEventJsCode = "ClearForm( this.form);" ;
            }
            else if ( ( nJScriptCode == 3 ) )
            {
               sEventJsCode = "GX_help(" + "''" + "," + StringUtil.Lower( sCallerPgm) + ");" ;
            }
            else if ( ( nJScriptCode == 5 ) )
            {
               sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" + "gxSubmit();" ;
            }
            else if ( ( nJScriptCode == 0 ) )
            {
               sEventJsCode = "" ;
            }
            else
            {
               sEventJsCode = "" ;
            }
            gx_start_js_anchor( sEventJsCode, sUserOnClickCode, sLinkURL, sLinkTarget);
         }
         else
         {
            sEventJsCode = "" ;
         }
         if ( ( nFormat == 0 ) )
         {
            SendWebValue( sCaption) ;
         }
         else
         {
            if ( ( nFormat == 3 ) )
            {
               SendWebValueSpace( sCaption) ;
            }
            else
            {
               WriteHtmlText( sCaption) ;
            }
         }
         if ( ( nEnabled != 0 ) )
         {
            gx_end_js_anchor( sEventJsCode, sUserOnClickCode, sLinkURL);
         }
         if ( ( nFormat != 2 ) )
         {
            WriteHtmlText( "</span>") ;
         }
      }

      void gx_start_js_anchor( String sGXOnClickCode ,
                               String sUserOnClickCode ,
                               String sLinkURL ,
                               String sLinkTarget )
      {
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sUserOnClickCode).TrimEnd(' ') )==0)) )
         {
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sGXOnClickCode).TrimEnd(' ') )==0)) )
            {
               WriteHtmlText( "<a href=\"javascript:if( ") ;
               WriteHtmlText( sUserOnClickCode) ;
               WriteHtmlText( ") {") ;
               WriteHtmlText( sGXOnClickCode) ;
               WriteHtmlText( "}\">") ;
            }
            else
            {
               WriteHtmlText( "<a href=\"javascript:") ;
               WriteHtmlText( sUserOnClickCode) ;
               WriteHtmlText( "\">") ;
            }
         }
         else
         {
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sGXOnClickCode).TrimEnd(' ') )==0)) )
            {
               WriteHtmlText( "<a href=\"javascript:") ;
               WriteHtmlText( sGXOnClickCode) ;
               WriteHtmlText( "\">") ;
            }
            else
            {
               gx_link_start( sLinkURL, sLinkTarget);
            }
         }
      }

      void gx_end_js_anchor( String sGXOnClickCode ,
                             String sUserOnClickCode ,
                             String sLinkURL )
      {
         if ( ! ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sGXOnClickCode).TrimEnd(' ') )==0)) && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sUserOnClickCode).TrimEnd(' ') )==0)) ) )
         {
            WriteHtmlText( "</a>") ;
         }
         else
         {
            gx_link_end( sLinkURL);
         }
      }

      void gx_combobox_ctrl2( GXCombobox cmbCObjCtrl ,
                              String sCtrlName ,
                              String sValue ,
                              String sType ,
                              int nVisible ,
                              int nEnabled ,
                              int nRows ,
                              short nFormat ,
                              String sStyleString ,
                              String sClassString ,
                              String sFormatedValue ,
                              int nJScriptCode ,
                              String sUserOnClickCode ,
                              String sEventName ,
                              String sTags ,
                              String sCallerPgm )
      {
         String sOStyle ;
         String sEventJsCode ;
         int idxLst ;
         String ClassHTML ;
         idxLst = 1 ;
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;") ;
         sOStyle = sStyleString ;
         sStyleString = sStyleString + ((nVisible!=0)&&(nEnabled==0) ? ";display:none;" : "") ;
         /* Initialize internal JScript code according to EventNo */
         if ( ( nJScriptCode == 1 ) )
         {
            sEventJsCode = "GX_js_close();" + "return false;" ;
         }
         else if ( ( nJScriptCode == 2 ) )
         {
            sEventJsCode = "ClearForm( this.form);" + "return false;" ;
         }
         else if ( ( nJScriptCode == 3 ) )
         {
            sEventJsCode = "GX_help(" + "''" + "," + StringUtil.Lower( sCallerPgm) + ");" + "return false;" ;
         }
         else if ( ( nJScriptCode == 5 ) )
         {
            sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" + "gxSubmit();" ;
         }
         else if ( ( nJScriptCode == 0 ) )
         {
            sEventJsCode = "" ;
         }
         else
         {
            sEventJsCode = "" ;
         }
         WriteHtmlText( "<select size=") ;
         WriteHtmlText( StringUtil.LTrim( StringUtil.NToC( (decimal)(nRows), 3, 0, ".", ""))) ;
         WriteHtmlText( " id=\"") ;
         WriteHtmlText( sCtrlName+"\"") ;
         WriteHtmlText( " name=\"") ;
         WriteHtmlText( sCtrlName+"\"") ;
         if ( ( StringUtil.Len( sClassString) > 0 ) )
         {
            WriteHtmlText( " class=\"") ;
            WriteHtmlText( sClassString) ;
            WriteHtmlText( "\"") ;
         }
         if ( ( StringUtil.Len( sStyleString) > 0 ) )
         {
            WriteHtmlText( " style=\"") ;
            WriteHtmlText( sStyleString) ;
            WriteHtmlText( "\" ") ;
         }
         WriteHtmlText( sTags) ;
         gx_on_js_event( "gxoch0", sEventJsCode, sUserOnClickCode);
         WriteHtmlTextNl( ">") ;
         while ( ( idxLst <= cmbCObjCtrl.ItemCount ) )
         {
            if ( ( String.CompareOrdinal(sType.TrimEnd(' '), "int".TrimEnd(' ') ) == 0 ) )
            {
               WriteHtmlText( "<option value=\""+StringUtil.Trim( cmbCObjCtrl.getItemValue((short)(idxLst)))) ;
            }
            else
            {
               WriteHtmlText( "<option value=\""+StringUtil.RTrim( cmbCObjCtrl.getItemValue((short)(idxLst)))) ;
            }
            if ( ( String.CompareOrdinal(StringUtil.LTrim( cmbCObjCtrl.getItemValue((short)(idxLst))).TrimEnd(' '), StringUtil.LTrim( sValue).TrimEnd(' ') ) == 0 ) )
            {
               WriteHtmlText( "\" selected >") ;
            }
            else
            {
               WriteHtmlText( "\">") ;
            }
            if ( ( nFormat == 0 ) )
            {
               SendWebValue( cmbCObjCtrl.getItemText((short)(idxLst))) ;
            }
            else
            {
               if ( ( nFormat == 3 ) )
               {
                  SendWebValueSpace( cmbCObjCtrl.getItemText((short)(idxLst))) ;
               }
               else
               {
                  WriteHtmlText( cmbCObjCtrl.getItemText((short)(idxLst))) ;
               }
            }
            skipLines(1);
            idxLst = (int)(idxLst+1) ;
         }
         WriteHtmlTextNl( "</select>") ;
         if ( ( nEnabled == 0 ) )
         {
            if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               ClassHTML = "Readonly" + sClassString ;
            }
            else
            {
               ClassHTML = sClassString ;
            }
            WriteHtmlText( "<span"+" id=\"span_"+sCtrlName+"\"") ;
            if ( ( StringUtil.Len( ClassHTML) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( ClassHTML) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sOStyle) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sOStyle) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            SendWebValue( cmbCObjCtrl.Description) ;
            WriteHtmlText( "</span>") ;
         }
      }

      void gx_combobox_ctrl( GXCombobox cmbCObjCtrl ,
                             String sCtrlName ,
                             String sValue ,
                             String sType ,
                             int nVisible ,
                             int nEnabled ,
                             int nRows ,
                             short nFormat ,
                             String sStyleString ,
                             String sClassString ,
                             String sFormatedValue ,
                             int nJScriptCode ,
                             String sUserOnClickCode ,
                             String sEventName ,
                             String sTags ,
                             String sCallerPgm )
      {
         String sEventJsCode ;
         int idxLst ;
         String ClassHTML ;
         idxLst = 1 ;
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;") ;
         if ( ( nEnabled == 1 ) )
         {
            /* Initialize internal JScript code according to EventNo */
            if ( ( nJScriptCode == 1 ) )
            {
               sEventJsCode = "GX_js_close();" + "return false;" ;
            }
            else if ( ( nJScriptCode == 2 ) )
            {
               sEventJsCode = "ClearForm( this.form);" + "return false;" ;
            }
            else if ( ( nJScriptCode == 3 ) )
            {
               sEventJsCode = "GX_help(" + "''" + "," + StringUtil.Lower( sCallerPgm) + ");" + "return false;" ;
            }
            else if ( ( nJScriptCode == 5 ) )
            {
               sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" + "gxSubmit();" ;
            }
            else if ( ( nJScriptCode == 0 ) )
            {
               sEventJsCode = "" ;
            }
            else
            {
               sEventJsCode = "" ;
            }
            WriteHtmlText( "<select size=") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.NToC( (decimal)(nRows), 3, 0, ".", ""))) ;
            WriteHtmlText( " name=\"") ;
            WriteHtmlText( sCtrlName+"\"") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( sClassString) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( sTags) ;
            gx_on_js_event( "gxoch0", sEventJsCode, sUserOnClickCode);
            WriteHtmlTextNl( ">") ;
            while ( ( idxLst <= cmbCObjCtrl.ItemCount ) )
            {
               if ( ( String.CompareOrdinal(sType.TrimEnd(' '), "int".TrimEnd(' ') ) == 0 ) )
               {
                  WriteHtmlText( "<option value=\""+StringUtil.Trim( cmbCObjCtrl.getItemValue((short)(idxLst)))) ;
               }
               else
               {
                  WriteHtmlText( "<option value=\""+StringUtil.RTrim( cmbCObjCtrl.getItemValue((short)(idxLst)))) ;
               }
               if ( ( String.CompareOrdinal(StringUtil.LTrim( cmbCObjCtrl.getItemValue((short)(idxLst))).TrimEnd(' '), StringUtil.LTrim( sValue).TrimEnd(' ') ) == 0 ) )
               {
                  WriteHtmlText( "\" selected >") ;
               }
               else
               {
                  WriteHtmlText( "\">") ;
               }
               if ( ( nFormat == 0 ) )
               {
                  SendWebValue( cmbCObjCtrl.getItemText((short)(idxLst))) ;
               }
               else
               {
                  if ( ( nFormat == 3 ) )
                  {
                     SendWebValueSpace( cmbCObjCtrl.getItemText((short)(idxLst))) ;
                  }
                  else
                  {
                     WriteHtmlText( cmbCObjCtrl.getItemText((short)(idxLst))) ;
                  }
               }
               skipLines(1);
               idxLst = (int)(idxLst+1) ;
            }
            WriteHtmlTextNl( "</select>") ;
         }
         else
         {
            if ( ( StringUtil.Len( sClassString) != 0 ) && ( StringUtil.StringSearch( sClassString, "Readonly", 1) != 1 ) )
            {
               ClassHTML = "Readonly" + sClassString ;
            }
            else
            {
               ClassHTML = sClassString ;
            }
            WriteHtmlText( "<span"+" id=\"span_"+sCtrlName+"\"") ;
            if ( ( StringUtil.Len( ClassHTML) > 0 ) )
            {
               WriteHtmlText( " class=\"") ;
               WriteHtmlText( ClassHTML) ;
               WriteHtmlText( "\"") ;
            }
            if ( ( StringUtil.Len( sStyleString) > 0 ) )
            {
               WriteHtmlText( " style=\"") ;
               WriteHtmlText( sStyleString) ;
               WriteHtmlText( "\" ") ;
            }
            WriteHtmlText( ">") ;
            SendWebValue( cmbCObjCtrl.Description) ;
            WriteHtmlText( "</span>") ;
            gx_hidden_field( sCtrlName, sValue);
         }
      }

      protected void initialize_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavCpescodigo_Internalname = "_CPESCODIGO" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavCpescpf_Internalname = "_CPESCPF" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavCpesdatnasc_Internalname = "_CPESDATNASC" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtavCpesendnumero_Internalname = "_CPESENDNUMERO" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavCpestelefone_Internalname = "_CPESTELEFONE" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavCpescelular_Internalname = "_CPESCELULAR" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         cmbavCpessituacao_Internalname = "_CPESSITUACAO" ;
         bttBtn_refresh_Internalname = "BTN_REFRESH" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
         subGrid1_Titlebackstyle = 1 ;
         subGrid1_Class = "" ;
         cmbavCpessituacao_Jsonclick = "" ;
         edtavCpescelular_Jsonclick = "" ;
         edtavCpestelefone_Jsonclick = "" ;
         edtavCpesendnumero_Jsonclick = "" ;
         edtavCpesdatnasc_Jsonclick = "" ;
         edtavCpescpf_Jsonclick = "" ;
         edtavCpescodigo_Jsonclick = "" ;
         edtPesDatNasc_Jsonclick = "" ;
         edtPesCPF_Jsonclick = "" ;
         edtPesCodigo_Jsonclick = "" ;
         subGrid1_Backstyle = 1 ;
         edtPesCodigo_Link = "" ;
         subGrid1_Backcolorstyle = 2 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         this.AV12pPesCo = AV12pPesCo;
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxajaxcallmode = 0 ;
         nGotPars = 0 ;
         gxfirstwebparm = "" ;
         AV12pPesCo = 0 ;
         GxWebError = 0 ;
         wbTemp = 0 ;
         Form = new GXWebForm();
         addContentType = false ;
         sDynURL = "" ;
         GXt_char1 = "" ;
         FormProcess = "" ;
         AV5cPesCod = 0 ;
         AV6cPesCPF = "" ;
         AV7cPesDat = (DateTime)(DateTime.MinValue) ;
         AV8cPesEnd = "" ;
         AV9cPesTel = "" ;
         AV10cPesCe = "" ;
         AV11cPesSi = 0 ;
         nRC_Grid1 = 0 ;
         Grid1_nFirstRecordOnPage = 0 ;
         Grid1_nEOF = 0 ;
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         sPrefix = "" ;
         GXSUBMITID = "" ;
         Rfr0gs = false ;
         wbErr = false ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         nDonePA = 0 ;
         lblTextblock1_Name = "" ;
         lblTextblock2_Name = "" ;
         lblTextblock3_Name = "" ;
         lblTextblock4_Name = "" ;
         lblTextblock5_Name = "" ;
         lblTextblock6_Name = "" ;
         lblTextblock7_Name = "" ;
         GX_FocusControl = "" ;
         edtavCpescodigo_Internalname = "" ;
         subGrid1_Backcolorstyle = 0 ;
         subGrid1_Backstyle = 0 ;
         subGrid1_Backcolor = 0 ;
         subGrid1_Allbackcolor = 0 ;
         ClassString = "" ;
         StyleString = "" ;
         ROClassString = "" ;
         edtPesCodigo_Link = "" ;
         A12PesCodi = 0 ;
         edtPesCodigo_Internalname = "" ;
         edtPesCodigo_Jsonclick = "" ;
         edtPesCPF_Internalname = "" ;
         A14PesCPF = "" ;
         edtPesCPF_Jsonclick = "" ;
         edtPesDatNasc_Internalname = "" ;
         A15PesDatN = (DateTime)(DateTime.MinValue) ;
         edtPesDatNasc_Jsonclick = "" ;
         gxCalCtrlInc = 0 ;
         GXCCtl = "" ;
         scmdbuf = "" ;
         lV6cPesCPF = "" ;
         lV8cPesEnd = "" ;
         lV9cPesTel = "" ;
         lV10cPesCe = "" ;
         H00072_A17PesEndN = new String[] {""} ;
         H00072_n17PesEndN = new bool[] {false} ;
         H00072_A20PesTele = new String[] {""} ;
         H00072_n20PesTele = new bool[] {false} ;
         H00072_A21PesCelu = new String[] {""} ;
         H00072_n21PesCelu = new bool[] {false} ;
         H00072_A22PesSitu = new short[1] ;
         H00072_n22PesSitu = new bool[] {false} ;
         H00072_A15PesDatN = new DateTime[] {DateTime.MinValue} ;
         H00072_n15PesDatN = new bool[] {false} ;
         H00072_A14PesCPF = new String[] {""} ;
         H00072_n14PesCPF = new bool[] {false} ;
         H00072_A12PesCodi = new int[1] ;
         A17PesEndN = "" ;
         n17PesEndN = false ;
         A20PesTele = "" ;
         n20PesTele = false ;
         A21PesCelu = "" ;
         n21PesCelu = false ;
         A22PesSitu = 0 ;
         n22PesSitu = false ;
         n15PesDatN = false ;
         n14PesCPF = false ;
         Grid1_nRecordCount = 0 ;
         H00073_AGrid1_nRe = new int[1] ;
         nDoneStart = 0 ;
         edtavCpescpf_Internalname = "" ;
         edtavCpesdatnasc_Internalname = "" ;
         edtavCpesendnumero_Internalname = "" ;
         edtavCpestelefone_Internalname = "" ;
         edtavCpescelular_Internalname = "" ;
         cmbavCpessituacao_Internalname = "" ;
         returnInSub = false ;
         Grid1_nCurrentRecord = 0 ;
         tblTable1_Internalname = "" ;
         TempTags = "" ;
         bttBtn_first_Internalname = "" ;
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Internalname = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Internalname = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Internalname = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttBtn_cancel_Internalname = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_help_Internalname = "" ;
         bttBtn_help_Jsonclick = "" ;
         tblTable2_Internalname = "" ;
         lblTextblock1_Internalname = "" ;
         lblTextblock1_Jsonclick = "" ;
         edtavCpescodigo_Jsonclick = "" ;
         lblTextblock2_Internalname = "" ;
         lblTextblock2_Jsonclick = "" ;
         edtavCpescpf_Jsonclick = "" ;
         lblTextblock3_Internalname = "" ;
         lblTextblock3_Jsonclick = "" ;
         edtavCpesdatnasc_Jsonclick = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         lblTextblock4_Internalname = "" ;
         lblTextblock4_Jsonclick = "" ;
         edtavCpesendnumero_Jsonclick = "" ;
         lblTextblock5_Internalname = "" ;
         lblTextblock5_Jsonclick = "" ;
         edtavCpestelefone_Jsonclick = "" ;
         lblTextblock6_Internalname = "" ;
         lblTextblock6_Jsonclick = "" ;
         edtavCpescelular_Jsonclick = "" ;
         lblTextblock7_Internalname = "" ;
         lblTextblock7_Jsonclick = "" ;
         cmbavCpessituacao_Jsonclick = "" ;
         bttBtn_refresh_Internalname = "" ;
         bttBtn_refresh_Jsonclick = "" ;
         subGrid1_Internalname = "" ;
         subGrid1_Titlebackstyle = 0 ;
         subGrid1_Class = "" ;
         subGrid1_Linesclass = "" ;
         subGrid1_Titlebackcolor = 0 ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         nGXWrapped = 0 ;
         Formheaderjscriptsrc = new GeneXus.Utils.GxStringCollection();
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         cmbCObjCtrl = new GXCombobox();
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hgx0010__default(),
            new Object[][] {
                new Object[] {
               H00072_A17PesEndN, H00072_n17PesEndN, H00072_A20PesTele, H00072_n20PesTele, H00072_A21PesCelu, H00072_n21PesCelu, H00072_A22PesSitu, H00072_n22PesSitu, H00072_A15PesDatN, H00072_n15PesDatN,
               H00072_A14PesCPF, H00072_n14PesCPF, H00072_A12PesCodi
               }
               , new Object[] {
               H00073_AGrid1_nRe
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short gxajaxcallmode ;
      private short nGotPars ;
      private short GxWebError ;
      private short wbTemp ;
      private short AV11cPesSi ;
      private short nRC_Grid1 ;
      private short Grid1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short nGXsfl_24_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Backstyle ;
      private short A22PesSitu ;
      private short nDoneStart ;
      private short subGrid1_Titlebackstyle ;
      private short nGXWrapped ;
      private int AV12pPesCo ;
      private int idxLst ;
      private int AV5cPesCod ;
      private int Grid1_nFirstRecordOnPage ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int A12PesCodi ;
      private int gxCalCtrlInc ;
      private int Grid1_nRecordCount ;
      private int Grid1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private String gxfirstwebparm ;
      private String sDynURL ;
      private String GXt_char1 ;
      private String FormProcess ;
      private String sPrefix ;
      private String GXSUBMITID ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String lblTextblock1_Name ;
      private String lblTextblock2_Name ;
      private String lblTextblock3_Name ;
      private String lblTextblock4_Name ;
      private String lblTextblock5_Name ;
      private String lblTextblock6_Name ;
      private String lblTextblock7_Name ;
      private String GX_FocusControl ;
      private String edtavCpescodigo_Internalname ;
      private String sClassString ;
      private String sStyleString ;
      private String ClassString ;
      private String StyleString ;
      private String ROClassString ;
      private String edtPesCodigo_Link ;
      private String edtPesCodigo_Internalname ;
      private String edtPesCodigo_Jsonclick ;
      private String edtPesCPF_Internalname ;
      private String edtPesCPF_Jsonclick ;
      private String edtPesDatNasc_Internalname ;
      private String edtPesDatNasc_Jsonclick ;
      private String sGXsfl_24_idx="0001" ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String edtavCpescpf_Internalname ;
      private String edtavCpesdatnasc_Internalname ;
      private String edtavCpesendnumero_Internalname ;
      private String edtavCpestelefone_Internalname ;
      private String edtavCpescelular_Internalname ;
      private String cmbavCpessituacao_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_help_Internalname ;
      private String bttBtn_help_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavCpescodigo_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavCpescpf_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavCpesdatnasc_Jsonclick ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtavCpesendnumero_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavCpestelefone_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavCpescelular_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String cmbavCpessituacao_Jsonclick ;
      private String bttBtn_refresh_Internalname ;
      private String bttBtn_refresh_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private DateTime AV7cPesDat ;
      private DateTime A15PesDatN ;
      private bool addContentType ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n17PesEndN ;
      private bool n20PesTele ;
      private bool n21PesCelu ;
      private bool n22PesSitu ;
      private bool n15PesDatN ;
      private bool n14PesCPF ;
      private bool returnInSub ;
      private String AV6cPesCPF ;
      private String AV8cPesEnd ;
      private String AV9cPesTel ;
      private String AV10cPesCe ;
      private String A14PesCPF ;
      private String lV6cPesCPF ;
      private String lV8cPesEnd ;
      private String lV9cPesTel ;
      private String lV10cPesCe ;
      private String A17PesEndN ;
      private String A20PesTele ;
      private String A21PesCelu ;
      private GeneXus.Utils.GxStringCollection Formheaderjscriptsrc ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCpessituacao ;
      private IDataReader H00072 ;
      private IDataStoreProvider pr_default ;
      private String[] H00072_A17PesEndN ;
      private bool[] H00072_n17PesEndN ;
      private String[] H00072_A20PesTele ;
      private bool[] H00072_n20PesTele ;
      private String[] H00072_A21PesCelu ;
      private bool[] H00072_n21PesCelu ;
      private short[] H00072_A22PesSitu ;
      private bool[] H00072_n22PesSitu ;
      private DateTime[] H00072_A15PesDatN ;
      private bool[] H00072_n15PesDatN ;
      private String[] H00072_A14PesCPF ;
      private bool[] H00072_n14PesCPF ;
      private int[] H00072_A12PesCodi ;
      private IDataReader H00073 ;
      private int[] H00073_AGrid1_nRe ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXCombobox cmbCObjCtrl ;
      private int aP0_pPesCodigo ;
   }

   public class hgx0010__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmH00072 ;
          prmH00072 = new Object[] {
          new Object[] {"@AV5cPesCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cPesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@AV7cPesDat",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cPesEnd",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV9cPesTel",SqlDbType.VarChar,14,0} ,
          new Object[] {"@AV10cPesCe",SqlDbType.VarChar,14,0} ,
          new Object[] {"@AV11cPesSi",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmH00073 ;
          prmH00073 = new Object[] {
          new Object[] {"@AV5cPesCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cPesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@AV7cPesDat",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8cPesEnd",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV9cPesTel",SqlDbType.VarChar,14,0} ,
          new Object[] {"@AV10cPesCe",SqlDbType.VarChar,14,0} ,
          new Object[] {"@AV11cPesSi",SqlDbType.SmallInt,1,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("H00072", "SELECT [PesEndNumero], [PesTelefone], [PesCelular], [PesSituacao], [PesDatNasc], [PesCPF], [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE ([PesCodigo] >= @AV5cPesCod) AND ([PesCPF] like @AV6cPesCPF) AND ([PesDatNasc] >= @AV7cPesDat) AND ([PesEndNumero] like @AV8cPesEnd) AND ([PesTelefone] like @AV9cPesTel) AND ([PesCelular] like @AV10cPesCe) AND ([PesSituacao] >= @AV11cPesSi) ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00072,11,0,false,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("H00073", "SELECT COUNT(*) FROM [PESSOA] WITH (NOLOCK) WHERE ([PesCodigo] >= @AV5cPesCod) AND ([PesCPF] like @AV6cPesCPF) AND ([PesDatNasc] >= @AV7cPesDat) AND ([PesEndNumero] like @AV8cPesEnd) AND ([PesTelefone] like @AV9cPesTel) AND ([PesCelular] like @AV10cPesCe) AND ([PesSituacao] >= @AV11cPesSi) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00073,1,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((int[]) buf[12])[0] = rslt.getInt(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
