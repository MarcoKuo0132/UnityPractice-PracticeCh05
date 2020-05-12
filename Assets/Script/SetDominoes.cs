using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDominoes : MonoBehaviour
{
    public GameObject dominoePrefab;
    public GameObject dominoeEnd;

    public int NumCenterDom = 25;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 dir = dominoeEnd.transform.position - transform.position;
        float interval = dir.magnitude / (NumCenterDom + 1);
        dir.Normalize();

        for (int i = 1; i <= NumCenterDom; i++)
        {
            GameObject newDom = (GameObject)Instantiate(dominoePrefab);
            newDom.transform.position = transform.position + dir * interval * i;
            newDom.transform.rotation = transform.rotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
