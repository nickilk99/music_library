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
using System.IO;

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

        private byte[] ConvertFileToByte(string spath) {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(spath);
            long numBytes = fInfo.Length;
            FileStream fs = new FileStream(spath,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            data = br.ReadBytes((int)numBytes);

            return data;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            album.AlbumTitle = txtAlbumTitle.Text;
            album.ArtistName = txtArtistName.Text;
            album.Year = Convert.ToInt32(txtYear.Text);
            album.Length = Convert.ToInt32(txtLength.Text);
            album.Cover = ConvertFileToByte(this.pictureBoxPhoto.ImageLocation);

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
            pictureBoxPhoto.Image = null;
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
                    var img = new MemoryStream(album.Cover);
                    pictureBoxPhoto.Image = Image.FromStream(img);
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void addAGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (GenreForm frm = new GenreForm())
            {
                frm.ShowDialog();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Cover";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBoxPhoto.ImageLocation = ofd.FileName;
            }

        }
    }
}
