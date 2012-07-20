﻿namespace UCosmic.Domain.Establishments
{
    public class GetEstablishmentBySamlEntityIdQuery : BaseEntitiesQuery<Establishment>, IDefineQuery<Establishment>
    {
        public string SamlEntityId { get; set; }
    }

    public class GetEstablishmentBySamlEntityIdHandler : IHandleQueries<GetEstablishmentBySamlEntityIdQuery, Establishment>
    {
        private readonly IQueryEntities _entities;

        public GetEstablishmentBySamlEntityIdHandler(IQueryEntities entities)
        {
            _entities = entities;
        }

        public Establishment Handle(GetEstablishmentBySamlEntityIdQuery query)
        {
            return _entities.Get<Establishment>()
                .EagerLoad(query.EagerLoad, _entities)
                .BySamlEntityId(query.SamlEntityId)
            ;
        }
    }
}
