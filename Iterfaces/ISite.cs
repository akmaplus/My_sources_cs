//��������������� ���������� ����������� ISite, IComponent � IContainer ��� �� ������������� � ���������� ����������

  //����, ���������� ���������� ISite

  // ����� ISBNSite ������������ ��������� ISBN-���� �����
  class ISBNSite : ISite  //���������(���������) ��������� ISite
  {
    //�������� ���� �������
    private IComponent m_curComponent;  //���������
    private IContainer m_curContainer;  //���������

    private bool m_bDesignMode;         //���� - ����� ����������

    private string m_ISBNCmpName;       //������������� ��� ������ ��������� ������ ���� - ISBN-���

    //����������� ������ - ��������� ���� ���������-���������
    public ISBNSite(IContainer actvCntr, IComponent prntCmpnt)
    {
      m_curComponent = prntCmpnt;
      m_curContainer = actvCntr;
      m_bDesignMode = false;
      m_ISBNCmpName = null;
    }

    //���������� ���������� ISite
    public virtual IComponent Component  {  get  { return m_curComponent;  }  }
    public virtual IContainer Container  {  get  { return m_curContainer;  }  }
    
    public virtual bool DesignMode       {  get  { return m_bDesignMode;   }  }

    public virtual string Name           {  get  { return m_ISBNCmpName;   }
                                            set  { m_ISBNCmpName = value;  }
                                         }

    //���������� ���������� IServiceProvider
    public virtual object GetService(Type serviceType)
    {
      //� ���� ������� �� ������������
      return null;
    }

  }


  // ����� BookComponent ������������ ��������� ���������� ����
  class BookComponent : IComponent  //���������(���������) ��������� IComponent
  {
    public event EventHandler Disposed;
    private ISite m_curISBNSite;
    private string m_bookTitle;
    private string m_bookAuthor;

    //����������� - ��������� ���� ��������-�����
    public BookComponent(string Title, string Author)
    {
      m_curISBNSite = null;
      Disposed = null;
      m_bookTitle = Title;
      m_bookAuthor = Author;
    }

    //��������
    public string Title       {  get   {   return m_bookTitle;    }   }
    public string Author      {  get   {   return m_bookAuthor;   }   }

    //���������� ��������
    public virtual void Dispose()
    {   
      if(Disposed != null)  Disposed(this,EventArgs.Empty);  //��� �������, ������� ������
    }

    //���������� ���������� ISite
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
