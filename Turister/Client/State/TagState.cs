using System.Collections.Generic;
using Turister.Shared;

namespace Turister.Client.State
{
    public class TagState : StateBase<List<Tag>>
    {
        protected override List<Tag> PresetData()
        {
            return new List<Tag>()
            {
                new Tag {Title = "История"},
                new Tag {Title = "Историческая достопримечательность"},
                new Tag {Title = "Для всей семьи"},
                new Tag {Title = "Раскопки"},
                new Tag {Title = "Парковка рядом"},
                new Tag {Title = "Отель"},
            };
        }
    }
}