namespace Music_Library.Views
{
    partial class Library
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
            this.vWSongAlbumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Music_Library_MusicLibraryContextDataSet = new Music_Library._Music_Library_MusicLibraryContextDataSet();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songsTableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.SongsTableAdapter();
            this.tableAdapterManager = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager();
            this.musicLibraryMusicLibraryContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbumTableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbumTableAdapter();
            this.vWSongAlbum1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbum1TableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum1TableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addAGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Music_Library_MusicLibraryContextDataSet1 = new Music_Library._Music_Library_MusicLibraryContextDataSet();
            this.vWSongAlbum2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbum2TableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum2TableAdapter();
            this.vWSongAlbum2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbum2DataGridView = new System.Windows.Forms.DataGridView();
            this.songTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicLibraryMusicLibraryContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum1BindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vWSongAlbumBindingSource
            // 
            this.vWSongAlbumBindingSource.DataMember = "VWSongAlbum";
            this.vWSongAlbumBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
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
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = null;
            this.tableAdapterManager.ArtistsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.SongsTableAdapter = this.songsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // musicLibraryMusicLibraryContextDataSetBindingSource
            // 
            this.musicLibraryMusicLibraryContextDataSetBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            this.musicLibraryMusicLibraryContextDataSetBindingSource.Position = 0;
            // 
            // vWSongAlbumTableAdapter
            // 
            this.vWSongAlbumTableAdapter.ClearBeforeFill = true;
            // 
            // vWSongAlbum1BindingSource
            // 
            this.vWSongAlbum1BindingSource.DataMember = "VWSongAlbum1";
            this.vWSongAlbum1BindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // vWSongAlbum1TableAdapter
            // 
            this.vWSongAlbum1TableAdapter.ClearBeforeFill = true;
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
            this.addAGenreToolStripMenuItem.Enabled = false;
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
            // _Music_Library_MusicLibraryContextDataSet1
            // 
            this._Music_Library_MusicLibraryContextDataSet1.DataSetName = "_Music_Library_MusicLibraryContextDataSet";
            this._Music_Library_MusicLibraryContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWSongAlbum2BindingSource
            // 
            this.vWSongAlbum2BindingSource.DataMember = "VWSongAlbum2";
            this.vWSongAlbum2BindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet1;
            // 
            // vWSongAlbum2TableAdapter
            // 
            this.vWSongAlbum2TableAdapter.ClearBeforeFill = true;
            // 
            // vWSongAlbum2BindingSource1
            // 
            this.vWSongAlbum2BindingSource1.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            this.vWSongAlbum2BindingSource1.Position = 0;
            // 
            // vWSongAlbum2DataGridView
            // 
            this.vWSongAlbum2DataGridView.AutoGenerateColumns = false;
            this.vWSongAlbum2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vWSongAlbum2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songTitleDataGridViewTextBoxColumn,
            this.albumTitleDataGridViewTextBoxColumn,
            this.coverDataGridViewImageColumn,
            this.artistNameDataGridViewTextBoxColumn});
            this.vWSongAlbum2DataGridView.DataSource = this.vWSongAlbum2BindingSource;
            this.vWSongAlbum2DataGridView.Location = new System.Drawing.Point(12, 27);
            this.vWSongAlbum2DataGridView.Name = "vWSongAlbum2DataGridView";
            this.vWSongAlbum2DataGridView.Size = new System.Drawing.Size(514, 360);
            this.vWSongAlbum2DataGridView.TabIndex = 3;
            // 
            // songTitleDataGridViewTextBoxColumn
            // 
            this.songTitleDataGridViewTextBoxColumn.DataPropertyName = "SongTitle";
            this.songTitleDataGridViewTextBoxColumn.HeaderText = "SongTitle";
            this.songTitleDataGridViewTextBoxColumn.Name = "songTitleDataGridViewTextBoxColumn";
            // 
            // albumTitleDataGridViewTextBoxColumn
            // 
            this.albumTitleDataGridViewTextBoxColumn.DataPropertyName = "AlbumTitle";
            this.albumTitleDataGridViewTextBoxColumn.HeaderText = "AlbumTitle";
            this.albumTitleDataGridViewTextBoxColumn.Name = "albumTitleDataGridViewTextBoxColumn";
            // 
            // coverDataGridViewImageColumn
            // 
            this.coverDataGridViewImageColumn.DataPropertyName = "Cover";
            this.coverDataGridViewImageColumn.HeaderText = "Cover";
            this.coverDataGridViewImageColumn.Name = "coverDataGridViewImageColumn";
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vWSongAlbum2DataGridView);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicLibraryMusicLibraryContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum1BindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Music_Library_MusicLibraryContextDataSet _Music_Library_MusicLibraryContextDataSet;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource musicLibraryMusicLibraryContextDataSetBindingSource;
        private System.Windows.Forms.BindingSource vWSongAlbumBindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbumTableAdapter vWSongAlbumTableAdapter;
        private System.Windows.Forms.BindingSource vWSongAlbum1BindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum1TableAdapter vWSongAlbum1TableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addAGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addASongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private _Music_Library_MusicLibraryContextDataSet _Music_Library_MusicLibraryContextDataSet1;
        private System.Windows.Forms.BindingSource vWSongAlbum2BindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum2TableAdapter vWSongAlbum2TableAdapter;
        private System.Windows.Forms.BindingSource vWSongAlbum2BindingSource1;
        private System.Windows.Forms.DataGridView vWSongAlbum2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn songTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn coverDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
    }
}