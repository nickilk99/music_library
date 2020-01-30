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
    public partial class AlbumForm : Form
    {
        Album album = new Album();

        public AlbumForm()
        {
            InitializeComponent();
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete? ", "crud operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MusicLibraryContext ac = new MusicLibraryContext())
                {
                    var entry = ac.Entry(album);

                    if (entry.State == EntityState.Detached)
                    {
                        ac.Albums.Attach(album);
                    }
                    ac.Albums.Remove(album);
                    ac.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("deleted successfuly");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            album.AlbumTitle = txtAlbumTitle.Text;
            album.ArtistName = txtArtistName.Text;
            album.Year = Convert.ToInt32(txtYear.Text);
            album.Length = Convert.ToInt32(txtLength.Text);

            using (MusicLibraryContext ac = new MusicLibraryContext())
            {
                if (album.AlbumId == 0)
                {
                    ac.Albums.Add(album);
                }
                else
                {
                    ac.Entry(album).State = EntityState.Modified;
                }

                ac.SaveChanges();
            }

            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted successfuly");
        }



        void PopulateDataGridView()
        {
            dvgAlbum.AutoGenerateColumns = false;
            using (MusicLibraryContext ac = new MusicLibraryContext())
            {
                dvgAlbum.DataSource = ac.Albums.ToList<Album>();
            }

        }

        void Clear()
        {
            txtAlbumTitle.Text = txtArtistName.Text = txtLength.Text = txtYear.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            album.AlbumId = 0;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dvgAlbum.CurrentRow.Index != -1)
            {
                album.AlbumId = Convert.ToInt32(dvgAlbum.CurrentRow.Cells["albumIdDataGridViewTextBoxColumn1"].Value);

                using (MusicLibraryContext ac = new MusicLibraryContext())
                {
                    album = ac.Albums.Where(x => x.AlbumId == album.AlbumId).FirstOrDefault();
                    txtAlbumTitle.Text = album.AlbumTitle;
                    txtArtistName.Text = album.ArtistName;
                    txtYear.Text = Convert.ToString(album.Year);
                    txtLength.Text = Convert.ToString(album.Length);

                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
    }
}
