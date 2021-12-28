using RestWithASP_NET5.API.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASP_NET5.API.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
