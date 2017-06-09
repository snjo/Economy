[System.Serializable]
public class Resource
{    
    public string name;
    public float amount;

    public Resource(string name)
    {
        this.name = name;
        this.amount = 0;
    }
}