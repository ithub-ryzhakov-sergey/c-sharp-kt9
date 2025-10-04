namespace App.T1_CustomDictionary;
public class DualKeyDictionary<TValue>
{
    private Dictionary<int, TValue> _dictByID = new Dictionary<int, TValue>();
    private Dictionary<string, TValue> _dictByKey = new Dictionary<string, TValue>();









    public TValue this[int id]
    {
        get
        {
            
            if (!_dictByID.ContainsKey(id))
            {
                throw new KeyNotFoundException();
            }
            return _dictByID[id];
        }




            


        set
        {
            if (value == null)
            {
                throw new ArgumentException();
            }

            if ( _dictByID.ContainsKey(id) )
            {
                _dictByID[id] = value;
            }

            _dictByID[id] = value;
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
            if (!_dictByKey.ContainsKey(key))
            {
                throw new KeyNotFoundException();
            }
            return _dictByKey[key];
        }




        set
        {
            if( value == null)
            {
                throw new ArgumentException();
            }

            if( _dictByKey.ContainsKey(key))
            {
                _dictByKey[key] = value;
            }

            _dictByKey[key] = value;
        }
    }

















    public void KeyNotFoundException(string key)
    {
        if (!_dictByKey.ContainsKey(key))
        {
            throw new KeyNotFoundException();
        }
    }

}