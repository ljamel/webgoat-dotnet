using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace VulnApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            // Connexion SQL Server
            string connStr = "Server=db;Database=VulnDB;User Id=sa;Password=Your_password123;TrustServerCertificate=true;";
            string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return Content("✅ Logged in (vulnerable) Bravo le flag est C3stP@lh3ure");
                    }
                    else
                    {
                        return Content("❌ Invalid login");
                    }
                }
            }
        }
    }
}
