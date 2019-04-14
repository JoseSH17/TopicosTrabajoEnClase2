using System;
using System.Collections.Generic;
using Estacionamientos.Model;

namespace WCF.Dominio.Especificacion
{
    public class Estacionamientos
    {
        public IList<Estacionamiento> ListarRegistrosPorRangoDeFecha(DateTime fechaInicial, DateTime fechaFinal)
        {
            var laAccion = new Accion.Estacionamientos();
            var elResultado = laAccion.ListarRegistrosPorRangoDeFecha(fechaInicial,fechaFinal);
            return elResultado;
        }

        public IList<Estacionamiento> ListarRegistrosPorProvincia(int IDProvincia)
        {
            var laAccion = new Accion.Estacionamientos();
            var elResultado = laAccion.ListarRegistrosPorProvincia(IDProvincia);
            return elResultado;
        }
    }
}