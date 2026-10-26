namespace Game_test_2
{
    partial class Game
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
            this.tableChinh = new System.Windows.Forms.TableLayoutPanel();
            this.tableMenu = new System.Windows.Forms.TableLayoutPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.bttVao = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttChoiLai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableGame = new System.Windows.Forms.TableLayoutPanel();
            this.picHole9 = new System.Windows.Forms.PictureBox();
            this.picHole8 = new System.Windows.Forms.PictureBox();
            this.picHole7 = new System.Windows.Forms.PictureBox();
            this.picHole6 = new System.Windows.Forms.PictureBox();
            this.picHole5 = new System.Windows.Forms.PictureBox();
            this.picHole4 = new System.Windows.Forms.PictureBox();
            this.picHole3 = new System.Windows.Forms.PictureBox();
            this.picHole2 = new System.Windows.Forms.PictureBox();
            this.picHole1 = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.tableChinh.SuspendLayout();
            this.tableMenu.SuspendLayout();
            this.tableGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHole9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableChinh
            // 
            this.tableChinh.ColumnCount = 1;
            this.tableChinh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableChinh.Controls.Add(this.tableMenu, 0, 0);
            this.tableChinh.Controls.Add(this.tableGame, 0, 1);
            this.tableChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableChinh.Location = new System.Drawing.Point(0, 0);
            this.tableChinh.Name = "tableChinh";
            this.tableChinh.Padding = new System.Windows.Forms.Padding(10);
            this.tableChinh.RowCount = 2;
            this.tableChinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableChinh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableChinh.Size = new System.Drawing.Size(782, 553);
            this.tableChinh.TabIndex = 0;
            // 
            // tableMenu
            // 
            this.tableMenu.ColumnCount = 4;
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableMenu.Controls.Add(this.lblTime, 2, 0);
            this.tableMenu.Controls.Add(this.label1, 0, 0);
            this.tableMenu.Controls.Add(this.lblScore, 1, 0);
            this.tableMenu.Controls.Add(this.cmbDifficulty, 0, 1);
            this.tableMenu.Controls.Add(this.bttVao, 1, 1);
            this.tableMenu.Controls.Add(this.bttThoat, 3, 1);
            this.tableMenu.Controls.Add(this.bttChoiLai, 2, 1);
            this.tableMenu.Controls.Add(this.button1, 3, 0);
            this.tableMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenu.Location = new System.Drawing.Point(13, 13);
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.Padding = new System.Windows.Forms.Padding(6);
            this.tableMenu.RowCount = 2;
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMenu.Size = new System.Drawing.Size(756, 104);
            this.tableMenu.TabIndex = 0;
            this.tableMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.tableMenu_Paint);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTime.Location = new System.Drawing.Point(304, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(104, 30);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time: 30s";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đập Chuột";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblScore.Location = new System.Drawing.Point(136, 14);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 30);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDifficulty.DropDownWidth = 120;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Dễ",
            "Thường",
            "Khó"});
            this.cmbDifficulty.Location = new System.Drawing.Point(9, 61);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 36);
            this.cmbDifficulty.TabIndex = 4;
            this.cmbDifficulty.Text = "Độ Khó";
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // bttVao
            // 
            this.bttVao.BackColor = System.Drawing.Color.LimeGreen;
            this.bttVao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVao.ForeColor = System.Drawing.Color.MintCream;
            this.bttVao.Location = new System.Drawing.Point(136, 55);
            this.bttVao.Name = "bttVao";
            this.bttVao.Size = new System.Drawing.Size(162, 39);
            this.bttVao.TabIndex = 8;
            this.bttVao.Text = "Bắt Đầu";
            this.bttVao.UseVisualStyleBackColor = false;
            this.bttVao.Click += new System.EventHandler(this.bttVao_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bttThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttThoat.ForeColor = System.Drawing.Color.MintCream;
            this.bttThoat.Location = new System.Drawing.Point(528, 55);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(219, 39);
            this.bttThoat.TabIndex = 6;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttChoiLai
            // 
            this.bttChoiLai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bttChoiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttChoiLai.ForeColor = System.Drawing.Color.MintCream;
            this.bttChoiLai.Location = new System.Drawing.Point(304, 55);
            this.bttChoiLai.Name = "bttChoiLai";
            this.bttChoiLai.Size = new System.Drawing.Size(213, 39);
            this.bttChoiLai.TabIndex = 12;
            this.bttChoiLai.Text = "Chơi lại";
            this.bttChoiLai.UseVisualStyleBackColor = false;
            this.bttChoiLai.Click += new System.EventHandler(this.bttChoiLai_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(528, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tạm dừng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableGame
            // 
            this.tableGame.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableGame.ColumnCount = 3;
            this.tableGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableGame.Controls.Add(this.picHole9, 2, 2);
            this.tableGame.Controls.Add(this.picHole8, 1, 2);
            this.tableGame.Controls.Add(this.picHole7, 0, 2);
            this.tableGame.Controls.Add(this.picHole6, 2, 1);
            this.tableGame.Controls.Add(this.picHole5, 1, 1);
            this.tableGame.Controls.Add(this.picHole4, 0, 1);
            this.tableGame.Controls.Add(this.picHole3, 2, 0);
            this.tableGame.Controls.Add(this.picHole2, 1, 0);
            this.tableGame.Controls.Add(this.picHole1, 0, 0);
            this.tableGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGame.Location = new System.Drawing.Point(13, 123);
            this.tableGame.Name = "tableGame";
            this.tableGame.Padding = new System.Windows.Forms.Padding(8);
            this.tableGame.RowCount = 3;
            this.tableGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableGame.Size = new System.Drawing.Size(756, 417);
            this.tableGame.TabIndex = 1;
            // 
            // picHole9
            // 
            this.picHole9.AccessibleName = "hole 9";
            this.picHole9.BackColor = System.Drawing.Color.Transparent;
            this.picHole9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole9.ErrorImage = null;
            this.picHole9.Image = global::Game_test_2.Properties.Resources.hole_2;
            this.picHole9.InitialImage = null;
            this.picHole9.Location = new System.Drawing.Point(507, 281);
            this.picHole9.Margin = new System.Windows.Forms.Padding(6);
            this.picHole9.Name = "picHole9";
            this.picHole9.Size = new System.Drawing.Size(234, 121);
            this.picHole9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole9.TabIndex = 8;
            this.picHole9.TabStop = false;
            this.picHole9.Tag = "9";
            // 
            // picHole8
            // 
            this.picHole8.AccessibleName = "hole 8";
            this.picHole8.BackColor = System.Drawing.Color.Transparent;
            this.picHole8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole8.ErrorImage = null;
            this.picHole8.Image = global::Game_test_2.Properties.Resources.hole_11;
            this.picHole8.InitialImage = null;
            this.picHole8.Location = new System.Drawing.Point(261, 281);
            this.picHole8.Margin = new System.Windows.Forms.Padding(6);
            this.picHole8.Name = "picHole8";
            this.picHole8.Size = new System.Drawing.Size(233, 121);
            this.picHole8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole8.TabIndex = 7;
            this.picHole8.TabStop = false;
            this.picHole8.Tag = "8";
            // 
            // picHole7
            // 
            this.picHole7.AccessibleName = "hole 7";
            this.picHole7.BackColor = System.Drawing.Color.Transparent;
            this.picHole7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole7.ErrorImage = null;
            this.picHole7.Image = global::Game_test_2.Properties.Resources.hole_3;
            this.picHole7.InitialImage = null;
            this.picHole7.Location = new System.Drawing.Point(15, 281);
            this.picHole7.Margin = new System.Windows.Forms.Padding(6);
            this.picHole7.Name = "picHole7";
            this.picHole7.Size = new System.Drawing.Size(233, 121);
            this.picHole7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole7.TabIndex = 6;
            this.picHole7.TabStop = false;
            this.picHole7.Tag = "7";
            // 
            // picHole6
            // 
            this.picHole6.AccessibleName = "hole 6";
            this.picHole6.BackColor = System.Drawing.Color.Transparent;
            this.picHole6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole6.ErrorImage = null;
            this.picHole6.Image = global::Game_test_2.Properties.Resources.hole_3;
            this.picHole6.InitialImage = null;
            this.picHole6.Location = new System.Drawing.Point(507, 148);
            this.picHole6.Margin = new System.Windows.Forms.Padding(6);
            this.picHole6.Name = "picHole6";
            this.picHole6.Size = new System.Drawing.Size(234, 120);
            this.picHole6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole6.TabIndex = 5;
            this.picHole6.TabStop = false;
            this.picHole6.Tag = "6";
            // 
            // picHole5
            // 
            this.picHole5.AccessibleName = "hole 5";
            this.picHole5.BackColor = System.Drawing.Color.Transparent;
            this.picHole5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole5.ErrorImage = null;
            this.picHole5.Image = global::Game_test_2.Properties.Resources.hole_11;
            this.picHole5.InitialImage = null;
            this.picHole5.Location = new System.Drawing.Point(261, 148);
            this.picHole5.Margin = new System.Windows.Forms.Padding(6);
            this.picHole5.Name = "picHole5";
            this.picHole5.Size = new System.Drawing.Size(233, 120);
            this.picHole5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole5.TabIndex = 4;
            this.picHole5.TabStop = false;
            this.picHole5.Tag = "5";
            // 
            // picHole4
            // 
            this.picHole4.AccessibleName = "hole 4";
            this.picHole4.BackColor = System.Drawing.Color.Transparent;
            this.picHole4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole4.ErrorImage = null;
            this.picHole4.Image = global::Game_test_2.Properties.Resources.hole_2;
            this.picHole4.InitialImage = null;
            this.picHole4.Location = new System.Drawing.Point(15, 148);
            this.picHole4.Margin = new System.Windows.Forms.Padding(6);
            this.picHole4.Name = "picHole4";
            this.picHole4.Size = new System.Drawing.Size(233, 120);
            this.picHole4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole4.TabIndex = 3;
            this.picHole4.TabStop = false;
            this.picHole4.Tag = "4";
            // 
            // picHole3
            // 
            this.picHole3.AccessibleName = "hole 3";
            this.picHole3.BackColor = System.Drawing.Color.Transparent;
            this.picHole3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole3.ErrorImage = null;
            this.picHole3.Image = global::Game_test_2.Properties.Resources.hole_2;
            this.picHole3.InitialImage = null;
            this.picHole3.Location = new System.Drawing.Point(507, 15);
            this.picHole3.Margin = new System.Windows.Forms.Padding(6);
            this.picHole3.Name = "picHole3";
            this.picHole3.Size = new System.Drawing.Size(234, 120);
            this.picHole3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole3.TabIndex = 2;
            this.picHole3.TabStop = false;
            this.picHole3.Tag = "3";
            // 
            // picHole2
            // 
            this.picHole2.AccessibleName = "hole 2";
            this.picHole2.BackColor = System.Drawing.Color.Transparent;
            this.picHole2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole2.ErrorImage = null;
            this.picHole2.Image = global::Game_test_2.Properties.Resources.hole_3;
            this.picHole2.InitialImage = null;
            this.picHole2.Location = new System.Drawing.Point(261, 15);
            this.picHole2.Margin = new System.Windows.Forms.Padding(6);
            this.picHole2.Name = "picHole2";
            this.picHole2.Size = new System.Drawing.Size(233, 120);
            this.picHole2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole2.TabIndex = 1;
            this.picHole2.TabStop = false;
            this.picHole2.Tag = "2";
            // 
            // picHole1
            // 
            this.picHole1.AccessibleName = "hole 1";
            this.picHole1.BackColor = System.Drawing.Color.Transparent;
            this.picHole1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHole1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHole1.ErrorImage = null;
            this.picHole1.Image = global::Game_test_2.Properties.Resources.hole_1;
            this.picHole1.InitialImage = null;
            this.picHole1.Location = new System.Drawing.Point(15, 15);
            this.picHole1.Margin = new System.Windows.Forms.Padding(6);
            this.picHole1.Name = "picHole1";
            this.picHole1.Size = new System.Drawing.Size(233, 120);
            this.picHole1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHole1.TabIndex = 0;
            this.picHole1.TabStop = false;
            this.picHole1.Tag = "1";
            // 
            // gametimer
            // 
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tableChinh);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.tableChinh.ResumeLayout(false);
            this.tableMenu.ResumeLayout(false);
            this.tableMenu.PerformLayout();
            this.tableGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHole9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHole1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableChinh;
        private System.Windows.Forms.TableLayoutPanel tableMenu;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttVao;
        private System.Windows.Forms.TableLayoutPanel tableGame;
        private System.Windows.Forms.PictureBox picHole1;
        private System.Windows.Forms.PictureBox picHole2;
        private System.Windows.Forms.PictureBox picHole9;
        private System.Windows.Forms.PictureBox picHole8;
        private System.Windows.Forms.PictureBox picHole7;
        private System.Windows.Forms.PictureBox picHole6;
        private System.Windows.Forms.PictureBox picHole5;
        private System.Windows.Forms.PictureBox picHole4;
        private System.Windows.Forms.PictureBox picHole3;
        private System.Windows.Forms.Button bttChoiLai;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Button button1;
    }
}