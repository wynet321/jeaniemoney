using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ClassLibrary.lib.Handler
{
    public abstract class DbHandler
    {
        public abstract bool isValid();
        public abstract DbCommand generateDbCommand(string command, DbParameter[] parameters);
        public abstract DbParameter generateDbParameter(string parameterName, object value, string objectClassName = "string", ParameterDirection parameterDirection = ParameterDirection.Input);
        public abstract int execTranx(IList<SqlCommand> commandList, IList<DbParameter[]> parametersList);
        public abstract int execCommand(string command, DbParameter[] parameters);
        public abstract DataTable getDataTable(string command, DbParameter[] parameters);
        public abstract object getValue(string command, DbParameter[] parameters);
    }
}
