using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: This line of code loads data into the 'music_LibraryDataSet2.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter3.Fill(this.music_LibraryDataSet2.Genres);
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter2.Fill(this._Music_Library_MusicLibraryContextDataSet.Genres);
            // TODO: This line of code loads data into the 'music_LibraryDataSet1.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter1.Fill(this.music_LibraryDataSet1.Genres);
            // TODO: This line of code loads data into the 'music_LibraryDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.music_LibraryDataSet.Genres);

        }
    }
}
