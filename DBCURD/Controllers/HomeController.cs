using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace DBCURD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult InsertDb()
        {
            return View();
        }
        public ActionResult UpdateDb()
        {
            return View();
        }
        public ActionResult DelectDb()
        {
            return View();
        }
        public void TRY()
        {

        }
        [HttpPost]
        public ActionResult InsertDb(string Name, string CompanyName, string Phone)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["The_World"].ConnectionString;
            conn.Open();
            //SQL新增
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            string SqlInsert = "INSERT INTO Customers (CompanyName, ContactName, Phone) VALUES (@CompanyName ,@Name ,@Phone)";
            sql.Parameters.AddWithValue("@Name", Name);
            sql.Parameters.AddWithValue("@CompanyName", CompanyName);
            sql.Parameters.AddWithValue("@Phone", Phone);
            sql.CommandType = CommandType.Text;
            sql.CommandText = SqlInsert;
            
            SqlDataReader reader = sql.ExecuteReader();
            //int count = (int)sql.ExecuteScalar();
            
            return View();
        }
        [HttpPost]
        public ActionResult UpdateDb(string Name, string CompanyName, string Phone)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["The_World"].ConnectionString;
            conn.Open();
            //SQL更新
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            // UPDATE [table] [欄位名2] = @值1 , [欄位名3] = @值2, [欄位名4] = @值3,....) WHERE[欄位名1] = @值4
            string SqlUpdated = @"UPDATE  Customers 
            SET CompanyName = @CompanyName, ContactName = @Name,Phone = @Phone WHERE CustomerID = '1' ";
            sql.Parameters.AddWithValue("@Name", Name);
            sql.Parameters.AddWithValue("@CompanyName", CompanyName);
            sql.Parameters.AddWithValue("@Phone", Phone);
            sql.CommandType = CommandType.Text;
            sql.CommandText = SqlUpdated;
            SqlDataReader reader = sql.ExecuteReader();
            //int count = (int)sql.ExecuteScalar();

            return View();
        }
        [HttpPost]
        public ActionResult DelectDb(string ID)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["The_World"].ConnectionString;
            conn.Open();
            //SQL刪除
            SqlCommand sql = new SqlCommand();
            sql.Connection = conn;
            // DELETE FROM [table] WHERE[欄位名] = @值1
            string SqlDelect = @"DELETE  Customers WHERE CustomerID = @ID ";
            sql.Parameters.AddWithValue("@ID", ID);
            //sql.Parameters.AddWithValue("@Name", Name);
            //sql.Parameters.AddWithValue("@CompanyName", CompanyName);
            //sql.Parameters.AddWithValue("@Phone", Phone);
            sql.CommandType = CommandType.Text;
            sql.CommandText = SqlDelect;
            SqlDataReader reader = sql.ExecuteReader();
            //int count = (int)sql.ExecuteScalar();

            return View();
        }
    }
}
