using System;
using System.Collections.Generic;
using System.Linq;
using Turister.Shared;

namespace Turister.Client.State
{
    public class PlacesState : IState<IList<Place>>
    {
        private List<Place> _places;
        public event Action OnChange;

        public PlacesState()
        {
            _places = PresetData().ToList();
        }

        public IList<Place> Data
        {
            get => _places;
            set
            {
                _places = value.ToList();
                OnChange?.Invoke();
            }
        }

        public IList<Place> PresetData()
        {
            return new List<Place>()
            {
                new Place
                {
                    Id = 0,
                    Title = "Старая Рязань",
                    Description = "Ста́рая Ряза́нь (до 1778 года — Рязань, неоф. «Русская Троя») — один из крупнейших древнерусских городов XII—XIII веков, столица Великого Рязанского княжества. Площадь одних только укреплений Старой Рязани во второй половине XII века, не считая городских посадов достигает более 60 га, с предместьями — 75 га. К началу XIII века в городе проживало около 8 тыс. человек[1]. У подножья городских валов располагается современное село Старая Рязань.",

                    Images = new List<Uri>() {new Uri("https://mediaryazan.ru/upload/iblock/41c/26%20-%20jfwn%20kkjxwcuakx%20rbdosext.jpg_Thumbnail0.jpg")},

                    Rating = 4.8,
                    
                    Tags = new List<Tag>()
                    {
                        new Tag {Title = "История"},
                        new Tag {Title = "Историческая достопримечательность"},
                        new Tag {Title = "Для всей семьи"},
                        new Tag {Title = "Раскопки"},
                        new Tag {Title = "Парковка рядом"}
                    },
                },

                new Place
                {
                    Id = 1,
                    Title = "Успенский собор",
                    Description = "Успенский собор Рязанского Кремля построен в 1693—1699 годах зодчим из крепостных Яковом Григорьевичем Бухвостовым. Стилизованное изображение собора является одним из символов Рязани.",

                    Images = new List<Uri>() {new Uri("https://posmotrim.by/pics/d6d77f3c9.jpg") },

                    Rating = 4.5,

                    Tags = new List<Tag>()
                    {
                        new Tag {Title = "История"},
                        new Tag {Title = "Историческая достопримечательность"},
                        new Tag {Title = "Для всей семьи"},
                        new Tag {Title = "Парковка рядом"}
                    },
                },

                new Place
                {
                    Id = 2,
                    Title = "Соборная колокольня",
                    Description = "Соборная колокольня — памятник архитектуры XVIII—XIX веков, построенный в стиле классицизма. По настоящее время остаётся одним из самых высоких зданий города и Рязанской области (общая высота 83,2 метра).",

                    Images = new List<Uri>() {new Uri("https://upload.wikimedia.org/wikipedia/commons/e/ed/%D0%9A%D0%BE%D0%BB%D0%BE%D0%BA%D0%BE%D0%BB%D1%8C%D0%BD%D1%8F_%D0%A0%D1%8F%D0%B7%D0%9A%D1%80%D0%B5%D0%BC%D0%BB%D1%8F.jpg") },

                    Rating = 4.2,

                    Tags = new List<Tag>()
                    {
                        new Tag {Title = "История"},
                        new Tag {Title = "Историческая достопримечательность"},
                        new Tag {Title = "Для всей семьи"},
                        new Tag {Title = "Парковка рядом"}
                    },
                },

                new Place
                {
                    Id = 3,
                    Title = "Христорождественский собор",
                    Description = "Христорожде́ственский собо́р Рязанского Кремля — православный кафедральный собор города Рязани. Наряду с Успенским собором — один из двух главных храмов Рязанской митрополии. Является первым каменным зданием на территории Рязанского Кремля, и одним из самых древних из сохранившийся до наших дней зданий Рязанской области.",

                    Images = new List<Uri>() {new Uri("https://labuda.blog/wp-content/uploads/2020/08/1245d6949d2f4891aa2a62aa8f41c3e2.jpg") },

                    Rating = 5,

                    Tags = new List<Tag>()
                    {
                        new Tag {Title = "История"},
                        new Tag {Title = "Историческая достопримечательность"},
                        new Tag {Title = "Для всей семьи"},
                        new Tag {Title = "Парковка рядом"}
                    },
                },
            };
        }
    }
}