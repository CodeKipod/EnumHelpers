using System;
using System.Collections.Generic;
using System.Linq;

namespace Roman.Ambinder.EnumHelpers.Conversion
{
    public class PreloadedCachedEnumValueNameConverterOf<TEnum> :
        IEnumValueNameConverterOf<TEnum>
        where TEnum : struct, Enum
    {
        private readonly IReadOnlyDictionary<string, TEnum> _valuesByNames;

        private readonly IReadOnlyDictionary<TEnum, string> _namesByValues;

        private PreloadedCachedEnumValueNameConverterOf()
        {
            var values = EnumHelpers.GetValuesFor<TEnum>();
            _valuesByNames = values.ToDictionary(v => v.ToString(), v => v);
            _namesByValues = values.ToDictionary(v => v, v => v.ToString());
        }

        public bool TryConvert(in string name, out TEnum value)
            => _valuesByNames.TryGetValue(name, out value);

        public string Convert(in TEnum value) => _namesByValues[value];

        public static IEnumValueNameConverterOf<TEnum> Instance { get; }
            = new PreloadedCachedEnumValueNameConverterOf<TEnum>();
    }
}