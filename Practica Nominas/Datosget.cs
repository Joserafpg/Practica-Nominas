using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Nominas
{
    public class Datosget
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Fecha_Nac { get; set; }
        public string Cargo { get; set; }
        public string Sueldo_Bruto { get; set; }
        public string ARS { get; set; }
        public string AFP { get; set; }
        public string Vivienda { get; set; }
        public string Descuento { get; set; }
        public string Sueldo_Neto { get; set; }

        public Datosget() { }

        public Datosget(int pId, string pNombre, string pCedula, string pFecha_Nac, string pCargo, string pSueldobruto, string pARS, string pAFP, string pVivienda, string pDescuento, string pSueldoNeto)
        {
            this.Id= pId;
            this.Nombre= pNombre;
            this.Cedula= pCedula;
            this.Fecha_Nac = pFecha_Nac;
            this.Cargo = pCargo;
            this.Sueldo_Bruto = pSueldobruto;
            this.ARS = pARS;
            this.AFP = pAFP;
            this.Vivienda = pVivienda;
            this.Descuento = pDescuento;
            this.Sueldo_Neto = pSueldoNeto;
        }
    }
}
