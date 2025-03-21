/*
               File: Filme
        Description: Cadastro de Filmes
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 3/3/2025 17:20:36.68
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
   public class tfilme : GXHttpHandler
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
            A33CatCodi = (int)(NumberUtil.Val( GetNextPar( ), "")) ;
            n33CatCodi = false ;
            gxajaxcallmode = 1 ;
            gxLoad_3( A33CatCodi) ;
            return  ;
         }
         lblTextblock1_Name = "Textblock1" ;
         lblTextblock2_Name = "Textblock2" ;
         lblTextblock3_Name = "Textblock3" ;
         cmbFilSituacao.Name = "FILSITUACAO" ;
         cmbFilSituacao.Height = 1 ;
         cmbFilSituacao.WebTags = "" ;
         cmbFilSituacao.addItem(StringUtil.Str( (decimal)(1), 1, 0), "Ativo", 0);
         cmbFilSituacao.addItem(StringUtil.Str( (decimal)(2), 1, 0), "Inativo", 0);
         lblTextblock4_Name = "Textblock4" ;
         lblTextblock5_Name = "Textblock5" ;
         lblTextblock6_Name = "Textblock6" ;
         lblTextblock7_Name = "Textblock7" ;
         initialize_properties( ) ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "9_0_7-910", 0) ;
         Form.Meta.addItem("Description", "Cadastro de Filmes", 0) ;
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
         GX_FocusControl = edtFilCodigo_Internalname ;
         wbErr = false ;
      }

      public tfilme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tfilme( IGxContext context )
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
         cmbFilSituacao = new GXCombobox();
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
            wb_table1_2_022( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_022e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            RenderHtmlCloseForm022( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_022( bool wbgen )
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
            gx_button_ctrl2( 1, bttBtn_first_Internalname, "|<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "4" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_previous_Internalname, "<", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "5" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_next_Internalname, ">", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "6" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_last_Internalname, ">|", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "7" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_select_Internalname, "Select", "", "", StyleString, ClassString, 1, 1, 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "", "'HLP_TFilme.htm'");
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
            wb_table2_9_022( true) ;
         }
         return  ;
      }

      protected void wb_table2_9_022e( bool wbgen )
      {
         if ( ( wbgen == true ) )
         {
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "26" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_enter_Internalname, "Apply Changes", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "27" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_check_Internalname, "Check", "", "", StyleString, ClassString, 1, 1, 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "28" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_cancel_Internalname, "Close", "", "", StyleString, ClassString, 1, 1, 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "29" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_delete_Internalname, "Delete All", "", "", StyleString, ClassString, 1, bttBtn_delete_Enabled, 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "30" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 2, bttBtn_help_Internalname, "Help", "", "", StyleString, ClassString, 1, 1, 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table1_2_022e( true) ;
         }
         else
         {
            wb_table1_2_022e( false) ;
         }
      }

      protected void wb_table2_9_022( bool wbgen )
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
            gx_label_ctrl( lblTextblock1_Internalname, 1, 1, 0, "Código do Filme", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "11" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtFilCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28FilCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A28FilCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(11);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,true,null,'eng');"+"\"", 0, edtFilCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TFilme.htm'");
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "12" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S4" ;
            StyleString = "" + "" ;
            gx_button_ctrl2( 1, bttBtn_get_Internalname, "=>", "", "", StyleString, ClassString, 1, 1, 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock2_Internalname, 1, 1, 0, "Nome do Filme", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "14" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtFilNome_Internalname, StringUtil.RTrim( A29FilNome), 50, 50, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A29FilNome, "@!")), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"this.value=this.value.toUpperCase();;GXOnBlur(14);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtFilNome_Jsonclick, "", 0, 0, 1, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock3_Internalname, 1, 1, 0, "Situação do Filme", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "16" + "," + "''" + "," + "0" + ")\"" ;
            cmbFilSituacao.CurrentValue = StringUtil.Str( (decimal)(A30FilSitu), 1, 0) ;
            /* ComboBox */
            gx_combobox_ctrl( cmbFilSituacao, cmbFilSituacao_Internalname, StringUtil.Str( (decimal)(A30FilSitu), 1, 0), "int", 1, 1, 1, 2, StyleString, ClassString, "", 0, cmbFilSituacao_Jsonclick, "", TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(16);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock4_Internalname, 1, 1, 0, "Data do Filme", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "18" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            if ( ( 1 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
            {
               WriteHtmlText( "<table id=\""+edtFilData_Internalname+"_dp_container\" cellpadding=\"0\" cellspacing=\"0\"><tr><td>") ;
            }
            gx_single_line_edit2( edtFilData_Internalname, StringUtil.Format(A31FilData, "99/99/99"), 8, 8, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( A31FilData, "99/99/99"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"gxvdate( this, 8,0,0,1,'eng',false,0);;GXOnBlur(18);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtFilData_Jsonclick, "", 0, 0, 1, "'HLP_TFilme.htm'");
            if ( ( 1 == 1 ) && ( 1 == 1 ) || ( 0 == 1 ) )
            {
               WriteHtmlTextNl( "</td><td>") ;
               WriteHtmlText( "<img src=\""+convertURL( "calendar-img.gif")+"\" id=\""+edtFilData_Internalname+"_dp_trigger\" style=\"cursor: pointer;\" title=\"Date selector\" onmouseover=\"this.style.background='red';\" onmouseout=\"this.style.background=''\"/>") ;
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
               WriteHtmlText( "Calendar.setup( {inputField:\""+edtFilData_Internalname+"\""+",showsTime: false "+",weekNumbers: false "+",mondayFirst: false "+",ifFormat:\""+"%m/%d/%y"+"\",") ;
               WriteHtmlText( "button:\""+edtFilData_Internalname+"_dp_trigger\""+",onSelect: dateChanged_"+edtFilData_Internalname+",") ;
               WriteHtmlTextNl( "align:\"Bl\",singleClick:true});") ;
               WriteHtmlText( "function dateChanged_"+edtFilData_Internalname+"(calendar, date) { if (calendar && calendar.dateClicked){") ;
               if ( ( 1 == 1 ) )
               {
                  WriteHtmlText( " document.getElementById(\""+edtFilData_Internalname+"\").value"+"="+"calendar.date.print(\""+"%m/%d/%y"+"\");"+"calendar.callCloseHandler();") ;
               }
               else
               {
                  WriteHtmlText( "calendar.parseDate("+" document.forms[0]."+edtFilData_Internalname+".value);"+"calendar.callCloseHandler();") ;
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
            gx_label_ctrl( lblTextblock5_Internalname, 1, 1, 0, "Descrição do Filme", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Multiple line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "20" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            smlStyle = StyleString ;
            StyleString = StyleString + ((1==0)||((1==0)&&(0==1)) ? ";display:none;" : "") ;
            if ( ( 0 != 0 ) || ( 1 != 0 ) )
            {
               if ( ( 1 != 0 ) || ( ( 1 == 0 ) && ( 0 != 0 ) ) )
               {
                  WriteHtmlTextNl( "<textarea cols="+"80"+" rows="+"10"+" name=\""+edtFIlDescricao_Internalname+"\""+" id=\""+edtFIlDescricao_Internalname+"\" "+" maxlength=\""+"800"+"\""+TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\";GXOnBlur(20);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\""+" style=\""+StyleString+"\" "+" class=\""+ClassString+"\" "+">") ;
                  WriteHtmlText( A32FIlDesc+"</textarea>") ;
               }
               else
               {
                  gx_hidden_field( edtFIlDescricao_Internalname, A32FIlDesc);
               }
            }
            if ( ( 1 == 0 ) )
            {
               if ( ( 0 == 0 ) )
               {
                  gx_hidden_field( edtFIlDescricao_Internalname, A32FIlDesc);
               }
               if ( ( 1 != 0 ) || ( ( 1 == 0 ) && ( 0 != 0 ) ) )
               {
                  if ( ( StringUtil.Len( ClassString) != 0 ) && ( StringUtil.StringSearch( ClassString, "Readonly", 1) != 1 ) )
                  {
                     ClassString = "Readonly" + ClassString ;
                  }
                  smlStyle = smlStyle + ((1==0) ? ";display:none;" : "") ;
                  WriteHtmlText( "<span"+" id=\"span_"+edtFIlDescricao_Internalname+"\""+((0==0) ? " overflow=\"hidden\";" : "")+"\"") ;
                  if ( ( StringUtil.Len( ClassString) > 0 ) )
                  {
                     WriteHtmlText( " class=\"") ;
                     WriteHtmlText( ClassString) ;
                     WriteHtmlText( "\"") ;
                  }
                  if ( ( StringUtil.Len( smlStyle) > 0 ) )
                  {
                     WriteHtmlText( " style=\"") ;
                     WriteHtmlText( smlStyle) ;
                     WriteHtmlText( "\" ") ;
                  }
                  WriteHtmlText( ">") ;
                  if ( ( 0 == 0 ) )
                  {
                     SendWebValueEnter( A32FIlDesc) ;
                  }
                  else
                  {
                     if ( ( 0 == 3 ) )
                     {
                        SendWebValueComplete( A32FIlDesc) ;
                     }
                     else
                     {
                        WriteHtmlText( A32FIlDesc) ;
                     }
                  }
                  WriteHtmlText( "</span>") ;
               }
            }
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock6_Internalname, 1, 1, 0, "Código da Categoria", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            TempTags = " " + "gxctx=\"" + "_" + "" + "\"" + " onFocus=\"gxonfocus2(this, " + "22" + "," + "''" + "," + "0" + ")\"" ;
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCatCodigo_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33CatCodi), 9, 0, ".", "")), 9, 9, 1, 0, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.Format( (decimal)(A33CatCodi), "ZZZZZZZZ9"), TempTags+" onchange=\"gxonchange(this)\" "+" onBlur=\"valid_integer( this,',');;GXOnBlur(22);\""+" gxoch2=\""+"form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,false,null,'eng');"+"\"", 0, edtCatCodigo_Jsonclick, "", 0, 0, 1, "'HLP_TFilme.htm'");
            /* Static images/pictures */
            ClassString = "S8" ;
            StyleString = "" + "" ;
            gx_bitmap( imgprompt_33_Internalname, "", "prompt.gif", 1, 0, "", "", 0, 0, 0, 0, 0, 0, imgprompt_33_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            WriteHtmlText( "<TR>") ;
            WriteHtmlText( "<TD>") ;
            /* Text block */
            ClassString = "S5" ;
            StyleString = "" + "" ;
            gx_label_ctrl( lblTextblock7_Internalname, 1, 1, 0, "Nome da Categoria", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "<TD>") ;
            /* Single line edit */
            ClassString = "S6" ;
            StyleString = "" + "" ;
            gx_single_line_edit2( edtCatNome_Internalname, StringUtil.RTrim( A34CatNome), 50, 50, 1, 0, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( StringUtil.Format( A34CatNome, "@!")), "", 0, edtCatNome_Jsonclick, "", 0, 0, 1, "'HLP_TFilme.htm'");
            WriteHtmlText( "</TD>") ;
            WriteHtmlText( "</TR>") ;
            /* End of table */
            WriteHtmlText( "</table>") ;
            wb_table2_9_022e( true) ;
         }
         else
         {
            wb_table2_9_022e( false) ;
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
               Z28FilCodi = (int)(NumberUtil.CToN( cgiGet( "Z28FilCodi"), "", "")) ;
               Z29FilNome = GXUtil.ValueDecode( cgiGet( "Z29FilNome")) ;
               Z30FilSitu = (short)(NumberUtil.CToN( cgiGet( "Z30FilSitu"), "", "")) ;
               Z31FilData = DateTimeUtil.CToD( cgiGet( "Z31FilData"), 0) ;
               Z33CatCodi = (int)(NumberUtil.CToN( cgiGet( "Z33CatCodi"), "", "")) ;
               IsConfirmed = (short)(NumberUtil.CToN( cgiGet( "IsConfirmed"), "", "")) ;
               IsModified = (short)(NumberUtil.CToN( cgiGet( "IsModified"), "", "")) ;
               Gx_mode = GXUtil.ValueDecode( cgiGet( "Mode")) ;
               context.sCallerURL = GXUtil.ValueDecode( cgiGet( "sCallerURL")) ;
               /* Read subfile selected row values. */
               /* Read variables values. */
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
               A29FilNome = StringUtil.Upper( cgiGet( edtFilNome_Internalname)) ;
               n29FilNome = false ;
               n29FilNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A29FilNome).TrimEnd(' ') )==0)) ? true : false) ;
               cmbFilSituacao.CurrentValue = cgiGet( cmbFilSituacao_Internalname) ;
               A30FilSitu = (short)(NumberUtil.Val( cgiGet( cmbFilSituacao_Internalname), ".")) ;
               n30FilSitu = false ;
               n30FilSitu = (((0==A30FilSitu)) ? true : false) ;
               if ( ( DateTimeUtil.VCDate( cgiGet( edtFilData_Internalname), 1) == 0 ) )
               {
                  GX_msglist.addItem(GXResourceManager.GetMessage("faildate", new   object[]  {"Data do Filme"}), 1);
                  AnyError = 1 ;
                  GX_FocusControl = edtFilData_Internalname ;
                  wbErr = true ;
                  A31FilData = (DateTime)(DateTime.MinValue) ;
                  n31FilData = false ;
               }
               else
               {
                  A31FilData = DateTimeUtil.CToD( cgiGet( edtFilData_Internalname), 1) ;
                  n31FilData = false ;
               }
               n31FilData = (((DateTime.MinValue==A31FilData)) ? true : false) ;
               A32FIlDesc = StringUtil.Upper( cgiGet( edtFIlDescricao_Internalname)) ;
               n32FIlDesc = false ;
               n32FIlDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A32FIlDesc).TrimEnd(' ') )==0)) ? true : false) ;
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
               n33CatCodi = (((0==A33CatCodi)) ? true : false) ;
               A34CatNome = StringUtil.Upper( cgiGet( edtCatNome_Internalname)) ;
               n34CatNome = false ;
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
               InitAll022( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      protected void CONFIRM_020( )
      {
         BeforeValidate022( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls022( ) ;
            }
            else
            {
               CheckExtendedTable022( ) ;
               if ( ( AnyError == 0 ) )
               {
                  ZM022( 3) ;
               }
               CloseExtendedTableCursors022( ) ;
            }
         }
         if ( ( AnyError == 0 ) )
         {
            IsConfirmed = 1 ;
         }
         if ( ( AnyError == 0 ) )
         {
            ConfirmValues020( ) ;
         }
      }

      protected void ResetCaption020( )
      {
         IsConfirmed = 0 ;
      }

      protected void ZM022( int GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z29FilNome = T00023_A29FilNome[0] ;
               Z30FilSitu = T00023_A30FilSitu[0] ;
               Z31FilData = T00023_A31FilData[0] ;
               Z33CatCodi = T00023_A33CatCodi[0] ;
            }
            else
            {
               Z29FilNome = A29FilNome ;
               Z30FilSitu = A30FilSitu ;
               Z31FilData = A31FilData ;
               Z33CatCodi = A33CatCodi ;
            }
         }
         if ( ( GX_JID == -2 ) )
         {
            Z28FilCodi = A28FilCodi ;
            Z29FilNome = A29FilNome ;
            Z30FilSitu = A30FilSitu ;
            Z31FilData = A31FilData ;
            Z32FIlDesc = A32FIlDesc ;
            Z33CatCodi = A33CatCodi ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_33_Link = ((String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') )==0) ? "" : "javascript:"+"HGx0030("+"document.forms[0]."+"CATCODIGO"+");") ;
      }

      protected void standaloneModal( )
      {
      }

      protected void Load022( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1 ;
            A29FilNome = T00025_A29FilNome[0] ;
            n29FilNome = T00025_n29FilNome[0] ;
            A30FilSitu = T00025_A30FilSitu[0] ;
            n30FilSitu = T00025_n30FilSitu[0] ;
            A31FilData = T00025_A31FilData[0] ;
            n31FilData = T00025_n31FilData[0] ;
            A32FIlDesc = T00025_A32FIlDesc[0] ;
            n32FIlDesc = T00025_n32FIlDesc[0] ;
            A34CatNome = T00025_A34CatNome[0] ;
            n34CatNome = T00025_n34CatNome[0] ;
            A33CatCodi = T00025_A33CatCodi[0] ;
            n33CatCodi = T00025_n33CatCodi[0] ;
            ZM022( -2) ;
         }
         pr_default.close(3);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( ! ( ((DateTime.MinValue==A31FilData)) || ( A31FilData >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Data do Filme is out of range", "OutOfRange", 1);
            AnyError = 1 ;
         }
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {n33CatCodi, A33CatCodi});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( ((0==A33CatCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Categorias'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCatCodigo_Internalname ;
            }
         }
         A34CatNome = T00024_A34CatNome[0] ;
         n34CatNome = T00024_n34CatNome[0] ;
         pr_default.close(2);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
         if ( ( IsConfirmed == 0 ) )
         {
            bttBtn_delete_Enabled = RcdFound2 ;
         }
         else
         {
            bttBtn_delete_Enabled = 0 ;
         }
      }

      protected void gxLoad_3( int A33CatCodi )
      {
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {n33CatCodi, A33CatCodi});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( ((0==A33CatCodi)) ) )
            {
               GX_msglist.addItem("No matching 'Cadastro de Categorias'.", "ForeignKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtCatCodigo_Internalname ;
            }
         }
         A34CatNome = T00026_A34CatNome[0] ;
         n34CatNome = T00026_n34CatNome[0] ;
         wbTemp = context.ResponseContentType( "text/html") ;
         wbTemp = context.SetHeader( "pragma", "no-cache") ;
         context.GX_webresponse.AppendHeader("Content-Type", "text/plain;charset=utf-8");
         wbTemp = context.SetHeader( "Cache-Control", "max-age=0") ;
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A34CatNome))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey022( )
      {
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1 ;
         }
         else
         {
            RcdFound2 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 2) ;
            RcdFound2 = 1 ;
            A28FilCodi = T00023_A28FilCodi[0] ;
            n28FilCodi = T00023_n28FilCodi[0] ;
            A29FilNome = T00023_A29FilNome[0] ;
            n29FilNome = T00023_n29FilNome[0] ;
            A30FilSitu = T00023_A30FilSitu[0] ;
            n30FilSitu = T00023_n30FilSitu[0] ;
            A31FilData = T00023_A31FilData[0] ;
            n31FilData = T00023_n31FilData[0] ;
            A32FIlDesc = T00023_A32FIlDesc[0] ;
            n32FIlDesc = T00023_n32FIlDesc[0] ;
            A33CatCodi = T00023_A33CatCodi[0] ;
            n33CatCodi = T00023_n33CatCodi[0] ;
            Z28FilCodi = A28FilCodi ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load022( ) ;
            Gx_mode = sMode2 ;
         }
         else
         {
            RcdFound2 = 0 ;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode2 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( ( RcdFound2 == 0 ) )
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
         RcdFound2 = 0 ;
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00028_A28FilCodi[0] < A28FilCodi ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00028_A28FilCodi[0] > A28FilCodi ) ) )
            {
               A28FilCodi = T00028_A28FilCodi[0] ;
               n28FilCodi = T00028_n28FilCodi[0] ;
               RcdFound2 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0 ;
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {n28FilCodi, A28FilCodi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00029_A28FilCodi[0] > A28FilCodi ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00029_A28FilCodi[0] < A28FilCodi ) ) )
            {
               A28FilCodi = T00029_A28FilCodi[0] ;
               n28FilCodi = T00029_n28FilCodi[0] ;
               RcdFound2 = 1 ;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey022( ) ;
         if ( ( RcdFound2 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtFilCodigo_Internalname ;
            }
            else if ( ( A28FilCodi != Z28FilCodi ) )
            {
               A28FilCodi = Z28FilCodi ;
               n28FilCodi = false ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "CandidateKeyNotFound", 1);
               AnyError = 1 ;
               GX_FocusControl = edtFilCodigo_Internalname ;
            }
            else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               if ( ( IsConfirmed == 1 ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtFilCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "DLT" ;
                  /* Confirm record */
                  CONFIRM_020( ) ;
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
                  Update022( ) ;
                  GX_FocusControl = edtFilCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_020( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     GX_FocusControl = bttBtn_enter_Internalname ;
                  }
               }
            }
         }
         else
         {
            if ( ( A28FilCodi != Z28FilCodi ) )
            {
               Gx_mode = "INS" ;
               if ( ( IsConfirmed == 1 ) )
               {
                  /* Insert record */
                  Insert022( ) ;
                  GX_FocusControl = edtFilCodigo_Internalname ;
               }
               else
               {
                  /* Confirm record */
                  CONFIRM_020( ) ;
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
                  GX_FocusControl = edtFilCodigo_Internalname ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  if ( ( IsConfirmed == 1 ) )
                  {
                     /* Insert record */
                     Insert022( ) ;
                     GX_FocusControl = edtFilCodigo_Internalname ;
                  }
                  else
                  {
                     /* Confirm record */
                     CONFIRM_020( ) ;
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
         if ( ( A28FilCodi != Z28FilCodi ) )
         {
            A28FilCodi = Z28FilCodi ;
            n28FilCodi = false ;
            GX_msglist.addItem(GXResourceManager.GetMessage("getbeforedlt"), 1);
            AnyError = 1 ;
            GX_FocusControl = edtFilCodigo_Internalname ;
         }
         else
         {
            if ( ( IsConfirmed == 1 ) )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtFilCodigo_Internalname ;
            }
            else
            {
               Gx_mode = "DLT" ;
               /* Confirm record */
               CONFIRM_020( ) ;
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
         GetKey022( ) ;
         if ( ( RcdFound2 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("noupdate"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtFilCodigo_Internalname ;
            }
            else if ( ( A28FilCodi != Z28FilCodi ) )
            {
               A28FilCodi = Z28FilCodi ;
               n28FilCodi = false ;
               GX_msglist.addItem(GXResourceManager.GetMessage("getbeforeupd"), "DuplicatePrimaryKey", 1);
               AnyError = 1 ;
               GX_FocusControl = edtFilCodigo_Internalname ;
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
            if ( ( A28FilCodi != Z28FilCodi ) )
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
                  GX_FocusControl = edtFilCodigo_Internalname ;
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
         context.RollbackDataStores("TFilme");
         GX_FocusControl = edtFilNome_Internalname ;
      }

      protected void insert_Check( )
      {
         CONFIRM_020( ) ;
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
         if ( ( RcdFound2 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("keynfound"), "PrimaryKeyNotFound", 1);
            AnyError = 1 ;
         }
         GX_FocusControl = edtFilNome_Internalname ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart022( ) ;
         if ( ( RcdFound2 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtFilNome_Internalname ;
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( ( RcdFound2 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtFilNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( ( RcdFound2 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtFilNome_Internalname ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart022( ) ;
         if ( ( RcdFound2 == 0 ) )
         {
            GX_msglist.addItem(GXResourceManager.GetMessage("norectobrow"), 0);
         }
         else
         {
            while ( ( RcdFound2 != 0 ) )
            {
               ScanNext022( ) ;
            }
            Gx_mode = "UPD" ;
         }
         GX_FocusControl = edtFilNome_Internalname ;
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00022 */
            pr_default.execute(0, new Object[] {n28FilCodi, A28FilCodi});
            if ( ! (pr_default.getStatus(0) != 103) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("lock", new   object[]  {"FILME"}), "RecordIsLocked", 1);
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( String.CompareOrdinal(Z29FilNome.TrimEnd(' '), T00022_A29FilNome[0].TrimEnd(' ') ) != 0 ) || ( Z30FilSitu != T00022_A30FilSitu[0] ) || ( Z31FilData != T00022_A31FilData[0] ) || ( Z33CatCodi != T00022_A33CatCodi[0] ) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("waschg", new   object[]  {"FILME"}), "RecordWasChanged", 1);
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable022( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM022( 2) ;
            CheckOptimisticConcurrency022( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm022( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert022( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000210 */
                     pr_default.execute(8, new Object[] {n29FilNome, A29FilNome, n30FilSitu, A30FilSitu, n31FilData, A31FilData, n32FIlDesc, A32FIlDesc, n33CatCodi, A33CatCodi});
                     pr_default.close(8);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000211 */
                     pr_default.execute(9);
                     A28FilCodi = T000211_A28FilCodi[0] ;
                     n28FilCodi = T000211_n28FilCodi[0] ;
                     pr_default.close(9);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucadded"), 0);
                           ResetCaption020( ) ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable022( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm022( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate022( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000212 */
                     pr_default.execute(10, new Object[] {n29FilNome, A29FilNome, n30FilSitu, A30FilSitu, n31FilData, A31FilData, n32FIlDesc, A32FIlDesc, n33CatCodi, A33CatCodi, n28FilCodi, A28FilCodi});
                     pr_default.close(10);
                     DeferredUpdate022( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(GXResourceManager.GetMessage("sucupdated"), 0);
                           ResetCaption020( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate022( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls022( ) ;
            /* No cascading delete specified. */
            AfterConfirm022( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete022( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000213 */
                  pr_default.execute(11, new Object[] {n28FilCodi, A28FilCodi});
                  pr_default.close(11);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        move_next( ) ;
                        if ( ( RcdFound2 == 0 ) )
                        {
                           InitAll022( ) ;
                           Gx_mode = "INS" ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                        }
                        GX_msglist.addItem(GXResourceManager.GetMessage("sucdeleted"), 0);
                        ResetCaption020( ) ;
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
         sMode2 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel022( ) ;
         Gx_mode = sMode2 ;
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000214 */
            pr_default.execute(12, new Object[] {n33CatCodi, A33CatCodi});
            A34CatNome = T000214_A34CatNome[0] ;
            n34CatNome = T000214_n34CatNome[0] ;
            pr_default.close(12);
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000215 */
            pr_default.execute(13, new Object[] {n28FilCodi, A28FilCodi});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de Mídias"}), "CannotDeleteReferencedRecord", 1);
               AnyError = 1 ;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel022( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(0);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete022( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("TFilme");
            if ( ( AnyError == 0 ) )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("TFilme");
         }
         IsModified = 0 ;
         if ( ( AnyError != 0 ) )
         {
            context.wjLoc = "" ;
         }
      }

      protected void ScanStart022( )
      {
         /* Using cursor T000216 */
         pr_default.execute(14);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound2 = 1 ;
            A28FilCodi = T000216_A28FilCodi[0] ;
            n28FilCodi = T000216_n28FilCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         pr_default.readNext(14);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound2 = 1 ;
            A28FilCodi = T000216_A28FilCodi[0] ;
            n28FilCodi = T000216_n28FilCodi[0] ;
         }
      }

      protected void ScanEnd022( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         WriteHtmlText( "Cadastro de Filmes") ;
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
         WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return GXValidForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" ACTION=\""+formatLink("tfilme.aspx") +"\""+">") ;
         gx_hidden_field( "_EventName", "");
         gx_hidden_field( "_EventGridId", "");
         gx_hidden_field( "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm022( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         gx_hidden_field( "Z28FilCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28FilCodi), 9, 0, ".", "")));
         gx_hidden_field( "Z29FilNome", StringUtil.RTrim( Z29FilNome));
         gx_hidden_field( "Z30FilSitu", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30FilSitu), 1, 0, ".", "")));
         gx_hidden_field( "Z31FilData", DateTimeUtil.DToC( Z31FilData, 0, "/"));
         gx_hidden_field( "Z33CatCodi", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33CatCodi), 9, 0, ".", "")));
         gx_hidden_field( "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         gx_hidden_field( "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         gx_hidden_field( "Mode", StringUtil.RTrim( Gx_mode));
         gx_hidden_field( "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         WriteHtmlTextNl( "</body>") ;
         WriteHtmlTextNl( "</html>") ;
      }

      protected void InitializeNonKey022( )
      {
         A29FilNome = "" ;
         n29FilNome = false ;
         n29FilNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A29FilNome).TrimEnd(' ') )==0)) ? true : false) ;
         A30FilSitu = 0 ;
         n30FilSitu = false ;
         n30FilSitu = (((0==A30FilSitu)) ? true : false) ;
         A31FilData = (DateTime)(DateTime.MinValue) ;
         n31FilData = false ;
         n31FilData = (((DateTime.MinValue==A31FilData)) ? true : false) ;
         A32FIlDesc = "" ;
         n32FIlDesc = false ;
         n32FIlDesc = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A32FIlDesc).TrimEnd(' ') )==0)) ? true : false) ;
         A33CatCodi = 0 ;
         n33CatCodi = false ;
         n33CatCodi = (((0==A33CatCodi)) ? true : false) ;
         A34CatNome = "" ;
         n34CatNome = false ;
      }

      protected void InitAll022( )
      {
         A28FilCodi = 0 ;
         n28FilCodi = false ;
         InitializeNonKey022( ) ;
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
            WriteHtmlTextNl( "var wHGx0020=null;") ;
            WriteHtmlTextNl( "var wHGx0020=null;") ;
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
            WriteHtmlTextNl( "if (!gxCheckControlConds('PROMPT_33', '_', 0, [22],isMod)) {return;}") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:false};") ;
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
            WriteHtmlTextNl( "function onCloseHGx0020()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0020(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
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
            WriteHtmlTextNl( "function onCloseHGx0020()") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlText( "form_onchange(document.forms[0]."+"Mode, document.forms[0]."+"IsConfirmed,(typeof(window.GXPkIsDirty)==\"undefined\"?false:window.GXPkIsDirty),null,'eng');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "function HGx0020(P0,isMod)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "GXPARAMETERS[0] = {Ctrl:P0,isKey:true};") ;
            WriteHtmlTextNl( "if (wHGx0020== null || wHGx0020.closed)") ;
            WriteHtmlTextNl( "{") ;
            WriteHtmlTextNl( "window.GXPromptCloseHandler = onCloseHGx0020;") ;
            WriteHtmlText( "document.forms[0]._EventName.value='"+"';") ;
            WriteHtmlTextNl( "GXISGET = true;") ;
            WriteHtmlTextNl( "sParms = \"?\";") ;
            WriteHtmlTextNl( "sParms = sParms + (gxurlvalue(P0));") ;
            WriteHtmlText( "wHGx0020=open(\"") ;
            WriteHtmlText( "hgx0020.aspx") ;
            WriteHtmlText( "\" + sParms, '', 'toolbar=no,location=no,directories=no,status=yes,menubar=no,scrollbars=yes,resizable=yes,copyhistory=no');") ;
            WriteHtmlTextNl( "}") ;
            WriteHtmlTextNl( "wHGx0020.focus();") ;
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
         WriteHtmlTextNl( "obj."+"FILNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "obj."+"FILSITUACAO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"FILDESCRICAO.value = "+"\""+StringUtil.RTrim( StringUtil.StringReplace( "", StringUtil.NewLine( ), "\\n"))+"\";") ;
         WriteHtmlTextNl( "obj."+"CATCODIGO.value = "+"\""+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 1, 0, ".", ""))+"\";") ;
         WriteHtmlTextNl( "obj."+"CATNOME.value = "+"\""+StringUtil.RTrim( "")+"\";") ;
         WriteHtmlTextNl( "}") ;
         WriteHtmlTextNl( "</script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "form_onchange.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "std_messages.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gxvdate.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "gx_help.js")+"\"></script>") ;
         WriteHtmlTextNl( "<script language=\"JavaScript\" src=\""+convertURL( "tfilme.js")+"\"></script>") ;
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
               sEventJsCode = "HGx0020(" + "document.forms[0]." + "FILCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0020(" + "document.forms[0]." + "FILCODIGO" + ");" ;
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
                     sEventJsCode = "HGx0020(" + "document.forms[0]." + "FILCODIGO" + ");" ;
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
            sEventJsCode = "HGx0020(" + "document.forms[0]." + "FILCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0020(" + "document.forms[0]." + "FILCODIGO" + ");" + "return false;" ;
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
               sEventJsCode = "HGx0020(" + "document.forms[0]." + "FILCODIGO" + ");" + "return false;" ;
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

      protected void initialize_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttBtn_select_Internalname = "BTN_SELECT" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtFilCodigo_Internalname = "FILCODIGO" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtFilNome_Internalname = "FILNOME" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         cmbFilSituacao_Internalname = "FILSITUACAO" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtFilData_Internalname = "FILDATA" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtFIlDescricao_Internalname = "FILDESCRICAO" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtCatCodigo_Internalname = "CATCODIGO" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtCatNome_Internalname = "CATNOME" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_33_Internalname = "PROMPT_33" ;
         edtCatNome_Jsonclick = "" ;
         imgprompt_33_Link = "" ;
         edtCatCodigo_Jsonclick = "" ;
         edtFilData_Jsonclick = "" ;
         cmbFilSituacao_Jsonclick = "" ;
         edtFilNome_Jsonclick = "" ;
         edtFilCodigo_Jsonclick = "" ;
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
         RcdFound2 = 0 ;
         GxWebError = 0 ;
         scmdbuf = "" ;
         gxajaxcallmode = 0 ;
         gxfirstwebparm = "" ;
         A33CatCodi = 0 ;
         n33CatCodi = false ;
         lblTextblock1_Name = "" ;
         lblTextblock2_Name = "" ;
         lblTextblock3_Name = "" ;
         lblTextblock4_Name = "" ;
         lblTextblock5_Name = "" ;
         lblTextblock6_Name = "" ;
         lblTextblock7_Name = "" ;
         IsConfirmed = 0 ;
         IsModified = 0 ;
         AnyError = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         edtFilCodigo_Internalname = "" ;
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
         A28FilCodi = 0 ;
         edtFilCodigo_Jsonclick = "" ;
         bttBtn_get_Internalname = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock2_Internalname = "" ;
         lblTextblock2_Jsonclick = "" ;
         edtFilNome_Internalname = "" ;
         A29FilNome = "" ;
         edtFilNome_Jsonclick = "" ;
         lblTextblock3_Internalname = "" ;
         lblTextblock3_Jsonclick = "" ;
         A30FilSitu = 0 ;
         cmbFilSituacao_Internalname = "" ;
         cmbFilSituacao_Jsonclick = "" ;
         lblTextblock4_Internalname = "" ;
         lblTextblock4_Jsonclick = "" ;
         edtFilData_Internalname = "" ;
         A31FilData = (DateTime)(DateTime.MinValue) ;
         edtFilData_Jsonclick = "" ;
         gxCalCtrlInc = 0 ;
         lblTextblock5_Internalname = "" ;
         lblTextblock5_Jsonclick = "" ;
         smlStyle = "" ;
         edtFIlDescricao_Internalname = "" ;
         A32FIlDesc = "" ;
         lblTextblock6_Internalname = "" ;
         lblTextblock6_Jsonclick = "" ;
         edtCatCodigo_Internalname = "" ;
         edtCatCodigo_Jsonclick = "" ;
         imgprompt_33_Internalname = "" ;
         imgprompt_33_Link = "" ;
         lblTextblock7_Internalname = "" ;
         lblTextblock7_Jsonclick = "" ;
         edtCatNome_Internalname = "" ;
         A34CatNome = "" ;
         edtCatNome_Jsonclick = "" ;
         Z28FilCodi = 0 ;
         Z29FilNome = "" ;
         Z30FilSitu = 0 ;
         Z31FilData = (DateTime)(DateTime.MinValue) ;
         Z33CatCodi = 0 ;
         Gx_mode = "" ;
         n28FilCodi = false ;
         n29FilNome = false ;
         n30FilSitu = false ;
         n31FilData = false ;
         n32FIlDesc = false ;
         n34CatNome = false ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GX_JID = 0 ;
         Z32FIlDesc = "" ;
         T00025_A28FilCodi = new int[1] ;
         T00025_n28FilCodi = new bool[] {false} ;
         T00025_A29FilNome = new String[] {""} ;
         T00025_n29FilNome = new bool[] {false} ;
         T00025_A30FilSitu = new short[1] ;
         T00025_n30FilSitu = new bool[] {false} ;
         T00025_A31FilData = new DateTime[] {DateTime.MinValue} ;
         T00025_n31FilData = new bool[] {false} ;
         T00025_A32FIlDesc = new String[] {""} ;
         T00025_n32FIlDesc = new bool[] {false} ;
         T00025_A34CatNome = new String[] {""} ;
         T00025_n34CatNome = new bool[] {false} ;
         T00025_A33CatCodi = new int[1] ;
         T00025_n33CatCodi = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00024_A34CatNome = new String[] {""} ;
         T00024_n34CatNome = new bool[] {false} ;
         T00026_A34CatNome = new String[] {""} ;
         T00026_n34CatNome = new bool[] {false} ;
         wbTemp = 0 ;
         T00027_A28FilCodi = new int[1] ;
         T00027_n28FilCodi = new bool[] {false} ;
         T00023_A28FilCodi = new int[1] ;
         T00023_n28FilCodi = new bool[] {false} ;
         T00023_A29FilNome = new String[] {""} ;
         T00023_n29FilNome = new bool[] {false} ;
         T00023_A30FilSitu = new short[1] ;
         T00023_n30FilSitu = new bool[] {false} ;
         T00023_A31FilData = new DateTime[] {DateTime.MinValue} ;
         T00023_n31FilData = new bool[] {false} ;
         T00023_A32FIlDesc = new String[] {""} ;
         T00023_n32FIlDesc = new bool[] {false} ;
         T00023_A33CatCodi = new int[1] ;
         T00023_n33CatCodi = new bool[] {false} ;
         sMode2 = "" ;
         T00028_A28FilCodi = new int[1] ;
         T00028_n28FilCodi = new bool[] {false} ;
         T00029_A28FilCodi = new int[1] ;
         T00029_n28FilCodi = new bool[] {false} ;
         T00022_A28FilCodi = new int[1] ;
         T00022_n28FilCodi = new bool[] {false} ;
         T00022_A29FilNome = new String[] {""} ;
         T00022_n29FilNome = new bool[] {false} ;
         T00022_A30FilSitu = new short[1] ;
         T00022_n30FilSitu = new bool[] {false} ;
         T00022_A31FilData = new DateTime[] {DateTime.MinValue} ;
         T00022_n31FilData = new bool[] {false} ;
         T00022_A32FIlDesc = new String[] {""} ;
         T00022_n32FIlDesc = new bool[] {false} ;
         T00022_A33CatCodi = new int[1] ;
         T00022_n33CatCodi = new bool[] {false} ;
         T000211_A28FilCodi = new int[1] ;
         T000211_n28FilCodi = new bool[] {false} ;
         T000214_A34CatNome = new String[] {""} ;
         T000214_n34CatNome = new bool[] {false} ;
         T000215_A37MidCodi = new int[1] ;
         T000216_A28FilCodi = new int[1] ;
         T000216_n28FilCodi = new bool[] {false} ;
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
         cmbCObjCtrl = new GXCombobox();
         GXt_char14 = "" ;
         GXt_char15 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tfilme__default(),
            new Object[][] {
                new Object[] {
               T00022_A28FilCodi, T00022_A29FilNome, T00022_n29FilNome, T00022_A30FilSitu, T00022_n30FilSitu, T00022_A31FilData, T00022_n31FilData, T00022_A32FIlDesc, T00022_n32FIlDesc, T00022_A33CatCodi,
               T00022_n33CatCodi
               }
               , new Object[] {
               T00023_A28FilCodi, T00023_A29FilNome, T00023_n29FilNome, T00023_A30FilSitu, T00023_n30FilSitu, T00023_A31FilData, T00023_n31FilData, T00023_A32FIlDesc, T00023_n32FIlDesc, T00023_A33CatCodi,
               T00023_n33CatCodi
               }
               , new Object[] {
               T00024_A34CatNome, T00024_n34CatNome
               }
               , new Object[] {
               T00025_A28FilCodi, T00025_A29FilNome, T00025_n29FilNome, T00025_A30FilSitu, T00025_n30FilSitu, T00025_A31FilData, T00025_n31FilData, T00025_A32FIlDesc, T00025_n32FIlDesc, T00025_A34CatNome,
               T00025_n34CatNome, T00025_A33CatCodi, T00025_n33CatCodi
               }
               , new Object[] {
               T00026_A34CatNome, T00026_n34CatNome
               }
               , new Object[] {
               T00027_A28FilCodi
               }
               , new Object[] {
               T00028_A28FilCodi
               }
               , new Object[] {
               T00029_A28FilCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000211_A28FilCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000214_A34CatNome, T000214_n34CatNome
               }
               , new Object[] {
               T000215_A37MidCodi
               }
               , new Object[] {
               T000216_A28FilCodi
               }
            }
         );
      }

      private short RcdFound2 ;
      private short GxWebError ;
      private short gxajaxcallmode ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short A30FilSitu ;
      private short Z30FilSitu ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int A33CatCodi ;
      private int trnEnded ;
      private int bttBtn_delete_Enabled ;
      private int A28FilCodi ;
      private int gxCalCtrlInc ;
      private int Z28FilCodi ;
      private int Z33CatCodi ;
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
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtFilCodigo_Internalname ;
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
      private String edtFilCodigo_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtFilNome_Internalname ;
      private String edtFilNome_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String cmbFilSituacao_Internalname ;
      private String cmbFilSituacao_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtFilData_Internalname ;
      private String edtFilData_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String smlStyle ;
      private String edtFIlDescricao_Internalname ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtCatCodigo_Internalname ;
      private String edtCatCodigo_Jsonclick ;
      private String imgprompt_33_Internalname ;
      private String imgprompt_33_Link ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtCatNome_Internalname ;
      private String edtCatNome_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode2 ;
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
      private DateTime A31FilData ;
      private DateTime Z31FilData ;
      private bool n33CatCodi ;
      private bool wbErr ;
      private bool n28FilCodi ;
      private bool n29FilNome ;
      private bool n30FilSitu ;
      private bool n31FilData ;
      private bool n32FIlDesc ;
      private bool n34CatNome ;
      private bool addContentType ;
      private String A32FIlDesc ;
      private String Z32FIlDesc ;
      private String A29FilNome ;
      private String A34CatNome ;
      private String Z29FilNome ;
      private GeneXus.Utils.GxStringCollection Formheaderjscriptsrc ;
      private GXWebForm Form ;
      private IDataReader T00022 ;
      private IDataReader T00023 ;
      private IDataReader T00024 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbFilSituacao ;
      private IDataReader T00025 ;
      private IDataStoreProvider pr_default ;
      private int[] T00025_A28FilCodi ;
      private bool[] T00025_n28FilCodi ;
      private String[] T00025_A29FilNome ;
      private bool[] T00025_n29FilNome ;
      private short[] T00025_A30FilSitu ;
      private bool[] T00025_n30FilSitu ;
      private DateTime[] T00025_A31FilData ;
      private bool[] T00025_n31FilData ;
      private String[] T00025_A32FIlDesc ;
      private bool[] T00025_n32FIlDesc ;
      private String[] T00025_A34CatNome ;
      private bool[] T00025_n34CatNome ;
      private int[] T00025_A33CatCodi ;
      private bool[] T00025_n33CatCodi ;
      private String[] T00024_A34CatNome ;
      private bool[] T00024_n34CatNome ;
      private IDataReader T00026 ;
      private String[] T00026_A34CatNome ;
      private bool[] T00026_n34CatNome ;
      private IDataReader T00027 ;
      private int[] T00027_A28FilCodi ;
      private bool[] T00027_n28FilCodi ;
      private int[] T00023_A28FilCodi ;
      private bool[] T00023_n28FilCodi ;
      private String[] T00023_A29FilNome ;
      private bool[] T00023_n29FilNome ;
      private short[] T00023_A30FilSitu ;
      private bool[] T00023_n30FilSitu ;
      private DateTime[] T00023_A31FilData ;
      private bool[] T00023_n31FilData ;
      private String[] T00023_A32FIlDesc ;
      private bool[] T00023_n32FIlDesc ;
      private int[] T00023_A33CatCodi ;
      private bool[] T00023_n33CatCodi ;
      private IDataReader T00028 ;
      private int[] T00028_A28FilCodi ;
      private bool[] T00028_n28FilCodi ;
      private IDataReader T00029 ;
      private int[] T00029_A28FilCodi ;
      private bool[] T00029_n28FilCodi ;
      private int[] T00022_A28FilCodi ;
      private bool[] T00022_n28FilCodi ;
      private String[] T00022_A29FilNome ;
      private bool[] T00022_n29FilNome ;
      private short[] T00022_A30FilSitu ;
      private bool[] T00022_n30FilSitu ;
      private DateTime[] T00022_A31FilData ;
      private bool[] T00022_n31FilData ;
      private String[] T00022_A32FIlDesc ;
      private bool[] T00022_n32FIlDesc ;
      private int[] T00022_A33CatCodi ;
      private bool[] T00022_n33CatCodi ;
      private IDataReader T000211 ;
      private int[] T000211_A28FilCodi ;
      private bool[] T000211_n28FilCodi ;
      private IDataReader T000214 ;
      private String[] T000214_A34CatNome ;
      private bool[] T000214_n34CatNome ;
      private IDataReader T000215 ;
      private int[] T000215_A37MidCodi ;
      private IDataReader T000216 ;
      private int[] T000216_A28FilCodi ;
      private bool[] T000216_n28FilCodi ;
      private GXCombobox cmbCObjCtrl ;
   }

   public class tfilme__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@FilNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@FilSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilData",SqlDbType.DateTime,8,0} ,
          new Object[] {"@FIlDescricao",SqlDbType.Text,800,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@FilNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@FilSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FilData",SqlDbType.DateTime,8,0} ,
          new Object[] {"@FIlDescricao",SqlDbType.Text,800,0} ,
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@CatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000216 ;
          prmT000216 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00022", "SELECT [FilCodigo], [FilNome], [FilSituacao], [FilData], [FIlDescricao], [CatCodigo] FROM [FILME] WITH (UPDLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00023", "SELECT [FilCodigo], [FilNome], [FilSituacao], [FilData], [FIlDescricao], [CatCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00024", "SELECT [CatNome] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00025", "SELECT TM1.[FilCodigo], TM1.[FilNome], TM1.[FilSituacao], TM1.[FilData], TM1.[FIlDescricao], T2.[CatNome], TM1.[CatCodigo] FROM ([FILME] TM1 WITH (NOLOCK) LEFT JOIN [CATEGORIA] T2 WITH (NOLOCK) ON T2.[CatCodigo] = TM1.[CatCodigo]) WHERE TM1.[FilCodigo] = @FilCodigo ORDER BY TM1.[FilCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00026", "SELECT [CatNome] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00027", "SELECT [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00028", "SELECT TOP 1 [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE ( [FilCodigo] > @FilCodigo) ORDER BY [FilCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00029", "SELECT TOP 1 [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE ( [FilCodigo] < @FilCodigo) ORDER BY [FilCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000210", "INSERT INTO [FILME] ([FilNome], [FilSituacao], [FilData], [FIlDescricao], [CatCodigo]) VALUES (@FilNome, @FilSituacao, @FilData, @FIlDescricao, @CatCodigo)", GxErrorMask.GX_NOMASK,prmT000210)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000211", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000212", "UPDATE [FILME] SET [FilNome]=@FilNome, [FilSituacao]=@FilSituacao, [FilData]=@FilData, [FIlDescricao]=@FIlDescricao, [CatCodigo]=@CatCodigo  WHERE [FilCodigo] = @FilCodigo", GxErrorMask.GX_NOMASK,prmT000212)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000213", "DELETE FROM [FILME]  WHERE [FilCodigo] = @FilCodigo", GxErrorMask.GX_NOMASK,prmT000213)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000214", "SELECT [CatNome] FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @CatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000214,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000215", "SELECT TOP 1 [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [FilCodigo] = @FilCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000216", "SELECT [FilCodigo] FROM [FILME] WITH (NOLOCK) ORDER BY [FilCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,100,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
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
                   stmt.setNull( 4 , SqlDbType.Text );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[9]);
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
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
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
                   stmt.setNull( 4 , SqlDbType.Text );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[11]);
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
