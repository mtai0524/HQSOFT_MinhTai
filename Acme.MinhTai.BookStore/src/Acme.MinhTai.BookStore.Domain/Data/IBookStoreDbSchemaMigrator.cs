using System.Threading.Tasks;

namespace Acme.MinhTai.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
