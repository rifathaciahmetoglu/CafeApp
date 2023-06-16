using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
                                                  //logics = iş kuralı demektir.
        public static IResult Run(params IResult[] logics)//bana parametre olarak istediğin kadar Iresult verebilirsin demektir.
            //params kullanınca istediğimiz kadar parametre gönderebiliyoruz.
        {
            foreach (var logic in logics)
            {
                if (!logic.Succes)//başarısız olanı
                {
                    return logic;//business'a şu logic hatalı diye bildiriyoruz.
                }
            }
            return null;
        }
    }
}
