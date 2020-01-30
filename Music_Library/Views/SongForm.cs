using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Music_Library.Views
{
    public partial class SongForm : Form
    {
        Song song = new Song();
        public SongForm()
        {
            InitializeComponent();
        }

        private void FrmAddSong_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        void Clear()
        {
            textSongTitle.Text = "";
            buttonSave.Text = "Save";
            buttonDelete.Enabled = false;
            song.SongId = 0;
        }

        void PopulateDataGridView()
        {
            songDataGridView.AutoGenerateColumns = false;
            using (MusicLibraryContext ac = new MusicLibraryContext())
            {
                songDataGridView.DataSource = ac.Songs.ToList<Song>();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void addAGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (GenreForm frm = new GenreForm())
            {
                frm.ShowDialog();
            }
        }

        private void addAnArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ArtistForm frm = new ArtistForm())
            {
                frm.ShowDialog();
            }
        }

        private void addAnAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AlbumForm frm = new AlbumForm())
            {
                frm.ShowDialog();
            }
        }

        private void addASongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SongForm frm = new SongForm())
            {
                frm.ShowDialog();
            }
        }

        private void SongForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.Songs);
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.Songs);
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.Albums);
            // TODO: This line of code loads data into the 'music_LibraryDataSet2.Genres' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter2.Fill(this._Music_Library_MusicLibraryContextDataSet.Genres);

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            song.Title = textSongTitle.Text.Trim();
            song.AlbumId = Convert.ToInt32(albumComboBox.SelectedValue);
            song.GenreId = Convert.ToInt32(typeComboBox.SelectedValue);
            using (MusicLibraryContext db = new MusicLibraryContext())
            {


                if (song.SongId == 0)
                {
                    db.Songs.Add(song);
                }
                else
                {
                    db.Entry(song).State = EntityState.Modified;
                }
                db.SaveChanges();
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Song entered successfully!");



            }
        }
    }
}
