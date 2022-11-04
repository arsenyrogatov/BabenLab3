namespace BabenLab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.atransform_button = new System.Windows.Forms.Button();
            this.aresult_textBox = new System.Windows.Forms.TextBox();
            this.acapacity_textBox = new System.Windows.Forms.TextBox();
            this.ainput_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bwtmtf_button = new System.Windows.Forms.Button();
            this.mtf_textBox = new System.Windows.Forms.TextBox();
            this.bwt_textBox = new System.Windows.Forms.TextBox();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.atransform_button);
            this.panel1.Controls.Add(this.aresult_textBox);
            this.panel1.Controls.Add(this.acapacity_textBox);
            this.panel1.Controls.Add(this.ainput_textBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 224);
            this.panel1.TabIndex = 0;
            // 
            // atransform_button
            // 
            this.atransform_button.AutoSize = true;
            this.atransform_button.Location = new System.Drawing.Point(13, 186);
            this.atransform_button.Name = "atransform_button";
            this.atransform_button.Size = new System.Drawing.Size(113, 27);
            this.atransform_button.TabIndex = 3;
            this.atransform_button.Text = "Преобразовать";
            this.atransform_button.UseVisualStyleBackColor = true;
            this.atransform_button.Click += new System.EventHandler(this.atransform_button_Click);
            // 
            // aresult_textBox
            // 
            this.aresult_textBox.Location = new System.Drawing.Point(594, 13);
            this.aresult_textBox.Multiline = true;
            this.aresult_textBox.Name = "aresult_textBox";
            this.aresult_textBox.ReadOnly = true;
            this.aresult_textBox.Size = new System.Drawing.Size(284, 166);
            this.aresult_textBox.TabIndex = 2;
            // 
            // acapacity_textBox
            // 
            this.acapacity_textBox.Location = new System.Drawing.Point(304, 13);
            this.acapacity_textBox.Multiline = true;
            this.acapacity_textBox.Name = "acapacity_textBox";
            this.acapacity_textBox.ReadOnly = true;
            this.acapacity_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.acapacity_textBox.Size = new System.Drawing.Size(284, 166);
            this.acapacity_textBox.TabIndex = 1;
            // 
            // ainput_textBox
            // 
            this.ainput_textBox.Location = new System.Drawing.Point(14, 13);
            this.ainput_textBox.Multiline = true;
            this.ainput_textBox.Name = "ainput_textBox";
            this.ainput_textBox.Size = new System.Drawing.Size(284, 166);
            this.ainput_textBox.TabIndex = 0;
            this.ainput_textBox.Text = resources.GetString("ainput_textBox.Text");
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bwtmtf_button);
            this.panel2.Controls.Add(this.mtf_textBox);
            this.panel2.Controls.Add(this.bwt_textBox);
            this.panel2.Controls.Add(this.input_textBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 182);
            this.panel2.TabIndex = 1;
            // 
            // bwtmtf_button
            // 
            this.bwtmtf_button.AutoSize = true;
            this.bwtmtf_button.Location = new System.Drawing.Point(766, 137);
            this.bwtmtf_button.Name = "bwtmtf_button";
            this.bwtmtf_button.Size = new System.Drawing.Size(113, 27);
            this.bwtmtf_button.TabIndex = 4;
            this.bwtmtf_button.Text = "Преобразовать";
            this.bwtmtf_button.UseVisualStyleBackColor = true;
            this.bwtmtf_button.Click += new System.EventHandler(this.bwtmtf_button_Click);
            // 
            // mtf_textBox
            // 
            this.mtf_textBox.Location = new System.Drawing.Point(66, 96);
            this.mtf_textBox.Name = "mtf_textBox";
            this.mtf_textBox.ReadOnly = true;
            this.mtf_textBox.Size = new System.Drawing.Size(813, 25);
            this.mtf_textBox.TabIndex = 5;
            // 
            // bwt_textBox
            // 
            this.bwt_textBox.Location = new System.Drawing.Point(66, 54);
            this.bwt_textBox.Name = "bwt_textBox";
            this.bwt_textBox.ReadOnly = true;
            this.bwt_textBox.Size = new System.Drawing.Size(813, 25);
            this.bwt_textBox.TabIndex = 4;
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(66, 13);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(813, 25);
            this.input_textBox.TabIndex = 3;
            this.input_textBox.Text = "ИИККЕКВАУЦСРННН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MTF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BWT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фраза";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаба 3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button atransform_button;
        private TextBox aresult_textBox;
        private TextBox acapacity_textBox;
        private TextBox ainput_textBox;
        private Panel panel2;
        private Button bwtmtf_button;
        private TextBox mtf_textBox;
        private TextBox bwt_textBox;
        private TextBox input_textBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}