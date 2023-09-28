using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.src.util.sqlsugar
{
    internal class SqlSugarHelper
    {
        public static string ConnectionStr = @"DataSource=database.sqlite";


        //用单例模式
        public static SqlSugarScope Db =
            new(
                new ConnectionConfig() { ConnectionString = ConnectionStr, DbType = DbType.Sqlite, IsAutoCloseConnection = true },
                db =>
                {
                    db.Aop.OnLogExecuted = (sql, parms) => { UtilMethods.GetNativeSql(sql, parms); };
                }
            );
    }

}
