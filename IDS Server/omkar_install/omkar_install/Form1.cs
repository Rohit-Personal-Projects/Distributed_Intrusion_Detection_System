using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
namespace SERKAN.THE.MAN
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox1.Lines = GetInstalled();
      



    }

    public static string[] GetInstalled()
    {int i=0;
      List<string> result = new List<string>();
      TextWriter tw = new StreamWriter("E:\\IDS final\\IDS Server\\FTPserver\\FileLog.txt");
      tw.WriteLine("THE following Softwares are installed on the Computer");
      tw.WriteLine();
      tw.WriteLine();
      string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
      using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
      {
        foreach (string skName in rk.GetSubKeyNames())
        {
            using (RegistryKey sk = rk.OpenSubKey(skName))
            {
                string prog = Convert.ToString(sk.GetValue("DisplayName"));
                if (!string.IsNullOrEmpty(prog))
                {
                    result.Add(prog);
                    tw.WriteLine(prog);
                }
            }
        }
      }
      tw.Close();
      using (StreamReader li = new StreamReader("E:\\IDS final\\IDS Server\\FTPserver\\FileLogOrg.txt"))
      using (StreamReader li2 = new StreamReader("E:\\IDS final\\IDS Server\\FTPserver\\FileLog.txt"))
      {
          while (true)
          {
              if (li.EndOfStream || li2.EndOfStream)
                  break;
              string liTxt = li.ReadLine();
              string li2Txt = li2.ReadLine();
              if (!liTxt.Equals(li2Txt))
              {
                  i=1;
                  break;
              }
              }
      }






if(i==1)
    MessageBox.Show("Installations have changed", "Alert Box");





      




      return result.ToArray();
     
    }


  }
}
