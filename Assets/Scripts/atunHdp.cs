using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atunHdp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (doorManager.exists == false)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
