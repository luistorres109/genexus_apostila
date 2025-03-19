/*
               File: Categoria
        Description: Cadastro de Categorias
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:35.4
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
   public class tcategoria : GXHttpHandler
   {
      protected void INITENV( )
      {
         if ( ( GxWebError != 0 ) )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initpars( ) ;
         gxajaxcallmode = 0 ;
         gxfirstwebparm = GetNextPar( ) ;
         lblTextblock1_Name = "Textblock1" ;
         lblTextblock2_Name = "Textblock2" ;
         initialize_properties( ) ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "9_0_7-910", 0) ;
         Form.Meta.addItem("Description", "Cadastro de Categorias", 0) ;
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
         GX_FocusControl = edtCatCodigo_Internalname ;
         wbErr = false ;
      }

      public tcategoria( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tcategoria( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            UserMain( ) ;
            Draw( ) ;
         }
         this.cleanup();
      }

      protected void Draw( )
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
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            wb_table1_2_033( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_033e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            RenderHtmlCloseForm033( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_033( bool wbgen )
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
            WriteHtmlText( "<TD>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "3" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_first_Internalname, "|<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "4" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_previous_Internalname, "<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "5" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_next_Internalname, ">", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "6" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_last_Internalname, ">|", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "7" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_select_Internalname, "Select", "", "", StyleString, ClassString, 1, 1, 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "", "'HLP_TCategoria.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            ClassString = "S3" ;
            StyleString = "" + "" ;
            gx_msg_list2( "", context.GX_msglist.DisplayMode, StyleString, ClassString, false);
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            wb_table2_9_033( true) ;
         }
         return  ;
      }

      protected void wb_table2_9_033e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "16" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_enter_Internalname, "Apply Changes", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "17" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_check_Internalname, "Check", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "18" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_cancel_Internalname, "Close", "", "", StyleString, ClassString, 1, 1, 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "19" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_delete_Internalname, "Delete All", "", "", StyleString, ClassString, 1, bttBtn_delete_Enabled, 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "20" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_help_Internalname, "Help", "", "", StyleString, ClassString, 1, 1, 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "'HLP_TCategoria.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table1_2_033e( true) ;
         }
         else
         {
            wb_table1_2_033e( false) ;
         }
      }

      protected void wb_table2_9_033( bool wbgen )
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
            gx_label_ctrl( lblTextblock1_Internalname, 1, 1, 0, "Código da Categoria", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "'HLP_TCategoria.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "11" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCatCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33CatCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A33CatCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(11);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,true,null,'eng');"+"\"", 0, edtCatCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TCategoria.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "12" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_get_Internalname, "=>", "", "", StyleString, ClassString, 1, 1, 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "'HLP_TCategoria.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock2_Internalname, 1, 1, 0, "Nome da Categoria", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "'HLP_TCategoria.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "14" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCatNome_Internalname, StringUtil.RTrim( A34CatNome), 50, 50, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A34CatNome, "@!")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"this.value=this.value.toUpperCase();;GXOnBlur(14);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtCatNome_Jsonclick, "", 0, 0, 1, "'HLP_TCategoria.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table2_9_033e( true) ;
         }
         else
         {
            wb_table2_9_033e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(context.GetRequestMethod( ).TrimEnd(' '), "POST".TrimEnd(' ') ) == 0 ) )
            {
               /* Read saved values. */
               Z33CatCodi = (int)(NumberUtil.CToN( cgiGet( "Z33CatCodi"), "", "")) ;
               Z34CatNome = GXUtil.ValueDecode( cgiGet( "Z34CatNome")) ;
               IsConfirmed = (short)(NumberUtil.CToN( cgiGet( "IsConfirmed"), "", "")) ;
               IsModified = (short)(NumberUtil.CToN( cgiGet( "IsModified"), "", "")) ;
               Gx_mode = GXUtil.ValueDecode( cgiGet( "Mode")) ;
               context.sCallerURL = GXUtil.ValueDecode( cgiGet( "sCallerURL")) ;
               /* Read subfile selected row values. */
               /* Read variables values. */
               if ( ( ( NumberUtil.CToN( cgiGet( edtCatCodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtCatCodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtCatCodigo_Internalname ;
                  wbErr = true ;
                  A33CatCodi = (int)(0M) ;
                  n33CatCodi = false ;
               }
               else
               {
                  A33CatCodi = (int)(NumberUtil.CToN( cgiGet( edtCatCodigo_Internalname), "", "")) ;
                  n33CatCodi = false ;
               }
               A34CatNome = StringUtil.Upper( cgiGet( edtCatNome_Internalname)) ;
               n34CatNome = false ;
               n34CatNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A34CatNome).TrimEnd(' ') )==0)) ? true : false) ;
               /* Read hidden variables. */
               /* Read hidden properties. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               context.sCallerURL = context.GetReferer( ) ;
               Gx_mode = "INS" ;
               standaloneModal( ) ;
            }
         }
      }

      protected void Process( )
      {
         if ( ( String.CompareOrdinal(context.GetRequestMethod( ).TrimEnd(' '), "POST".TrimEnd(' ') ) == 0 ) )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( ( StringUtil.Len( sEvt) > 0 ) )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( ( String.CompareOrdinal(sEvtType.TrimEnd(' '), "E".TrimEnd(' ') ) == 0 ) )
               {
                  sEvtType = StringUtil.Right( sEvt, 1) ;
                  if ( ( String.CompareOrdinal(sEvtType.TrimEnd(' '), ".".TrimEnd(' ') ) == 0 ) )
                  {
                     sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                     if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "FIRST".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_first( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "PREVIOUS".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_previous( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "NEXT".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_next( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "LAST".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_last( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "SELECT".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_select( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "GET".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_get( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "ENTER".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_enter( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "CHECK".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_Check( ) ;
                     }
                     else if ( ( String.CompareOrdinal(sEvt.TrimEnd(' '), "DELETE".TrimEnd(' ') ) == 0 ) )
                     {
                        context.wbHandled = 1 ;
                        btn_delete( ) ;
                        /* No code required for Help button. It is implemented at the Browser level. */
                     }
                  }
                  else
                  {
                  }
               }
               context.wbHandled = 1 ;
            }
         }
      }

      protected void disable_std_buttons( )
      {
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("confdelete"), 0);
            }
            else
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("mustconfirm"), 0);
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( ( trnEnded == 1 ) )
         {
            trnEnded = 0 ;
            if ( ( context.nUserReturn == 1 ) )
            {
               return  ;
            }
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll033( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      protected void CONFIRM_030( )
      {
         BeforeValidate033( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls033( ) ;
            }
            else
            {
               CheckExtendedTable033( ) ;
               if ( ( AnyError == 0 ) )
               {
               }
               CloseExtendedTableCursors033( ) ;
            }
         }
         if ( ( AnyError == 0 ) )
         {
            IsConfirmed = 1 ;
         }
         if ( ( AnyError == 0 ) )
         {
            ConfirmValues030( ) ;
         }
      }

      protected void ResetCaption030( )
      {
         IsConfirmed = 0 ;
      }

      protected void ZM033( int GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z34CatNome = T00033_A34CatNome[0] ;
            }
            else
            {
               Z34CatNome = A34CatNome ;
            }
         }
         if ( ( GX_JID == -1 ) )
         {
            Z33CatCodi = A33CatCodi ;
            Z34CatNome = A34CatNome ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load033( )
      {
         /* Using cursor T00034 */
         pr_default.execute(2, new Object[] {n33CatCodi, A33CatCodi});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound3 = 1 ;
            A34CatNome = T00034_A34CatNome[0] ;
            n34CatNome = T00034_n34CatNome[0] ;
            ZM033( -1) ;
         }
         pr_default.close(2);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
      }

      protected void CheckExtendedTable033( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
         if ( ( IsConfirmed == 0 ) )
         {
            bttBtn_delete_Enabled = RcdFound3 ;
         }
         else
         {
            bttBtn_delete_Enabled = 0 ;
         }
      }

      protected void GetKey033( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {n33CatCodi, A33CatCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound3 = 1 ;
         }
         else
         {
            RcdFound3 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {n33CatCodi, A33CatCodi});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM033( 1) ;
            RcdFound3 = 1 ;
            A33CatCodi = T00033_A33CatCodi[0] ;
            n33CatCodi = T00033_n33CatCodi[0] ;
            A34CatNome = T00033_A34CatNome[0] ;
            n34CatNome = T00033_n34CatNome[0] ;
            Z33CatCodi = A33CatCodi ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load033( ) ;
            Gx_mode = sMode3 ;
         }
         else
         {
            RcdFound3 = 0 ;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode3 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( ( RcdFound3 == 0 ) )
         {
            Gx_mode = "INS" ;
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound3 = 0 ;
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {n33CatCodi, A33CatCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00036_A33CatCodi[0] < A33CatCodi ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00036_A33CatCodi[0] > A33CatCodi ) ) )
            {
               A33CatCodi = T00036_A33CatCodi[0] ;
               n33CatCodi = T00036_n33CatCodi[0] ;
               RcdFound3 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0 ;
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {n33CatCodi, A33CatCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00037_A33CatCodi[0] > A33CatCodi ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00037_A33CatCodi[0] < A33CatCodi ) ) )
            {
               A33CatCodi = T00037_A33CatCodi[0] ;
               n33CatCodi = T00037_n33CatCodi[0] ;
               RcdFound3 = 1 ;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey033( ) ;
         if ( ( RcdFound3 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCatCodigo_Internalname ;
            }
            else if ( ( A33CatCodi != Z33CatCodi ) )
            {
               A33CatCodi = Z33CatCodi ;
               n33CatCodi = false ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "CandidateKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCatCodigo_Internalname ;
            }
            else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               if ( ( IsConfirmed == 1 ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtCatCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "DLT" ;
                  /* Confirm record */
                  CONFIRM_030( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     GX_FocusControl = bttBtn_enter_Internalname ;
                  }
               }
            }
            else
            {
               Gx_mode = "UPD" ;
               if ( ( IsConfirmed == 1 ) )
               {
                  /* Update record */
                  Update033( ) ;
                  GX_FocusControl = edtCatCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_030( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     GX_FocusControl = bttBtn_enter_Internalname ;
                  }
               }
            }
         }
         else
         {
            if ( ( A33CatCodi != Z33CatCodi ) )
            {
               Gx_mode = "INS" ;
               if ( ( IsConfirmed == 1 ) )
               {
                  /* Insert record */
                  Insert033( ) ;
                  GX_FocusControl = edtCatCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_030( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     GX_FocusControl = bttBtn_enter_Internalname ;
                  }
               }
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("recdeleted"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtCatCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  if ( ( IsConfirmed == 1 ) )
                  {
                     /* Insert record */
                     Insert033( ) ;
                     GX_FocusControl = edtCatCodigo_Internalname ;
                  }
                  else
                  {
                     /* Confirm record */
                     CONFIRM_030( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        GX_FocusControl = bttBtn_enter_Internalname ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( A33CatCodi != Z33CatCodi ) )
         {
            A33CatCodi = Z33CatCodi ;
            n33CatCodi = false ;
            GX_msglist.addItem(GXResourceManager.GetMessage("getbeforedlt"), 1);
            AnyError = 1 ;
            GX_FocusControl = edtCatCodigo_Internalname ;
         }
         else
         {
            if ( ( IsConfirmed == 1 ) )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtCatCodigo_Internalname ;
            }
            else
            {
               Gx_mode = "DLT" ;
               /* Confirm record */
               CONFIRM_030( ) ;
               if ( ( AnyError == 0 ) )
               {
                  GX_FocusControl = bttBtn_enter_Internalname ;
               }
            }
         }
         if ( ( AnyError != 0 ) )
         {
            Gx_mode = "UPD" ;
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_Check( )
      {
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey033( ) ;
         if ( ( RcdFound3 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCatCodigo_Internalname ;
            }
            else if ( ( A33CatCodi != Z33CatCodi ) )
            {
               A33CatCodi = Z33CatCodi ;
               n33CatCodi = false ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCatCodigo_Internalname ;
            }
            else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD" ;
               update_Check( ) ;
            }
         }
         else
         {
            if ( ( A33CatCodi != Z33CatCodi ) )
            {
               Gx_mode = "INS" ;
               insert_Check( ) ;
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("recdeleted"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtCatCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(0);
         context.RollbackDataStores("TCategoria");
         GX_FocusControl = edtCatNome_Internalname ;
      }

      protected void insert_Check( )
      {
         CONFIRM_030( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( ( RcdFound3 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("keynfound"), "PrimaryKeyNotFound", 1);
            AnyError = 1 ;
         }
         GX_FocusControl = edtCatNome_Internalname ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart033( ) ;
         if ( ( RcdFound3 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCatNome_Internalname ;
         ScanEnd033( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( ( RcdFound3 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCatNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( ( RcdFound3 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCatNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart033( ) ;
         if ( ( RcdFound3 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            while ( ( RcdFound3 != 0 ) )
            {
               ScanNext033( ) ;
            }
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCatNome_Internalname ;
         ScanEnd033( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {n33CatCodi, A33CatCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("lock", new   object[]  {"CATEGORIA"}), "RecordIsLocked", 1);
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( String.CompareOrdinal(Z34CatNome.TrimEnd(' '), T00032_A34CatNome[0].TrimEnd(' ') ) != 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("waschg", new   object[]  {"CATEGORIA"}), "RecordWasChanged", 1);
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable033( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM033( 1) ;
            CheckOptimisticConcurrency033( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm033( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert033( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T00038 */
                     pr_default.execute(6, new Object[] {n34CatNome, A34CatNome});
                     pr_default.close(6);
                     /* Retrieving last key number assigned */
                     /* Using cursor T00039 */
                     pr_default.execute(7);
                     A33CatCodi = T00039_A33CatCodi[0] ;
                     n33CatCodi = T00039_n33CatCodi[0] ;
                     pr_default.close(7);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucadded"), 0);
                           ResetCaption030( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(GXResourceManager.GetMessage("unexp"), 1);
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable033( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm033( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate033( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000310 */
                     pr_default.execute(8, new Object[] {n34CatNome, A34CatNome, n33CatCodi, A33CatCodi});
                     pr_default.close(8);
                     DeferredUpdate033( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucupdated"), 0);
                           ResetCaption030( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(GXResourceManager.GetMessage("unexp"), 1);
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate033( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls033( ) ;
            /* No cascading delete specified. */
            AfterConfirm033( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete033( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000311 */
                  pr_default.execute(9, new Object[] {n33CatCodi, A33CatCodi});
                  pr_default.close(9);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        move_next( ) ;
                        if ( ( RcdFound3 == 0 ) )
                        {
                           InitAll033( ) ;
                           Gx_mode = "INS" ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                        }
                        GX_msglist.addItem(GXResourceManager.GetMessage("sucdeleted"), 0);
                        ResetCaption030( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(GXResourceManager.GetMessage("unexp"), 1);
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode3 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel033( ) ;
         Gx_mode = sMode3 ;
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000312 */
            pr_default.execute(10, new Object[] {n33CatCodi, A33CatCodi});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de Filmes"}), "CannotDeleteReferencedRecord", 1);
               AnyError = 1 ;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel033( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete033( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            pr_default.close(1);
            context.CommitDataStores("TCategoria");
            if ( ( AnyError == 0 ) )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("TCategoria");
         }
         IsModified = 0 ;
         if ( ( AnyError != 0 ) )
         {
            context.wjLoc = "" ;
         }
      }

      protected void ScanStart033( )
      {
         /* Using cursor T000313 */
         pr_default.execute(11);
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound3 = 1 ;
            A33CatCodi = T000313_A33CatCodi[0] ;
            n33CatCodi = T000313_n33CatCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         pr_default.readNext(11);
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound3 = 1 ;
            A33CatCodi = T000313_A33CatCodi[0] ;
            n33CatCodi = T000313_n33CatCodi[0] ;
         }
      }

      protected void ScanEnd033( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues030( )
      {
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
         WriteHtmlText( "Cadastro de Categorias") ;
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
         FormProcess = (true ? " onload=\"gxonload();"+"\""+" onkeyup=\"form_onkeyup(event)\" onkeypress=\"form_onkeypress(event,true,false)\" onkeydown=\"form_onkeypress(null,true,false)\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"" : "") ;
         WriteHtmlText( "<body") ;
         if ( ! ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( "").TrimEnd(' ') )==0)) ) )
         {
            WriteHtmlText( " background=\""+convertURL( "")+"\"") ;
         }
         WriteHtmlText( " "+"class"+" "+" bgcolor=\""+context.BuildHTMLColor( (int)(0xFFFFFF))+"\""+FormProcess+">") ;
         skipLines(1);
         WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return GXValidForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" ACTION=\""+formatLink("tcategoria.aspx") +"\""+">") ;
         gx_hidden_field( "_EventName", "");
         gx_hidden_field( "_EventGridId", "");
         gx_hidden_field( "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm033( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         gx_hidden_field( "Z33CatCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33CatCodi), 9, 0, ".", "")));
         gx_hidden_field( "Z34CatNome", StringUtil.RTrim( Z34CatNome));
         gx_hidden_field( "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         gx_hidden_field( "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         gx_hidden_field( "Mode", StringUtil.RTrim( Gx_mode));
         gx_hidden_field( "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         WriteHtmlTextNl( "</body>") ;
         WriteHtmlTextNl( "</html>") ;
      }

      protected void InitializeNonKey033( )
      {
         A34CatNome = "" ;
         n34CatNome = false ;
         n34CatNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A34CatNome).TrimEnd(' ') )==0)) ? true : false) ;
      }

      protected void InitAll033( )
      {
         A33CatCodi = 0 ;
         n33CatCodi = false ;
         InitializeNonKey033( ) ;
      }

      protected void StandaloneModalInsert( )
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
         WriteHtmlTextNl( "var GXBadNumMsg = \"The value is not a valid number.\";") ;
         if ( ( context.nUserReturn == 0 ) )
         {
            WriteHtmlTextNl( "var GXPARAMETERS = new Array();") ;
            WriteHtmlTextNl( "var wHGx0030=null;") ;
            WriteHtmlTextNl( "var wHGx0030=null;") ;
            WriteHtmlTextNl( "var GXISGET=false;") ;
            /* Set focus on 'active' control (if any). */
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( GX_FocusControl).TrimEnd(' ') )==0)) )
            {
               WriteHtmlTextNl( "GXSetUserFocus(document.forms[0]."+GX_FocusControl+");") ;
            }
            WriteHtmlTextNl( "function onCloseHGx0030()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0030(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0030== null || wHGx0030.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0030;") ;
            WriteHtmlTextNl( "GXISGET = false;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0030=open(\"") ;
            WriteHtmlText( "hgx0030.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0030.focus();") ;
            WriteHtmlTextNl( "if (isMod != null) GXSetRowModified(isMod);") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function onCloseHGx0030()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0030(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0030== null || wHGx0030.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0030;") ;
            WriteHtmlText( "document.forms[0]._EventName.value='"+"';") ;
            WriteHtmlTextNl( "GXISGET = true;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0030=open(\"") ;
            WriteHtmlText( "hgx0030.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0030.focus();") ;
            WriteHtmlTextNl( "if (isMod != null) GXSetRowModified(isMod);") ;
            WriteHtmlTextNl( "}") ;
         }
         else
         {
         }
         WriteHtmlTextNl( "function ClearNonKeyFields()") ;
         WriteHtmlTextNl( "{") ;
         WriteHtmlTextNl( "var obj = document.forms[0];") ;
         WriteHtmlTextNl( "window.GXPkIsDirty=false;") ;
         WriteHtmlTextNl( "obj."+"CATNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "}") ;
         WriteHtmlTextNl( "</script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "form_onchange.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "std_messages.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gx_help.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "tcategoria.js")+"\"></script>") ;
         /* End function include_jscripts */
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
            else if ( ( nJScriptCode == 4 ) )
            {
               sEventJsCode = "HGx0030(" + "document.forms[0]." + "CATCODIGO" + ");" + "return false;" ;
            }
            else if ( ( nJScriptCode == 6 ) )
            {
               sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" ;
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
            else if ( ( nJScriptCode == 4 ) )
            {
               sEventJsCode = "HGx0030(" + "document.forms[0]." + "CATCODIGO" + ");" ;
            }
            else if ( ( nJScriptCode == 6 ) )
            {
               sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" + "gxSubmit();" ;
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

      void gx_link_end( String sLinkURL )
      {
         if ( ( String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sLinkURL).TrimEnd(' ') ) != 0 ) )
         {
            WriteHtmlText( "</a>") ;
         }
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
                  else if ( ( nJScriptCode == 4 ) )
                  {
                     sEventJsCode = "HGx0030(" + "document.forms[0]." + "CATCODIGO" + ");" ;
                  }
                  else if ( ( nJScriptCode == 6 ) )
                  {
                     sEventJsCode = "gxdisableformnvis();GX_setevent('" + sEventName + "');" + "gxSubmit();" ;
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

      protected void initialize_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttBtn_select_Internalname = "BTN_SELECT" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtCatCodigo_Internalname = "CATCODIGO" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtCatNome_Internalname = "CATNOME" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         edtCatNome_Jsonclick = "" ;
         edtCatCodigo_Jsonclick = "" ;
         bttBtn_delete_Enabled = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         RcdFound3 = 0 ;
         GxWebError = 0 ;
         scmdbuf = "" ;
         gxajaxcallmode = 0 ;
         gxfirstwebparm = "" ;
         lblTextblock1_Name = "" ;
         lblTextblock2_Name = "" ;
         IsConfirmed = 0 ;
         IsModified = 0 ;
         AnyError = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         edtCatCodigo_Internalname = "" ;
         wbErr = false ;
         tblTable1_Internalname = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtn_first_Internalname = "" ;
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Internalname = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Internalname = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Internalname = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttBtn_select_Internalname = "" ;
         bttBtn_select_Jsonclick = "" ;
         bttBtn_enter_Internalname = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_check_Internalname = "" ;
         bttBtn_check_Jsonclick = "" ;
         bttBtn_cancel_Internalname = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Internalname = "" ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Jsonclick = "" ;
         bttBtn_help_Internalname = "" ;
         bttBtn_help_Jsonclick = "" ;
         tblTable2_Internalname = "" ;
         lblTextblock1_Internalname = "" ;
         lblTextblock1_Jsonclick = "" ;
         A33CatCodi = 0 ;
         edtCatCodigo_Jsonclick = "" ;
         bttBtn_get_Internalname = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock2_Internalname = "" ;
         lblTextblock2_Jsonclick = "" ;
         edtCatNome_Internalname = "" ;
         A34CatNome = "" ;
         edtCatNome_Jsonclick = "" ;
         Z33CatCodi = 0 ;
         Z34CatNome = "" ;
         Gx_mode = "" ;
         n33CatCodi = false ;
         n34CatNome = false ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GX_JID = 0 ;
         T00034_A33CatCodi = new int[1] ;
         T00034_n33CatCodi = new bool[] {false} ;
         T00034_A34CatNome = new String[] {""} ;
         T00034_n34CatNome = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00035_A33CatCodi = new int[1] ;
         T00035_n33CatCodi = new bool[] {false} ;
         T00033_A33CatCodi = new int[1] ;
         T00033_n33CatCodi = new bool[] {false} ;
         T00033_A34CatNome = new String[] {""} ;
         T00033_n34CatNome = new bool[] {false} ;
         sMode3 = "" ;
         T00036_A33CatCodi = new int[1] ;
         T00036_n33CatCodi = new bool[] {false} ;
         T00037_A33CatCodi = new int[1] ;
         T00037_n33CatCodi = new bool[] {false} ;
         T00032_A33CatCodi = new int[1] ;
         T00032_n33CatCodi = new bool[] {false} ;
         T00032_A34CatNome = new String[] {""} ;
         T00032_n34CatNome = new bool[] {false} ;
         T00039_A33CatCodi = new int[1] ;
         T00039_n33CatCodi = new bool[] {false} ;
         T000312_A28FilCodi = new int[1] ;
         T000313_A33CatCodi = new int[1] ;
         T000313_n33CatCodi = new bool[] {false} ;
         wbTemp = 0 ;
         idxLst = 0 ;
         addContentType = false ;
         sDynURL = "" ;
         FormProcess = "" ;
         Formheaderjscriptsrc = new GeneXus.Utils.GxStringCollection();
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tcategoria__default(),
            new Object[][] {
                new Object[] {
               T00032_A33CatCodi, T00032_A34CatNome, T00032_n34CatNome
               }
               , new Object[] {
               T00033_A33CatCodi, T00033_A34CatNome, T00033_n34CatNome
               }
               , new Object[] {
               T00034_A33CatCodi, T00034_A34CatNome, T00034_n34CatNome
               }
               , new Object[] {
               T00035_A33CatCodi
               }
               , new Object[] {
               T00036_A33CatCodi
               }
               , new Object[] {
               T00037_A33CatCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T00039_A33CatCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000312_A28FilCodi
               }
               , new Object[] {
               T000313_A33CatCodi
               }
            }
         );
      }

      private short RcdFound3 ;
      private short GxWebError ;
      private short gxajaxcallmode ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_delete_Enabled ;
      private int A33CatCodi ;
      private int Z33CatCodi ;
      private int GX_JID ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String lblTextblock1_Name ;
      private String lblTextblock2_Name ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtCatCodigo_Internalname ;
      private String tblTable1_Internalname ;
      private String sStyleString ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_check_Internalname ;
      private String bttBtn_check_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttBtn_help_Internalname ;
      private String bttBtn_help_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtCatCodigo_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtCatNome_Internalname ;
      private String edtCatNome_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode3 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char9 ;
      private bool wbErr ;
      private bool n33CatCodi ;
      private bool n34CatNome ;
      private bool addContentType ;
      private String A34CatNome ;
      private String Z34CatNome ;
      private GeneXus.Utils.GxStringCollection Formheaderjscriptsrc ;
      private GXWebForm Form ;
      private IDataReader T00032 ;
      private IDataReader T00033 ;
      private IGxDataStore dsDefault ;
      private IDataReader T00034 ;
      private IDataStoreProvider pr_default ;
      private int[] T00034_A33CatCodi ;
      private bool[] T00034_n33CatCodi ;
      private String[] T00034_A34CatNome ;
      private bool[] T00034_n34CatNome ;
      private IDataReader T00035 ;
      private int[] T00035_A33CatCodi ;
      private bool[] T00035_n33CatCodi ;
      private int[] T00033_A33CatCodi ;
      private bool[] T00033_n33CatCodi ;
      private String[] T00033_A34CatNome ;
      private bool[] T00033_n34CatNome ;
      private IDataReader T00036 ;
      private int[] T00036_A33CatCodi ;
      private bool[] T00036_n33CatCodi ;
      private IDataReader T00037 ;
      private int[] T00037_A33CatCodi ;
      private bool[] T00037_n33CatCodi ;
      private int[] T00032_A33CatCodi ;
      private bool[] T00032_n33CatCodi ;
      private String[] T00032_A34CatNome ;
      private bool[] T00032_n34CatNome ;
      private IDataReader T00039 ;
      private int[] T00039_A33CatCodi ;
      private bool[] T00039_n33CatCodi ;
      private IDataReader T000312 ;
      private int[] T000312_A28FilCodi ;
      private IDataReader T000313 ;
      private int[] T000313_A33CatCodi ;
      private bool[] T000313_n33CatCodi ;
   }

   public class tcategoria__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[3])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[4])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[5])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[6])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@CatNome",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@CatNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00032", "SELECT [CatCodigo], [CatNome] FROM [CATEGORIA] WITH (UPDLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00033", "SELECT [CatCodigo], [CatNome] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00034", "SELECT TM1.[CatCodigo], TM1.[CatNome] FROM [CATEGORIA] TM1 WITH (NOLOCK) WHERE TM1.[CatCodigo] = @CatCodigo ORDER BY TM1.[CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00035", "SELECT [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00036", "SELECT TOP 1 [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE ( [CatCodigo] > @CatCodigo) ORDER BY [CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00037", "SELECT TOP 1 [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) WHERE ( [CatCodigo] < @CatCodigo) ORDER BY [CatCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00038", "INSERT INTO [CATEGORIA] ([CatNome]) VALUES (@CatNome)", GxErrorMask.GX_NOMASK,prmT00038)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00039", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000310", "UPDATE [CATEGORIA] SET [CatNome]=@CatNome  WHERE [CatCodigo] = @CatCodigo", GxErrorMask.GX_NOMASK,prmT000310)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000311", "DELETE FROM [CATEGORIA]  WHERE [CatCodigo] = @CatCodigo", GxErrorMask.GX_NOMASK,prmT000311)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000312", "SELECT TOP 1 [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000312,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000313", "SELECT [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK) ORDER BY [CatCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000313,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 3 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
                }
                break;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
       }
    }

 }

}
