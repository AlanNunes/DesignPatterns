using System;

namespace CacheSingleton.Singleton
{
    public class Cache
    {
        private static Cache _cache;

        public Guid Guid { get; set; }

        public Cache() { }

        public static Cache GetInstance()
        {
            if (_cache == null)
            {
                _cache = new Cache() { Guid = Guid.NewGuid() };
            }
            return _cache;
        }
    }
}
