using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Disconnected
{
    public class IntelDB
    {
        private DataSet _dataSet = new DataSet();
        private SqlDataAdapter _authorAdapter = new SqlDataAdapter();
        private SqlConnection _connection = new SqlConnection("Server=(local);Database=IntelCPU;Trusted_Connection=True;");

        public IntelDB()
        {
            _authorAdapter.SelectCommand = new SqlCommand("SELECT * FROM Processors", _connection);

            _authorAdapter.DeleteCommand = new SqlCommand("DELETE FROM Processors WHERE Id = @id", _connection);
            _authorAdapter.DeleteCommand.Parameters.Add(new SqlParameter("id", SqlDbType.Int, 0, "Id"));

            _authorAdapter.InsertCommand = new SqlCommand("INSERT INTO Processors (Family, Socket, Generation, Cores, CoreSpeed, BusSpeed, Graphics, Price) VALUES(@Family, @Socket, @Generation, @Cores, @CoreSpeed, @BusSpeed, @Graphics, @Price)", _connection);
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Family", SqlDbType.NVarChar, 30, "Family"));
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Socket", SqlDbType.NVarChar, 10, "Socket"));
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Generation", SqlDbType.NVarChar, 20, "Generation"));
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Cores", SqlDbType.TinyInt, 0, "Cores"));
            SqlParameter paramInsCoreSpeed = new SqlParameter("CoreSpeed", SqlDbType.Decimal)
            {
                SourceColumn = "CoreSpeed",
                Precision = 5,
                Scale = 1
            };
            _authorAdapter.InsertCommand.Parameters.Add(paramInsCoreSpeed);
            SqlParameter paramInsBusSpeed = new SqlParameter("BusSpeed", SqlDbType.Decimal)
            {
                SourceColumn = "BusSpeed",
                Precision = 5,
                Scale = 1
            };
            _authorAdapter.InsertCommand.Parameters.Add(paramInsBusSpeed);
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Graphics", SqlDbType.Bit, 0, "Graphics"));
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Price", SqlDbType.Int, 0, "Price"));

            _authorAdapter.UpdateCommand = new SqlCommand("UPDATE Processors SET Family = @Family, Socket = @Socket, Generation = @Generation, Cores = @Cores, CoreSpeed = @CoreSpeed, BusSpeed = @BusSpeed, Graphics = @Graphics, Price = @Price WHERE Id = @Id", _connection);
            _authorAdapter.UpdateCommand.Parameters.Add(new SqlParameter("Family", SqlDbType.NVarChar, 30, "Family"));
            _authorAdapter.UpdateCommand.Parameters.Add(new SqlParameter("Socket", SqlDbType.NVarChar, 10, "Socket"));
            _authorAdapter.UpdateCommand.Parameters.Add(new SqlParameter("Generation", SqlDbType.NVarChar, 20, "Generation"));
            _authorAdapter.UpdateCommand.Parameters.Add(new SqlParameter("Cores", SqlDbType.TinyInt, 0, "Cores"));
            SqlParameter paramUpdCoreSpeed = new SqlParameter("CoreSpeed", SqlDbType.Decimal)
            {
                SourceColumn = "CoreSpeed",
                Precision = 5,
                Scale = 1
            };
            _authorAdapter.UpdateCommand.Parameters.Add(paramUpdCoreSpeed);
            SqlParameter paramUpdBusSpeed = new SqlParameter("BusSpeed", SqlDbType.Decimal)
            {
                SourceColumn = "BusSpeed",
                Precision = 5,
                Scale = 1
            };
            _authorAdapter.UpdateCommand.Parameters.Add(paramUpdBusSpeed);
            _authorAdapter.UpdateCommand.Parameters.Add(new SqlParameter("Graphics", SqlDbType.Bit, 0, "Graphics"));
            _authorAdapter.UpdateCommand.Parameters.Add(new SqlParameter("Price", SqlDbType.Int, 0, "Price"));
            _authorAdapter.UpdateCommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int, 0, "Id"));

            _authorAdapter.Fill(_dataSet, "Processors");
        }

        public DataTable GetProcessors()
        {
            return _dataSet.Tables["Processors"];
        }

        public void PushProcessors()
        {
            _authorAdapter.Update(_dataSet.Tables["Processors"]);
        }
    }
}
