using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Pool;
using Vector3 = UnityEngine.Vector3;

public class Generate : MonoBehaviour
{
    [SerializeField]
    public static Generate instance;
    public GameObject normalCollectible;
    public GameObject bigCollectible;
    public GameObject damageCollectible;
    public Transform leftBorder;
    public Transform rightBorder;
    public Transform topBorder;

    private float timer = 1;
    private List<GameObject> normalColls = new List<GameObject>();
    // private List<GameObject> bigColls = new List<GameObject>();
    // private List<GameObject> damageColls = new List<GameObject>();

    private int normalPoolSize = 10;
    private UnityEngine.Vector3 lastPosition;
    //private int bigPoolSize = 10;
    //private int damagePoolSize = 10;    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void instantiateCollectibles(List<GameObject> colls, GameObject coll, int poolSize)
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject collectible = Instantiate(coll);
            collectible.SetActive(false);
            colls.Add(collectible);
        }
    }

    void Start()
    {
        instantiateCollectibles(normalColls, normalCollectible, normalPoolSize);
        //instantiateCollectibles(bigColls, bigCollectible, bigPoolSize);
        //instantiateCollectibles(damageColls, damageCollectible, damagePoolSize);
    }

    private GameObject GetCollectible(List<GameObject> colls)
    {
        for (int i = 0; i < colls.Count; i++)
        {
            if (!colls[i].activeInHierarchy)
            {
                return colls[i];
            }
        }

        return null;
    }

    private void generateCollectible(GameObject coll, Vector3 position)
    {
        if (coll == null) return;

        coll.transform.position = position;
        coll.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            //int chance = Random.Range(1, 100);
            
            generateCollectible(GetCollectible(normalColls), GetRandomPosition());
            
            timer = 0.7f;
        }
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 newPosition;
        if (lastPosition == null)
        {
            lastPosition = GenerateRandomPosition();
            newPosition = lastPosition;
        } else 
        {
            do 
            {
                newPosition = GenerateRandomPosition();
            } while (Vector3.Distance(newPosition, lastPosition) < 3f);
            lastPosition = newPosition;
        }
        

        return  newPosition;
    }

    private Vector3 GenerateRandomPosition() {
        float positionX = Random.Range(leftBorder.position.x, rightBorder.position.x);
        float positionY = topBorder.position.y;
        return new Vector3(positionX, positionY, 0);
    }
}
