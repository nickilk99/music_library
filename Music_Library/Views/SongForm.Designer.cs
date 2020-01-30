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
            this.songDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textSongTitle = new System.Windows.Forms.TextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Music_Library_MusicLibraryContextDataSet = new Music_Library._Music_Library_MusicLibraryContextDataSet();
            this.albumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.music_LibraryDataSet = new Music_Library.Music_LibraryDataSet();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.music_LibraryDataSet1 = new Music_Library.Music_LibraryDataSet1();
            this.genresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter2 = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.GenresTableAdapter();
            this.tableAdapterManager1 = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.genresBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.music_LibraryDataSet2 = new Music_Library.Music_LibraryDataSet2();
            this.genresBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.AlbumsTableAdapter();
            typeLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_LibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_LibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(10, 215);
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
            this.menuStrip2.Size = new System.Drawing.Size(824, 24);
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
            // 
            // songDataGridView
            // 
            this.songDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView.Location = new System.Drawing.Point(268, 170);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.Size = new System.Drawing.Size(396, 138);
            this.songDataGridView.TabIndex = 21;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(187, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(106, 285);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Location = new System.Drawing.Point(25, 285);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textSongTitle
            // 
            this.textSongTitle.Location = new System.Drawing.Point(58, 185);
            this.textSongTitle.Name = "textSongTitle";
            this.textSongTitle.Size = new System.Drawing.Size(204, 20);
            this.textSongTitle.TabIndex = 14;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(12, 245);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(39, 13);
            this.labelAlbum.TabIndex = 13;
            this.labelAlbum.Text = "Album:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 192);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title:";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(Music_Library.Genre);
            // 
            // genreBindingSource1
            // 
            this.genreBindingSource1.DataSource = typeof(Music_Library.Genre);
            // 
            // genreBindingSource2
            // 
            this.genreBindingSource2.DataSource = typeof(Music_Library.Genre);
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
            this.albumComboBox.Location = new System.Drawing.Point(57, 237);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(205, 21);
            this.albumComboBox.TabIndex = 21;
            this.albumComboBox.ValueMember = "AlbumId";
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // _Music_Library_MusicLibraryContextDataSet
            // 
            this._Music_Library_MusicLibraryContextDataSet.DataSetName = "_Music_Library_MusicLibraryContextDataSet";
            this._Music_Library_MusicLibraryContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumBindingSource1
            // 
            this.albumBindingSource1.DataSource = typeof(Music_Library.Album);
            // 
            // music_LibraryDataSet
            // 
            this.music_LibraryDataSet.DataSetName = "Music_LibraryDataSet";
            this.music_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.music_LibraryDataSet;
            // 
            // genresTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
            // 
            // genresBindingSource1
            // 
            this.genresBindingSource1.DataMember = "Genres";
            this.genresBindingSource1.DataSource = this.music_LibraryDataSet1;
            // 
            // music_LibraryDataSet1
            // 
            this.music_LibraryDataSet1.DataSetName = "Music_LibraryDataSet1";
            this.music_LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresTableAdapter1
            // 
            // 
            // genresBindingSource2
            // 
            this.genresBindingSource2.DataMember = "Genres";
            this.genresBindingSource2.DataSource = this._Music_Library_MusicLibraryContextDataSet;
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
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genresBindingSource2, "Type", true));
            this.typeComboBox.DataSource = this.genresBindingSource4;
            this.typeComboBox.DisplayMember = "Type";
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(57, 212);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(205, 21);
            this.typeComboBox.TabIndex = 22;
            this.typeComboBox.ValueMember = "GenreId";
            // 
            // genresBindingSource4
            // 
            this.genresBindingSource4.DataMember = "Genres";
            this.genresBindingSource4.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // music_LibraryDataSet2
            // 
            this.music_LibraryDataSet2.DataSetName = "Music_LibraryDataSet2";
            this.music_LibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresBindingSource3
            // 
            this.genresBindingSource3.DataMember = "Genres";
            this.genresBindingSource3.DataSource = this.music_LibraryDataSet2;
            // 
            // albumBindingSource2
            // 
            this.albumBindingSource2.DataSource = typeof(Music_Library.Album);
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 633);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.albumComboBox);
            this.Controls.Add(this.songDataGridView);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textSongTitle);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip2);
            this.Name = "SongForm";
            this.Text = "SongForm";
            this.Load += new System.EventHandler(this.SongForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_LibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridView songDataGridView;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textSongTitle;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource genreBindingSource1;
        private System.Windows.Forms.BindingSource genreBindingSource2;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.ComboBox albumComboBox;
        private Music_LibraryDataSet music_LibraryDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private Music_LibraryDataSet1 music_LibraryDataSet1;
        private System.Windows.Forms.BindingSource genresBindingSource1;
        private _Music_Library_MusicLibraryContextDataSet _Music_Library_MusicLibraryContextDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource2;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.GenresTableAdapter genresTableAdapter2;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private Music_LibraryDataSet2 music_LibraryDataSet2;
        private System.Windows.Forms.BindingSource genresBindingSource3;
        private System.Windows.Forms.BindingSource genresBindingSource4;
        private System.Windows.Forms.BindingSource albumBindingSource1;
        private System.Windows.Forms.BindingSource albumBindingSource2;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
    }
}