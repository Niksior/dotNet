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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.speedValue = new System.Windows.Forms.Label();
            this.altitudeValue = new System.Windows.Forms.Label();
            this.depthValue = new System.Windows.Forms.Label();
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
            this.increaseSpeed.Location = new System.Drawing.Point(579, 106);
            this.increaseSpeed.Name = "increaseSpeed";
            this.increaseSpeed.Size = new System.Drawing.Size(75, 23);
            this.increaseSpeed.TabIndex = 8;
            this.increaseSpeed.Text = "+";
            this.increaseSpeed.UseVisualStyleBackColor = true;
            // 
            // decreaseSpeed
            // 
            this.decreaseSpeed.Location = new System.Drawing.Point(814, 106);
            this.decreaseSpeed.Name = "decreaseSpeed";
            this.decreaseSpeed.Size = new System.Drawing.Size(75, 23);
            this.decreaseSpeed.TabIndex = 10;
            this.decreaseSpeed.Text = "-";
            this.decreaseSpeed.UseVisualStyleBackColor = true;
            // 
            // increaseAltitude
            // 
            this.increaseAltitude.Location = new System.Drawing.Point(579, 199);
            this.increaseAltitude.Name = "increaseAltitude";
            this.increaseAltitude.Size = new System.Drawing.Size(75, 23);
            this.increaseAltitude.TabIndex = 11;
            this.increaseAltitude.Text = "+";
            this.increaseAltitude.UseVisualStyleBackColor = true;
            // 
            // decreaseAltitude
            // 
            this.decreaseAltitude.Location = new System.Drawing.Point(814, 199);
            this.decreaseAltitude.Name = "decreaseAltitude";
            this.decreaseAltitude.Size = new System.Drawing.Size(75, 23);
            this.decreaseAltitude.TabIndex = 13;
            this.decreaseAltitude.Text = "-";
            this.decreaseAltitude.UseVisualStyleBackColor = true;
            // 
            // increaseDepth
            // 
            this.increaseDepth.Location = new System.Drawing.Point(579, 283);
            this.increaseDepth.Name = "increaseDepth";
            this.increaseDepth.Size = new System.Drawing.Size(75, 23);
            this.increaseDepth.TabIndex = 14;
            this.increaseDepth.Text = "+";
            this.increaseDepth.UseVisualStyleBackColor = true;
            // 
            // decreaseDepth
            // 
            this.decreaseDepth.Location = new System.Drawing.Point(814, 283);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Altitude";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Depth";
            // 
            // speedValue
            // 
            this.speedValue.AutoSize = true;
            this.speedValue.Location = new System.Drawing.Point(714, 111);
            this.speedValue.Name = "speedValue";
            this.speedValue.Size = new System.Drawing.Size(63, 13);
            this.speedValue.TabIndex = 21;
            this.speedValue.Text = "speedValue";
            // 
            // altitudeValue
            // 
            this.altitudeValue.AutoSize = true;
            this.altitudeValue.Location = new System.Drawing.Point(714, 199);
            this.altitudeValue.Name = "altitudeValue";
            this.altitudeValue.Size = new System.Drawing.Size(68, 13);
            this.altitudeValue.TabIndex = 22;
            this.altitudeValue.Text = "altitudeValue";
            // 
            // depthValue
            // 
            this.depthValue.AutoSize = true;
            this.depthValue.Location = new System.Drawing.Point(714, 283);
            this.depthValue.Name = "depthValue";
            this.depthValue.Size = new System.Drawing.Size(61, 13);
            this.depthValue.TabIndex = 23;
            this.depthValue.Text = "depthValue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 408);
            this.Controls.Add(this.depthValue);
            this.Controls.Add(this.altitudeValue);
            this.Controls.Add(this.speedValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.activeToy);
            this.Controls.Add(this.decreaseDepth);
            this.Controls.Add(this.increaseDepth);
            this.Controls.Add(this.decreaseAltitude);
            this.Controls.Add(this.increaseAltitude);
            this.Controls.Add(this.decreaseSpeed);
            this.Controls.Add(this.increaseSpeed);
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
        private System.Windows.Forms.Button increaseSpeed;
        private System.Windows.Forms.Button decreaseSpeed;
        private System.Windows.Forms.Button increaseAltitude;
        private System.Windows.Forms.Button decreaseAltitude;
        private System.Windows.Forms.Button increaseDepth;
        private System.Windows.Forms.Button decreaseDepth;
        private System.Windows.Forms.Label activeToy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label speedValue;
        private System.Windows.Forms.Label altitudeValue;
        private System.Windows.Forms.Label depthValue;
    }
}

