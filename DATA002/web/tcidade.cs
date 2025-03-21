/*
               File: Cidade
        Description: Cadastro de Cidades
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:35.51
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
   public class tcidade : GXHttpHandler
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
         if ( ( String.CompareOrdinal(gxfirstwebparm.TrimEnd(' '), "gxajaxExecAct_"+"gxLoad_2".TrimEnd(' ') ) == 0 ) )
         {
            A23EstCodi = (int)(NumberUtil.Val( GetNextPar( ), "")) ;
            n23EstCodi = false ;
            gxajaxcallmode = 1 ;
            gxLoad_2( A23EstCodi) ;
            return  ;
         }
         lblTextblock1_Name = "Textblock1" ;
         lblTextblock2_Name = "Textblock2" ;
         lblTextblock3_Name = "Textblock3" ;
         lblTextblock4_Name = "Textblock4" ;
         lblTextblock5_Name = "Textblock5" ;
         initialize_properties( ) ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "9_0_7-910", 0) ;
         Form.Meta.addItem("Description", "Cadastro de Cidades", 0) ;
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
         GX_FocusControl = edtCidCodigo_Internalname ;
         wbErr = false ;
      }

      public tcidade( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tcidade( IGxContext context )
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
            wb_table1_2_055( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_055e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            RenderHtmlCloseForm055( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_055( bool wbgen )
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
            gx_button_ctrl2( 1, bttBtn_first_Internalname, "|<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "4" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_previous_Internalname, "<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "5" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_next_Internalname, ">", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "6" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_last_Internalname, ">|", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "7" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_select_Internalname, "Select", "", "", StyleString, ClassString, 1, 1, 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "", "'HLP_TCidade.htm'");
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
            wb_table2_9_055( true) ;
         }
         return  ;
      }

      protected void wb_table2_9_055e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "22" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_enter_Internalname, "Apply Changes", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "23" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_check_Internalname, "Check", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "24" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_cancel_Internalname, "Close", "", "", StyleString, ClassString, 1, 1, 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "25" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_delete_Internalname, "Delete All", "", "", StyleString, ClassString, 1, bttBtn_delete_Enabled, 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "26" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_help_Internalname, "Help", "", "", StyleString, ClassString, 1, 1, 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table1_2_055e( true) ;
         }
         else
         {
            wb_table1_2_055e( false) ;
         }
      }

      protected void wb_table2_9_055( bool wbgen )
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
            gx_label_ctrl( lblTextblock1_Internalname, 1, 1, 0, "Código da Cidade", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "11" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCidCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A26CidCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A26CidCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(11);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,true,null,'eng');"+"\"", 0, edtCidCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TCidade.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "12" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_get_Internalname, "=>", "", "", StyleString, ClassString, 1, 1, 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock2_Internalname, 1, 1, 0, "Nome da Cidade", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "14" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCidNome_Internalname, StringUtil.RTrim( A27CidNome), 50, 50, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A27CidNome, "@!")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"this.value=this.value.toUpperCase();;GXOnBlur(14);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtCidNome_Jsonclick, "", 0, 0, 1, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock3_Internalname, 1, 1, 0, "Código do Estado", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "16" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtEstCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23EstCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A23EstCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(16);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtEstCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TCidade.htm'");
            /* Static images/pictures */
            ClassString = "S8" ;
            StyleString = "" + "" ;
            gx_bitmap( imgprompt_23_Internalname, "", "prompt.gif", 1, 0, "", "", 0, 0, 0, 0, 0, 0, imgprompt_23_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock4_Internalname, 1, 1, 0, "UF do Estado", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtEstUF_Internalname, StringUtil.RTrim( A24EstUF), 2, 2, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A24EstUF, "@!")), "", 0, edtEstUF_Jsonclick, "", 0, 0, 1, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock5_Internalname, 1, 1, 0, "Nome do Estado", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtEstNome_Internalname, StringUtil.RTrim( A25EstNome), 50, 50, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A25EstNome, "@!")), "", 0, edtEstNome_Jsonclick, "", 0, 0, 1, "'HLP_TCidade.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table2_9_055e( true) ;
         }
         else
         {
            wb_table2_9_055e( false) ;
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
               Z26CidCodi = (int)(NumberUtil.CToN( cgiGet( "Z26CidCodi"), "", "")) ;
               Z27CidNome = GXUtil.ValueDecode( cgiGet( "Z27CidNome")) ;
               Z23EstCodi = (int)(NumberUtil.CToN( cgiGet( "Z23EstCodi"), "", "")) ;
               IsConfirmed = (short)(NumberUtil.CToN( cgiGet( "IsConfirmed"), "", "")) ;
               IsModified = (short)(NumberUtil.CToN( cgiGet( "IsModified"), "", "")) ;
               Gx_mode = GXUtil.ValueDecode( cgiGet( "Mode")) ;
               context.sCallerURL = GXUtil.ValueDecode( cgiGet( "sCallerURL")) ;
               /* Read subfile selected row values. */
               /* Read variables values. */
               if ( ( ( NumberUtil.CToN( cgiGet( edtCidCodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtCidCodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtCidCodigo_Internalname ;
                  wbErr = true ;
                  A26CidCodi = (int)(0M) ;
                  n26CidCodi = false ;
               }
               else
               {
                  A26CidCodi = (int)(NumberUtil.CToN( cgiGet( edtCidCodigo_Internalname), "", "")) ;
                  n26CidCodi = false ;
               }
               A27CidNome = StringUtil.Upper( cgiGet( edtCidNome_Internalname)) ;
               n27CidNome = false ;
               n27CidNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A27CidNome).TrimEnd(' ') )==0)) ? true : false) ;
               if ( ( ( NumberUtil.CToN( cgiGet( edtEstCodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtEstCodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtEstCodigo_Internalname ;
                  wbErr = true ;
                  A23EstCodi = (int)(0M) ;
                  n23EstCodi = false ;
               }
               else
               {
                  A23EstCodi = (int)(NumberUtil.CToN( cgiGet( edtEstCodigo_Internalname), "", "")) ;
                  n23EstCodi = false ;
               }
               n23EstCodi = (((0==A23EstCodi)) ? true : false) ;
               A24EstUF = StringUtil.Upper( cgiGet( edtEstUF_Internalname)) ;
               n24EstUF = false ;
               A25EstNome = StringUtil.Upper( cgiGet( edtEstNome_Internalname)) ;
               n25EstNome = false ;
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
               InitAll055( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      protected void CONFIRM_050( )
      {
         BeforeValidate055( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls055( ) ;
            }
            else
            {
               CheckExtendedTable055( ) ;
               if ( ( AnyError == 0 ) )
               {
                  ZM055( 2) ;
               }
               CloseExtendedTableCursors055( ) ;
            }
         }
         if ( ( AnyError == 0 ) )
         {
            IsConfirmed = 1 ;
         }
         if ( ( AnyError == 0 ) )
         {
            ConfirmValues050( ) ;
         }
      }

      protected void ResetCaption050( )
      {
         IsConfirmed = 0 ;
      }

      protected void ZM055( int GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z27CidNome = T00053_A27CidNome[0] ;
               Z23EstCodi = T00053_A23EstCodi[0] ;
            }
            else
            {
               Z27CidNome = A27CidNome ;
               Z23EstCodi = A23EstCodi ;
            }
         }
         if ( ( GX_JID == -1 ) )
         {
            Z26CidCodi = A26CidCodi ;
            Z27CidNome = A27CidNome ;
            Z23EstCodi = A23EstCodi ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_23_Link = ((String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') )==0) ? "" : "javascript:"+"HGx0040("+"document.forms[0]."+"ESTCODIGO"+");") ;
      }

      protected void standaloneModal( )
      {
      }

      protected void Load055( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1 ;
            A27CidNome = T00055_A27CidNome[0] ;
            n27CidNome = T00055_n27CidNome[0] ;
            A24EstUF = T00055_A24EstUF[0] ;
            n24EstUF = T00055_n24EstUF[0] ;
            A25EstNome = T00055_A25EstNome[0] ;
            n25EstNome = T00055_n25EstNome[0] ;
            A23EstCodi = T00055_A23EstCodi[0] ;
            n23EstCodi = T00055_n23EstCodi[0] ;
            ZM055( -1) ;
         }
         pr_default.close(3);
         OnLoadActions055( ) ;
      }

      protected void OnLoadActions055( )
      {
      }

      protected void CheckExtendedTable055( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {n23EstCodi, A23EstCodi});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( ((0==A23EstCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Estados'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtEstCodigo_Internalname ;
            }
         }
         A24EstUF = T00054_A24EstUF[0] ;
         n24EstUF = T00054_n24EstUF[0] ;
         A25EstNome = T00054_A25EstNome[0] ;
         n25EstNome = T00054_n25EstNome[0] ;
         pr_default.close(2);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors055( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
         if ( ( IsConfirmed == 0 ) )
         {
            bttBtn_delete_Enabled = RcdFound5 ;
         }
         else
         {
            bttBtn_delete_Enabled = 0 ;
         }
      }

      protected void gxLoad_2( int A23EstCodi )
      {
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {n23EstCodi, A23EstCodi});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( ((0==A23EstCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Estados'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtEstCodigo_Internalname ;
            }
         }
         A24EstUF = T00056_A24EstUF[0] ;
         n24EstUF = T00056_n24EstUF[0] ;
         A25EstNome = T00056_A25EstNome[0] ;
         n25EstNome = T00056_n25EstNome[0] ;
         wbTemp = context.ResponseContentType( "text/html") ;
         wbTemp = context.SetHeader( "pragma", "no-cache") ;
         context.GX_webresponse.AppendHeader("Content-Type", "text/plain;charset=utf-8");
         wbTemp = context.SetHeader( "Cache-Control", "max-age=0") ;
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A24EstUF))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A25EstNome))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey055( )
      {
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound5 = 1 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM055( 1) ;
            RcdFound5 = 1 ;
            A26CidCodi = T00053_A26CidCodi[0] ;
            n26CidCodi = T00053_n26CidCodi[0] ;
            A27CidNome = T00053_A27CidNome[0] ;
            n27CidNome = T00053_n27CidNome[0] ;
            A23EstCodi = T00053_A23EstCodi[0] ;
            n23EstCodi = T00053_n23EstCodi[0] ;
            Z26CidCodi = A26CidCodi ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load055( ) ;
            Gx_mode = sMode5 ;
         }
         else
         {
            RcdFound5 = 0 ;
            InitializeNonKey055( ) ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode5 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey055( ) ;
         if ( ( RcdFound5 == 0 ) )
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
         RcdFound5 = 0 ;
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00058_A26CidCodi[0] < A26CidCodi ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00058_A26CidCodi[0] > A26CidCodi ) ) )
            {
               A26CidCodi = T00058_A26CidCodi[0] ;
               n26CidCodi = T00058_n26CidCodi[0] ;
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0 ;
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00059_A26CidCodi[0] > A26CidCodi ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00059_A26CidCodi[0] < A26CidCodi ) ) )
            {
               A26CidCodi = T00059_A26CidCodi[0] ;
               n26CidCodi = T00059_n26CidCodi[0] ;
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey055( ) ;
         if ( ( RcdFound5 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCidCodigo_Internalname ;
            }
            else if ( ( A26CidCodi != Z26CidCodi ) )
            {
               A26CidCodi = Z26CidCodi ;
               n26CidCodi = false ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "CandidateKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCidCodigo_Internalname ;
            }
            else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               if ( ( IsConfirmed == 1 ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtCidCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "DLT" ;
                  /* Confirm record */
                  CONFIRM_050( ) ;
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
                  Update055( ) ;
                  GX_FocusControl = edtCidCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_050( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     GX_FocusControl = bttBtn_enter_Internalname ;
                  }
               }
            }
         }
         else
         {
            if ( ( A26CidCodi != Z26CidCodi ) )
            {
               Gx_mode = "INS" ;
               if ( ( IsConfirmed == 1 ) )
               {
                  /* Insert record */
                  Insert055( ) ;
                  GX_FocusControl = edtCidCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_050( ) ;
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
                  GX_FocusControl = edtCidCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  if ( ( IsConfirmed == 1 ) )
                  {
                     /* Insert record */
                     Insert055( ) ;
                     GX_FocusControl = edtCidCodigo_Internalname ;
                  }
                  else
                  {
                     /* Confirm record */
                     CONFIRM_050( ) ;
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
         if ( ( A26CidCodi != Z26CidCodi ) )
         {
            A26CidCodi = Z26CidCodi ;
            n26CidCodi = false ;
            GX_msglist.addItem(GXResourceManager.GetMessage("getbeforedlt"), 1);
            AnyError = 1 ;
            GX_FocusControl = edtCidCodigo_Internalname ;
         }
         else
         {
            if ( ( IsConfirmed == 1 ) )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtCidCodigo_Internalname ;
            }
            else
            {
               Gx_mode = "DLT" ;
               /* Confirm record */
               CONFIRM_050( ) ;
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
         GetKey055( ) ;
         if ( ( RcdFound5 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCidCodigo_Internalname ;
            }
            else if ( ( A26CidCodi != Z26CidCodi ) )
            {
               A26CidCodi = Z26CidCodi ;
               n26CidCodi = false ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCidCodigo_Internalname ;
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
            if ( ( A26CidCodi != Z26CidCodi ) )
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
                  GX_FocusControl = edtCidCodigo_Internalname ;
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
         context.RollbackDataStores("TCidade");
         GX_FocusControl = edtCidNome_Internalname ;
      }

      protected void insert_Check( )
      {
         CONFIRM_050( ) ;
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
         if ( ( RcdFound5 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("keynfound"), "PrimaryKeyNotFound", 1);
            AnyError = 1 ;
         }
         GX_FocusControl = edtCidNome_Internalname ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart055( ) ;
         if ( ( RcdFound5 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCidNome_Internalname ;
         ScanEnd055( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( ( RcdFound5 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCidNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( ( RcdFound5 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCidNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart055( ) ;
         if ( ( RcdFound5 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            while ( ( RcdFound5 != 0 ) )
            {
               ScanNext055( ) ;
            }
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtCidNome_Internalname ;
         ScanEnd055( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency055( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {n26CidCodi, A26CidCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("lock", new   object[]  {"CIDADE"}), "RecordIsLocked", 1);
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( String.CompareOrdinal(Z27CidNome.TrimEnd(' '), T00052_A27CidNome[0].TrimEnd(' ') ) != 0 ) || ( Z23EstCodi != T00052_A23EstCodi[0] ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("waschg", new   object[]  {"CIDADE"}), "RecordWasChanged", 1);
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert055( )
      {
         BeforeValidate055( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable055( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM055( 1) ;
            CheckOptimisticConcurrency055( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm055( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert055( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000510 */
                     pr_default.execute(8, new Object[] {n27CidNome, A27CidNome, n23EstCodi, A23EstCodi});
                     pr_default.close(8);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000511 */
                     pr_default.execute(9);
                     A26CidCodi = T000511_A26CidCodi[0] ;
                     n26CidCodi = T000511_n26CidCodi[0] ;
                     pr_default.close(9);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucadded"), 0);
                           ResetCaption050( ) ;
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
               Load055( ) ;
            }
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void Update055( )
      {
         BeforeValidate055( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable055( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency055( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm055( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate055( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000512 */
                     pr_default.execute(10, new Object[] {n27CidNome, A27CidNome, n23EstCodi, A23EstCodi, n26CidCodi, A26CidCodi});
                     pr_default.close(10);
                     DeferredUpdate055( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucupdated"), 0);
                           ResetCaption050( ) ;
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
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void DeferredUpdate055( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate055( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency055( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls055( ) ;
            /* No cascading delete specified. */
            AfterConfirm055( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete055( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000513 */
                  pr_default.execute(11, new Object[] {n26CidCodi, A26CidCodi});
                  pr_default.close(11);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        move_next( ) ;
                        if ( ( RcdFound5 == 0 ) )
                        {
                           InitAll055( ) ;
                           Gx_mode = "INS" ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                        }
                        GX_msglist.addItem(GXResourceManager.GetMessage("sucdeleted"), 0);
                        ResetCaption050( ) ;
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
         sMode5 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel055( ) ;
         Gx_mode = sMode5 ;
      }

      protected void OnDeleteControls055( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000514 */
            pr_default.execute(12, new Object[] {n23EstCodi, A23EstCodi});
            A24EstUF = T000514_A24EstUF[0] ;
            n24EstUF = T000514_n24EstUF[0] ;
            A25EstNome = T000514_A25EstNome[0] ;
            n25EstNome = T000514_n25EstNome[0] ;
            pr_default.close(12);
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000515 */
            pr_default.execute(13, new Object[] {n26CidCodi, A26CidCodi});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de Pessoas"}), "CannotDeleteReferencedRecord", 1);
               AnyError = 1 ;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel055( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete055( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("TCidade");
            if ( ( AnyError == 0 ) )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("TCidade");
         }
         IsModified = 0 ;
         if ( ( AnyError != 0 ) )
         {
            context.wjLoc = "" ;
         }
      }

      protected void ScanStart055( )
      {
         /* Using cursor T000516 */
         pr_default.execute(14);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound5 = 1 ;
            A26CidCodi = T000516_A26CidCodi[0] ;
            n26CidCodi = T000516_n26CidCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext055( )
      {
         pr_default.readNext(14);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound5 = 1 ;
            A26CidCodi = T000516_A26CidCodi[0] ;
            n26CidCodi = T000516_n26CidCodi[0] ;
         }
      }

      protected void ScanEnd055( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm055( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert055( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate055( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete055( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete055( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate055( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
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
         WriteHtmlText( "Cadastro de Cidades") ;
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
         WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return GXValidForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" ACTION=\""+formatLink("tcidade.aspx") +"\""+">") ;
         gx_hidden_field( "_EventName", "");
         gx_hidden_field( "_EventGridId", "");
         gx_hidden_field( "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm055( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         gx_hidden_field( "Z26CidCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26CidCodi), 9, 0, ".", "")));
         gx_hidden_field( "Z27CidNome", StringUtil.RTrim( Z27CidNome));
         gx_hidden_field( "Z23EstCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z23EstCodi), 9, 0, ".", "")));
         gx_hidden_field( "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         gx_hidden_field( "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         gx_hidden_field( "Mode", StringUtil.RTrim( Gx_mode));
         gx_hidden_field( "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         WriteHtmlTextNl( "</body>") ;
         WriteHtmlTextNl( "</html>") ;
      }

      protected void InitializeNonKey055( )
      {
         A27CidNome = "" ;
         n27CidNome = false ;
         n27CidNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A27CidNome).TrimEnd(' ') )==0)) ? true : false) ;
         A23EstCodi = 0 ;
         n23EstCodi = false ;
         n23EstCodi = (((0==A23EstCodi)) ? true : false) ;
         A24EstUF = "" ;
         n24EstUF = false ;
         A25EstNome = "" ;
         n25EstNome = false ;
      }

      protected void InitAll055( )
      {
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         InitializeNonKey055( ) ;
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
            WriteHtmlTextNl( "var wHGx0040=null;") ;
            WriteHtmlTextNl( "var wHGx0050=null;") ;
            WriteHtmlTextNl( "var wHGx0050=null;") ;
            WriteHtmlTextNl( "var GXISGET=false;") ;
            /* Set focus on 'active' control (if any). */
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( GX_FocusControl).TrimEnd(' ') )==0)) )
            {
               WriteHtmlTextNl( "GXSetUserFocus(document.forms[0]."+GX_FocusControl+");") ;
            }
            WriteHtmlTextNl( "function onCloseHGx0040()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0040(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "if (!gxCheckControlConds('PROMPT_23', '_', 0, [16],isMod)) {return;}") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:false};") ;
            WriteHtmlTextNl( "if (wHGx0040== null || wHGx0040.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0040;") ;
            WriteHtmlTextNl( "GXISGET = false;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0040=open(\"") ;
            WriteHtmlText( "hgx0040.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0040.focus();") ;
            WriteHtmlTextNl( "if (isMod != null) GXSetRowModified(isMod);") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function onCloseHGx0050()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0050(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0050== null || wHGx0050.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0050;") ;
            WriteHtmlTextNl( "GXISGET = false;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0050=open(\"") ;
            WriteHtmlText( "hgx0050.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0050.focus();") ;
            WriteHtmlTextNl( "if (isMod != null) GXSetRowModified(isMod);") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function onCloseHGx0050()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0050(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0050== null || wHGx0050.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0050;") ;
            WriteHtmlText( "document.forms[0]._EventName.value='"+"';") ;
            WriteHtmlTextNl( "GXISGET = true;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0050=open(\"") ;
            WriteHtmlText( "hgx0050.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0050.focus();") ;
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
         WriteHtmlTextNl( "obj."+"CIDNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"ESTCODIGO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"ESTUF.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"ESTNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "}") ;
         WriteHtmlTextNl( "</script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "form_onchange.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "std_messages.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gx_help.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "tcidade.js")+"\"></script>") ;
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
               sEventJsCode = "HGx0050(" + "document.forms[0]." + "CIDCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0050(" + "document.forms[0]." + "CIDCODIGO" + ");" ;
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
                     sEventJsCode = "HGx0050(" + "document.forms[0]." + "CIDCODIGO" + ");" ;
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

      void gx_bitmap( String sInternalName ,
                      String sAccesskey ,
                      String sImageURL ,
                      int nVisible ,
                      int nEnabled ,
                      String sAlternateText ,
                      String sTooltipText ,
                      int nBorderWidth ,
                      int nAutoresize ,
                      int nWidth ,
                      int nHeight ,
                      int nVerticalSpace ,
                      int nHorizontalSpace ,
                      String sLinkURL ,
                      String sLinkTarget ,
                      int nJScriptCode ,
                      String sUserOnClickCode ,
                      String sEventName ,
                      String sStyleString ,
                      String sClassString ,
                      String sAlign ,
                      String sTags ,
                      String sUseMap ,
                      String sJsDynCode ,
                      String sCallerPgm )
      {
         String sEventJsCode ;
         String sCapAKey ;
         sEventJsCode = "" ;
         sCapAKey = GXUtil.AccessKey( sTooltipText) ;
         sTooltipText = GXUtil.AccessKeyCaption( sTooltipText) ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sCapAKey).TrimEnd(' ') )==0)) )
         {
            sAccesskey = sCapAKey ;
         }
         sStyleString = sStyleString + ((nVisible!=0) ? "" : ";display:none;") ;
         if ( ( nEnabled != 0 ) )
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
               sEventJsCode = "HGx0050(" + "document.forms[0]." + "CIDCODIGO" + ");" + "return false;" ;
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
         }
         if ( ( nEnabled == 0 ) )
         {
            if ( ( nEnabled != 0 ) )
            {
               gx_start_js_anchor( sEventJsCode, sUserOnClickCode, sLinkURL, sLinkTarget);
            }
            else
            {
               gx_link_start( sLinkURL, sLinkTarget);
            }
            WriteHtmlText( "<img src=\"") ;
            WriteHtmlText( convertURL( sImageURL)) ;
            WriteHtmlText( "\"") ;
         }
         else
         {
            if ( ( context.GetBrowserType( ) == 5 ) || ( context.GetBrowserType( ) == 2 ) && ( String.CompareOrdinal(context.GetBrowserVersion( ).TrimEnd(' '), "5.0".TrimEnd(' ') ) <= 0 ) )
            {
               WriteHtmlText( "<a href=\"#\"") ;
               gx_on_js_event( "onclick", sEventJsCode+((nJScriptCode==4) ? "" : "gxSubmit();"), sUserOnClickCode);
               WriteHtmlText( ">") ;
               WriteHtmlText( "<img src=\"") ;
               WriteHtmlText( convertURL( sImageURL)) ;
               WriteHtmlText( "\" name=\"") ;
               WriteHtmlText( sInternalName) ;
               WriteHtmlText( "\"") ;
            }
            else
            {
               WriteHtmlText( "<input type=\"image\" src=\"") ;
               WriteHtmlText( convertURL( sImageURL)) ;
               WriteHtmlText( "\" name=\"") ;
               WriteHtmlText( sInternalName) ;
               WriteHtmlText( "\"") ;
               gx_on_js_event( "onclick", sEventJsCode, sUserOnClickCode);
            }
         }
         if ( ( StringUtil.Len( sAccesskey) != 0 ) )
         {
            WriteHtmlText( " accesskey=\"") ;
            WriteHtmlText( sAccesskey) ;
            WriteHtmlText( "\"") ;
         }
         WriteHtmlText( " id=\"") ;
         WriteHtmlText( sInternalName) ;
         WriteHtmlText( "\"") ;
         if ( ! ((0==nVerticalSpace)) )
         {
            WriteHtmlText( " vspace=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nVerticalSpace), 10, 0))) ;
            WriteHtmlText( "\"") ;
         }
         if ( ! ((0==nHorizontalSpace)) )
         {
            WriteHtmlText( " hspace=\"") ;
            WriteHtmlText( StringUtil.LTrim( StringUtil.Str( (decimal)(nHorizontalSpace), 10, 0))) ;
            WriteHtmlText( "\"") ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sAlign).TrimEnd(' ') )==0)) )
         {
            WriteHtmlText( " align=\"") ;
            WriteHtmlText( StringUtil.LTrim( sAlign)) ;
            WriteHtmlText( "\"") ;
         }
         if ( ( StringUtil.Len( sClassString) == 0 ) || ( nBorderWidth > 0 ) )
         {
            WriteHtmlText( " border=\"") ;
            WriteHtmlText( StringUtil.Str( (decimal)(nBorderWidth), 3, 0)) ;
            WriteHtmlText( "\"") ;
            if ( ( StringUtil.Len( sClassString) > 0 ) )
            {
               sStyleString = sStyleString + ";border-width: " + StringUtil.Str( (decimal)(nBorderWidth), 3, 0) ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sAlternateText).TrimEnd(' ') )==0)) )
         {
            WriteHtmlText( " alt=\"") ;
            WriteHtmlText( sAlternateText) ;
            WriteHtmlText( "\"") ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sTooltipText).TrimEnd(' ') )==0)) )
         {
            WriteHtmlText( " title=\"") ;
            WriteHtmlText( sTooltipText) ;
            WriteHtmlText( "\"") ;
         }
         if ( ( nWidth > 0 ) )
         {
            sStyleString = sStyleString + ";width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nWidth), 10, 0)) ;
         }
         if ( ( nHeight > 0 ) )
         {
            sStyleString = sStyleString + ";height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(nHeight), 10, 0)) ;
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
         WriteHtmlText( sTags) ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sUseMap).TrimEnd(' ') )==0)) )
         {
            WriteHtmlText( " usemap=\"") ;
            WriteHtmlText( sUseMap) ;
            WriteHtmlText( "\"") ;
         }
         WriteHtmlText( "/>") ;
         if ( ( nEnabled == 0 ) )
         {
            if ( ( nEnabled != 0 ) )
            {
               gx_end_js_anchor( sEventJsCode, sUserOnClickCode, sLinkURL);
            }
            else
            {
               gx_link_end( sLinkURL);
            }
         }
         else
         {
            if ( ( context.GetBrowserType( ) == 5 ) || ( context.GetBrowserType( ) == 2 ) && ( String.CompareOrdinal(context.GetBrowserVersion( ).TrimEnd(' '), "5.0".TrimEnd(' ') ) <= 0 ) )
            {
               WriteHtmlText( "</a>") ;
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
         edtCidCodigo_Internalname = "CIDCODIGO" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtCidNome_Internalname = "CIDNOME" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtEstCodigo_Internalname = "ESTCODIGO" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtEstUF_Internalname = "ESTUF" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtEstNome_Internalname = "ESTNOME" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_23_Internalname = "PROMPT_23" ;
         edtEstNome_Jsonclick = "" ;
         edtEstUF_Jsonclick = "" ;
         imgprompt_23_Link = "" ;
         edtEstCodigo_Jsonclick = "" ;
         edtCidNome_Jsonclick = "" ;
         edtCidCodigo_Jsonclick = "" ;
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
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         RcdFound5 = 0 ;
         GxWebError = 0 ;
         scmdbuf = "" ;
         gxajaxcallmode = 0 ;
         gxfirstwebparm = "" ;
         A23EstCodi = 0 ;
         n23EstCodi = false ;
         lblTextblock1_Name = "" ;
         lblTextblock2_Name = "" ;
         lblTextblock3_Name = "" ;
         lblTextblock4_Name = "" ;
         lblTextblock5_Name = "" ;
         IsConfirmed = 0 ;
         IsModified = 0 ;
         AnyError = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         edtCidCodigo_Internalname = "" ;
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
         A26CidCodi = 0 ;
         edtCidCodigo_Jsonclick = "" ;
         bttBtn_get_Internalname = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock2_Internalname = "" ;
         lblTextblock2_Jsonclick = "" ;
         edtCidNome_Internalname = "" ;
         A27CidNome = "" ;
         edtCidNome_Jsonclick = "" ;
         lblTextblock3_Internalname = "" ;
         lblTextblock3_Jsonclick = "" ;
         edtEstCodigo_Internalname = "" ;
         edtEstCodigo_Jsonclick = "" ;
         imgprompt_23_Internalname = "" ;
         imgprompt_23_Link = "" ;
         lblTextblock4_Internalname = "" ;
         lblTextblock4_Jsonclick = "" ;
         edtEstUF_Internalname = "" ;
         A24EstUF = "" ;
         edtEstUF_Jsonclick = "" ;
         lblTextblock5_Internalname = "" ;
         lblTextblock5_Jsonclick = "" ;
         edtEstNome_Internalname = "" ;
         A25EstNome = "" ;
         edtEstNome_Jsonclick = "" ;
         Z26CidCodi = 0 ;
         Z27CidNome = "" ;
         Z23EstCodi = 0 ;
         Gx_mode = "" ;
         n26CidCodi = false ;
         n27CidNome = false ;
         n24EstUF = false ;
         n25EstNome = false ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GX_JID = 0 ;
         T00055_A26CidCodi = new int[1] ;
         T00055_n26CidCodi = new bool[] {false} ;
         T00055_A27CidNome = new String[] {""} ;
         T00055_n27CidNome = new bool[] {false} ;
         T00055_A24EstUF = new String[] {""} ;
         T00055_n24EstUF = new bool[] {false} ;
         T00055_A25EstNome = new String[] {""} ;
         T00055_n25EstNome = new bool[] {false} ;
         T00055_A23EstCodi = new int[1] ;
         T00055_n23EstCodi = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00054_A24EstUF = new String[] {""} ;
         T00054_n24EstUF = new bool[] {false} ;
         T00054_A25EstNome = new String[] {""} ;
         T00054_n25EstNome = new bool[] {false} ;
         T00056_A24EstUF = new String[] {""} ;
         T00056_n24EstUF = new bool[] {false} ;
         T00056_A25EstNome = new String[] {""} ;
         T00056_n25EstNome = new bool[] {false} ;
         wbTemp = 0 ;
         T00057_A26CidCodi = new int[1] ;
         T00057_n26CidCodi = new bool[] {false} ;
         T00053_A26CidCodi = new int[1] ;
         T00053_n26CidCodi = new bool[] {false} ;
         T00053_A27CidNome = new String[] {""} ;
         T00053_n27CidNome = new bool[] {false} ;
         T00053_A23EstCodi = new int[1] ;
         T00053_n23EstCodi = new bool[] {false} ;
         sMode5 = "" ;
         T00058_A26CidCodi = new int[1] ;
         T00058_n26CidCodi = new bool[] {false} ;
         T00059_A26CidCodi = new int[1] ;
         T00059_n26CidCodi = new bool[] {false} ;
         T00052_A26CidCodi = new int[1] ;
         T00052_n26CidCodi = new bool[] {false} ;
         T00052_A27CidNome = new String[] {""} ;
         T00052_n27CidNome = new bool[] {false} ;
         T00052_A23EstCodi = new int[1] ;
         T00052_n23EstCodi = new bool[] {false} ;
         T000511_A26CidCodi = new int[1] ;
         T000511_n26CidCodi = new bool[] {false} ;
         T000514_A24EstUF = new String[] {""} ;
         T000514_n24EstUF = new bool[] {false} ;
         T000514_A25EstNome = new String[] {""} ;
         T000514_n25EstNome = new bool[] {false} ;
         T000515_A12PesCodi = new int[1] ;
         T000516_A26CidCodi = new int[1] ;
         T000516_n26CidCodi = new bool[] {false} ;
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
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tcidade__default(),
            new Object[][] {
                new Object[] {
               T00052_A26CidCodi, T00052_A27CidNome, T00052_n27CidNome, T00052_A23EstCodi, T00052_n23EstCodi
               }
               , new Object[] {
               T00053_A26CidCodi, T00053_A27CidNome, T00053_n27CidNome, T00053_A23EstCodi, T00053_n23EstCodi
               }
               , new Object[] {
               T00054_A24EstUF, T00054_n24EstUF, T00054_A25EstNome, T00054_n25EstNome
               }
               , new Object[] {
               T00055_A26CidCodi, T00055_A27CidNome, T00055_n27CidNome, T00055_A24EstUF, T00055_n24EstUF, T00055_A25EstNome, T00055_n25EstNome, T00055_A23EstCodi, T00055_n23EstCodi
               }
               , new Object[] {
               T00056_A24EstUF, T00056_n24EstUF, T00056_A25EstNome, T00056_n25EstNome
               }
               , new Object[] {
               T00057_A26CidCodi
               }
               , new Object[] {
               T00058_A26CidCodi
               }
               , new Object[] {
               T00059_A26CidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000511_A26CidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000514_A24EstUF, T000514_n24EstUF, T000514_A25EstNome, T000514_n25EstNome
               }
               , new Object[] {
               T000515_A12PesCodi
               }
               , new Object[] {
               T000516_A26CidCodi
               }
            }
         );
      }

      private short RcdFound5 ;
      private short GxWebError ;
      private short gxajaxcallmode ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int A23EstCodi ;
      private int trnEnded ;
      private int bttBtn_delete_Enabled ;
      private int A26CidCodi ;
      private int Z26CidCodi ;
      private int Z23EstCodi ;
      private int GX_JID ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String lblTextblock1_Name ;
      private String lblTextblock2_Name ;
      private String lblTextblock3_Name ;
      private String lblTextblock4_Name ;
      private String lblTextblock5_Name ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtCidCodigo_Internalname ;
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
      private String edtCidCodigo_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtCidNome_Internalname ;
      private String edtCidNome_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtEstCodigo_Internalname ;
      private String edtEstCodigo_Jsonclick ;
      private String imgprompt_23_Internalname ;
      private String imgprompt_23_Link ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtEstUF_Internalname ;
      private String A24EstUF ;
      private String edtEstUF_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtEstNome_Internalname ;
      private String edtEstNome_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode5 ;
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
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private bool n23EstCodi ;
      private bool wbErr ;
      private bool n26CidCodi ;
      private bool n27CidNome ;
      private bool n24EstUF ;
      private bool n25EstNome ;
      private bool addContentType ;
      private String A27CidNome ;
      private String A25EstNome ;
      private String Z27CidNome ;
      private GeneXus.Utils.GxStringCollection Formheaderjscriptsrc ;
      private GXWebForm Form ;
      private IDataReader T00052 ;
      private IDataReader T00053 ;
      private IDataReader T00054 ;
      private IGxDataStore dsDefault ;
      private IDataReader T00055 ;
      private IDataStoreProvider pr_default ;
      private int[] T00055_A26CidCodi ;
      private bool[] T00055_n26CidCodi ;
      private String[] T00055_A27CidNome ;
      private bool[] T00055_n27CidNome ;
      private String[] T00055_A24EstUF ;
      private bool[] T00055_n24EstUF ;
      private String[] T00055_A25EstNome ;
      private bool[] T00055_n25EstNome ;
      private int[] T00055_A23EstCodi ;
      private bool[] T00055_n23EstCodi ;
      private String[] T00054_A24EstUF ;
      private bool[] T00054_n24EstUF ;
      private String[] T00054_A25EstNome ;
      private bool[] T00054_n25EstNome ;
      private IDataReader T00056 ;
      private String[] T00056_A24EstUF ;
      private bool[] T00056_n24EstUF ;
      private String[] T00056_A25EstNome ;
      private bool[] T00056_n25EstNome ;
      private IDataReader T00057 ;
      private int[] T00057_A26CidCodi ;
      private bool[] T00057_n26CidCodi ;
      private int[] T00053_A26CidCodi ;
      private bool[] T00053_n26CidCodi ;
      private String[] T00053_A27CidNome ;
      private bool[] T00053_n27CidNome ;
      private int[] T00053_A23EstCodi ;
      private bool[] T00053_n23EstCodi ;
      private IDataReader T00058 ;
      private int[] T00058_A26CidCodi ;
      private bool[] T00058_n26CidCodi ;
      private IDataReader T00059 ;
      private int[] T00059_A26CidCodi ;
      private bool[] T00059_n26CidCodi ;
      private int[] T00052_A26CidCodi ;
      private bool[] T00052_n26CidCodi ;
      private String[] T00052_A27CidNome ;
      private bool[] T00052_n27CidNome ;
      private int[] T00052_A23EstCodi ;
      private bool[] T00052_n23EstCodi ;
      private IDataReader T000511 ;
      private int[] T000511_A26CidCodi ;
      private bool[] T000511_n26CidCodi ;
      private IDataReader T000514 ;
      private String[] T000514_A24EstUF ;
      private bool[] T000514_n24EstUF ;
      private String[] T000514_A25EstNome ;
      private bool[] T000514_n25EstNome ;
      private IDataReader T000515 ;
      private int[] T000515_A12PesCodi ;
      private IDataReader T000516 ;
      private int[] T000516_A26CidCodi ;
      private bool[] T000516_n26CidCodi ;
   }

   public class tcidade__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[6])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          new Object[] {"@CidNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@CidNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000516 ;
          prmT000516 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00052", "SELECT [CidCodigo], [CidNome], [EstCodigo] FROM [CIDADE] WITH (UPDLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00053", "SELECT [CidCodigo], [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00054", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00055", "SELECT TM1.[CidCodigo], TM1.[CidNome], T2.[EstUF], T2.[EstNome], TM1.[EstCodigo] FROM ([CIDADE] TM1 WITH (NOLOCK) LEFT JOIN [ESTADO] T2 WITH (NOLOCK) ON T2.[EstCodigo] = TM1.[EstCodigo]) WHERE TM1.[CidCodigo] = @CidCodigo ORDER BY TM1.[CidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00056", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00057", "SELECT [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00058", "SELECT TOP 1 [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE ( [CidCodigo] > @CidCodigo) ORDER BY [CidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00059", "SELECT TOP 1 [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE ( [CidCodigo] < @CidCodigo) ORDER BY [CidCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000510", "INSERT INTO [CIDADE] ([CidNome], [EstCodigo]) VALUES (@CidNome, @EstCodigo)", GxErrorMask.GX_NOMASK,prmT000510)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000511", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000512", "UPDATE [CIDADE] SET [CidNome]=@CidNome, [EstCodigo]=@EstCodigo  WHERE [CidCodigo] = @CidCodigo", GxErrorMask.GX_NOMASK,prmT000512)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000513", "DELETE FROM [CIDADE]  WHERE [CidCodigo] = @CidCodigo", GxErrorMask.GX_NOMASK,prmT000513)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000514", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000515", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000516", "SELECT [CidCodigo] FROM [CIDADE] WITH (NOLOCK) ORDER BY [CidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,100,0,true,false )
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
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 2) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 14 :
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
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
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
             case 10 :
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
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[5]);
                }
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 13 :
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
