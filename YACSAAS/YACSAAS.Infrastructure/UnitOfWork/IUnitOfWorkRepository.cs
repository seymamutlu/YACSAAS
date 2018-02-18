using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YACSAAS.Infrastructure.Domain;

namespace YACSAAS.Infrastructure.UnitOfWork
{
	public interface IUnitOfWorkRepository
	{
		void PersistInsertion(IAggregateRoot aggregateRoot);
		void PersistUpdate(IAggregateRoot aggregateRoot);
		void PersistDeletion(IAggregateRoot aggregateRoot);
	}
}
