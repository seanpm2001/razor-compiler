// <auto-generated />
namespace Microsoft.VisualStudio.LanguageServices.Razor
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.VisualStudio.LanguageServices.Razor.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Value cannot be null or an empty string.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get => GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// Value cannot be null or an empty string.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
            => GetString("ArgumentCannotBeNullOrEmpty");

        /// <summary>
        /// An unexpected exception occurred when invoking '{0}.{1}' on the Razor language service.
        /// </summary>
        internal static string UnexpectedException
        {
            get => GetString("UnexpectedException");
        }

        /// <summary>
        /// An unexpected exception occurred when invoking '{0}.{1}' on the Razor language service.
        /// </summary>
        internal static string FormatUnexpectedException(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnexpectedException"), p0, p1);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
