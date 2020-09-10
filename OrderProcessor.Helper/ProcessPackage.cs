using OrderProcessor.BusinessRules.Abstract;
using System;

namespace OrderProcessor.Helper
{
    public class ProcessPackage
    {
        IBusinessRule _businessRule;
        public ProcessPackage(IBusinessRule businessRule)
        {
            _businessRule = businessRule;
        }
        public void processpackage(string prodcutCategory)
        {
            prodcutCategory
        }
    }
}
