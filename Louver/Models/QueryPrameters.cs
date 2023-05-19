namespace Louver.Models
{
    public class QueryPrameters
    {
        const int _maxSize = 100;
        private int _Size = 50;
        public int page { get; set; } = 1;
        public int size {
            get { return _Size; }
            set { _Size=Math.Min(_maxSize,value); }
        }

    }
}
