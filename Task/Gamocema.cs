using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public abstract class Gamocema<T>
    {
        public abstract List<T> DisplayInformation(List<T> Information);

        public abstract List<T> SearchByYear(List<T> Information,int year);
    }
}
