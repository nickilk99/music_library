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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.vWSongAlbum2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addAGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.vWSongAlbum3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbum3TableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum3TableAdapter();
            this.vWSongAlbum3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Music_Library_MusicLibraryContextDataSet = new Music_Library._Music_Library_MusicLibraryContextDataSet();
            this.vWSongAlbum2TableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum2TableAdapter();
            this.vWSongAlbum1TableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum1TableAdapter();
            this.vWSongAlbum1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbumTableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbumTableAdapter();
            this.musicLibraryMusicLibraryContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager();
            this.songsTableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.SongsTableAdapter();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbum2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbum4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWSongAlbum4TableAdapter = new Music_Library._Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum4TableAdapter();
            this.vWSongAlbum4DataGridView = new System.Windows.Forms.DataGridView();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtPlay = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicLibraryMusicLibraryContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum4DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(263, 292);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(246, 44);
            this.WMP.TabIndex = 4;
            this.WMP.Enter += new System.EventHandler(this.WMP_Enter);
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
            this.menuStrip2.Size = new System.Drawing.Size(808, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // vWSongAlbum3TableAdapter
            // 
            this.vWSongAlbum3TableAdapter.ClearBeforeFill = true;
            // 
            // vWSongAlbum3BindingSource
            // 
            this.vWSongAlbum3BindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            this.vWSongAlbum3BindingSource.Position = 0;
            // 
            // _Music_Library_MusicLibraryContextDataSet
            // 
            this._Music_Library_MusicLibraryContextDataSet.DataSetName = "_Music_Library_MusicLibraryContextDataSet";
            this._Music_Library_MusicLibraryContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWSongAlbum2TableAdapter
            // 
            this.vWSongAlbum2TableAdapter.ClearBeforeFill = true;
            // 
            // vWSongAlbum1TableAdapter
            // 
            this.vWSongAlbum1TableAdapter.ClearBeforeFill = true;
            // 
            // vWSongAlbum1BindingSource
            // 
            this.vWSongAlbum1BindingSource.DataMember = "VWSongAlbum1";
            this.vWSongAlbum1BindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // vWSongAlbumTableAdapter
            // 
            this.vWSongAlbumTableAdapter.ClearBeforeFill = true;
            // 
            // musicLibraryMusicLibraryContextDataSetBindingSource
            // 
            this.musicLibraryMusicLibraryContextDataSetBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            this.musicLibraryMusicLibraryContextDataSetBindingSource.Position = 0;
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
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // vWSongAlbumBindingSource
            // 
            this.vWSongAlbumBindingSource.DataMember = "VWSongAlbum";
            this.vWSongAlbumBindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // vWSongAlbum2BindingSource1
            // 
            this.vWSongAlbum2BindingSource1.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            this.vWSongAlbum2BindingSource1.Position = 0;
            // 
            // vWSongAlbum4BindingSource
            // 
            this.vWSongAlbum4BindingSource.DataMember = "VWSongAlbum4";
            this.vWSongAlbum4BindingSource.DataSource = this._Music_Library_MusicLibraryContextDataSet;
            // 
            // vWSongAlbum4TableAdapter
            // 
            this.vWSongAlbum4TableAdapter.ClearBeforeFill = true;
            // 
            // vWSongAlbum4DataGridView
            // 
            this.vWSongAlbum4DataGridView.AutoGenerateColumns = false;
            this.vWSongAlbum4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vWSongAlbum4DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vWSongAlbum4DataGridView.DataSource = this.vWSongAlbum4BindingSource;
            this.vWSongAlbum4DataGridView.Location = new System.Drawing.Point(12, 27);
            this.vWSongAlbum4DataGridView.Name = "vWSongAlbum4DataGridView";
            this.vWSongAlbum4DataGridView.Size = new System.Drawing.Size(784, 220);
            this.vWSongAlbum4DataGridView.TabIndex = 4;
            this.vWSongAlbum4DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vWSongAlbum4DataGridView_CellContentClick);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(13, 266);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play Song";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtPlay
            // 
            this.txtPlay.Location = new System.Drawing.Point(106, 268);
            this.txtPlay.Name = "txtPlay";
            this.txtPlay.Size = new System.Drawing.Size(100, 20);
            this.txtPlay.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SongTitle";
            this.dataGridViewTextBoxColumn1.HeaderText = "SongTitle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AlbumTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "AlbumTitle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Cover";
            this.dataGridViewImageColumn1.HeaderText = "Cover";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ArtistName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ArtistName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Path";
            this.dataGridViewTextBoxColumn4.HeaderText = "Path";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.txtPlay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.vWSongAlbum4DataGridView);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Music_Library_MusicLibraryContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicLibraryMusicLibraryContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSongAlbum4DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum3TableAdapter vWSongAlbum3TableAdapter;
        private System.Windows.Forms.BindingSource vWSongAlbum3BindingSource;
        private _Music_Library_MusicLibraryContextDataSet _Music_Library_MusicLibraryContextDataSet;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum2TableAdapter vWSongAlbum2TableAdapter;
        private System.Windows.Forms.BindingSource vWSongAlbum2BindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum1TableAdapter vWSongAlbum1TableAdapter;
        private System.Windows.Forms.BindingSource vWSongAlbum1BindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbumTableAdapter vWSongAlbumTableAdapter;
        private System.Windows.Forms.BindingSource musicLibraryMusicLibraryContextDataSetBindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.SongsTableAdapter songsTableAdapter;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private System.Windows.Forms.BindingSource vWSongAlbumBindingSource;
        private System.Windows.Forms.ToolStripMenuItem addAGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addASongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.BindingSource vWSongAlbum3BindingSource1;
        private System.Windows.Forms.BindingSource vWSongAlbum2BindingSource1;
        private System.Windows.Forms.BindingSource vWSongAlbum4BindingSource;
        private _Music_Library_MusicLibraryContextDataSetTableAdapters.VWSongAlbum4TableAdapter vWSongAlbum4TableAdapter;
        private System.Windows.Forms.DataGridView vWSongAlbum4DataGridView;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}