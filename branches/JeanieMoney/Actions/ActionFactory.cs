using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeanieMoney.Actions
{
    class ActionFactory
    {
        public static IAction create(String className)
        {
            if (!String.IsNullOrWhiteSpace(className))
            {
                switch (className)
                {
                    case "BENEFICIARY": return new BeneficiaryAction();
                    case "PAYER": return new PayerAction();
                    default: return null;//never run this line
                }
            }
            else
            {
                //Log failed

                return null;
            }
        }
    }
}
