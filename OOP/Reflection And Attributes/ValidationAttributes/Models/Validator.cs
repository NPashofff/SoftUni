namespace ValidationAttributes.Models
{
    using System.Reflection;
    using CustomAtributes;
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] property = obj
                .GetType()
                .GetProperties();

            foreach (PropertyInfo item in property)
            {
                MyValidationAttribute customAtribute = (MyValidationAttribute)item
                    .GetCustomAttribute(typeof(MyValidationAttribute), false);

                bool isValid = customAtribute.IsValid(item.GetValue(obj));
                if (!isValid)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
