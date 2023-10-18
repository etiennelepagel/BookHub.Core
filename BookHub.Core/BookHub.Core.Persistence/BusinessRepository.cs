using BookHub.Core.Application;
using Google.Cloud.Firestore;

namespace BookHub.Core.Persistence;

public class BusinessRepository : IBusinessRepository
{
    public async Task<List<Business>> GetBusinesses()
    {
        var db = await FirestoreDb.CreateAsync();
        var businesses = await db.Collection("business").ListDocumentsAsync().ToListAsync();
        var result = await Task.WhenAll(businesses.Select(async businessDocument =>
        {
            var businessSnapshot = await businessDocument.GetSnapshotAsync();
            var business = businessSnapshot.ConvertTo<Entities.Business>();
            //var business = businessSnapshot.ToDictionary();
            return new Business(business.Id, business.BusinessName);
        }));

        return result.ToList();
    }
}