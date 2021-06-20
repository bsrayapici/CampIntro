using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValitaionManager());
            gamerManager.Add(new Gamer { Id=1, BirthYear=1995, FirstName="Büşra",LastName="Yapıcı"});
            SaleManager salarymanager = new SaleManager();
        }
    }
}
