using System;
using System.Collections.Generic;

namespace Roman.Ambinder.EnumHelpers.Caching
{
    public class CachedEnumValuesNamesOf<TEnum>
        where TEnum : Enum
    {
        private CachedEnumValuesNamesOf() { }

        public ref readonly IReadOnlyList<TEnum> Values =>
            ref CachedEnumValuesOf<TEnum>.Instance.All;

        public ref readonly IReadOnlyList<string> Names =>
            ref CachedEnumNamesValuesOf<TEnum>.Instance.All;

        public static CachedEnumValuesNamesOf<TEnum> Instance { get; }
            = new CachedEnumValuesNamesOf<TEnum>();
    }
}