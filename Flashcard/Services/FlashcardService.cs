using FlashcardLibrary.Data;
using FlashcardLibrary.Models;



namespace Flashcard.Services
{
    public class FlashcardService : IFlashcardService
    {

        private IFlashcardData _db = new FlashcardData();

        public async Task<List<FlashcardModel>> GetAllFlashcards()
        {
            List<FlashcardModel> cards = await _db.ReadAllFlashcards();
            return cards;

        }

        public async Task<FlashcardModel> GetFlashcardByID(int id)
        {
            FlashcardModel card = await _db.ReadFlashCardByID(id);
            return card;
        }

        public async Task SaveFlashCard(FlashcardModel card)
        {
            await _db.UpdateFlashcard(card);
        }

        public async Task AddFlashcard(FlashcardModel card)
        {
            await _db.CreateFlashcard(card);
        }

        public async Task RemoveFlashcard(FlashcardModel card)
        {
            await _db.DeleteFlashcard(card);
        }

        public async Task <List<FlashcardSetModel>>LoadFlashcardList()
        {
           
           return await _db.LoadFlashcardList();
        }

    }
}
