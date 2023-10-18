using Google.Cloud.Firestore;

namespace BookHub.Core.Persistence.Entities;

[FirestoreData]
public class Business
{
    [FirestoreDocumentId]
    public string Id { get; set; }
    
    [FirestoreProperty]
    public string Address { get; set; }
    
    [FirestoreProperty]
    public string BannerImageLink { get; set; }
    
    [FirestoreProperty]
    public string BusinessId { get; set; }
    
    [FirestoreProperty]
    public string BusinessName { get; set; }
    
    [FirestoreProperty]
    public string Category { get; set; }
    
    [FirestoreProperty]
    public string CloseTime { get; set; }
    
    [FirestoreProperty]
    public string Description { get; set; }
    
    [FirestoreProperty]
    public string[] Facilities { get; set; }
    
    [FirestoreProperty]
    public string FbLink { get; set; }
    
    [FirestoreProperty]
    public string InstaLink { get; set; }
    
    [FirestoreProperty]
    public string LogoImageLink { get; set; }
    
    [FirestoreProperty]
    public string OpenTime { get; set; }
    
    [FirestoreProperty]
    public string PhoneNo { get; set; }
    
    [FirestoreProperty]
    public string XLink { get; set; }
}