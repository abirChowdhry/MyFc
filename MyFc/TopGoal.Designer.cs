
namespace MyFc
{
    partial class TopGoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopGoal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SquaddataGridView = new System.Windows.Forms.DataGridView();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Maximisebutton = new System.Windows.Forms.Button();
            this.Minimisebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquaddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SquaddataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(207, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 411);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top Players";
            // 
            // SquaddataGridView
            // 
            this.SquaddataGridView.AllowUserToAddRows = false;
            this.SquaddataGridView.AllowUserToDeleteRows = false;
            this.SquaddataGridView.AllowUserToResizeColumns = false;
            this.SquaddataGridView.AllowUserToResizeRows = false;
            this.SquaddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SquaddataGridView.BackgroundColor = System.Drawing.Color.Indigo;
            this.SquaddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SquaddataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SquaddataGridView.GridColor = System.Drawing.Color.White;
            this.SquaddataGridView.Location = new System.Drawing.Point(6, 25);
            this.SquaddataGridView.Name = "SquaddataGridView";
            this.SquaddataGridView.ReadOnly = true;
            this.SquaddataGridView.Size = new System.Drawing.Size(635, 380);
            this.SquaddataGridView.TabIndex = 0;
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(905, 580);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(160, 36);
            this.Backbutton.TabIndex = 75;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "Top Goal Scorer";
            // 
            // Maximisebutton
            // 
            this.Maximisebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximisebutton.FlatAppearance.BorderSize = 0;
            this.Maximisebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximisebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximisebutton.ForeColor = System.Drawing.Color.White;
            this.Maximisebutton.Image = ((System.Drawing.Image)(resources.GetObject("Maximisebutton.Image")));
            this.Maximisebutton.Location = new System.Drawing.Point(980, 0);
            this.Maximisebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Maximisebutton.Name = "Maximisebutton";
            this.Maximisebutton.Size = new System.Drawing.Size(47, 49);
            this.Maximisebutton.TabIndex = 72;
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
            this.Minimisebutton.Location = new System.Drawing.Point(926, 0);
            this.Minimisebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Minimisebutton.Name = "Minimisebutton";
            this.Minimisebutton.Size = new System.Drawing.Size(47, 49);
            this.Minimisebutton.TabIndex = 73;
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
            this.Exitbutton.Location = new System.Drawing.Point(1033, 0);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(47, 49);
            this.Exitbutton.TabIndex = 71;
            this.Exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // TopGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1077, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maximisebutton);
            this.Controls.Add(this.Minimisebutton);
            this.Controls.Add(this.Exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopGoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopGoal";
            this.Load += new System.EventHandler(this.TopGoal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SquaddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView SquaddataGridView;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Maximisebutton;
        private System.Windows.Forms.Button Minimisebutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}