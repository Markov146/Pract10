namespace Magazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "C:\\Users\\user\\Desktop\\Данные сотрудников.json";
            string ss = "C:\\Users\\user\\Desktop\\Личные данные сотрудников.json";
            if (!File.Exists(s))
            {
                string put = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Directory.CreateDirectory(put);
                Sotrudniki Adm = new Sotrudniki();
                Adm.Login = "Admin";
                Adm.Password = "11111";
                Adm.Work = "Admin";
                Adm.ID = 0;
                List<Sotrudniki> rab = new List<Sotrudniki>();
                rab.Add(Adm);

                InfSotrud pust = new InfSotrud();
                List<InfSotrud> irab = new List<InfSotrud>();
                irab.Add(pust);
                File.Create(put + "\\Данные сотрудников.json").Close();
                File.Create(put + "\\Личные данные сотрудников.json").Close();
                Deser_and_Seril.Cerialaz(rab, "\\Данные сотрудников.json");
                Deser_and_Seril.Cerialaz(irab, "\\Личные данные сотрудников.json");
            }
            Avtorize inpt = new Avtorize();

            while (true)
            {
         
                string[] pr = inpt.UserAvtorize();
                string who = "";
                List<Sotrudniki> rab = Deser_and_Seril.DeCer<List<Sotrudniki>>("Данные сотрудников.json");
                int n = 0;
                int id = 0;
                foreach (var pleer in rab)
                {
                    if (pleer.Login == pr[0])
                    {
                        if (pleer.Password == pr[1])
                        {
                            n = 1;
                            who = pleer.Work;
                            id = pleer.ID;
                        }
                    }
                }
                if (n == 1)
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Такой человек здесь работает");

                }
                else
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Такого логина или пароля нет");
                }
                if (who == "Admin")
                {
                    Console.WriteLine("Это администратор");
                    Adminstr adm = new Adminstr();
                    adm.Privetstvie(id);
                }


            }


        
}   }   }
    
