using System;
using System.Collections.Generic;

namespace Turister.Shared
{
    public class Place
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Tag> Tags { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public List<Uri> Images { get; set; }
    }
}