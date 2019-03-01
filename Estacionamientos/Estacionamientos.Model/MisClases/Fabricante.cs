using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamientos.Model
{
    public partial class Fabricante
    {
        [DataMember]
        public string NombrePais  { get; set; }

        [DataMember]
        public string NombreVehiculo { get; set; }
    }
}
