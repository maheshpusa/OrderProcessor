using OrderProcessor.BusinessRules.Abstract;
using System;
using System.Linq;

namespace OrderProcessor.Helper
{
    public class ProcessPackage
    {
        IProcessOrderRule _businessRule;
        //public ProcessPackage(IProcessOrderRule businessRule)
        //{
        //    _businessRule = businessRule;
        //}
        public void processpackage(string prodcutCategory)
        {
            //IProcessOrderRule res = (IProcessOrderRule)Activator.CreateInstance("OrderProcessor.BusinessRules", prodcutCategory);
            //res.ProcessOrder();
            
            var type = typeof(IProcessOrderRule);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));

        }
    }
}
