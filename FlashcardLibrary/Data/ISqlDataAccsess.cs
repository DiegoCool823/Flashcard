
namespace FlashcardLibrary.Data
{
    public interface ISqlDataAccsess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}