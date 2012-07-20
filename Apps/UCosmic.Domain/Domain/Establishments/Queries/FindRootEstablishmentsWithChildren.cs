﻿using System.Linq;

namespace UCosmic.Domain.Establishments
{
    public class FindRootEstablishmentsWithChildrenQuery : BaseEntitiesQuery<Establishment>, IDefineQuery<Establishment[]>
    {
    }

    public class FindRootEstablishmentsWithChildrenHandler : IHandleQueries<FindRootEstablishmentsWithChildrenQuery, Establishment[]>
    {
        private readonly IQueryEntities _entities;

        public FindRootEstablishmentsWithChildrenHandler(IQueryEntities entities)
        {
            _entities = entities;
        }

        public Establishment[] Handle(FindRootEstablishmentsWithChildrenQuery query)
        {
            return _entities.Get<Establishment>()
                .EagerLoad(query.EagerLoad, _entities)
                .IsRoot()
                .WithAnyChildren()
                .OrderBy(query.OrderBy)
                .ToArray()
            ;
        }
    }
}
