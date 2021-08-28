using System.Collections;
using System.Collections.Generic;

namespace Filter
{
    public interface IFilter
    {
        List<Item> MatchItems(List<Item> items);
    }
}