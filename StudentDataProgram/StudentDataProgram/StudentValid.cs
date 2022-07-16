using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace StudentDataProgram
{
    internal class StudentValid : AbstractValidator<Student>
    {

        public  StudentValid()
        {


            //İsim ve soyisimin içerebileceği karakterlerin hepsi burada 
            Regex regexNameAndSurname = new Regex(@"^[a-zA-Z-']*$");
            Regex regerxStudentNumber = new Regex(@"^[0-9' a-zA-Z- ]*$");
           

            RuleFor(x => x.studentNumber).NotEmpty().NotNull().WithMessage("Lütfen bir numara giriniz").Matches(regerxStudentNumber);
            RuleFor(x => x.name).NotEmpty().WithMessage("Lütfen bir isim giriniz!").Matches(regexNameAndSurname);
            RuleFor(x => x.lastName).NotEmpty().WithMessage("Lütfen bir soyisim giriniz!").Matches(regexNameAndSurname);
            RuleFor(x => x.grade).NotNull().WithMessage("Lütfen bir sınıf seçiniz");
            RuleFor(x => x.univercity).NotNull().WithMessage("Lütfen bir üniversite seçiniz");
            RuleFor(x => x.department).NotNull().WithMessage("Lütfen bir bölüm seçiniz");

        }



    }
}
