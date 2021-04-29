
namespace MyFc
{
    partial class TransferUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemovePlayerbutton = new System.Windows.Forms.Button();
            this.AddPlayerbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemovePlayerbutton);
            this.panel1.Controls.Add(this.AddPlayerbutton);
            this.panel1.Location = new System.Drawing.Point(212, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 338);
            this.panel1.TabIndex = 0;
            // 
            // RemovePlayerbutton
            // 
            this.RemovePlayerbutton.BackColor = System.Drawing.Color.Indigo;
            this.RemovePlayerbutton.FlatAppearance.BorderSize = 0;
            this.RemovePlayerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayerbutton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePlayerbutton.ForeColor = System.Drawing.Color.White;
            this.RemovePlayerbutton.Image = ((System.Drawing.Image)(resources.GetObject("RemovePlayerbutton.Image")));
            this.RemovePlayerbutton.Location = new System.Drawing.Point(22, 181);
            this.RemovePlayerbutton.Name = "RemovePlayerbutton";
            this.RemovePlayerbutton.Size = new System.Drawing.Size(535, 99);
            this.RemovePlayerbutton.TabIndex = 2;
            this.RemovePlayerbutton.Text = "REMOVE SOLD PLAYER";
            this.RemovePlayerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RemovePlayerbutton.UseVisualStyleBackColor = false;
            this.RemovePlayerbutton.Click += new System.EventHandler(this.RemovePlayerbutton_Click);
            // 
            // AddPlayerbutton
            // 
            this.AddPlayerbutton.BackColor = System.Drawing.Color.Indigo;
            this.AddPlayerbutton.FlatAppearance.BorderSize = 0;
            this.AddPlayerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlayerbutton.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerbutton.ForeColor = System.Drawing.Color.White;
            this.AddPlayerbutton.Image = ((System.Drawing.Image)(resources.GetObject("AddPlayerbutton.Image")));
            this.AddPlayerbutton.Location = new System.Drawing.Point(22, 35);
            this.AddPlayerbutton.Name = "AddPlayerbutton";
            this.AddPlayerbutton.Size = new System.Drawing.Size(535, 99);
            this.AddPlayerbutton.TabIndex = 1;
            this.AddPlayerbutton.Text = "ADD NEW SIGNING";
            this.AddPlayerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddPlayerbutton.UseVisualStyleBackColor = false;
            this.AddPlayerbutton.Click += new System.EventHandler(this.AddPlayerbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(869, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TransferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "TransferUserControl";
            this.Size = new System.Drawing.Size(1354, 595);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RemovePlayerbutton;
        private System.Windows.Forms.Button AddPlayerbutton;
    }
}
