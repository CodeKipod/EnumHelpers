using System;
using Roman.Ambinder.EnumHelpers.Caching.Common;

namespace Roman.Ambinder.EnumHelpers.Caching
{
    public sealed class CachedEnumValuesOf<TEnum> : BaseCtorCacheOf<TEnum>
        where TEnum : Enum
    {
        private CachedEnumValuesOf() : base(EnumHelpers.GetValuesFor<TEnum>())
        { }

        public static CachedEnumValuesOf<TEnum> Instance { get; } = new CachedEnumValuesOf<TEnum>();
    }
}