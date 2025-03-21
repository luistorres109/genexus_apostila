using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class gxrgzd : GXReorganization
   {
      public gxrgzd( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrgzd( IGxContext context )
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
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         /* Class with standard routines for Reorganization. */
      }

      public void DropColumnConstraints( String sTableName ,
                                         String sColumnName ,
                                         String sSchemaName )
      {
         /* Using cursor P00012 */
         pr_default.execute(0, new Object[] {sTableName, sColumnName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            constraintname = P00012_Aconstrain[0] ;
            nconstrain = P00012_nconstrain[0] ;
            cmdBuffer = "ALTER TABLE " + sSchemaName + " DROP CONSTRAINT " + constraintname ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         sTableName = "" ;
         sColumnName = "" ;
         sSchemaName = "" ;
         xtype = "" ;
         tablename = "" ;
         constraintname = "" ;
         nconstrain = false ;
         columnname = "" ;
         scmdbuf = "" ;
         P00012_Aconstrain = new String[] {""} ;
         P00012_nconstrain = new bool[] {false} ;
         nconstrain = false ;
         cmdBuffer = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gxrgzd__default(),
            new Object[][] {
                new Object[] {
               P00012_Aconstrain
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected String sTableName ;
      protected String sColumnName ;
      protected String sSchemaName ;
      protected String xtype ;
      protected String tablename ;
      protected String constraintname ;
      protected String columnname ;
      protected String scmdbuf ;
      protected String cmdBuffer ;
      protected bool nconstrain ;
      protected IGxDataStore dsDefault ;
      protected IDataReader P00012 ;
      protected IDataStoreProvider pr_default ;
      protected String[] P00012_Aconstrain ;
      protected bool[] P00012_nconstrain ;
      protected GxCommand RGZ ;
   }

   public class gxrgzd__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0} ,
          new Object[] {"@sColumnName",SqlDbType.Char,255,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("P00012", "SELECT T1.[name] FROM [sysobjects] T1 WITH (NOLOCK), [sysobjects] T2 WITH (NOLOCK), [sysconstraints] T3 WITH (NOLOCK), [syscolumns] T4 WITH (NOLOCK) WHERE (T1.[parent_obj] = T2.[id] AND T1.[id] = T3.[constid] AND T3.[colid] = T4.[colid] AND T2.[id] = T4.[id]) AND (T1.[xtype] = 'D' and T2.[name] = @sTableName and T4.[name] = @sColumnName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
