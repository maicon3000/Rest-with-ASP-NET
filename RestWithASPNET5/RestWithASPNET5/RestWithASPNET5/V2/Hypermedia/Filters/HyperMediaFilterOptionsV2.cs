using RestWithASPNET5.V2.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNET5.V2.Hypermedia.Filters
{
    public class HyperMediaFilterOptionsV2
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
