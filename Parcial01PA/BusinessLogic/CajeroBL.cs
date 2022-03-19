using Parcial01PA.Models;
using Parcial01PA.Services;

namespace Parcial01PA.BusinessLogic
{
    public class CajeroBL : ICajero
    {
        public int Retirar()
        {
            return 0;
        }

        public int Verificar(ActionCajero cajero)
        {
            int res = cajero.Monto;
            if(res % 5 == 0){
                res = 0;
            }
           return res;
        }
    }
}
