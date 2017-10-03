using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUtilities
{
    public class Rand
    {
        private readonly Random _r;
        private Rand _instance;

        private Rand()
        {
            _r = new Random();
        }

        public Rand GetInstance()
        {
            return _instance ?? (_instance = new Rand());
        }


        public List<int> GenerateIntList(int length, int maxValue = 255)
        {
            var outList = new List<int>();
            for (var i = 0; i < length; i++)
            {
                outList.Add(_r.Next(maxValue));
            }
            return outList;
        }
    }
}
