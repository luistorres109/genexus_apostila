/*
               File: Pessoa
        Description: Cadastro de Pessoas
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:38.15
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
   public class tpessoa : GXHttpHandler
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
         if ( ( String.CompareOrdinal(gxfirstwebparm.TrimEnd(' '), "gxajaxExecAct_"+"gxLoad_3".TrimEnd(' ') ) == 0 ) )
         {
            A26CidCodi = (int)(NumberUtil.Val( GetNextPar( ), "")) ;
            n26CidCodi = false ;
            gxajaxcallmode = 1 ;
            gxLoad_3( A26CidCodi) ;
            return  ;
         }
         if ( ( String.CompareOrdinal(gxfirstwebparm.TrimEnd(' '), "gxajaxExecAct_"+"gxLoad_4".TrimEnd(' ') ) == 0 ) )
         {
            A23EstCodi = (int)(NumberUtil.Val( GetNextPar( ), "")) ;
            n23EstCodi = false ;
            gxajaxcallmode = 1 ;
            gxLoad_4( A23EstCodi) ;
            return  ;
         }
         lblTextblock1_Name = "Textblock1" ;
         lblTextblock2_Name = "Textblock2" ;
         lblTextblock3_Name = "Textblock3" ;
         lblTextblock4_Name = "Textblock4" ;
         lblTextblock5_Name = "Textblock5" ;
         lblTextblock6_Name = "Textblock6" ;
         lblTextblock7_Name = "Textblock7" ;
         lblTextblock8_Name = "Textblock8" ;
         lblTextblock9_Name = "Textblock9" ;
         lblTextblock10_Name = "Textblock10" ;
         lblTextblock11_Name = "Textblock11" ;
         cmbPesSituacao.Name = "PESSITUACAO" ;
         cmbPesSituacao.Height = 1 ;
         cmbPesSituacao.WebTags = "" ;
         cmbPesSituacao.addItem(StringUtil.Str( (decimal)(1), 1, 0), "Ativo", 0);
         cmbPesSituacao.addItem(StringUtil.Str( (decimal)(2), 1, 0), "Inativo", 0);
         lblTextblock12_Name = "Textblock12" ;
         lblTextblock13_Name = "Textblock13" ;
         lblTextblock14_Name = "Textblock14" ;
         lblTextblock15_Name = "Textblock15" ;
         lblTextblock16_Name = "Textblock16" ;
         initialize_properties( ) ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "9_0_7-910", 0) ;
         Form.Meta.addItem("Description", "Cadastro de Pessoas", 0) ;
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
         GX_FocusControl = edtPesCodigo_Internalname ;
         wbErr = false ;
      }

      public tpessoa( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tpessoa( IGxContext context )
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
         cmbPesSituacao = new GXCombobox();
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
            wb_table1_2_011( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_011e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            RenderHtmlCloseForm011( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_011( bool wbgen )
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
            gx_button_ctrl2( 1, bttBtn_first_Internalname, "|<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "4" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_previous_Internalname, "<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "5" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_next_Internalname, ">", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "6" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_last_Internalname, ">|", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "7" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_select_Internalname, "Select", "", "", StyleString, ClassString, 1, 1, 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "", "'HLP_TPessoa.htm'");
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
            wb_table2_9_011( true) ;
         }
         return  ;
      }

      protected void wb_table2_9_011e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "44" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_enter_Internalname, "Apply Changes", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "45" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_check_Internalname, "Check", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "46" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_cancel_Internalname, "Close", "", "", StyleString, ClassString, 1, 1, 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "47" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_delete_Internalname, "Delete All", "", "", StyleString, ClassString, 1, bttBtn_delete_Enabled, 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "48" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_help_Internalname, "Help", "", "", StyleString, ClassString, 1, 1, 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table1_2_011e( true) ;
         }
         else
         {
            wb_table1_2_011e( false) ;
         }
      }

      protected void wb_table2_9_011( bool wbgen )
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
            gx_label_ctrl( lblTextblock1_Internalname, 1, 1, 0, "Codigo da Pessoa", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "11" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12PesCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A12PesCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(11);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,true,null,'eng');"+"\"", 0, edtPesCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "12" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_get_Internalname, "=>", "", "", StyleString, ClassString, 1, 1, 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock2_Internalname, 1, 1, 0, "Nome da Pessoa", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "14" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesNome_Internalname, StringUtil.RTrim( A13PesNome), 50, 50, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A13PesNome, "@!")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"this.value=this.value.toUpperCase();;GXOnBlur(14);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesNome_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock3_Internalname, 1, 1, 0, "CPF da Pessoa", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "16" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesCPF_Internalname, StringUtil.RTrim( A14PesCPF), 14, 14, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A14PesCPF, "999.999.999-99")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(16);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesCPF_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock4_Internalname, 1, 1, 0, "Data de Nascimento da Pessoa", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "18" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            if ( ( 1 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
            {
               WriteHtmlText( "<table id=\""+edtPesDatNasc_Internalname+"_dp_container\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>") ;
            }
            gx_single_line_edit2( edtPesDatNasc_Internalname, StringUtil.Format(A15PesDatN, "99/99/99"), 8, 8, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( A15PesDatN, "99/99/99"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"gxvdate( this, 8,0,0,1,'eng',false,0);;GXOnBlur(18);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesDatNasc_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            if ( ( 1 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
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
               if ( ( 1 == 1 ) )
               {
                  WriteHtmlText( " document.getElementById(\""+edtPesDatNasc_Internalname+"\").value"+"="+"calendar.date.print(\""+"%m/%d/%y"+"\");"+"calendar.callCloseHandler();") ;
               }
               else
               {
                  WriteHtmlText( "calendar.parseDate("+" document.forms[0]."+edtPesDatNasc_Internalname+".value);"+"calendar.callCloseHandler();") ;
               }
               WriteHtmlText( "}}") ;
               WriteHtmlTextNl( "</script>") ;
            }
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock5_Internalname, 1, 1, 0, "Endereço da Pessoa", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "20" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesEndereco_Internalname, StringUtil.RTrim( A16PesEnde), 50, 50, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A16PesEnde, "")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(20);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesEndereco_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock6_Internalname, 1, 1, 0, "Número do Endereço da Pessoa", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "22" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesEndNumero_Internalname, StringUtil.RTrim( A17PesEndN), 20, 20, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A17PesEndN, "")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(22);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesEndNumero_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock7_Internalname, 1, 1, 0, "Bairro da Pessoa", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "24" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesBairro_Internalname, StringUtil.RTrim( A18PesBair), 50, 50, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A18PesBair, "")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(24);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesBairro_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock8_Internalname, 1, 1, 0, "Email da Pessoa", "", "", 0, lblTextblock8_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "26" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesEmail_Internalname, StringUtil.RTrim( A19PesEmai), 80, 100, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A19PesEmai, "")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(26);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesEmail_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock9_Internalname, 1, 1, 0, "Telefone Residencial da Pessoa", "", "", 0, lblTextblock9_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "28" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesTelefone_Internalname, StringUtil.RTrim( A20PesTele), 15, 15, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A20PesTele, "(99) 9999-9999")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(28);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesTelefone_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock10_Internalname, 1, 1, 0, "Telefone Celular da Pessoa", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "30" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtPesCelular_Internalname, StringUtil.RTrim( A21PesCelu), 15, 15, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A21PesCelu, "(99) 9999-9999")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(30);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtPesCelular_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock11_Internalname, 1, 1, 0, "Situação da Pessoa", "", "", 0, lblTextblock11_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "32" + "," + "''" + "," + "0" + ")\"" ;
            cmbPesSituacao.CurrentValue = StringUtil.Str( (decimal)(A22PesSitu), 1, 0) ;
            /* ComboBox */
            gx_combobox_ctrl( cmbPesSituacao, cmbPesSituacao_Internalname, StringUtil.Str( (decimal)(A22PesSitu), 1, 0), "int", 1, 1, 1, 2, StyleString, ClassString, "", 0, cmbPesSituacao_Jsonclick, "", TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(32);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock12_Internalname, 1, 1, 0, "Código do Estado", "", "", 0, lblTextblock12_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtEstCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A23EstCodi), 9, 0, ".", "")), 9, 9, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A23EstCodi), "ZZZZZZZZ9"), "", 0, edtEstCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock13_Internalname, 1, 1, 0, "UF do Estado", "", "", 0, lblTextblock13_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtEstUF_Internalname, StringUtil.RTrim( A24EstUF), 2, 2, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A24EstUF, "@!")), "", 0, edtEstUF_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock14_Internalname, 1, 1, 0, "Nome do Estado", "", "", 0, lblTextblock14_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtEstNome_Internalname, StringUtil.RTrim( A25EstNome), 50, 50, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A25EstNome, "@!")), "", 0, edtEstNome_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock15_Internalname, 1, 1, 0, "Código da Cidade", "", "", 0, lblTextblock15_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "40" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCidCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A26CidCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A26CidCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(40);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtCidCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            /* Static images/pictures */
            ClassString = "S8" ;
            StyleString = "" + "" ;
            gx_bitmap( imgprompt_26_Internalname, "", "prompt.gif", 1, 0, "", "", 0, 0, 0, 0, 0, 0, imgprompt_26_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock16_Internalname, 1, 1, 0, "Nome da Cidade", "", "", 0, lblTextblock16_Jsonclick, "", StyleString, ClassString, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCidNome_Internalname, StringUtil.RTrim( A27CidNome), 50, 50, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A27CidNome, "@!")), "", 0, edtCidNome_Jsonclick, "", 0, 0, 1, "'HLP_TPessoa.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table2_9_011e( true) ;
         }
         else
         {
            wb_table2_9_011e( false) ;
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
               Z12PesCodi = (int)(NumberUtil.CToN( cgiGet( "Z12PesCodi"), "", "")) ;
               Z13PesNome = GXUtil.ValueDecode( cgiGet( "Z13PesNome")) ;
               Z14PesCPF = GXUtil.ValueDecode( cgiGet( "Z14PesCPF")) ;
               Z15PesDatN = DateTimeUtil.CToD( cgiGet( "Z15PesDatN"), 0) ;
               Z16PesEnde = GXUtil.ValueDecode( cgiGet( "Z16PesEnde")) ;
               Z17PesEndN = GXUtil.ValueDecode( cgiGet( "Z17PesEndN")) ;
               Z18PesBair = GXUtil.ValueDecode( cgiGet( "Z18PesBair")) ;
               Z19PesEmai = GXUtil.ValueDecode( cgiGet( "Z19PesEmai")) ;
               Z20PesTele = GXUtil.ValueDecode( cgiGet( "Z20PesTele")) ;
               Z21PesCelu = GXUtil.ValueDecode( cgiGet( "Z21PesCelu")) ;
               Z22PesSitu = (short)(NumberUtil.CToN( cgiGet( "Z22PesSitu"), "", "")) ;
               Z26CidCodi = (int)(NumberUtil.CToN( cgiGet( "Z26CidCodi"), "", "")) ;
               IsConfirmed = (short)(NumberUtil.CToN( cgiGet( "IsConfirmed"), "", "")) ;
               IsModified = (short)(NumberUtil.CToN( cgiGet( "IsModified"), "", "")) ;
               Gx_mode = GXUtil.ValueDecode( cgiGet( "Mode")) ;
               context.sCallerURL = GXUtil.ValueDecode( cgiGet( "sCallerURL")) ;
               /* Read subfile selected row values. */
               /* Read variables values. */
               if ( ( ( NumberUtil.CToN( cgiGet( edtPesCodigo_Internalname), "", "") < Convert.ToDecimal( 0 )) ) || ( ( NumberUtil.CToN( cgiGet( edtPesCodigo_Internalname), "", "") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("badnum"), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtPesCodigo_Internalname ;
                  wbErr = true ;
                  A12PesCodi = (int)(0M) ;
               }
               else
               {
                  A12PesCodi = (int)(NumberUtil.CToN( cgiGet( edtPesCodigo_Internalname), "", "")) ;
               }
               A13PesNome = StringUtil.Upper( cgiGet( edtPesNome_Internalname)) ;
               n13PesNome = false ;
               n13PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A13PesNome).TrimEnd(' ') )==0)) ? true : false) ;
               A14PesCPF = cgiGet( edtPesCPF_Internalname) ;
               n14PesCPF = false ;
               n14PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
               if ( ( DateTimeUtil.VCDate( cgiGet( edtPesDatNasc_Internalname), 1) == 0 ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("faildate", new   object[]  {"Data de Nascimento da Pessoa"}), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtPesDatNasc_Internalname ;
                  wbErr = true ;
                  A15PesDatN = (DateTime)(DateTime.MinValue) ;
                  n15PesDatN = false ;
               }
               else
               {
                  A15PesDatN = DateTimeUtil.CToD( cgiGet( edtPesDatNasc_Internalname), 1) ;
                  n15PesDatN = false ;
               }
               n15PesDatN = (((DateTime.MinValue==A15PesDatN)) ? true : false) ;
               A16PesEnde = cgiGet( edtPesEndereco_Internalname) ;
               n16PesEnde = false ;
               n16PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A16PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
               A17PesEndN = cgiGet( edtPesEndNumero_Internalname) ;
               n17PesEndN = false ;
               n17PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
               A18PesBair = cgiGet( edtPesBairro_Internalname) ;
               n18PesBair = false ;
               n18PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesBair).TrimEnd(' ') )==0)) ? true : false) ;
               A19PesEmai = cgiGet( edtPesEmail_Internalname) ;
               n19PesEmai = false ;
               n19PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
               A20PesTele = cgiGet( edtPesTelefone_Internalname) ;
               n20PesTele = false ;
               n20PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesTele).TrimEnd(' ') )==0)) ? true : false) ;
               A21PesCelu = cgiGet( edtPesCelular_Internalname) ;
               n21PesCelu = false ;
               n21PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
               cmbPesSituacao.CurrentValue = cgiGet( cmbPesSituacao_Internalname) ;
               A22PesSitu = (short)(NumberUtil.Val( cgiGet( cmbPesSituacao_Internalname), ".")) ;
               n22PesSitu = false ;
               n22PesSitu = (((0==A22PesSitu)) ? true : false) ;
               A23EstCodi = (int)(NumberUtil.CToN( cgiGet( edtEstCodigo_Internalname), "", "")) ;
               n23EstCodi = false ;
               A24EstUF = StringUtil.Upper( cgiGet( edtEstUF_Internalname)) ;
               n24EstUF = false ;
               A25EstNome = StringUtil.Upper( cgiGet( edtEstNome_Internalname)) ;
               n25EstNome = false ;
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
               n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
               A27CidNome = StringUtil.Upper( cgiGet( edtCidNome_Internalname)) ;
               n27CidNome = false ;
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
               InitAll011( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  ZM011( 3) ;
                  ZM011( 4) ;
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( ( AnyError == 0 ) )
         {
            IsConfirmed = 1 ;
         }
         if ( ( AnyError == 0 ) )
         {
            ConfirmValues010( ) ;
         }
      }

      protected void ResetCaption010( )
      {
         IsConfirmed = 0 ;
      }

      protected void ZM011( int GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z13PesNome = T00013_A13PesNome[0] ;
               Z14PesCPF = T00013_A14PesCPF[0] ;
               Z15PesDatN = T00013_A15PesDatN[0] ;
               Z16PesEnde = T00013_A16PesEnde[0] ;
               Z17PesEndN = T00013_A17PesEndN[0] ;
               Z18PesBair = T00013_A18PesBair[0] ;
               Z19PesEmai = T00013_A19PesEmai[0] ;
               Z20PesTele = T00013_A20PesTele[0] ;
               Z21PesCelu = T00013_A21PesCelu[0] ;
               Z22PesSitu = T00013_A22PesSitu[0] ;
               Z26CidCodi = T00013_A26CidCodi[0] ;
            }
            else
            {
               Z13PesNome = A13PesNome ;
               Z14PesCPF = A14PesCPF ;
               Z15PesDatN = A15PesDatN ;
               Z16PesEnde = A16PesEnde ;
               Z17PesEndN = A17PesEndN ;
               Z18PesBair = A18PesBair ;
               Z19PesEmai = A19PesEmai ;
               Z20PesTele = A20PesTele ;
               Z21PesCelu = A21PesCelu ;
               Z22PesSitu = A22PesSitu ;
               Z26CidCodi = A26CidCodi ;
            }
         }
         if ( ( GX_JID == -2 ) )
         {
            Z12PesCodi = A12PesCodi ;
            Z13PesNome = A13PesNome ;
            Z14PesCPF = A14PesCPF ;
            Z15PesDatN = A15PesDatN ;
            Z16PesEnde = A16PesEnde ;
            Z17PesEndN = A17PesEndN ;
            Z18PesBair = A18PesBair ;
            Z19PesEmai = A19PesEmai ;
            Z20PesTele = A20PesTele ;
            Z21PesCelu = A21PesCelu ;
            Z22PesSitu = A22PesSitu ;
            Z26CidCodi = A26CidCodi ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_26_Link = ((String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') )==0) ? "" : "javascript:"+"HGx0050("+"document.forms[0]."+"CIDCODIGO"+");") ;
      }

      protected void standaloneModal( )
      {
      }

      protected void Load011( )
      {
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A12PesCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound1 = 1 ;
            A13PesNome = T00016_A13PesNome[0] ;
            n13PesNome = T00016_n13PesNome[0] ;
            A14PesCPF = T00016_A14PesCPF[0] ;
            n14PesCPF = T00016_n14PesCPF[0] ;
            A15PesDatN = T00016_A15PesDatN[0] ;
            n15PesDatN = T00016_n15PesDatN[0] ;
            A16PesEnde = T00016_A16PesEnde[0] ;
            n16PesEnde = T00016_n16PesEnde[0] ;
            A17PesEndN = T00016_A17PesEndN[0] ;
            n17PesEndN = T00016_n17PesEndN[0] ;
            A18PesBair = T00016_A18PesBair[0] ;
            n18PesBair = T00016_n18PesBair[0] ;
            A19PesEmai = T00016_A19PesEmai[0] ;
            n19PesEmai = T00016_n19PesEmai[0] ;
            A20PesTele = T00016_A20PesTele[0] ;
            n20PesTele = T00016_n20PesTele[0] ;
            A21PesCelu = T00016_A21PesCelu[0] ;
            n21PesCelu = T00016_n21PesCelu[0] ;
            A22PesSitu = T00016_A22PesSitu[0] ;
            n22PesSitu = T00016_n22PesSitu[0] ;
            A24EstUF = T00016_A24EstUF[0] ;
            n24EstUF = T00016_n24EstUF[0] ;
            A25EstNome = T00016_A25EstNome[0] ;
            n25EstNome = T00016_n25EstNome[0] ;
            A27CidNome = T00016_A27CidNome[0] ;
            n27CidNome = T00016_n27CidNome[0] ;
            A26CidCodi = T00016_A26CidCodi[0] ;
            n26CidCodi = T00016_n26CidCodi[0] ;
            A23EstCodi = T00016_A23EstCodi[0] ;
            n23EstCodi = T00016_n23EstCodi[0] ;
            ZM011( -2) ;
         }
         pr_default.close(4);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( ! ( ((DateTime.MinValue==A15PesDatN)) || ( A15PesDatN >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Data de Nascimento da Pessoa is out of range", "OutOfRange", 1);
            AnyError = 1 ;
         }
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( ((0==A26CidCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Cidades'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCidCodigo_Internalname ;
            }
         }
         A27CidNome = T00014_A27CidNome[0] ;
         n27CidNome = T00014_n27CidNome[0] ;
         A23EstCodi = T00014_A23EstCodi[0] ;
         n23EstCodi = T00014_n23EstCodi[0] ;
         pr_default.close(2);
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {n23EstCodi, A23EstCodi});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( ((0==A23EstCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Estados'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
            }
         }
         A24EstUF = T00015_A24EstUF[0] ;
         n24EstUF = T00015_n24EstUF[0] ;
         A25EstNome = T00015_A25EstNome[0] ;
         n25EstNome = T00015_n25EstNome[0] ;
         pr_default.close(3);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
         if ( ( IsConfirmed == 0 ) )
         {
            bttBtn_delete_Enabled = RcdFound1 ;
         }
         else
         {
            bttBtn_delete_Enabled = 0 ;
         }
      }

      protected void gxLoad_3( int A26CidCodi )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( ((0==A26CidCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Cidades'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCidCodigo_Internalname ;
            }
         }
         A27CidNome = T00017_A27CidNome[0] ;
         n27CidNome = T00017_n27CidNome[0] ;
         A23EstCodi = T00017_A23EstCodi[0] ;
         n23EstCodi = T00017_n23EstCodi[0] ;
         wbTemp = context.ResponseContentType( "text/html") ;
         wbTemp = context.SetHeader( "pragma", "no-cache") ;
         context.GX_webresponse.AppendHeader("Content-Type", "text/plain;charset=utf-8");
         wbTemp = context.SetHeader( "Cache-Control", "max-age=0") ;
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A27CidNome))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A23EstCodi), 9, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_4( int A23EstCodi )
      {
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {n23EstCodi, A23EstCodi});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( ((0==A23EstCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Estados'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
            }
         }
         A24EstUF = T00018_A24EstUF[0] ;
         n24EstUF = T00018_n24EstUF[0] ;
         A25EstNome = T00018_A25EstNome[0] ;
         n25EstNome = T00018_n25EstNome[0] ;
         wbTemp = context.ResponseContentType( "text/html") ;
         wbTemp = context.SetHeader( "pragma", "no-cache") ;
         context.GX_webresponse.AppendHeader("Content-Type", "text/plain;charset=utf-8");
         wbTemp = context.SetHeader( "Cache-Control", "max-age=0") ;
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A24EstUF))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A25EstNome))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey011( )
      {
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A12PesCodi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound1 = 1 ;
         }
         else
         {
            RcdFound1 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A12PesCodi});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 2) ;
            RcdFound1 = 1 ;
            A12PesCodi = T00013_A12PesCodi[0] ;
            A13PesNome = T00013_A13PesNome[0] ;
            n13PesNome = T00013_n13PesNome[0] ;
            A14PesCPF = T00013_A14PesCPF[0] ;
            n14PesCPF = T00013_n14PesCPF[0] ;
            A15PesDatN = T00013_A15PesDatN[0] ;
            n15PesDatN = T00013_n15PesDatN[0] ;
            A16PesEnde = T00013_A16PesEnde[0] ;
            n16PesEnde = T00013_n16PesEnde[0] ;
            A17PesEndN = T00013_A17PesEndN[0] ;
            n17PesEndN = T00013_n17PesEndN[0] ;
            A18PesBair = T00013_A18PesBair[0] ;
            n18PesBair = T00013_n18PesBair[0] ;
            A19PesEmai = T00013_A19PesEmai[0] ;
            n19PesEmai = T00013_n19PesEmai[0] ;
            A20PesTele = T00013_A20PesTele[0] ;
            n20PesTele = T00013_n20PesTele[0] ;
            A21PesCelu = T00013_A21PesCelu[0] ;
            n21PesCelu = T00013_n21PesCelu[0] ;
            A22PesSitu = T00013_A22PesSitu[0] ;
            n22PesSitu = T00013_n22PesSitu[0] ;
            A26CidCodi = T00013_A26CidCodi[0] ;
            n26CidCodi = T00013_n26CidCodi[0] ;
            Z12PesCodi = A12PesCodi ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load011( ) ;
            Gx_mode = sMode1 ;
         }
         else
         {
            RcdFound1 = 0 ;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode1 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( ( RcdFound1 == 0 ) )
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
         RcdFound1 = 0 ;
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A12PesCodi});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000110_A12PesCodi[0] < A12PesCodi ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000110_A12PesCodi[0] > A12PesCodi ) ) )
            {
               A12PesCodi = T000110_A12PesCodi[0] ;
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T000111 */
         pr_default.execute(9, new Object[] {A12PesCodi});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000111_A12PesCodi[0] > A12PesCodi ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000111_A12PesCodi[0] < A12PesCodi ) ) )
            {
               A12PesCodi = T000111_A12PesCodi[0] ;
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey011( ) ;
         if ( ( RcdFound1 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtPesCodigo_Internalname ;
            }
            else if ( ( A12PesCodi != Z12PesCodi ) )
            {
               A12PesCodi = Z12PesCodi ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "CandidateKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtPesCodigo_Internalname ;
            }
            else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               if ( ( IsConfirmed == 1 ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPesCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "DLT" ;
                  /* Confirm record */
                  CONFIRM_010( ) ;
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
                  Update011( ) ;
                  GX_FocusControl = edtPesCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_010( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     GX_FocusControl = bttBtn_enter_Internalname ;
                  }
               }
            }
         }
         else
         {
            if ( ( A12PesCodi != Z12PesCodi ) )
            {
               Gx_mode = "INS" ;
               if ( ( IsConfirmed == 1 ) )
               {
                  /* Insert record */
                  Insert011( ) ;
                  GX_FocusControl = edtPesCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_010( ) ;
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
                  GX_FocusControl = edtPesCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  if ( ( IsConfirmed == 1 ) )
                  {
                     /* Insert record */
                     Insert011( ) ;
                     GX_FocusControl = edtPesCodigo_Internalname ;
                  }
                  else
                  {
                     /* Confirm record */
                     CONFIRM_010( ) ;
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
         if ( ( A12PesCodi != Z12PesCodi ) )
         {
            A12PesCodi = Z12PesCodi ;
            GX_msglist.addItem(GXResourceManager.GetMessage("getbeforedlt"), 1);
            AnyError = 1 ;
            GX_FocusControl = edtPesCodigo_Internalname ;
         }
         else
         {
            if ( ( IsConfirmed == 1 ) )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtPesCodigo_Internalname ;
            }
            else
            {
               Gx_mode = "DLT" ;
               /* Confirm record */
               CONFIRM_010( ) ;
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
         GetKey011( ) ;
         if ( ( RcdFound1 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtPesCodigo_Internalname ;
            }
            else if ( ( A12PesCodi != Z12PesCodi ) )
            {
               A12PesCodi = Z12PesCodi ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtPesCodigo_Internalname ;
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
            if ( ( A12PesCodi != Z12PesCodi ) )
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
                  GX_FocusControl = edtPesCodigo_Internalname ;
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
         context.RollbackDataStores("TPessoa");
         GX_FocusControl = edtPesNome_Internalname ;
      }

      protected void insert_Check( )
      {
         CONFIRM_010( ) ;
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
         if ( ( RcdFound1 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("keynfound"), "PrimaryKeyNotFound", 1);
            AnyError = 1 ;
         }
         GX_FocusControl = edtPesNome_Internalname ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart011( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtPesNome_Internalname ;
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtPesNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtPesNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart011( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            while ( ( RcdFound1 != 0 ) )
            {
               ScanNext011( ) ;
            }
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtPesNome_Internalname ;
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A12PesCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("lock", new   object[]  {"PESSOA"}), "RecordIsLocked", 1);
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(0) == 101) || ( String.CompareOrdinal(Z13PesNome.TrimEnd(' '), T00012_A13PesNome[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z14PesCPF.TrimEnd(' '), T00012_A14PesCPF[0].TrimEnd(' ') ) != 0 ) || ( Z15PesDatN != T00012_A15PesDatN[0] ) || ( String.CompareOrdinal(Z16PesEnde.TrimEnd(' '), T00012_A16PesEnde[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z17PesEndN.TrimEnd(' '), T00012_A17PesEndN[0].TrimEnd(' ') ) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( String.CompareOrdinal(Z18PesBair.TrimEnd(' '), T00012_A18PesBair[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z19PesEmai.TrimEnd(' '), T00012_A19PesEmai[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z20PesTele.TrimEnd(' '), T00012_A20PesTele[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z21PesCelu.TrimEnd(' '), T00012_A21PesCelu[0].TrimEnd(' ') ) != 0 ) || ( Z22PesSitu != T00012_A22PesSitu[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z26CidCodi != T00012_A26CidCodi[0] ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("waschg", new   object[]  {"PESSOA"}), "RecordWasChanged", 1);
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM011( 2) ;
            CheckOptimisticConcurrency011( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert011( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000112 */
                     pr_default.execute(10, new Object[] {n13PesNome, A13PesNome, n14PesCPF, A14PesCPF, n15PesDatN, A15PesDatN, n16PesEnde, A16PesEnde, n17PesEndN, A17PesEndN, n18PesBair, A18PesBair, n19PesEmai, A19PesEmai, n20PesTele, A20PesTele, n21PesCelu, A21PesCelu, n22PesSitu, A22PesSitu, n26CidCodi, A26CidCodi});
                     pr_default.close(10);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000113 */
                     pr_default.execute(11);
                     A12PesCodi = T000113_A12PesCodi[0] ;
                     pr_default.close(11);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucadded"), 0);
                           ResetCaption010( ) ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate011( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000114 */
                     pr_default.execute(12, new Object[] {n13PesNome, A13PesNome, n14PesCPF, A14PesCPF, n15PesDatN, A15PesDatN, n16PesEnde, A16PesEnde, n17PesEndN, A17PesEndN, n18PesBair, A18PesBair, n19PesEmai, A19PesEmai, n20PesTele, A20PesTele, n21PesCelu, A21PesCelu, n22PesSitu, A22PesSitu, n26CidCodi, A26CidCodi, A12PesCodi});
                     pr_default.close(12);
                     DeferredUpdate011( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucupdated"), 0);
                           ResetCaption010( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls011( ) ;
            /* No cascading delete specified. */
            AfterConfirm011( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000115 */
                  pr_default.execute(13, new Object[] {A12PesCodi});
                  pr_default.close(13);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        move_next( ) ;
                        if ( ( RcdFound1 == 0 ) )
                        {
                           InitAll011( ) ;
                           Gx_mode = "INS" ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                        }
                        GX_msglist.addItem(GXResourceManager.GetMessage("sucdeleted"), 0);
                        ResetCaption010( ) ;
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
         sMode1 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel011( ) ;
         Gx_mode = sMode1 ;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000116 */
            pr_default.execute(14, new Object[] {n26CidCodi, A26CidCodi});
            A27CidNome = T000116_A27CidNome[0] ;
            n27CidNome = T000116_n27CidNome[0] ;
            A23EstCodi = T000116_A23EstCodi[0] ;
            n23EstCodi = T000116_n23EstCodi[0] ;
            pr_default.close(14);
            /* Using cursor T000117 */
            pr_default.execute(15, new Object[] {n23EstCodi, A23EstCodi});
            A24EstUF = T000117_A24EstUF[0] ;
            n24EstUF = T000117_n24EstUF[0] ;
            A25EstNome = T000117_A25EstNome[0] ;
            n25EstNome = T000117_n25EstNome[0] ;
            pr_default.close(15);
         }
      }

      protected void EndLevel011( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            pr_default.close(1);
            pr_default.close(14);
            pr_default.close(15);
            context.CommitDataStores("TPessoa");
            if ( ( AnyError == 0 ) )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(14);
            pr_default.close(15);
            context.RollbackDataStores("TPessoa");
         }
         IsModified = 0 ;
         if ( ( AnyError != 0 ) )
         {
            context.wjLoc = "" ;
         }
      }

      protected void ScanStart011( )
      {
         /* Using cursor T000118 */
         pr_default.execute(16);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound1 = 1 ;
            A12PesCodi = T000118_A12PesCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         pr_default.readNext(16);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound1 = 1 ;
            A12PesCodi = T000118_A12PesCodi[0] ;
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues010( )
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
         WriteHtmlText( "Cadastro de Pessoas") ;
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
         WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return GXValidForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" ACTION=\""+formatLink("tpessoa.aspx") +"\""+">") ;
         gx_hidden_field( "_EventName", "");
         gx_hidden_field( "_EventGridId", "");
         gx_hidden_field( "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm011( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         gx_hidden_field( "Z12PesCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z12PesCodi), 9, 0, ".", "")));
         gx_hidden_field( "Z13PesNome", StringUtil.RTrim( Z13PesNome));
         gx_hidden_field( "Z14PesCPF", StringUtil.RTrim( Z14PesCPF));
         gx_hidden_field( "Z15PesDatN", DateTimeUtil.DToC( Z15PesDatN, 0, "/"));
         gx_hidden_field( "Z16PesEnde", StringUtil.RTrim( Z16PesEnde));
         gx_hidden_field( "Z17PesEndN", StringUtil.RTrim( Z17PesEndN));
         gx_hidden_field( "Z18PesBair", StringUtil.RTrim( Z18PesBair));
         gx_hidden_field( "Z19PesEmai", StringUtil.RTrim( Z19PesEmai));
         gx_hidden_field( "Z20PesTele", StringUtil.RTrim( Z20PesTele));
         gx_hidden_field( "Z21PesCelu", StringUtil.RTrim( Z21PesCelu));
         gx_hidden_field( "Z22PesSitu", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22PesSitu), 1, 0, ".", "")));
         gx_hidden_field( "Z26CidCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26CidCodi), 9, 0, ".", "")));
         gx_hidden_field( "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         gx_hidden_field( "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         gx_hidden_field( "Mode", StringUtil.RTrim( Gx_mode));
         gx_hidden_field( "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         WriteHtmlTextNl( "</body>") ;
         WriteHtmlTextNl( "</html>") ;
      }

      protected void InitializeNonKey011( )
      {
         A13PesNome = "" ;
         n13PesNome = false ;
         n13PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A13PesNome).TrimEnd(' ') )==0)) ? true : false) ;
         A14PesCPF = "" ;
         n14PesCPF = false ;
         n14PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
         A15PesDatN = (DateTime)(DateTime.MinValue) ;
         n15PesDatN = false ;
         n15PesDatN = (((DateTime.MinValue==A15PesDatN)) ? true : false) ;
         A16PesEnde = "" ;
         n16PesEnde = false ;
         n16PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A16PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
         A17PesEndN = "" ;
         n17PesEndN = false ;
         n17PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
         A18PesBair = "" ;
         n18PesBair = false ;
         n18PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesBair).TrimEnd(' ') )==0)) ? true : false) ;
         A19PesEmai = "" ;
         n19PesEmai = false ;
         n19PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
         A20PesTele = "" ;
         n20PesTele = false ;
         n20PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesTele).TrimEnd(' ') )==0)) ? true : false) ;
         A21PesCelu = "" ;
         n21PesCelu = false ;
         n21PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
         A22PesSitu = 0 ;
         n22PesSitu = false ;
         n22PesSitu = (((0==A22PesSitu)) ? true : false) ;
         A23EstCodi = 0 ;
         n23EstCodi = false ;
         A24EstUF = "" ;
         n24EstUF = false ;
         A25EstNome = "" ;
         n25EstNome = false ;
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
         A27CidNome = "" ;
         n27CidNome = false ;
      }

      protected void InitAll011( )
      {
         A12PesCodi = 0 ;
         InitializeNonKey011( ) ;
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
            WriteHtmlTextNl( "var wHGx0050=null;") ;
            WriteHtmlTextNl( "var wHGx0010=null;") ;
            WriteHtmlTextNl( "var wHGx0010=null;") ;
            WriteHtmlTextNl( "var GXISGET=false;") ;
            /* Set focus on 'active' control (if any). */
            if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( GX_FocusControl).TrimEnd(' ') )==0)) )
            {
               WriteHtmlTextNl( "GXSetUserFocus(document.forms[0]."+GX_FocusControl+");") ;
            }
            WriteHtmlTextNl( "function onCloseHGx0050()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0050(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "if (!gxCheckControlConds('PROMPT_26', '_', 0, [40],isMod)) {return;}") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:false};") ;
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
            WriteHtmlTextNl( "function onCloseHGx0010()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0010(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0010== null || wHGx0010.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0010;") ;
            WriteHtmlTextNl( "GXISGET = false;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0010=open(\"") ;
            WriteHtmlText( "hgx0010.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0010.focus();") ;
            WriteHtmlTextNl( "if (isMod != null) GXSetRowModified(isMod);") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function onCloseHGx0010()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0010(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0010== null || wHGx0010.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0010;") ;
            WriteHtmlText( "document.forms[0]._EventName.value='"+"';") ;
            WriteHtmlTextNl( "GXISGET = true;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0010=open(\"") ;
            WriteHtmlText( "hgx0010.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0010.focus();") ;
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
         WriteHtmlTextNl( "obj."+"PESNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESCPF.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESENDERECO.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESENDNUMERO.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESBAIRRO.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESEMAIL.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESTELEFONE.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESCELULAR.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"PESSITUACAO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"ESTCODIGO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"ESTUF.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"ESTNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"CIDCODIGO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"CIDNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "}") ;
         WriteHtmlTextNl( "</script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "form_onchange.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "std_messages.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxvdate.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gx_help.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "tpessoa.js")+"\"></script>") ;
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
               sEventJsCode = "HGx0010(" + "document.forms[0]." + "PESCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0010(" + "document.forms[0]." + "PESCODIGO" + ");" ;
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
                     sEventJsCode = "HGx0010(" + "document.forms[0]." + "PESCODIGO" + ");" ;
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
            sEventJsCode = "HGx0010(" + "document.forms[0]." + "PESCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0010(" + "document.forms[0]." + "PESCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0010(" + "document.forms[0]." + "PESCODIGO" + ");" + "return false;" ;
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
         edtPesCodigo_Internalname = "PESCODIGO" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtPesNome_Internalname = "PESNOME" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtPesCPF_Internalname = "PESCPF" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtPesDatNasc_Internalname = "PESDATNASC" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtPesEndereco_Internalname = "PESENDERECO" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtPesEndNumero_Internalname = "PESENDNUMERO" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtPesBairro_Internalname = "PESBAIRRO" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtPesEmail_Internalname = "PESEMAIL" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtPesTelefone_Internalname = "PESTELEFONE" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtPesCelular_Internalname = "PESCELULAR" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         cmbPesSituacao_Internalname = "PESSITUACAO" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtEstCodigo_Internalname = "ESTCODIGO" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         edtEstUF_Internalname = "ESTUF" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtEstNome_Internalname = "ESTNOME" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         edtCidCodigo_Internalname = "CIDCODIGO" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         edtCidNome_Internalname = "CIDNOME" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_26_Internalname = "PROMPT_26" ;
         edtCidNome_Jsonclick = "" ;
         imgprompt_26_Link = "" ;
         edtCidCodigo_Jsonclick = "" ;
         edtEstNome_Jsonclick = "" ;
         edtEstUF_Jsonclick = "" ;
         edtEstCodigo_Jsonclick = "" ;
         cmbPesSituacao_Jsonclick = "" ;
         edtPesCelular_Jsonclick = "" ;
         edtPesTelefone_Jsonclick = "" ;
         edtPesEmail_Jsonclick = "" ;
         edtPesBairro_Jsonclick = "" ;
         edtPesEndNumero_Jsonclick = "" ;
         edtPesEndereco_Jsonclick = "" ;
         edtPesDatNasc_Jsonclick = "" ;
         edtPesCPF_Jsonclick = "" ;
         edtPesNome_Jsonclick = "" ;
         edtPesCodigo_Jsonclick = "" ;
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
         pr_default.close(14);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         RcdFound1 = 0 ;
         GxWebError = 0 ;
         scmdbuf = "" ;
         gxajaxcallmode = 0 ;
         gxfirstwebparm = "" ;
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         A23EstCodi = 0 ;
         n23EstCodi = false ;
         lblTextblock1_Name = "" ;
         lblTextblock2_Name = "" ;
         lblTextblock3_Name = "" ;
         lblTextblock4_Name = "" ;
         lblTextblock5_Name = "" ;
         lblTextblock6_Name = "" ;
         lblTextblock7_Name = "" ;
         lblTextblock8_Name = "" ;
         lblTextblock9_Name = "" ;
         lblTextblock10_Name = "" ;
         lblTextblock11_Name = "" ;
         lblTextblock12_Name = "" ;
         lblTextblock13_Name = "" ;
         lblTextblock14_Name = "" ;
         lblTextblock15_Name = "" ;
         lblTextblock16_Name = "" ;
         IsConfirmed = 0 ;
         IsModified = 0 ;
         AnyError = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         edtPesCodigo_Internalname = "" ;
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
         A12PesCodi = 0 ;
         edtPesCodigo_Jsonclick = "" ;
         bttBtn_get_Internalname = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock2_Internalname = "" ;
         lblTextblock2_Jsonclick = "" ;
         edtPesNome_Internalname = "" ;
         A13PesNome = "" ;
         edtPesNome_Jsonclick = "" ;
         lblTextblock3_Internalname = "" ;
         lblTextblock3_Jsonclick = "" ;
         edtPesCPF_Internalname = "" ;
         A14PesCPF = "" ;
         edtPesCPF_Jsonclick = "" ;
         lblTextblock4_Internalname = "" ;
         lblTextblock4_Jsonclick = "" ;
         edtPesDatNasc_Internalname = "" ;
         A15PesDatN = (DateTime)(DateTime.MinValue) ;
         edtPesDatNasc_Jsonclick = "" ;
         gxCalCtrlInc = 0 ;
         lblTextblock5_Internalname = "" ;
         lblTextblock5_Jsonclick = "" ;
         edtPesEndereco_Internalname = "" ;
         A16PesEnde = "" ;
         edtPesEndereco_Jsonclick = "" ;
         lblTextblock6_Internalname = "" ;
         lblTextblock6_Jsonclick = "" ;
         edtPesEndNumero_Internalname = "" ;
         A17PesEndN = "" ;
         edtPesEndNumero_Jsonclick = "" ;
         lblTextblock7_Internalname = "" ;
         lblTextblock7_Jsonclick = "" ;
         edtPesBairro_Internalname = "" ;
         A18PesBair = "" ;
         edtPesBairro_Jsonclick = "" ;
         lblTextblock8_Internalname = "" ;
         lblTextblock8_Jsonclick = "" ;
         edtPesEmail_Internalname = "" ;
         A19PesEmai = "" ;
         edtPesEmail_Jsonclick = "" ;
         lblTextblock9_Internalname = "" ;
         lblTextblock9_Jsonclick = "" ;
         edtPesTelefone_Internalname = "" ;
         A20PesTele = "" ;
         edtPesTelefone_Jsonclick = "" ;
         lblTextblock10_Internalname = "" ;
         lblTextblock10_Jsonclick = "" ;
         edtPesCelular_Internalname = "" ;
         A21PesCelu = "" ;
         edtPesCelular_Jsonclick = "" ;
         lblTextblock11_Internalname = "" ;
         lblTextblock11_Jsonclick = "" ;
         A22PesSitu = 0 ;
         cmbPesSituacao_Internalname = "" ;
         cmbPesSituacao_Jsonclick = "" ;
         lblTextblock12_Internalname = "" ;
         lblTextblock12_Jsonclick = "" ;
         edtEstCodigo_Internalname = "" ;
         edtEstCodigo_Jsonclick = "" ;
         lblTextblock13_Internalname = "" ;
         lblTextblock13_Jsonclick = "" ;
         edtEstUF_Internalname = "" ;
         A24EstUF = "" ;
         edtEstUF_Jsonclick = "" ;
         lblTextblock14_Internalname = "" ;
         lblTextblock14_Jsonclick = "" ;
         edtEstNome_Internalname = "" ;
         A25EstNome = "" ;
         edtEstNome_Jsonclick = "" ;
         lblTextblock15_Internalname = "" ;
         lblTextblock15_Jsonclick = "" ;
         edtCidCodigo_Internalname = "" ;
         edtCidCodigo_Jsonclick = "" ;
         imgprompt_26_Internalname = "" ;
         imgprompt_26_Link = "" ;
         lblTextblock16_Internalname = "" ;
         lblTextblock16_Jsonclick = "" ;
         edtCidNome_Internalname = "" ;
         A27CidNome = "" ;
         edtCidNome_Jsonclick = "" ;
         Z12PesCodi = 0 ;
         Z13PesNome = "" ;
         Z14PesCPF = "" ;
         Z15PesDatN = (DateTime)(DateTime.MinValue) ;
         Z16PesEnde = "" ;
         Z17PesEndN = "" ;
         Z18PesBair = "" ;
         Z19PesEmai = "" ;
         Z20PesTele = "" ;
         Z21PesCelu = "" ;
         Z22PesSitu = 0 ;
         Z26CidCodi = 0 ;
         Gx_mode = "" ;
         n13PesNome = false ;
         n14PesCPF = false ;
         n15PesDatN = false ;
         n16PesEnde = false ;
         n17PesEndN = false ;
         n18PesBair = false ;
         n19PesEmai = false ;
         n20PesTele = false ;
         n21PesCelu = false ;
         n22PesSitu = false ;
         n24EstUF = false ;
         n25EstNome = false ;
         n27CidNome = false ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GX_JID = 0 ;
         T00016_A12PesCodi = new int[1] ;
         T00016_A13PesNome = new String[] {""} ;
         T00016_n13PesNome = new bool[] {false} ;
         T00016_A14PesCPF = new String[] {""} ;
         T00016_n14PesCPF = new bool[] {false} ;
         T00016_A15PesDatN = new DateTime[] {DateTime.MinValue} ;
         T00016_n15PesDatN = new bool[] {false} ;
         T00016_A16PesEnde = new String[] {""} ;
         T00016_n16PesEnde = new bool[] {false} ;
         T00016_A17PesEndN = new String[] {""} ;
         T00016_n17PesEndN = new bool[] {false} ;
         T00016_A18PesBair = new String[] {""} ;
         T00016_n18PesBair = new bool[] {false} ;
         T00016_A19PesEmai = new String[] {""} ;
         T00016_n19PesEmai = new bool[] {false} ;
         T00016_A20PesTele = new String[] {""} ;
         T00016_n20PesTele = new bool[] {false} ;
         T00016_A21PesCelu = new String[] {""} ;
         T00016_n21PesCelu = new bool[] {false} ;
         T00016_A22PesSitu = new short[1] ;
         T00016_n22PesSitu = new bool[] {false} ;
         T00016_A24EstUF = new String[] {""} ;
         T00016_n24EstUF = new bool[] {false} ;
         T00016_A25EstNome = new String[] {""} ;
         T00016_n25EstNome = new bool[] {false} ;
         T00016_A27CidNome = new String[] {""} ;
         T00016_n27CidNome = new bool[] {false} ;
         T00016_A26CidCodi = new int[1] ;
         T00016_n26CidCodi = new bool[] {false} ;
         T00016_A23EstCodi = new int[1] ;
         T00016_n23EstCodi = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00014_A27CidNome = new String[] {""} ;
         T00014_n27CidNome = new bool[] {false} ;
         T00014_A23EstCodi = new int[1] ;
         T00014_n23EstCodi = new bool[] {false} ;
         T00015_A24EstUF = new String[] {""} ;
         T00015_n24EstUF = new bool[] {false} ;
         T00015_A25EstNome = new String[] {""} ;
         T00015_n25EstNome = new bool[] {false} ;
         T00017_A27CidNome = new String[] {""} ;
         T00017_n27CidNome = new bool[] {false} ;
         T00017_A23EstCodi = new int[1] ;
         T00017_n23EstCodi = new bool[] {false} ;
         wbTemp = 0 ;
         T00018_A24EstUF = new String[] {""} ;
         T00018_n24EstUF = new bool[] {false} ;
         T00018_A25EstNome = new String[] {""} ;
         T00018_n25EstNome = new bool[] {false} ;
         T00019_A12PesCodi = new int[1] ;
         T00013_A12PesCodi = new int[1] ;
         T00013_A13PesNome = new String[] {""} ;
         T00013_n13PesNome = new bool[] {false} ;
         T00013_A14PesCPF = new String[] {""} ;
         T00013_n14PesCPF = new bool[] {false} ;
         T00013_A15PesDatN = new DateTime[] {DateTime.MinValue} ;
         T00013_n15PesDatN = new bool[] {false} ;
         T00013_A16PesEnde = new String[] {""} ;
         T00013_n16PesEnde = new bool[] {false} ;
         T00013_A17PesEndN = new String[] {""} ;
         T00013_n17PesEndN = new bool[] {false} ;
         T00013_A18PesBair = new String[] {""} ;
         T00013_n18PesBair = new bool[] {false} ;
         T00013_A19PesEmai = new String[] {""} ;
         T00013_n19PesEmai = new bool[] {false} ;
         T00013_A20PesTele = new String[] {""} ;
         T00013_n20PesTele = new bool[] {false} ;
         T00013_A21PesCelu = new String[] {""} ;
         T00013_n21PesCelu = new bool[] {false} ;
         T00013_A22PesSitu = new short[1] ;
         T00013_n22PesSitu = new bool[] {false} ;
         T00013_A26CidCodi = new int[1] ;
         T00013_n26CidCodi = new bool[] {false} ;
         sMode1 = "" ;
         T000110_A12PesCodi = new int[1] ;
         T000111_A12PesCodi = new int[1] ;
         T00012_A12PesCodi = new int[1] ;
         T00012_A13PesNome = new String[] {""} ;
         T00012_n13PesNome = new bool[] {false} ;
         T00012_A14PesCPF = new String[] {""} ;
         T00012_n14PesCPF = new bool[] {false} ;
         T00012_A15PesDatN = new DateTime[] {DateTime.MinValue} ;
         T00012_n15PesDatN = new bool[] {false} ;
         T00012_A16PesEnde = new String[] {""} ;
         T00012_n16PesEnde = new bool[] {false} ;
         T00012_A17PesEndN = new String[] {""} ;
         T00012_n17PesEndN = new bool[] {false} ;
         T00012_A18PesBair = new String[] {""} ;
         T00012_n18PesBair = new bool[] {false} ;
         T00012_A19PesEmai = new String[] {""} ;
         T00012_n19PesEmai = new bool[] {false} ;
         T00012_A20PesTele = new String[] {""} ;
         T00012_n20PesTele = new bool[] {false} ;
         T00012_A21PesCelu = new String[] {""} ;
         T00012_n21PesCelu = new bool[] {false} ;
         T00012_A22PesSitu = new short[1] ;
         T00012_n22PesSitu = new bool[] {false} ;
         T00012_A26CidCodi = new int[1] ;
         T00012_n26CidCodi = new bool[] {false} ;
         Gx_longc = false ;
         T000113_A12PesCodi = new int[1] ;
         T000116_A27CidNome = new String[] {""} ;
         T000116_n27CidNome = new bool[] {false} ;
         T000116_A23EstCodi = new int[1] ;
         T000116_n23EstCodi = new bool[] {false} ;
         T000117_A24EstUF = new String[] {""} ;
         T000117_n24EstUF = new bool[] {false} ;
         T000117_A25EstNome = new String[] {""} ;
         T000117_n25EstNome = new bool[] {false} ;
         T000118_A12PesCodi = new int[1] ;
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
         GXt_char14 = "" ;
         GXt_char15 = "" ;
         GXt_char16 = "" ;
         GXt_char17 = "" ;
         GXt_char18 = "" ;
         GXt_char19 = "" ;
         GXt_char20 = "" ;
         GXt_char21 = "" ;
         GXt_char22 = "" ;
         cmbCObjCtrl = new GXCombobox();
         GXt_char23 = "" ;
         GXt_char24 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tpessoa__default(),
            new Object[][] {
                new Object[] {
               T00012_A12PesCodi, T00012_A13PesNome, T00012_n13PesNome, T00012_A14PesCPF, T00012_n14PesCPF, T00012_A15PesDatN, T00012_n15PesDatN, T00012_A16PesEnde, T00012_n16PesEnde, T00012_A17PesEndN,
               T00012_n17PesEndN, T00012_A18PesBair, T00012_n18PesBair, T00012_A19PesEmai, T00012_n19PesEmai, T00012_A20PesTele, T00012_n20PesTele, T00012_A21PesCelu, T00012_n21PesCelu, T00012_A22PesSitu,
               T00012_n22PesSitu, T00012_A26CidCodi, T00012_n26CidCodi
               }
               , new Object[] {
               T00013_A12PesCodi, T00013_A13PesNome, T00013_n13PesNome, T00013_A14PesCPF, T00013_n14PesCPF, T00013_A15PesDatN, T00013_n15PesDatN, T00013_A16PesEnde, T00013_n16PesEnde, T00013_A17PesEndN,
               T00013_n17PesEndN, T00013_A18PesBair, T00013_n18PesBair, T00013_A19PesEmai, T00013_n19PesEmai, T00013_A20PesTele, T00013_n20PesTele, T00013_A21PesCelu, T00013_n21PesCelu, T00013_A22PesSitu,
               T00013_n22PesSitu, T00013_A26CidCodi, T00013_n26CidCodi
               }
               , new Object[] {
               T00014_A27CidNome, T00014_n27CidNome, T00014_A23EstCodi, T00014_n23EstCodi
               }
               , new Object[] {
               T00015_A24EstUF, T00015_n24EstUF, T00015_A25EstNome, T00015_n25EstNome
               }
               , new Object[] {
               T00016_A12PesCodi, T00016_A13PesNome, T00016_n13PesNome, T00016_A14PesCPF, T00016_n14PesCPF, T00016_A15PesDatN, T00016_n15PesDatN, T00016_A16PesEnde, T00016_n16PesEnde, T00016_A17PesEndN,
               T00016_n17PesEndN, T00016_A18PesBair, T00016_n18PesBair, T00016_A19PesEmai, T00016_n19PesEmai, T00016_A20PesTele, T00016_n20PesTele, T00016_A21PesCelu, T00016_n21PesCelu, T00016_A22PesSitu,
               T00016_n22PesSitu, T00016_A24EstUF, T00016_n24EstUF, T00016_A25EstNome, T00016_n25EstNome, T00016_A27CidNome, T00016_n27CidNome, T00016_A26CidCodi, T00016_n26CidCodi, T00016_A23EstCodi,
               T00016_n23EstCodi
               }
               , new Object[] {
               T00017_A27CidNome, T00017_n27CidNome, T00017_A23EstCodi, T00017_n23EstCodi
               }
               , new Object[] {
               T00018_A24EstUF, T00018_n24EstUF, T00018_A25EstNome, T00018_n25EstNome
               }
               , new Object[] {
               T00019_A12PesCodi
               }
               , new Object[] {
               T000110_A12PesCodi
               }
               , new Object[] {
               T000111_A12PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000113_A12PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000116_A27CidNome, T000116_n27CidNome, T000116_A23EstCodi, T000116_n23EstCodi
               }
               , new Object[] {
               T000117_A24EstUF, T000117_n24EstUF, T000117_A25EstNome, T000117_n25EstNome
               }
               , new Object[] {
               T000118_A12PesCodi
               }
            }
         );
      }

      private short RcdFound1 ;
      private short GxWebError ;
      private short gxajaxcallmode ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short A22PesSitu ;
      private short Z22PesSitu ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int A26CidCodi ;
      private int A23EstCodi ;
      private int trnEnded ;
      private int bttBtn_delete_Enabled ;
      private int A12PesCodi ;
      private int gxCalCtrlInc ;
      private int Z12PesCodi ;
      private int Z26CidCodi ;
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
      private String lblTextblock6_Name ;
      private String lblTextblock7_Name ;
      private String lblTextblock8_Name ;
      private String lblTextblock9_Name ;
      private String lblTextblock10_Name ;
      private String lblTextblock11_Name ;
      private String lblTextblock12_Name ;
      private String lblTextblock13_Name ;
      private String lblTextblock14_Name ;
      private String lblTextblock15_Name ;
      private String lblTextblock16_Name ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPesCodigo_Internalname ;
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
      private String edtPesCodigo_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtPesNome_Internalname ;
      private String edtPesNome_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtPesCPF_Internalname ;
      private String edtPesCPF_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtPesDatNasc_Internalname ;
      private String edtPesDatNasc_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtPesEndereco_Internalname ;
      private String edtPesEndereco_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtPesEndNumero_Internalname ;
      private String edtPesEndNumero_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtPesBairro_Internalname ;
      private String edtPesBairro_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtPesEmail_Internalname ;
      private String edtPesEmail_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtPesTelefone_Internalname ;
      private String edtPesTelefone_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtPesCelular_Internalname ;
      private String edtPesCelular_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String cmbPesSituacao_Internalname ;
      private String cmbPesSituacao_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtEstCodigo_Internalname ;
      private String edtEstCodigo_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtEstUF_Internalname ;
      private String A24EstUF ;
      private String edtEstUF_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String edtEstNome_Internalname ;
      private String edtEstNome_Jsonclick ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String edtCidCodigo_Internalname ;
      private String edtCidCodigo_Jsonclick ;
      private String imgprompt_26_Internalname ;
      private String imgprompt_26_Link ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String edtCidNome_Internalname ;
      private String edtCidNome_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode1 ;
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
      private String GXt_char14 ;
      private String GXt_char15 ;
      private String GXt_char16 ;
      private String GXt_char17 ;
      private String GXt_char18 ;
      private String GXt_char19 ;
      private String GXt_char20 ;
      private String GXt_char21 ;
      private String GXt_char22 ;
      private String GXt_char23 ;
      private String GXt_char24 ;
      private DateTime A15PesDatN ;
      private DateTime Z15PesDatN ;
      private bool n26CidCodi ;
      private bool n23EstCodi ;
      private bool wbErr ;
      private bool n13PesNome ;
      private bool n14PesCPF ;
      private bool n15PesDatN ;
      private bool n16PesEnde ;
      private bool n17PesEndN ;
      private bool n18PesBair ;
      private bool n19PesEmai ;
      private bool n20PesTele ;
      private bool n21PesCelu ;
      private bool n22PesSitu ;
      private bool n24EstUF ;
      private bool n25EstNome ;
      private bool n27CidNome ;
      private bool Gx_longc ;
      private bool addContentType ;
      private String A13PesNome ;
      private String A14PesCPF ;
      private String A16PesEnde ;
      private String A17PesEndN ;
      private String A18PesBair ;
      private String A19PesEmai ;
      private String A20PesTele ;
      private String A21PesCelu ;
      private String A25EstNome ;
      private String A27CidNome ;
      private String Z13PesNome ;
      private String Z14PesCPF ;
      private String Z16PesEnde ;
      private String Z17PesEndN ;
      private String Z18PesBair ;
      private String Z19PesEmai ;
      private String Z20PesTele ;
      private String Z21PesCelu ;
      private GeneXus.Utils.GxStringCollection Formheaderjscriptsrc ;
      private GXWebForm Form ;
      private IDataReader T00012 ;
      private IDataReader T00013 ;
      private IDataReader T00014 ;
      private IDataReader T00015 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPesSituacao ;
      private IDataReader T00016 ;
      private IDataStoreProvider pr_default ;
      private int[] T00016_A12PesCodi ;
      private String[] T00016_A13PesNome ;
      private bool[] T00016_n13PesNome ;
      private String[] T00016_A14PesCPF ;
      private bool[] T00016_n14PesCPF ;
      private DateTime[] T00016_A15PesDatN ;
      private bool[] T00016_n15PesDatN ;
      private String[] T00016_A16PesEnde ;
      private bool[] T00016_n16PesEnde ;
      private String[] T00016_A17PesEndN ;
      private bool[] T00016_n17PesEndN ;
      private String[] T00016_A18PesBair ;
      private bool[] T00016_n18PesBair ;
      private String[] T00016_A19PesEmai ;
      private bool[] T00016_n19PesEmai ;
      private String[] T00016_A20PesTele ;
      private bool[] T00016_n20PesTele ;
      private String[] T00016_A21PesCelu ;
      private bool[] T00016_n21PesCelu ;
      private short[] T00016_A22PesSitu ;
      private bool[] T00016_n22PesSitu ;
      private String[] T00016_A24EstUF ;
      private bool[] T00016_n24EstUF ;
      private String[] T00016_A25EstNome ;
      private bool[] T00016_n25EstNome ;
      private String[] T00016_A27CidNome ;
      private bool[] T00016_n27CidNome ;
      private int[] T00016_A26CidCodi ;
      private bool[] T00016_n26CidCodi ;
      private int[] T00016_A23EstCodi ;
      private bool[] T00016_n23EstCodi ;
      private String[] T00014_A27CidNome ;
      private bool[] T00014_n27CidNome ;
      private int[] T00014_A23EstCodi ;
      private bool[] T00014_n23EstCodi ;
      private String[] T00015_A24EstUF ;
      private bool[] T00015_n24EstUF ;
      private String[] T00015_A25EstNome ;
      private bool[] T00015_n25EstNome ;
      private IDataReader T00017 ;
      private String[] T00017_A27CidNome ;
      private bool[] T00017_n27CidNome ;
      private int[] T00017_A23EstCodi ;
      private bool[] T00017_n23EstCodi ;
      private IDataReader T00018 ;
      private String[] T00018_A24EstUF ;
      private bool[] T00018_n24EstUF ;
      private String[] T00018_A25EstNome ;
      private bool[] T00018_n25EstNome ;
      private IDataReader T00019 ;
      private int[] T00019_A12PesCodi ;
      private int[] T00013_A12PesCodi ;
      private String[] T00013_A13PesNome ;
      private bool[] T00013_n13PesNome ;
      private String[] T00013_A14PesCPF ;
      private bool[] T00013_n14PesCPF ;
      private DateTime[] T00013_A15PesDatN ;
      private bool[] T00013_n15PesDatN ;
      private String[] T00013_A16PesEnde ;
      private bool[] T00013_n16PesEnde ;
      private String[] T00013_A17PesEndN ;
      private bool[] T00013_n17PesEndN ;
      private String[] T00013_A18PesBair ;
      private bool[] T00013_n18PesBair ;
      private String[] T00013_A19PesEmai ;
      private bool[] T00013_n19PesEmai ;
      private String[] T00013_A20PesTele ;
      private bool[] T00013_n20PesTele ;
      private String[] T00013_A21PesCelu ;
      private bool[] T00013_n21PesCelu ;
      private short[] T00013_A22PesSitu ;
      private bool[] T00013_n22PesSitu ;
      private int[] T00013_A26CidCodi ;
      private bool[] T00013_n26CidCodi ;
      private IDataReader T000110 ;
      private int[] T000110_A12PesCodi ;
      private IDataReader T000111 ;
      private int[] T000111_A12PesCodi ;
      private int[] T00012_A12PesCodi ;
      private String[] T00012_A13PesNome ;
      private bool[] T00012_n13PesNome ;
      private String[] T00012_A14PesCPF ;
      private bool[] T00012_n14PesCPF ;
      private DateTime[] T00012_A15PesDatN ;
      private bool[] T00012_n15PesDatN ;
      private String[] T00012_A16PesEnde ;
      private bool[] T00012_n16PesEnde ;
      private String[] T00012_A17PesEndN ;
      private bool[] T00012_n17PesEndN ;
      private String[] T00012_A18PesBair ;
      private bool[] T00012_n18PesBair ;
      private String[] T00012_A19PesEmai ;
      private bool[] T00012_n19PesEmai ;
      private String[] T00012_A20PesTele ;
      private bool[] T00012_n20PesTele ;
      private String[] T00012_A21PesCelu ;
      private bool[] T00012_n21PesCelu ;
      private short[] T00012_A22PesSitu ;
      private bool[] T00012_n22PesSitu ;
      private int[] T00012_A26CidCodi ;
      private bool[] T00012_n26CidCodi ;
      private IDataReader T000113 ;
      private int[] T000113_A12PesCodi ;
      private IDataReader T000116 ;
      private String[] T000116_A27CidNome ;
      private bool[] T000116_n27CidNome ;
      private int[] T000116_A23EstCodi ;
      private bool[] T000116_n23EstCodi ;
      private IDataReader T000117 ;
      private String[] T000117_A24EstUF ;
      private bool[] T000117_n24EstUF ;
      private String[] T000117_A25EstNome ;
      private bool[] T000117_n25EstNome ;
      private IDataReader T000118 ;
      private int[] T000118_A12PesCodi ;
      private GXCombobox cmbCObjCtrl ;
   }

   public class tpessoa__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[14])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[15])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@PesNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesDatNasc",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesEndereco",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEndNumero",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesBairro",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PesTelefone",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesCelular",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@PesNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesDatNasc",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesEndereco",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEndNumero",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesBairro",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PesTelefone",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesCelular",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00012", "SELECT [PesCodigo], [PesNome], [PesCPF], [PesDatNasc], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [CidCodigo] FROM [PESSOA] WITH (UPDLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00013", "SELECT [PesCodigo], [PesNome], [PesCPF], [PesDatNasc], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [CidCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00014", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00015", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00016", "SELECT TM1.[PesCodigo], TM1.[PesNome], TM1.[PesCPF], TM1.[PesDatNasc], TM1.[PesEndereco], TM1.[PesEndNumero], TM1.[PesBairro], TM1.[PesEmail], TM1.[PesTelefone], TM1.[PesCelular], TM1.[PesSituacao], T3.[EstUF], T3.[EstNome], T2.[CidNome], TM1.[CidCodigo], T2.[EstCodigo] FROM (([PESSOA] TM1 WITH (NOLOCK) LEFT JOIN [CIDADE] T2 WITH (NOLOCK) ON T2.[CidCodigo] = TM1.[CidCodigo]) LEFT JOIN [ESTADO] T3 WITH (NOLOCK) ON T3.[EstCodigo] = T2.[EstCodigo]) WHERE TM1.[PesCodigo] = @PesCodigo ORDER BY TM1.[PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00017", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00018", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00019", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000110", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE ( [PesCodigo] > @PesCodigo) ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000111", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE ( [PesCodigo] < @PesCodigo) ORDER BY [PesCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000112", "INSERT INTO [PESSOA] ([PesNome], [PesCPF], [PesDatNasc], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [CidCodigo]) VALUES (@PesNome, @PesCPF, @PesDatNasc, @PesEndereco, @PesEndNumero, @PesBairro, @PesEmail, @PesTelefone, @PesCelular, @PesSituacao, @CidCodigo)", GxErrorMask.GX_NOMASK,prmT000112)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000113", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000113,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000114", "UPDATE [PESSOA] SET [PesNome]=@PesNome, [PesCPF]=@PesCPF, [PesDatNasc]=@PesDatNasc, [PesEndereco]=@PesEndereco, [PesEndNumero]=@PesEndNumero, [PesBairro]=@PesBairro, [PesEmail]=@PesEmail, [PesTelefone]=@PesTelefone, [PesCelular]=@PesCelular, [PesSituacao]=@PesSituacao, [CidCodigo]=@CidCodigo  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000114)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000115", "DELETE FROM [PESSOA]  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000115)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000116", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000117", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000118", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,100,0,true,false )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((int[]) buf[21])[0] = rslt.getInt(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((int[]) buf[21])[0] = rslt.getInt(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getString(12, 2) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((int[]) buf[27])[0] = rslt.getInt(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((int[]) buf[29])[0] = rslt.getInt(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 16 :
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
                stmt.SetParameter(1, (int)parms[0]);
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
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
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(11, (int)parms[21]);
                }
                break;
             case 12 :
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
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(11, (int)parms[21]);
                }
                stmt.SetParameter(12, (int)parms[22]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 14 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 15 :
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
