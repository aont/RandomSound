namespace RandomSound
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.note1_textBox = new System.Windows.Forms.TextBox();
            this.sgm1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sgm2_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.note2_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.prob1_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prob2_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "note 1";
            // 
            // note1_textBox
            // 
            this.note1_textBox.Location = new System.Drawing.Point(55, 6);
            this.note1_textBox.Name = "note1_textBox";
            this.note1_textBox.Size = new System.Drawing.Size(100, 19);
            this.note1_textBox.TabIndex = 1;
            // 
            // sgm1_textBox
            // 
            this.sgm1_textBox.Location = new System.Drawing.Point(55, 31);
            this.sgm1_textBox.Name = "sgm1_textBox";
            this.sgm1_textBox.Size = new System.Drawing.Size(100, 19);
            this.sgm1_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "sgm 1";
            // 
            // sgm2_textBox
            // 
            this.sgm2_textBox.Location = new System.Drawing.Point(55, 106);
            this.sgm2_textBox.Name = "sgm2_textBox";
            this.sgm2_textBox.Size = new System.Drawing.Size(100, 19);
            this.sgm2_textBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "sgm 2";
            // 
            // note2_textBox
            // 
            this.note2_textBox.Location = new System.Drawing.Point(55, 81);
            this.note2_textBox.Name = "note2_textBox";
            this.note2_textBox.Size = new System.Drawing.Size(100, 19);
            this.note2_textBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "note 2";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(164, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(55, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 22);
            this.button2.TabIndex = 12;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(161, 6);
            this.trackBar1.Maximum = 127;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 129);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "volume";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(102, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 22);
            this.button3.TabIndex = 15;
            this.button3.Text = "set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // prob1_textBox
            // 
            this.prob1_textBox.Location = new System.Drawing.Point(55, 56);
            this.prob1_textBox.Name = "prob1_textBox";
            this.prob1_textBox.Size = new System.Drawing.Size(100, 19);
            this.prob1_textBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "prob 1";
            // 
            // prob2_textBox
            // 
            this.prob2_textBox.Location = new System.Drawing.Point(55, 131);
            this.prob2_textBox.Name = "prob2_textBox";
            this.prob2_textBox.Size = new System.Drawing.Size(100, 19);
            this.prob2_textBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "prob 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(210, 188);
            this.Controls.Add(this.prob2_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prob1_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sgm2_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.note2_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sgm1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.note1_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "random sound";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox note1_textBox;
        private System.Windows.Forms.TextBox sgm1_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sgm2_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox note2_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox prob1_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prob2_textBox;
        private System.Windows.Forms.Label label7;

    }
}

