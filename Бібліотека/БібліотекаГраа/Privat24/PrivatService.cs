namespace Privat24
{
    public class PrivatService
    {

        private string url = "https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5";

        public string GetJsonValuta()
        {
            HttpClient client  = new HttpClient();

            var responce = client.GetStringAsync(url).Result;
            return responce;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Це найпростіший сервіс для привату ");
        } 


    }
}
