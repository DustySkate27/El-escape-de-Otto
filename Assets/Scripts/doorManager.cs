using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorManager : MonoBehaviour
{

    [SerializeField] public bool d742in = false;
    [SerializeField] public bool d742out = false;

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
            if (d742in == true && collision.gameObject.CompareTag("Player"))
            {
                d742in = false;
                SceneManager.LoadScene("742");
            }

            if (d742out == true && collision.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene("pasillos");
            }
        }
    }

}
