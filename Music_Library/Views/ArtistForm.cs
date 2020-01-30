using Music_Library.Views;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class ArtistForm : Form
    {
        private Artist artist = new Artist();

        public ArtistForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            artist.FirstName = textBoxFirstName.Text;
            artist.LastName = textBoxLastName.Text;
            artist.Age = Convert.ToInt32(textBoxAge.Text);

            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                if (artist.ArtistId == 0)
                {
                    musicLibraryContext.Artists.Add(artist);
                }
                else
                {
                    musicLibraryContext.Entry(artist).State = EntityState.Modified;
                }

                musicLibraryContext.SaveChanges();
            }

            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted successfuly");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete? ", "crud operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
                {
                    var entry = musicLibraryContext.Entry(artist);

                    if (entry.State == EntityState.Detached)
                    {
                        musicLibraryContext.Artists.Attach(artist);
                    }
                    musicLibraryContext.Artists.Remove(artist);
                    musicLibraryContext.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("deleted successfuly");
                }
            }
        }

        private void dataGridViewArtist_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewArtist.CurrentRow.Index != -1)
            {
                artist.ArtistId = Convert.ToInt32(dataGridViewArtist.CurrentRow.Cells["artistIdDataGridViewTextBoxColumn"].Value);

                using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
                {
                    artist = musicLibraryContext.Artists.Where(x => x.ArtistId == artist.ArtistId).FirstOrDefault();
                    textBoxFirstName.Text = artist.FirstName;
                    textBoxLastName.Text = artist.LastName;
                    textBoxAge.Text = Convert.ToString(artist.Age);
                }
                buttonSave.Text = "Update";
                buttonDelete.Enabled = true;
            }
        }

        private void PopulateDataGridView()
        {
            dataGridViewArtist.AutoGenerateColumns = false;
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                dataGridViewArtist.DataSource = musicLibraryContext.Artists.ToList<Artist>();
            }
        }

        private void Clear()
        {
            textBoxFirstName.Text = textBoxLastName.Text = textBoxAge.Text = "";
            buttonSave.Text = "Save";
            buttonDelete.Enabled = false;
            artist.ArtistId = 0;
        }

        private void ArtistForm_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void addAGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (GenreForm frm = new GenreForm())
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

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addASongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SongForm frm = new SongForm())
            {
                frm.ShowDialog();
            }
        }
    }
}