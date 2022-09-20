
namespace JednoduchaKalkulacka
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTNcount = new System.Windows.Forms.Button();
            this.RBplus = new System.Windows.Forms.RadioButton();
            this.RBminus = new System.Windows.Forms.RadioButton();
            this.RBkrat = new System.Windows.Forms.RadioButton();
            this.RBdeleno = new System.Windows.Forms.RadioButton();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 1;
            // 
            // BTNcount
            // 
            this.BTNcount.Location = new System.Drawing.Point(142, 117);
            this.BTNcount.Name = "BTNcount";
            this.BTNcount.Size = new System.Drawing.Size(75, 23);
            this.BTNcount.TabIndex = 2;
            this.BTNcount.Text = "Vypočítat";
            this.BTNcount.UseVisualStyleBackColor = true;
            this.BTNcount.Click += new System.EventHandler(this.BTNcount_Click);
            // 
            // RBplus
            // 
            this.RBplus.AutoSize = true;
            this.RBplus.Location = new System.Drawing.Point(61, 117);
            this.RBplus.Name = "RBplus";
            this.RBplus.Size = new System.Drawing.Size(59, 17);
            this.RBplus.TabIndex = 7;
            this.RBplus.TabStop = true;
            this.RBplus.Text = "Součet";
            this.RBplus.UseVisualStyleBackColor = true;
            this.RBplus.Click += new System.EventHandler(this.RBplus_Click);
            // 
            // RBminus
            // 
            this.RBminus.AutoSize = true;
            this.RBminus.Location = new System.Drawing.Point(61, 140);
            this.RBminus.Name = "RBminus";
            this.RBminus.Size = new System.Drawing.Size(56, 17);
            this.RBminus.TabIndex = 8;
            this.RBminus.TabStop = true;
            this.RBminus.Text = "Rozdíl";
            this.RBminus.UseVisualStyleBackColor = true;
            this.RBminus.Click += new System.EventHandler(this.RBminus_Click);
            // 
            // RBkrat
            // 
            this.RBkrat.AutoSize = true;
            this.RBkrat.Location = new System.Drawing.Point(61, 163);
            this.RBkrat.Name = "RBkrat";
            this.RBkrat.Size = new System.Drawing.Size(55, 17);
            this.RBkrat.TabIndex = 9;
            this.RBkrat.TabStop = true;
            this.RBkrat.Text = "Součit";
            this.RBkrat.UseVisualStyleBackColor = true;
            this.RBkrat.Click += new System.EventHandler(this.RBkrat_Click);
            // 
            // RBdeleno
            // 
            this.RBdeleno.AutoSize = true;
            this.RBdeleno.Location = new System.Drawing.Point(61, 186);
            this.RBdeleno.Name = "RBdeleno";
            this.RBdeleno.Size = new System.Drawing.Size(50, 17);
            this.RBdeleno.TabIndex = 10;
            this.RBdeleno.TabStop = true;
            this.RBdeleno.Text = "Podíl";
            this.RBdeleno.UseVisualStyleBackColor = true;
            this.RBdeleno.Click += new System.EventHandler(this.RBdeleno_Click);
            // 
            // BTNdelete
            // 
            this.BTNdelete.Location = new System.Drawing.Point(142, 146);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(75, 23);
            this.BTNdelete.TabIndex = 11;
            this.BTNdelete.Text = "Smazat";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // BTNclose
            // 
            this.BTNclose.Location = new System.Drawing.Point(142, 175);
            this.BTNclose.Name = "BTNclose";
            this.BTNclose.Size = new System.Drawing.Size(75, 23);
            this.BTNclose.TabIndex = 12;
            this.BTNclose.Text = "Zavřít";
            this.BTNclose.UseVisualStyleBackColor = true;
            this.BTNclose.Click += new System.EventHandler(this.BTNclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "b:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNclose);
            this.Controls.Add(this.BTNdelete);
            this.Controls.Add(this.RBdeleno);
            this.Controls.Add(this.RBkrat);
            this.Controls.Add(this.RBminus);
            this.Controls.Add(this.RBplus);
            this.Controls.Add(this.BTNcount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTNcount;
        private System.Windows.Forms.RadioButton RBplus;
        private System.Windows.Forms.RadioButton RBminus;
        private System.Windows.Forms.RadioButton RBkrat;
        private System.Windows.Forms.RadioButton RBdeleno;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

