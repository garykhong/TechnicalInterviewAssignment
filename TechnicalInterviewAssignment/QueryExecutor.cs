using System;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment
{
    public class QueryExecutor
    {
        public List<string> Queries { get; set; }
        private List<long> Numbers = new List<long>();

        public QueryExecutor()
        {
            Queries = new List<string>();
        }

        public List<long> GetAllQueriesResult()
        {
            List<long> allQueriesResult = new List<long>();
            Numbers = new List<long>();

            foreach (string query in Queries)
            {
                string[] queryParts = query.Split(' ');
                if (queryParts.Length == 1)
                {
                    switch (Convert.ToInt64(queryParts[0]))
                    {
                        case 2:
                            Numbers.RemoveAt(0);
                            break;
                        case 3:
                            allQueriesResult.Add(Numbers[0]);
                            break;
                    }
                }
                else if (queryParts.Length == 2)
                {
                    if (Convert.ToInt64(queryParts[0]) == 1)
                    {
                        Numbers.Add(Convert.ToInt64(queryParts[1]));
                    }
                }
            }
            return allQueriesResult;
        }
    }
}
