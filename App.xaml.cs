using SQLite;
using Popa_Sebastian_Ioan_Lab7.Models;
using System.IO;
using Popa_Sebastian_Ioan_Lab7.Data;



namespace Popa_Sebastian_Ioan_Lab7
{ 
public partial class App : Application
{
    static ShoppingListDataBase database;
    public static ShoppingListDataBase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               ShoppingListDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
    
