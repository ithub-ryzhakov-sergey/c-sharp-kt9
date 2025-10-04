using System;
using System.Collections.Generic;

namespace App.Topics.Generics.T1_CustomDictionary
{
    public class DualKeyDictionary<TValue>
    {
        public Dictionary<int, TValue> intDict = new Dictionary<int, TValue>();
        public Dictionary<string, TValue> stringDict = new Dictionary<string, TValue>();

        public TValue this[int id]
        {
            get
            {
                if (intDict.TryGetValue(id, out var value))
                {
                    return value;
                }
                throw new KeyNotFoundException($"элемент с ключом {id} не найден");
            }
            set
            {
                intDict[id] = value;
            }
        }

        public TValue this[string key]
        {
            get
            {
                if (key == null)
                    throw new ArgumentNullException(nameof(key));
                if (stringDict.TryGetValue(key, out var value))
                {
                    return value;
                }
                throw new KeyNotFoundException($"элемент с ключом {key} не неайден");
            }
            set
            {
                if (key == null)
                    throw new ArgumentNullException(nameof(key));
                stringDict[key] = value;
            }
        }
    }
}