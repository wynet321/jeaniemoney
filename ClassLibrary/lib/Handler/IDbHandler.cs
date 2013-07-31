using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ClassLibrary.lib.Handler
{
    public interface IDbHandler
    {
        DbConnection getConnection();
        bool isValid();
        DbCommand generateDbCommand(string command, DbParameter[] parameters);
        DbParameter generateDbParameter(string parameterName, object value, string objectClassName="string", ParameterDirection parameterDirection = ParameterDirection.Input);
        int execTranx(IList<SqlCommand> commandList, IList<DbParameter[]> parametersList);
        int execCommand(string command, DbParameter[] parameters);
        DataTable getDataTable(string command, DbParameter[] parameters);
        object getValue(string command, DbParameter[] parameters);
    }
}
