//демонстрируется реализация интерфейсов ISite, IComponent и IContainer для их использования в контейнере библиотеки

  //ниже, реализация интерфейса ISite

  // класс ISBNSite представляет компонент ISBN-кода книги
  class ISBNSite : ISite  //наследует(реализует) интерфейс ISite
  {
    //закрытые поля объекта
    private IComponent m_curComponent;  //компонент
    private IContainer m_curContainer;  //контейнер

    private bool m_bDesignMode;         //флаг - Режим разработки

    private string m_ISBNCmpName;       //специфическое для нашего дочернего класса поле - ISBN-имя

    //конструктор класса - принимает пару контейнер-компонент
    public ISBNSite(IContainer actvCntr, IComponent prntCmpnt)
    {
      m_curComponent = prntCmpnt;
      m_curContainer = actvCntr;
      m_bDesignMode = false;
      m_ISBNCmpName = null;
    }

    //реализация интерфейса ISite
    public virtual IComponent Component  {  get  { return m_curComponent;  }  }
    public virtual IContainer Container  {  get  { return m_curContainer;  }  }
    
    public virtual bool DesignMode       {  get  { return m_bDesignMode;   }  }

    public virtual string Name           {  get  { return m_ISBNCmpName;   }
                                            set  { m_ISBNCmpName = value;  }
                                         }

    //реализация интерфейса IServiceProvider
    public virtual object GetService(Type serviceType)
    {
      //в этом примере не используется
      return null;
    }

  }


  // класс BookComponent представляет компонент контейнера книг
  class BookComponent : IComponent  //наследует(реализует) интерфейс IComponent
  {
    public event EventHandler Disposed;
    private ISite m_curISBNSite;
    private string m_bookTitle;
    private string m_bookAuthor;

    //конструктор - принимает пару Название-Автор
    public BookComponent(string Title, string Author)
    {
      m_curISBNSite = null;
      Disposed = null;
      m_bookTitle = Title;
      m_bookAuthor = Author;
    }

    //свойства
    public string Title       {  get   {   return m_bookTitle;    }   }
    public string Author      {  get   {   return m_bookAuthor;   }   }

    //деструктор ресурсов
    public virtual void Dispose()
    {   
      if(Disposed != null)  Disposed(this,EventArgs.Empty);  //для примера, очищать нечего
    }

    //реализация интерфейса ISite
    public virtual ISite Site {  get  {  return m_curISBNSite;    }
                                 set  {   m_curISBNSite = value;  }
                              }


    public override bool Equals(object cmp)
    {
      BookComponent cmpObj = (BookComponent)cmp;

      if(this.Title.Equals(cmpObj.Title) && this.Author.Equals(cmpObj.Author))
        return true;

      return false;
    }

    public override int GetHashCode()  {  return base.GetHashCode();  }
  }
