set pathmysql=C:\Program Files\MySQL\MySQL Connector Net 6.5.4\Assemblies\v4.0\
set reflibs=/r:"%pathmysql%MySql.Web.dll" /r:"%pathmysql%MySql.Data.dll" /r:"%pathmysql%MySql.Data.Entity.dll"

csc.exe %reflibs%  /nologo %1%