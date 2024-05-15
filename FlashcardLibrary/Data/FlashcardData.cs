using FlashcardLibrary.Models;
using System.Collections;

namespace FlashcardLibrary.Data
{
    public class FlashcardData : IFlashcardData
    {
        private readonly ISqlDataAccsess _db = new SqlDataAccsess();

        public async Task CreateFlashcard(FlashcardModel card)
        {
            string sql = "INSERT INTO flashcard_model (flashcard_set_name, flashcard_number, front_side, front_image, back_side, back_image) VALUES (@flashcard_set_name, @flashcard_number, @front_side, @front_image, @back_side, @back_image);";
            await _db.SaveData(sql, card);
        }

        public async Task<List<FlashcardModel>> ReadAllFlashcards()
        {

            string sql = "SELECT * FROM `flashcard_model`";
            IEnumerable<FlashcardModel> cards = await _db.LoadData<FlashcardModel, dynamic>(sql, new { });
            return cards.ToList();
        }

        public async Task<FlashcardModel> ReadFlashCardByID(int id)
        {
            string sql = "SELECT * FROM flashcard_model WHERE flashcard_model.id = @id";
            IEnumerable<FlashcardModel> result = await _db.LoadData<FlashcardModel, dynamic>(sql, new { id });
            List<FlashcardModel> cards = result.ToList();
            if (cards.Count > 0) { return cards[0]; }
            return null;
        }


        public async Task UpdateFlashcard(FlashcardModel card)
        {
            string sql = "UPDATE flashcard_model SET flashcard_set_name = @flashcard_set_name, flashcard_number = @flashcard_number, front_side = @front_side, front_image = @front_image, back_side = @back_side, back_image = @back_image WHERE flashcard_model.id = @id;";
            await _db.SaveData(sql, card);
        }

        public async Task DeleteFlashcard(FlashcardModel card)
        {
            string sql = "DELETE FROM flashcard_model WHERE flashcard_model.id = @id";
            await _db.SaveData(sql, card);
        }

        public async Task<List<FlashcardSetModel>> LoadFlashcardList()
        {
            string sql = "SELECT * FROM `flashcard_sets`";
            IEnumerable<FlashcardSetModel> fList = await _db.LoadData<FlashcardSetModel, dynamic>(sql, new { });

            return fList.ToList();
        }

        //public async Task <List<FlashcardSetModel>>




    }





}




    

