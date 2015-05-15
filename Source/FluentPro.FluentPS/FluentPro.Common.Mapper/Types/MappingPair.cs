using FluentPro.Common.Mapper.Interfaces;

namespace FluentPro.Common.Mapper.Types
{
    public class MappingPair
    {
        public MappingPair(IMappingObject src, IMappingObject dest)
        {
            Src = src;
            Dest = dest;
        }

        public IMappingObject Src { get; set; }

        public IMappingObject Dest { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 63;
                hash ^= hash * Src.GetHashCode();
                hash ^= hash * Dest.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var pair = obj as MappingPair;
            if (pair == null)
            {
                return false;
            }

            return pair.Src.Equals(Src) && pair.Dest.Equals(Dest);
        }
    }
}
