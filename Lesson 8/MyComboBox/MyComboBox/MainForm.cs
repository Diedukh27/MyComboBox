using System.Security.Cryptography.X509Certificates;

namespace MyComboBox
{
    public partial class MainForm : Form
    {
        Roles[] listRoles =
            {
                new Roles(1, "Адмін"),
                new Roles(2, "Менеджер"),
                new Roles(3, "Продавець"),
                new Roles(4, "Складовик"),
                new Roles(5, "Продавець стажер")
            };
        public MainForm()
        {            
            
           InitializeComponent();
            cbRoles.Items.AddRange(listRoles);

        }
    }
}
