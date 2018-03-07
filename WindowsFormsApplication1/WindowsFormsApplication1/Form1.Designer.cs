namespace WindowsFormsApplication1
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
            this.toyCatalog = new System.Windows.Forms.ListBox();
            this.toyOwned = new System.Windows.Forms.ListBox();
            this.toyNameBox = new System.Windows.Forms.TextBox();
            this.toyAdd = new System.Windows.Forms.Button();
            this.toyDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toyCatalog
            // 
            this.toyCatalog.FormattingEnabled = true;
            this.toyCatalog.Location = new System.Drawing.Point(12, 38);
            this.toyCatalog.Name = "toyCatalog";
            this.toyCatalog.Size = new System.Drawing.Size(124, 342);
            this.toyCatalog.TabIndex = 0;
            // 
            // toyOwned
            // 
            this.toyOwned.FormattingEnabled = true;
            this.toyOwned.Location = new System.Drawing.Point(331, 39);
            this.toyOwned.Name = "toyOwned";
            this.toyOwned.Size = new System.Drawing.Size(139, 342);
            this.toyOwned.TabIndex = 1;
            // 
            // toyNameBox
            // 
            this.toyNameBox.Location = new System.Drawing.Point(165, 44);
            this.toyNameBox.Name = "toyNameBox";
            this.toyNameBox.Size = new System.Drawing.Size(131, 20);
            this.toyNameBox.TabIndex = 2;
            // 
            // toyAdd
            // 
            this.toyAdd.Location = new System.Drawing.Point(165, 124);
            this.toyAdd.Name = "toyAdd";
            this.toyAdd.Size = new System.Drawing.Size(131, 39);
            this.toyAdd.TabIndex = 3;
            this.toyAdd.Text = "Dodaj";
            this.toyAdd.UseVisualStyleBackColor = true;
            // 
            // toyDelete
            // 
            this.toyDelete.Location = new System.Drawing.Point(165, 211);
            this.toyDelete.Name = "toyDelete";
            this.toyDelete.Size = new System.Drawing.Size(131, 34);
            this.toyDelete.TabIndex = 4;
            this.toyDelete.Text = "Usun";
            this.toyDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Katalog zabawek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Posiadane zabawki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwa zabawki";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toyDelete);
            this.Controls.Add(this.toyAdd);
            this.Controls.Add(this.toyNameBox);
            this.Controls.Add(this.toyOwned);
            this.Controls.Add(this.toyCatalog);
            this.Name = "Form1";
            this.Text = "Zabawki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox toyCatalog;
        private System.Windows.Forms.ListBox toyOwned;
        private System.Windows.Forms.TextBox toyNameBox;
        private System.Windows.Forms.Button toyAdd;
        private System.Windows.Forms.Button toyDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

