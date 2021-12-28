﻿using RestWithASP_NET5.API.Hypermedia;
using RestWithASP_NET5.API.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
