<i>Patika .NET Core - 1st Work (Patika & PayCore)</i>
<br />
<h3>(Sonraki güncellemede birim testleri eklenecek.)</h3>

<hr />
<h2>Proje Hakkında</h2>
<ul>
    <li>.NET 6 ile geliştirilmiş bir ASP.NET Web API projesidir.</li>
    <li>Patika'da yer alan <a href="https://app.patika.dev/courses/net-core/16-odev-author-controller-eklenmesi">örnek çalışmaya</a> ait bir projedir.</li>
    <li>Katmanlı bir yapı izlenerek oluşturulmuştur.</li>
    <li><a href="https://www.microsoft.com/sql-server/sql-server-2019" target="_blank">MsSQL</a> veri tabanı kullanılmıştır.</li>
    <li><a href="https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx" target="_blank">Entity Framework Core</a> ORM aracından yararlanılmıştır.</li>
    <li>Gerekli validasyon işlemleri <a href="https://fluentvalidation.net">FluentValidation</a> kütüphanesi kullanılarak gerçekleştirilmiştir.</li>
    <li>Veri transferiyle güvenliğin sağlanması <a href="https://docs.automapper.org/en/stable/">AutoMapper</a> kütüphanesi aracılığıyla yapılmıştır.</li>
</ul>

<hr />
<h2>Proje Yapısı</h2>
<ul>
    <li>Core
        <ul>
            <li>API
                <ul>
                    <li>Abstract
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Api/Abstract/ICoreController.cs" target="_blank"><b>ICoreController.cs</b></a></li>
                        </ul>
                    </li>
                    <li>Concrete
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Api/Concrete/CoreController.cs" target="_blank"><b>CoreController.cs</b></a></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li>Business
                <ul>
                    <li>Abstract
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Business/Abstract/ICoreService.cs" target="_blank"><b>ICoreService.cs</b></a></li>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Business/Abstract/IService.cs" target="_blank"><b>IService.cs</b></a></li>
                        </ul>
                    </li>
                    <li>Concrete
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Business/Concrete/CoreService.cs" target="_blank"><b>CoreService.cs</b></a></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li>Data Access
                <ul>
                    <li>Abstract
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/DataAccess/Abstract/IEfRepository.cs" target="_blank"><b>IEfRepository.cs</b></a></li>
                        </ul>
                    </li>
                    <li>Concrete
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/DataAccess/Concrete/EfRepository.cs" target="_blank"><b>EfRepository.cs</b></a></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li>Dto
                <ul>
                    <li>Abstract
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Dto/Abstract/ICoreCreateDto.cs" target="_blank"><b>ICoreCreateDto.cs</b></a></li>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Dto/Abstract/ICoreUpdateDto.cs" target="_blank"><b>ICoreUpdateDto.cs</b></a></li>
                        </ul>
                    </li>
                    <li>Concrete
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Dto/Concrete/MappingProfile.cs" target="_blank"><b>MappingProfile.cs</b></a></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li>Entity
                <ul>
                    <li>Abstract
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Entity/Abstract/ICoreEntity.cs" target="_blank"><b>ICoreEntity.cs</b></a></li>
                        </ul>
                    </li>
                    <li>Concrete
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Entity/Concrete/CoreEntity.cs" target="_blank"><b>CoreEntity.cs</b></a></li>
                        </ul>
                    </li>
                </ul>
            </li>
        </ul>
    </li>
    <li>Business
        <ul>
            <li>Abstract
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Business/Abstract/IAuthorService.cs" target="_blank"><b>IAuthorService.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Business/Abstract/IBookService.cs" target="_blank"><b>IBookService.cs</b></a></li>
                </ul>
            </li>
            <li>Concrete
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Business/Concrete/AuthorService.cs" target="_blank"><b>AuthorService.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Business/Concrete/BookService.cs" target="_blank"><b>BookService.cs</b></a></li>
                </ul>
            </li>
        </ul>
    </li>
    <li>Data Access
        <ul>
            <li>Abstract
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/DataAccess/Abstract/IAuthorDal.cs" target="_blank"><b>IAuthorDal.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/DataAccess/Abstract/IBookDal.cs" target="_blank"><b>IBookDal.cs</b></a></li>
                </ul>
            </li>
            <li>Concrete
                <ul>
                    <li>Contexts
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/DataAccess/Concrete/Contexts/EfContext.cs" target="_blank"><b>EfContext.cs</b></a></li>
                        </ul>
                    </li>
                    <li>Layers
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/DataAccess/Concrete/Layers/AuthorDal.cs" target="_blank"><b>AuthorDal.cs</b></a></li>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/DataAccess/Concrete/Layers/BookDal.cs" target="_blank"><b>BookDal.cs</b></a></li>
                        </ul>
                    </li>
                    <li>Mappings
                        <ul>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/DataAccess/Concrete/Mappings/AuthorMap.cs" target="_blank"><b>AuthorMap.cs</b></a></li>
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/DataAccess/Concrete/Mappings/BookMap.cs" target="_blank"><b>BookMap.cs</b></a></li>
                        </ul>
                    </li>
                </ul>
            </li>
        </ul>
    </li>
    <li>Entity
        <ul>
            <li>Concrete
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Entity/Concrete/Author.cs" target="_blank"><b>Author.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Entity/Concrete/Book.cs" target="_blank"><b>Book.cs</b></a></li>
                </ul>
            </li>
        </ul>
    </li>
    <li>Dto
        <ul>
            <li>Concrete
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Dto/Concrete/CreateAuthor.cs" target="_blank"><b>CreateAuthor.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Dto/Concrete/CreateBook.cs" target="_blank"><b>CreateBook.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Dto/Concrete/UpdateAuthor.cs" target="_blank"><b>UpdateAuthor.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Dto/Concrete/UpdateBook.cs" target="_blank"><b>UpdateBook.cs</b></a></li>
                </ul>
            </li>
        </ul>
    </li>
    <li>API
        <ul>
            <li>Controllers
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Controllers/AuthorsController.cs" target="_blank"><b>AuthorsController.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Controllers/BooksController.cs" target="_blank"><b>BooksController.cs</b></a></li>
                </ul>
            </li>
            <li>Utilities
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Utilities/DateTimeConverter.cs" target="_blank"><b>DateTimeConverter.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Utilities/Message.cs" target="_blank"><b>Message.cs</b></a></li>
                </ul>
            </li>
            <li>Validators
                <ul>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Validators/CreateAuthorValidator.cs" target="_blank"><b>CreateAuthorValidator.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Validators/CreateBookValidator.cs" target="_blank"><b>CreateBookValidator.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Validators/UpdateAuthorValidator.cs" target="_blank"><b>UpdateAuthorValidator.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Validators/UpdateBookValidator.cs" target="_blank"><b>UpdateBookValidator.cs</b></a></li>
                </ul>
            </li>
            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Program.cs" target="_blank"><b>Program.cs</b></a></li>
            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/appsettings.json" target="_blank"><b>appsettings.json</b></a></li>
        </ul>
    </li>
</ul>
