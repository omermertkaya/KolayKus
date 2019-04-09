using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColomnPool : MonoBehaviour
{
    public int colomnPoolSize = 5;
    public GameObject columnPrefab;
    
    public float spawnRate = 4f;
    public float colomnMin = 1f;
    public float colomnMax = 3.5f;

    private GameObject[] colomns;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColomn = 0;




    // Start is called before the first frame update
    void Start()
    {
        colomns = new GameObject[colomnPoolSize];
        for (int i = 0; i < colomnPoolSize; i++)
        {
            colomns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if(GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosiiton = Random.Range(colomnMin, colomnMax);
            colomns[currentColomn].transform.position = new Vector2(spawnXPosition, spawnYPosiiton);
            currentColomn++;
            if(currentColomn >= colomnPoolSize)
            {
                currentColomn = 0;

            }
        }
        
    }
}
