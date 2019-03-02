using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamientos.Model
{
    public partial class Estacionamiento
    {
        [DataMember]
        public string Feriados{
            get
            {
                string diaFeriado = "";
                DateTime fechaIngreso = FechaHoraIngreso;
                DateTime? fechaSalida = FechaHoraSalida;               
              
                //Se valida si fechaSalida tiene valor; es decir, si el vehiculo ya se fue del estacionamiento
                if (fechaSalida.HasValue)
                {
                    if (fechaIngreso.Month == fechaSalida.Value.Month && fechaIngreso.Day == fechaSalida.Value.Day)
                    {
                        //Si son el mismo dia, se usa cualquiera para comparar.
                        diaFeriado = "El feriado de FechaIngreso y de FechaSalida es: " + ValidarFeriadoxFecha(fechaIngreso);
                    } else
                    {
                        diaFeriado = "El feriado de FechaIngreso es: " + ValidarFeriadoxFecha(fechaIngreso) + ", y el de FechaSalida es: " + ValidarFeriadoxFecha(fechaSalida.Value);
                    }
                } else { 
                    diaFeriado = "El feriado de FechaIngreso es: " + ValidarFeriadoxFecha(fechaIngreso) + ", el vehiculo aun se encuentra estacionado";
                    return diaFeriado;
                }
                
                return null;
            }
            set { }
        }

        [DataMember]
        public string TiempoEstacionado
        {
            get {
                string elResultado = "";
                DateTime ingreso = FechaHoraIngreso;
                DateTime? salida = FechaHoraSalida;


                if (!salida.HasValue)
                    return elResultado;

                TimeSpan? difference = salida - ingreso;
                elResultado = difference.Value.TotalHours.ToString();
                return elResultado;
            }
            set { }
        }

        private string ValidarFeriadoxFecha(DateTime fecha)
        {
            DiasFeriadosAnuale feriados = new DiasFeriadosAnuale();
            string diaFeriado = "";
            if (fecha.Month.Equals(feriados.ListaFeriados.Find(m => m.mes == fecha.Month))
                    && fecha.Day.Equals(feriados.ListaFeriados.Find(d => d.dia == fecha.Day)))
            {
                //  diaFeriado = feriados.
                diaFeriado = feriados.ListaFeriados.Where(m => m.mes == fecha.Month)
                                                   .Where(d => d.dia == fecha.Day)
                                                   .Select(n => n.nombre).ToString();
                return diaFeriado;

            }
            return "no es feriado";
        }
    }
}
