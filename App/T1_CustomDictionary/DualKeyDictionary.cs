using System.ComponentModel.DataAnnotations;

namespace App.T1_CustomDictionary;

public class DualKeyDictionary<TValue> {
    private Dictionary<int, TValue> _intStorage = new Dictionary<int, TValue>{};
    private Dictionary<string, TValue> _stringStorage = new Dictionary<string, TValue>{}; 
    public TValue this[int id] {
        get
        {
            if (!_intStorage.ContainsKey(id)) {
                throw new KeyNotFoundException();
            }
            return _intStorage[id];
        }
        set
        {
            if (_intStorage.ContainsKey(id))
            {
                _intStorage[id] = value;
            }
            else
            {
                _intStorage.Add(id, value);
            }
        } }
    public TValue this[string key] {
        get
        {
            if (string.IsNullOrEmpty(key)) { throw new ArgumentNullException(); }
            if (!_stringStorage.ContainsKey(key))
            {
                throw new KeyNotFoundException();
            }
            return _stringStorage[key];
        }
        set
        {
            if (string.IsNullOrEmpty(key)) { throw new ArgumentNullException(); }
            if (_stringStorage.ContainsKey(key))
            {
                _stringStorage[key] = value;
            }
            else
            {
                _stringStorage.Add(key, value);
            }
        } }
}
