﻿using System;
using System.Linq;

namespace UCosmic.Domain.Establishments
{
    public class FindAllEstablishmentsQuery : BaseEntitiesQuery<Establishment>, IDefineQuery<Establishment[]>
    {
    }

    public class FindAllEstablishmentsHandler : IHandleQueries<FindAllEstablishmentsQuery, Establishment[]>
    {
        private readonly IQueryEntities _entities;

        public FindAllEstablishmentsHandler(IQueryEntities entities)
        {
            _entities = entities;
        }

        public Establishment[] Handle(FindAllEstablishmentsQuery query)
        {
            if (query == null) throw new ArgumentNullException("query");

            var results = _entities.Query<Establishment>()
                .EagerLoad(_entities, query.EagerLoad)
                .OrderBy(query.OrderBy);

            return results.ToArray();
        }
    }
}
