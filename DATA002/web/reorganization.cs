namespace GeneXus.Programs {
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
   public class reorganization : GXReorganization
   {
      public static void Main( )
      {
         new reorganization().execute();
      }

      [ WebMethod ]
      public ArrayList execute( )
      {
         _Context = new GxContext();
         GeneXus.Configuration.Config.ConfigFileName = "client.exe.config" ;
         DataStoreUtil.LoadDataStores( context);
         new gxcrtdb( _Context ).execute();
         try
         {
            new gxrgza( _Context ).execute();
            new gxrgzb( _Context ).execute();
            new gxrgzc( _Context ).execute();
            GXReorganization.NotifyEnd();
         }
         catch (ThreadAbortException) {}
         return GXReorganization.ReorgLog;
      }

      public override void ExecForm( )
      {
         execute();
      }

   }

}
