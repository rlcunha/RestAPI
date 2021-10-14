using DitaliaAPI.Hypermedia;
using System.Collections.Generic;

namespace DitaliaAPI.HyperMedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
