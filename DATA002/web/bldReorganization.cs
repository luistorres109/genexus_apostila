using System;
using GeneXus.Builder;
using System.IO;
public class bldReorganization : GxBaseBuilder
{
   string cs_path = "." ;
   public bldReorganization( ) : base()
   {
   }

   public override void BeforeCompile( )
   {
   }

   public override void AfterCompile( )
   {
      this.exec( "virtualdir.exe", getenv("webroot")+" \""+getenv("mdlpath")+"\"" + " \""+getenv("csc")+"\"" , ".");
   }

   static public void Main( string[] args )
   {
      bldReorganization x = new bldReorganization() ;
      x.SetMainSourceFile( "");
      x.LoadVariables( args);
      x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\Reorganization.dll", cs_path + @"\Reorganization.rsp");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.eng.dll", cs_path + @"\messages.eng.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( ( obj == @"bin\Reorganization.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\Reorganization.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxrgzd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxrgzc.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxrgzb.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxrgza.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxcrtdb.cs" ))
            return true;
      }
      if ( ( obj == @"bin\messages.eng.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\messages.eng.txt" ))
            return true;
      }
      return false ;
   }

}

