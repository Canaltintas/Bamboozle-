using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Road : MonoBehaviour
{
    public GameObject roads;
    private List<GameObject> clone = new List<GameObject>();
    
    private float distance;
    public float createDistance = 0f;

    private int index=0;
    private int cloneindex = 0;

    public GameObject[] collectables,obstacles;
    public GameObject spawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject newRoad = Instantiate(roads, new Vector3(createDistance, 0, 0), Quaternion.identity);
            clone.Add(newRoad);
           createDistance += 50f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.gameObject.transform.position, clone[index].transform.position);
        if (distance > 50)
        {
            if (index <2)
            {
                index += 1;
            }
            else
            {
                index = 0;
            }
            clone[cloneindex].transform.position = new Vector3(createDistance, 0, 0);
            createDistance += 50f;
            cloneindex = index;
            MixedCollectable();
            
        }
        //MixedCollectable();
        
    }

    void MixedCollectable()
    {
        
       // collectables[0].transform.position = new Vector3(this.gameObject.transform.position.x + 50f, 2f, 3.68f);
        
        
            int randCollect = Random.Range(0, 2);
            int randLocation = Random.Range(0, 3);
            int randStatue = Random.Range(0, 5);
            
                if (randLocation == 0)
                {
                    collectables[randCollect].transform.position = new Vector3(this.gameObject.transform.position.x + 50f, 2f, -3.68f);
                    
                }else if (randLocation == 1)
                {
                    collectables[randCollect].transform.position = new Vector3(this.gameObject.transform.position.x + 50f, 2f, 3.68f);
                }
                else
                {
                    collectables[randCollect].transform.position = new Vector3(this.gameObject.transform.position.x + 50f, 2f, 0f);
                }

                if (randStatue == 0) 
                {
                    obstacles[0].transform.position = new Vector3(spawnPoint.transform.position.x, 0f, 0f);
                }else if (randStatue == 1)
                {
                    obstacles[0].transform.position = new Vector3(spawnPoint.transform.position.x, 0f, 3.68f);
                }else if (randStatue == 2)
                {
                    obstacles[0].transform.position = new Vector3(spawnPoint.transform.position.x, 0f, -3.68f);
                }else if (randStatue == 3)
                {
                    obstacles[1].transform.position = new Vector3(spawnPoint.transform.position.x, 0f, 4.25f);
                }else if (randStatue == 4)
                {
                    obstacles[1].transform.position = new Vector3(spawnPoint.transform.position.x, 0f, -2.18f);
                }
                        
            
            //collectables[randCollect].transform.position = spawnPoints[randLocation].transform.position;
        

    }

   
}
