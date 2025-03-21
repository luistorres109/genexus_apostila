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
   public class gxrgza : GXReorganization
   {
      public gxrgza( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrgza( IGxContext context )
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
         /*
            This is the first program in the reorganization process.
            It must be compiled and run before any other reorganization
            program.
         */
         /* Lock tables */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzlcktb", new   object[]  {"1"}) , null);
         /* Load data into tables. */
         /* Drop integrity constraints (if any). */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzdic", new   object[]  {"2"}) , null);
         /* Create new and temporary tables. */
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("rgzctnt", new   object[]  {"3"}) , null);
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("filecrea", new   object[]  {"PESSOA", ""}) , null);
         cmdBuffer=" DROP TABLE [PESSOA] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE TABLE [PESSOA] ([PesCodigo] int NOT null  IDENTITY(1,1), [PesNome] varchar(50) null , [PesCPF] varchar(14) null , [PesDatNasc] datetime null , [PesEndereco] varchar(50) null , [PesEndNumero] varchar(20) null , [PesBairro] varchar(50) null , [PesEmail] varchar(100) null , [PesTelefone] varchar(14) null , [PesCelular] varchar(14) null , [PesSituacao] smallint null , [CidCodigo] int null , PRIMARY KEY([PesCodigo]))  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("filecrea", new   object[]  {"FILME", ""}) , null);
         cmdBuffer=" DROP TABLE [FILME] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE TABLE [FILME] ([FilCodigo] int NOT null  IDENTITY(1,1), [FilNome] varchar(50) null , [FilSituacao] smallint null , [FilData] datetime null , [FIlDescricao] varchar(MAX) null , [CatCodigo] int null , PRIMARY KEY([FilCodigo]))  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("filecrea", new   object[]  {"CATEGORIA", ""}) , null);
         cmdBuffer=" DROP TABLE [CATEGORIA] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE TABLE [CATEGORIA] ([CatCodigo] int NOT null  IDENTITY(1,1), [CatNome] varchar(50) null , PRIMARY KEY([CatCodigo]))  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("filecrea", new   object[]  {"ESTADO", ""}) , null);
         cmdBuffer=" DROP TABLE [ESTADO] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE TABLE [ESTADO] ([EstCodigo] int NOT null  IDENTITY(1,1), [EstUF] char(2) null , [EstNome] varchar(50) null , PRIMARY KEY([EstCodigo]))  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("filecrea", new   object[]  {"CIDADE", ""}) , null);
         cmdBuffer=" DROP TABLE [CIDADE] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE TABLE [CIDADE] ([CidCodigo] int NOT null  IDENTITY(1,1), [CidNome] varchar(50) null , [EstCodigo] int null , PRIMARY KEY([CidCodigo]))  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("filecrea", new   object[]  {"MIDIA", ""}) , null);
         cmdBuffer=" DROP TABLE [MIDIA] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" CREATE TABLE [MIDIA] ([MidCodigo] int NOT null  IDENTITY(1,1), [MidTipo] smallint null , [MidSituacao] smallint null , [FilCodigo] int null , PRIMARY KEY([MidCodigo]))  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Creating temporary indexes. */
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
         cmdBuffer = "" ;
         /* GeneXus formulas. */
      }

      protected String cmdBuffer ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
   }

}
