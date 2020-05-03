using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;

namespace RECSClimate
{
    public class ContributorDatabase
    {
        readonly SQLiteAsyncConnection database;
        public ContributorDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Contributor>().Wait();
        }

        public Task<List<Contributor>> GetContributorsAsync()
        {
            return database.Table<Contributor>().ToListAsync();
        }

        public Task<List<Contributor>> GetContributorsNotDoneAsync()
        {
            return database.QueryAsync<Contributor>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Contributor> GetContributorAsync(int id)
        {
            return database.Table<Contributor>().Where(i => i.ContributorID == id).FirstOrDefaultAsync();

        }

        public Task<int> SaveContributorAsync(Contributor contributor)
        {
            if (contributor.ContributorID != 0)
            {
                return database.UpdateAsync(contributor);
            }
            else
            {
                return database.InsertAsync(contributor);
            }
        }

        public Task<int> DeleteContributorAsync(Contributor contributor)
        {
            return database.DeleteAsync(contributor);
        }
    }
}
