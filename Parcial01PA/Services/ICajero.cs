using Parcial01PA.Models;

namespace Parcial01PA.Services
{
    public interface ICajero
    {
        public int Verificar(ActionCajero cajero);
        public int Retirar();
    }
}
