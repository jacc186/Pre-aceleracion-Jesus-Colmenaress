using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLModels
{
    public interface IModels
    {
        int Id { get; set; }
        string Img { get; set; }
        string Name { get; set; }

    }
}
