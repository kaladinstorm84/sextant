using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sextant.Data
{
    public class Relation
    {
        public string RelationFrom { get; set; }
        public string RelationTo { get; set; }
        public RelationType Type { get; set; }
    }
    public enum RelationType
    {
        Single,
        SingleLong,
        Double,
        DoubleLong,
    }
}
