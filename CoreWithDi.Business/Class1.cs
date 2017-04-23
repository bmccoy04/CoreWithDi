using System;
using CoreWithDi.Business.Contracts;

namespace CoreWithDi.Business
{
    public class Class1 : IClass1
    {
        private string[] store = new string[] { "Class1 value1", "Class1 value2" };

        public string[] GetValues()
        {
            return store;
        }

        public string GetValue()
        {
            return store[0];
        }
    }
}
