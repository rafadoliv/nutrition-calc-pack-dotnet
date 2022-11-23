using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double CalcImc(double Height, double Weight);
        string GetIMCCategory(double IMC);
        bool IsValid(double Height, double Weight);
    }
}
