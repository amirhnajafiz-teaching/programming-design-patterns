using System.Collections;
using System.Collections.Generic;

namespace Filter
{
    public abstract class OrFilter : IFilter
    {
        public abstract List<Item> MatchItems(List<Item> items);
    }
}