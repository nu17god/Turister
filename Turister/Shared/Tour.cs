using System;
using System.Collections.Generic;

namespace Turister.Shared
{
    public class Tour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Tag> Tags { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public List<Uri> Images { get; set; }
        public List<int> PlacesId { get; set; }
        public double Distance { get; set; }
        public TimeSpan Time { get; set; }
    }
}