namespace Pizzas.API.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD
{
    private static string _connectionString = @"Server=A-PHZ2-CIDI-007;
DataBase=DAI-Pizzas;Trusted_Connection=True;";

    public static List<Pizza> GetAll()
    {
        List<Pizza> lista = new List<Pizza>();
        string sql = "GetPizzas";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Pizza>(sql, commandType: System.Data.CommandType.StoredProcedure).ToList();

        }
        return lista;

    }
    public static Pizza GetById(int Id)
    {
        Pizza lista = new Pizza();
        string sql = "GetPizzaById";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.QueryFirstOrDefault<Pizza>(sql, new { Id }, commandType: System.Data.CommandType.StoredProcedure);

        }

        return lista;
    }


    public static void CreatePizza(Pizza pizza)
{
    string sql = "CreatePizza";
    using (SqlConnection db = new SqlConnection(_connectionString))
    {
        db.Execute(sql, new { nombre = pizza.Nombre, descripcion = pizza.Descripcion, libreGluten = pizza.LibreGluten, importe = pizza.Importe }, commandType: System.Data.CommandType.StoredProcedure);
    }
}

    public static void UpdatePizza(int Id, Pizza pizza)
    {
        string sql = "UpdatePizza";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { Id = Id, nombre = pizza.Nombre, descripcion = pizza.Descripcion, libreGluten = pizza.LibreGluten, importe = pizza.Importe }, commandType: System.Data.CommandType.StoredProcedure);

        }
    }

    public static void DeletePizza(int Id)
    {

        string sql = "DeletePizza";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new { Id = Id }, commandType: System.Data.CommandType.StoredProcedure);

        }

    }
}