namespace Lesson6.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KNUmodel : DbContext
    {
        // Контекст настроен для использования строки подключения "KNUmodel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Lesson6.KNUmodel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "KNUmodel" 
        // в файле конфигурации приложения.
        public KNUmodel()
            : base("name=KNUmodel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Student> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}