using Estacionamientos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF.Dominio.Repositorio
{
    public class Provincias
    {
        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();

        public Provincias()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        internal Provincia BuscarProvincia(int IDProvincia)
        {
            var elResultado = _contexto.Provincias.Find(IDProvincia);
            return elResultado;
        }
    }
}