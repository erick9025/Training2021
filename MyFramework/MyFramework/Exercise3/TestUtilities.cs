using System;
using System.ComponentModel;

namespace Inheritance.Exercise3
{
    public static class TestUtilities
    {
        /// <summary>
        /// Returns the description atribute from a given enum value
        /// </summary>
        /// <typeparam name="T">Enum type</typeparam>
        /// <param name="enumValue">Enum value</param>
        /// <returns></returns>
        public static string GetDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            //https://blog.hildenco.com/2018/07/getting-enum-descriptions-using-c.html

            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }

        public static int GetAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
    }

    public enum Gender
    {
        [Description("Male (Man)")]
        Male,
        [Description("Female (Woman)")]
        Female,
        [Description("Not binary")]
        NotBinary
    }
}
