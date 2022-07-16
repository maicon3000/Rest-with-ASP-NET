using System.Text;

namespace RestWithASPNET5.V2.Hypermedia
{
    public class HyperMediaLink
    {
        public string Rel { get; set; }
        public string href;
        public string Href {
            get
            {
                object _lock = new object();
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("%2f", "/").ToString();
                }
            }
            set { href = value; }
        }
        public string Type { get; set; }
        public string Action { get; set; }
    }
}
