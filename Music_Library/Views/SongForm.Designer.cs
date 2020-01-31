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
            this.songsDataGridView = new System.Windows.Forms.DataGridView();
            this.songIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._Music_Library_MusicLibraryContextDataSet = new Music_Library._Music_Library_MusicLibraryContextDataSet();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textSongTitle = new System.Windows.Forms.TextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter2 = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.GenresTableAdapter();
            this.tableAdapterManager1 = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.genresBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.AlbumsTableAdapter();
            this.musicLibraryMusicLibraryContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songsTableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.SongsTableAdapter();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicLibraryMusicLibraryContextDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(9, 145);
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
            this.libraryToolStripMenuItem.Enabled = false;
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.libraryToolStripMenuItem.Text = "Library";
            // 
            // songsDataGridView
            // 
            this.songsDataGridView.AutoGenerateColumns = false;
            this.songsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn1,
            this.songTitleDataGridViewTextBoxColumn,
            this.albumIdDataGridViewTextBoxColumn1,
            this.genreIdDataGridViewTextBoxColumn1,
            this.pathDataGridViewTextBoxColumn});
            this.songsDataGridView.DataSource = this.songsBindingSource1;
            this.songsDataGridView.Location = new System.Drawing.Point(268, 85);
            this.songsDataGridView.Name = "songsDataGridView";
            this.songsDataGridView.Size = new System.Drawing.Size(520, 245);
            this.songsDataGridView.TabIndex = 21;
            this.songsDataGridView.DoubleClick += new System.EventHandler(this.songsDataGridView_DoubleClick);
            // 
            // songIdDataGridViewTextBoxColumn1
            // 
            this.songIdDataGridViewTextBoxColumn1.DataPropertyName = "SongId";
            this.songIdDataGridViewTextBoxColumn1.HeaderText = "SongId";
            this.songIdDataGridViewTextBoxColumn1.Name = "songIdDataGridViewTextBoxColumn1";
            this.songIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // songTitleDataGridViewTextBoxColumn
            // 
            this.songTitleDataGridViewTextBoxColumn.DataPropertyName = "SongTitle";
            this.songTitleDataGridViewTextBoxColumn.HeaderText = "SongTitle";
            this.songTitleDataGridViewTextBoxColumn.Name = "songTitleDataGridViewTextBoxColumn";
            // 
            // albumIdDataGridViewTextBoxColumn1
            // 
            this.albumIdDataGridViewTextBoxColumn1.DataPropertyName = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn1.HeaderText = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn1.Name = "albumIdDataGridViewTextBoxColumn1";
            // 
            // genreIdDataGridViewTextBoxColumn1
            // 
            this.genreIdDataGridViewTextBoxColumn1.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn1.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn1.Name = "genreIdDataGridViewTextBoxColumn1";
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // songsBindingSource1
            // 
            this.songsBindingSource1.DataMember = "Songs";
            this.songsBindingSource1.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // _Music_Library_MusicLibraryContextDataSet
            // 
            this._Music_Library_MusicLibraryContextDataSet.DataSetName = "_Music_Library_MusicLibraryContextDataSet";
            this._Music_Library_MusicLibraryContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // songIdDataGridViewTextBoxColumn
            // 
            this.songIdDataGridViewTextBoxColumn.DataPropertyName = "SongId";
            this.songIdDataGridViewTextBoxColumn.HeaderText = "SongId";
            this.songIdDataGridViewTextBoxColumn.Name = "songIdDataGridViewTextBoxColumn";
            this.songIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.buttonCancel.Location = new System.Drawing.Point(187, 307);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(106, 307);
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
            this.buttonSave.Location = new System.Drawing.Point(25, 307);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // textSongTitle
            // 
            this.textSongTitle.Location = new System.Drawing.Point(58, 85);
            this.textSongTitle.Name = "textSongTitle";
            this.textSongTitle.Size = new System.Drawing.Size(162, 20);
            this.textSongTitle.TabIndex = 14;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(10, 202);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(39, 13);
            this.labelAlbum.TabIndex = 13;
            this.labelAlbum.Text = "Album:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 88);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title:";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(Music_Library.Album);
            // 
            // albumComboBox
            // 
            this.albumComboBox.DataSource = this.albumsBindingSource;
            this.albumComboBox.DisplayMember = "AlbumTitle";
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(59, 199);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(162, 21);
            this.albumComboBox.TabIndex = 21;
            this.albumComboBox.ValueMember = "AlbumId";
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // genresTableAdapter2
            // 
            this.genresTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlbumsTableAdapter = null;
            this.tableAdapterManager1.ArtistsTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.GenresTableAdapter = this.genresTableAdapter2;
            this.tableAdapterManager1.SongsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataSource = this.genresBindingSource4;
            this.typeComboBox.DisplayMember = "Type";
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(57, 142);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(163, 21);
            this.typeComboBox.TabIndex = 22;
            this.typeComboBox.ValueMember = "GenreId";
            // 
            // genresBindingSource4
            // 
            this.genresBindingSource4.DataMember = "Genres";
            this.genresBindingSource4.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // musicLibraryMusicLibraryContextDataSetBindingSource
            // 
            this.musicLibraryMusicLibraryContextDataSetBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            this.musicLibraryMusicLibraryContextDataSetBindingSource.Position = 0;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(17, 258);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(26, 13);
            this.lblPath.TabIndex = 24;
            this.lblPath.Text = "File:";
            // 
            // txtFile
            // 
            this.txtFile.AllowDrop = true;
            this.txtFile.Location = new System.Drawing.Point(58, 255);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(163, 20);
            this.txtFile.TabIndex = 26;
            this.txtFile.Click += new System.EventHandler(this.ChooseFile);
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.albumComboBox);
            this.Controls.Add(this.songsDataGridView);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textSongTitle);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip2);
            this.Name = "SongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SongForm";
            this.Load += new System.EventHandler(this.SongForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicLibraryMusicLibraryContextDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView songsDataGridView;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textSongTitle;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.ComboBox albumComboBox;
        private _Music_Library_MusicLibraryContextDataSet _Music_Library_MusicLibraryContextDataSet;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.GenresTableAdapter genresTableAdapter2;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.BindingSource genresBindingSource4;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.BindingSource musicLibraryMusicLibraryContextDataSetBindingSource;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.BindingSource songsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
    }
}