using Microsoft.Maui.Storage;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace Aloha_
{
    internal class Database
    {
        public const string DatabaseFilename = "fsite.db";
        
        public static string DatabasePath => Path.Combine(FileSystem.AppDataDirectory, "Assets", DatabaseFilename);

        
       public const SQLite.SQLiteOpenFlags Flags = SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.Create | SQLite.SQLiteOpenFlags.SharedCache;
        
           
        // open the database in read/write mode

        // create the database if it doesn't exist

        // enable multi-threaded database access

      
        public class Tour
        {
            [PrimaryKey, AutoIncrement, Column("_id_tour")]
            public int id_tour { get; set; }
            public string name_tour { get; set; }
            public int price_tour { get; set; }
            public string description_tour { get; set; }
            public string title_tour { get; set; }
            public string un_title { get; set; }
            public string img { get; set;}

            public string video { get; set; }
        }
        [Table("Tour")]
        public class Root
        {
            public List<Tour> results { get; set; }
        }
    
    }
}
