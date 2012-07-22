﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using UCosmic.Domain.People;

namespace UCosmic.Domain.Establishments
{
    public class Establishment : RevisableEntity
    {
        public Establishment()
        {
            InstitutionInfo = new InstitutionInfo();
            PublicContactInfo = new EstablishmentContactInfo();
            PartnerContactInfo = new EstablishmentContactInfo();

            // ReSharper disable DoNotCallOverridableMethodsInConstructor
            EmailDomains = new Collection<EstablishmentEmailDomain>();
            Urls = new Collection<EstablishmentUrl>();
            Names = new Collection<EstablishmentName>();
            Affiliates = new Collection<Affiliation>();
            Ancestors = new Collection<EstablishmentNode>();
            Children = new Collection<Establishment>();
            Offspring = new Collection<EstablishmentNode>();
            // ReSharper restore DoNotCallOverridableMethodsInConstructor
        }

        public string OfficialName { get; set; }

        public virtual ICollection<EstablishmentName> Names { get; set; }

        public EstablishmentName TranslateNameTo(string languageIsoCode)
        {
            if (string.IsNullOrWhiteSpace(languageIsoCode)) return null;

            return Names.FirstOrDefault(establishmentName => establishmentName.TranslationToLanguage != null && !establishmentName.IsFormerName && (
                establishmentName.TranslationToLanguage.TwoLetterIsoCode.Equals(languageIsoCode, StringComparison.OrdinalIgnoreCase) ||
                establishmentName.TranslationToLanguage.ThreeLetterIsoCode.Equals(languageIsoCode, StringComparison.OrdinalIgnoreCase) ||
                establishmentName.TranslationToLanguage.ThreeLetterIsoBibliographicCode.Equals(languageIsoCode, StringComparison.OrdinalIgnoreCase)));
        }

        public EstablishmentName TranslatedName
        {
            get
            {
                var currentUiName = TranslateNameTo(
                    CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
                return currentUiName ?? TranslateNameTo("en") ?? Names.Single(n => n.IsOfficialName);
            }
        }

        public string WebsiteUrl { get; set; }

        public virtual ICollection<EstablishmentUrl> Urls { get; set; }

        public virtual Establishment Parent { get; set; }

        public virtual ICollection<EstablishmentNode> Ancestors { get; set; }

        public virtual ICollection<Establishment> Children { get; set; }

        public virtual ICollection<EstablishmentNode> Offspring { get; set; }

        public virtual EstablishmentLocation Location { get; set; }

        public virtual EstablishmentSamlSignOn SamlSignOn { get; protected internal set; }

        public virtual EstablishmentType Type { get; set; }

        public bool IsMember { get; set; }

        public bool IsAncestorMember
        {
            get
            {
                var currentParent = Parent;
                while (currentParent != null)
                {
                    if (currentParent.IsMember)
                    {
                        return true;
                    }
                    currentParent = currentParent.Parent;
                }
                return false;
            }
        }

        public virtual ICollection<EstablishmentEmailDomain> EmailDomains { get; set; }

        public virtual ICollection<Affiliation> Affiliates { get; set; }

        public bool IsInstitution
        {
            get { return Type.Category.Code == EstablishmentCategoryCode.Inst; }
        }

        public InstitutionInfo InstitutionInfo { get; set; }
        public EstablishmentContactInfo PublicContactInfo { get; set; }
        public EstablishmentContactInfo PartnerContactInfo { get; set; }

        public override string ToString()
        {
            return OfficialName;
        }

        public bool HasSamlSignOn()
        {
            return SamlSignOn != null && IsMember;
        }
    }

    public static class EstablishmentExtensions
    {
        public static Establishment ByOfficialName(this IEnumerable<Establishment> query, string officialName)
        {
            return (query != null)
                ? query.SingleOrDefault(t =>
                    t.OfficialName.Equals(officialName, StringComparison.OrdinalIgnoreCase))
                : null;
        }

        public static Establishment ByWebsiteUrl(this IEnumerable<Establishment> query, string websiteUrl)
        {
            return (query != null)
                ? query.SingleOrDefault(t =>
                    string.Compare(t.WebsiteUrl, websiteUrl, StringComparison.OrdinalIgnoreCase) == 0)
                : null;
        }

        public static bool HasDefaultAffiliate(this Establishment establishment, IPrincipal principal)
        {
            if (establishment == null) throw new ArgumentNullException("establishment");
            if (principal == null) throw new ArgumentNullException("principal");

            Func<Affiliation, bool> defaultAffiliation = a =>
                a.IsDefault && a.Person.User != null
                && a.Person.User.Name.Equals(principal.Identity.Name, StringComparison.OrdinalIgnoreCase);
            return establishment.Affiliates.Any(defaultAffiliation)
                || establishment.Ancestors.Any(n => n.Ancestor.Affiliates.Any(defaultAffiliation));
        }

    }
}