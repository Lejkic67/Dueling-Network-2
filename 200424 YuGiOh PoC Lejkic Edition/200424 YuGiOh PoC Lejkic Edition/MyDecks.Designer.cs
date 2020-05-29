namespace _200424_YuGiOh_PoC_Lejkic_Edition
{
    partial class FrmMyDecks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyDecks));
            this.lblMain = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.lbExtra = new System.Windows.Forms.ListBox();
            this.lvSve = new System.Windows.Forms.ListView();
            this.ilSve = new System.Windows.Forms.ImageList(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.ilSearch = new System.Windows.Forms.ImageList(this.components);
            this.pbSelCard = new System.Windows.Forms.PictureBox();
            this.rtbSelCardInfo = new System.Windows.Forms.RichTextBox();
            this.lblCardName = new System.Windows.Forms.Label();
            this.cbDeckovi = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNameDeck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMain.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(404, 21);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(131, 32);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Main Deck";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.BackColor = System.Drawing.Color.Transparent;
            this.lblList.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(834, 21);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(88, 32);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "Search";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblExtra.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra.Location = new System.Drawing.Point(404, 283);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(131, 32);
            this.lblExtra.TabIndex = 4;
            this.lblExtra.Text = "Extra Deck";
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(248, 60);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(446, 212);
            this.lbMain.TabIndex = 6;
            this.lbMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbMain_MouseClick);
            this.lbMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbMain_MouseDoubleClick);
            // 
            // lbExtra
            // 
            this.lbExtra.FormattingEnabled = true;
            this.lbExtra.Location = new System.Drawing.Point(248, 321);
            this.lbExtra.Name = "lbExtra";
            this.lbExtra.Size = new System.Drawing.Size(446, 121);
            this.lbExtra.TabIndex = 8;
            this.lbExtra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbExtra_MouseClick);
            this.lbExtra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbExtra_MouseDoubleClick);
            // 
            // lvSve
            // 
            this.lvSve.HideSelection = false;
            this.lvSve.Location = new System.Drawing.Point(760, 99);
            this.lvSve.Name = "lvSve";
            this.lvSve.Size = new System.Drawing.Size(229, 368);
            this.lvSve.TabIndex = 9;
            this.lvSve.UseCompatibleStateImageBehavior = false;
            this.lvSve.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSve_MouseClick);
            this.lvSve.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSve_MouseDoubleClick);
            // 
            // ilSve
            // 
            this.ilSve.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilSve.ImageSize = new System.Drawing.Size(16, 16);
            this.ilSve.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(760, 60);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(229, 20);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // ilSearch
            // 
            this.ilSearch.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilSearch.ImageSize = new System.Drawing.Size(16, 16);
            this.ilSearch.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbSelCard
            // 
            this.pbSelCard.Location = new System.Drawing.Point(36, 60);
            this.pbSelCard.Name = "pbSelCard";
            this.pbSelCard.Size = new System.Drawing.Size(160, 230);
            this.pbSelCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelCard.TabIndex = 11;
            this.pbSelCard.TabStop = false;
            // 
            // rtbSelCardInfo
            // 
            this.rtbSelCardInfo.BackColor = System.Drawing.SystemColors.Window;
            this.rtbSelCardInfo.Location = new System.Drawing.Point(36, 321);
            this.rtbSelCardInfo.Name = "rtbSelCardInfo";
            this.rtbSelCardInfo.Size = new System.Drawing.Size(160, 146);
            this.rtbSelCardInfo.TabIndex = 12;
            this.rtbSelCardInfo.Text = "";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.BackColor = System.Drawing.Color.Transparent;
            this.lblCardName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(70, 36);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(0, 21);
            this.lblCardName.TabIndex = 13;
            // 
            // cbDeckovi
            // 
            this.cbDeckovi.FormattingEnabled = true;
            this.cbDeckovi.Location = new System.Drawing.Point(613, 12);
            this.cbDeckovi.Name = "cbDeckovi";
            this.cbDeckovi.Size = new System.Drawing.Size(121, 21);
            this.cbDeckovi.TabIndex = 14;
            this.cbDeckovi.SelectedIndexChanged += new System.EventHandler(this.cbDeckovi_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(597, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbNameDeck
            // 
            this.tbNameDeck.Location = new System.Drawing.Point(389, 463);
            this.tbNameDeck.Name = "tbNameDeck";
            this.tbNameDeck.Size = new System.Drawing.Size(133, 20);
            this.tbNameDeck.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name :";
            // 
            // FrmMyDecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameDeck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbDeckovi);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.rtbSelCardInfo);
            this.Controls.Add(this.pbSelCard);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lvSve);
            this.Controls.Add(this.lbExtra);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMyDecks";
            this.Text = "MyDecks";
            ((System.ComponentModel.ISupportInitialize)(this.pbSelCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.ListBox lbExtra;
        private System.Windows.Forms.ListView lvSve;
        private System.Windows.Forms.ImageList ilSve;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ImageList ilSearch;
        private System.Windows.Forms.PictureBox pbSelCard;
        private System.Windows.Forms.RichTextBox rtbSelCardInfo;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.ComboBox cbDeckovi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNameDeck;
        private System.Windows.Forms.Label label1;
    }
}