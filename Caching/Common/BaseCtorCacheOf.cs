using System.Collections.Generic;

namespace Roman.Ambinder.EnumHelpers.Caching.Common
{
    public abstract class BaseCtorCacheOf<T> : ICacheOf<T>
    {
        private readonly IReadOnlyList<T> _all;

        protected BaseCtorCacheOf(IReadOnlyList<T> all)
        {
            _all = all;
        }

        public ref readonly IReadOnlyList<T> All => ref _all;
    }
}