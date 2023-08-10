namespace mp3Player
{
    public class Song
    {
        private string fileName;
        private string filePath;

        public Song() { }
        public Song (string fileName, string filePath)
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }
        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }
        public string FilePath
        {
            get
            {
                return this.filePath;
            }
            set
            {
                this.filePath = value;
            }
        }
    }
}