using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardLibrary.Models
{
    public class FlashcardModel
    {
        public int ID { get; set; }
        public string flashcard_set_name { get; set; }
        public int flashcard_number { get; set; }
        public string front_side { get; set; }
        public string front_image { get; set; }
        public string back_side { get; set; }
        public string back_image {  get; set; }

         public override string ToString()
        {
            string output;

            output = $"ID: {ID}\nflashcard_set_name: {flashcard_set_name} flashcard_number: {flashcard_number} front_side: {front_side}\nfront_image: {front_image} back_side: {back_side} back_image: {back_image}";



            return output;
        }

    }
}
