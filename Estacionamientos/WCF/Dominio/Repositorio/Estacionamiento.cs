using Estacionamientos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF.Dominio.Repositorio
{
    public class Estacionamiento
    {

        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        public Estacionamiento()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        internal List<Estacionamiento> ListarRegistrosPorRangoDeFechas(DateTime PrimeraFecha, DateTime SegundaFecha)
        {
            IList<Estacionamiento> elResultado = new List<Estacionamiento>();
            elResultado = _contexto.Estacionamientoes.Where(
                p => PrimeraFecha <= p.FechaHoraIngreso && p.FechaHoraSalida <= SegundaFecha).OrderByDescending(o => o.IDParqueo).ToList();
            var elNuevoResultado = elResultado;
            return elNuevoResultado;
        }
    }
}