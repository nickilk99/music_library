using Music_Library.Views;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class GenreForm : Form
    {
        private MusicLibraryContext _context;
        private Genre genre = new Genre();

        public GenreForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new MusicLibraryContext();

            //load categories from db
            _context.Genres.Load();

            //bind the data to the source
            this.genreBindingSource.DataSource = _context.Genres.Local.ToBindingList();

            btnDeleteGenre.Enabled = false;
        }

        private void addAGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (GenreForm frm = new GenreForm())
            {
                frm.ShowDialog();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //dispose context and close connection
            this._context.Dispose();
        }

        public void Clear()
        {
            this.txtType.Text = " ";
            btnsaveGenre.Text = "Save";
            btnDeleteGenre.Enabled = false;
            genre.GenreId = 0;
        }

        public void PopulateGenreList()
        {
            using (MusicLibraryContext db = new MusicLibraryContext())
            {
                genreDataGridView.DataSource = db.Genres.ToList<Genre>();
            }
        }

        private void genreDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (genreDataGridView.CurrentRow.Index != 1)
            {
                int tempNum = Convert.ToInt32(genreDataGridView.CurrentRow.Cells["GenreId"].Value);

                genre = (Genre)MusicLibraryOperation.createOperation(TYPE.GENRE).Get(tempNum);
                if (genre == null)
                {
                    Message.show("Could not find this information.", MESSAGE_TYPE.FAILURE);
                    return;
                }
                txtType.Text = genre.Type;
                btnsaveGenre.Text = "Update";
                btnDeleteGenre.Enabled = true;
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (Message.show("Are you sure you want to delete?", MESSAGE_TYPE.ADVISORY) == DialogResult.Yes)
            {
                int tempNum = MusicLibraryOperation.createOperation(TYPE.GENRE).Delete(genre);
                if (tempNum > 0)
                {
                    Message.show("Deleted successfully.", MESSAGE_TYPE.SUCCESS);
                }
                else
                {
                    Message.show("Failed to delete.", MESSAGE_TYPE.FAILURE);
                }
                PopulateGenreList();
                Clear();
            }
        }

        private void btnsaveGenre_Click(object sender, EventArgs e)
        {
            genre.Type = txtType.Text.Trim();
            if (Validate(txtType.Text)) {
                int tempNum;
                if (genre.GenreId == 0)
                {
                    tempNum = MusicLibraryOperation.createOperation(TYPE.GENRE).Add(genre);
                }
                else
                {
                    tempNum = MusicLibraryOperation.createOperation(TYPE.GENRE).Update(genre);
                }

                if (tempNum > 0)
                {
                    Message.show("Submitted successfully.", MESSAGE_TYPE.SUCCESS);
                }
                else
                {
                    Message.show("Submission Failed.", MESSAGE_TYPE.FAILURE);
                }
                Clear();
                PopulateGenreList();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void addAnAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AlbumForm frm = new AlbumForm())
            {
                frm.ShowDialog();
            }
        }

        private bool Validate(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                errorProvider1.SetError(txtType, "Please enter data");
                return false;
            }
            return true;
        }

        private void addASongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SongForm frm = new SongForm())
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

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Library frm = new Library())
            {
                frm.ShowDialog();
            }
        }

        private void genreDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}