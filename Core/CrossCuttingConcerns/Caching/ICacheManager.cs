﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Aspects.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);//Cache de varmı diye bakacağımız metot.
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
