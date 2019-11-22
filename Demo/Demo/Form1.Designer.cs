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
            this.textBox_tempPontto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_tempUp = new System.Windows.Forms.Button();
            this.button_tempDown = new System.Windows.Forms.Button();
            this.textBox_tempLiha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox_tempPontto
            // 
            this.textBox_tempPontto.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tempPontto.Location = new System.Drawing.Point(56, 78);
            this.textBox_tempPontto.Name = "textBox_tempPontto";
            this.textBox_tempPontto.Size = new System.Drawing.Size(274, 80);
            this.textBox_tempPontto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pöntön lämpötila:";
            // 
            // button_tempUp
            // 
            this.button_tempUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempUp.Location = new System.Drawing.Point(343, 78);
            this.button_tempUp.Name = "button_tempUp";
            this.button_tempUp.Size = new System.Drawing.Size(40, 39);
            this.button_tempUp.TabIndex = 2;
            this.button_tempUp.Text = "+";
            this.button_tempUp.UseVisualStyleBackColor = true;
            // 
            // button_tempDown
            // 
            this.button_tempDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tempDown.Location = new System.Drawing.Point(343, 121);
            this.button_tempDown.Name = "button_tempDown";
            this.button_tempDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_tempDown.Size = new System.Drawing.Size(40, 37);
            this.button_tempDown.TabIndex = 3;
            this.button_tempDown.Text = "-";
            this.button_tempDown.UseVisualStyleBackColor = true;
            // 
            // textBox_tempLiha
            // 
            this.textBox_tempLiha.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tempLiha.Location = new System.Drawing.Point(457, 78);
            this.textBox_tempLiha.Name = "textBox_tempLiha";
            this.textBox_tempLiha.Size = new System.Drawing.Size(274, 80);
            this.textBox_tempLiha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lihan lämpötila:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_tempLiha);
            this.Controls.Add(this.button_tempDown);
            this.Controls.Add(this.button_tempUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_tempPontto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tempPontto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_tempUp;
        private System.Windows.Forms.Button button_tempDown;
        private System.Windows.Forms.TextBox textBox_tempLiha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

