namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartCorel = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartCorel
            // 
            this.StartCorel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartCorel.Location = new System.Drawing.Point(14, 75);
            this.StartCorel.Margin = new System.Windows.Forms.Padding(5);
            this.StartCorel.Name = "StartCorel";
            this.StartCorel.Size = new System.Drawing.Size(168, 51);
            this.StartCorel.TabIndex = 3;
            this.StartCorel.Text = "Abrir CorelDRAW";
            this.StartCorel.UseVisualStyleBackColor = true;
            this.StartCorel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Reset.Location = new System.Drawing.Point(14, 14);
            this.Reset.Margin = new System.Windows.Forms.Padding(5);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(168, 51);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Resetar";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Provided by Flavio Moreira";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartCorel);
            this.Controls.Add(this.Reset);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(214, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(214, 195);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CorelDRAW Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartCorel;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
    }
}

