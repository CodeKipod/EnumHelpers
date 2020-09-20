using System.Collections.Generic;

namespace Roman.Ambinder.EnumHelpers.Caching.Common
{
    public interface ICacheOf<T>
    {
        ref readonly IReadOnlyList<T> All { get; }
    }
}