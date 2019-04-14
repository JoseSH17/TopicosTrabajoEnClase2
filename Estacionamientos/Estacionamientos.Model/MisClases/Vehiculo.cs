using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamientos.Model
{
    public partial class Vehiculo
    {
        Fabricante fabricante = new Fabricante();
        Pai pais = new Pai();
        RegionContinente regionContinente = new RegionContinente();
        Continente continente = new Continente();
        TipoVehiculo tipoVehiculo = new TipoVehiculo();
        [DataMember]
        public string NombreFabricante
        {
            get {
                string nombreFabricante = "";
                if (fabricante.IDFabricante.Equals(IDFabricante))
                    nombreFabricante = fabricante.NombreFabricante;
                return nombreFabricante;
            }
            set { }
        }

        [DataMember]
        public string NombrePais
        {
            get
            {
                string nombrePaisFabricante = "";
                if (fabricante.IDFabricante.Equals(IDFabricante) && pais.IDPais.Equals(fabricante.IDPais))
                    nombrePaisFabricante = pais.NombrePais;
                return nombrePaisFabricante;
            }
            set { }
        }

        [DataMember]
        public string NombreRegionContinente
        {
            get
            {
                string nombreRegionsContinente = "";
                if (fabricante.IDFabricante.Equals(IDFabricante) && pais.IDPais.Equals(fabricante.IDPais)
                    && regionContinente.IDRegionContinente.Equals(pais.IDRegionContinente))
                    nombreRegionsContinente = regionContinente.Descripcion;
                return nombreRegionsContinente;
            }
            set { }
        }

        [DataMember]
        public string NombreContinente
        {
            get
            {
                string nombreContinente = "";
                if (fabricante.IDFabricante.Equals(IDFabricante) && pais.IDPais.Equals(fabricante.IDPais)
                    && regionContinente.IDRegionContinente.Equals(pais.IDRegionContinente)
                    && continente.IDContinente.Equals(regionContinente.IDContinente))
                    nombreContinente = continente.Descripcion;
                return nombreContinente;
            }
            set { }
        }

        [DataMember]
        public string NombreTipoVehiculo
        {
            get
            {
                string nombreTipoVehiculo = "";
                if (tipoVehiculo.IDTipoVehiculo.Equals(TipoVehiculo))
                    nombreTipoVehiculo = fabricante.NombreFabricante;
                return nombreTipoVehiculo;
            }
            set { }
        }

        [DataMember]
        public decimal AntiguedadVehiculo
        {
            get
            {
                decimal antiguedad = 0;
                decimal anioFabricacion = Ano.Value;
                if(anioFabricacion != 0)
                {
                    antiguedad = DateTime.Now.Year - anioFabricacion;
                }
                return antiguedad;
            }
            set { }
        }
    }
}
