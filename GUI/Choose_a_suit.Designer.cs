namespace GUI {
    partial class Choose_a_suit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.grp_suit_selection = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdo_Spades = new System.Windows.Forms.RadioButton();
            this.rdo_Hearts = new System.Windows.Forms.RadioButton();
            this.rdo_Diamond = new System.Windows.Forms.RadioButton();
            this.rdo_Clubs = new System.Windows.Forms.RadioButton();
            this.btn_Play_card = new System.Windows.Forms.Button();
            this.grp_suit_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "You choose a Eight!\r\nYou get to choose a suit";
            // 
            // grp_suit_selection
            // 
            this.grp_suit_selection.Controls.Add(this.pictureBox4);
            this.grp_suit_selection.Controls.Add(this.pictureBox3);
            this.grp_suit_selection.Controls.Add(this.pictureBox2);
            this.grp_suit_selection.Controls.Add(this.pictureBox1);
            this.grp_suit_selection.Controls.Add(this.rdo_Spades);
            this.grp_suit_selection.Controls.Add(this.rdo_Hearts);
            this.grp_suit_selection.Controls.Add(this.rdo_Diamond);
            this.grp_suit_selection.Controls.Add(this.rdo_Clubs);
            this.grp_suit_selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_suit_selection.Location = new System.Drawing.Point(46, 124);
            this.grp_suit_selection.Name = "grp_suit_selection";
            this.grp_suit_selection.Size = new System.Drawing.Size(148, 174);
            this.grp_suit_selection.TabIndex = 1;
            this.grp_suit_selection.TabStop = false;
            this.grp_suit_selection.Text = "Choose a Suit";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GUI.Properties.Resources.spades;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(9, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 22);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GUI.Properties.Resources.hearts;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(9, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 22);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.diamonds;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(9, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 22);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.clubs;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 22);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // rdo_Spades
            // 
            this.rdo_Spades.AutoSize = true;
            this.rdo_Spades.Location = new System.Drawing.Point(31, 131);
            this.rdo_Spades.Name = "rdo_Spades";
            this.rdo_Spades.Size = new System.Drawing.Size(76, 22);
            this.rdo_Spades.TabIndex = 3;
            this.rdo_Spades.TabStop = true;
            this.rdo_Spades.Text = "Spades";
            this.rdo_Spades.UseVisualStyleBackColor = true;
            // 
            // rdo_Hearts
            // 
            this.rdo_Hearts.AutoSize = true;
            this.rdo_Hearts.Location = new System.Drawing.Point(31, 96);
            this.rdo_Hearts.Name = "rdo_Hearts";
            this.rdo_Hearts.Size = new System.Drawing.Size(70, 22);
            this.rdo_Hearts.TabIndex = 2;
            this.rdo_Hearts.TabStop = true;
            this.rdo_Hearts.Text = "Hearts";
            this.rdo_Hearts.UseVisualStyleBackColor = true;
            // 
            // rdo_Diamond
            // 
            this.rdo_Diamond.AutoSize = true;
            this.rdo_Diamond.Location = new System.Drawing.Point(31, 61);
            this.rdo_Diamond.Name = "rdo_Diamond";
            this.rdo_Diamond.Size = new System.Drawing.Size(94, 22);
            this.rdo_Diamond.TabIndex = 1;
            this.rdo_Diamond.TabStop = true;
            this.rdo_Diamond.Text = "Diamonds";
            this.rdo_Diamond.UseVisualStyleBackColor = true;
            // 
            // rdo_Clubs
            // 
            this.rdo_Clubs.AutoSize = true;
            this.rdo_Clubs.Location = new System.Drawing.Point(31, 29);
            this.rdo_Clubs.Name = "rdo_Clubs";
            this.rdo_Clubs.Size = new System.Drawing.Size(64, 22);
            this.rdo_Clubs.TabIndex = 0;
            this.rdo_Clubs.TabStop = true;
            this.rdo_Clubs.Text = "Clubs";
            this.rdo_Clubs.UseVisualStyleBackColor = true;
            this.rdo_Clubs.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // btn_Play_card
            // 
            this.btn_Play_card.Location = new System.Drawing.Point(46, 330);
            this.btn_Play_card.Name = "btn_Play_card";
            this.btn_Play_card.Size = new System.Drawing.Size(132, 23);
            this.btn_Play_card.TabIndex = 2;
            this.btn_Play_card.Text = "Play Card";
            this.btn_Play_card.UseVisualStyleBackColor = true;
            this.btn_Play_card.Click += new System.EventHandler(this.btn_Play_card_Click);
            // 
            // Choose_a_suit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(231, 383);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Play_card);
            this.Controls.Add(this.grp_suit_selection);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Choose_a_suit";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose a Suit?";
            this.TopMost = true;
            this.grp_suit_selection.ResumeLayout(false);
            this.grp_suit_selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_suit_selection;
        private System.Windows.Forms.RadioButton rdo_Spades;
        private System.Windows.Forms.RadioButton rdo_Hearts;
        private System.Windows.Forms.RadioButton rdo_Diamond;
        private System.Windows.Forms.RadioButton rdo_Clubs;
        private System.Windows.Forms.Button btn_Play_card;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        }
    }