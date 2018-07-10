using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacExample
{
    public interface ITestService
    {
        string GetTestString();
    }

    public class TestService : ITestService
    {
        public string GetTestString()
        {
            return "This is a test2.";
        }
    }
}