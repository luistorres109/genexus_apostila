/*
               File: Midia
        Description: Cadastro de Mídias
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:37.48
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
   public class tmidia : GXHttpHandler
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
            A28FilCodi = (int)(NumberUtil.Val( GetNextPar( ), "")) ;
            n28FilCodi = false ;
            gxajaxcallmode = 1 ;
            gxLoad_2( A28FilCodi) ;
            return  ;
         }
         lblTextblock1_Name = "Textblock1" ;
         lblTextblock2_Name = "Textblock2" ;
         cmbMidTipo.Name = "MIDTIPO" ;
         cmbMidTipo.Height = 1 ;
         cmbMidTipo.WebTags = "" ;
         cmbMidTipo.addItem(StringUtil.Str( (decimal)(1), 1, 0), "DVD", 0);
         cmbMidTipo.addItem(StringUtil.Str( (decimal)(2), 1, 0), "Bluray", 0);
         cmbMidTipo.addItem(StringUtil.Str( (decimal)(3), 1, 0), "VHS", 0);
         lblTextblock3_Name = "Textblock3" ;
         cmbMidSituacao.Name = "MIDSITUACAO" ;
         cmbMidSituacao.Height = 1 ;
         cmbMidSituacao.WebTags = "" ;
         cmbMidSituacao.addItem(StringUtil.Str( (decimal)(1), 1, 0), "Liberado", 0);
         cmbMidSituacao.addItem(StringUtil.Str( (decimal)(2), 1, 0), "Locado", 0);
         lblTextblock4_Name = "Textblock4" ;
         lblTextblock5_Name = "Textblock5" ;
         initialize_properties( ) ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "9_0_7-910", 0) ;
         Form.Meta.addItem("Description", "Cadastro de Mídias", 0) ;
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
         GX_FocusControl = edtMidCodigo_Internalname ;
         wbErr = false ;
      }

      public tmidia( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tmidia( IGxContext context )
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
         cmbMidTipo = new GXCombobox();
         cmbMidSituacao = new GXCombobox();
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
            wb_table1_2_066( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_066e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            RenderHtmlCloseForm066( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_066( bool wbgen )
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
            gx_button_ctrl2( 1, bttBtn_first_Internalname, "|<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "4" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_previous_Internalname, "<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "5" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_next_Internalname, ">", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "6" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_last_Internalname, ">|", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "7" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_select_Internalname, "Select", "", "", StyleString, ClassString, 1, 1, 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "", "'HLP_TMidia.htm'");
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
            wb_table2_9_066( true) ;
         }
         return  ;
      }

      protected void wb_table2_9_066e( bool wbgen )
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
            gx_button_ctrl2( 1, bttBtn_enter_Internalname, "Apply Changes", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "23" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_check_Internalname, "Check", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "24" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_cancel_Internalname, "Close", "", "", StyleString, ClassString, 1, 1, 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "25" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_delete_Internalname, "Delete All", "", "", StyleString, ClassString, 1, bttBtn_delete_Enabled, 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "26" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_help_Internalname, "Help", "", "", StyleString, ClassString, 1, 1, 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table1_2_066e( true) ;
         }
         else
         {
            wb_table1_2_066e( false) ;
         }
      }

      protected void wb_table2_9_066( bool wbgen )
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
            gx_label_ctrl( lblTextblock1_Internalname, 1, 1, 0, "Código de Mídia", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "11" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtMidCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37MidCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A37MidCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(11);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,true,null,'eng');"+"\"", 0, edtMidCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TMidia.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "12" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_get_Internalname, "=>", "", "", StyleString, ClassString, 1, 1, 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock2_Internalname, 1, 1, 0, "Tipo de Mídia", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "14" + "," + "''" + "," + "0" + ")\"" ;
            cmbMidTipo.CurrentValue = StringUtil.Str( (decimal)(A35MidTipo), 1, 0) ;
            /* ComboBox */
            gx_combobox_ctrl( cmbMidTipo, cmbMidTipo_Internalname, StringUtil.Str( (decimal)(A35MidTipo), 1, 0), "int", 1, 1, 1, 2, StyleString, ClassString, "", 0, cmbMidTipo_Jsonclick, "", TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(14);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock3_Internalname, 1, 1, 0, "Situação de Mídia", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "16" + "," + "''" + "," + "0" + ")\"" ;
            cmbMidSituacao.CurrentValue = StringUtil.Str( (decimal)(A36MidSitu), 1, 0) ;
            /* ComboBox */
            gx_combobox_ctrl( cmbMidSituacao, cmbMidSituacao_Internalname, StringUtil.Str( (decimal)(A36MidSitu), 1, 0), "int", 1, 1, 1, 2, StyleString, ClassString, "", 0, cmbMidSituacao_Jsonclick, "", TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(16);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock4_Internalname, 1, 1, 0, "Código do Filme", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "18" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtFilCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28FilCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A28FilCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(18);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtFilCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TMidia.htm'");
            /* Static images/pictures */
            ClassString = "S8" ;
            StyleString = "" + "" ;
            gx_bitmap( imgprompt_28_Internalname, "", "prompt.gif", 1, 0, "", "", 0, 0, 0, 0, 0, 0, imgprompt_28_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock5_Internalname, 1, 1, 0, "Nome do Filme", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtFilNome_Internalname, StringUtil.RTrim( A29FilNome), 50, 50, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A29FilNome, "@!")), "", 0, edtFilNome_Jsonclick, "", 0, 0, 1, "'HLP_TMidia.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table2_9_066e( true) ;
         }
         else
         {
            wb_table2_9_066e( false) ;
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
               Z37MidCodi = (int)(NumberUtil.CToN( cgiGet( "Z37MidCodi"), "", "")) ;
               Z35MidTipo = (short)(NumberUtil.CToN( cgiGet( "Z35MidTipo"), "", "")) ;
               Z36MidSitu = (short)(NumberUtil.CToN( cgiGet( "Z36MidSitu"), "", "")) ;
               Z28FilCodi = (int)(NumberUtil.CToN( cgiGet( "Z28FilCodi"), "", "")) ;
               IsConfirmed = (short)(NumberUtil.CToN( cgiGet( "IsConfirmed"), "", "")) ;
               IsModified = (short)(NumberUtil.CToN( cgiGet( "IsModified"), "", "")) ;
               Gx_mode = GXUtil.ValueDecode( cgiGet( "Mode")) ;
               context.sCallerURL = GXUtil.ValueDecode( cgiGet( "sCallerURL")) ;
               /* Read subfile selected row values. */
               /* Read variables values. */
               if ( ( ( NumberUtil.CToN( cgiGet( edtMidCodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtMidCodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtMidCodigo_Internalname ;
                  wbErr = true ;
                  A37MidCodi = (int)(0M) ;
               }
               else
               {
                  A37MidCodi = (int)(NumberUtil.CToN( cgiGet( edtMidCodigo_Internalname), "", "")) ;
               }
               cmbMidTipo.CurrentValue = cgiGet( cmbMidTipo_Internalname) ;
               A35MidTipo = (short)(NumberUtil.Val( cgiGet( cmbMidTipo_Internalname), ".")) ;
               n35MidTipo = false ;
               n35MidTipo = (((0==A35MidTipo)) ? true : false) ;
               cmbMidSituacao.CurrentValue = cgiGet( cmbMidSituacao_Internalname) ;
               A36MidSitu = (short)(NumberUtil.Val( cgiGet( cmbMidSituacao_Internalname), ".")) ;
               n36MidSitu = false ;
               n36MidSitu = (((0==A36MidSitu)) ? true : false) ;
               if ( ( ( NumberUtil.CToN( cgiGet( edtFilCodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtFilCodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtFilCodigo_Internalname ;
                  wbErr = true ;
                  A28FilCodi = (int)(0M) ;
                  n28FilCodi = false ;
               }
               else
               {
                  A28FilCodi = (int)(NumberUtil.CToN( cgiGet( edtFilCodigo_Internalname), "", "")) ;
                  n28FilCodi = false ;
               }
               n28FilCodi = (((0==A28FilCodi)) ? true : false) ;
               A29FilNome = StringUtil.Upper( cgiGet( edtFilNome_Internalname)) ;
               n29FilNome = false ;
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
               InitAll066( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      protected void CONFIRM_060( )
      {
         BeforeValidate066( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls066( ) ;
            }
            else
            {
               CheckExtendedTable066( ) ;
               if ( ( AnyError == 0 ) )
               {
                  ZM066( 2) ;
               }
               CloseExtendedTableCursors066( ) ;
            }
         }
         if ( ( AnyError == 0 ) )
         {
            IsConfirmed = 1 ;
         }
         if ( ( AnyError == 0 ) )
         {
            ConfirmValues060( ) ;
         }
      }

      protected void ResetCaption060( )
      {
         IsConfirmed = 0 ;
      }

      protected void ZM066( int GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z35MidTipo = T00063_A35MidTipo[0] ;
               Z36MidSitu = T00063_A36MidSitu[0] ;
               Z28FilCodi = T00063_A28FilCodi[0] ;
            }
            else
            {
               Z35MidTipo = A35MidTipo ;
               Z36MidSitu = A36MidSitu ;
               Z28FilCodi = A28FilCodi ;
            }
         }
         if ( ( GX_JID == -1 ) )
         {
            Z37MidCodi = A37MidCodi ;
            Z35MidTipo = A35MidTipo ;
            Z36MidSitu = A36MidSitu ;
            Z28FilCodi = A28FilCodi ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_28_Link = ((String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') )==0) ? "" : "javascript:"+"HGx0020("+"document.forms[0]."+"FILCODIGO"+");") ;
      }

      protected void standaloneModal( )
      {
      }

      protected void Load066( )
      {
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1 ;
            A35MidTipo = T00065_A35MidTipo[0] ;
            n35MidTipo = T00065_n35MidTipo[0] ;
            A36MidSitu = T00065_A36MidSitu[0] ;
            n36MidSitu = T00065_n36MidSitu[0] ;
            A29FilNome = T00065_A29FilNome[0] ;
            n29FilNome = T00065_n29FilNome[0] ;
            A28FilCodi = T00065_A28FilCodi[0] ;
            n28FilCodi = T00065_n28FilCodi[0] ;
            ZM066( -1) ;
         }
         pr_default.close(3);
         OnLoadActions066( ) ;
      }

      protected void OnLoadActions066( )
      {
      }

      protected void CheckExtendedTable066( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( ((0==A28FilCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Filmes'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtFilCodigo_Internalname ;
            }
         }
         A29FilNome = T00064_A29FilNome[0] ;
         n29FilNome = T00064_n29FilNome[0] ;
         pr_default.close(2);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors066( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
         if ( ( IsConfirmed == 0 ) )
         {
            bttBtn_delete_Enabled = RcdFound6 ;
         }
         else
         {
            bttBtn_delete_Enabled = 0 ;
         }
      }

      protected void gxLoad_2( int A28FilCodi )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( ((0==A28FilCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Filmes'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtFilCodigo_Internalname ;
            }
         }
         A29FilNome = T00066_A29FilNome[0] ;
         n29FilNome = T00066_n29FilNome[0] ;
         wbTemp = context.ResponseContentType( "text/html") ;
         wbTemp = context.SetHeader( "pragma", "no-cache") ;
         context.GX_webresponse.AppendHeader("Content-Type", "text/plain;charset=utf-8");
         wbTemp = context.SetHeader( "Cache-Control", "max-age=0") ;
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A29FilNome))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey066( )
      {
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound6 = 1 ;
         }
         else
         {
            RcdFound6 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM066( 1) ;
            RcdFound6 = 1 ;
            A37MidCodi = T00063_A37MidCodi[0] ;
            A35MidTipo = T00063_A35MidTipo[0] ;
            n35MidTipo = T00063_n35MidTipo[0] ;
            A36MidSitu = T00063_A36MidSitu[0] ;
            n36MidSitu = T00063_n36MidSitu[0] ;
            A28FilCodi = T00063_A28FilCodi[0] ;
            n28FilCodi = T00063_n28FilCodi[0] ;
            Z37MidCodi = A37MidCodi ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load066( ) ;
            Gx_mode = sMode6 ;
         }
         else
         {
            RcdFound6 = 0 ;
            InitializeNonKey066( ) ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode6 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey066( ) ;
         if ( ( RcdFound6 == 0 ) )
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
         RcdFound6 = 0 ;
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00068_A37MidCodi[0] < A37MidCodi ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00068_A37MidCodi[0] > A37MidCodi ) ) )
            {
               A37MidCodi = T00068_A37MidCodi[0] ;
               RcdFound6 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0 ;
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A37MidCodi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00069_A37MidCodi[0] > A37MidCodi ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00069_A37MidCodi[0] < A37MidCodi ) ) )
            {
               A37MidCodi = T00069_A37MidCodi[0] ;
               RcdFound6 = 1 ;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey066( ) ;
         if ( ( RcdFound6 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtMidCodigo_Internalname ;
            }
            else if ( ( A37MidCodi != Z37MidCodi ) )
            {
               A37MidCodi = Z37MidCodi ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "CandidateKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtMidCodigo_Internalname ;
            }
            else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               if ( ( IsConfirmed == 1 ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtMidCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "DLT" ;
                  /* Confirm record */
                  CONFIRM_060( ) ;
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
                  Update066( ) ;
                  GX_FocusControl = edtMidCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_060( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     GX_FocusControl = bttBtn_enter_Internalname ;
                  }
               }
            }
         }
         else
         {
            if ( ( A37MidCodi != Z37MidCodi ) )
            {
               Gx_mode = "INS" ;
               if ( ( IsConfirmed == 1 ) )
               {
                  /* Insert record */
                  Insert066( ) ;
                  GX_FocusControl = edtMidCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_060( ) ;
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
                  GX_FocusControl = edtMidCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  if ( ( IsConfirmed == 1 ) )
                  {
                     /* Insert record */
                     Insert066( ) ;
                     GX_FocusControl = edtMidCodigo_Internalname ;
                  }
                  else
                  {
                     /* Confirm record */
                     CONFIRM_060( ) ;
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
         if ( ( A37MidCodi != Z37MidCodi ) )
         {
            A37MidCodi = Z37MidCodi ;
            GX_msglist.addItem(GXResourceManager.GetMessage("getbeforedlt"), 1);
            AnyError = 1 ;
            GX_FocusControl = edtMidCodigo_Internalname ;
         }
         else
         {
            if ( ( IsConfirmed == 1 ) )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtMidCodigo_Internalname ;
            }
            else
            {
               Gx_mode = "DLT" ;
               /* Confirm record */
               CONFIRM_060( ) ;
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
         GetKey066( ) ;
         if ( ( RcdFound6 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtMidCodigo_Internalname ;
            }
            else if ( ( A37MidCodi != Z37MidCodi ) )
            {
               A37MidCodi = Z37MidCodi ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtMidCodigo_Internalname ;
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
            if ( ( A37MidCodi != Z37MidCodi ) )
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
                  GX_FocusControl = edtMidCodigo_Internalname ;
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
         context.RollbackDataStores("TMidia");
         GX_FocusControl = cmbMidTipo_Internalname ;
      }

      protected void insert_Check( )
      {
         CONFIRM_060( ) ;
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
         if ( ( RcdFound6 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("keynfound"), "PrimaryKeyNotFound", 1);
            AnyError = 1 ;
         }
         GX_FocusControl = cmbMidTipo_Internalname ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart066( ) ;
         if ( ( RcdFound6 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = cmbMidTipo_Internalname ;
         ScanEnd066( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( ( RcdFound6 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = cmbMidTipo_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( ( RcdFound6 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = cmbMidTipo_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart066( ) ;
         if ( ( RcdFound6 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            while ( ( RcdFound6 != 0 ) )
            {
               ScanNext066( ) ;
            }
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = cmbMidTipo_Internalname ;
         ScanEnd066( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency066( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A37MidCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("lock", new   object[]  {"MIDIA"}), "RecordIsLocked", 1);
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z35MidTipo != T00062_A35MidTipo[0] ) || ( Z36MidSitu != T00062_A36MidSitu[0] ) || ( Z28FilCodi != T00062_A28FilCodi[0] ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("waschg", new   object[]  {"MIDIA"}), "RecordWasChanged", 1);
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert066( )
      {
         BeforeValidate066( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable066( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM066( 1) ;
            CheckOptimisticConcurrency066( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm066( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert066( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000610 */
                     pr_default.execute(8, new Object[] {n35MidTipo, A35MidTipo, n36MidSitu, A36MidSitu, n28FilCodi, A28FilCodi});
                     pr_default.close(8);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000611 */
                     pr_default.execute(9);
                     A37MidCodi = T000611_A37MidCodi[0] ;
                     pr_default.close(9);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucadded"), 0);
                           ResetCaption060( ) ;
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
               Load066( ) ;
            }
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void Update066( )
      {
         BeforeValidate066( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable066( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency066( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm066( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate066( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000612 */
                     pr_default.execute(10, new Object[] {n35MidTipo, A35MidTipo, n36MidSitu, A36MidSitu, n28FilCodi, A28FilCodi, A37MidCodi});
                     pr_default.close(10);
                     DeferredUpdate066( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucupdated"), 0);
                           ResetCaption060( ) ;
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
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void DeferredUpdate066( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate066( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency066( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls066( ) ;
            /* No cascading delete specified. */
            AfterConfirm066( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete066( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000613 */
                  pr_default.execute(11, new Object[] {A37MidCodi});
                  pr_default.close(11);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        move_next( ) ;
                        if ( ( RcdFound6 == 0 ) )
                        {
                           InitAll066( ) ;
                           Gx_mode = "INS" ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                        }
                        GX_msglist.addItem(GXResourceManager.GetMessage("sucdeleted"), 0);
                        ResetCaption060( ) ;
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
         sMode6 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel066( ) ;
         Gx_mode = sMode6 ;
      }

      protected void OnDeleteControls066( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000614 */
            pr_default.execute(12, new Object[] {n28FilCodi, A28FilCodi});
            A29FilNome = T000614_A29FilNome[0] ;
            n29FilNome = T000614_n29FilNome[0] ;
            pr_default.close(12);
         }
      }

      protected void EndLevel066( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete066( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("TMidia");
            if ( ( AnyError == 0 ) )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("TMidia");
         }
         IsModified = 0 ;
         if ( ( AnyError != 0 ) )
         {
            context.wjLoc = "" ;
         }
      }

      protected void ScanStart066( )
      {
         /* Using cursor T000615 */
         pr_default.execute(13);
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound6 = 1 ;
            A37MidCodi = T000615_A37MidCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext066( )
      {
         pr_default.readNext(13);
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound6 = 1 ;
            A37MidCodi = T000615_A37MidCodi[0] ;
         }
      }

      protected void ScanEnd066( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm066( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert066( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate066( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete066( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete066( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate066( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         WriteHtmlText( "Cadastro de Mídias") ;
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
         WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return GXValidForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" ACTION=\""+formatLink("tmidia.aspx") +"\""+">") ;
         gx_hidden_field( "_EventName", "");
         gx_hidden_field( "_EventGridId", "");
         gx_hidden_field( "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm066( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         gx_hidden_field( "Z37MidCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37MidCodi), 9, 0, ".", "")));
         gx_hidden_field( "Z35MidTipo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35MidTipo), 1, 0, ".", "")));
         gx_hidden_field( "Z36MidSitu", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36MidSitu), 1, 0, ".", "")));
         gx_hidden_field( "Z28FilCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28FilCodi), 9, 0, ".", "")));
         gx_hidden_field( "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         gx_hidden_field( "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         gx_hidden_field( "Mode", StringUtil.RTrim( Gx_mode));
         gx_hidden_field( "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         WriteHtmlTextNl( "</body>") ;
         WriteHtmlTextNl( "</html>") ;
      }

      protected void InitializeNonKey066( )
      {
         A35MidTipo = 0 ;
         n35MidTipo = false ;
         n35MidTipo = (((0==A35MidTipo)) ? true : false) ;
         A36MidSitu = 0 ;
         n36MidSitu = false ;
         n36MidSitu = (((0==A36MidSitu)) ? true : false) ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         n28FilCodi = (((0==A28FilCodi)) ? true : false) ;
         A29FilNome = "" ;
         n29FilNome = false ;
      }

      protected void InitAll066( )
      {
         A37MidCodi = 0 ;
         InitializeNonKey066( ) ;
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
            WriteHtmlTextNl( "var wHGx0020=null;") ;
            WriteHtmlTextNl( "var wHGx0060=null;") ;
            WriteHtmlTextNl( "var wHGx0060=null;") ;
            WriteHtmlTextNl( "var GXISGET=false;") ;
            /* Set focus on 'active' control (if any). */
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( GX_FocusControl).TrimEnd(' ') )==0)) )
            {
               WriteHtmlTextNl( "GXSetUserFocus(document.forms[0]."+GX_FocusControl+");") ;
            }
            WriteHtmlTextNl( "function onCloseHGx0020()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0020(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "if (!gxCheckControlConds('PROMPT_28', '_', 0, [18],isMod)) {return;}") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:false};") ;
            WriteHtmlTextNl( "if (wHGx0020== null || wHGx0020.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0020;") ;
            WriteHtmlTextNl( "GXISGET = false;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0020=open(\"") ;
            WriteHtmlText( "hgx0020.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0020.focus();") ;
            WriteHtmlTextNl( "if (isMod != null) GXSetRowModified(isMod);") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function onCloseHGx0060()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0060(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0060== null || wHGx0060.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0060;") ;
            WriteHtmlTextNl( "GXISGET = false;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0060=open(\"") ;
            WriteHtmlText( "hgx0060.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0060.focus();") ;
            WriteHtmlTextNl( "if (isMod != null) GXSetRowModified(isMod);") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function onCloseHGx0060()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0060(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0060== null || wHGx0060.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0060;") ;
            WriteHtmlText( "document.forms[0]._EventName.value='"+"';") ;
            WriteHtmlTextNl( "GXISGET = true;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0060=open(\"") ;
            WriteHtmlText( "hgx0060.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0060.focus();") ;
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
         WriteHtmlTextNl( "obj."+"MIDTIPO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"MIDSITUACAO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"FILCODIGO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"FILNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "}") ;
         WriteHtmlTextNl( "</script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "form_onchange.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "std_messages.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gx_help.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "tmidia.js")+"\"></script>") ;
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
               sEventJsCode = "HGx0060(" + "document.forms[0]." + "MIDCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0060(" + "document.forms[0]." + "MIDCODIGO" + ");" ;
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
                     sEventJsCode = "HGx0060(" + "document.forms[0]." + "MIDCODIGO" + ");" ;
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
         else if ( ( nJScriptCode == 4 ) )
         {
            sEventJsCode = "HGx0060(" + "document.forms[0]." + "MIDCODIGO" + ");" + "return false;" ;
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
            else if ( ( nJScriptCode == 4 ) )
            {
               sEventJsCode = "HGx0060(" + "document.forms[0]." + "MIDCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0060(" + "document.forms[0]." + "MIDCODIGO" + ");" + "return false;" ;
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
         edtMidCodigo_Internalname = "MIDCODIGO" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         cmbMidTipo_Internalname = "MIDTIPO" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         cmbMidSituacao_Internalname = "MIDSITUACAO" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtFilCodigo_Internalname = "FILCODIGO" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtFilNome_Internalname = "FILNOME" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_28_Internalname = "PROMPT_28" ;
         edtFilNome_Jsonclick = "" ;
         imgprompt_28_Link = "" ;
         edtFilCodigo_Jsonclick = "" ;
         cmbMidSituacao_Jsonclick = "" ;
         cmbMidTipo_Jsonclick = "" ;
         edtMidCodigo_Jsonclick = "" ;
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
         RcdFound6 = 0 ;
         GxWebError = 0 ;
         scmdbuf = "" ;
         gxajaxcallmode = 0 ;
         gxfirstwebparm = "" ;
         A28FilCodi = 0 ;
         n28FilCodi = false ;
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
         edtMidCodigo_Internalname = "" ;
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
         A37MidCodi = 0 ;
         edtMidCodigo_Jsonclick = "" ;
         bttBtn_get_Internalname = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock2_Internalname = "" ;
         lblTextblock2_Jsonclick = "" ;
         A35MidTipo = 0 ;
         cmbMidTipo_Internalname = "" ;
         cmbMidTipo_Jsonclick = "" ;
         lblTextblock3_Internalname = "" ;
         lblTextblock3_Jsonclick = "" ;
         A36MidSitu = 0 ;
         cmbMidSituacao_Internalname = "" ;
         cmbMidSituacao_Jsonclick = "" ;
         lblTextblock4_Internalname = "" ;
         lblTextblock4_Jsonclick = "" ;
         edtFilCodigo_Internalname = "" ;
         edtFilCodigo_Jsonclick = "" ;
         imgprompt_28_Internalname = "" ;
         imgprompt_28_Link = "" ;
         lblTextblock5_Internalname = "" ;
         lblTextblock5_Jsonclick = "" ;
         edtFilNome_Internalname = "" ;
         A29FilNome = "" ;
         edtFilNome_Jsonclick = "" ;
         Z37MidCodi = 0 ;
         Z35MidTipo = 0 ;
         Z36MidSitu = 0 ;
         Z28FilCodi = 0 ;
         Gx_mode = "" ;
         n35MidTipo = false ;
         n36MidSitu = false ;
         n29FilNome = false ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GX_JID = 0 ;
         T00065_A37MidCodi = new int[1] ;
         T00065_A35MidTipo = new short[1] ;
         T00065_n35MidTipo = new bool[] {false} ;
         T00065_A36MidSitu = new short[1] ;
         T00065_n36MidSitu = new bool[] {false} ;
         T00065_A29FilNome = new String[] {""} ;
         T00065_n29FilNome = new bool[] {false} ;
         T00065_A28FilCodi = new int[1] ;
         T00065_n28FilCodi = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00064_A29FilNome = new String[] {""} ;
         T00064_n29FilNome = new bool[] {false} ;
         T00066_A29FilNome = new String[] {""} ;
         T00066_n29FilNome = new bool[] {false} ;
         wbTemp = 0 ;
         T00067_A37MidCodi = new int[1] ;
         T00063_A37MidCodi = new int[1] ;
         T00063_A35MidTipo = new short[1] ;
         T00063_n35MidTipo = new bool[] {false} ;
         T00063_A36MidSitu = new short[1] ;
         T00063_n36MidSitu = new bool[] {false} ;
         T00063_A28FilCodi = new int[1] ;
         T00063_n28FilCodi = new bool[] {false} ;
         sMode6 = "" ;
         T00068_A37MidCodi = new int[1] ;
         T00069_A37MidCodi = new int[1] ;
         T00062_A37MidCodi = new int[1] ;
         T00062_A35MidTipo = new short[1] ;
         T00062_n35MidTipo = new bool[] {false} ;
         T00062_A36MidSitu = new short[1] ;
         T00062_n36MidSitu = new bool[] {false} ;
         T00062_A28FilCodi = new int[1] ;
         T00062_n28FilCodi = new bool[] {false} ;
         T000611_A37MidCodi = new int[1] ;
         T000614_A29FilNome = new String[] {""} ;
         T000614_n29FilNome = new bool[] {false} ;
         T000615_A37MidCodi = new int[1] ;
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
         cmbCObjCtrl = new GXCombobox();
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tmidia__default(),
            new Object[][] {
                new Object[] {
               T00062_A37MidCodi, T00062_A35MidTipo, T00062_n35MidTipo, T00062_A36MidSitu, T00062_n36MidSitu, T00062_A28FilCodi, T00062_n28FilCodi
               }
               , new Object[] {
               T00063_A37MidCodi, T00063_A35MidTipo, T00063_n35MidTipo, T00063_A36MidSitu, T00063_n36MidSitu, T00063_A28FilCodi, T00063_n28FilCodi
               }
               , new Object[] {
               T00064_A29FilNome, T00064_n29FilNome
               }
               , new Object[] {
               T00065_A37MidCodi, T00065_A35MidTipo, T00065_n35MidTipo, T00065_A36MidSitu, T00065_n36MidSitu, T00065_A29FilNome, T00065_n29FilNome, T00065_A28FilCodi, T00065_n28FilCodi
               }
               , new Object[] {
               T00066_A29FilNome, T00066_n29FilNome
               }
               , new Object[] {
               T00067_A37MidCodi
               }
               , new Object[] {
               T00068_A37MidCodi
               }
               , new Object[] {
               T00069_A37MidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000611_A37MidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000614_A29FilNome, T000614_n29FilNome
               }
               , new Object[] {
               T000615_A37MidCodi
               }
            }
         );
      }

      private short RcdFound6 ;
      private short GxWebError ;
      private short gxajaxcallmode ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short A35MidTipo ;
      private short A36MidSitu ;
      private short Z35MidTipo ;
      private short Z36MidSitu ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int A28FilCodi ;
      private int trnEnded ;
      private int bttBtn_delete_Enabled ;
      private int A37MidCodi ;
      private int Z37MidCodi ;
      private int Z28FilCodi ;
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
      private String edtMidCodigo_Internalname ;
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
      private String edtMidCodigo_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String cmbMidTipo_Internalname ;
      private String cmbMidTipo_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String cmbMidSituacao_Internalname ;
      private String cmbMidSituacao_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtFilCodigo_Internalname ;
      private String edtFilCodigo_Jsonclick ;
      private String imgprompt_28_Internalname ;
      private String imgprompt_28_Link ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtFilNome_Internalname ;
      private String edtFilNome_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode6 ;
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
      private bool n28FilCodi ;
      private bool wbErr ;
      private bool n35MidTipo ;
      private bool n36MidSitu ;
      private bool n29FilNome ;
      private bool addContentType ;
      private String A29FilNome ;
      private GeneXus.Utils.GxStringCollection Formheaderjscriptsrc ;
      private GXWebForm Form ;
      private IDataReader T00062 ;
      private IDataReader T00063 ;
      private IDataReader T00064 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbMidTipo ;
      private GXCombobox cmbMidSituacao ;
      private IDataReader T00065 ;
      private IDataStoreProvider pr_default ;
      private int[] T00065_A37MidCodi ;
      private short[] T00065_A35MidTipo ;
      private bool[] T00065_n35MidTipo ;
      private short[] T00065_A36MidSitu ;
      private bool[] T00065_n36MidSitu ;
      private String[] T00065_A29FilNome ;
      private bool[] T00065_n29FilNome ;
      private int[] T00065_A28FilCodi ;
      private bool[] T00065_n28FilCodi ;
      private String[] T00064_A29FilNome ;
      private bool[] T00064_n29FilNome ;
      private IDataReader T00066 ;
      private String[] T00066_A29FilNome ;
      private bool[] T00066_n29FilNome ;
      private IDataReader T00067 ;
      private int[] T00067_A37MidCodi ;
      private int[] T00063_A37MidCodi ;
      private short[] T00063_A35MidTipo ;
      private bool[] T00063_n35MidTipo ;
      private short[] T00063_A36MidSitu ;
      private bool[] T00063_n36MidSitu ;
      private int[] T00063_A28FilCodi ;
      private bool[] T00063_n28FilCodi ;
      private IDataReader T00068 ;
      private int[] T00068_A37MidCodi ;
      private IDataReader T00069 ;
      private int[] T00069_A37MidCodi ;
      private int[] T00062_A37MidCodi ;
      private short[] T00062_A35MidTipo ;
      private bool[] T00062_n35MidTipo ;
      private short[] T00062_A36MidSitu ;
      private bool[] T00062_n36MidSitu ;
      private int[] T00062_A28FilCodi ;
      private bool[] T00062_n28FilCodi ;
      private IDataReader T000611 ;
      private int[] T000611_A37MidCodi ;
      private IDataReader T000614 ;
      private String[] T000614_A29FilNome ;
      private bool[] T000614_n29FilNome ;
      private IDataReader T000615 ;
      private int[] T000615_A37MidCodi ;
      private GXCombobox cmbCObjCtrl ;
   }

   public class tmidia__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@MidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@MidSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          new Object[] {"@MidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000614 ;
          prmT000614 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000615 ;
          prmT000615 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00062", "SELECT [MidCodigo], [MidTipo], [MidSituacao], [FilCodigo] FROM [MIDIA] WITH (UPDLOCK) WHERE [MidCodigo] = @MidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00063", "SELECT [MidCodigo], [MidTipo], [MidSituacao], [FilCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @MidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00064", "SELECT [FilNome] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00065", "SELECT TM1.[MidCodigo], TM1.[MidTipo], TM1.[MidSituacao], T2.[FilNome], TM1.[FilCodigo] FROM ([MIDIA] TM1 WITH (NOLOCK) LEFT JOIN [FILME] T2 WITH (NOLOCK) ON T2.[FilCodigo] = TM1.[FilCodigo]) WHERE TM1.[MidCodigo] = @MidCodigo ORDER BY TM1.[MidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00066", "SELECT [FilNome] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00067", "SELECT [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @MidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00068", "SELECT TOP 1 [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE ( [MidCodigo] > @MidCodigo) ORDER BY [MidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00069", "SELECT TOP 1 [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE ( [MidCodigo] < @MidCodigo) ORDER BY [MidCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000610", "INSERT INTO [MIDIA] ([MidTipo], [MidSituacao], [FilCodigo]) VALUES (@MidTipo, @MidSituacao, @FilCodigo)", GxErrorMask.GX_NOMASK,prmT000610)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000611", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000612", "UPDATE [MIDIA] SET [MidTipo]=@MidTipo, [MidSituacao]=@MidSituacao, [FilCodigo]=@FilCodigo  WHERE [MidCodigo] = @MidCodigo", GxErrorMask.GX_NOMASK,prmT000612)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000613", "DELETE FROM [MIDIA]  WHERE [MidCodigo] = @MidCodigo", GxErrorMask.GX_NOMASK,prmT000613)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000614", "SELECT [FilNome] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000615", "SELECT [MidCodigo] FROM [MIDIA] WITH (NOLOCK) ORDER BY [MidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,100,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 13 :
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
                stmt.SetParameter(1, (int)parms[0]);
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
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
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[5]);
                }
                stmt.SetParameter(4, (int)parms[6]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
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
       }
    }

 }

}
