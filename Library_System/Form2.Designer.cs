namespace Library_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.borrow_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.genre_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fiction_button = new System.Windows.Forms.Button();
            this.thriller_button = new System.Windows.Forms.Button();
            this.romance_button = new System.Windows.Forms.Button();
            this.fantasy_button = new System.Windows.Forms.Button();
            this.horror_button = new System.Windows.Forms.Button();
            this.horrorControl1 = new Library_System.Controls.HorrorControl();
            this.fictionControl1 = new Library_System.Control.FictionControl();
            this.romanceControl1 = new Library_System.Controls.RomanceControl();
            this.thrillerControl1 = new Library_System.Control.ThrillerControl();
            this.fantasyControl1 = new Library_System.Controls.FantasyControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.genre_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.fictionControl1);
            this.panel1.Controls.Add(this.borrow_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.romanceControl1);
            this.panel1.Controls.Add(this.thrillerControl1);
            this.panel1.Controls.Add(this.fantasyControl1);
            this.panel1.Controls.Add(this.horrorControl1);
            this.panel1.Location = new System.Drawing.Point(-20, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 665);
            this.panel1.TabIndex = 0;
            // 
            // borrow_button
            // 
            this.borrow_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.borrow_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrow_button.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_button.ForeColor = System.Drawing.Color.White;
            this.borrow_button.Location = new System.Drawing.Point(914, 562);
            this.borrow_button.Name = "borrow_button";
            this.borrow_button.Size = new System.Drawing.Size(120, 51);
            this.borrow_button.TabIndex = 3;
            this.borrow_button.Text = "borrow";
            this.borrow_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(15, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 60);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(17, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 32);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(54, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(199, 32);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // genre_panel
            // 
            this.genre_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.genre_panel.Controls.Add(this.label1);
            this.genre_panel.Controls.Add(this.flowLayoutPanel1);
            this.genre_panel.Location = new System.Drawing.Point(0, 154);
            this.genre_panel.Name = "genre_panel";
            this.genre_panel.Size = new System.Drawing.Size(234, 340);
            this.genre_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "➤ GENRE";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fiction_button);
            this.flowLayoutPanel1.Controls.Add(this.thriller_button);
            this.flowLayoutPanel1.Controls.Add(this.romance_button);
            this.flowLayoutPanel1.Controls.Add(this.fantasy_button);
            this.flowLayoutPanel1.Controls.Add(this.horror_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(219, 254);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fiction_button
            // 
            this.fiction_button.BackColor = System.Drawing.Color.Transparent;
            this.fiction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiction_button.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiction_button.ForeColor = System.Drawing.Color.White;
            this.fiction_button.Location = new System.Drawing.Point(3, 3);
            this.fiction_button.Name = "fiction_button";
            this.fiction_button.Size = new System.Drawing.Size(204, 43);
            this.fiction_button.TabIndex = 2;
            this.fiction_button.Text = "Fiction";
            this.fiction_button.UseVisualStyleBackColor = false;
            this.fiction_button.Click += new System.EventHandler(this.fiction_button_Click);
            // 
            // thriller_button
            // 
            this.thriller_button.BackColor = System.Drawing.Color.Transparent;
            this.thriller_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thriller_button.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thriller_button.ForeColor = System.Drawing.Color.White;
            this.thriller_button.Location = new System.Drawing.Point(3, 52);
            this.thriller_button.Name = "thriller_button";
            this.thriller_button.Size = new System.Drawing.Size(204, 43);
            this.thriller_button.TabIndex = 3;
            this.thriller_button.Text = "Thriller";
            this.thriller_button.UseVisualStyleBackColor = false;
            this.thriller_button.Click += new System.EventHandler(this.thriller_button_Click);
            // 
            // romance_button
            // 
            this.romance_button.BackColor = System.Drawing.Color.Transparent;
            this.romance_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.romance_button.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romance_button.ForeColor = System.Drawing.Color.White;
            this.romance_button.Location = new System.Drawing.Point(3, 101);
            this.romance_button.Name = "romance_button";
            this.romance_button.Size = new System.Drawing.Size(204, 43);
            this.romance_button.TabIndex = 4;
            this.romance_button.Text = "Romance";
            this.romance_button.UseVisualStyleBackColor = false;
            this.romance_button.Click += new System.EventHandler(this.romance_button_Click);
            // 
            // fantasy_button
            // 
            this.fantasy_button.BackColor = System.Drawing.Color.Transparent;
            this.fantasy_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fantasy_button.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantasy_button.ForeColor = System.Drawing.Color.White;
            this.fantasy_button.Location = new System.Drawing.Point(3, 150);
            this.fantasy_button.Name = "fantasy_button";
            this.fantasy_button.Size = new System.Drawing.Size(204, 43);
            this.fantasy_button.TabIndex = 5;
            this.fantasy_button.Text = "Fantasy";
            this.fantasy_button.UseVisualStyleBackColor = false;
            this.fantasy_button.Click += new System.EventHandler(this.fantasy_button_Click);
            // 
            // horror_button
            // 
            this.horror_button.BackColor = System.Drawing.Color.Transparent;
            this.horror_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horror_button.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horror_button.ForeColor = System.Drawing.Color.White;
            this.horror_button.Location = new System.Drawing.Point(3, 199);
            this.horror_button.Name = "horror_button";
            this.horror_button.Size = new System.Drawing.Size(204, 43);
            this.horror_button.TabIndex = 6;
            this.horror_button.Text = "Horror";
            this.horror_button.UseVisualStyleBackColor = false;
            this.horror_button.Click += new System.EventHandler(this.horror_button_Click);
            // 
            // horrorControl1
            // 
            this.horrorControl1.Location = new System.Drawing.Point(304, 126);
            this.horrorControl1.Name = "horrorControl1";
            this.horrorControl1.Size = new System.Drawing.Size(735, 422);
            this.horrorControl1.TabIndex = 8;
            // 
            // fictionControl1
            // 
            this.fictionControl1.Location = new System.Drawing.Point(304, 128);
            this.fictionControl1.Name = "fictionControl1";
            this.fictionControl1.Size = new System.Drawing.Size(730, 398);
            this.fictionControl1.TabIndex = 4;
            this.fictionControl1.Load += new System.EventHandler(this.fictionControl1_Load);
            // 
            // romanceControl1
            // 
            this.romanceControl1.Location = new System.Drawing.Point(304, 126);
            this.romanceControl1.Name = "romanceControl1";
            this.romanceControl1.Size = new System.Drawing.Size(735, 415);
            this.romanceControl1.TabIndex = 6;
            // 
            // thrillerControl1
            // 
            this.thrillerControl1.Location = new System.Drawing.Point(304, 126);
            this.thrillerControl1.Name = "thrillerControl1";
            this.thrillerControl1.Size = new System.Drawing.Size(730, 400);
            this.thrillerControl1.TabIndex = 5;
            // 
            // fantasyControl1
            // 
            this.fantasyControl1.Location = new System.Drawing.Point(304, 126);
            this.fantasyControl1.Name = "fantasyControl1";
            this.fantasyControl1.Size = new System.Drawing.Size(735, 415);
            this.fantasyControl1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 656);
            this.Controls.Add(this.genre_panel);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.genre_panel.ResumeLayout(false);
            this.genre_panel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button borrow_button;
        private System.Windows.Forms.Panel genre_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fiction_button;
        private System.Windows.Forms.Button thriller_button;
        private System.Windows.Forms.Button romance_button;
        private System.Windows.Forms.Button fantasy_button;
        private System.Windows.Forms.Button horror_button;
        private Control.FictionControl fictionControl1;
        private Control.ThrillerControl thrillerControl1;
        private Controls.RomanceControl romanceControl1;
        private Controls.FantasyControl fantasyControl1;
        private Controls.HorrorControl horrorControl1;
    }
}