using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestionItems.Models
{
        public class ItemTrabajo
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaEntrega { get; set; }
            public string Relevancia { get; set; } // "Alta" o "Baja"
            public string Estado { get; set; } // "Pendiente" o "Completado"
        }
}