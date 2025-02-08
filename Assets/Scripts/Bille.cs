using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bille : MonoBehaviour
{
     public string sceneToReload = "ES1-Demo_Devoir"; // Remplacez par le nom de votre scène

    // Le nom ou le tag de l'objet spécifique avec lequel l'objet doit entrer en contact
    public string objectTag = "Terminus";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }
    
        else if (collision.gameObject.CompareTag("Terminus"))
        {
            StartCoroutine(RedemarrerAvecDelai(5f)); 
        }
    }

    
    IEnumerator RedemarrerAvecDelai(float delay)
    {
        
        yield return new WaitForSeconds(delay);
        
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
