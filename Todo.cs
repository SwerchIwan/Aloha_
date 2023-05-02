using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aloha_.Database;

namespace Aloha_
{
    internal class Todo
    {
        public class TodoItemDatabase
        {
            SQLiteAsyncConnection Database;

            public TodoItemDatabase()
            {
            }

            public async Task Init()
            {
                if (Database is not null)
                    return;

                Database = new SQLiteAsyncConnection(Database.DatabasePath, Flags);
                var result = await Database.CreateTableAsync<Tour>();
            }
            public async Task<List<Tour>> GetItemsAsync()
            {
                await Init();
                return await Database.Table<Tour>().ToListAsync();
            }


            public async Task<Tour> GetItemAsync(int id)
            {
                await Init();
                return await Database.Table<Tour>().Where(i => i.id_tour == id).FirstOrDefaultAsync();
            }

            public async Task<int> SaveItemAsync(Tour item)
            {
                await Init();
                if (item.id_tour != 0)
                    return await Database.UpdateAsync(item);
                else
                    return await Database.InsertAsync(item);
            }

            public async Task<int> DeleteItemAsync(Tour item)
            {
                await Init();
                return await Database.DeleteAsync(item);
            }
        }
    }
}
