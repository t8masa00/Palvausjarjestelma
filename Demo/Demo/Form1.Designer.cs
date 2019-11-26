namespace Demo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox_liha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_tempUp = new System.Windows.Forms.Button();
            this.button_tempDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_savuntuotto = new System.Windows.Forms.TextBox();
            this.button_tempUp3 = new System.Windows.Forms.Button();
            this.button_tempDown3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_kuivaus = new System.Windows.Forms.TextBox();
            this.button_tempUp2 = new System.Windows.Forms.Button();
            this.button_tempDown2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_sisalampo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_lampo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_liha
            // 
            this.textBox_liha.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_liha.Location = new System.Drawing.Point(285, 89);
            this.textBox_liha.Name = "textBox_liha";
            this.textBox_liha.Size = new System.Drawing.Size(138, 80);
            this.textBox_liha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aseta haluttu lihan lämpö:";
            // 
            // button_tempUp
            // 
            this.button_tempUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempUp.Location = new System.Drawing.Point(453, 89);
            this.button_tempUp.Name = "button_tempUp";
            this.button_tempUp.Size = new System.Drawing.Size(40, 39);
            this.button_tempUp.TabIndex = 2;
            this.button_tempUp.Text = "+";
            this.button_tempUp.UseVisualStyleBackColor = true;
            this.button_tempUp.Click += new System.EventHandler(this.Button_tempUp_Click);
            // 
            // button_tempDown
            // 
            this.button_tempDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempDown.Location = new System.Drawing.Point(453, 132);
            this.button_tempDown.Name = "button_tempDown";
            this.button_tempDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_tempDown.Size = new System.Drawing.Size(40, 37);
            this.button_tempDown.TabIndex = 3;
            this.button_tempDown.Text = "-";
            this.button_tempDown.UseVisualStyleBackColor = true;
            this.button_tempDown.Click += new System.EventHandler(this.Button_tempDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Palvain";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_savuntuotto);
            this.groupBox1.Controls.Add(this.button_tempUp3);
            this.groupBox1.Controls.Add(this.button_tempDown3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_kuivaus);
            this.groupBox1.Controls.Add(this.button_tempUp2);
            this.groupBox1.Controls.Add(this.button_tempDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_liha);
            this.groupBox1.Controls.Add(this.button_tempUp);
            this.groupBox1.Controls.Add(this.button_tempDown);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 605);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ohjelman asetukset:";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(285, 492);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(191, 82);
            this.start.TabIndex = 12;
            this.start.Text = "Aloita";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aseta savuntuotto aika:";
            // 
            // textBox_savuntuotto
            // 
            this.textBox_savuntuotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_savuntuotto.Location = new System.Drawing.Point(285, 354);
            this.textBox_savuntuotto.Name = "textBox_savuntuotto";
            this.textBox_savuntuotto.Size = new System.Drawing.Size(138, 80);
            this.textBox_savuntuotto.TabIndex = 8;
            // 
            // button_tempUp3
            // 
            this.button_tempUp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempUp3.Location = new System.Drawing.Point(453, 354);
            this.button_tempUp3.Name = "button_tempUp3";
            this.button_tempUp3.Size = new System.Drawing.Size(40, 39);
            this.button_tempUp3.TabIndex = 10;
            this.button_tempUp3.Text = "+";
            this.button_tempUp3.UseVisualStyleBackColor = true;
            this.button_tempUp3.Click += new System.EventHandler(this.Button_tempUp3_Click);
            // 
            // button_tempDown3
            // 
            this.button_tempDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempDown3.Location = new System.Drawing.Point(453, 397);
            this.button_tempDown3.Name = "button_tempDown3";
            this.button_tempDown3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_tempDown3.Size = new System.Drawing.Size(40, 37);
            this.button_tempDown3.TabIndex = 11;
            this.button_tempDown3.Text = "-";
            this.button_tempDown3.UseVisualStyleBackColor = true;
            this.button_tempDown3.Click += new System.EventHandler(this.Button_tempDown3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aseta kuivaus aika:";
            // 
            // textBox_kuivaus
            // 
            this.textBox_kuivaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kuivaus.Location = new System.Drawing.Point(285, 221);
            this.textBox_kuivaus.Name = "textBox_kuivaus";
            this.textBox_kuivaus.Size = new System.Drawing.Size(138, 80);
            this.textBox_kuivaus.TabIndex = 4;
            // 
            // button_tempUp2
            // 
            this.button_tempUp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempUp2.Location = new System.Drawing.Point(453, 221);
            this.button_tempUp2.Name = "button_tempUp2";
            this.button_tempUp2.Size = new System.Drawing.Size(40, 39);
            this.button_tempUp2.TabIndex = 6;
            this.button_tempUp2.Text = "+";
            this.button_tempUp2.UseVisualStyleBackColor = true;
            this.button_tempUp2.Click += new System.EventHandler(this.Button_tempUp2_Click);
            // 
            // button_tempDown2
            // 
            this.button_tempDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempDown2.Location = new System.Drawing.Point(453, 264);
            this.button_tempDown2.Name = "button_tempDown2";
            this.button_tempDown2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_tempDown2.Size = new System.Drawing.Size(40, 37);
            this.button_tempDown2.TabIndex = 7;
            this.button_tempDown2.Text = "-";
            this.button_tempDown2.UseVisualStyleBackColor = true;
            this.button_tempDown2.Click += new System.EventHandler(this.Button_tempDown2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_sisalampo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(608, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 157);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lihan sisälämpö:";
            // 
            // label_sisalampo
            // 
            this.label_sisalampo.AutoSize = true;
            this.label_sisalampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sisalampo.Location = new System.Drawing.Point(36, 49);
            this.label_sisalampo.Name = "label_sisalampo";
            this.label_sisalampo.Size = new System.Drawing.Size(41, 39);
            this.label_sisalampo.TabIndex = 0;
            this.label_sisalampo.Text = "\"\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_lampo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(608, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 157);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laatikon lämpö:";
            // 
            // label_lampo
            // 
            this.label_lampo.AutoSize = true;
            this.label_lampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lampo.Location = new System.Drawing.Point(36, 58);
            this.label_lampo.Name = "label_lampo";
            this.label_lampo.Size = new System.Drawing.Size(41, 39);
            this.label_lampo.TabIndex = 1;
            this.label_lampo.Text = "\"\"";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(608, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 80);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Käynnissä";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(787, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sulje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 782);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_liha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_tempUp;
        private System.Windows.Forms.Button button_tempDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_savuntuotto;
        private System.Windows.Forms.Button button_tempUp3;
        private System.Windows.Forms.Button button_tempDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_kuivaus;
        private System.Windows.Forms.Button button_tempUp2;
        private System.Windows.Forms.Button button_tempDown2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_sisalampo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_lampo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

