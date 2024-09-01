namespace Cornerstech.EntityLayer.Entities
{

    public class AgreementPartner : BaseEntity
        {
            public int AgreementId { get; set; }
            public int PartnerId { get; set; }
            public Agreement Agreement { get; set; }
            public Partner Partner { get; set; }
        }

}