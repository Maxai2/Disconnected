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
            SqlParameter paramCoreSpeed = new SqlParameter("CoreSpeed", SqlDbType.Decimal);
            paramCoreSpeed.SourceColumn = "CoreSpeed";
            paramCoreSpeed.Precision = 5;
            paramCoreSpeed.Scale = 1;
            _authorAdapter.InsertCommand.Parameters.Add(paramCoreSpeed);
            SqlParameter paramBusSpeed = new SqlParameter("BusSpeed", SqlDbType.Decimal);
            paramBusSpeed.SourceColumn = "BusSpeed";
            paramBusSpeed.Precision = 5;
            paramBusSpeed.Scale = 1;
            _authorAdapter.InsertCommand.Parameters.Add(paramBusSpeed);
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Graphics", SqlDbType.Bit, 0, "Graphics"));
            _authorAdapter.InsertCommand.Parameters.Add(new SqlParameter("Price", SqlDbType.Int, 0, "Price"));



            _authorAdapter.Fill(_dataSet, "Processors");
        }

        public DataTable GetProcessors()
        {
            _dataSet.Tables["Processors"].RowChanged += IntelDB_RowChanged; 
            _dataSet.Tables["Processors"].RowDeleted += IntelDB_RowDeleted;
            _dataSet.Tables["Processors"].TableNewRow += IntelDB_TableNewRow;

            return _dataSet.Tables["Processors"];
        }

        private void IntelDB_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void IntelDB_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void IntelDB_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void PushProcessors()
        {
            _authorAdapter.Update(_dataSet.Tables["Processors"]);
        }

        public int GetDeletedItemsCount()
        {
            int count = 0;
            foreach (DataRow row in _dataSet.Tables["Processors"].Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    ++count;
                }
            }

            return count;
        }

        public int GetUpdatedItemsCount()
        {
            int count = 0;
            foreach (DataRow row in _dataSet.Tables["Processors"].Rows)
            {
                if (row.RowState == DataRowState.Modified)
                {
                    ++count;
                }
            }

            return count;
        }

        public int GetInsertedItemsCount()
        {
            int count = 0;
            foreach (DataRow row in _dataSet.Tables["Processors"].Rows)
            {
                if (row.RowState == DataRowState.Added)
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
