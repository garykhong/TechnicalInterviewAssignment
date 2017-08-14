using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterviewAssignment;
using System.Collections.Generic;

namespace TechnicalInterviewAssignment.Tests
{
    [TestClass]
    public class QueryExecutor_GetAllQueriesResult
    {
        private QueryExecutor executor = new QueryExecutor();
        [TestMethod]
        public void TenQueries_Gives14LineBreak14LineBreak()
        {
            executor.Queries.Add("1 42");
            executor.Queries.Add("2");
            executor.Queries.Add("1 14");
            executor.Queries.Add("3");
            executor.Queries.Add("1 28");
            executor.Queries.Add("3");
            executor.Queries.Add("1 60");
            executor.Queries.Add("1 78");
            executor.Queries.Add("2");
            executor.Queries.Add("2");
            Assert.AreEqual(14,
                GetAllQueriesResult()[0]);
            Assert.AreEqual(14,
                GetAllQueriesResult()[1]);
        }

        private List<long> GetAllQueriesResult()
        {
            return executor.GetAllQueriesResult();
        }
    }
}
