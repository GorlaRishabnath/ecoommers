using System;
using System.Collections.Generic;
using System.Text;

namespace product_data.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(string message) : base(message)
        {

        }
    }
}
