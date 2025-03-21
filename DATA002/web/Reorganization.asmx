<%@ WebService Language="C#"  Class="reorganization_services" %>

using System ;
using System.Collections;
using System.Web.Services ;
using GeneXus.Programs ;
public class reorganization_services
{
   [WebMethod]
   public ArrayList reorganization_service( )
   {
      return new reorganization().execute();
   }

}

