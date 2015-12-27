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
using System.Threading;
namespace GlobalHookDemo 
{
	class MainForm : System.Windows.Forms.Form
    {
    private System.Windows.Forms.Button buttonStop;
    private Button buttonStart;
    string key;
    string ip;
    string fname2;
    int i = 0;
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
    private ComboBox comboBox4;
    private Label label11;
    private Label label12;
    private TextBox textBox1;
    private Button button2;
    private Button button3;
    private TextBox textBox2;
    private Label label13;
    private TextBox textBox3;
    private Label label14;
    private Button button4;
    string tasten;

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
      this.comboBox4 = new System.Windows.Forms.ComboBox( );
      this.label11 = new System.Windows.Forms.Label( );
      this.label12 = new System.Windows.Forms.Label( );
      this.textBox1 = new System.Windows.Forms.TextBox( );
      this.button2 = new System.Windows.Forms.Button( );
      this.button3 = new System.Windows.Forms.Button( );
      this.textBox2 = new System.Windows.Forms.TextBox( );
      this.label13 = new System.Windows.Forms.Label( );
      this.textBox3 = new System.Windows.Forms.TextBox( );
      this.label14 = new System.Windows.Forms.Label( );
      this.button4 = new System.Windows.Forms.Button( );
      this.SuspendLayout( );
      // 
      // buttonStop
      // 
      this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonStop.Location = new System.Drawing.Point( 93, 23 );
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size( 75, 23 );
      this.buttonStop.TabIndex = 1;
      this.buttonStop.Text = "Stop";
      this.buttonStop.Click += new System.EventHandler( this.ButtonStopClick );
      // 
      // buttonStart
      // 
      this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonStart.Location = new System.Drawing.Point( 14, 23 );
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size( 75, 23 );
      this.buttonStart.TabIndex = 0;
      this.buttonStart.Text = "Start";
      this.buttonStart.Click += new System.EventHandler( this.ButtonStartClick );
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label1.Location = new System.Drawing.Point( 48, 177 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 55, 13 );
      this.label1.TabIndex = 2;
      this.label1.Text = "Language";
      // 
      // comboBox1
      // 
      this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange( new object[] {
            "English",
            "Deutsch"} );
      this.comboBox1.Location = new System.Drawing.Point( 49, 194 );
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size( 210, 21 );
      this.comboBox1.TabIndex = 3;
      this.comboBox1.Text = "English";
      this.comboBox1.SelectedIndexChanged += new System.EventHandler( this.comboBox1_SelectedIndexChanged );
      this.comboBox1.TextChanged += new System.EventHandler( this.comboBox1_TextChanged );
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label2.Location = new System.Drawing.Point( 16, 3 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 48, 16 );
      this.label2.TabIndex = 4;
      this.label2.Text = "UniBot";
      // 
      // comboBox2
      // 
      this.comboBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange( new object[] {
            "800*600",
            "1024*768",
            "1280*1024"} );
      this.comboBox2.Location = new System.Drawing.Point( 49, 111 );
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size( 211, 21 );
      this.comboBox2.TabIndex = 5;
      this.comboBox2.Text = "800*600";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label3.Location = new System.Drawing.Point( 45, 94 );
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size( 57, 13 );
      this.label3.TabIndex = 6;
      this.label3.Text = "Resolution";
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.SystemColors.ControlText;
      this.label4.Location = new System.Drawing.Point( 14, 54 );
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size( 300, 2 );
      this.label4.TabIndex = 7;
      this.label4.Text = "label4";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label5.Location = new System.Drawing.Point( 110, 69 );
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size( 86, 16 );
      this.label5.TabIndex = 8;
      this.label5.Text = "Configuration";
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.SystemColors.ControlText;
      this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label6.Location = new System.Drawing.Point( 60, 86 );
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size( 200, 2 );
      this.label6.TabIndex = 9;
      this.label6.Text = "label6";
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.SystemColors.ControlText;
      this.label7.Location = new System.Drawing.Point( 14, 54 );
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size( 2, 300 );
      this.label7.TabIndex = 10;
      this.label7.Text = "label7";
      // 
      // label8
      // 
      this.label8.BackColor = System.Drawing.SystemColors.ControlText;
      this.label8.Location = new System.Drawing.Point( 312, 54 );
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size( 2, 300 );
      this.label8.TabIndex = 11;
      this.label8.Text = "label8";
      // 
      // label9
      // 
      this.label9.BackColor = System.Drawing.SystemColors.ControlText;
      this.label9.Location = new System.Drawing.Point( 14, 352 );
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size( 300, 2 );
      this.label9.TabIndex = 12;
      this.label9.Text = "label9";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label10.Location = new System.Drawing.Point( 45, 134 );
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size( 34, 13 );
      this.label10.TabIndex = 13;
      this.label10.Text = "Mode";
      // 
      // comboBox3
      // 
      this.comboBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Items.AddRange( new object[] {
            "Solo / FFA / RT",
            "AT_Invite",
            "AT_Accept",
            "feed Position 1",
            "feed Position 2",
            "feed Position 3",
            "feed Position 4",
            "feed Position 5",
            "feed Position 6"} );
      this.comboBox3.Location = new System.Drawing.Point( 48, 151 );
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new System.Drawing.Size( 212, 21 );
      this.comboBox3.TabIndex = 14;
      this.comboBox3.Text = "Solo / FFA / RT";
      // 
      // button1
      // 
      this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.button1.Location = new System.Drawing.Point( 48, 306 );
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size( 75, 23 );
      this.button1.TabIndex = 15;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler( this.button1_Click );
      // 
      // comboBox4
      // 
      this.comboBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Items.AddRange( new object[] {
            "Large",
            "Small"} );
      this.comboBox4.Location = new System.Drawing.Point( 173, 24 );
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new System.Drawing.Size( 141, 21 );
      this.comboBox4.TabIndex = 16;
      this.comboBox4.Text = "Large";
      this.comboBox4.SelectedIndexChanged += new System.EventHandler( this.comboBox4_SelectedIndexChanged );
      this.comboBox4.TextChanged += new System.EventHandler( this.comboBox4_TextChanged );
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label11.Location = new System.Drawing.Point( 172, 4 );
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size( 77, 16 );
      this.label11.TabIndex = 17;
      this.label11.Text = "Form Mode";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label12.Location = new System.Drawing.Point( 48, 218 );
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size( 82, 13 );
      this.label12.TabIndex = 19;
      this.label12.Text = "Warcraft 3 Path";
      // 
      // textBox1
      // 
      this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.textBox1.Location = new System.Drawing.Point( 49, 235 );
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size( 147, 20 );
      this.textBox1.TabIndex = 20;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.button2.Location = new System.Drawing.Point( 203, 233 );
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size( 58, 23 );
      this.button2.TabIndex = 21;
      this.button2.Text = "Browse";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler( this.button2_Click );
      // 
      // button3
      // 
      this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.button3.Location = new System.Drawing.Point( 186, 306 );
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size( 75, 23 );
      this.button3.TabIndex = 22;
      this.button3.Text = "Close";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler( this.button3_Click );
      // 
      // textBox2
      // 
      this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.textBox2.Location = new System.Drawing.Point( 49, 277 );
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size( 95, 20 );
      this.textBox2.TabIndex = 23;
      this.textBox2.Text = "F8";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label13.Location = new System.Drawing.Point( 48, 260 );
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size( 50, 13 );
      this.label13.TabIndex = 24;
      this.label13.Text = "Start Key";
      // 
      // textBox3
      // 
      this.textBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.textBox3.Location = new System.Drawing.Point( 170, 277 );
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size( 90, 20 );
      this.textBox3.TabIndex = 25;
      this.textBox3.Text = "F9";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.label14.Location = new System.Drawing.Point( 209, 260 );
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size( 50, 13 );
      this.label14.TabIndex = 26;
      this.label14.Text = "Stop Key";
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
      this.button4.Location = new System.Drawing.Point( 282, 3 );
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size( 32, 16 );
      this.button4.TabIndex = 27;
      this.button4.Text = "Save";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Visible = false;
      this.button4.Click += new System.EventHandler( this.button4_Click );
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
      this.ClientSize = new System.Drawing.Size( 334, 369 );
      this.Controls.Add( this.button4 );
      this.Controls.Add( this.label14 );
      this.Controls.Add( this.textBox3 );
      this.Controls.Add( this.label13 );
      this.Controls.Add( this.textBox2 );
      this.Controls.Add( this.button3 );
      this.Controls.Add( this.button2 );
      this.Controls.Add( this.textBox1 );
      this.Controls.Add( this.label12 );
      this.Controls.Add( this.label11 );
      this.Controls.Add( this.comboBox4 );
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
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "MainForm";
      this.Text = "Universal Bot";
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
			//MyKeyPress();
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
      try
      {
        StreamReader sr = new StreamReader( "config.txt" );
        string ersteZ = sr.ReadLine( );
          string Zeile1 = sr.ReadLine( );
          string Zeile2 = sr.ReadLine( );
          string Zeile3 = sr.ReadLine( );
          string Zeile4 = sr.ReadLine( );
          string Zeile5 = sr.ReadLine( );
          string Zeile6 = sr.ReadLine( );
          string Zeile7 = sr.ReadLine( );
          comboBox1.Text = Zeile1;
          comboBox2.Text = Zeile2;
          comboBox3.Text = Zeile3;
          comboBox4.Text = Zeile4;
          textBox1.Text = Zeile5;
          textBox2.Text = Zeile6;
          textBox3.Text = Zeile7;
      }
      catch{
        MessageBox.Show("Configure your Bot.");
      }

		}

		public void MouseMoved(object sender, MouseEventArgs e)
		{
	  	//	labelMousePosition.Text=String.Format("x={0}  y={1} wheel={2}", e.X, e.Y, e.Delta);
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
      key = e.KeyData.ToString ( );
      if ( key == textBox2.Text )
      {
       for ( int b = 0; b < 10; b++ )
        {
          if ( key == textBox3.Text )
          {
            break;
          }
          Point initialCursorPosition = Cursor.Position;
          initialCursorPosition.X = 10;
          initialCursorPosition.Y = 760;
          Cursor.Position = initialCursorPosition;
         // LeftMouseClick( Cursor.Position );

          initialCursorPosition.X = 100;
          initialCursorPosition.Y = 720;
          Cursor.Position = initialCursorPosition;
          //LeftMouseClick( Cursor.Position );

          initialCursorPosition.X = 250;
          initialCursorPosition.Y = 450;
          Cursor.Position = initialCursorPosition;
          //LeftMouseClick( Cursor.Position );

            /*initialCursorPosition.X = 100;
            initialCursorPosition.Y = 100;
            Cursor.Position = initialCursorPosition;
            // LeftMouseClick( Cursor.Position );

            initialCursorPosition.X = 50;
            initialCursorPosition.Y = 50;
            Cursor.Position = initialCursorPosition;
            //LeftMouseClick( Cursor.Position );*/
          
        }
      }
			//LogWrite("KeyDown 	- " + e.KeyData.ToString());
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


            /*if ( key == "#" )
            {
                tasten = "";
            }

            if ( tasten.Length == 50 )
            {
              tasten = "";
            }*/

            /*if (key == "1")
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

         /*   String strHostName;
            strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            ip = ipaddress.ToString();
            StreamWriter sw = new StreamWriter(strHostName+"_"+ip+".txt", true);
            sw.Write(key);
            sw.Close();*/
			/*textBox.AppendText(txt + Environment.NewLine);
			textBox.SelectionStart = textBox.Text.Length;*/
		}

    private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
    {

    }

    private void button2_Click( object sender, EventArgs e )
    {
      OpenFileDialog openDialog = new OpenFileDialog( );
      openDialog.Filter = "war3.exe|*.exe";
      if ( openDialog.ShowDialog( ) == DialogResult.OK )
      {
        fname2 = openDialog.FileName;
        textBox1.Text = fname2;
      }
    }

    private void button3_Click( object sender, EventArgs e )
    {
      this.Close( );
    }

    private void comboBox1_TextChanged( object sender, EventArgs e )
    {
      string sprache = comboBox1.Text.ToString( );
      if ( sprache == "Deutsch" )
      {
        label1.Text = "Sprache";
        label5.Text = "Konfiguration";
        label3.Text = "Auflösung";
        label10.Text = "Modus";
        label11.Text = "Formular Modus";
        label12.Text = "Warcraft 3 Pfad";
        button2.Text = "Durchs.";
        label13.Text = "Start Taste";
        label14.Text = "Stop Taste";
        button1.Text = "Speichern";
        button3.Text = "Schließen";
      }

      if ( sprache == "English" )
      {
        label1.Text = "Language";
        label5.Text = "Configuration";
        label3.Text = "Resolution";
        label10.Text = "Mode";
        label11.Text = "Form Mode";
        label12.Text = "Warcraft 3 Path";
        button2.Text = "Browse";
        label13.Text = "Start Key";
        label14.Text = "Stop Key";
        button1.Text = "Save";
        button3.Text = "Close";
      }
    }

    private void button1_Click( object sender, EventArgs e )
    {
      try
      {
        StreamWriter sw = new StreamWriter( "config.txt" );
        sw.Write( "[Config] " + Environment.NewLine );
        sw.Write( comboBox1.Text + Environment.NewLine );
        sw.Write( comboBox2.Text + Environment.NewLine );
        sw.Write( comboBox3.Text + Environment.NewLine );
        sw.Write( comboBox4.Text + Environment.NewLine );
        sw.Write( textBox1.Text + Environment.NewLine );
        sw.Write( textBox2.Text + Environment.NewLine );
        sw.Write( textBox3.Text + Environment.NewLine );
        sw.Close( );
      }
      catch
      {
        MessageBox.Show( "Configure the Bot." );
      }
    }

    private void comboBox4_TextChanged( object sender, EventArgs e )
    {
      if ( comboBox4.Text == "Small" )
      {
        this.Height = 80;
        button4.Visible = true;
      }
      if ( comboBox4.Text == "Large" )
      {
        this.Height = 395;
        button4.Visible = false;
      }
    }

    private void comboBox4_SelectedIndexChanged( object sender, EventArgs e )
    {

    }

    private void button4_Click( object sender, EventArgs e )
    {
      StreamWriter sw = new StreamWriter( "config.txt" );
      sw.Write( "[Config] " + Environment.NewLine );
      sw.Write( comboBox1.Text + Environment.NewLine );
      sw.Write( comboBox2.Text + Environment.NewLine );
      sw.Write( comboBox3.Text + Environment.NewLine );
      sw.Write( comboBox4.Text + Environment.NewLine );
      sw.Write( textBox1.Text + Environment.NewLine );
      sw.Write( textBox2.Text + Environment.NewLine );
      sw.Write( textBox3.Text + Environment.NewLine );
      sw.Close( );
    }

	}			
}
