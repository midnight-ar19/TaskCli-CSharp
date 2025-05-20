using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCli.Models
{
    public class Tarea
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool status { get; set; }
        public DateTime createdAt;
        public DateTime updatedAt;


        public override string ToString()
        {
            return $"id: {id} - descripcion: {descripcion} - status: {status} - creacion: {createdAt}";
        }

    }
}
