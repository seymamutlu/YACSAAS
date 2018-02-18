using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACSAAS.Infrastructure.Domain
{
	public class BusinessRule
	{
	    public BusinessRule(string ruleDescription)
		{
			RuleDescription = ruleDescription;
		}

		public String RuleDescription { get; }
	}
}
