using System.Text;

namespace DitaliaAPI.Hypermedia
{
    public class HyperMediaLink
    {
        public string Rel { get; set; }
        private string href; //%2f
        public string Href
        {
            get
            {
                object _lock = new();
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("%2F", "/").ToString();
                }
            }
            set { href = value; }
        }//a2f
        public string Type { get; set; }
        public string Action { get; set; }
    }
}
