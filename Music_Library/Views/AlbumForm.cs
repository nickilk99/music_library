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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Music_Library.Views;

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
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.Artists' table. You can move, or remove it, as needed.
            this.artistsTableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.Artists);
            //dvgAlbum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dvgAlbum.RowTemplate.Height = 75;
            Clear();
            PopulateDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Message.show("Are you sure you want to delete?", MESSAGE_TYPE.ADVISORY) == DialogResult.Yes)
            {
                int tempNum = MusicLibraryOperation.createOperation(TYPE.ALBUM).Delete(album);
                if (tempNum > 0)
                {
                    Message.show("Deleted successfully.", MESSAGE_TYPE.SUCCESS);
                }
                else
                {
                    Message.show("Failed to delete.", MESSAGE_TYPE.FAILURE);
                }
                PopulateDataGridView();
                Clear();
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

            if (Validate(txtAlbumTitle.Text) && Validate(txtLength.Text) && Validate(txtYear.Text) && Validate(artistsComboBox.Text) && Validate(pictureBoxPhoto.ImageLocation)) {
                album.AlbumTitle = txtAlbumTitle.Text;
                album.ArtistName = artistsComboBox.Text;
                album.Year = Convert.ToInt32(txtYear.Text);
                album.Length = Convert.ToInt32(txtLength.Text);
                album.Cover = ConvertFileToByte(this.pictureBoxPhoto.ImageLocation);



                int tempNum;
                if (album.AlbumId == 0)
                {
                    tempNum = MusicLibraryOperation.createOperation(TYPE.ALBUM).Add(album);
                }
                else
                {
                    tempNum = MusicLibraryOperation.createOperation(TYPE.ALBUM).Update(album);
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
                PopulateDataGridView();

            }

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
            txtAlbumTitle.Text = artistsComboBox.Text = txtLength.Text = txtYear.Text = "";
            pictureBoxPhoto.Image = null;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            album.AlbumId = 0;
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dvgAlbum.CurrentRow.Index != -1)
            {
                int tempNum = Convert.ToInt32(dvgAlbum.CurrentRow.Cells["albumIdDataGridViewTextBoxColumn"].Value);
                album = (Album)MusicLibraryOperation.createOperation(TYPE.ALBUM).Get(tempNum);
                if (album == null)
                {
                    Message.show("Could not find this information.", MESSAGE_TYPE.FAILURE);
                    return;
                }
                txtAlbumTitle.Text = album.AlbumTitle;
                artistsComboBox.Text = album.ArtistName;
                txtYear.Text = Convert.ToString(album.Year);
                txtLength.Text = Convert.ToString(album.Length);
                var img = new MemoryStream(album.Cover);
                pictureBoxPhoto.Image = Image.FromStream(img);
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

        private void addAnArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ArtistForm frm = new ArtistForm())
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

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Library frm = new Library())
            {
                frm.ShowDialog();
            }
        }

        private bool Validate(String txt)
        {
            if (String.IsNullOrEmpty(txt))
            {
                errorProvider1.SetError(txtAlbumTitle, "Please enter data");
                errorProvider1.SetError(txtYear, "Please enter data");
                errorProvider1.SetError(txtLength, "Please enter data");
                errorProvider1.SetError(artistsComboBox, "Please enter data");
                errorProvider1.SetError(pictureBoxPhoto, "Please select a photo");

                return false;
            }
            return true;
        }

    }
}
