using Newtonsoft.Json;

namespace Magazin
{
    internal class Dasser_and_Seril
    {
        public static T DeCer<T>(string files)
        {
            string put = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = put + "\\Кафешка\\" + files;
            string json = File.ReadAllText(file);
            T uchastnik = JsonConvert.DeserializeObject<T>(json);
            return uchastnik;
        }
        public static void Cerialaz<T>(T pleer, string files)
        {
            string put = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = put + "\\Кафешка\\" + files;
            var json = JsonConvert.SerializeObject(pleer);
            File.WriteAllText(file, json);
        }
    }
}
