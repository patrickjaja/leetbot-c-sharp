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
using System.Collections;

namespace LeetBot 
{
	class MainForm : System.Windows.Forms.Form
    {
	public MainForm()
	{
		InitializeComponent();
    }
    #region Designer
    // THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
	// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
    // http://forums.microsoft.com/MSDN/ShowPost.aspx?PostID=2013305&SiteID=1
	void InitializeComponent() {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.radioButton9 = new System.Windows.Forms.RadioButton();
        this.radioButton8 = new System.Windows.Forms.RadioButton();
        this.radioButton7 = new System.Windows.Forms.RadioButton();
        this.radioButton6 = new System.Windows.Forms.RadioButton();
        this.radioButton5 = new System.Windows.Forms.RadioButton();
        this.radioButton4 = new System.Windows.Forms.RadioButton();
        this.radioButton3 = new System.Windows.Forms.RadioButton();
        this.radioButton2 = new System.Windows.Forms.RadioButton();
        this.radioButton1 = new System.Windows.Forms.RadioButton();
        this.label2 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.imageList1 = new System.Windows.Forms.ImageList(this.components);
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(-1, 4);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(56, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Tool is off.";
        // 
        // groupBox1
        // 
        this.groupBox1.BackColor = System.Drawing.Color.Transparent;
        this.groupBox1.Controls.Add(this.radioButton9);
        this.groupBox1.Controls.Add(this.radioButton8);
        this.groupBox1.Controls.Add(this.radioButton7);
        this.groupBox1.Controls.Add(this.radioButton6);
        this.groupBox1.Controls.Add(this.radioButton5);
        this.groupBox1.Controls.Add(this.radioButton4);
        this.groupBox1.Controls.Add(this.radioButton3);
        this.groupBox1.Controls.Add(this.radioButton2);
        this.groupBox1.Controls.Add(this.radioButton1);
        this.groupBox1.Location = new System.Drawing.Point(2, 20);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(327, 62);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Simple Configuration - Select the mode";
        // 
        // radioButton9
        // 
        this.radioButton9.AutoSize = true;
        this.radioButton9.BackColor = System.Drawing.Color.Transparent;
        this.radioButton9.Location = new System.Drawing.Point(267, 19);
        this.radioButton9.Name = "radioButton9";
        this.radioButton9.Size = new System.Drawing.Size(60, 17);
        this.radioButton9.TabIndex = 6;
        this.radioButton9.TabStop = true;
        this.radioButton9.Text = "Level 9";
        this.radioButton9.UseVisualStyleBackColor = false;
        this.radioButton9.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton8
        // 
        this.radioButton8.AutoSize = true;
        this.radioButton8.Location = new System.Drawing.Point(201, 40);
        this.radioButton8.Name = "radioButton8";
        this.radioButton8.Size = new System.Drawing.Size(60, 17);
        this.radioButton8.TabIndex = 7;
        this.radioButton8.TabStop = true;
        this.radioButton8.Text = "Level 8";
        this.radioButton8.UseVisualStyleBackColor = true;
        this.radioButton8.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton7
        // 
        this.radioButton7.AutoSize = true;
        this.radioButton7.Location = new System.Drawing.Point(201, 17);
        this.radioButton7.Name = "radioButton7";
        this.radioButton7.Size = new System.Drawing.Size(60, 17);
        this.radioButton7.TabIndex = 6;
        this.radioButton7.TabStop = true;
        this.radioButton7.Text = "Level 7";
        this.radioButton7.UseVisualStyleBackColor = true;
        this.radioButton7.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton6
        // 
        this.radioButton6.AutoSize = true;
        this.radioButton6.Location = new System.Drawing.Point(135, 40);
        this.radioButton6.Name = "radioButton6";
        this.radioButton6.Size = new System.Drawing.Size(60, 17);
        this.radioButton6.TabIndex = 5;
        this.radioButton6.TabStop = true;
        this.radioButton6.Text = "Level 6";
        this.radioButton6.UseVisualStyleBackColor = true;
        this.radioButton6.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton5
        // 
        this.radioButton5.AutoSize = true;
        this.radioButton5.Location = new System.Drawing.Point(135, 17);
        this.radioButton5.Name = "radioButton5";
        this.radioButton5.Size = new System.Drawing.Size(60, 17);
        this.radioButton5.TabIndex = 4;
        this.radioButton5.TabStop = true;
        this.radioButton5.Text = "Level 5";
        this.radioButton5.UseVisualStyleBackColor = true;
        this.radioButton5.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton4
        // 
        this.radioButton4.AutoSize = true;
        this.radioButton4.Location = new System.Drawing.Point(76, 39);
        this.radioButton4.Name = "radioButton4";
        this.radioButton4.Size = new System.Drawing.Size(60, 17);
        this.radioButton4.TabIndex = 3;
        this.radioButton4.TabStop = true;
        this.radioButton4.Text = "Level 4";
        this.radioButton4.UseVisualStyleBackColor = true;
        this.radioButton4.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton3
        // 
        this.radioButton3.AutoSize = true;
        this.radioButton3.Location = new System.Drawing.Point(10, 37);
        this.radioButton3.Name = "radioButton3";
        this.radioButton3.Size = new System.Drawing.Size(60, 17);
        this.radioButton3.TabIndex = 2;
        this.radioButton3.TabStop = true;
        this.radioButton3.Text = "Level 2";
        this.radioButton3.UseVisualStyleBackColor = true;
        this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton2
        // 
        this.radioButton2.AutoSize = true;
        this.radioButton2.Location = new System.Drawing.Point(76, 17);
        this.radioButton2.Name = "radioButton2";
        this.radioButton2.Size = new System.Drawing.Size(60, 17);
        this.radioButton2.TabIndex = 1;
        this.radioButton2.TabStop = true;
        this.radioButton2.Text = "Level 3";
        this.radioButton2.UseVisualStyleBackColor = true;
        this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // radioButton1
        // 
        this.radioButton1.AutoSize = true;
        this.radioButton1.Location = new System.Drawing.Point(10, 17);
        this.radioButton1.Name = "radioButton1";
        this.radioButton1.Size = new System.Drawing.Size(60, 17);
        this.radioButton1.TabIndex = 0;
        this.radioButton1.TabStop = true;
        this.radioButton1.Text = "Level 1";
        this.radioButton1.UseVisualStyleBackColor = true;
        this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(316, 4);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(13, 13);
        this.label2.TabIndex = 2;
        this.label2.Text = "?";
        this.label2.Click += new System.EventHandler(this.msgBox);
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(170, 57);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(159, 122);
        this.pictureBox1.TabIndex = 3;
        this.pictureBox1.TabStop = false;
        // 
        // imageList1
        // 
        this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
        this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
        this.imageList1.Images.SetKeyName(0, "imgsmall.gif");
        this.imageList1.Images.SetKeyName(1, "img.gif");
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(7, 163);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(42, 9);
        this.label3.TabIndex = 4;
        this.label3.Text = "by SuiZiD-";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(106, 4);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(97, 13);
        this.label4.TabIndex = 5;
        this.label4.Text = "F8 = off      F9 = on";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(9, 85);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(83, 13);
        this.label5.TabIndex = 6;
        this.label5.Text = "Don\'t use CAPS";
        // 
        // MainForm
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.ClientSize = new System.Drawing.Size(334, 174);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.pictureBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.Name = "MainForm";
        this.Text = "L33t B0T - 0FF";
        this.Load += new System.EventHandler(this.MainFormLoad);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

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

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private IContainer components;
        private Label label3;
        private Label label4;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton6;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Label label5;



		
		UserActivityHook actHook;
		void MainFormLoad(object sender, System.EventArgs e)
		{
           actHook = new UserActivityHook(); // crate an instance with global hooks
			// hang on events
			//actHook.OnMouseActivity+=new MouseEventHandler(MouseMoved);
			actHook.KeyDown+=new KeyEventHandler(MyKeyDown);
			//actHook.KeyPress+=new KeyPressEventHandler(MyKeyPress);
			//actHook.KeyUp+=new KeyEventHandler(MyKeyUp);
            //MessageBox.Show(level7[1][0].ToString());
		}

        bool isOn = false;
        string leetMode = string.Empty;

        string [] alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        string [] level1   = {"4", "b", "c", "d", "3", "f", "g", "h", "i", "j", "k", "1", "m", "n", "0", "p", "9", "r", "s", "7", "u", "v", "w", "x", "y", "z"};
        string [] level2   = {"4", "b", "c", "d", "3", "f", "g", "h", "1", "j", "k", "1", "m", "n", "0", "p", "9", "r", "5", "7", "u", "v", "w", "x", "y", "2"};
        string [] level3   = {"4", "8", "c", "d", "3", "f", "6", "h", "'", "j", "k", "1", "m", "n", "0", "p", "9", "r", "5", "7", "u", "v", "w", "x", "'/", "2"};
        string [] level4   = {"@", "8", "c", "d", "3", "f", "6", "h", "'", "j", "k", "1", "m", "n", "0", "p", "9", "r", "5", "7", "u", "v", "w", "x", "'/", "2"};
        string [] level5   = {"@", "|3", "c", "d", "3", "f", "6", "#", "!", "7", "|<", "1", "m", "n", "0", "|>", "9", "|2", "$", "7", "u", "\\/", "w", "x", "'/", "2"};
        string [] level6   = {"@", "|3", "c", "|)", "&", "|=", "6", "#", "!", ",|", "|<", "1", "m", "n", "0", "|>", "9", "|2", "$", "7", "u", "\\/", "w", "x", "'/", "2"};
        string [] level7   = {"@", "|3", "[", "|)", "&", "|=", "6", "#", "!", ",|", "|<", "1", "^^", "^/", "0", "|*", "9", "|2", "5", "7", "(_)", "\\/", "\\/\\/", "><", "'/", "2"};
        string [] level8   = {"@", "8", "(", "|)", "&", "|=", "6", "|-|", "!", "_|", "|\\(", "1", "|\\/|", "|\\|", "()", "|>", "(,)", "|2", "$", "|", "|_|", "\\/", "\\^/", ")(", "'/", "\"/_"};
        string [] level9   = {"@", "8", "(", "|)", "&", "|=", "6", "|-|", "!", "_|", "|\\}{", "|_", "/\\/\\", "|\\|", "()", "|>", "(,)", "|2", "$", "|", "|_|", "\\/", "\\^/", ")(", "'/", "\"/_"};
        //Array [] levelss = {level1[], level2, level3, level4, level5, level6, level7, level8, level9};
        
        
        
        

		public void MyKeyDown(object sender, KeyEventArgs e)
		{
          int charPosition = 0;
          string typedKey;
          //typedKey = e.KeyCode.ToString( );
          typedKey = e.KeyData.ToString();
          //MessageBox.Show(e.KeyData.ToString());
          

          if (isOn == true)
          {
              switch(leetMode)
              {
                  case "Level 1":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level1[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level1[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 2":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level2[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level2[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 3":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level3[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level3[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 4":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level4[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level4[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 5":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level5[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level5[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 6":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level6[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level6[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 7":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level7[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level7[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 8":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level8[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level8[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  case "Level 9":
                      foreach (string str in alphabet)
                      {
                          if (str == typedKey.ToLower())
                          {
                              e.Handled = true;
                              for (int i = 0; i < level9[charPosition].Length; i++)
                              {
                                  SendKeys.Send("{" + level9[charPosition][i] + "}");
                              }
                          }
                          charPosition++;
                      }
                      break;
                  default:
                      break;
              }


              /*
              if (e.KeyCode == Keys.E)
              {
                  e.Handled = true;
                  //SendKeys.Send("{BKSP}");
                  SendKeys.Send("{3}");
              }
              if (e.KeyCode == Keys.A)
              {
                  e.Handled = true;
                  //SendKeys.Send("{BKSP}");
                  SendKeys.Send("{4}");
              }
               * */
              /*
            if (e.KeyCode == Keys.O)
            {
                e.Handled = true;
                //SendKeys.Send("{BKSP}");
                SendKeys.Send("{0}");
            }
               * */
              /*
              if (e.KeyCode == Keys.I)
              {
                  e.Handled = true;
                  //SendKeys.Send("{BKSP}");
                  SendKeys.Send("{1}");
              }
               * */
          }

          switch (e.KeyCode)
          {
              case Keys.F8:
                  isOn = false;
                  label1.Text = "Tool is off.";
                  this.Text = "L33t B0T - 0FF";
                  break;
              case Keys.F9:
                  isOn = true;
                  label1.Text = "Tool is on.";
                  this.Text = "L33t B0T - 0N";
                  break;
              default:
                  break;
          }
		}
        public void radioClick(object sender)
        {
            if (sender.GetType() == typeof(RadioButton))
            {
                RadioButton rbn = (RadioButton)sender;
                leetMode = rbn.Text;
            }
        }
		public void MyKeyPress(object sender, KeyPressEventArgs e)
		{  
 
		}
		
		public void MyKeyUp(object sender, KeyEventArgs e)
		{

		}

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioClick(sender);
        }

        private void msgBox(object sender, EventArgs e)
        {
            MessageBox.Show("Help: ");
            MessageBox.Show("1337 5p34k 157 31n3 1n73rn375pr4ch3 und w1rd v0r 4113m v0n ch4773rn, h4ck3rn, g4m3rn und j3d3m d3r d3nk7 d4durch 37w45 b350nd3r3r5 zu 531n. 1337 5p34k g1b75 nur g35chr13b3n.");
        }
    }
}	
