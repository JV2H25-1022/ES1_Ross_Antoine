using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuBille : MonoBehaviour
{

    [SerializeReference] private GameObject _sardine;
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
        if(_sardine != null)
        {
          _sardine.SetActive(false);   
        }
       
          
    }

}
