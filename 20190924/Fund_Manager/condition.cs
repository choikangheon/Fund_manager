using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fund_Manager
{
    public class condition
    {
        public int index; //조건식 인덱스
        public string name; //조건식 이름

        public condition(int index, string name)
        {
            this.index = index;
            this.name = name;
        }
    }
}
