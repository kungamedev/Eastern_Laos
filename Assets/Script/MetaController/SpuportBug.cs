using UnityEngine;

public class SpuportBug : MonoBehaviour
{
    
    public string Url;
    public void Open() 
    {
        Application.OpenURL(Url);
    }
    
}
