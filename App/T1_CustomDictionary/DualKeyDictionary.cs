namespace App.Topics.Generics.T1_CustomDictionary;

public class DualKeyDictionary<TValue>
{
    private Dictionary<int, TValue> _intDict = new Dictionary<int, TValue>();
    private Dictionary<string, TValue> _stringDict = new Dictionary<string, TValue>();
    public TValue this[int id]
    {
        get
        {
            if (this._intDict.ContainsKey(id))
            {
                return this._intDict[id];
            }
            throw new KeyNotFoundException();

        }

        set
        {
            this._intDict[id] = value;
        }
    }
    public TValue this[string key]
    {
        get
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            if (this._stringDict.ContainsKey(key))
            {
                return this._stringDict[key];
            }
            throw new KeyNotFoundException();
        }

        set
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            _stringDict[key] = value;
        }

    }
}