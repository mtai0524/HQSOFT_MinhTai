using Acme.MinhTai.BookStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Acme.MinhTai.BookStore.Blazor.Client;

public abstract class BookStoreComponentBase : AbpComponentBase
{
    protected BookStoreComponentBase()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
