using Acme.MinhTai.BookStore.Authors;
using Acme.MinhTai.BookStore.Books;
using AutoMapper;

namespace Acme.MinhTai.BookStore.Blazor.Client;

public class BookStoreBlazorAutoMapperProfile : Profile
{
    public BookStoreBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.

        CreateMap<BookDto, CreateUpdateBookDto>();

    }
}