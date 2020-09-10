using OrderProcessor.BusinessRules.Abstract;
using System;

namespace OrderProcessor.Helper
{
    public class ProcessPackage
    {
        IProcessOrderRule _businessRule;
        public ProcessPackage(IProcessOrderRule businessRule)
        {
            _businessRule = businessRule;
        }
        public void processpackage(string prodcutCategory)
        {
              
        }
    }
}
