namespace System_programming_first_project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.haydab_chiqarma = new System.Windows.Forms.RadioButton();
            this.haydab_chiqar = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dinamik = new System.Windows.Forms.RadioButton();
            this.statik = new System.Windows.Forms.RadioButton();
            this.pr_yoq = new System.Windows.Forms.RadioButton();
            this.pr_bor = new System.Windows.Forms.RadioButton();
            this.jarayon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jadval = new System.Windows.Forms.DataGridView();
            this.yadro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.algoritm = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vaqt_kvant = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.protsessor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jadval)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaqt_kvant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.haydab_chiqarma);
            this.panel1.Controls.Add(this.haydab_chiqar);
            this.panel1.Location = new System.Drawing.Point(37, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 76);
            this.panel1.TabIndex = 4;
            // 
            // haydab_chiqarma
            // 
            this.haydab_chiqarma.AutoSize = true;
            this.haydab_chiqarma.Location = new System.Drawing.Point(13, 48);
            this.haydab_chiqarma.Name = "haydab_chiqarma";
            this.haydab_chiqarma.Size = new System.Drawing.Size(177, 20);
            this.haydab_chiqarma.TabIndex = 1;
            this.haydab_chiqarma.TabStop = true;
            this.haydab_chiqarma.Text = "Haydab chiqarmaydigan";
            this.haydab_chiqarma.UseVisualStyleBackColor = true;
            // 
            // haydab_chiqar
            // 
            this.haydab_chiqar.AutoSize = true;
            this.haydab_chiqar.Location = new System.Drawing.Point(13, 12);
            this.haydab_chiqar.Name = "haydab_chiqar";
            this.haydab_chiqar.Size = new System.Drawing.Size(151, 20);
            this.haydab_chiqar.TabIndex = 0;
            this.haydab_chiqar.TabStop = true;
            this.haydab_chiqar.Text = "Haydab chiqaruvchi ";
            this.haydab_chiqar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pr_yoq);
            this.panel2.Controls.Add(this.pr_bor);
            this.panel2.Location = new System.Drawing.Point(305, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 134);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dinamik);
            this.panel3.Controls.Add(this.statik);
            this.panel3.Location = new System.Drawing.Point(13, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 58);
            this.panel3.TabIndex = 2;
            // 
            // dinamik
            // 
            this.dinamik.AutoSize = true;
            this.dinamik.Location = new System.Drawing.Point(24, 27);
            this.dinamik.Name = "dinamik";
            this.dinamik.Size = new System.Drawing.Size(77, 20);
            this.dinamik.TabIndex = 1;
            this.dinamik.TabStop = true;
            this.dinamik.Text = "Dinamik";
            this.dinamik.UseVisualStyleBackColor = true;
            // 
            // statik
            // 
            this.statik.AutoSize = true;
            this.statik.Location = new System.Drawing.Point(24, 1);
            this.statik.Name = "statik";
            this.statik.Size = new System.Drawing.Size(61, 20);
            this.statik.TabIndex = 0;
            this.statik.TabStop = true;
            this.statik.Text = "Statik";
            this.statik.UseVisualStyleBackColor = true;
            // 
            // pr_yoq
            // 
            this.pr_yoq.AutoSize = true;
            this.pr_yoq.Location = new System.Drawing.Point(13, 10);
            this.pr_yoq.Name = "pr_yoq";
            this.pr_yoq.Size = new System.Drawing.Size(153, 20);
            this.pr_yoq.TabIndex = 1;
            this.pr_yoq.TabStop = true;
            this.pr_yoq.Text = "Prioritetga ega emas";
            this.pr_yoq.UseVisualStyleBackColor = true;
            this.pr_yoq.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // pr_bor
            // 
            this.pr_bor.AutoSize = true;
            this.pr_bor.Location = new System.Drawing.Point(13, 45);
            this.pr_bor.Name = "pr_bor";
            this.pr_bor.Size = new System.Drawing.Size(116, 20);
            this.pr_bor.TabIndex = 0;
            this.pr_bor.TabStop = true;
            this.pr_bor.Text = "Prioritetga ega";
            this.pr_bor.UseVisualStyleBackColor = true;
            this.pr_bor.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // jarayon
            // 
            this.jarayon.Location = new System.Drawing.Point(437, 135);
            this.jarayon.Name = "jarayon";
            this.jarayon.Size = new System.Drawing.Size(45, 22);
            this.jarayon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jarayonlar soni:";
            // 
            // jadval
            // 
            this.jadval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jadval.Location = new System.Drawing.Point(553, 49);
            this.jadval.Name = "jadval";
            this.jadval.RowHeadersWidth = 51;
            this.jadval.RowTemplate.Height = 24;
            this.jadval.Size = new System.Drawing.Size(376, 340);
            this.jadval.TabIndex = 10;
            // 
            // yadro
            // 
            this.yadro.Location = new System.Drawing.Point(437, 100);
            this.yadro.Name = "yadro";
            this.yadro.Size = new System.Drawing.Size(45, 22);
            this.yadro.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yadrolar soni:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Algoritm turi:";
            // 
            // algoritm
            // 
            this.algoritm.FormattingEnabled = true;
            this.algoritm.Items.AddRange(new object[] {
            "Birinchi kelganga birinchi xizmat",
            "Charxpalak",
            "Eng qisqa talab vaqtiga birinchi xizmat"});
            this.algoritm.Location = new System.Drawing.Point(132, 49);
            this.algoritm.Name = "algoritm";
            this.algoritm.Size = new System.Drawing.Size(339, 24);
            this.algoritm.TabIndex = 14;
            this.algoritm.SelectedIndexChanged += new System.EventHandler(this.algoritm_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Jadvalga o\'tish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Natija";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.protsessor);
            this.panel4.Controls.Add(this.vaqt_kvant);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(37, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 172);
            this.panel4.TabIndex = 5;
            // 
            // vaqt_kvant
            // 
            this.vaqt_kvant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaqt_kvant.Location = new System.Drawing.Point(11, 57);
            this.vaqt_kvant.Name = "vaqt_kvant";
            this.vaqt_kvant.RowHeadersWidth = 51;
            this.vaqt_kvant.RowTemplate.Height = 24;
            this.vaqt_kvant.Size = new System.Drawing.Size(230, 112);
            this.vaqt_kvant.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Protsessorlar soni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vaqt kvantlari kiriting:";
            // 
            // protsessor
            // 
            this.protsessor.FormattingEnabled = true;
            this.protsessor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.protsessor.Location = new System.Drawing.Point(133, 4);
            this.protsessor.Name = "protsessor";
            this.protsessor.Size = new System.Drawing.Size(108, 24);
            this.protsessor.TabIndex = 18;
            this.protsessor.SelectedIndexChanged += new System.EventHandler(this.protsessor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 410);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.algoritm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yadro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jadval);
            this.Controls.Add(this.jarayon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jadval)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vaqt_kvant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton haydab_chiqarma;
        private System.Windows.Forms.RadioButton haydab_chiqar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton dinamik;
        private System.Windows.Forms.RadioButton statik;
        private System.Windows.Forms.RadioButton pr_yoq;
        private System.Windows.Forms.RadioButton pr_bor;
        private System.Windows.Forms.TextBox jarayon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView jadval;
        private System.Windows.Forms.TextBox yadro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox algoritm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView vaqt_kvant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox protsessor;
    }
}

