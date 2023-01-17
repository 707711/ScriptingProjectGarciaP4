using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSate : MonoBehaviour
{
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Actice Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
