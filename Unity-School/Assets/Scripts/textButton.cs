using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textButton : MonoBehaviour
{
    public Transform prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void txtButton()
    {
        print("You just clicked the button");  
    }

    public void spawnBn()
    {
        Instantiate(prefab, new Vector3(-0.99F, 3.15f, -4.96f), Quaternion.identity);
    }

}
