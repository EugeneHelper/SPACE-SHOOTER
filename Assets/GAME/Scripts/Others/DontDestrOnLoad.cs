using UnityEngine;

public class DontDestrOnLoad : MonoBehaviour
{
    private static DontDestrOnLoad inctance;
    void Start()
    {
        if (inctance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            inctance = this;
        }
        
        DontDestroyOnLoad(this.gameObject);
    }
}