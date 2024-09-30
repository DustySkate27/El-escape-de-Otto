using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aulaManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Aula742"))
        {
            if (doorManager.d742in == true && collision.gameObject.CompareTag("Player"))
            {
                doorManager.d742in = false;
                SceneManager.LoadScene("742");
            }

            if (doorManager.d742out == true && collision.gameObject.CompareTag("Player"))
            {
                doorManager.d742out = false;
                SceneManager.LoadScene("pasillos");

            }
        }
    }



}
