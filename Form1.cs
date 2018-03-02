using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using cc;

namespace SerialCreate
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "生成序列号";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 21);
            this.textBox3.TabIndex = 7;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 21);
            this.textBox4.TabIndex = 8;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 21);
            this.textBox5.TabIndex = 9;
            this.textBox5.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 8);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(88, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 8);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(136, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(8, 8);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(184, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(8, 8);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "昆明明华澳汉科技有限公司              2007年";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(0, 88);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(531, 21);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(531, 21);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(531, 21);
            this.textBox8.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(543, 167);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "注册码生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

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


		private void button4_Click(object sender, System.EventArgs e)
		{
			string str_SerialNumber;
			string str_nb1,str_nb2,str_nb3,str_nb4,str_nb5;
            string miWen1=textBox8.Text;
			if (textBox8.Text.Trim()=="")
			{
				MessageBox.Show("机器码不能为空");
				return;
			}
			DESEncryptor dese2=new DESEncryptor();
			dese2.InputString=miWen1;
			dese2.DecryptKey="lhgynkm0";
			dese2.DesDecrypt();
			string mingWen1=dese2.OutString;
			WL(mingWen1);
			dese2=null;

          	str_SerialNumber=mingWen1;
			str_nb1=str_SerialNumber.Substring(2,1);
			str_nb2=str_SerialNumber.Substring(3,1);
			str_nb3=str_SerialNumber.Substring(4,1);
			str_nb4=str_SerialNumber.Substring(5,1);
			str_nb5=str_SerialNumber.Substring(6,1);
			label1.Text=mingWen1;

			int num;
			System.Random random;
			System.Collections.ArrayList array;

			random= new Random();
			array=new System.Collections.ArrayList();
 
			//保存第一个数到 array 对象
			array.Add((int)random.Next(1000,9999));
 
			int i,j,m=1; 
			int n=0;
			string str0=null,str1;
			//循环取6不重复的数字
			while(m<6)
			{
				n=n+1;
				num=random.Next(1000,9999);
 
				//判断是否已经存在
				for(j=0;j<array.Count;j++)
				{
					//如果数列中的数字比随机数大，则该随机数为新数，插入到大数的前面
					if (num<(int)array[j])
					{
						array.Insert(j,num);
						m++;
					}
					//相等，则说明存在，跳出循环重新取数
					if(num==(int)array[j])
						break;
     
				}
				string str_num=num.ToString();
				if (n==1)
				{
					textBox1.Text=str_nb5 + num.ToString();
					str1=str_nb5 + num.ToString();
					str0=str0+str1;
				}
				if (n==2)
				{
					string str_num20,str_num21;
					str_num20=str_num.Substring(0,1);
					str_num21=str_num.Substring(1,3);
					textBox2.Text=str_num20 + str_nb4 + str_num21;
					str1=str_num20 + str_nb4 + str_num21;
					str0=str0+"-"+str1;
				}
				if (n==3)
				{
					string str_num30,str_num31;
					str_num30=str_num.Substring(0,2);
					str_num31=str_num.Substring(2,2);
					textBox3.Text=str_num30 + str_nb3 + str_num31;
					str1=str_num30 + str_nb3 + str_num31;
					str0=str0+"-"+str1;
				}
				if (n==4)
				{
					string str_num40,str_num41;
					str_num40=str_num.Substring(0,3);
					str_num41=str_num.Substring(3,1);
					textBox4.Text=str_num40 + str_nb2 + str_num41;
					str1=str_num40 + str_nb2 + str_num41;
					str0=str0+"-"+str1;
				}
				if (n==5)
				{
					textBox5.Text=num.ToString() + str_nb1;
					str1=num.ToString() + str_nb1;
					str0=str0+"-"+str1;
				}
				//加密
				DESEncryptor dese=new DESEncryptor();
                dese.InputString ="ynkm"+ mingWen1 + "dxkj";
				dese.EncryptKey="lhgynkm0";
				dese.DesEncrypt();
				string miWen=dese.OutString;
				WL(miWen);
				dese=null;
				textBox6.Text=miWen;
                //解密
				DESEncryptor dese1=new DESEncryptor();
				dese1.InputString=miWen;
				dese1.DecryptKey="lhgynkm0";
				dese1.DesDecrypt();
				string mingWen=dese1.OutString;
				WL(mingWen);
				dese1=null;
				textBox7.Text=mingWen;
				//所有的数都比随机数小……
				if(j==array.Count )
				{
					array.Add(num);
					m++; 
				}
			}
   
			for(i=0;i<6;i++)
			{
				Console.Write(array[i].ToString() + " ");
			}
			Console.Read();
 
		}


		private static void WL(object text, params object[] args)
		{
			Console.WriteLine(text.ToString(), args); 
		}
 
		private static void RL()
		{
			Console.ReadLine(); 
		}
 
		private static void Break() 
		{
			System.Diagnostics.Debugger.Break();
		}



	}
}
