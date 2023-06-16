using FluentValidation;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool//bu tip toollarda sürekli new yapmamak için static olarak oluşturulur
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);// prodcut için doğrulama yapacağımızı söylüyoruz.
            var result = validator.Validate(context);//üstteki bilgileri doğrula demek.
            if (!result.IsValid)//validation yapılacağı zaman standart kod //sonuç geçerli değilse
            {
                throw new FluentValidation.ValidationException(result.Errors);// o zaman hata ver.
            }
        }
    }
}
