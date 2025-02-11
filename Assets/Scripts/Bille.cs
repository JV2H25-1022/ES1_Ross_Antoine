using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bille : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {

 
    }
        void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }
    
        else if (collision.gameObject.CompareTag("Terminus"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
