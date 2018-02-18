using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACSAAS.Infrastructure.Domain
{
	public abstract class ValueObjectBase
	{
		private List<BusinessRule> _brokenRules = new List<BusinessRule>();

	    protected ValueObjectBase()
		{
		}

		protected abstract void Validate();

		public void ThrowExceptionIfInvalid()
		{
			_brokenRules.Clear();
			Validate();
			if (_brokenRules.Any())
			{
				StringBuilder issues = new StringBuilder();
				foreach (BusinessRule businessRule in _brokenRules)
				{
					issues.AppendLine(businessRule.RuleDescription);
				}

				throw new ValueObjectIsInvalidException(issues.ToString());
			}
		}

		protected void AddBrokenRule(BusinessRule businessRule)
		{
			_brokenRules.Add(businessRule);
		}
	}
}
