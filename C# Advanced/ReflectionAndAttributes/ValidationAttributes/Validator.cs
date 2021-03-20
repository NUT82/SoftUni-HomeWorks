using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType().GetProperties();
            
            foreach (var property in properties)
            {
                var atributes = property.GetCustomAttributes().Cast<MyValidationAttribute>().ToArray();

                foreach (var atribute in atributes)
                {
                    bool isValid = atribute.IsValid(property.GetValue(obj));
                    if (!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
