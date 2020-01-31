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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();

        }

        private void songsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.songsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Music_Library_MusicLibraryContextDataSet);

        }

        private void Library_Load(object sender, EventArgs e)
        {
            vWSongAlbum4DataGridView.RowTemplate.Height = 75;

            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.VWSongAlbum4' table. You can move, or remove it, as needed.
            this.vWSongAlbum4TableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.VWSongAlbum4);
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.VWSongAlbum3' table. You can move, or remove it, as needed.
            this.vWSongAlbum3TableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.VWSongAlbum3);
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet1.VWSongAlbum2' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.VWSongAlbum1' table. You can move, or remove it, as needed.
            this.vWSongAlbum1TableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.VWSongAlbum1);
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.VWSongAlbum' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_Music_Library_MusicLibraryContextDataSet.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter.Fill(this._Music_Library_MusicLibraryContextDataSet.Songs);

            libraryToolStripMenuItem.Enabled = false;

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

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Library frm = new Library())
            {
                frm.ShowDialog();
            }
        }

        private void vWSongAlbum2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = Convert.ToString(vWSongAlbum4DataGridView.CurrentRow.Cells["Path"].Value);
            WMP.URL = @path;
        }

        private void vWSongAlbum4DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string path = Convert.ToString(vWSongAlbum4DataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value);
            //WMP.URL = @path;
            //WMP.currentPlaylist = WMP.mediaCollection.getByName(path);
            txtPlay.Text = Convert.ToString(vWSongAlbum4DataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value);
            //MessageBox.Show(path);
        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            WMP.URL = txtPlay.Text; 
        }
    }
}
