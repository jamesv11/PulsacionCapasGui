namespace PulsacionesGUI
{
    partial class ConsultarPersonasFrm
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
            this.TablaTgb = new System.Windows.Forms.DataGridView();
            this.ConsultarBtm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTgb)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaTgb
            // 
            this.TablaTgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaTgb.Location = new System.Drawing.Point(98, 64);
            this.TablaTgb.Name = "TablaTgb";
            this.TablaTgb.Size = new System.Drawing.Size(487, 237);
            this.TablaTgb.TabIndex = 0;
            // 
            // ConsultarBtm
            // 
            this.ConsultarBtm.Location = new System.Drawing.Point(299, 333);
            this.ConsultarBtm.Name = "ConsultarBtm";
            this.ConsultarBtm.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBtm.TabIndex = 1;
            this.ConsultarBtm.Text = "Consultar";
            this.ConsultarBtm.UseVisualStyleBackColor = true;
            this.ConsultarBtm.Click += new System.EventHandler(this.ConsultarBtm_Click);
            // 
            // ConsultarPersonasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 378);
            this.Controls.Add(this.ConsultarBtm);
            this.Controls.Add(this.TablaTgb);
            this.Name = "ConsultarPersonasFrm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaTgb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaTgb;
        private System.Windows.Forms.Button ConsultarBtm;
    }
}