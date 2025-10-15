namespace InheritanceDetails
{
    public sealed class Bolt
    {
        public const string Admin = "Адміністратор";

        public const string Manager = "Менеджер";

        public const string User = "Користувач";


        public static string[] GetRoles => [Admin, Manager, User]; 
    }
}
