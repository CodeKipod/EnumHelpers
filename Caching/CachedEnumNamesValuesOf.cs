using System;
using Roman.Ambinder.EnumHelpers.Caching.Common;

namespace Roman.Ambinder.EnumHelpers.Caching
{
    public sealed class CachedEnumNamesValuesOf<TEnum> : BaseCtorCacheOf<string>
        where TEnum : Enum
    {
        private CachedEnumNamesValuesOf() 
            : base(EnumHelpers.GetNamesFor<TEnum>()) { }

        public static ICacheOf<string> Instance { get; } = new CachedEnumNamesValuesOf<TEnum>();
    }
}