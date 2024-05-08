namespace WebAppL.Models
{
    public class CounterModel
    {
        public int _count_plus { get; set; }
        public int _count_minus { get; set; }
        public int _count_all { get; set; }
        public int _count_otherall { get; set; }

        public void Count(string Text)
        {
            int i = 0;
            while (Text.Length-1 > i)
            {
                i++;
                if (Text[i] == '+')
                {
                    _count_plus++;
                }
                if (Text[i] == '-')
                {
                    _count_minus++;
                }
            }
            _count_all = _count_minus + _count_plus;
            _count_otherall = i + 1;
        }
    }
}
