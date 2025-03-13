using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class QueryBuilder
    {
        private string _select = "";
        private string _from = "";
        private string _orderBy = "";
        private string _where = "";

        public QueryBuilder(string dataSet)
        {
            _select = "SELECT *";
            _from = $"FROM {dataSet}";
        }

        public string Build()
            => string.Join(" ", _select, _from, _where, _orderBy);

        public QueryBuilder Select(string columns)
        {
            _select = $"SELECT {columns}";
            return this;
        }

        public QueryBuilder OrderBy(string column)
        {
            _orderBy = $"ORDER BY {column}";
            return this;
        }

        public QueryBuilder Where(string expression)
        {
            _where = $"WHERE {expression}";
            return this;
        }
    }
}