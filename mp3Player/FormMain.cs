using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave; // https://github.com/naudio/NAudio
using System.IO;

namespace mp3Player
{
    public partial class FormMain : Form
    {
        IWavePlayer waveOut;
        AudioFileReader audioFileReader;
        bool isPaused = false;
        bool isMuted = false;
        float volume = 0.5f;
        List<Song> songs = new List<Song>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close the Player?", "Close...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAbout = new FormAbout();
            formAbout.ShowDialog();
            formAbout.Activate();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count != 0)
            {
                try
                {
                    if (!isPaused)
                    {
                        CloseWave();
                        waveOut = new WaveOut();
                        waveOut.PlaybackStopped += WaveOutStopped;
                        for (int i = 0; i < songs.Count; i++)
                        {
                            if (songs[i].FileName == listBox_songs.SelectedItem.ToString())
                            {
                                audioFileReader = new AudioFileReader(songs[i].FilePath);
                                audioFileReader.Volume = volume;
                                break;
                            }
                        }
                        waveOut.Init(audioFileReader);
                    }
                    waveOut.Play();
                    pictureBox_gif.Show();
                    isPaused = false;
                }
                catch (Exception)
                {
                    listBox_songs.SelectedIndex = 0;
                }
            }
            else
            {
                btn_add_Click(sender, e);
                if (listBox_songs.Items.Count != 0)
                {
                    listBox_songs.SelectedIndex = 0;
                }
                pictureBox_gif.Show();
                isPaused = false;
            }
        }

        private void CloseWave()
        {
            if (listBox_songs.Items.Count != 0)
            {
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }
                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                    audioFileReader = null;
                }
                isPaused = false;
                pictureBox_gif.Hide();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            CloseWave();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 files (*.mp3)|*.mp3|WAV files (*.wav)|*.wav";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] paths = dialog.FileNames;
                string[] names = dialog.SafeFileNames;
                for (int i = 0; i < names.Length; i++)
                {
                    Song song = new Song(names[i], paths[i]);
                    if (!CheckRepeatedSong(paths[i]))
                    {
                        songs.Add(song);
                    }
                }
                RefreshList();
            }
        }
        private void RefreshList()
        {
            listBox_songs.Items.Clear();

            for (int i = 0; i < songs.Count; i++)
            {
                listBox_songs.Items.Add(songs[i].FileName);
            }
        }
        private void listBox_songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_songs.SelectedItem != null)
            {
                CloseWave();
                waveOut = new WaveOut();
                waveOut.PlaybackStopped += WaveOutStopped;
                for (int i = 0; i < songs.Count; i++)
                {
                    if (songs[i].FileName == listBox_songs.SelectedItem.ToString())
                    {
                        audioFileReader = new AudioFileReader(songs[i].FilePath);
                        audioFileReader.Volume = volume;
                        break;
                    }
                }
                waveOut.Init(audioFileReader);
                waveOut.Play();
                pictureBox_gif.Show();
            }
        }

        private void WaveOutStopped(object sender, EventArgs e)
        {
            btn_next_Click(sender, e);
        }

        private void btn_Previousbtn_Previous_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count != 0)
            {
                try
                {
                    listBox_songs.SelectedIndex--;
                }
                catch (ArgumentOutOfRangeException)
                {
                    listBox_songs.SelectedItem = listBox_songs.Items[listBox_songs.Items.Count - 1];
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count != 0)
            {
                try
                {
                    listBox_songs.SelectedIndex++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    listBox_songs.SelectedItem = listBox_songs.Items[0];
                }
            }
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count != 0 && listBox_songs.SelectedItem != null)
            {
                try
                {
                    if (isPaused)
                    {
                        waveOut.Play();
                        pictureBox_gif.Show();
                        isPaused = false;
                    }
                    else
                    {
                        waveOut.Pause();
                        pictureBox_gif.Hide();
                        isPaused = true;
                    }
                }
                catch (NullReferenceException)
                {
                    
                }
            }
        }

        private void singleSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAddSong = new FormAddSong();
            formAddSong.ShowDialog();
            if (formAddSong.DialogResult == DialogResult.OK)
            {
                if (CheckRepeatedSong(formAddSong.NewSong.FilePath))
                {
                    MessageBox.Show("Song already exists!", "Can not be added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    songs.Add(formAddSong.NewSong);
                    if (listBox_songs.Items.Count != 0)
                    {
                        DialogResult dialog = MessageBox.Show("Do you want to clear your songs list?", "Adding...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            songs.Clear();
                            songs.Add(formAddSong.NewSong);
                        }
                    }
                    RefreshList();
                }
            }
        }

        private void songsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count != 0)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = ".wpl";
                saveDialog.Filter = "Playlist (*.wpl)|*.wpl";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveDialog.FileName, false))
                    {
                        for (int i = 0; i < songs.Count; i++)
                        {
                            sw.WriteLine(songs[i].FilePath);
                        }
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_songs.Items.Count != 0)
            {
                if (MessageBox.Show("Do you want to clear your songs list?", "Adding...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listBox_songs.Items.Clear();
                    songs.Clear();
                }
            }
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Playlist (*.wpl)|*.wpl";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openDialog.FileName))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string path = line;
                        int index = path.LastIndexOf('\\');
                        string name = path.Substring(index + 1);
                        if (!CheckRepeatedSong(path))
                        {
                            songs.Add(new Song(name, path));
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            RefreshList();
        }

        private bool CheckRepeatedSong(string path)
        {
            bool isExist = false;
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].FilePath == path)
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            volume = trackBar_volume.Value / 10.0f;
            if (audioFileReader != null)
            {
                audioFileReader.Volume = volume;
            }
            if (volume == 0)
            {
                btn_mute.BackgroundImage = Properties.Resources.mute;
            }
            else
            {
                btn_mute.BackgroundImage = Properties.Resources.mute_no;
            }
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                if (isMuted == false)
                {
                    audioFileReader.Volume = 0;
                    trackBar_volume.Value = 0;
                    btn_mute.BackgroundImage = Properties.Resources.mute;
                    isMuted = true;
                }
                else
                {
                    audioFileReader.Volume = volume;
                    trackBar_volume.Value = (int)(volume * 10);
                    btn_mute.BackgroundImage = Properties.Resources.mute_no;
                    isMuted = false;
                }
            }
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                audioFileReader.CurrentTime = audioFileReader.CurrentTime.Add(TimeSpan.FromSeconds(-3));
            }
        }

        private void btn_goFor_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                audioFileReader.CurrentTime = audioFileReader.CurrentTime.Add(TimeSpan.FromSeconds(3));
            }
        }

        private void listBox_songs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox_songs_DragDrop(object sender, DragEventArgs e)
        {
            List<string> DroppedPaths = new List<string>();
            foreach (var path in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {
                if (Directory.Exists(path))
                {
                    DroppedPaths.AddRange(Directory.GetFiles(path));
                }
                else
                {
                    DroppedPaths.Add(path);
                }
            }
            for (int i = 0; i < DroppedPaths.Count; i++)
            {
                if (!CheckRepeatedSong(DroppedPaths[i]))
                {
                    string path = DroppedPaths[i];
                    int index = path.LastIndexOf('\\');
                    string name = path.Substring(index + 1);
                    songs.Add(new Song(name, path));
                }
            }
            RefreshList();
            DroppedPaths.Clear();
        }

        private void fileToolStripMenuItem_DropDownOpened_1(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void fileToolStripMenuItem_DropDownClosed_1(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
        }

        private void playlistToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            playlistToolStripMenuItem.ForeColor = Color.Black;
        }

        private void playlistToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            playlistToolStripMenuItem.ForeColor = Color.White;
        }

        private void moreToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            moreToolStripMenuItem.ForeColor = Color.Black;
        }

        private void moreToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            moreToolStripMenuItem.ForeColor = Color.White;
        }
    }
}