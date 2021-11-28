using LoteriaApi.Data;
using LoteriaApi.Models;
using System.Linq;

namespace LoteriaApi.Repositories
{
    public interface ICardRepository
    {
        Card[] GetAllCards();
    }

    public class CardRepository : ICardRepository
    {
        public Card[] GetAllCards()
        {
            using (var context = new LoteriaContext())
            {
                return context.Cards.ToArray();
            }
        }
    }
}