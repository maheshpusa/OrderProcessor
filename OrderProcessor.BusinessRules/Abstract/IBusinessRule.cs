using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessor.BusinessRules.Abstract
{
    public interface IBusinessRule
    {
        void GeneratePackingSlip();
    }
}
