using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Transform Tr;
    float obtSpeed = 5;

    public GameObject[] Items;
    public GameObject[] Models;

    public int randomModel;

    public GameObject tossObj;

    // Start is called before the first frame update
    void Start()
    {
        randomModel = Random.Range(0, 3);
        Items[randomModel].SetActive(true);
        Models[randomModel].SetActive(true);

        gameObject.layer = randomModel+6; // 6,7,8 이 되어야 함

        tossObj = Items[randomModel];

        Tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Tr.position += -Tr.right * obtSpeed * Time.deltaTime;
    }
}
