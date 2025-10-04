namespace App.Topics.Generics.T1_CustomDictionary;

public class Test
{
    private int value;

    public int GetValue()
    {
        return this.value;
    }

    public void SetValue(int newValue)
    {
        this.value = newValue;
    }
}

public class DualKeyDictionary<TValue>
{
    private readonly Dictionary<int, TValue> A;

    private readonly Dictionary<string, TValue> B;

    public DualKeyDictionary()
    {
        A = new Dictionary<int, TValue>();
        B = new Dictionary<string, TValue>();
    }

    public TValue this[int key]
    {
        get
        {
            return this.A[key];
        }
        set
        {
            this.A[key] = value;
        }
    }

    public TValue this[string key]
    {
        get
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            return this.B[key];
        }
        set
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            this.B[key] = value;
        }
    }

}