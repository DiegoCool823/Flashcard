using Dapper;
using MySql.Data.MySqlClient;
using System.Data;


namespace FlashcardLibrary.Data
{
    public class SqlDataAccsess : ISqlDataAccsess
    {
        private string connectionString = "server=localhost;port=3306;uid=KITEApp;pwd=KITERules!;database=flashcard_project;";


        public async Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data;
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }





    }
}
