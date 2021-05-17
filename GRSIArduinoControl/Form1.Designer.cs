
namespace GRSIArduinoControl
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
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.btnObterCOMs = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tbLEDRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnONRed = new System.Windows.Forms.Button();
            this.btnOFFRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCOM
            // 
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(61, 27);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(121, 23);
            this.cbCOM.TabIndex = 0;
            this.cbCOM.SelectedIndexChanged += new System.EventHandler(this.cbCOM_SelectedIndexChanged);
            // 
            // btnObterCOMs
            // 
            this.btnObterCOMs.Location = new System.Drawing.Point(73, 65);
            this.btnObterCOMs.Name = "btnObterCOMs";
            this.btnObterCOMs.Size = new System.Drawing.Size(98, 23);
            this.btnObterCOMs.TabIndex = 1;
            this.btnObterCOMs.Text = "Obter COMs";
            this.btnObterCOMs.UseVisualStyleBackColor = true;
            this.btnObterCOMs.Click += new System.EventHandler(this.btnObterCOMs_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(84, 117);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // tbLEDRed
            // 
            this.tbLEDRed.ForeColor = System.Drawing.SystemColors.Window;
            this.tbLEDRed.Location = new System.Drawing.Point(61, 235);
            this.tbLEDRed.Name = "tbLEDRed";
            this.tbLEDRed.Size = new System.Drawing.Size(80, 23);
            this.tbLEDRed.TabIndex = 3;
            this.tbLEDRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "LED Vermelho";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(84, 157);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 6;
            this.btnTerminar.Text = "TERMINAR";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(84, 386);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnONRed
            // 
            this.btnONRed.Location = new System.Drawing.Point(170, 235);
            this.btnONRed.Name = "btnONRed";
            this.btnONRed.Size = new System.Drawing.Size(75, 23);
            this.btnONRed.TabIndex = 8;
            this.btnONRed.Text = "ON";
            this.btnONRed.UseVisualStyleBackColor = true;
            this.btnONRed.Click += new System.EventHandler(this.btnONRed_Click);
            // 
            // btnOFFRed
            // 
            this.btnOFFRed.Location = new System.Drawing.Point(262, 235);
            this.btnOFFRed.Name = "btnOFFRed";
            this.btnOFFRed.Size = new System.Drawing.Size(75, 23);
            this.btnOFFRed.TabIndex = 9;
            this.btnOFFRed.Text = "OFF";
            this.btnOFFRed.UseVisualStyleBackColor = true;
            this.btnOFFRed.Click += new System.EventHandler(this.btnOFFRed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.btnOFFRed);
            this.Controls.Add(this.btnONRed);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLEDRed);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnObterCOMs);
            this.Controls.Add(this.cbCOM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Button btnObterCOMs;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tbLEDRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnONRed;
        private System.Windows.Forms.Button btnOFFRed;
    }
}

