using Google.Cloud.Firestore;

namespace BookHub.Core.Persistence.Entities;

[FirestoreData]
public class Business
{
    [FirestoreDocumentId]
    public string Id { get; set; }
    
    [FirestoreProperty("address")]
    public string Address { get; set; }

    [FirestoreProperty("bannerImageLink")]
    public string BannerImageLink { get; set; }

    [FirestoreProperty("businessId")]
    public string BusinessId { get; set; }

    [FirestoreProperty("businessName")]
    public string BusinessName { get; set; }

    [FirestoreProperty("category")]
    public string Category { get; set; }

    [FirestoreProperty("cloaseTime")]
    public string CloseTime { get; set; }

    [FirestoreProperty("description")]
    public string Description { get; set; }

    [FirestoreProperty("facilities")]
    public string[] Facilities { get; set; }

    [FirestoreProperty("fbLink")]
    public string FbLink { get; set; }

    [FirestoreProperty("instaLink")]
    public string InstaLink { get; set; }

    [FirestoreProperty("logoImageLink")]
    public string LogoImageLink { get; set; }

    [FirestoreProperty("openTime")]
    public string OpenTime { get; set; }

    [FirestoreProperty("phoneNo")]
    public string PhoneNo { get; set; }

    [FirestoreProperty("xLink")]
    public string XLink { get; set; }
}