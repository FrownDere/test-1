using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameManager.ins.player);
        transform.position = Vector3.MoveTowards(transform.position, GameManager.ins.player.position, speed * Time.deltaTime);
        transform.right = GameManager.ins.player.position - transform.position;
        
    }
}
