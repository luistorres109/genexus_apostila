/*
               File: Gx0030
        Description: Selection List Cadastro de Categorias
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:33.90
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
   public class hgx0030 : GXHttpHandler
   {
      public hgx0030( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public hgx0030( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pCatCodigo )
      {
         this.AV6pCatCod = 0 ;
         executePrivate();
         aP0_pCatCodigo=this.AV6pCatCod;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initpars( ) ;
         gxajaxcallmode = 0 ;
         if ( ( nGotPars == 0 ) )
         {
            gxfirstwebparm = GetNextPar( ) ;
            AV6pCatCod = (int)(NumberUtil.Val( gxfirstwebparm, "")) ;
         }
      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
         INITWEB( ) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            PA092( ) ;
            if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS092( ) ;
               if ( ( gxajaxcallmode == 0 ) )
               {
                  WE092( ) ;
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
         WriteHtmlText( "Selection List Cadastro de Categorias") ;
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
         WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return GXValidForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" ACTION=\""+formatLink("hgx0030.aspx") + "?" + UrlEncode("" +AV6pCatCod)+"\""+">") ;
         gx_hidden_field( "_EventName", "");
         gx_hidden_field( "_EventGridId", "");
         gx_hidden_field( "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm092( )
      {
         /* Send hidden variables. */
         gx_hidden_field( "GXH__CCATCODIGO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5cCatCod), 9, 0, ".", "")));
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

      protected void WB090( )
      {
         if ( ( wbLoad == false ) )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            WriteHtmlText( "<BODY>") ;
            wb_table1_3_092( true) ;
         }
         else
         {
            wb_table1_3_092( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_092e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</BODY>") ;
         }
         wbLoad = true ;
      }

      protected void START092( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         wbTemp = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "9_0_7-910", 0) ;
         Form.Meta.addItem("Description", "Selection List Cadastro de Categorias", 0) ;
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
         STRUP090( ) ;
      }

      protected void WS092( )
      {
         START092( ) ;
         EVT092( ) ;
      }

      protected void EVT092( )
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
                  if ( ( NumberUtil.CToN( cgiGet( "GXH__CCATCODIGO"), "", "") != Convert.ToDecimal( AV5cCatCod )) )
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
                           /* Execute user event: E11092 */
                           E11092 ();
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "'GXM_PREVIOUS'".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12092 */
                           E12092 ();
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "'GXM_NEXT'".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E13092 */
                           E13092 ();
                        }
                        else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "'GXM_LAST'".TrimEnd(' ') ) == 0 ) )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E14092 */
                           E14092 ();
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

      protected void WE092( )
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
               RenderHtmlCloseForm092( ) ;
            }
         }
      }

      protected void PA092( )
      {
         if ( ( nDonePA == 0 ) )
         {
            lblTextblock1_Name = "Textblock1" ;
            initialize_properties( ) ;
            GX_FocusControl = edtavCcatcodigo_Internalname ;
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void sendrow_102( )
      {
         WB090( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_10_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
                  if ( ( ((int)(nGXsfl_10_idx) % (2)) == 0 ) )
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
                  if ( ( ((int)(nGXsfl_10_idx/ (decimal)(1)) % (2)) - 1 == 0 ) )
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
            edtCatCodigo_Link = "javascript:GX_js_return"+"("+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A33CatCodi), 9, 0, ".", "")))+"')" ;
            gx_single_line_edit2( edtCatCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33CatCodi), 9, 0, ".", "")), 20, 9, 1, 0, 0, 0, 0, 0, edtCatCodigo_Link, "", StyleString, ClassString, ROClassString, StringUtil.Format( (decimal)(A33CatCodi), "ZZZZZZZZ9"), "", 0, edtCatCodigo_Jsonclick, "", 10, 0, 1, "'HLP_HGx0030.htm'");
            WriteHtmlTextNl( "</td>") ;
            WriteHtmlTextNl( "</tr>") ;
            nGXsfl_10_idx = (short)(nGXsfl_10_idx+1) ;
            sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
            edtCatCodigo_Internalname = "CATCODIGO_"+sGXsfl_10_idx ;
         }
         /* End function sendrow_102 */
      }

      protected void Refresh( )
      {
         RF092( ) ;
         /* End function Refresh */
      }

      protected void RF092( )
      {
         wbStart = 10 ;
         nGXsfl_10_idx = 1 ;
         sGXsfl_10_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)), 4, "0") ;
         edtCatCodigo_Internalname = "CATCODIGO_"+sGXsfl_10_idx ;
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( context.wjLoc).TrimEnd(' ') )==0)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00092 */
            pr_default.execute(0, new Object[] {AV5cCatCod});
            nGXsfl_10_idx = 1 ;
            Grid1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( nGXsfl_10_idx <= subGrid1_Recordsperpage( ) ) ) ) )
            {
               A33CatCodi = H00092_A33CatCodi[0] ;
               /* Execute user event: E15092 */
               E15092 ();
               pr_default.readNext(0);
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               Grid1_nEOF = 1 ;
            }
            pr_default.close(0);
            wbEnd = 10 ;
            WB090( ) ;
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
         /* Using cursor H00093 */
         pr_default.execute(1, new Object[] {AV5cCatCod});
         Grid1_nRecordCount = H00093_AGrid1_nRe[0] ;
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

      protected void STRUP090( )
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
            if ( ( ( NumberUtil.CToN( cgiGet( edtavCcatcodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtavCcatcodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
               GX_FocusControl = edtavCcatcodigo_Internalname ;
               wbErr = true ;
               AV5cCatCod = (int)(0M) ;
            }
            else
            {
               AV5cCatCod = (int)(NumberUtil.CToN( cgiGet( edtavCcatcodigo_Internalname), "", "")) ;
            }
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
         /* Execute user event: E16092 */
         E16092 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E16092( )
      {
         /* Enter Routine */
         AV6pCatCod = A33CatCodi ;
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void E11092( )
      {
         /* 'GXM_first' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E12092( )
      {
         /* 'GXM_previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E13092( )
      {
         /* 'GXM_next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E14092( )
      {
         /* 'GXM_last' Routine */
         subgrid1_lastpage( ) ;
      }

      private void E15092( )
      {
         /* Load Routine */
         if ( ( 10 == 0 ) || ( ( Grid1_nCurrentRecord >= Grid1_nFirstRecordOnPage ) && ( Grid1_nCurrentRecord < Grid1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_102( ) ;
         }
         Grid1_nCurrentRecord = (int)(Grid1_nCurrentRecord+1) ;
      }

      protected void wb_table1_3_092( bool wbgen )
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
            wb_table2_5_092( true) ;
         }
         else
         {
            wb_table2_5_092( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_092e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "12" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_first_Internalname, "|<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_first_Jsonclick, "E\\'GXM_FIRST\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(10), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)+");", "", "'HLP_HGx0030.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "13" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_previous_Internalname, "<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_previous_Jsonclick, "E\\'GXM_PREVIOUS\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(10), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)+");", "", "'HLP_HGx0030.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "14" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_next_Internalname, ">", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_next_Jsonclick, "E\\'GXM_NEXT\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(10), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)+");", "", "'HLP_HGx0030.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "15" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_last_Internalname, ">|", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_last_Jsonclick, "E\\'GXM_LAST\\'.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(10), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)+");", "", "'HLP_HGx0030.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD align=right>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "16" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_cancel_Internalname, "Close", "", "", StyleString, ClassString, 1, 1, 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(10), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)+");", "", "'HLP_HGx0030.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "17" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_help_Internalname, "Help", "", "", StyleString, ClassString, 1, 1, 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(10), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)+");", "", "'HLP_HGx0030.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table1_3_092e( true) ;
         }
         else
         {
            wb_table1_3_092e( false) ;
         }
      }

      protected void wb_table2_5_092( bool wbgen )
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
            gx_label_ctrl( lblTextblock1_Internalname, 1, 1, 0, "Código da Categoria", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "'HLP_HGx0030.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "\" gxrow=\"" + sGXsfl_10_idx + "\"" + " onFocus=\"gxonfocus2(this, " + "7" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtavCcatcodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5cCatCod), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(AV5cCatCod), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(7);\"", 0, edtavCcatcodigo_Jsonclick, "", 0, 0, 1, "'HLP_HGx0030.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD align=right>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "8" + "," + "''" + "," + "10" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_refresh_Internalname, "Search", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_refresh_Jsonclick, "EREFRESH.", TempTags, "GX_setgridevent("+StringUtil.Str( (decimal)(10), 3, 0)+","+StringUtil.Str( (decimal)(nGXsfl_10_idx), 4, 0)+");", "", "'HLP_HGx0030.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD colspan=3>") ;
         }
         if ( ( wbStart == 10 ) )
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
                  if ( ( ((int)(nGXsfl_10_idx) % (2)) == 0 ) )
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
                  if ( ( ((int)(nGXsfl_10_idx/ (decimal)(1)) % (2)) - 1 == 0 ) )
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
            SendWebValue( "Código da Categoria") ;
            WriteHtmlTextNl( "</th>") ;
            WriteHtmlTextNl( "</tr>") ;
         }
         if ( ( wbEnd == 10 ) )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_10_idx-1) ;
            /* Subfile end */
            WriteHtmlText( "</table>") ;
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table2_5_092e( true) ;
         }
         else
         {
            wb_table2_5_092e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6pCatCod = Convert.ToInt32(obj[0]) ;
      }

      public override String getresponse( String sGXDynURL )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         PA092( ) ;
         WS092( ) ;
         WE092( ) ;
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
         WriteHtmlTextNl( "function GX_js_return( pCatCodigo) {if (opener != null) {if (opener.GXPARAMETERS != null) {") ;
         WriteHtmlTextNl( "GXAssignPromptField(0,pCatCodigo);") ;
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
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gx_help.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "hgx0030.js")+"\"></script>") ;
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

      protected void initialize_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavCcatcodigo_Internalname = "_CCATCODIGO" ;
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
         edtavCcatcodigo_Jsonclick = "" ;
         edtCatCodigo_Jsonclick = "" ;
         subGrid1_Backstyle = 1 ;
         edtCatCodigo_Link = "" ;
         subGrid1_Backcolorstyle = 2 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         this.AV6pCatCod = AV6pCatCod;
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
         AV6pCatCod = 0 ;
         GxWebError = 0 ;
         wbTemp = 0 ;
         idxLst = 0 ;
         Form = new GXWebForm();
         addContentType = false ;
         sDynURL = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         FormProcess = "" ;
         AV5cCatCod = 0 ;
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
         GX_FocusControl = "" ;
         edtavCcatcodigo_Internalname = "" ;
         subGrid1_Backcolorstyle = 0 ;
         subGrid1_Backstyle = 0 ;
         subGrid1_Backcolor = 0 ;
         subGrid1_Allbackcolor = 0 ;
         ClassString = "" ;
         StyleString = "" ;
         ROClassString = "" ;
         edtCatCodigo_Link = "" ;
         A33CatCodi = 0 ;
         edtCatCodigo_Internalname = "" ;
         edtCatCodigo_Jsonclick = "" ;
         scmdbuf = "" ;
         H00092_A33CatCodi = new int[1] ;
         Grid1_nRecordCount = 0 ;
         H00093_AGrid1_nRe = new int[1] ;
         nDoneStart = 0 ;
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
         edtavCcatcodigo_Jsonclick = "" ;
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
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hgx0030__default(),
            new Object[][] {
                new Object[] {
               H00092_A33CatCodi
               }
               , new Object[] {
               H00093_AGrid1_nRe
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
      private short nRC_Grid1 ;
      private short Grid1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short nGXsfl_10_idx=1 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Backstyle ;
      private short nDoneStart ;
      private short subGrid1_Titlebackstyle ;
      private short nGXWrapped ;
      private int AV6pCatCod ;
      private int idxLst ;
      private int AV5cCatCod ;
      private int Grid1_nFirstRecordOnPage ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int A33CatCodi ;
      private int Grid1_nRecordCount ;
      private int Grid1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private String gxfirstwebparm ;
      private String sDynURL ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String FormProcess ;
      private String sPrefix ;
      private String GXSUBMITID ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String lblTextblock1_Name ;
      private String GX_FocusControl ;
      private String edtavCcatcodigo_Internalname ;
      private String sClassString ;
      private String sStyleString ;
      private String ClassString ;
      private String StyleString ;
      private String ROClassString ;
      private String edtCatCodigo_Link ;
      private String edtCatCodigo_Internalname ;
      private String edtCatCodigo_Jsonclick ;
      private String sGXsfl_10_idx="0001" ;
      private String scmdbuf ;
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
      private String edtavCcatcodigo_Jsonclick ;
      private String bttBtn_refresh_Internalname ;
      private String bttBtn_refresh_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char8 ;
      private bool addContentType ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GeneXus.Utils.GxStringCollection Formheaderjscriptsrc ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataReader H00092 ;
      private IDataStoreProvider pr_default ;
      private int[] H00092_A33CatCodi ;
      private IDataReader H00093 ;
      private int[] H00093_AGrid1_nRe ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pCatCodigo ;
   }

   public class hgx0030__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00092 ;
          prmH00092 = new Object[] {
          new Object[] {"@AV5cCatCod",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00093 ;
          prmH00093 = new Object[] {
          new Object[] {"@AV5cCatCod",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("H00092", "SELECT [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] >= @AV5cCatCod ORDER BY [CatCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00092,11,0,false,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("H00093", "SELECT COUNT(*) FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] >= @AV5cCatCod ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00093,1,0,false,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
