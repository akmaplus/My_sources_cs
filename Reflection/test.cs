using System;
using System.Reflection;

class App
{
 static void Main()
 {
    //перечисляем члены перечисления System.TypeCode
   
    //Type t = new TypeCode().GetType();        //получаем тип из экз. перечисления
    Type t = Type.GetType("System.TypeCode");   //получаем тип по строке, содержащей имя типа, с префиксом пространства имен

    Console.WriteLine("{0}", t.GUID);   //печатаем идентификатор перечисления (нашего исх. типа)
    Console.WriteLine("{0}", t.FullName);  //полное имя типа
    Console.WriteLine("{0}", IsType(t) );  //печатаем характеристики объекта (нашего исх. типа)


    foreach(var x in t.GetEnumValues())             //получ. массив зн. перечисления
        Console.WriteLine("{0,2} {1}", (int)x, x.ToString());  //порядковый код, имя-члена

 }

  static string IsType(Type t)
  {
    string descr="";
    if( t.IsEnum )                  descr += " Enum";
    if( t.IsArray )                 descr += " Array";
    if( t.IsClass )                 descr += " Class";
    if( t.IsGenericType )           descr += " GenericType";
    if( t.IsInterface )             descr += " Interface";
    if( t.IsPointer )               descr += " Pointer";
    if( t.IsCOMObject )             descr += " COMObject";
    if( t.IsValueType )             descr += " ValueType";
    if( t.IsByRef )                 descr += " ByRef";
    if( t.IsGenericParameter )      descr += " GenericParameter";
    if( t.IsMarshalByRef )          descr += " MarshalByRef";
    if( t.IsSerializable )          descr += " IsSerializable";
    if( t.IsAbstract )              descr += " Abstract";
    if( t.IsPublic )                descr += " Public";
    if( t.IsNotPublic )             descr += " NotPublic";
    if( t.IsSealed )                descr += " Sealed";
    if( t.IsPrimitive )             descr += " Primitive";
    if( t.IsContextful )            descr += " Contextful";
    if( t.IsImport )                descr += " Import";
    if( t.IsVisible )               descr += " Visible";
    if( t.IsUnicodeClass )          descr += " UnicodeClass";
    if( t.IsAutoClass )             descr += " AutoClass";
    if( t.IsAnsiClass )             descr += " AnsiClass";
    if( t.IsSpecialName )           descr += " SpecialName";
    if( t.IsGenericTypeDefinition ) descr += " GenericTypeDefinition";
    if( t.IsLayoutSequential )      descr += " LayoutSequential";
    if( t.IsExplicitLayout )        descr += " ExplicitLayout";
    if( t.IsAutoLayout )            descr += " AutoLayout";
    if( t.IsNestedPublic )          descr += " NestedPublic";
    if( t.IsNestedPrivate )         descr += " NestedPrivate";
    if( t.IsNestedFamORAssem )      descr += " NestedFamORAssem";
    if( t.IsNestedFamily )          descr += " NestedFamily";
    if( t.IsNestedFamANDAssem )     descr += " NestedFamANDAssem";
    if( t.IsNestedAssembly )        descr += " NestedAssembly";
    if( t.IsNested )                descr += " Nested";
    if( t.IsSecurityTransparent )   descr += " SecurityTransparent";
    if( t.IsSecuritySafeCritical )  descr += " SecuritySafeCritical";
    if( t.IsSecurityCritical )      descr += " IsSecurityCritical";
    return descr;
  }
}
