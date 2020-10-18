using System;
using System.Collections.Generic;
using System.Linq;
using Turister.Shared;

namespace Turister.Client.State
{
    public class PlacesState : StateBase<List<Place>>
    {
        protected override List<Place> PresetData()
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
            };
        }
    }
}