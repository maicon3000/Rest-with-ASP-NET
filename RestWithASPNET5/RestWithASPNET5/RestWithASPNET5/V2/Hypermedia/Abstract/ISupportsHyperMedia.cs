using System.Collections.Generic;

namespace RestWithASPNET5.V2.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
