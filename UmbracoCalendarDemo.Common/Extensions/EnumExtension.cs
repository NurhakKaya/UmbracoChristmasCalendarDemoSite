using System;

namespace UmbracoCalendarDemo.Common.Extensions
{
    public static class EnumExtension
    {
        public static T GetEnumValue<T>(this string value) where T : struct
        {
            T result;
            Enum.TryParse(value, true, out result);
            return result;
        }
    }
}
