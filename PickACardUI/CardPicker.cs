using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();
        /// <summary>
        /// Picks a number of cards amd returns them.
        /// </summary>
        /// <param name="numberOfCards">The number of cards to pick.</param>
        /// <returns>An array of strings that contain the card names.</returns>
        public static string[] PickSomeCards(int numberOfCards) 
        {
            string[] pickedCards = new string[numberOfCards];
            /*Creates a string array variable called pickedCards which store a array of strings.
             * The amount of arrays is determined by numberOfCards int value */


            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // get a random number from 1 - 4.
            int value = random.Next(1, 5);

            // if it's 1, return the string spades.
            if (value == 1) 
            {
                return "Spades";
            }

            // if it is 2, return the string hearts.
            if (value == 2)
            {
                return "hearts";
            }

            // if its 3, return the string clubs.
            if (value == 3)
            {
                return "clubs";
            }

            // if we have not returned yet, return diamonds.
            else
            {
                return "diamonds";
            }
        }

        private static string RandomValue()
        {
            // Gets a random number from 1 to 13 to use as the card value.
            int value = random.Next(1, 14);

            // If No is 1 then the card is Ace.
            if (value == 1)
            {
                return "Ace";
            }
            
            // If the number is 11 then the card is Jack.
            if (value == 11)
            {
                return "Jack";
            }

            // If the number is 12 then the card is Queen.
            if (value == 12)
            {
                return "Queen";
            }

            // If the number is 13 then the card is King.
            if (value == 13)
            {
                return "King";
            }

            //Any other number not the above will be the actual card number then after converted into a string.
            else
            {
                return value.ToString();
            }

        }
    }
}
