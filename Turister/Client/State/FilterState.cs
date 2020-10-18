using System.Collections.Generic;
using System.Linq;
using Turister.Shared;

namespace Turister.Client.State
{
    public class FilterState : StateBase<Filter>
    {
        protected override Filter PresetData()
        {
            return new Filter
            {
                Tags = new List<Tag>(),
                MinRate = 0,
                MaxDistance = 300,
            };
        }

        public void ClearFilter()
        {
            Data = PresetData();
        }

        public void AddTag(Tag tag)
        {
            if (Data.Tags.All(t => t.Title != tag.Title))
            {
                Data.Tags.Add(tag);
            }
        }

        public void RemoveTag(Tag tag)
        {
            Data.Tags = Data.Tags.Where(t => t.Title != tag.Title).ToList();
        }
    }
}