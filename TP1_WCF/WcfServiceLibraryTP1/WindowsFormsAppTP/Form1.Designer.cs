
namespace WindowsFormsAppTP
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_resultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_soustraction = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(145, 53);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(254, 20);
            this.tb_x.TabIndex = 1;
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(145, 98);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(254, 20);
            this.tb_y.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // tb_resultat
            // 
            this.tb_resultat.Location = new System.Drawing.Point(145, 147);
            this.tb_resultat.Name = "tb_resultat";
            this.tb_resultat.ReadOnly = true;
            this.tb_resultat.Size = new System.Drawing.Size(254, 20);
            this.tb_resultat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultat";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(29, 212);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_soustraction
            // 
            this.btn_soustraction.Location = new System.Drawing.Point(132, 212);
            this.btn_soustraction.Name = "btn_soustraction";
            this.btn_soustraction.Size = new System.Drawing.Size(75, 23);
            this.btn_soustraction.TabIndex = 7;
            this.btn_soustraction.Text = "-";
            this.btn_soustraction.UseVisualStyleBackColor = true;
            this.btn_soustraction.Click += new System.EventHandler(this.btn_soustraction_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(239, 212);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_multiply.TabIndex = 8;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(347, 212);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 23);
            this.btn_division.TabIndex = 9;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_soustraction);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_resultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_resultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_soustraction;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_division;
    }
}

