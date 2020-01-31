using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
            this.txtFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFile_DragDrop);
            this.txtFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
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
            songsDataGridView.AutoGenerateColumns = false;
            using (MusicLibraryContext ac = new MusicLibraryContext())
            {
                songsDataGridView.DataSource = ac.Songs.ToList<Song>();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete? ", "crud operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MusicLibraryContext ac = new MusicLibraryContext())
                {
                    var entry = ac.Entry(song);

                    if (entry.State == EntityState.Detached)
                    {
                        ac.Songs.Attach(song);
                    }
                    ac.Songs.Remove(song);
                    ac.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("deleted successfuly");
                }
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


        private void txtFile_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }


        private void txtFile_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                txtFile.Text = (s[i]);

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
            song.SongTitle = textSongTitle.Text;
            song.AlbumId = Convert.ToInt32(albumComboBox.SelectedValue);
            song.GenreId = Convert.ToInt32(typeComboBox.SelectedValue);

            using (MusicLibraryContext ac = new MusicLibraryContext())
            {
                if (song.SongId == 0)
                {
                    ac.Songs.Add(song);
                }
                else
                {
                    ac.Entry(song).State = EntityState.Modified;
                }

                ac.SaveChanges();
            }

            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted successfuly");
        }

        private void ChooseFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file (or is it the full path?)

                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    // do anything you want with the file in this block
                    song.Path = "C:\\Users\\1295607\\Desktop\\songs" + System.IO.Path.GetFileName(path);
                    txtFile.Text = path;
                }
            }
        }

        private void songsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (songsDataGridView.CurrentRow.Index != -1)
            {
                song.SongId = Convert.ToInt32(songsDataGridView.CurrentRow.Cells["songIddataGridViewTextBoxColumn1"].Value);

                using (MusicLibraryContext ac = new MusicLibraryContext())
                {
                    song = ac.Songs.Where(x => x.SongId == song.SongId).FirstOrDefault();
                    textSongTitle.Text = song.SongTitle;
                    song.AlbumId = Convert.ToInt32(albumComboBox.SelectedValue);
                    song.GenreId = Convert.ToInt32(typeComboBox.SelectedValue);

                }
                buttonSave.Text = "Update";
                buttonDelete.Enabled = true;
            }
        }
    }

}

