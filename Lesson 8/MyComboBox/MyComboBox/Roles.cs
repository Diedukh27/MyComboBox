namespace MyComboBox
{
    public class Roles
    {
        private string _rolesName;

        private int _id;

        public Roles()
        {
            this._rolesName = string.Empty;
            this._id = 0;   
        }
        public Roles(int id, string rolesName)
        {
            this._rolesName=rolesName;
            this._id = id;
        }
        public override string ToString() {

            return _rolesName;
                }
    }
}
