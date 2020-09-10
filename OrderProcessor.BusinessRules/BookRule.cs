using OrderProcessor.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules
{
    class BookRule : BaseProductRule, IProcessOrderRule
    {
        public override void ProcessOrder() 
        {
            GeneratePackingSlip();
            GeneratePackingSlip();
            GenerateAgentCommission();
        }
    }
}
