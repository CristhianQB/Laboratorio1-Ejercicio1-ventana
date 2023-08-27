namespace Laboratorio1_Ejercicio1_ventana
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbl3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            txtb = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(111, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Fahrenheit ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(130, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Celsius";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl3.Location = new System.Drawing.Point(278, 98);
            lbl3.Name = "lbl3";
            lbl3.Size = new System.Drawing.Size(98, 37);
            lbl3.TabIndex = 2;
            lbl3.Text = "0.0000";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(183, 174);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(89, 50);
            button1.TabIndex = 3;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtb
            // 
            txtb.Location = new System.Drawing.Point(252, 48);
            txtb.Name = "txtb";
            txtb.Size = new System.Drawing.Size(173, 23);
            txtb.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(507, 450);
            Controls.Add(txtb);
            Controls.Add(button1);
            Controls.Add(lbl3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtb;
    }
}
