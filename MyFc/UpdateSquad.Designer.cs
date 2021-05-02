
namespace MyFc
{
    partial class UpdateSquad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSquad));
            this.Updatebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.PositioncomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CurrencycomboBox2 = new System.Windows.Forms.ComboBox();
            this.CurrencycomboBox1 = new System.Windows.Forms.ComboBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WagetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PreferredFootcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateOfBirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdatePlayerpictureBox = new System.Windows.Forms.PictureBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.PlayerIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Maximisebutton = new System.Windows.Forms.Button();
            this.Minimisebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePlayerpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Updatebutton
            // 
            this.Updatebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(492, 629);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(215, 29);
            this.Updatebutton.TabIndex = 46;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.groupBox1.Controls.Add(this.Browsebutton);
            this.groupBox1.Controls.Add(this.PositioncomboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CurrencycomboBox2);
            this.groupBox1.Controls.Add(this.CurrencycomboBox1);
            this.groupBox1.Controls.Add(this.PricetextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.WagetextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PreferredFootcomboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DateOfBirthdateTimePicker);
            this.groupBox1.Controls.Add(this.HeighttextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.UpdatePlayerpictureBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(159, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 458);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Details";
            // 
            // Browsebutton
            // 
            this.Browsebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebutton.ForeColor = System.Drawing.Color.Black;
            this.Browsebutton.Location = new System.Drawing.Point(81, 328);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(183, 29);
            this.Browsebutton.TabIndex = 40;
            this.Browsebutton.Text = "BROWSE";
            this.Browsebutton.UseVisualStyleBackColor = true;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // PositioncomboBox
            // 
            this.PositioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositioncomboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositioncomboBox.FormattingEnabled = true;
            this.PositioncomboBox.Items.AddRange(new object[] {
            "Goalkeeper",
            "Defender",
            "Midfielder",
            "Forward"});
            this.PositioncomboBox.Location = new System.Drawing.Point(508, 209);
            this.PositioncomboBox.Name = "PositioncomboBox";
            this.PositioncomboBox.Size = new System.Drawing.Size(342, 30);
            this.PositioncomboBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(329, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Position";
            // 
            // CurrencycomboBox2
            // 
            this.CurrencycomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencycomboBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencycomboBox2.FormattingEnabled = true;
            this.CurrencycomboBox2.Items.AddRange(new object[] {
            "$",
            "€"});
            this.CurrencycomboBox2.Location = new System.Drawing.Point(729, 385);
            this.CurrencycomboBox2.Name = "CurrencycomboBox2";
            this.CurrencycomboBox2.Size = new System.Drawing.Size(121, 30);
            this.CurrencycomboBox2.TabIndex = 37;
            // 
            // CurrencycomboBox1
            // 
            this.CurrencycomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencycomboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencycomboBox1.FormattingEnabled = true;
            this.CurrencycomboBox1.Items.AddRange(new object[] {
            "$",
            "€"});
            this.CurrencycomboBox1.Location = new System.Drawing.Point(729, 327);
            this.CurrencycomboBox1.Name = "CurrencycomboBox1";
            this.CurrencycomboBox1.Size = new System.Drawing.Size(121, 30);
            this.CurrencycomboBox1.TabIndex = 36;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricetextBox.Location = new System.Drawing.Point(508, 386);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(211, 31);
            this.PricetextBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(329, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Price";
            // 
            // WagetextBox
            // 
            this.WagetextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WagetextBox.Location = new System.Drawing.Point(508, 327);
            this.WagetextBox.Name = "WagetextBox";
            this.WagetextBox.Size = new System.Drawing.Size(211, 31);
            this.WagetextBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(329, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Weekly Wage";
            // 
            // PreferredFootcomboBox
            // 
            this.PreferredFootcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreferredFootcomboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreferredFootcomboBox.FormattingEnabled = true;
            this.PreferredFootcomboBox.Items.AddRange(new object[] {
            "Right",
            "Left"});
            this.PreferredFootcomboBox.Location = new System.Drawing.Point(508, 267);
            this.PreferredFootcomboBox.Name = "PreferredFootcomboBox";
            this.PreferredFootcomboBox.Size = new System.Drawing.Size(342, 30);
            this.PreferredFootcomboBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Preferred Foot";
            // 
            // DateOfBirthdateTimePicker
            // 
            this.DateOfBirthdateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthdateTimePicker.Location = new System.Drawing.Point(508, 97);
            this.DateOfBirthdateTimePicker.Name = "DateOfBirthdateTimePicker";
            this.DateOfBirthdateTimePicker.Size = new System.Drawing.Size(342, 31);
            this.DateOfBirthdateTimePicker.TabIndex = 29;
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeighttextBox.Location = new System.Drawing.Point(508, 159);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(342, 31);
            this.HeighttextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(329, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Date of Birth";
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(508, 44);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(342, 31);
            this.NametextBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(329, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Name";
            // 
            // UpdatePlayerpictureBox
            // 
            this.UpdatePlayerpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UpdatePlayerpictureBox.Image")));
            this.UpdatePlayerpictureBox.Location = new System.Drawing.Point(81, 139);
            this.UpdatePlayerpictureBox.Name = "UpdatePlayerpictureBox";
            this.UpdatePlayerpictureBox.Size = new System.Drawing.Size(183, 169);
            this.UpdatePlayerpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdatePlayerpictureBox.TabIndex = 0;
            this.UpdatePlayerpictureBox.TabStop = false;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("Searchbutton.Image")));
            this.Searchbutton.Location = new System.Drawing.Point(738, 101);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(110, 29);
            this.Searchbutton.TabIndex = 44;
            this.Searchbutton.Text = "SEARCH";
            this.Searchbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // PlayerIdtextBox
            // 
            this.PlayerIdtextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIdtextBox.Location = new System.Drawing.Point(464, 99);
            this.PlayerIdtextBox.Name = "PlayerIdtextBox";
            this.PlayerIdtextBox.Size = new System.Drawing.Size(268, 31);
            this.PlayerIdtextBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Player ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Update Squad";
            // 
            // Maximisebutton
            // 
            this.Maximisebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximisebutton.FlatAppearance.BorderSize = 0;
            this.Maximisebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximisebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximisebutton.ForeColor = System.Drawing.Color.White;
            this.Maximisebutton.Image = ((System.Drawing.Image)(resources.GetObject("Maximisebutton.Image")));
            this.Maximisebutton.Location = new System.Drawing.Point(1154, -1);
            this.Maximisebutton.Name = "Maximisebutton";
            this.Maximisebutton.Size = new System.Drawing.Size(40, 40);
            this.Maximisebutton.TabIndex = 49;
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
            this.Minimisebutton.Location = new System.Drawing.Point(1108, -1);
            this.Minimisebutton.Name = "Minimisebutton";
            this.Minimisebutton.Size = new System.Drawing.Size(40, 40);
            this.Minimisebutton.TabIndex = 50;
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
            this.Exitbutton.Location = new System.Drawing.Point(1200, -1);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(40, 40);
            this.Exitbutton.TabIndex = 48;
            this.Exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(1069, 686);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(160, 36);
            this.Backbutton.TabIndex = 51;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // UpdateSquad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1241, 734);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Maximisebutton);
            this.Controls.Add(this.Minimisebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.PlayerIdtextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSquad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateSquad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePlayerpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PositioncomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CurrencycomboBox2;
        private System.Windows.Forms.ComboBox CurrencycomboBox1;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WagetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PreferredFootcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateOfBirthdateTimePicker;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox UpdatePlayerpictureBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox PlayerIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Maximisebutton;
        private System.Windows.Forms.Button Minimisebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Browsebutton;
    }
}