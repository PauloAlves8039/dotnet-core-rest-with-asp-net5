using System.Collections.Generic;

namespace RestWithASP_NET5.API.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
