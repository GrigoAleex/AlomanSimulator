using System.Collections.Generic;
using UnityEngine;

public class Inamic : MonoBehaviour
{
    public float speed;
    public float distantaurmarire;
    public float razamax;
    public Transform player;
    public Transform respawn;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        respawn= GameObject.FindGameObjectWithTag("Respawn").transform;
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < distantaurmarire)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }else if (Vector2.Distance(transform.position, player.position) > distantaurmarire)
        {
            transform.position = Vector2.MoveTowards(transform.position, respawn.position, speed * Time.deltaTime);
        } 
        if (Vector2.Distance(transform.position, respawn.position) > razamax)
        {transform.position = Vector2.MoveTowards(transform.position, respawn.position, speed * Time.deltaTime);}
    }         

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, distantaurmarire);
    }
}
