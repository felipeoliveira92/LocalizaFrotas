using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizaFrotasDomain
{
    public class Veiculo
    {
        public Guid Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string AnoFabricacao { get; set; }
    }
}
