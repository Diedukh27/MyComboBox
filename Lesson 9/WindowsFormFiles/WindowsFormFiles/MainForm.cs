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
                // MessageBox.Show("���� ���������� ��� ������� ��������� ��������");
                pbImage.Image = Image.FromFile(Images1);
            }
            else
            {
                MessageBox.Show("���� ������������� ������� ��������� �� ��������");
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "������ ����������",
                //Filter = "���������� (.jpg .jpeg .png)"
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
            };

            if (dlg.ShowDialog() != DialogResult.OK) return;

            string path = dlg.FileName;
            txtSelectFile.Text = path;

            var ext = Path.GetExtension(path).ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
            {
                MessageBox.Show("ҳ���� JPG, JPEG ��� PNG", "�������");
                return;
            }

            if (new FileInfo(path).Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("���� �������� 5 ��", "�������");
                return;
            }

            try
            {
                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                pbImage.Image = new Bitmap(Image.FromStream(fs));
            }
            catch
            {
                MessageBox.Show("������� ��� ������� ����������", "�������");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
