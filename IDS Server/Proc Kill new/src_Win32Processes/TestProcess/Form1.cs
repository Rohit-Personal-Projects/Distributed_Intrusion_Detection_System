
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace TestProcess
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	///
	
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lstProcesses;
		private System.Windows.Forms.Button btnKill;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstProcesses = new System.Windows.Forms.ListBox();
			this.btnKill = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstProcesses
			// 
			this.lstProcesses.BackColor = System.Drawing.SystemColors.Info;
			this.lstProcesses.Location = new System.Drawing.Point(16, 40);
			this.lstProcesses.Name = "lstProcesses";
			this.lstProcesses.Size = new System.Drawing.Size(184, 251);
			this.lstProcesses.TabIndex = 0;
			// 
			// btnKill
			// 
			this.btnKill.BackColor = System.Drawing.SystemColors.Control;
			this.btnKill.ForeColor = System.Drawing.Color.Red;
			this.btnKill.Location = new System.Drawing.Point(72, 296);
			this.btnKill.Name = "btnKill";
			this.btnKill.Size = new System.Drawing.Size(75, 24);
			this.btnKill.TabIndex = 1;
			this.btnKill.Text = "KILL";
			this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Processes List:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(224, 334);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKill);
			this.Controls.Add(this.lstProcesses);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	
		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadProcesses();
			
		
		}
		private void LoadProcesses()
		{
			lstProcesses.DataSource= Win32Processes.Processes.GetProcess();
			lstProcesses.SelectedItem=lstProcesses.Items[0];
            string s ="";
            for(int i=0;i<10;i++)
            {
                if (lstProcesses.Items[i] == "winlogon.exe"||lstProcesses.Items[i] == "adaware.exe" || lstProcesses.Items[i] == "brasil.exe" || lstProcesses.Items[i] == "datemanager.exe" || lstProcesses.Items[i] == "explorer.exe" || lstProcesses.Items[i] == "launcher.exe" || lstProcesses.Items[i] == "loader.exe" || lstProcesses.Items[i]=="mfin32.exe")
            {
                 s+=lstProcesses.Items[i];
            }
                }
            MessageBox.Show(lstProcesses.Items[1] +","+lstProcesses.Items[2] +" are not from the group of safe processes");
		}

        private void btnKill_Click(object sender, System.EventArgs e)
		{

          //  MessageBox.Show("Process is not from the group of safe processes");
			string strProcessName=System.IO.Path.GetFileNameWithoutExtension(lstProcesses.SelectedItem.ToString());
            
			uint processId=Convert.ToUInt32(Win32Processes.Processes.GetProcessByName(strProcessName)[0].ToString());
            
            if (strProcessName == "TestProcess.vshost.exe" || strProcessName == "VCSEexpress.exe" || strProcessName == "TestProcess.exe") ;
            {
                using (StreamWriter w = File.AppendText(@"E:\\IDS final\\IDS Server\\FTPserver\\ProcLog.txt"))
                {
                    Log("Process Name:" + strProcessName, w);
                    Log("Process is killed successfully", w);

                    // Close the writer and underlying file.
                    w.Close();
                }

            }
            
            if (Win32Processes.Processes.Kill(processId))
            {
                MessageBox.Show("Process is killed successfully");
                using (StreamWriter w = File.AppendText(@"E:\ProcLog.txt"))
                {
                    Log("Process Name:" + strProcessName,w);
                    Log("Process is killed successfully", w);

                    // Close the writer and underlying file.
                    w.Close();
                }

                LoadProcesses();
            }
            else
            {
                MessageBox.Show("Process cannot be Killed");
                using (StreamWriter w = File.AppendText(@"E:\ProcLog.txt"))
                {
                    Log("Process cannot be Killed", w);
                    Log("Process Name:" + strProcessName,w);
                    // Close the writer and underlying file.
                    w.Close();
                }
            }
		}
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
            // Update the underlying file.
            w.Flush();
        }



	}
}
