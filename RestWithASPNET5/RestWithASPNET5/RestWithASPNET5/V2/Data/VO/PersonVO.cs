using RestWithASPNET5.Hypermedia;
using RestWithASPNET5.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASPNET5.V2.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
