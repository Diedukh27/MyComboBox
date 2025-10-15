namespace Exeption
{
    public class ReadFail
    {
        private string _fileName;

        private List<string> _lines;

        public void ReadLines(string fileName)
        {
            _lines = new List<string>();
            fileName = fileName;

            if (!File.Exists(_fileName))
            {
                throw new MyReadearExeotion("Hello");
            }


            // вміст уього файлу
            var allLines = File.ReadAllLines(fileName);
        }


    }
}

