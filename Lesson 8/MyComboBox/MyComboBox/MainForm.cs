using System.Security.Cryptography.X509Certificates;

namespace MyComboBox
{
    public partial class MainForm : Form
    {
        Roles[] listRoles =
            {
                new Roles(1, "����"),
                new Roles(2, "��������"),
                new Roles(3, "���������"),
                new Roles(4, "���������"),
                new Roles(5, "��������� ������")
            };
        public MainForm()
        {            
            
           InitializeComponent();
            cbRoles.Items.AddRange(listRoles);

        }
    }
}
