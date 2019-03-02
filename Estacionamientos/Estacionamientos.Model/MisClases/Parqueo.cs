using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamientos.Model
{
    public partial class Parqueo
    {
        Distrito distrito = new Distrito();
        Canton canton = new Canton();
        Provincia provincia = new Provincia();
        [DataMember]
        public string NombreDistrito
        {
            get {
                string nombreDistrito = "";
                if (distrito.ConsecutivoDistrito.Equals(ConsecutivoDistrito))
                    nombreDistrito = distrito.Descripcion;
                return nombreDistrito;
            }
            set { }
        }

        [DataMember]
        public string NombreCanton
        {
            get {
                string nombreCanton = "";
                if (distrito.ConsecutivoDistrito.Equals(ConsecutivoDistrito) && canton.IDCanton.Equals(distrito.Canton))
                    nombreCanton = canton.Descripcion;
                return nombreCanton;
            }
            set { }
        }

        [DataMember]
        public string NombreProvincia
        {
            get {
                string nombreProvincia = "";
                if (distrito.ConsecutivoDistrito.Equals(ConsecutivoDistrito) && canton.IDCanton.Equals(distrito.Canton) && provincia.IDProvincia.Equals(distrito.IDProvincia))
                    nombreProvincia = provincia.Descripcion;
                return nombreProvincia;
                }
            set { }
        }

    }
}
