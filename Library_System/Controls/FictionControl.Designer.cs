namespace Library_System.Control
{
    partial class FictionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.f1 = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.Button();
            this.f3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.f1);
            this.flowLayoutPanel1.Controls.Add(this.f2);
            this.flowLayoutPanel1.Controls.Add(this.f3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 394);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(3, 3);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(224, 332);
            this.f1.TabIndex = 0;
            this.f1.Text = "button1";
            this.f1.UseVisualStyleBackColor = true;
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(233, 3);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(224, 332);
            this.f2.TabIndex = 1;
            this.f2.Text = "button2";
            this.f2.UseVisualStyleBackColor = true;
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(463, 3);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(224, 332);
            this.f3.TabIndex = 2;
            this.f3.Text = "button3";
            this.f3.UseVisualStyleBackColor = true;
            // 
            // FictionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FictionControl";
            this.Size = new System.Drawing.Size(730, 398);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button f1;
        private System.Windows.Forms.Button f2;
        private System.Windows.Forms.Button f3;
    }
}
