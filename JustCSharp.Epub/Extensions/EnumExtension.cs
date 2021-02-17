using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace JustCSharp.Epub.Extensions
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var displayNameAttribute = enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttribute<DisplayAttribute>();

            if(displayNameAttribute != null)
            {
                return displayNameAttribute.Name;
            }

            return enumValue.ToString();
        }
        
        public static T GetAttribute<T>(this Enum enumValue) where T: Attribute
        {
            var attribute = enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttribute<T>();
            return attribute;
        }
    }
}