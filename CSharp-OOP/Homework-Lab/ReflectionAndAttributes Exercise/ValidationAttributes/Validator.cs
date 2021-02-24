using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
   public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] propInfo = obj
                .GetType()
                .GetProperties();
            bool result = true;
            foreach (PropertyInfo prop in propInfo)
            {
                IEnumerable<MyValidationAttribute> customPropAttr = prop.GetCustomAttributes()
                    .Where(x=>x is MyValidationAttribute)
                    .Cast<MyValidationAttribute>();
                foreach (MyValidationAttribute validationProp in customPropAttr)
                {
                    result = validationProp.IsValid(prop.GetValue(obj));
                    if (!result)
                    {
                    return result;

                    }
                }
            }
            return result;
        }
    }
}
