using FlashcardLibrary.Models;

namespace FlashcardLibrary.Data
{
    public interface IFlashcardData
    {
        Task CreateFlashcard(FlashcardModel card);
        Task DeleteFlashcard(FlashcardModel card);
        Task<List<FlashcardSetModel>> LoadFlashcardList();  
            Task<List<FlashcardModel>> ReadAllFlashcards();
        Task<FlashcardModel> ReadFlashCardByID(int id);
        Task UpdateFlashcard(FlashcardModel card);
    }
}