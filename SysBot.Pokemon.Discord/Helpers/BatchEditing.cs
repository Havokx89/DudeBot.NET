using System;
using System.Collections.Generic;

namespace SysBot.Pokemon.Discord
{
    public static class BatchEditing
    {
        // Minimal mapping of batch-editable property names to their expected type names.
        // Extend this dictionary with the actual properties supported by your application.
        private static readonly Dictionary<string, string> _propertyTypes = new(StringComparer.OrdinalIgnoreCase)
        {
            { "species", "string" },
            { "level", "int" },
            { "nickname", "string" },
            { "shiny", "bool" },
            { "ability", "string" },
        };

        public static bool TryGetPropertyType(string propertyName, out string? typeName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                typeName = null;
                return false;
            }

            return _propertyTypes.TryGetValue(propertyName, out typeName);
        }
    }
}
