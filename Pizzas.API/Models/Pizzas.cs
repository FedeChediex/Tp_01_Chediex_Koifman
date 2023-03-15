
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace Pizzas.API.Models
{

    public class Pizza
    {
        private int _id;
        private string? _nombre;
        private string? _descripcion;

        private bool _libreGluten;
        private float _importe;
        
        public int Id
        {
            get{ return _id; }
             set{ _id= value; }
        }

        public string Nombre
        {
            get{ return _nombre; }
            set{ _nombre = value; }
        }

        public string Descripcion
        {
            get{ return _descripcion; }
            set{ _descripcion = value; }
        }

        public bool LibreGluten
        {
            get{ return _libreGluten; }
            set{ _libreGluten = value; }
        }

        public float Importe
        {
            get{ return _importe; }
            set{ _importe = value; }
        }
    }

}