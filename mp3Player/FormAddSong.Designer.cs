namespace mp3Player
{
    partial class FormAddSong
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
            this.txtBox_AddSong = new System.Windows.Forms.TextBox();
            this.btn_addSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_AddSong
            // 
            this.txtBox_AddSong.Location = new System.Drawing.Point(43, 33);
            this.txtBox_AddSong.Name = "txtBox_AddSong";
            this.txtBox_AddSong.ReadOnly = true;
            this.txtBox_AddSong.Size = new System.Drawing.Size(243, 20);
            this.txtBox_AddSong.TabIndex = 0;
            // 
            // btn_addSong
            // 
            this.btn_addSong.Location = new System.Drawing.Point(163, 76);
            this.btn_addSong.Name = "btn_addSong";
            this.btn_addSong.Size = new System.Drawing.Size(123, 23);
            this.btn_addSong.TabIndex = 1;
            this.btn_addSong.Text = "Choose Song";
            this.btn_addSong.UseVisualStyleBackColor = true;
            this.btn_addSong.Click += new System.EventHandler(this.btn_addSong_Click);
            // 
            // FormAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 128);
            this.Controls.Add(this.btn_addSong);
            this.Controls.Add(this.txtBox_AddSong);
            this.Name = "FormAddSong";
            this.Text = "FormAddSong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_AddSong;
        private System.Windows.Forms.Button btn_addSong;
    }
}