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

namespace Music_Library
{
    public partial class FrmAddGenre : Form
    {
        MusicLibraryContext _context;
        Genre genre = new Genre();
        public FrmAddGenre()
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

        }

        private void addAGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmAddGenre frm = new FrmAddGenre())
            {
                frm.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void genreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {



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

        private void genreDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void genreDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (genreDataGridView.CurrentRow.Index != 1)
            {
                genre.GenreId = Convert.ToInt32(genreDataGridView.CurrentRow.Cells["GenreId"].Value);
                using (MusicLibraryContext db = new MusicLibraryContext())
                {
                    genre = db.Genres.Where(x => x.GenreId == genre.GenreId).FirstOrDefault();
                    txtType.Text = genre.Type;
                }
                btnsaveGenre.Text = "Update";
                btnDeleteGenre.Enabled = true;
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Test", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MusicLibraryContext db = new MusicLibraryContext())
                {
                    var entry = db.Entry(genre);
                    if(entry.State == EntityState.Detached)
                    {
                        db.Genres.Attach(genre);
                    }
                    db.Genres.Remove(genre);
                    db.SaveChanges();
                    PopulateGenreList();
                    Clear();
                    MessageBox.Show("Genre Deleted!");
                }
            }
        }

        private void btnsaveGenre_Click(object sender, EventArgs e)
        {
            genre.Type = txtType.Text.Trim();
            using (MusicLibraryContext db = new MusicLibraryContext())
            {
                if (genre.GenreId == 0)
                {
                    db.Genres.Add(genre);

                }
                else
                {
                    db.Entry(genre).State = EntityState.Modified;
                }
                db.SaveChanges();


            }


            Clear();
            PopulateGenreList();
            MessageBox.Show("Genre entered successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
