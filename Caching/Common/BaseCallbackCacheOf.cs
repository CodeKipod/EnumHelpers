using System.Collections.Generic;

namespace Roman.Ambinder.EnumHelpers.Caching.Common
{
    public abstract class BaseCallbackCacheOf<T> : ICacheOf<T>
    {
        private readonly IReadOnlyList<T> _all;

        protected BaseCallbackCacheOf()
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            _all = OnGetAll();
        }

        protected abstract IReadOnlyList<T> OnGetAll();

        public ref readonly IReadOnlyList<T> All => ref _all;
    }
}