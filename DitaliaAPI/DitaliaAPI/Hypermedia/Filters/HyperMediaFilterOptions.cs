using DitaliaAPI.HyperMedia.Abstract;
using System.Collections.Generic;

namespace DitaliaAPI.HyperMedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
