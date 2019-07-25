namespace 開通生成器
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Slot_Box = new System.Windows.Forms.TextBox();
            this.Port_Box = new System.Windows.Forms.TextBox();
            this.OnuID_Box = new System.Windows.Forms.TextBox();
            this.SN_Box = new System.Windows.Forms.TextBox();
            this.Des_Box = new System.Windows.Forms.TextBox();
            this.UP_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IP_Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GW_Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Mode_Box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Svlan_Box = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Cvlan_Box = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Percen_Box = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Down_Box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "T100 (中正區)",
            "T103 (大同區)",
            "T104 (中山區)",
            "T105 (松山區)",
            "T106 (大安區)",
            "T108 (萬華區)",
            "T110 (信義區)",
            "T111 (士林區)",
            "T112 (北投區)",
            "T114 (內湖區)",
            "T115 (南港區)",
            "T116 (文山區)"});
            this.comboBox2.Location = new System.Drawing.Point(155, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(296, 30);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(153, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "行政區：";
            // 
            // Slot_Box
            // 
            this.Slot_Box.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Slot_Box.Location = new System.Drawing.Point(15, 73);
            this.Slot_Box.Name = "Slot_Box";
            this.Slot_Box.Size = new System.Drawing.Size(121, 22);
            this.Slot_Box.TabIndex = 4;
            this.Slot_Box.TextChanged += new System.EventHandler(this.Slot_Box_TextChanged);
            this.Slot_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Slot_Box_KeyPress);
            // 
            // Port_Box
            // 
            this.Port_Box.Location = new System.Drawing.Point(155, 73);
            this.Port_Box.Name = "Port_Box";
            this.Port_Box.Size = new System.Drawing.Size(121, 22);
            this.Port_Box.TabIndex = 5;
            this.Port_Box.TextChanged += new System.EventHandler(this.Port_Box_TextChanged);
            this.Port_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Port_Box_KeyPress);
            // 
            // OnuID_Box
            // 
            this.OnuID_Box.Location = new System.Drawing.Point(296, 73);
            this.OnuID_Box.Name = "OnuID_Box";
            this.OnuID_Box.Size = new System.Drawing.Size(121, 22);
            this.OnuID_Box.TabIndex = 6;
            this.OnuID_Box.TextChanged += new System.EventHandler(this.OnuID_Box_TextChanged);
            this.OnuID_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnuID_Box_KeyPress);
            // 
            // SN_Box
            // 
            this.SN_Box.Location = new System.Drawing.Point(15, 121);
            this.SN_Box.Name = "SN_Box";
            this.SN_Box.Size = new System.Drawing.Size(121, 22);
            this.SN_Box.TabIndex = 7;
            // 
            // Des_Box
            // 
            this.Des_Box.Location = new System.Drawing.Point(156, 121);
            this.Des_Box.Name = "Des_Box";
            this.Des_Box.Size = new System.Drawing.Size(121, 22);
            this.Des_Box.TabIndex = 8;
            // 
            // UP_Box
            // 
            this.UP_Box.Location = new System.Drawing.Point(296, 121);
            this.UP_Box.Name = "UP_Box";
            this.UP_Box.Size = new System.Drawing.Size(121, 22);
            this.UP_Box.TabIndex = 9;
            this.UP_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UP_Box_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(293, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "OLT：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Slot：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(152, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Port：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(296, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "OnuID：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "S/N：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(156, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Discription：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(293, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "UpStream：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 11.25F);
            this.button1.Location = new System.Drawing.Point(16, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 50;
            this.button1.Text = "產出 Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(13, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "固定IP：";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(16, 223);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 22);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(16, 251);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 22);
            this.textBox8.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(16, 279);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 22);
            this.textBox9.TabIndex = 27;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(16, 363);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(121, 22);
            this.textBox10.TabIndex = 30;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(16, 335);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(121, 22);
            this.textBox11.TabIndex = 29;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(16, 307);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(121, 22);
            this.textBox12.TabIndex = 28;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("新細明體-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(146, 223);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(576, 417);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(437, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Host2_IP/MASK：";
            // 
            // IP_Box
            // 
            this.IP_Box.Location = new System.Drawing.Point(437, 165);
            this.IP_Box.Name = "IP_Box";
            this.IP_Box.Size = new System.Drawing.Size(121, 22);
            this.IP_Box.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(561, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Host2_GW：";
            // 
            // GW_Box
            // 
            this.GW_Box.Location = new System.Drawing.Point(564, 165);
            this.GW_Box.Name = "GW_Box";
            this.GW_Box.Size = new System.Drawing.Size(121, 22);
            this.GW_Box.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(296, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Port Mode(幾n)：";
            // 
            // Mode_Box
            // 
            this.Mode_Box.Location = new System.Drawing.Point(296, 165);
            this.Mode_Box.Name = "Mode_Box";
            this.Mode_Box.Size = new System.Drawing.Size(121, 22);
            this.Mode_Box.TabIndex = 14;
            this.Mode_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mode_Box_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(13, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Svlan：";
            // 
            // Svlan_Box
            // 
            this.Svlan_Box.Location = new System.Drawing.Point(15, 165);
            this.Svlan_Box.Name = "Svlan_Box";
            this.Svlan_Box.Size = new System.Drawing.Size(121, 22);
            this.Svlan_Box.TabIndex = 12;
            this.Svlan_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Svlan_Box_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(156, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Cvlan：";
            // 
            // Cvlan_Box
            // 
            this.Cvlan_Box.Location = new System.Drawing.Point(158, 165);
            this.Cvlan_Box.Name = "Cvlan_Box";
            this.Cvlan_Box.Size = new System.Drawing.Size(121, 22);
            this.Cvlan_Box.TabIndex = 13;
            this.Cvlan_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cvlan_Box_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(11, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "專案類型：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(561, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 45;
            this.label16.Text = "Bw%：";
            // 
            // Percen_Box
            // 
            this.Percen_Box.Location = new System.Drawing.Point(564, 121);
            this.Percen_Box.Name = "Percen_Box";
            this.Percen_Box.Size = new System.Drawing.Size(121, 22);
            this.Percen_Box.TabIndex = 11;
            this.Percen_Box.Text = "10";
            this.Percen_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Percen_Box_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(434, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 16);
            this.label17.TabIndex = 53;
            this.label17.Text = "DownStream：";
            // 
            // Down_Box
            // 
            this.Down_Box.Location = new System.Drawing.Point(437, 121);
            this.Down_Box.Name = "Down_Box";
            this.Down_Box.Size = new System.Drawing.Size(121, 22);
            this.Down_Box.TabIndex = 10;
            this.Down_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Down_Box_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(951, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "啟用";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.textBox1.Location = new System.Drawing.Point(929, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 55;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(931, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 12);
            this.label18.TabIndex = 56;
            this.label18.Text = "VIP功能：請輸入密碼";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 11.25F);
            this.button3.Location = new System.Drawing.Point(16, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 47);
            this.button3.TabIndex = 57;
            this.button3.Text = "將輸出txt檔";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(17, 509);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 45);
            this.button4.TabIndex = 59;
            this.button4.Text = "一鍵開通";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("新細明體-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.Location = new System.Drawing.Point(811, 220);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(404, 420);
            this.richTextBox2.TabIndex = 60;
            this.richTextBox2.Text = "\n恭喜開通一鍵開通功能，目前只能開通ONT部分，\nOLT TAG 以上 都要手打!!\n\n需要先產出 Profile 確認後，才能啟用!!\n\n# 有任何錯誤 不負責" +
    "!!";
            this.richTextBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(741, 653);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Down_Box);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Percen_Box);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Cvlan_Box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Svlan_Box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Mode_Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GW_Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IP_Box);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UP_Box);
            this.Controls.Add(this.Des_Box);
            this.Controls.Add(this.SN_Box);
            this.Controls.Add(this.OnuID_Box);
            this.Controls.Add(this.Port_Box);
            this.Controls.Add(this.Slot_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form1";
            this.Text = "Profile 生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Slot_Box;
        private System.Windows.Forms.TextBox Port_Box;
        private System.Windows.Forms.TextBox OnuID_Box;
        private System.Windows.Forms.TextBox SN_Box;
        private System.Windows.Forms.TextBox Des_Box;
        private System.Windows.Forms.TextBox UP_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IP_Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GW_Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Mode_Box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Svlan_Box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Cvlan_Box;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Percen_Box;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Down_Box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

