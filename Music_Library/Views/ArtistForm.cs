using Music_Library.Views;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class ArtistForm : Form
    {
        private static int MIN_AGE = 1;
        private static int MAX_AGE = 130;
        private Artist artist = new Artist();

        public ArtistForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            artist.FirstName = textBoxFirstName.Text;
            artist.LastName = textBoxLastName.Text;
            artist.Age = Convert.ToInt32(textBoxAge.Text);

            int tempNum;
            if (artist.ArtistId == 0)
            {
                tempNum = MusicLibraryOperation.createOperation(TYPE.ARTIST).Add(artist);
            }
            else
            {
                tempNum = MusicLibraryOperation.createOperation(TYPE.ARTIST).Update(artist);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (Message.show("Are you sure you want to delete?", MESSAGE_TYPE.ADVISORY) == DialogResult.Yes)
            {
                int tempNum = MusicLibraryOperation.createOperation(TYPE.ARTIST).Delete(artist);
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

        private void dataGridViewArtist_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewArtist.CurrentRow.Index != -1)
            {
                int tempNum = Convert.ToInt32(dataGridViewArtist.CurrentRow.Cells["artistIdDataGridViewTextBoxColumn"].Value);
                artist = (Artist)MusicLibraryOperation.createOperation(TYPE.ARTIST).Get(tempNum);
                if (artist == null)
                {
                    Message.show("Could not find this information.", MESSAGE_TYPE.FAILURE);
                    return;
                }
                textBoxFirstName.Text = artist.FirstName;
                textBoxLastName.Text = artist.LastName;
                textBoxAge.Text = Convert.ToString(artist.Age);
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

        /// <summary>
        /// validate the first name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstNameValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            mandatoryDataValidating(textBox, e);
        }

        /// <summary>
        /// validate the last name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastNameValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            mandatoryDataValidating(textBox, e);
        }

        /// <summary>
        /// validate the age.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ageValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            mandatoryDataValidating(textBox, e);
            illegalAgeValidating(textBox, e);
        }

        private void mandatoryDataValidating(TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, "Please enter data.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        private void illegalAgeValidating(TextBox textBox, CancelEventArgs e)
        {
            int tempNum = textBox.Text == "" ? 0 : Convert.ToInt32(textBox.Text);
            if (tempNum < MIN_AGE || tempNum > MAX_AGE)
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, "Please enter legal age.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        private void dataGridViewArtist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}