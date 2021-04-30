
namespace MyFc
{
    partial class SeasonUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeasonUserControl));
            this.TopRatedPlayerbutton = new System.Windows.Forms.Button();
            this.TopGoalScorerbutton = new System.Windows.Forms.Button();
            this.TopAssistbutton = new System.Windows.Forms.Button();
            this.UpdateRatingbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopRatedPlayerbutton
            // 
            this.TopRatedPlayerbutton.BackColor = System.Drawing.Color.Indigo;
            this.TopRatedPlayerbutton.FlatAppearance.BorderSize = 0;
            this.TopRatedPlayerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopRatedPlayerbutton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRatedPlayerbutton.ForeColor = System.Drawing.Color.White;
            this.TopRatedPlayerbutton.Image = ((System.Drawing.Image)(resources.GetObject("TopRatedPlayerbutton.Image")));
            this.TopRatedPlayerbutton.Location = new System.Drawing.Point(764, 70);
            this.TopRatedPlayerbutton.Name = "TopRatedPlayerbutton";
            this.TopRatedPlayerbutton.Size = new System.Drawing.Size(290, 345);
            this.TopRatedPlayerbutton.TabIndex = 2;
            this.TopRatedPlayerbutton.Text = "TOP RATED PLAYERS";
            this.TopRatedPlayerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TopRatedPlayerbutton.UseVisualStyleBackColor = false;
            this.TopRatedPlayerbutton.Click += new System.EventHandler(this.TopRatedPlayerbutton_Click);
            // 
            // TopGoalScorerbutton
            // 
            this.TopGoalScorerbutton.BackColor = System.Drawing.Color.Indigo;
            this.TopGoalScorerbutton.FlatAppearance.BorderSize = 0;
            this.TopGoalScorerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopGoalScorerbutton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopGoalScorerbutton.ForeColor = System.Drawing.Color.White;
            this.TopGoalScorerbutton.Image = ((System.Drawing.Image)(resources.GetObject("TopGoalScorerbutton.Image")));
            this.TopGoalScorerbutton.Location = new System.Drawing.Point(102, 70);
            this.TopGoalScorerbutton.Name = "TopGoalScorerbutton";
            this.TopGoalScorerbutton.Size = new System.Drawing.Size(317, 177);
            this.TopGoalScorerbutton.TabIndex = 3;
            this.TopGoalScorerbutton.Text = "TOP GOAL SCORER";
            this.TopGoalScorerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TopGoalScorerbutton.UseVisualStyleBackColor = false;
            // 
            // TopAssistbutton
            // 
            this.TopAssistbutton.BackColor = System.Drawing.Color.Indigo;
            this.TopAssistbutton.FlatAppearance.BorderSize = 0;
            this.TopAssistbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopAssistbutton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopAssistbutton.ForeColor = System.Drawing.Color.White;
            this.TopAssistbutton.Image = ((System.Drawing.Image)(resources.GetObject("TopAssistbutton.Image")));
            this.TopAssistbutton.Location = new System.Drawing.Point(102, 253);
            this.TopAssistbutton.Name = "TopAssistbutton";
            this.TopAssistbutton.Size = new System.Drawing.Size(318, 162);
            this.TopAssistbutton.TabIndex = 4;
            this.TopAssistbutton.Text = "TOP ASSISTS";
            this.TopAssistbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TopAssistbutton.UseVisualStyleBackColor = false;
            // 
            // UpdateRatingbutton
            // 
            this.UpdateRatingbutton.BackColor = System.Drawing.Color.Indigo;
            this.UpdateRatingbutton.FlatAppearance.BorderSize = 0;
            this.UpdateRatingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateRatingbutton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRatingbutton.ForeColor = System.Drawing.Color.White;
            this.UpdateRatingbutton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateRatingbutton.Image")));
            this.UpdateRatingbutton.Location = new System.Drawing.Point(426, 266);
            this.UpdateRatingbutton.Name = "UpdateRatingbutton";
            this.UpdateRatingbutton.Size = new System.Drawing.Size(332, 149);
            this.UpdateRatingbutton.TabIndex = 5;
            this.UpdateRatingbutton.Text = "UPDATE PLAYER RATING";
            this.UpdateRatingbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UpdateRatingbutton.UseVisualStyleBackColor = false;
            this.UpdateRatingbutton.Click += new System.EventHandler(this.UpdateRatingbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SeasonUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UpdateRatingbutton);
            this.Controls.Add(this.TopAssistbutton);
            this.Controls.Add(this.TopGoalScorerbutton);
            this.Controls.Add(this.TopRatedPlayerbutton);
            this.Name = "SeasonUserControl";
            this.Size = new System.Drawing.Size(1354, 595);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TopRatedPlayerbutton;
        private System.Windows.Forms.Button TopGoalScorerbutton;
        private System.Windows.Forms.Button TopAssistbutton;
        private System.Windows.Forms.Button UpdateRatingbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
