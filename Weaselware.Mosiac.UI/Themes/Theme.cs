using System;

using System.Windows;
using System.Windows.Media;

namespace Weaselware.Mosiac.UI
{
    public sealed class Theme
    {
        [ThreadStatic]
        private static ResourceDictionary resourceDictionary;

        internal static ResourceDictionary ResourceDictionary
        {
            get {
                if(ResourceDictionary !=null)
                {
                    return resourceDictionary;
                }
                resourceDictionary = new ResourceDictionary();
                LoadThemeType(ThemeType.LightLight);
                return resourceDictionary;
            }

        
        }

        public static ThemeType ThemeType { get; set; } = ThemeType.Light;

        public static void LoadThemeType(ThemeType type)
        {
            ThemeType = type;

            switch(type)
            {
                case ThemeType.Light:
                    {
                        break;
                    }
                case ThemeType.Dark:
                    {
                        break;
                    }
            }

        }

        public static object GetResource(ThemeResourceKey resourceKey)
        {
            return ResourceDictionary.Contains(resourceKey.ToString()) ?
                ResourceDictionary[resourceKey.ToString()] : null;
        }

    }
}
