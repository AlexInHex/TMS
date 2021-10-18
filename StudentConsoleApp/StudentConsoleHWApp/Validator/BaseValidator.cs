using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsConsoleApp;
using StudentConsoleHWApp.Commands;

namespace StudentConsoleHWApp.Validator
{
    public abstract class BaseValidator : IValidator
    {       
       private StringBuilder sb = new StringBuilder();
        string IValidator.ErrorMessage { get { return sb.ToString();} }
        public string[] param;       

        public BaseValidator(string[] param)
        {
            this.param = param;
        }               

        public bool IdValidation(string id)
        {
            if (id != null)
            {
                foreach (char sumbol in id)
                {
                    if (Char.IsLetter(sumbol))
                    {
                        sb.AppendLine("Id не верный");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                sb.AppendLine("ID не введен");
                return false;
            }
            

        }

        public bool StringNotNull(string str)
        {
            if (str == null)
            {
                return false;
            }
            return true;
        }

        public bool NameValidation(string name)
        {
            if (StringNotNull(name) && name.Length <= 50)
            {
                foreach (char sumbol in name)
                {
                    if (Char.IsDigit(sumbol))
                    {
                        sb.AppendLine("Имя не должно содержать цифры");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                sb.AppendLine("Введите имя не длиннее 50 символов. ");
                return false;
            }

           
        }

        public bool SurnameValidation(string surname)
        {
            if (StringNotNull(surname) && surname.Length <= 50)
            {
                foreach (char sumbol in surname)
                {
                    if (Char.IsDigit(sumbol) )
                    {
                        sb.AppendLine("Фамилия не должна сожержать цифры");
                        return false;
                    }
                }
                return true;
            }
            else
            {
                sb.AppendLine("Введите фамилию не длиннее 50 символов.");
                return false;
            }
            
        }

        public bool AgeValidation(string age)
        {
            if (StringNotNull(age) && int.Parse(age) > 18 && int.Parse(age) < 100)
            {
                foreach (char sumbol in age)
                {
                    if (Char.IsDigit(sumbol))
                    {                        
                        return true;
                    }
                }
                sb.AppendLine("Возраст не должен содержать буквы");
                return false;
            }
            else
            {
                sb.AppendLine("Введите возраст от 18 до 99 лет ");
                return false;
            }           
        }

        public bool GenderValidation(string gender)
        {           
            string[] genderIsReal = {"М", "Ж", "МУЖ", "ЖЕН", "МУЖЧИНА", "ЖЕНЩИНА", "M", "W", "MAN", "WOMAN", "BOY", "GIRL", "МАЛЬЧИК",
                "ДЕВОЧКА", "ПАРЕНЬ", "ДЕВУШКА"};

            for (int i = 0; i < genderIsReal.Length; i++)
            {
                
                if (StringNotNull(gender) && gender.ToUpper() == genderIsReal[i])
                {
                    return true;
                }
            }
            sb.AppendLine("Введите пол");
            return false;            
        }

        public abstract bool Validate();        
    }
}
