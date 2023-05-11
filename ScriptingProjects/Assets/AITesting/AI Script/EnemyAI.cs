using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update

    Transform player;
    public float enemySpeed, dis;
    Vector3 startPos;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(transform.position, player.position);
        if(dis <= 10.0f)
        {
            chase();
        }
    }

    void chase()
    {
        transform.LookAt(player);
        transform.Translate(0, 0, enemySpeed * Time.deltaTime);
    }
}
