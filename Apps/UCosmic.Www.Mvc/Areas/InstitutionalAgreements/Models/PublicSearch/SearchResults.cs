﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using UCosmic.Domain.Establishments;
using UCosmic.Domain.InstitutionalAgreements;
using UCosmic.Domain.Places;
using UCosmic.Www.Mvc.Models;

namespace UCosmic.Www.Mvc.Areas.InstitutionalAgreements.Models.PublicSearch
{
    public class SearchResults
    {
        public bool IsManager { get; set; }
        public bool IsSupervisor { get; set; }
        public EstablishmentInfo ContextEstablishment { get; set; }
        public string Keyword { get; set; }
        public SelectListItem[] HierarchySelectList { get; set; }
        public string EstablishmentUrl { get; set; }
        public string NewEstablishmentUrl
        {
            get { return EstablishmentUrl; }
            set { EstablishmentUrl = value; }
        }

        private BoundingBoxModel _boundingBox;
        public BoundingBoxModel MapBoundingBox
        {
            get
            {
                if (_boundingBox == null)
                {
                    foreach (var partner in Establishments.Where(p => p.Location.BoundingBox.HasValue))
                    {
                        if (_boundingBox == null)
                        {
                            _boundingBox = Mapper.Map<BoundingBoxModel>(partner.Location.BoundingBox);
                            continue;
                        }
                        // ReSharper disable PossibleInvalidOperationException

                        // northern latitudes are positive, southern latitudes are negative
                        _boundingBox.Northeast.Latitude = Math.Max(_boundingBox.Northeast.Latitude.Value, partner.Location.BoundingBox.Northeast.Latitude.Value);
                        _boundingBox.Southwest.Latitude = Math.Min(_boundingBox.Southwest.Latitude.Value, partner.Location.BoundingBox.Southwest.Latitude.Value);

                        _boundingBox.Northeast.Longitude = Math.Max(_boundingBox.Northeast.Longitude.Value, partner.Location.BoundingBox.Northeast.Longitude.Value);
                        _boundingBox.Southwest.Longitude = Math.Min(_boundingBox.Southwest.Longitude.Value, partner.Location.BoundingBox.Southwest.Longitude.Value);

                        // ReSharper restore PossibleInvalidOperationException
                    }
                }

                return _boundingBox ?? (_boundingBox = new BoundingBoxModel
                {
                    Northeast = new CoordinatesModel { Latitude = 90, Longitude = 180 },
                    Southwest = new CoordinatesModel { Latitude = -90, Longitude = -180 },
                });
            }
            set { _boundingBox = value; }
        }

        public EstablishmentInfo[] Establishments { get; set; }
        public class EstablishmentInfo
        {
            public string OfficialName { get; set; }
            public string TranslatedName { get; set; }
            public string WebsiteUrl { get; set; }
            public string OfficialThenTranslatedName
            {
                get
                {
                    var name = OfficialName;
                    if (!OfficialName.Equals(TranslatedName))
                    {
                        name = string.Format("{0} ({1})", OfficialName, TranslatedName);
                    }
                    return name;
                }
            }

            public LocationInfo Location { get; set; }
            public class LocationInfo
            {
                public double? CenterLatitude { get; set; }
                public double? CenterLongitude { get; set; }
                public BoundingBox BoundingBox { get; set; }
                public int GoogleMapZoomLevel { get; set; }
            }
        }

        public AgreementInfo[] Agreements { get; set; }
        public class AgreementInfo
        {
            public Guid EntityId { get; set; }
            public string Type { get; set; }

            [DisplayFormat(DataFormatString = "{0:d}")]
            public DateTime StartsOn { get; set; }

            public EstablishmentInfo[] Partners { get; set; }
        }
    }

    public static class SearchResultsProfiler
    {
        public class EntitiesToModelsProfile : Profile
        {
            protected override void Configure()
            {
                CreateMap<Establishment, SearchResults.EstablishmentInfo>();
                CreateMap<EstablishmentLocation, SearchResults.EstablishmentInfo.LocationInfo>();
                CreateMap<InstitutionalAgreement, SearchResults.AgreementInfo>()
                    .ForMember(target => target.Partners, opt => opt
                        .ResolveUsing(source => source.Participants.Where(p => !p.IsOwner).Select(p => p.Establishment)))
                ;
            }
        }
    }
}