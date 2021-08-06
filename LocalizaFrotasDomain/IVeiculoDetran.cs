using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaFrotasDomain
{
    public interface IVeiculoDetran
    {
        public Task AgendarVistoriaDetran(Guid veiculoId);
    }
}
