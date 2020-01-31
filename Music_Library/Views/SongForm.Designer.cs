namespace Music_Library.Views
{
    partial class SongForm
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
            System.Windows.Forms.Label typeLabel;
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addAGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSongTitle = new System.Windows.Forms.TextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSong = new System.Windows.Forms.DataGridView();
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            typeLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(14, 129);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(42, 13);
            typeLabel.TabIndex = 21;
            typeLabel.Text = "Genre: ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAGenreToolStripMenuItem,
            this.addAnArtistToolStripMenuItem,
            this.addAnAlbumToolStripMenuItem,
            this.addASongToolStripMenuItem,
            this.libraryToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addAGenreToolStripMenuItem
            // 
            this.addAGenreToolStripMenuItem.Name = "addAGenreToolStripMenuItem";
            this.addAGenreToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addAGenreToolStripMenuItem.Text = "Add a Genre";
            this.addAGenreToolStripMenuItem.Click += new System.EventHandler(this.addAGenreToolStripMenuItem_Click);
            // 
            // addAnArtistToolStripMenuItem
            // 
            this.addAnArtistToolStripMenuItem.Name = "addAnArtistToolStripMenuItem";
            this.addAnArtistToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.addAnArtistToolStripMenuItem.Text = "Add an Artist";
            this.addAnArtistToolStripMenuItem.Click += new System.EventHandler(this.addAnArtistToolStripMenuItem_Click);
            // 
            // addAnAlbumToolStripMenuItem
            // 
            this.addAnAlbumToolStripMenuItem.Name = "addAnAlbumToolStripMenuItem";
            this.addAnAlbumToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.addAnAlbumToolStripMenuItem.Text = "Add an Album";
            this.addAnAlbumToolStripMenuItem.Click += new System.EventHandler(this.addAnAlbumToolStripMenuItem_Click);
            // 
            // addASongToolStripMenuItem
            // 
            this.addASongToolStripMenuItem.Enabled = false;
            this.addASongToolStripMenuItem.Name = "addASongToolStripMenuItem";
            this.addASongToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.addASongToolStripMenuItem.Text = "Add a Song";
            this.addASongToolStripMenuItem.Click += new System.EventHandler(this.addASongToolStripMenuItem_Click);
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            this.libraryToolStripMenuItem.Click += new System.EventHandler(this.libraryToolStripMenuItem_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(191, 250);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(110, 250);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Location = new System.Drawing.Point(29, 250);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSongTitle
            // 
            this.textBoxSongTitle.Location = new System.Drawing.Point(62, 99);
            this.textBoxSongTitle.Name = "textBoxSongTitle";
            this.textBoxSongTitle.Size = new System.Drawing.Size(204, 20);
            this.textBoxSongTitle.TabIndex = 14;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(16, 159);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(39, 13);
            this.labelAlbum.TabIndex = 13;
            this.labelAlbum.Text = "Album:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(16, 106);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title:";
            // 
            // comboBoxAlbum
            // 
            this.comboBoxAlbum.DataSource = this.albumBindingSource;
            this.comboBoxAlbum.DisplayMember = "AlbumTitle";
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(61, 151);
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(205, 21);
            this.comboBoxAlbum.TabIndex = 21;
            this.comboBoxAlbum.ValueMember = "AlbumId";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(Music_Library.Album);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DataSource = this.genreBindingSource;
            this.comboBoxGenre.DisplayMember = "Type";
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(61, 126);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(205, 21);
            this.comboBoxGenre.TabIndex = 22;
            this.comboBoxGenre.ValueMember = "GenreId";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(Music_Library.Genre);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(20, 192);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(26, 13);
            this.lblPath.TabIndex = 24;
            this.lblPath.Text = "File:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.AllowDrop = true;
            this.textBoxPath.Location = new System.Drawing.Point(61, 214);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(205, 20);
            this.textBoxPath.TabIndex = 26;
            this.textBoxPath.Click += new System.EventHandler(this.ChooseFile);
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.albumBindingSource;
            // 
            // dataGridViewSong
            // 
            this.dataGridViewSong.AutoGenerateColumns = false;
            this.dataGridViewSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridViewSong.DataSource = this.songsBindingSource;
            this.dataGridViewSong.Location = new System.Drawing.Point(320, 99);
            this.dataGridViewSong.Name = "dataGridViewSong";
            this.dataGridViewSong.Size = new System.Drawing.Size(447, 220);
            this.dataGridViewSong.TabIndex = 26;
            this.dataGridViewSong.DoubleClick += new System.EventHandler(this.dataGridViewSong_DoubleClick);
            // 
            // songIdDataGridViewTextBoxColumn
            // 
            this.songIdDataGridViewTextBoxColumn.DataPropertyName = "SongId";
            this.songIdDataGridViewTextBoxColumn.HeaderText = "SongId";
            this.songIdDataGridViewTextBoxColumn.Name = "songIdDataGridViewTextBoxColumn";
            this.songIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SongTitle";
            this.dataGridViewTextBoxColumn7.HeaderText = "SongTitle";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AlbumId";
            this.dataGridViewTextBoxColumn8.HeaderText = "AlbumId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Album";
            this.dataGridViewTextBoxColumn9.HeaderText = "Album";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GenreId";
            this.dataGridViewTextBoxColumn10.HeaderText = "GenreId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn11.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Path";
            this.dataGridViewTextBoxColumn12.HeaderText = "Path";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(60, 186);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.ChooseFile);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.dataGridViewSong);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxAlbum);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSongTitle);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip2);
            this.Name = "SongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SongForm";
            this.Load += new System.EventHandler(this.SongForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addAGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addASongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSongTitle;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxAlbum;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        //private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}