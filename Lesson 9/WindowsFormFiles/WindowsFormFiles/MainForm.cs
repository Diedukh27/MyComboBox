namespace WindowsFormFiles
{
    public partial class MainForm : Form
    {

        private string Images1 = @"Images\2.jpg";
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists(Images1))
            {
                // MessageBox.Show("Файл зображення для відсутніх зображень знайдено");
                pbImage.Image = Image.FromFile(Images1);
            }
            else
            {
                MessageBox.Show("Файл зображеннядля відсутніх зображень не знайдено");
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Оберіть зображення",
                //Filter = "Зображення (.jpg .jpeg .png)"
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
            };

            if (dlg.ShowDialog() != DialogResult.OK) return;

            string path = dlg.FileName;
            txtSelectFile.Text = path;

            var ext = Path.GetExtension(path).ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
            {
                MessageBox.Show("Тільки JPG, JPEG або PNG", "Помилка");
                return;
            }

            if (new FileInfo(path).Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("Файл перевищує 5 МБ", "Помилка");
                return;
            }

            try
            {
                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                pbImage.Image = new Bitmap(Image.FromStream(fs));
            }
            catch
            {
                MessageBox.Show("Помилка при відкритті зображення", "Помилка");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
