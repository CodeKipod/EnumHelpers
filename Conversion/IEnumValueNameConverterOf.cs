using System;

namespace Roman.Ambinder.EnumHelpers.Conversion
{
    public interface IEnumValueNameConverterOf<TEnum>
          where TEnum : struct, Enum
    {
        bool TryConvert(in string name, out TEnum value);

        string Convert(in TEnum value);
    }
}