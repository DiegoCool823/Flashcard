using FlashcardLibrary.Models;

namespace Flashcard.Services
{
    public interface IFlashcardService
    {
        Task AddFlashcard(FlashcardModel card);
        Task<List<FlashcardModel>> GetAllFlashcards();
        Task<FlashcardModel> GetFlashcardByID(int id);
        Task RemoveFlashcard(FlashcardModel card);
        Task SaveFlashCard(FlashcardModel card);

        Task<List<FlashcardSetModel>> LoadFlashcardList();
    }
}