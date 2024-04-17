using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_dom
{
    public interface IPoprawialny<T> where T : class
    {
        T PobierzLepszaWersje();
    }
}
