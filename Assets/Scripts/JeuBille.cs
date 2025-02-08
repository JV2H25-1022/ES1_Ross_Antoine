using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuBille : MonoBehaviour
{

    [SerializeReference] private GameObject _plateforme;
    // Start is called before the first frame update
    void Start()
    {
        _plateforme.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
