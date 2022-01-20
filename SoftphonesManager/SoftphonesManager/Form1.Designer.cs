namespace SoftphonesManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.lblColors = new System.Windows.Forms.Label();
            this.pnlEs = new System.Windows.Forms.Panel();
            this.lblEs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPt = new System.Windows.Forms.Panel();
            this.lblPt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlEn = new System.Windows.Forms.Panel();
            this.lblEn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlIc = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chMantener = new System.Windows.Forms.CheckBox();
            this.pnlColors.SuspendLayout();
            this.pnlEs.SuspendLayout();
            this.pnlPt.SuspendLayout();
            this.pnlEn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo colors:";
            // 
            // pnlColors
            // 
            this.pnlColors.AllowDrop = true;
            this.pnlColors.BackColor = System.Drawing.Color.Silver;
            this.pnlColors.Controls.Add(this.lblColors);
            this.pnlColors.Location = new System.Drawing.Point(164, 49);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(197, 43);
            this.pnlColors.TabIndex = 1;
            this.pnlColors.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlColors_DragDrop);
            this.pnlColors.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlColors_DragEnter);
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Location = new System.Drawing.Point(12, 14);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(35, 13);
            this.lblColors.TabIndex = 0;
            this.lblColors.Text = "label6";
            // 
            // pnlEs
            // 
            this.pnlEs.AllowDrop = true;
            this.pnlEs.BackColor = System.Drawing.Color.Silver;
            this.pnlEs.Controls.Add(this.lblEs);
            this.pnlEs.Location = new System.Drawing.Point(164, 126);
            this.pnlEs.Name = "pnlEs";
            this.pnlEs.Size = new System.Drawing.Size(197, 43);
            this.pnlEs.TabIndex = 3;
            this.pnlEs.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlEs_DragDrop);
            this.pnlEs.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlEs_DragEnter);
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Location = new System.Drawing.Point(12, 16);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(35, 13);
            this.lblEs.TabIndex = 1;
            this.lblEs.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Archivo values (es):";
            // 
            // pnlPt
            // 
            this.pnlPt.AllowDrop = true;
            this.pnlPt.BackColor = System.Drawing.Color.Silver;
            this.pnlPt.Controls.Add(this.lblPt);
            this.pnlPt.Location = new System.Drawing.Point(164, 205);
            this.pnlPt.Name = "pnlPt";
            this.pnlPt.Size = new System.Drawing.Size(197, 43);
            this.pnlPt.TabIndex = 3;
            this.pnlPt.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPt_DragDrop);
            this.pnlPt.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPt_DragEnter);
            // 
            // lblPt
            // 
            this.lblPt.AutoSize = true;
            this.lblPt.Location = new System.Drawing.Point(12, 16);
            this.lblPt.Name = "lblPt";
            this.lblPt.Size = new System.Drawing.Size(35, 13);
            this.lblPt.TabIndex = 2;
            this.lblPt.Text = "label8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Archivo values (pt):";
            // 
            // pnlEn
            // 
            this.pnlEn.AllowDrop = true;
            this.pnlEn.BackColor = System.Drawing.Color.Silver;
            this.pnlEn.Controls.Add(this.lblEn);
            this.pnlEn.Location = new System.Drawing.Point(164, 280);
            this.pnlEn.Name = "pnlEn";
            this.pnlEn.Size = new System.Drawing.Size(197, 43);
            this.pnlEn.TabIndex = 3;
            this.pnlEn.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlEn_DragDrop);
            this.pnlEn.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlEn_DragEnter);
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(12, 16);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(35, 13);
            this.lblEn.TabIndex = 3;
            this.lblEn.Text = "label9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Archivo values (en):";
            // 
            // pnlIc
            // 
            this.pnlIc.AllowDrop = true;
            this.pnlIc.BackColor = System.Drawing.Color.Silver;
            this.pnlIc.Location = new System.Drawing.Point(544, 49);
            this.pnlIc.Name = "pnlIc";
            this.pnlIc.Size = new System.Drawing.Size(197, 43);
            this.pnlIc.TabIndex = 3;
            this.pnlIc.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlIc_DragDrop);
            this.pnlIc.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlIc_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ícono:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(639, 396);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(102, 42);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // chMantener
            // 
            this.chMantener.AutoSize = true;
            this.chMantener.Location = new System.Drawing.Point(24, 421);
            this.chMantener.Name = "chMantener";
            this.chMantener.Size = new System.Drawing.Size(154, 17);
            this.chMantener.TabIndex = 6;
            this.chMantener.Text = "Mantener rutas por defecto";
            this.chMantener.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chMantener);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.pnlIc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlEn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlPt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlEs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlColors);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlColors.ResumeLayout(false);
            this.pnlColors.PerformLayout();
            this.pnlEs.ResumeLayout(false);
            this.pnlEs.PerformLayout();
            this.pnlPt.ResumeLayout(false);
            this.pnlPt.PerformLayout();
            this.pnlEn.ResumeLayout(false);
            this.pnlEn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Panel pnlEs;
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPt;
        private System.Windows.Forms.Label lblPt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlEn;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlIc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox chMantener;
    }
}

