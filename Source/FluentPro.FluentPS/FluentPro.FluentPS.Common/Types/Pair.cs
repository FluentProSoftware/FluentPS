namespace FluentPro.FluentPS.Common.Types
{
    public class Pair<TFirst, TSecond>
    {
        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public TFirst First { get; set; }

        public TSecond Second { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 63;
                hash ^= hash * First.GetHashCode();
                hash ^= hash * Second.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var pair = obj as Pair<TFirst, TSecond>;
            if (pair == null)
            {
                return false;
            }

            return pair.First.Equals(First) && pair.Second.Equals(Second);
        }
    }
}
