using Estacionamientos.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WCF.Dominio.Repositorio
{
    public class Estacionamientos
    {

        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        public Estacionamientos()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        internal IList<Estacionamiento> ListarRegistrosPorRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();
            elResultado = _contexto.Estacionamientoes.Where(
                f => fechaInicio <= f.FechaHoraIngreso && f.FechaHoraSalida <= fechaFin).OrderByDescending(o => o.FechaHoraIngreso).ToList();
            return elResultado;
        }

        internal IList<Estacionamiento> ListarRegistrosPorProvincia(int IDProvincia)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();
            //elResultado = _contexto.Estacionamientoes.Where(
            //    p => fechaInicio <= f.FechaHoraIngreso && f.FechaHoraSalida <= fechaFin).OrderByDescending(o => o.FechaHoraIngreso).ToList();
            //return elResultado;
            return null;
        }
    }
}