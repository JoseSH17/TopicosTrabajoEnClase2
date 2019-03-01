using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamientos.Model
{
    public partial class DiasFeriadosAnuale
    {   
        [DataMember]
        public List<DiasFeriados> ListaFeriados
        {
            get {
                var feriados = new List<DiasFeriados>();
               
                var feriado = new DiasFeriados()
                {
                    mes = MesFeriado,
                    dia = DiaFeriado,
                    nombre = NombreFeriado
                };

                feriados.Add(feriado);
                return feriados;
            }
            set { }
        } 
        
    }
}
