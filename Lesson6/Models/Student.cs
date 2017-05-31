using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson6.Models
{
    public class Student
    {
       // [HiddenInput]
        public int Id { get; set; }

//        [Display (Name = "Имя")]
        public string FirstName { get; set; }

  //      [Display (Name = "Фаилия")]
        public string LastName { get; set; }

    //    [Display(Name = "Поступил в:")]
       // [DataType(DataType.Date)]
        public DateTime DateInKnu { get; set; }

      //  [UIHint("MultilineText")]
        public string Intrests { get; set; }
    }
}