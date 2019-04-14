using System;
using System.Collections.Generic;
using Estacionamientos.Model;

namespace WCF.Dominio.Accion
{
    public class Estacionamientos
    {
        public IList<Estacionamiento> ListarRegistrosPorProvincia(int IDProvincia)
        {
            var elRepositorio = new Repositorio.Estacionamientos();
            var elResultado = elRepositorio.ListarRegistrosPorProvincia(IDProvincia);
            return elResultado;
        }

        public IList<Estacionamiento> ListarRegistrosPorRangoDeFecha(DateTime fechaInicial, DateTime fechaFinal)
        {
            var elRepositorio = new Repositorio.Estacionamientos();
            var elResultado = elRepositorio.ListarRegistrosPorRangoDeFechas(fechaInicial, fechaFinal);
            return elResultado;
        }

    }
}