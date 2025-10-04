using System;
using System.Collections.Generic;

namespace App.Topics.Generics.T1_CustomDictionary
{
    public class DualKeyDictionary<TValue>
    {
        private readonly Dictionary<int, TValue> _intDictionary;
        private readonly Dictionary<string, TValue> _stringDictionary;

        public DualKeyDictionary()
        {
            _intDictionary = new Dictionary<int, TValue>();
            _stringDictionary = new Dictionary<string, TValue>();
        }

        public TValue this[int id]
        {
            get
            {
                if (!_intDictionary.TryGetValue(id, out TValue value))
                {
                    throw new KeyNotFoundException($"The given integer key '{id}' was not present in the dictionary.");
                }
                return value;
            }
            set
            {
                _intDictionary[id] = value;
            }
        }

        public TValue this[string key]
        {
            get
            {
                if (key == null)
                {
                    throw new ArgumentNullException(nameof(key), "String key cannot be null.");
                }

                if (!_stringDictionary.TryGetValue(key, out TValue value))
                {
                    throw new KeyNotFoundException($"The given string key '{key}' was not present in the dictionary.");
                }
                return value;
            }
            set
            {
                if (key == null)
                {
                    throw new ArgumentNullException(nameof(key), "String key cannot be null.");
                }

                _stringDictionary[key] = value;
            }
        }
    }
}