using System;
using System.Windows.Forms;

namespace mp3Player
{
    public partial class FormAddSong : Form
    {
        public FormAddSong()
        {
            InitializeComponent();
        }

        Song song = new Song();

        private void btn_addSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 file (*.mp3)|*.mp3|WAV file (*.wav)|*.wav";
            dialog.Multiselect = false;
            if (btn_addSong.Text=="Choose Song")
            {
                if (dialog.ShowDialog()==DialogResult.OK)
                {
                    txtBox_AddSong.Text = dialog.SafeFileName;
                    song.FileName = dialog.SafeFileName;
                    song.FilePath = dialog.FileName;
                    btn_addSong.Text = "Add to List";
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public Song NewSong
        {
            get
            {
                return song;
            }
        }
    }
}