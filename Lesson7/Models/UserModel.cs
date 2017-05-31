namespace Lesson7.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserModel : DbContext
    {
        // Контекст настроен для использования строки подключения "UserModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Lesson7.UserModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "UserModel" 
        // в файле конфигурации приложения.
        public UserModel()
            : base("name=UserModel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}