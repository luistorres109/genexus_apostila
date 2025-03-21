using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override void BeforeCompile( )
   {
   }

   public override void AfterCompile( )
   {
      this.exec( "virtualdir.exe", getenv("webroot")+" \""+getenv("mdlpath")+"\"" + " \""+getenv("csc")+"\"" , ".");
      this.exec( "UpdateConfigWeb.exe", " ", ".");
   }

   static public void Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "Developermenu.cs");
      x.LoadVariables( args);
      x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\gxCommon.dll", cs_path + @"\gxCommon.rsp");
      sc.Add( @"bin\hgx0060.dll", cs_path + @"\hgx0060.rsp");
      sc.Add( @"bin\hgx0050.dll", cs_path + @"\hgx0050.rsp");
      sc.Add( @"bin\hgx0040.dll", cs_path + @"\hgx0040.rsp");
      sc.Add( @"bin\hgx0030.dll", cs_path + @"\hgx0030.rsp");
      sc.Add( @"bin\hgx0020.dll", cs_path + @"\hgx0020.rsp");
      sc.Add( @"bin\hgx0010.dll", cs_path + @"\hgx0010.rsp");
      sc.Add( @"bin\tmidia.dll", cs_path + @"\tmidia.rsp");
      sc.Add( @"bin\tcidade.dll", cs_path + @"\tcidade.rsp");
      sc.Add( @"bin\testado.dll", cs_path + @"\testado.rsp");
      sc.Add( @"bin\tcategoria.dll", cs_path + @"\tcategoria.rsp");
      sc.Add( @"bin\tfilme.dll", cs_path + @"\tfilme.rsp");
      sc.Add( @"bin\tpessoa.dll", cs_path + @"\tpessoa.rsp");
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
      if ( ( obj == @"bin\tpessoa.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\tpessoa.cs" ))
            return true;
      }
      if ( ( obj == @"bin\tfilme.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\tfilme.cs" ))
            return true;
      }
      if ( ( obj == @"bin\tcategoria.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\tcategoria.cs" ))
            return true;
      }
      if ( ( obj == @"bin\testado.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\testado.cs" ))
            return true;
      }
      if ( ( obj == @"bin\tcidade.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\tcidade.cs" ))
            return true;
      }
      if ( ( obj == @"bin\tmidia.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\tmidia.cs" ))
            return true;
      }
      if ( ( obj == @"bin\hgx0010.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\hgx0010.cs" ))
            return true;
      }
      if ( ( obj == @"bin\hgx0020.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\hgx0020.cs" ))
            return true;
      }
      if ( ( obj == @"bin\hgx0030.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\hgx0030.cs" ))
            return true;
      }
      if ( ( obj == @"bin\hgx0040.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\hgx0040.cs" ))
            return true;
      }
      if ( ( obj == @"bin\hgx0050.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\hgx0050.cs" ))
            return true;
      }
      if ( ( obj == @"bin\hgx0060.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\hgx0060.cs" ))
            return true;
      }
      if ( ( obj == @"bin\gxCommon.dll" ) )
      {
         if (checkTime(obj, cs_path + @"\gxCommon.rsp" ))
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

