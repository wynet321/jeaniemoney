using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Utility
{
    class ProviderName
    {

        private static Dictionary<string,string> providerInvariantName=new Dictionary<string,string>();
        static ProviderName()
        {
            providerInvariantName.Add("SQLSERVER","System.Data.SqlClient");
            providerInvariantName.Add("DB2","IBM.Data.DB2.iSeries");
            providerInvariantName.Add("ORACLE","Oracle.DataAccess.Client");
            providerInvariantName.Add("OLEDB","System.Data.OleDb");
            providerInvariantName.Add("ODBC","System.Data.ODBC");
            providerInvariantName.Add("MYSQL","MySql.Data.MySqlClient");
            providerInvariantName.Add("SQLITE","System.Data.SQLite");
            providerInvariantName.Add("FIREBIRD","FirebirdSql.Data.Firebird");
            providerInvariantName.Add("POSTGRESQL","Npgsql");
            providerInvariantName.Add("INFORMIX","IBM.Data.Informix");
            providerInvariantName.Add("SQLSERVERCE","System.Data.SqlServerCe");
    }

        public static string getPIN(string dbType)
        {
            return providerInvariantName[dbType];
    }
}
