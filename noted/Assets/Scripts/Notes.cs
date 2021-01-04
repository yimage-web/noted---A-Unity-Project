using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public int countSpec = 0;
    private bool pulled;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countSpec = 0;
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        if (!pulled)
        {
            transform.Translate(Vector3.back);
            pulled = true;
            countSpec = 1;
        }
        else
        {
            transform.Translate(Vector3.forward);
            pulled = false;
            countSpec = -1;
        }

        
    }
}
