using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNorthDemoAPI.Controllers
{
    /// <summary>
    /// Meetup API Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class MeetupController : ControllerBase
    {
        private static readonly string[] Swag = new[]
        {
            "Bit the Raccoon", "JetBrains Licence", "Stickers", "T-Shirts", "A Windows Phone!"
        };

        private static readonly string[] Food = new[]
        {
            "Pizza"
        };

        private static readonly string[] Beverage = new[]
        {
            "Beer", "Cider", "Wine", "Fizzy Pop", "Water"
        };

        private static readonly string[] Title = new[]
        {
            "Fantastic demo", "Dot Net Shenanigans", "Alpaca Farming"
        };

        private static readonly string[] Summary = new[]
        {
            "A lovely meetup, with lovely people.", "You will learn a lot.", "I've heard there may be pizza."
        };

        private readonly ILogger<MeetupController> _logger;

        public MeetupController(ILogger<MeetupController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Create me a random meetup
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Meetup> GetRandomMeetup()
        {
            return new Meetup[] {
                (new Meetup {
                    Food = Food[new Random().Next(Food.Length)],
                    Beverages = Beverage[new Random().Next(Beverage.Length)],
                    Swag = Swag[new Random().Next(Swag.Length)],
                    Summary = Summary[new Random().Next(Summary.Length)],
                    Title = Title[new Random().Next(Title.Length)],
                    Date = (DateTime.Now.AddDays(new Random().Next(90))).Date + new TimeSpan(20, 00, 00)
                })
            };
        }

        /// <summary>
        /// Genuinely, what's the next meetup?
        /// </summary>
        /// <returns></returns>
        [HttpGet("~/Meetup/Next")]
        public IEnumerable<Meetup> GetNext()
        {
            return new Meetup[] {
                (new Meetup {
                    Food = "Order a pizza",
                    Beverages = "Whatever is in your fridge",
                    Swag = "It's a surprise",
                    Summary = "A final Dot Net North get together for 2020",
                    Title = "Dot Net North Christmas Social",
                    Date = DateTime.Parse("2020-12-15 20:00")
                })
            };
        }

        /// <summary>
        /// Please let me donate a prize for the next meetup
        /// </summary>
        /// <returns></returns>
        [HttpPost("~/Meetup/Next/DonatePrize")]
        public IEnumerable<Meetup> PostNextDonatePrize(string prize)
        {
            return new Meetup[] {
                (new Meetup {
                    Food = "Order a pizza",
                    Beverages = "Whatever is in your fridge",
                    Swag = prize,
                    Summary = "A final Dot Net North get together for 2020",
                    Title = "Dot Net North Christmas Social",
                    Date = DateTime.Parse("2020-12-15 20:00")
                })
            };
        }

        /// <summary>
        /// That next meetup, can I arrange the catering?
        /// </summary>
        /// <returns></returns>
        [HttpPost("~/Meetup/Next/SupplySustenance")]
        public IEnumerable<Meetup> PostNextSupplySustenance(Sustenance sustenance)
        {
            return new Meetup[] {
                (new Meetup {
                    Food = sustenance.Food,
                    Beverages = sustenance.Beverages,
                    Swag = "It's a surprise",
                    Summary = "A final Dot Net North get together for 2020",
                    Title = "Dot Net North Christmas Social",
                    Date = DateTime.Parse("2020-12-15 20:00")
                })
            };
        }
    }
}
