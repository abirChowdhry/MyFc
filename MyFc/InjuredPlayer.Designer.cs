
namespace MyFc
{
    partial class InjuredPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InjuredPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Injuredbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PositioncomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InjuryPlayerpictureBox = new System.Windows.Forms.PictureBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.PlayerIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Maximisebutton = new System.Windows.Forms.Button();
            this.Minimisebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Recoveredbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateOfBirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.CurrencycomboBox2 = new System.Windows.Forms.ComboBox();
            this.CurrencycomboBox1 = new System.Windows.Forms.ComboBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.WagetextBox = new System.Windows.Forms.TextBox();
            this.PreferredFootcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SquaddataGridView = new System.Windows.Forms.DataGridView();
            this.EventcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InjuryPlayerpictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquaddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Exception Cases";
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(1364, 565);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(160, 36);
            this.Backbutton.TabIndex = 61;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Injuredbutton
            // 
            this.Injuredbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Injuredbutton.Location = new System.Drawing.Point(327, 492);
            this.Injuredbutton.Name = "Injuredbutton";
            this.Injuredbutton.Size = new System.Drawing.Size(215, 29);
            this.Injuredbutton.TabIndex = 60;
            this.Injuredbutton.Text = "MOVE PLAYER";
            this.Injuredbutton.UseVisualStyleBackColor = true;
            this.Injuredbutton.Click += new System.EventHandler(this.Injuredbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EventcomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PositioncomboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.InjuryPlayerpictureBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(63, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 307);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Details";
            // 
            // PositioncomboBox
            // 
            this.PositioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositioncomboBox.Enabled = false;
            this.PositioncomboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositioncomboBox.FormattingEnabled = true;
            this.PositioncomboBox.Items.AddRange(new object[] {
            "Goalkeeper",
            "Defender",
            "Midfielder",
            "Forward"});
            this.PositioncomboBox.Location = new System.Drawing.Point(346, 137);
            this.PositioncomboBox.Name = "PositioncomboBox";
            this.PositioncomboBox.Size = new System.Drawing.Size(342, 30);
            this.PositioncomboBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(260, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Position";
            // 
            // NametextBox
            // 
            this.NametextBox.Enabled = false;
            this.NametextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(346, 75);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.ReadOnly = true;
            this.NametextBox.Size = new System.Drawing.Size(342, 31);
            this.NametextBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(260, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Name";
            // 
            // InjuryPlayerpictureBox
            // 
            this.InjuryPlayerpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("InjuryPlayerpictureBox.Image")));
            this.InjuryPlayerpictureBox.Location = new System.Drawing.Point(52, 66);
            this.InjuryPlayerpictureBox.Name = "InjuryPlayerpictureBox";
            this.InjuryPlayerpictureBox.Size = new System.Drawing.Size(183, 169);
            this.InjuryPlayerpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InjuryPlayerpictureBox.TabIndex = 0;
            this.InjuryPlayerpictureBox.TabStop = false;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("Searchbutton.Image")));
            this.Searchbutton.Location = new System.Drawing.Point(568, 131);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(110, 29);
            this.Searchbutton.TabIndex = 58;
            this.Searchbutton.Text = "SEARCH";
            this.Searchbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // PlayerIdtextBox
            // 
            this.PlayerIdtextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIdtextBox.Location = new System.Drawing.Point(294, 129);
            this.PlayerIdtextBox.Name = "PlayerIdtextBox";
            this.PlayerIdtextBox.Size = new System.Drawing.Size(268, 31);
            this.PlayerIdtextBox.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Player ID";
            // 
            // Maximisebutton
            // 
            this.Maximisebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximisebutton.FlatAppearance.BorderSize = 0;
            this.Maximisebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximisebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximisebutton.ForeColor = System.Drawing.Color.White;
            this.Maximisebutton.Image = ((System.Drawing.Image)(resources.GetObject("Maximisebutton.Image")));
            this.Maximisebutton.Location = new System.Drawing.Point(1436, 0);
            this.Maximisebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Maximisebutton.Name = "Maximisebutton";
            this.Maximisebutton.Size = new System.Drawing.Size(47, 49);
            this.Maximisebutton.TabIndex = 63;
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
            this.Minimisebutton.Location = new System.Drawing.Point(1382, 0);
            this.Minimisebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Minimisebutton.Name = "Minimisebutton";
            this.Minimisebutton.Size = new System.Drawing.Size(47, 49);
            this.Minimisebutton.TabIndex = 64;
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
            this.Exitbutton.Location = new System.Drawing.Point(1489, 0);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(47, 49);
            this.Exitbutton.TabIndex = 62;
            this.Exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Recoveredbutton
            // 
            this.Recoveredbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recoveredbutton.Location = new System.Drawing.Point(1071, 492);
            this.Recoveredbutton.Name = "Recoveredbutton";
            this.Recoveredbutton.Size = new System.Drawing.Size(215, 29);
            this.Recoveredbutton.TabIndex = 65;
            this.Recoveredbutton.Text = "RECOVERED";
            this.Recoveredbutton.UseVisualStyleBackColor = true;
            this.Recoveredbutton.Click += new System.EventHandler(this.Recoveredbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CurrencycomboBox2);
            this.groupBox2.Controls.Add(this.HeighttextBox);
            this.groupBox2.Controls.Add(this.DateOfBirthdateTimePicker);
            this.groupBox2.Controls.Add(this.CurrencycomboBox1);
            this.groupBox2.Controls.Add(this.PricetextBox);
            this.groupBox2.Controls.Add(this.PreferredFootcomboBox);
            this.groupBox2.Controls.Add(this.WagetextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(12, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 103);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Details";
            this.groupBox2.Visible = false;
            // 
            // DateOfBirthdateTimePicker
            // 
            this.DateOfBirthdateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthdateTimePicker.Location = new System.Drawing.Point(6, 19);
            this.DateOfBirthdateTimePicker.Name = "DateOfBirthdateTimePicker";
            this.DateOfBirthdateTimePicker.Size = new System.Drawing.Size(71, 31);
            this.DateOfBirthdateTimePicker.TabIndex = 31;
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeighttextBox.Location = new System.Drawing.Point(83, 19);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(72, 31);
            this.HeighttextBox.TabIndex = 30;
            // 
            // CurrencycomboBox2
            // 
            this.CurrencycomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencycomboBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencycomboBox2.FormattingEnabled = true;
            this.CurrencycomboBox2.Items.AddRange(new object[] {
            "$",
            "€"});
            this.CurrencycomboBox2.Location = new System.Drawing.Point(147, 58);
            this.CurrencycomboBox2.Name = "CurrencycomboBox2";
            this.CurrencycomboBox2.Size = new System.Drawing.Size(121, 30);
            this.CurrencycomboBox2.TabIndex = 42;
            // 
            // CurrencycomboBox1
            // 
            this.CurrencycomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencycomboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencycomboBox1.FormattingEnabled = true;
            this.CurrencycomboBox1.Items.AddRange(new object[] {
            "$",
            "€"});
            this.CurrencycomboBox1.Location = new System.Drawing.Point(275, 22);
            this.CurrencycomboBox1.Name = "CurrencycomboBox1";
            this.CurrencycomboBox1.Size = new System.Drawing.Size(121, 30);
            this.CurrencycomboBox1.TabIndex = 41;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricetextBox.Location = new System.Drawing.Point(6, 56);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(135, 31);
            this.PricetextBox.TabIndex = 40;
            // 
            // WagetextBox
            // 
            this.WagetextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WagetextBox.Location = new System.Drawing.Point(275, 56);
            this.WagetextBox.Name = "WagetextBox";
            this.WagetextBox.Size = new System.Drawing.Size(121, 31);
            this.WagetextBox.TabIndex = 39;
            // 
            // PreferredFootcomboBox
            // 
            this.PreferredFootcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreferredFootcomboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreferredFootcomboBox.FormattingEnabled = true;
            this.PreferredFootcomboBox.Items.AddRange(new object[] {
            "Right",
            "Left"});
            this.PreferredFootcomboBox.Location = new System.Drawing.Point(161, 22);
            this.PreferredFootcomboBox.Name = "PreferredFootcomboBox";
            this.PreferredFootcomboBox.Size = new System.Drawing.Size(107, 30);
            this.PreferredFootcomboBox.TabIndex = 38;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SquaddataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(861, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 307);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exception Player List";
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
            this.SquaddataGridView.GridColor = System.Drawing.Color.White;
            this.SquaddataGridView.Location = new System.Drawing.Point(6, 25);
            this.SquaddataGridView.Name = "SquaddataGridView";
            this.SquaddataGridView.ReadOnly = true;
            this.SquaddataGridView.Size = new System.Drawing.Size(628, 276);
            this.SquaddataGridView.TabIndex = 0;
            // 
            // EventcomboBox
            // 
            this.EventcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventcomboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventcomboBox.FormattingEnabled = true;
            this.EventcomboBox.Items.AddRange(new object[] {
            "Injury",
            "Red Card"});
            this.EventcomboBox.Location = new System.Drawing.Point(346, 200);
            this.EventcomboBox.Name = "EventcomboBox";
            this.EventcomboBox.Size = new System.Drawing.Size(342, 30);
            this.EventcomboBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Event";
            // 
            // InjuredPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1536, 613);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Recoveredbutton);
            this.Controls.Add(this.Maximisebutton);
            this.Controls.Add(this.Minimisebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Injuredbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.PlayerIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InjuredPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InjuredPlayer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InjuryPlayerpictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SquaddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Injuredbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PositioncomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox InjuryPlayerpictureBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox PlayerIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Maximisebutton;
        private System.Windows.Forms.Button Minimisebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Recoveredbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthdateTimePicker;
        private System.Windows.Forms.ComboBox CurrencycomboBox2;
        private System.Windows.Forms.ComboBox CurrencycomboBox1;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.ComboBox PreferredFootcomboBox;
        private System.Windows.Forms.TextBox WagetextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView SquaddataGridView;
        private System.Windows.Forms.ComboBox EventcomboBox;
        private System.Windows.Forms.Label label3;
    }
}