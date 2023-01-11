
namespace Balta.ContentConext.SubscriptionContext;

public abstract class Subscription : BaseContent
{
	public Plan Plan { get; set; } = new Plan();
	public DateTime? EndDate { get; set; }
	
	//If de subscription does not have a EndDate, it is Active
	//If exists a EndDate, check if it is in the future
	public bool isInative => EndDate != null ? EndDate <= DateTime.Now : false;
}