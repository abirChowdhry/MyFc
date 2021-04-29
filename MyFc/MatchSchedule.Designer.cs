
namespace MyFc
{
    partial class MatchSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchSchedule));
            this.Maximisebutton = new System.Windows.Forms.Button();
            this.Minimisebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Maximisebutton
            // 
            this.Maximisebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximisebutton.FlatAppearance.BorderSize = 0;
            this.Maximisebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximisebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximisebutton.ForeColor = System.Drawing.Color.White;
            this.Maximisebutton.Image = ((System.Drawing.Image)(resources.GetObject("Maximisebutton.Image")));
            this.Maximisebutton.Location = new System.Drawing.Point(714, 2);
            this.Maximisebutton.Name = "Maximisebutton";
            this.Maximisebutton.Size = new System.Drawing.Size(40, 40);
            this.Maximisebutton.TabIndex = 52;
            this.Maximisebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Maximisebutton.UseVisualStyleBackColor = true;
            this.Maximisebutton.Click += new System.EventHandler(this.Maximisebutton_Click);
            // 
            // Minimisebutton
            // 
            this.Minimisebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimisebutton.FlatAppearance.BorderSize = 0;
            this.Minimisebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimisebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimisebutton.ForeColor = System.Drawing.Color.White;
            this.Minimisebutton.Image = ((System.Drawing.Image)(resources.GetObject("Minimisebutton.Image")));
            this.Minimisebutton.Location = new System.Drawing.Point(668, 2);
            this.Minimisebutton.Name = "Minimisebutton";
            this.Minimisebutton.Size = new System.Drawing.Size(40, 40);
            this.Minimisebutton.TabIndex = 53;
            this.Minimisebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Minimisebutton.UseVisualStyleBackColor = true;
            this.Minimisebutton.Click += new System.EventHandler(this.Minimisebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Image = ((System.Drawing.Image)(resources.GetObject("Exitbutton.Image")));
            this.Exitbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbutton.Location = new System.Drawing.Point(760, 2);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(40, 40);
            this.Exitbutton.TabIndex = 51;
            this.Exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 54;
            this.label1.Text = "Match Schedule";
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(628, 402);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(160, 36);
            this.Backbutton.TabIndex = 55;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // MatchSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maximisebutton);
            this.Controls.Add(this.Minimisebutton);
            this.Controls.Add(this.Exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchSchedule";
            this.Text = "MatchSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Maximisebutton;
        private System.Windows.Forms.Button Minimisebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
    }
}