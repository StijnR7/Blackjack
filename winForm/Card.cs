using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm
{
    class Card
    {
        private string[] allTypes = { "Spades", "Clubs", "Hearts", "Diamonds" };
        private string[] allValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "K", "Q", "A", "J" };
        Random random = new();
        private string type;
        private string value;

        public string Type { get => type; }
        public string Value { get => value; }
        
        public Card(string ForcedType = "", string ForcedValue = "")
        {
            if (ForcedType == "")
            {
                type = allTypes[random.Next(allTypes.Length)];
            }
            else { type = ForcedType; }


            if (ForcedValue == "")
            {
                value = allValues[random.Next(allValues.Length)];
            }
            else { value = ForcedValue; }
           

        }

    }
}
