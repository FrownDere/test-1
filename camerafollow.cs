using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;

    
    

    void Update ()

    {
        
        
        transform.LookAt(target);
        
        

    }


}
