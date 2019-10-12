using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laptop_on_script : MonoBehaviour
{

    public GameObject laptopoff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        laptopoff.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
