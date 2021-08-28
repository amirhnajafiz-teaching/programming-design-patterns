using System.Collections;
using System.Collections.Generic;

namespace Filter
{
    public abstract class AndFilter : IFilter
    {
        public abstract List<Item> MatchItems(List<Item> items);
    }
}