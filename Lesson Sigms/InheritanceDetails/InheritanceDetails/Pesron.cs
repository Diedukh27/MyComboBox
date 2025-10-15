namespace InheritanceDetails
{
    internal class Pesron
    {
        private readonly Guid _id;

        private string _name = "";

        public Pesron()
        {
            _id = Guid.NewGuid();
        }
    }
}
