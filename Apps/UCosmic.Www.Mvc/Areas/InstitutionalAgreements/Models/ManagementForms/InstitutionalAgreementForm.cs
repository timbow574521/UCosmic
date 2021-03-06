﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using UCosmic.Domain.InstitutionalAgreements;
using UCosmic.Www.Mvc.Models;

namespace UCosmic.Www.Mvc.Areas.InstitutionalAgreements.Models.ManagementForms
{
    public class InstitutionalAgreementForm : IReturnUrl
    {
        public InstitutionalAgreementForm()
        {
            Participants = new List<InstitutionalAgreementParticipantForm>();
            Contacts = new List<InstitutionalAgreementContactForm>();
            Files = new List<InstitutionalAgreementFileForm>();
            Umbrella = new UmbrellaForm();
        }

        [ScaffoldColumn(false)]
        public bool IsNew { get { return RevisionId == 0; } }

        public string ReturnUrl { get; set; }

        #region Identification

        [HiddenInput(DisplayValue = false)]
        public int RevisionId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public Guid EntityId { get; set; }

        #endregion
        #region Umbrella Agreement

        //public int? UmbrellaRevisionId { get; set; }

        //public SelectList UmbrellaOptions { get; set; }

        public UmbrellaForm Umbrella { get; set; }
        public class UmbrellaForm
        {
            [Display(Name = "Umbrella agreement")]
            [DisplayFormat(NullDisplayText = "[None - this is a top-level or standalone agreement]")]
            public Guid? EntityId { get; set; }

            [ScaffoldColumn(false)]
            public IEnumerable<SelectListItem> Options { get; set; }
        }

        #endregion
        #region Type and Status

        [UIHint("TypeComboBox")]
        [Display(Name = TypeDisplayName)]
        [Required(ErrorMessage = TypeRequiredErrorFormat)]
        [StringLength(150, ErrorMessage = "{0} cannot contain more than {1} characters.")]
        [AllowedType(ErrorMessage = "Agreement type '{0}' is not allowed. Please select an Agreement type from the list provided.")]
        public string Type { get; set; }
        public const string TypeDisplayName = "Agreement type";
        public const string TypeRequiredErrorFormat = "{0} is required.";

        [UIHint("StatusComboBox")]
        [Display(Name = StatusDisplayName)]
        [Required(ErrorMessage = StatusRequiredErrorFormat)]
        [StringLength(50, ErrorMessage = "{0} cannot contain more than {1} characters.")]
        [AllowedStatus(ErrorMessage = "Current status '{0}' is not allowed. Please select a Current status from the list provided.")]
        public string Status { get; set; }
        public const string StatusDisplayName = "Current status";
        public const string StatusRequiredErrorFormat = "{0} is required.";

        #endregion
        #region Titles & Description

        [Display(Name = "Check this box to automatically generate the summary description based on the agreement type, participants, and status.")]
        public bool IsTitleDerived { get; set; }

        [Display(Name = TitleDisplayName)]
        [Required(ErrorMessage = TitleRequiredErrorFormat)]
        [StringLength(500, ErrorMessage = "{0} cannot contain more than {1} characters.")]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }
        public const string TitleDisplayName = "Summary description";
        public const string TitleRequiredErrorFormat = "{0} is required.";

        [Display(Name = "Additional notes")]
        [StringLength(4000, ErrorMessage = "{0} cannot contain more than {1} characters.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        #endregion
        #region Lifetime

        [Display(Name = StartsOnDisplayName)]
        [Required(ErrorMessage = StartsOnRequiredErrorFormat)]
        [DataType(DataType.Text)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
        public DateTime? StartsOn { get; set; }
        internal DateTime StartsOnValue
        {
            get
            {
                if (!StartsOn.HasValue)
                    throw new InvalidOperationException("The model is not valid.");
                return StartsOn.Value;
            }
        }
        public const string StartsOnDisplayName = "Start date";
        public const string StartsOnRequiredErrorFormat = "{0} is required.";

        [Display(Name = ExpiresOnDisplayName)]
        [Required(ErrorMessage = ExpiresOnRequiredErrorFormat)]
        [DataType(DataType.Text)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
        public DateTime? ExpiresOn { get; set; }
        internal DateTime ExpiresOnValue
        {
            get
            {
                if (!ExpiresOn.HasValue)
                    throw new InvalidOperationException("The model is not valid.");
                return ExpiresOn.Value;
            }
        }
        public const string ExpiresOnDisplayName = "Expiration date";
        public const string ExpiresOnRequiredErrorFormat = "{0} is required.";

        [Display(Name = "This expiration date is estimated (agreement should be reviewed by this date).")]
        public bool IsExpirationEstimated { get; set; }

        [Display(Name = "Auto renew")]
        public bool? IsAutoRenew { get; set; }

        #endregion
        #region Visibility

        public InstitutionalAgreementVisibilityOption Visibility { get; set; }

        #endregion
        #region Collections

        [ScaffoldColumn(false)]
        [AtLeastOneOwner(ErrorMessage = "You must be affiliated with at least one agreement participant.")]
        public IList<InstitutionalAgreementParticipantForm> Participants { get; set; }

        [ScaffoldColumn(false)]
        public IList<InstitutionalAgreementContactForm> Contacts { get; set; }

        [ScaffoldColumn(false)]
        public IList<InstitutionalAgreementFileForm> Files { get; set; }

        #endregion
    }

    public static class InstitutionalAgreementProfiler
    {
        public class EntityToModelProfile : Profile
        {
            protected override void Configure()
            {
                CreateMap<InstitutionalAgreement, InstitutionalAgreementForm>()
                    .ForMember(d => d.ReturnUrl, o => o.Ignore())
                    .ForMember(d => d.Umbrella, o => o
                        .ResolveUsing(s => s.Umbrella != null
                            ? Mapper.Map<InstitutionalAgreementForm.UmbrellaForm>(s.Umbrella)
                            : new InstitutionalAgreementForm.UmbrellaForm()))
                ;

                CreateMap<InstitutionalAgreement, InstitutionalAgreementForm.UmbrellaForm>()
                    .ForMember(target => target.Options, o => o.Ignore())
                ;
            }
        }

        public class ModelToCommandProfile : Profile
        {
            protected override void Configure()
            {
                CreateMap<InstitutionalAgreementForm, CreateOrUpdateInstitutionalAgreementCommand>()
                    .ForMember(d => d.Principal, o => o.Ignore())
                    .ForMember(d => d.ChangeCount, o => o.Ignore())
                    .ForMember(d => d.RemoveParticipantEstablishmentEntityIds, o => o
                        .ResolveUsing(s => s.Participants.Where(m => m.IsDeleted).Select(m => m.EstablishmentEntityId)))
                    .ForMember(d => d.AddParticipantEstablishmentEntityIds, o => o
                        .ResolveUsing(s => s.Participants.Where(m => !m.IsDeleted).Select(m => m.EstablishmentEntityId)))
                    .ForMember(d => d.RemoveContactEntityIds, o => o
                        .ResolveUsing(s => s.Contacts.Where(m => m.IsDeleted).Select(m => m.EntityId)))
                    .ForMember(d => d.AddContactCommands, o => o
                        .ResolveUsing(s => Mapper.Map<AddContactToAgreementCommand[]>(s.Contacts.Where(m => !m.IsDeleted).ToArray())))
                    .ForMember(d => d.DetachFileEntityIds, o => o
                        .ResolveUsing(s => s.Files.Where(m => m.IsDeleted).Select(m => m.EntityId)))
                    .ForMember(d => d.AttachFileEntityIds, o => o
                        .ResolveUsing(s => s.Files.Where(m => !m.IsDeleted).Select(m => m.EntityId)))
                ;
            }
        }
    }
}