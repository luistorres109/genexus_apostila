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
public class gxcrtdb : GXReorganization
{
   public gxcrtdb( )
   {
      context = new GxContext(  );
      DataStoreUtil.LoadDataStores( context);
      dsDefault = context.GetDataStore("Default") ;
      IsMain = true;
   }

   public gxcrtdb( IGxContext context )
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
      /* This program creates the database to hold tables an indices. */
      /* API odbc Driver qesqlserver does not require or allow remote */
      /* database creation. */
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
      /* GeneXus formulas. */
   }

   protected IGxDataStore dsDefault ;
}

