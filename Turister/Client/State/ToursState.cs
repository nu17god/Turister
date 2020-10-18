using System;
using System.Collections.Generic;
using System.Linq;
using Turister.Shared;

namespace Turister.Client.State
{
    public class ToursState : IState<IList<Tour>>
    {
        private List<Tour> _tours;

        public event Action OnChange;

        public ToursState()
        {
            _tours = PresetData().ToList();
        }

        public IList<Tour> Data
        {
            get => _tours;
            set
            {
                _tours = value.ToList();
                OnChange?.Invoke();
            }
        }
        
        public IList<Tour> PresetData()
        {
            return new List<Tour>
            {
                new Tour
                {
                    Id = 0,
                    Title = "Прогулка по кремлю",
                    Rating = 4.7,
                    Description =
                        "Туристический маршрют по старым улицам с сохранившейся архитектурой, тематические песно пения, угощение национальной пищей, посещение маггазинов с сувенирами",

                    Images = new List<Uri>()
                    {
                        new Uri(
                            "https://lh3.googleusercontent.com/proxy/bdqY7Jl_QNhqJbdiNv5NMNJD8RWUdUJxMtgQ_fvG-Cc0gc9rxvZ_kBY0FgecXZFl7iZJ-abqGxt1Tp-Tap0enDOm2Eq4")
                    },

                    Tags = new List<Tag>
                    {
                        new Tag {Title = "История"},
                        new Tag {Title = "Историческая достопримечательность"},
                        new Tag {Title = "Для всей семьи"},
                        new Tag {Title = "Раскопки"},
                        new Tag {Title = "Парковка рядом"}
                    },
                    Time = new TimeSpan(2,30,0),
                    Distance = 3.2,
                    PlacesId = new List<int>{1, 2, 3}
            }
            };
        }
    }
}
