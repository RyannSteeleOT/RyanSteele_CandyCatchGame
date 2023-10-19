using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class candy : MonoBehaviour
{
    [SerializeField]  private GameObject[] textures;

    void Start()
    {
        //textures = GameObject.FindGameObjectsWithTag("texture");
        textures[Random.Range(0, textures.Length)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
