using Undersoft.SDK.Rubrics.Attributes;
using Undersoft.SDK.Service.Access.Identity;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Data.Model.Attributes;
using Undersoft.SVC.Domain.Entities.Enums;

namespace Undersoft.SVC.Service.Contracts
{
    public class Organization : DataObject, IContract
    {
        public IdentifierType? OrganizatioIdentifierType { get; set; }

        public string? OrganizatioIdentifier { get; set; }

        [DisplayRubric("Organization logo")]
        [ViewImage(ViewImageMode.Regular, "30px", "30px")]
        [FileRubric(FileRubricType.Property, "OrganizationImageData")]
        public string? OrganizationImage { get; set; }

        [DisplayRubric("Industry")]
        public string? OrganizationIndustry { get; set; }

        [DisplayRubric("Short name")]
        public string? OrganizationName { get; set; }

        [DisplayRubric("Full name")]
        public string? OrganizationFullName { get; set; }

        [DisplayRubric("Position")]
        public string? PositionInOrganization { get; set; }

        [DisplayRubric("Websites")]
        public string? OrganizationWebsites { get; set; }

        [DisplayRubric("Websites")]
        public OrganizationSize OrganizationSize { get; set; }

        public byte[]? OrganizationImageData { get; set; }

        public long? SupplierId { get; set; }
    }
}