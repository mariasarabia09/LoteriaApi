using LoteriaApi.Repositories;
using System.Web.Http;

namespace LoteriaApi.Controllers
{
    [RoutePrefix("cards")]
    public class CardsController : ApiController
    {
        private readonly ICardRepository _cardRepository;

        public CardsController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetCards()
        {
            var cards = _cardRepository.GetAllCards();

            return Ok(cards);
        }
    }
}