using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardLibrary.Models
{
    public class FlashcardSetModel
    {

        public int ID { get; set; }
        public string set_name { get; set; }
        public int card_amount { get; set; }

        public override string ToString()
        {
            string output;

            output = $"ID: {ID}\nset_name: {set_name} card_amount: {card_amount}";
            return output;
        }


    }
}
