using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class GxSilentTrnGridCollection : GxObjectCollection
   {
      public GxSilentTrnGridCollection( IGxContext context ,
                                        string containedName ,
                                        string containedXmlNamespace ,
                                        string containedType ,
                                        string containedTypeNamespace ) : base(context, containedName, containedXmlNamespace, containedType, containedTypeNamespace)
      {
      }

      public GxSilentTrnGridCollection( )
      {
      }

      public override int Add( Object o )
      {
         IGxSilentTrnGridItem item ;
         item = (IGxSilentTrnGridItem)(o) ;
         item.gxTpr_Modified = 1 ;
         item.gxTpr_Mode = "INS" ;
         int i ;
         i = base.Add( item) ;
         return i ;
      }

      public override void RemoveAt( int idx )
      {
         IGxSilentTrnGridItem item ;
         item = (IGxSilentTrnGridItem)(this[idx]) ;
         if ( ( String.CompareOrdinal(item.gxTpr_Mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            base.RemoveAt( idx);
         }
         else
         {
            item.gxTpr_Mode = "DLT" ;
         }
         return  ;
      }

      public override void Clear( )
      {
         int idx ;
         idx = (int)(this.Count-1) ;
         while ( ( idx >= 0 ) )
         {
            this.RemoveAt( idx);
            idx = (int)(idx-1) ;
         }
         return  ;
      }

   }

}
