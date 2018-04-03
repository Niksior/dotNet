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
            this.increaseSpeed = new System.Windows.Forms.Button();
            this.decreaseSpeed = new System.Windows.Forms.Button();
            this.increaseAltitude = new System.Windows.Forms.Button();
            this.decreaseAltitude = new System.Windows.Forms.Button();
            this.increaseDepth = new System.Windows.Forms.Button();
            this.decreaseDepth = new System.Windows.Forms.Button();
            this.activeToy = new System.Windows.Forms.Label();
            this.speedValue = new System.Windows.Forms.Label();
            this.altitudeValue = new System.Windows.Forms.Label();
            this.depthValue = new System.Windows.Forms.Label();
            this.altitudeBox = new System.Windows.Forms.GroupBox();
            this.speedBox = new System.Windows.Forms.GroupBox();
            this.depthBox = new System.Windows.Forms.GroupBox();
            this.altitudeBox.SuspendLayout();
            this.speedBox.SuspendLayout();
            this.depthBox.SuspendLayout();
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
            // increaseSpeed
            // 
            this.increaseSpeed.Location = new System.Drawing.Point(29, 50);
            this.increaseSpeed.Name = "increaseSpeed";
            this.increaseSpeed.Size = new System.Drawing.Size(75, 23);
            this.increaseSpeed.TabIndex = 8;
            this.increaseSpeed.Text = "+";
            this.increaseSpeed.UseVisualStyleBackColor = true;
            // 
            // decreaseSpeed
            // 
            this.decreaseSpeed.Location = new System.Drawing.Point(264, 50);
            this.decreaseSpeed.Name = "decreaseSpeed";
            this.decreaseSpeed.Size = new System.Drawing.Size(75, 23);
            this.decreaseSpeed.TabIndex = 10;
            this.decreaseSpeed.Text = "-";
            this.decreaseSpeed.UseVisualStyleBackColor = true;
            // 
            // increaseAltitude
            // 
            this.increaseAltitude.Location = new System.Drawing.Point(29, 40);
            this.increaseAltitude.Name = "increaseAltitude";
            this.increaseAltitude.Size = new System.Drawing.Size(75, 23);
            this.increaseAltitude.TabIndex = 11;
            this.increaseAltitude.Text = "+";
            this.increaseAltitude.UseVisualStyleBackColor = true;
            // 
            // decreaseAltitude
            // 
            this.decreaseAltitude.Location = new System.Drawing.Point(264, 40);
            this.decreaseAltitude.Name = "decreaseAltitude";
            this.decreaseAltitude.Size = new System.Drawing.Size(75, 23);
            this.decreaseAltitude.TabIndex = 13;
            this.decreaseAltitude.Text = "-";
            this.decreaseAltitude.UseVisualStyleBackColor = true;
            this.decreaseAltitude.Click += new System.EventHandler(this.decreaseAltitude_Click);
            // 
            // increaseDepth
            // 
            this.increaseDepth.Location = new System.Drawing.Point(29, 31);
            this.increaseDepth.Name = "increaseDepth";
            this.increaseDepth.Size = new System.Drawing.Size(75, 23);
            this.increaseDepth.TabIndex = 14;
            this.increaseDepth.Text = "+";
            this.increaseDepth.UseVisualStyleBackColor = true;
            // 
            // decreaseDepth
            // 
            this.decreaseDepth.Location = new System.Drawing.Point(264, 31);
            this.decreaseDepth.Name = "decreaseDepth";
            this.decreaseDepth.Size = new System.Drawing.Size(75, 23);
            this.decreaseDepth.TabIndex = 16;
            this.decreaseDepth.Text = "-";
            this.decreaseDepth.UseVisualStyleBackColor = true;
            // 
            // activeToy
            // 
            this.activeToy.AutoSize = true;
            this.activeToy.Location = new System.Drawing.Point(687, 22);
            this.activeToy.Name = "activeToy";
            this.activeToy.Size = new System.Drawing.Size(0, 13);
            this.activeToy.TabIndex = 17;
            // 
            // speedValue
            // 
            this.speedValue.AutoSize = true;
            this.speedValue.Location = new System.Drawing.Point(164, 55);
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(63, 13);
            this.speedValue.TabIndex = 21;
            this.speedValue.Text = "speedValue";
            // 
            // altitudeValue
            // 
            this.altitudeValue.AutoSize = true;
            this.altitudeValue.Location = new System.Drawing.Point(164, 40);
            this.altitudeValue.Name = "altitudeValue";
            this.altitudeValue.Size = new System.Drawing.Size(68, 13);
            this.altitudeValue.TabIndex = 22;
            this.altitudeValue.Text = "altitudeValue";
            // 
            // depthValue
            // 
            this.depthValue.AutoSize = true;
            this.depthValue.Location = new System.Drawing.Point(166, 31);
            this.depthValue.Name = "depthValue";
            this.depthValue.Size = new System.Drawing.Size(61, 13);
            this.depthValue.TabIndex = 23;
            this.depthValue.Text = "depthValue";
            // 
            // altitudeBox
            // 
            this.altitudeBox.Controls.Add(this.increaseAltitude);
            this.altitudeBox.Controls.Add(this.altitudeValue);
            this.altitudeBox.Controls.Add(this.decreaseAltitude);
            this.altitudeBox.Enabled = false;
            this.altitudeBox.Location = new System.Drawing.Point(550, 159);
            this.altitudeBox.Name = "altitudeBox";
            this.altitudeBox.Size = new System.Drawing.Size(353, 86);
            this.altitudeBox.TabIndex = 24;
            this.altitudeBox.TabStop = false;
            this.altitudeBox.Text = "Altitude";
            // 
            // speedBox
            // 
            this.speedBox.Controls.Add(this.speedValue);
            this.speedBox.Controls.Add(this.decreaseSpeed);
            this.speedBox.Controls.Add(this.increaseSpeed);
            this.speedBox.Enabled = false;
            this.speedBox.Location = new System.Drawing.Point(550, 57);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(353, 99);
            this.speedBox.TabIndex = 25;
            this.speedBox.TabStop = false;
            this.speedBox.Text = "Speed";
            // 
            // depthBox
            // 
            this.depthBox.Controls.Add(this.depthValue);
            this.depthBox.Controls.Add(this.decreaseDepth);
            this.depthBox.Controls.Add(this.increaseDepth);
            this.depthBox.Enabled = false;
            this.depthBox.Location = new System.Drawing.Point(550, 252);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(353, 100);
            this.depthBox.TabIndex = 26;
            this.depthBox.TabStop = false;
            this.depthBox.Text = "Depth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 408);
            this.Controls.Add(this.activeToy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toyDelete);
            this.Controls.Add(this.toyAdd);
            this.Controls.Add(this.toyNameBox);
            this.Controls.Add(this.toyOwned);
            this.Controls.Add(this.toyCatalog);
            this.Controls.Add(this.altitudeBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.depthBox);
            this.Name = "Form1";
            this.Text = "Zabawki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.altitudeBox.ResumeLayout(false);
            this.altitudeBox.PerformLayout();
            this.speedBox.ResumeLayout(false);
            this.speedBox.PerformLayout();
            this.depthBox.ResumeLayout(false);
            this.depthBox.PerformLayout();
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
        private System.Windows.Forms.Button increaseSpeed;
        private System.Windows.Forms.Button decreaseSpeed;
        private System.Windows.Forms.Button increaseAltitude;
        private System.Windows.Forms.Button decreaseAltitude;
        private System.Windows.Forms.Button increaseDepth;
        private System.Windows.Forms.Button decreaseDepth;
        private System.Windows.Forms.Label activeToy;
        private System.Windows.Forms.Label speedValue;
        private System.Windows.Forms.Label altitudeValue;
        private System.Windows.Forms.Label depthValue;
        private System.Windows.Forms.GroupBox altitudeBox;
        private System.Windows.Forms.GroupBox speedBox;
        private System.Windows.Forms.GroupBox depthBox;
    }
}

