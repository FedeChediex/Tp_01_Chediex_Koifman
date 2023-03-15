namespace Pizzas.API.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
public class BD
{
    private static string _connectionString = @"Server=A-PHZ2-AMI-010;
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
        Pizza lista = new Pizza();
        string sql = "Select * FROM Pizzas where Id = @_Id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.QueryFirstOrDefault<Pizza>(sql, new { _Id = Id });

        }

        return lista;
    }


    public static void CreatePizza(Pizza pizza)
    {
        string sql = "INSERT INTO Pizzas(Nombre,Descripcion, LibreGluten,  Importe) VALUES(@_nombre,@_descripcion, @_libregluten, @_importe)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {_nombre = pizza.Nombre , _descripcion = pizza.Descripcion, _importe = pizza.Importe, _libregluten = pizza.LibreGluten});

        }
    }

    public static void UpdatePizza(int Id, Pizza pizza)
    {
         string sql = "UPDATE INTO Pizzas(Nombre,Descripcion, LibreGluten,  Importe) VALUES(@_nombre,@_descripcion, @_libregluten, @_importe) Where Id = @_Id";
         using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {_Id = Id, _nombre = pizza.Nombre , _descripcion = pizza.Descripcion, _importe = pizza.Importe, _libregluten = pizza.LibreGluten});

        }
    }

    public static void DeletePizza(int Id )
    {
        
        string sql = "Delete * FROM Pizzas where Id = @_Id";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new {_Id = Id});

        }
       
    }
}