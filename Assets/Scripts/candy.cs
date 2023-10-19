using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class candy : MonoBehaviour
{
    [SerializeField] private GameObject[] textures;//Contains possible sprites
    public int[] candySpawn = new int[21];//Contains the id of candy textures in different wieghts to be randomly selected from
    public int spawnIndex;

    void Start()
    {

        int index = 0;
        for (int i = 6; i > 0; i--)//Create 
        {
            for(int j = i; j > 0; j--)
            {
                candySpawn[index] = i;
                index++;
            }
        }

        spawnIndex = Random.Range(0, 20);//Set candy type from candySpawn array

        textures[candySpawn[spawnIndex]].SetActive(true);//Set corresponding sprite to be active
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
