namespace Pizzas.API.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public class BD
{
    private static string _connectionString = @"Server=A-PHZ2-CIDI-011;
DataBase=DAI-Pizzas;Trusted_Connection=True;";
        
    public static List<Pizza> GetAll()
    {
        List<Pizza> lista = new List<Pizza>();
        string sql = "Select * FROM Pizzas";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Pizza>(sql).ToList();

        }
        return lista;

    }
     public static Pizza GetById(int Id)
    {
        List<Pizza> lista = new List<Pizza>();
        string sql = "Select * FROM Pizzas where Id = @_Id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Pizza>(sql, new { _Id = Id }).ToList();

        }
        return lista[0];

    }

    public static void DeletePizza(int Id )
    {
        
        string sql = "Delete * FROM Pizzas where Id = @_Id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {_Id = Id});

        }
       
    }

    public static void CreatePizza( string nombre, string descripcion, bool libregluten, float importe )
    {
        string sql = "INSERT INTO Pizzas(Nombre,Descripcion, LibreGluten,  Importe) VALUES(@_nombre,@_descripcion, @_libregluten, @_importe)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {_nombre = nombre , _descripcion = descripcion, _importe = importe, _libregluten = libregluten});

        }
    }

    public static void UpdatePizza(int Id, string nombre, string descripcion, bool libregluten, float importe)
    {
         string sql = "UPDATE INTO Pizzas(Nombre,Descripcion, LibreGluten,  Importe) VALUES(@_nombre,@_descripcion, @_libregluten, @_importe) Where Id = @_Id";
         using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {_Id = Id, _nombre = nombre , _descripcion = descripcion, _importe = importe, _libregluten = libregluten});

        }
    }
}