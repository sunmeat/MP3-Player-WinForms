namespace mp3Player
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btn_play;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox_songs = new System.Windows.Forms.ListBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.btn_goFor = new System.Windows.Forms.Button();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.pictureBox_gif = new System.Windows.Forms.PictureBox();
            this.btn_mute = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Previousbtn_Previous = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            btn_play = new System.Windows.Forms.Button();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            btn_play.BackColor = System.Drawing.Color.White;
            btn_play.BackgroundImage = global::mp3Player.Properties.Resources.play;
            btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_play.Location = new System.Drawing.Point(95, 152);
            btn_play.Name = "btn_play";
            btn_play.Size = new System.Drawing.Size(33, 23);
            btn_play.TabIndex = 1;
            btn_play.UseVisualStyleBackColor = false;
            btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.BackColor = System.Drawing.Color.Black;
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(516, 24);
            this.menuStrip_main.TabIndex = 0;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed_1);
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpened_1);
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleSongToolStripMenuItem,
            this.songsToolStripMenuItem});
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addSongToolStripMenuItem.Text = "Add Song";
            // 
            // singleSongToolStripMenuItem
            // 
            this.singleSongToolStripMenuItem.Name = "singleSongToolStripMenuItem";
            this.singleSongToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.singleSongToolStripMenuItem.Text = "Single Song";
            this.singleSongToolStripMenuItem.Click += new System.EventHandler(this.singleSongToolStripMenuItem_Click);
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.songsToolStripMenuItem.Text = "Songs";
            this.songsToolStripMenuItem.Click += new System.EventHandler(this.songsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePlaylistToolStripMenuItem,
            this.openToolStripMenuItem});
            this.playlistToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.DropDownClosed += new System.EventHandler(this.playlistToolStripMenuItem_DropDownClosed);
            this.playlistToolStripMenuItem.DropDownOpened += new System.EventHandler(this.playlistToolStripMenuItem_DropDownOpened);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openToolStripMenuItem.Text = "Open Playlist";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.moreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            this.moreToolStripMenuItem.DropDownClosed += new System.EventHandler(this.moreToolStripMenuItem_DropDownClosed);
            this.moreToolStripMenuItem.DropDownOpened += new System.EventHandler(this.moreToolStripMenuItem_DropDownOpened);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.05F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(416, 152);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(76, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Songs";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listBox_songs
            // 
            this.listBox_songs.AllowDrop = true;
            this.listBox_songs.BackColor = System.Drawing.Color.Black;
            this.listBox_songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_songs.ForeColor = System.Drawing.Color.White;
            this.listBox_songs.FormattingEnabled = true;
            this.listBox_songs.ItemHeight = 15;
            this.listBox_songs.Location = new System.Drawing.Point(6, 197);
            this.listBox_songs.Name = "listBox_songs";
            this.listBox_songs.Size = new System.Drawing.Size(504, 169);
            this.listBox_songs.TabIndex = 4;
            this.listBox_songs.SelectedIndexChanged += new System.EventHandler(this.listBox_songs_SelectedIndexChanged);
            this.listBox_songs.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_songs_DragDrop);
            this.listBox_songs.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_songs_DragEnter);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.LargeChange = 3;
            this.trackBar_volume.Location = new System.Drawing.Point(308, 150);
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(104, 45);
            this.trackBar_volume.TabIndex = 8;
            this.trackBar_volume.Value = 5;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // btn_goFor
            // 
            this.btn_goFor.BackgroundImage = global::mp3Player.Properties.Resources.next;
            this.btn_goFor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_goFor.Location = new System.Drawing.Point(240, 152);
            this.btn_goFor.Name = "btn_goFor";
            this.btn_goFor.Size = new System.Drawing.Size(30, 23);
            this.btn_goFor.TabIndex = 12;
            this.btn_goFor.Text = ">>";
            this.btn_goFor.UseVisualStyleBackColor = true;
            this.btn_goFor.Click += new System.EventHandler(this.btn_goFor_Click);
            // 
            // btn_goBack
            // 
            this.btn_goBack.BackgroundImage = global::mp3Player.Properties.Resources.prev;
            this.btn_goBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_goBack.Location = new System.Drawing.Point(11, 152);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(30, 23);
            this.btn_goBack.TabIndex = 11;
            this.btn_goBack.Text = "<<";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // pictureBox_gif
            // 
            this.pictureBox_gif.Image = global::mp3Player.Properties.Resources._18;
            this.pictureBox_gif.Location = new System.Drawing.Point(6, 25);
            this.pictureBox_gif.Name = "pictureBox_gif";
            this.pictureBox_gif.Size = new System.Drawing.Size(504, 109);
            this.pictureBox_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_gif.TabIndex = 10;
            this.pictureBox_gif.TabStop = false;
            this.pictureBox_gif.Visible = false;
            // 
            // btn_mute
            // 
            this.btn_mute.BackColor = System.Drawing.Color.White;
            this.btn_mute.BackgroundImage = global::mp3Player.Properties.Resources.mute_no;
            this.btn_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mute.Location = new System.Drawing.Point(279, 152);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(23, 23);
            this.btn_mute.TabIndex = 9;
            this.btn_mute.UseVisualStyleBackColor = false;
            this.btn_mute.Click += new System.EventHandler(this.btn_mute_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.White;
            this.btn_Pause.BackgroundImage = global::mp3Player.Properties.Resources.pause;
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pause.Location = new System.Drawing.Point(134, 152);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(23, 23);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.White;
            this.btn_next.BackgroundImage = global::mp3Player.Properties.Resources.goForw;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Location = new System.Drawing.Point(200, 152);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(30, 23);
            this.btn_next.TabIndex = 6;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Previousbtn_Previous
            // 
            this.btn_Previousbtn_Previous.BackColor = System.Drawing.Color.White;
            this.btn_Previousbtn_Previous.BackgroundImage = global::mp3Player.Properties.Resources.goBack;
            this.btn_Previousbtn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Previousbtn_Previous.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Previousbtn_Previous.Location = new System.Drawing.Point(51, 152);
            this.btn_Previousbtn_Previous.Name = "btn_Previousbtn_Previous";
            this.btn_Previousbtn_Previous.Size = new System.Drawing.Size(30, 23);
            this.btn_Previousbtn_Previous.TabIndex = 5;
            this.btn_Previousbtn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previousbtn_Previous.Click += new System.EventHandler(this.btn_Previousbtn_Previous_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.White;
            this.btn_stop.BackgroundImage = global::mp3Player.Properties.Resources.stop;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.Location = new System.Drawing.Point(163, 152);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(23, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(516, 372);
            this.Controls.Add(this.btn_goFor);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.pictureBox_gif);
            this.Controls.Add(this.btn_mute);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Previousbtn_Previous);
            this.Controls.Add(this.listBox_songs);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(btn_play);
            this.Controls.Add(this.menuStrip_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Mp3 Player";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox_songs;
        private System.Windows.Forms.Button btn_Previousbtn_Previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Button btn_mute;
        private System.Windows.Forms.PictureBox pictureBox_gif;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Button btn_goFor;
    }
}

