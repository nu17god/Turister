using System.Collections.Generic;

namespace Turister.Shared
{
    public class Filter
    {
        public IList<Tag> Tags { get; set; }
        public double MinRate { get; set; }
        public double MaxDistance { get; set; }
    }
}