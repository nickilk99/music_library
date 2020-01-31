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
        MusicLibraryContext musicLibraryContext;
        Song song = new Song();
        public SongForm()
        {
            InitializeComponent();
            this.textBoxPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFile_DragDrop);
            this.textBoxPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            musicLibraryContext = new MusicLibraryContext();
            this.albumBindingSource.DataSource = musicLibraryContext.Albums.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.musicLibraryContext.Dispose();
        }

        private void SongForm_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridViewSong.AutoGenerateColumns = false;
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                dataGridViewSong.DataSource = musicLibraryContext.Songs.ToList<Song>();
                comboBoxAlbum.DataSource = musicLibraryContext.Albums.ToList<Album>();
                comboBoxGenre.DataSource = musicLibraryContext.Genres.ToList<Genre>();
            }
        }

        private void Clear()
        {
            textBoxSongTitle.Text = "";
            comboBoxAlbum.SelectedValue = 0;
            comboBoxGenre.SelectedValue = 0;
            textBoxPath.Text = "";
            buttonSave.Text = "Save";
            buttonDelete.Enabled = false;
            song.SongId = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Validate(textBoxSongTitle.Text) && Validate(comboBoxGenre.Text) && Validate(comboBoxAlbum.Text) && Validate(textBoxPath.Text)) {

                song.SongTitle = textBoxSongTitle.Text.Trim();
                song.AlbumId = Convert.ToInt32(comboBoxAlbum.SelectedValue);
                song.GenreId = Convert.ToInt32(comboBoxGenre.SelectedValue);

                int tempNum;
                if (song.SongId == 0)
                {
                    tempNum = MusicLibraryOperation.createOperation(TYPE.SONG).Add(song);
                }
                else
                {
                    tempNum = MusicLibraryOperation.createOperation(TYPE.SONG).Update(song);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Message.show("Are you sure you want to delete?", MESSAGE_TYPE.ADVISORY) == DialogResult.Yes)
            {
                int tempNum = MusicLibraryOperation.createOperation(TYPE.SONG).Delete(song);
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

        private void dataGridViewSong_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewSong.CurrentRow.Index != -1)
            {
                int tempNum = Convert.ToInt32(dataGridViewSong.CurrentRow.Cells["songIdDataGridViewTextBoxColumn"].Value);
                song = (Song)MusicLibraryOperation.createOperation(TYPE.SONG).Get(tempNum);
                if (song == null)
                {
                    Message.show("Could not find this information.", MESSAGE_TYPE.FAILURE);
                    return;
                }
                textBoxSongTitle.Text = song.SongTitle;
                comboBoxAlbum.SelectedValue = song.AlbumId;
                comboBoxGenre.SelectedValue = song.GenreId;
                textBoxPath.Text = song.Path;
                buttonSave.Text = "Update";
                buttonDelete.Enabled = true;
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
                textBoxPath.Text = (s[i]);

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
                    song.Path = path;
                    textBoxPath.Text = path;

                }
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



        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private bool Validate(string txt)
        {
            if (String.IsNullOrEmpty(txt))
            {
                errorProvider1.SetError(textBoxSongTitle, "Please enter data");
                errorProvider1.SetError(comboBoxGenre, "Please enter data");
                errorProvider1.SetError(comboBoxAlbum, "Please enter data");
                errorProvider1.SetError(textBoxPath, "Please enter data");
                return false;
            }
            return true;
        }
    }

}

