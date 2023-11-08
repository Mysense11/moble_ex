namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new System.Windows.Forms.TextBox();
            cbPay = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblOrder = new System.Windows.Forms.Label();
            lblChiken = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            lblPal = new System.Windows.Forms.Label();
            lblTang = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            listbPay = new System.Windows.Forms.ListBox();
            btnEvent = new System.Windows.Forms.Button();
            btnReceipt = new System.Windows.Forms.Button();
            btnPay = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblCoke = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            lblJajang = new System.Windows.Forms.Label();
            lblZzam = new System.Windows.Forms.Label();
            lblShrimp = new System.Windows.Forms.Label();
            lblYang = new System.Windows.Forms.Label();
            lblRice = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button19 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(2, 368);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(254, 130);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cbPay
            // 
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "신용카드", "무통장입금", "포인트", "Pay" });
            cbPay.Location = new System.Drawing.Point(263, 475);
            cbPay.Name = "cbPay";
            cbPay.Size = new System.Drawing.Size(121, 23);
            cbPay.TabIndex = 2;
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(131, 296);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "8000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2, 334);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "주문시요구사항";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(426, 446);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "결제정보";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(30, 296);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 15);
            label4.TabIndex = 0;
            label4.Text = "8000";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new System.Drawing.Point(329, 153);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new System.Drawing.Size(55, 15);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "주문결과";
            // 
            // lblChiken
            // 
            lblChiken.AutoSize = true;
            lblChiken.Location = new System.Drawing.Point(125, 71);
            lblChiken.Name = "lblChiken";
            lblChiken.Size = new System.Drawing.Size(43, 15);
            lblChiken.TabIndex = 0;
            lblChiken.Text = "깐풍기";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(298, 446);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(55, 15);
            label10.TabIndex = 0;
            label10.Text = "결제방법";
            // 
            // lblPal
            // 
            lblPal.AutoSize = true;
            lblPal.Location = new System.Drawing.Point(225, 70);
            lblPal.Name = "lblPal";
            lblPal.Size = new System.Drawing.Size(43, 15);
            lblPal.TabIndex = 0;
            lblPal.Text = "팔보채";
            // 
            // lblTang
            // 
            lblTang.AutoSize = true;
            lblTang.Location = new System.Drawing.Point(21, 70);
            lblTang.Name = "lblTang";
            lblTang.Size = new System.Drawing.Size(43, 15);
            lblTang.TabIndex = 0;
            lblTang.Text = "탕수육";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(230, 196);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(35, 15);
            label14.TabIndex = 0;
            label14.Text = "6000";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(21, 91);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(42, 15);
            label16.TabIndex = 0;
            label16.Text = "30000";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(125, 196);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(42, 15);
            label20.TabIndex = 0;
            label20.Text = "35000";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(228, 91);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(42, 15);
            label22.TabIndex = 0;
            label22.Text = "35000";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(25, 196);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(42, 15);
            label23.TabIndex = 0;
            label23.Text = "35000";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(125, 91);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(42, 15);
            label24.TabIndex = 0;
            label24.Text = "35000";
            // 
            // listbPay
            // 
            listbPay.FormattingEnabled = true;
            listbPay.ItemHeight = 15;
            listbPay.Items.AddRange(new object[] { "일시불", "3개월 할부", "6개월 할부", "" });
            listbPay.Location = new System.Drawing.Point(413, 475);
            listbPay.Name = "listbPay";
            listbPay.Size = new System.Drawing.Size(113, 79);
            listbPay.TabIndex = 7;
            // 
            // btnEvent
            // 
            btnEvent.Location = new System.Drawing.Point(327, 102);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new System.Drawing.Size(104, 32);
            btnEvent.TabIndex = 8;
            btnEvent.Text = "주문메뉴확인";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new System.Drawing.Point(262, 368);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new System.Drawing.Size(102, 31);
            btnReceipt.TabIndex = 8;
            btnReceipt.Text = "요구사항 접수";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new System.Drawing.Point(278, 526);
            btnPay.Name = "btnPay";
            btnPay.Size = new System.Drawing.Size(75, 44);
            btnPay.TabIndex = 8;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // button7
            // 
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button7.Image = (System.Drawing.Image)resources.GetObject("button7.Image");
            button7.Location = new System.Drawing.Point(102, 9);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(83, 58);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button8.Image = (System.Drawing.Image)resources.GetObject("button8.Image");
            button8.Location = new System.Drawing.Point(6, 9);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(83, 58);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(329, 55);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(102, 31);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "주문취소";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCoke
            // 
            lblCoke.AutoSize = true;
            lblCoke.Location = new System.Drawing.Point(235, 275);
            lblCoke.Name = "lblCoke";
            lblCoke.Size = new System.Drawing.Size(31, 15);
            lblCoke.TabIndex = 0;
            lblCoke.Text = "콜라";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(231, 296);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(35, 15);
            label25.TabIndex = 0;
            label25.Text = "1500";
            // 
            // lblJajang
            // 
            lblJajang.AutoSize = true;
            lblJajang.Location = new System.Drawing.Point(225, 171);
            lblJajang.Name = "lblJajang";
            lblJajang.Size = new System.Drawing.Size(43, 15);
            lblJajang.TabIndex = 0;
            lblJajang.Text = "자장면";
            // 
            // lblZzam
            // 
            lblZzam.AutoSize = true;
            lblZzam.Location = new System.Drawing.Point(30, 275);
            lblZzam.Name = "lblZzam";
            lblZzam.Size = new System.Drawing.Size(31, 15);
            lblZzam.TabIndex = 0;
            lblZzam.Text = "짬뽕";
            // 
            // lblShrimp
            // 
            lblShrimp.AutoSize = true;
            lblShrimp.Location = new System.Drawing.Point(21, 171);
            lblShrimp.Name = "lblShrimp";
            lblShrimp.Size = new System.Drawing.Size(55, 15);
            lblShrimp.TabIndex = 0;
            lblShrimp.Text = "깐쇼새우";
            // 
            // lblYang
            // 
            lblYang.AutoSize = true;
            lblYang.Location = new System.Drawing.Point(125, 171);
            lblYang.Name = "lblYang";
            lblYang.Size = new System.Drawing.Size(43, 15);
            lblYang.TabIndex = 0;
            lblYang.Text = "양장피";
            // 
            // lblRice
            // 
            lblRice.AutoSize = true;
            lblRice.Location = new System.Drawing.Point(125, 275);
            lblRice.Name = "lblRice";
            lblRice.Size = new System.Drawing.Size(43, 15);
            lblRice.TabIndex = 0;
            lblRice.Text = "볶음밥";
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(204, 9);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(83, 58);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(6, 111);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(83, 58);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            button4.Location = new System.Drawing.Point(102, 109);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(83, 58);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Image = (System.Drawing.Image)resources.GetObject("button6.Image");
            button6.Location = new System.Drawing.Point(102, 214);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(83, 58);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button10
            // 
            button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button10.Image = (System.Drawing.Image)resources.GetObject("button10.Image");
            button10.Location = new System.Drawing.Point(6, 214);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(83, 58);
            button10.TabIndex = 8;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button14
            // 
            button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button14.Image = (System.Drawing.Image)resources.GetObject("button14.Image");
            button14.Location = new System.Drawing.Point(204, 214);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(83, 58);
            button14.TabIndex = 8;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button19
            // 
            button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button19.Image = (System.Drawing.Image)resources.GetObject("button19.Image");
            button19.Location = new System.Drawing.Point(204, 111);
            button19.Name = "button19";
            button19.Size = new System.Drawing.Size(83, 58);
            button19.TabIndex = 8;
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(581, 21);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(31, 15);
            label8.TabIndex = 0;
            label8.Text = "메뉴";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(714, 21);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 15);
            label7.TabIndex = 0;
            label7.Text = "수량";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(1047, 225);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(120, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("탕수육");
            domainUpDown1.Items.Add("깐풍기");
            domainUpDown1.Items.Add("팔보채");
            domainUpDown1.Items.Add("깐쇼새우");
            domainUpDown1.Items.Add("양장피");
            domainUpDown1.Items.Add("자장면");
            domainUpDown1.Items.Add("짬뽕");
            domainUpDown1.Items.Add("볶음밥");
            domainUpDown1.Items.Add("콜라");
            domainUpDown1.Items.Add("");
            domainUpDown1.Items.Add("");
            domainUpDown1.Items.Add("");
            domainUpDown1.Location = new System.Drawing.Point(915, 225);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new System.Drawing.Size(120, 23);
            domainUpDown1.TabIndex = 10;
            domainUpDown1.Text = "선택하세요";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightCyan;
            ClientSize = new System.Drawing.Size(880, 650);
            Controls.Add(domainUpDown1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnCancel);
            Controls.Add(button8);
            Controls.Add(button14);
            Controls.Add(button19);
            Controls.Add(button6);
            Controls.Add(button10);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(btnPay);
            Controls.Add(btnReceipt);
            Controls.Add(btnEvent);
            Controls.Add(listbPay);
            Controls.Add(lblPal);
            Controls.Add(label7);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label20);
            Controls.Add(label16);
            Controls.Add(lblRice);
            Controls.Add(label10);
            Controls.Add(label22);
            Controls.Add(label4);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(lblYang);
            Controls.Add(lblShrimp);
            Controls.Add(label25);
            Controls.Add(lblZzam);
            Controls.Add(lblChiken);
            Controls.Add(label8);
            Controls.Add(lblJajang);
            Controls.Add(lblCoke);
            Controls.Add(lblOrder);
            Controls.Add(lblTang);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbPay);
            Controls.Add(textBox1);
            ForeColor = System.Drawing.Color.DarkSlateGray;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblChiken;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPal;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ListBox listbPay;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCoke;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblJajang;
        private System.Windows.Forms.Label lblZzam;
        private System.Windows.Forms.Label lblShrimp;
        private System.Windows.Forms.Label lblYang;
        private System.Windows.Forms.Label lblRice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Timer timer1;
    }
}