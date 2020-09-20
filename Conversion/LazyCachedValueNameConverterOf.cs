using System;
using System.Collections.Concurrent;

namespace Roman.Ambinder.EnumHelpers.Conversion
{
    public class LazyCachedValueNameConverterOf<TEnum> :
        IEnumValueNameConverterOf<TEnum> where TEnum : struct, Enum
    {
        private readonly ConcurrentDictionary<string, TEnum> _valuesByNames =
            new ConcurrentDictionary<string, TEnum>();

        private readonly ConcurrentDictionary<TEnum, string> _namesByValues =
            new ConcurrentDictionary<TEnum, string>();

        private LazyCachedValueNameConverterOf() { }

        public bool TryConvert(in string name, out TEnum value)
        {
            if (_valuesByNames.TryGetValue(name, out value))
                return true;

            if (Enum.TryParse(name, out value))
            {
                _valuesByNames.TryAdd(name, value);
                return true;
            }

            return false;
        }

        public string Convert(in TEnum value)
            => _namesByValues.GetOrAdd(value, value.ToString());

        public static IEnumValueNameConverterOf<TEnum> Instance { get; }
            = new LazyCachedValueNameConverterOf<TEnum>();
    }
}