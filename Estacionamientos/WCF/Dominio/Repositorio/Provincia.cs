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

        public Provincia()
        {
            _contexto.Configuration.ProxyCreationEnabled = false;
            _contexto.Configuration.LazyLoadingEnabled = true;
        }

        public Provincia BuscarProvincia(int IDProvincia)
        {
            var elResultado = _contexto.Provincias.Find(IDProvincia);
            var elNuevoResultado = CompletarPropiedadesDeNavegacion(elResultado);
            return elNuevoResultado;
        }

        private IList<Provincia> CompletarPropiedadesDeNavegacion(IList<Provincia> laListaDeProvincias)
        {
            var elRepositorioCantonesModels = new ModelosDeCantones();
            IList<Product> elResultado = new List<Product>();
            foreach (var elProducto in laListaDeProductos)
            {
                if (elProducto.ProductModelID != null)
                {
                    elProducto.ProductModelName = elRepositorioDeProductModels.BuscarModeloDeProducto(elProducto.ProductModelID).Name;
                }
                if (elProducto.ProductSubcategoryID != null)
                {
                    var laSubCategoria = elRepositorioDeSubcategory.BuscarSubcategoria(elProducto.ProductSubcategoryID);
                    elProducto.ProductSubCategoryName = laSubCategoria.Name;
                    elProducto.ProductCategoryName = elRepositorioDeCategory.BuscarCategoria(laSubCategoria.ProductCategoryID).Name;
                }
                elResultado.Add(elProducto);
            }
            return elResultado;
        }
    }
}