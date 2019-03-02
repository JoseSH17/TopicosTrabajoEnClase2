using Estacionamientos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF.Dominio.Repositorio
{
    public class Provincia
    {
        static private ExamenAnalisisEntities _contexto = new ExamenAnalisisEntities();
        public Provincia BuscarProvincia(int IDProvincia)
        {
            var elResultado = _contexto.Provincias.Find(IDProvincia);
            return elResultado;
        }
    }
}