using Acme.MinhTai.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.MinhTai.BookStore;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
