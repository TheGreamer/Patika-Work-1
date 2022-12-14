<i>🌟 Patika .NET Core - 1st Work (Patika & PayCore)</i>
<br />

<hr />
<h2>🧐 About The Project</h2>
<ul>
    <li>An ASP.NET Web API project developed with .NET 6.</li>
    <li>It is a <a href="https://app.patika.dev/courses/net-core/16-odev-author-controller-eklenmesi">task project</a> in Patika.</li>
    <li>Was created by following the N-Tier architecture.</li>
    <li><a href="https://www.microsoft.com/sql-server/sql-server-2019" target="_blank">MsSQL</a> database was used.</li>
    <li><a href="https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx" target="_blank">Entity Framework Core</a> ORM tool was used.</li>
    <li>Necessary validation processes were performed using the <a href="https://fluentvalidation.net">FluentValidation</a> library.</li>
    <li>Ensuring security with data transfer is done through the <a href="https://docs.automapper.org/en/stable/">AutoMapper</a> library.</li>
</ul>

<hr />
<h2>💻 Project Structure</h2>
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
                            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Core/Dto/Abstract/ICoreDto.cs" target="_blank"><b>ICoreDto.cs</b></a></li>
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
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Dto/Concrete/AuthorDto.cs" target="_blank"><b>AuthorDto.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Dto/Concrete/BookDto.cs" target="_blank"><b>BookDto.cs</b></a></li>
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
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Validators/AuthorValidator.cs" target="_blank"><b>AuthorValidator.cs</b></a></li>
                    <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Validators/BookValidator.cs" target="_blank"><b>BookValidator.cs</b></a></li>
                </ul>
            </li>
            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/Program.cs" target="_blank"><b>Program.cs</b></a></li>
            <li><a href="https://github.com/TheGreamer/Patika-Work-1/blob/master/PatikaClassWork1/appsettings.json" target="_blank"><b>appsettings.json</b></a></li>
        </ul>
    </li>
</ul>
