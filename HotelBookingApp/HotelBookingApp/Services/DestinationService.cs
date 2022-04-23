using System.Collections.Generic;
using HotelBookingApp.Models;

namespace HotelBookingApp.Services
{
    public class DestinationService
    {
        static DestinationService _instance;

        public static DestinationService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DestinationService();

                return _instance;
            }
        }

        internal List<GalleryItem> Gallery
        {
            get
            {
                return new List<GalleryItem>
                {
                    new GalleryItem { Id = 1, Image = "destination1.jpg" },
                    new GalleryItem { Id = 2, Image = "destination2.jpg" },
                    new GalleryItem { Id = 3, Image = "destination3.jpg" },
                    new GalleryItem { Id = 4, Image = "destination4.jpg" }
                };
            }
        }

        public List<Destination> RecommendedDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Emirates Palace", Place = "Abu Dhabi", Image = "destination1.jpg", Price = 120, About = "When it comes to luxurious hotels, this one is at the top. Costing approximately $3 billion to build, Emirates Palace has 394 grand rooms and suites, 40 meeting and conference rooms, a white sand beach, a myriad of pools and fountains, two sumptuous spas, marble imported from 13 different countries and over 1,000 Swarovski crystal chandeliers. It’s like a small pleasure fortress that also boasts the most prestigious marina development in the Middle East. Royalty, or those who want to feel like it, can luxuriate in one of the many palace suites, all with lavish surroundings that would befit a Sultan of old yet with enough modern amenities to please today’s top tycoons.", Gallery = Gallery },
                    new Destination { Name = "Mardan Palace", Place = "Turkey", Image = "destination2.jpg", Price = 90, About = "ardan Palace is a luxury hotel based in Lara, Antalya with a reported cost of approximately $1.4 billion. With over 560 hotel rooms, it is commonly known as Europe’s most expensive luxury resort. Facilities include a 12,000 sq ft spa, 4 aquariums, 5 acres of pool plus a personal beach for the guests with sand imported from Egypt.Perfect for travelers wishing to combine comfort with luxury, the hotel includes velvet lined furniture, exotic wood floors and marble bathroom interiors.", Gallery = Gallery },
                    new Destination { Name = "Taj Lake Palace", Place = "Rajasthan, India", Image = "destination3.jpg", Price = 60, About = "Located in the middle of a lake in Rajasthan, this white marble palace was built in 1740. Former country residence of an Indian prince, it has retained its opulence. Its old-style furnished suites, terraces and spa have made it a romantic paradise for lovers who can afford it.", Gallery = Gallery },
                    new Destination { Name = "Soneva Jani", Place = "Noonu Atoll, Maldives", Image = "destination4.jpg", Price = 120, About = "Extravagant overwater villas tricked out with waterslides (and serviced by personal butlers) are divided into two sections at Soneva Jani, with Chapter Two having 27 newer and slightly larger villas. All guests can make use of the lush spa and the overwater cinema, plus watercraft, snorkel and dive equipment, surfboards, and more. Book a private beach dinner or sunrise breakfast for a truly unforgettable experience.", Gallery = Gallery },
                };
            }
        }

        public List<Destination> TopDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Taj Lake Palace", Place = "Rajasthan, India", Image = "destination3.jpg", Price = 60, About = "Located in the middle of a lake in Rajasthan, this white marble palace was built in 1740. Former country residence of an Indian prince, it has retained its opulence. Its old-style furnished suites, terraces and spa have made it a romantic paradise for lovers who can afford it.", Gallery = Gallery },
                    new Destination { Name = "Soneva Jani", Place = "Noonu Atoll, Maldives", Image = "destination4.jpg", Price = 120, About = "Extravagant overwater villas tricked out with waterslides (and serviced by personal butlers) are divided into two sections at Soneva Jani, with Chapter Two having 27 newer and slightly larger villas. All guests can make use of the lush spa and the overwater cinema, plus watercraft, snorkel and dive equipment, surfboards, and more. Book a private beach dinner or sunrise breakfast for a truly unforgettable experience.", Gallery = Gallery },
                    new Destination { Name = "Emirates Palace", Place = "Abu Dhabi", Image = "destination1.jpg", Price = 120, About = "When it comes to luxurious hotels, this one is at the top. Costing approximately $3 billion to build, Emirates Palace has 394 grand rooms and suites, 40 meeting and conference rooms, a white sand beach, a myriad of pools and fountains, two sumptuous spas, marble imported from 13 different countries and over 1,000 Swarovski crystal chandeliers. It’s like a small pleasure fortress that also boasts the most prestigious marina development in the Middle East. Royalty, or those who want to feel like it, can luxuriate in one of the many palace suites, all with lavish surroundings that would befit a Sultan of old yet with enough modern amenities to please today’s top tycoons.", Gallery = Gallery },
                    new Destination { Name = "Mardan Palace", Place = "Turkey", Image = "destination2.jpg", Price = 90, About = "ardan Palace is a luxury hotel based in Lara, Antalya with a reported cost of approximately $1.4 billion. With over 560 hotel rooms, it is commonly known as Europe’s most expensive luxury resort. Facilities include a 12,000 sq ft spa, 4 aquariums, 5 acres of pool plus a personal beach for the guests with sand imported from Egypt.Perfect for travelers wishing to combine comfort with luxury, the hotel includes velvet lined furniture, exotic wood floors and marble bathroom interiors.", Gallery = Gallery },
                    new Destination { Name = "Taj Lake Palace", Place = "Rajasthan, India", Image = "destination3.jpg", Price = 60, About = "Located in the middle of a lake in Rajasthan, this white marble palace was built in 1740. Former country residence of an Indian prince, it has retained its opulence. Its old-style furnished suites, terraces and spa have made it a romantic paradise for lovers who can afford it.", Gallery = Gallery },
                    new Destination { Name = "Soneva Jani", Place = "Noonu Atoll, Maldives", Image = "destination4.jpg", Price = 120, About = "Extravagant overwater villas tricked out with waterslides (and serviced by personal butlers) are divided into two sections at Soneva Jani, with Chapter Two having 27 newer and slightly larger villas. All guests can make use of the lush spa and the overwater cinema, plus watercraft, snorkel and dive equipment, surfboards, and more. Book a private beach dinner or sunrise breakfast for a truly unforgettable experience.", Gallery = Gallery },
                    new Destination { Name = "Emirates Palace", Place = "Abu Dhabi", Image = "destination1.jpg", Price = 120, About = "When it comes to luxurious hotels, this one is at the top. Costing approximately $3 billion to build, Emirates Palace has 394 grand rooms and suites, 40 meeting and conference rooms, a white sand beach, a myriad of pools and fountains, two sumptuous spas, marble imported from 13 different countries and over 1,000 Swarovski crystal chandeliers. It’s like a small pleasure fortress that also boasts the most prestigious marina development in the Middle East. Royalty, or those who want to feel like it, can luxuriate in one of the many palace suites, all with lavish surroundings that would befit a Sultan of old yet with enough modern amenities to please today’s top tycoons.", Gallery = Gallery },
                    new Destination { Name = "Mardan Palace", Place = "Turkey", Image = "destination2.jpg", Price = 90, About = "ardan Palace is a luxury hotel based in Lara, Antalya with a reported cost of approximately $1.4 billion. With over 560 hotel rooms, it is commonly known as Europe’s most expensive luxury resort. Facilities include a 12,000 sq ft spa, 4 aquariums, 5 acres of pool plus a personal beach for the guests with sand imported from Egypt.Perfect for travelers wishing to combine comfort with luxury, the hotel includes velvet lined furniture, exotic wood floors and marble bathroom interiors.", Gallery = Gallery },
                };
            }
        }
    }
}