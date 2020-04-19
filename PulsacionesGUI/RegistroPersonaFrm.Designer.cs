namespace PulsacionesGUI
{
    partial class RegistroPersonaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPersonaFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SexoCmb = new System.Windows.Forms.ComboBox();
            this.EdadTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.PulsacionTxt = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(193, 37);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(100, 20);
            this.IdentificacionTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pulsaciones";
            // 
            // SexoCmb
            // 
            this.SexoCmb.FormattingEnabled = true;
            this.SexoCmb.Items.AddRange(new object[] {
            "F",
            "M"});
            this.SexoCmb.Location = new System.Drawing.Point(193, 130);
            this.SexoCmb.Name = "SexoCmb";
            this.SexoCmb.Size = new System.Drawing.Size(121, 21);
            this.SexoCmb.TabIndex = 6;
            // 
            // EdadTxt
            // 
            this.EdadTxt.Location = new System.Drawing.Point(193, 99);
            this.EdadTxt.Name = "EdadTxt";
            this.EdadTxt.Size = new System.Drawing.Size(100, 20);
            this.EdadTxt.TabIndex = 7;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(193, 68);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreTxt.TabIndex = 8;
            // 
            // PulsacionTxt
            // 
            this.PulsacionTxt.Enabled = false;
            this.PulsacionTxt.Location = new System.Drawing.Point(193, 162);
            this.PulsacionTxt.Name = "PulsacionTxt";
            this.PulsacionTxt.ReadOnly = true;
            this.PulsacionTxt.Size = new System.Drawing.Size(100, 20);
            this.PulsacionTxt.TabIndex = 9;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBtn.Image")));
            this.GuardarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarBtn.Location = new System.Drawing.Point(82, 227);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(74, 46);
            this.GuardarBtn.TabIndex = 10;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(398, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 152);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroPersonaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.PulsacionTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.EdadTxt);
            this.Controls.Add(this.SexoCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroPersonaFrm";
            this.Text = "RegistroPersona";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SexoCmb;
        private System.Windows.Forms.TextBox EdadTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox PulsacionTxt;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}