using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bille : MonoBehaviour
{
    private float timer=0f;
    
     [SerializeField] private bool _restart = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_restart){
            timer += Time.deltaTime;
             if(timer >= 5f){
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }  
        }
 
    }
        void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }
    
        else if (collision.gameObject.CompareTag("Terminus"))
        {
            _restart = true;
            timer =0f;

        }
    }
}
