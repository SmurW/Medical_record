using System.Data.SqlClient;
using System.Configuration;

namespace Medical_record.Data.MsSqlData
{
    public class ConnectionService
    {
        private readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=MedicalRecord;" +
            "Integrated Security=True;" +
           // "Persist Security Info=False;User ID = dbo;" + 
            "Connect Timeout=60;Encrypt=False;" +
            "TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = MedicalRecord; Persist Security Info=False;User ID = dbo;
        //Pooling=False;MultipleActiveResultSets=False;Connect Timeout = 60;
        //Encrypt=False;TrustServerCertificate=True
        public ConnectionService()
        {
            //Для работы без тестов
            //_connectionString = ConfigurationManager.
            //    ConnectionStrings["MsSqlData"].ToString();
        }

        public SqlConnection GetConnection() => new SqlConnection(_connectionString);
    }
}
