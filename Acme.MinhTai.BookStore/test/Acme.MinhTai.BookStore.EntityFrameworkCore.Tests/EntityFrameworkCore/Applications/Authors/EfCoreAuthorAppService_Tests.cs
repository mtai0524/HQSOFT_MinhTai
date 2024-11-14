using Acme.MinhTai.BookStore.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Acme.MinhTai.BookStore.EntityFrameworkCore.Applications.Authors
{
    [Collection(BookStoreTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
    {

    }
}
