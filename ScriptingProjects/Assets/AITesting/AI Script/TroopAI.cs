using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopAI : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed, dis;
    Transform enemy;

    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);

        //dis = Vector3.Distance(transform.position, enemy.position);
        //if (dis <= 10.0f)
        {
            //chase();
        }

    }

    //void chase()
    //{
        //transform.LookAt(enemy);
        //transform.Translate(0, 0, playerSpeed * Time.deltaTime);
    //}
}
