using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    public class ItemsCarousel
    {
        public ItemsCarousel(string id, string text, string image)
        {
            Id = id;
            Text = text;
            this.image = image;
        }

        public string Id { get; set; }
        public string Text { get; set; }
        public string image { get; set; }
    }
}
