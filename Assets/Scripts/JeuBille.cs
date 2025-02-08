using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuBille : MonoBehaviour
{

    public GameObject PlataformeInitiale;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Starting()
    {
          PlataformeInitiale.SetActive(false);     
    }

}
