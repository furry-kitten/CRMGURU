using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorlWithAPI.Models.Interfaces
{
    internal interface ICitySaver
    {
        string Insert(City city);
    }
}
