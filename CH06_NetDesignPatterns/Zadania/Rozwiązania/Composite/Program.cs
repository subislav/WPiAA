using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuCategory rootMenu = new MenuCategory("Menu Główne");
            MenuCategory sniadania = new MenuCategory("Śniadania");
            MenuCategory obiady = new MenuCategory("Obiady");
            MenuCategory napoje = new MenuCategory("Napoje");
            MenuCategory piwo = new MenuCategory("Piwo");
            MenuCategory bezalkoholowe = new MenuCategory("Bezalkoholowe");
            MenuCategory zupy = new MenuCategory("Zupy");
            MenuItem jajecznica = new MenuItem("Jajecznica na maśle", 15.00);
            MenuItem owsianka = new MenuItem("Owsianka z owocami", 12.50);
            MenuItem schabowy = new MenuItem("Kotlet Schabowy", 35.00);
            MenuItem mielony = new MenuItem("Kotlet Mielony", 25.00);
            MenuItem pomidorowa = new MenuItem("Zupa Pomidorowa", 18.00);
            MenuItem rosol = new MenuItem("Rosół z kury", 16.00);
            MenuItem cola = new MenuItem("Coca-Cola", 8.00);
            MenuItem woda = new MenuItem("Woda Mineralna", 5.00);
            MenuItem pilsner = new MenuItem("Pilsner", 12.00);
            MenuItem przeniczne = new MenuItem("Przeniczne", 14.00);
            sniadania.Add(jajecznica);
            sniadania.Add(owsianka);
            zupy.Add(pomidorowa);
            zupy.Add(rosol);
            obiady.Add(schabowy);
            obiady.Add(mielony);
            obiady.Add(zupy);
            napoje.Add(piwo);
            napoje.Add(bezalkoholowe);
            bezalkoholowe.Add(woda);
            bezalkoholowe.Add(cola);
            piwo.Add(pilsner);
            piwo.Add(przeniczne);
            rootMenu.Add(sniadania);
            rootMenu.Add(obiady);
            rootMenu.Add(napoje);
            rootMenu.Display(0);
            Console.ReadKey();
        }
    }
}