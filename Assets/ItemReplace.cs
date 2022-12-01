using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemReplace : MonoBehaviour
{
    public GameObject brokentable; //obj1
    public GameObject futuretable; //obj2
    private bool used = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!used && Input.GetKey(KeyCode.E))
        {
            Replace(brokentable, futuretable);
            Debug.Log("Replaced");
            used = true;
        }

    }

    void Replace(GameObject obj1, GameObject obj2)
    {
        Instantiate(obj2, obj1.transform.position, Quaternion.identity);
        Destroy(obj1);
    }
}

