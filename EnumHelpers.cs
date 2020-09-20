using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Roman.Ambinder.EnumHelpers
{
    public static class EnumHelpers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IReadOnlyList<TEnum> GetValuesFor<TEnum>()
            where TEnum : Enum
         => Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .ToArray();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IReadOnlyList<string> GetNamesFor<TEnum>()
            where TEnum : Enum
            => Enum.GetValues(typeof(TEnum))
                .Cast<object>()
                .Select(v => v.ToString())
                .ToArray();
    }
}