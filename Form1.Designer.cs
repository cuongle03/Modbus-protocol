
namespace IOT_BT1B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button3 = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            label4 = new Label();
            label3 = new Label();
            groupBox6 = new GroupBox();
            button12 = new Button();
            button11 = new Button();
            groupBox5 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            groupBox4 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox3 = new ComboBox();
            groupBox7 = new GroupBox();
            button14 = new Button();
            groupBox9 = new GroupBox();
            label17 = new Label();
            label16 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            label11 = new Label();
            groupBox8 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button13 = new Button();
            button15 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(29, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sends";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(23, 142);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 99);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(29, 339);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 152);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reciveds";
            // 
            // button4
            // 
            button4.Location = new Point(27, 123);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Read";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(203, 84);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "9600", "14400" });
            comboBox2.Location = new Point(331, 50);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Com ports";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 12);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Baud rates";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(791, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(110, 23);
            progressBar1.TabIndex = 6;
            progressBar1.Click += progressBar1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(553, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(671, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(12, 497);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(524, 246);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "show and controler";
            // 
            // button6
            // 
            button6.Location = new Point(186, 44);
            button6.Name = "button6";
            button6.Size = new Size(75, 40);
            button6.TabIndex = 11;
            button6.Text = "Led_stop";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(44, 44);
            button5.Name = "button5";
            button5.Size = new Size(75, 40);
            button5.TabIndex = 10;
            button5.Text = "Led_run";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 26);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "Stop";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 26);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "Run";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.Info;
            groupBox6.Controls.Add(button12);
            groupBox6.Controls.Add(button11);
            groupBox6.Location = new Point(369, 103);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(151, 104);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "K3";
            // 
            // button12
            // 
            button12.Location = new Point(78, 53);
            button12.Name = "button12";
            button12.Size = new Size(66, 30);
            button12.TabIndex = 5;
            button12.Text = "OFF";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(6, 53);
            button11.Name = "button11";
            button11.Size = new Size(66, 30);
            button11.TabIndex = 4;
            button11.Text = "ON";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Info;
            groupBox5.Controls.Add(button10);
            groupBox5.Controls.Add(button9);
            groupBox5.Location = new Point(186, 103);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(148, 104);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "K2";
            // 
            // button10
            // 
            button10.Location = new Point(70, 53);
            button10.Name = "button10";
            button10.Size = new Size(66, 30);
            button10.TabIndex = 3;
            button10.Text = "OFF";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(6, 53);
            button9.Name = "button9";
            button9.Size = new Size(58, 30);
            button9.TabIndex = 2;
            button9.Text = "ON";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Info;
            groupBox4.Controls.Add(button8);
            groupBox4.Controls.Add(button7);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(0, 103);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(145, 104);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "K1";
            // 
            // button8
            // 
            button8.Location = new Point(70, 53);
            button8.Name = "button8";
            button8.Size = new Size(58, 30);
            button8.TabIndex = 1;
            button8.Text = "OFF";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 53);
            button7.Name = "button7";
            button7.Size = new Size(58, 30);
            button7.TabIndex = 0;
            button7.Text = "ON";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1500;
            timer1.Tick += timer1_Tick;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "03 Read", "16 Wirite" });
            comboBox3.Location = new Point(92, 67);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(149, 23);
            comboBox3.TabIndex = 10;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(button14);
            groupBox7.Controls.Add(groupBox9);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(textBox6);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(comboBox3);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(textBox5);
            groupBox7.Controls.Add(textBox3);
            groupBox7.Controls.Add(textBox4);
            groupBox7.Location = new Point(542, 50);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(713, 693);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "Modbus RTU";
            // 
            // button14
            // 
            button14.BackColor = Color.Gold;
            button14.Location = new Point(282, 13);
            button14.Name = "button14";
            button14.Size = new Size(104, 54);
            button14.TabIndex = 10;
            button14.Text = "connect RTU";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = SystemColors.Info;
            groupBox9.Controls.Add(label17);
            groupBox9.Controls.Add(label16);
            groupBox9.Controls.Add(textBox12);
            groupBox9.Controls.Add(textBox11);
            groupBox9.Location = new Point(436, 232);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(277, 175);
            groupBox9.TabIndex = 21;
            groupBox9.TabStop = false;
            groupBox9.Text = "FC10 Write";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(13, 31);
            label17.Name = "label17";
            label17.Size = new Size(82, 15);
            label17.TabIndex = 33;
            label17.Text = "Register name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(193, 33);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 32;
            label16.Text = "Data";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(111, 79);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(160, 49);
            textBox12.TabIndex = 28;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(13, 79);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(72, 49);
            textBox11.TabIndex = 27;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(422, 67);
            label11.Name = "label11";
            label11.Size = new Size(125, 15);
            label11.TabIndex = 20;
            label11.Text = "Resquest and Respone";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = SystemColors.ActiveCaption;
            groupBox8.Controls.Add(label10);
            groupBox8.Controls.Add(label9);
            groupBox8.Controls.Add(textBox7);
            groupBox8.Location = new Point(24, 224);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(389, 445);
            groupBox8.TabIndex = 19;
            groupBox8.TabStop = false;
            groupBox8.Text = "FC03 Read";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(317, 19);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 20;
            label10.Text = "Data";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 19);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 19;
            label9.Text = "Reg";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(211, 41);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(164, 368);
            textBox7.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 132);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(422, 99);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 98);
            textBox6.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 31);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 13;
            label6.Text = "Slave id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 75);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 12;
            label5.Text = "Function";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 182);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 15;
            label8.Text = "Qualiti";
            label8.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(92, 168);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 29);
            textBox5.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 29);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(92, 113);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 29);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button13
            // 
            button13.BackColor = Color.IndianRed;
            button13.Location = new Point(381, 97);
            button13.Name = "button13";
            button13.Size = new Size(140, 71);
            button13.TabIndex = 12;
            button13.Text = "Enable timer1";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.YellowGreen;
            button15.Location = new Point(82, 97);
            button15.Name = "button15";
            button15.Size = new Size(119, 54);
            button15.TabIndex = 22;
            button15.Text = "enable controller";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 755);
            Controls.Add(button15);
            Controls.Add(groupBox7);
            Controls.Add(groupBox3);
            Controls.Add(button13);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Controler";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // Kiểm tra nếu cổng COM đã mở
            {
                try
                {
                    string dataToSend = textBox1.Text.Trim(); // Lấy dữ liệu từ textbox1

                    if (!string.IsNullOrWhiteSpace(dataToSend)) // Kiểm tra nếu không rỗng
                    {
                        serialPort1.WriteLine(dataToSend); // Gửi dữ liệu
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gửi dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label4;
        private Button button6;
        private Button button5;
        private ComboBox comboBox3;
        private GroupBox groupBox7;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox6;
        private Button button13;
        private TextBox textBox7;
        private Label label11;
        private GroupBox groupBox8;
        private Label label10;
        private Label label9;
        private GroupBox groupBox9;
        private Label label17;
        private Label label16;
        private TextBox textBox12;
        private TextBox textBox11;
        private Button button14;
        private Button button15;
    }
}
