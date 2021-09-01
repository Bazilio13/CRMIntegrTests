using System;

namespace CRM.Tests.Data
{
    public abstract class BaseData
    {
        protected const string _dateFormat = "MM/dd/yyyy hh:mm:ss.fff";
        protected const string _validDateFormat = "dd/MM/yyyy";
        protected static Random _random = new Random();
    }
}
