using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_script : MonoBehaviour
{

    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        light.SetActive(true);
    }


        void Awake()
    {



        


    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
