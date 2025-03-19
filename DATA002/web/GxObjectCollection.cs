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
   [Serializable]
   public class GxObjectCollection : GxObjectCollectionBase
   {
      public GxObjectCollection( IGxContext context ,
                                 string containedName ,
                                 string containedXmlNamespace ,
                                 string containedType ,
                                 string containedTypeNamespace ) : base(context, containedName, containedXmlNamespace, containedType, containedTypeNamespace)
      {
      }

      public GxObjectCollection( )
      {
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short currError ;
         String arrayType ;
         short gxi ;
         currError = 1 ;
         arrayType = "" ;
         gxi = 0 ;
         while ( ( gxi <= oReader.AttributeCount ) )
         {
            if ( ( String.CompareOrdinal(oReader.GetAttributeLocalName(gxi).TrimEnd(' '), "arrayType".TrimEnd(' ') ) == 0 ) )
            {
               arrayType = oReader.GetAttributeByIndex(gxi) ;
            }
            gxi = (short)(gxi+1) ;
         }
         if ( ( String.CompareOrdinal(arrayType.TrimEnd(' '), "".TrimEnd(' ') ) != 0 ) )
         {
            currError = (short)(readEncodedArray(arrayType,oReader)) ;
         }
         else
         {
            currError = (short)(readCollection(oReader,sName)) ;
         }
         return currError ;
      }

      public short readEncodedArray( String arrayType ,
                                     GXXMLReader oReader )
      {
         short currError ;
         int arrayLength ;
         int arraySizeStartPos ;
         int arraySizeLength ;
         short gxi ;
         arraySizeStartPos = (int)(StringUtil.StringSearch( arrayType, "[", 1)+1) ;
         arraySizeLength = (int)(StringUtil.Len( arrayType)-arraySizeStartPos) ;
         if ( ( arraySizeStartPos == 1 ) || ( arraySizeLength == 0 ) )
         {
            throw new Exception( "GxObjectCollectionBase error: Could not read encoded array size\"+\"(\"+StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 6, 0, \".\", \"\"))+\")") ;
         }
         arrayLength = (int)(NumberUtil.Val( StringUtil.Substring( arrayType, arraySizeStartPos, arraySizeLength), ".")) ;
         currError = oReader.Read() ;
         gxi = 0 ;
         while ( ( gxi < arrayLength ) && ( currError > 0 ) )
         {
            currError = (short)(AddObjectInstance(oReader)) ;
            oReader.Read();
            gxi = (short)(gxi+1) ;
         }
         return currError ;
      }

      public short readCollection( GXXMLReader oReader ,
                                   String sName )
      {
         short currError ;
         String sTagName ;
         currError = 1 ;
         if ( ( String.CompareOrdinal(oReader.Name.TrimEnd(' '), GetContainedName().TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(sName.TrimEnd(' '), GetContainedName().TrimEnd(' ') ) == 0 ) )
         {
            currError = oReader.Read() ;
         }
         sTagName = oReader.Name ;
         this.ClearCollection();
         while ( ( String.CompareOrdinal(oReader.Name.TrimEnd(' '), sTagName.TrimEnd(' ') ) == 0 ) && ( oReader.NodeType == 1 ) && ( currError > 0 ) )
         {
            if ( IsSimpleCollection() || ( oReader.IsSimple == 0 ) )
            {
               currError = (short)(AddObjectInstance(oReader)) ;
            }
            oReader.Read();
         }
         return currError ;
      }

      public override Object Clone( )
      {
         GxObjectCollection objCol ;
         objCol = new GxObjectCollection( context, _containedName, _containedXmlNamespace, _containedType, _containedTypeNamespace) ;
         return (Object)(objCol) ;
      }

   }

}
