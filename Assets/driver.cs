using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 50F;
    [SerializeField] float moveSpeed = 1F;



    // Start is called before the first frame update
    void Start()
    {
        
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = (Input.GetAxis("Horizontal") *steerSpeed)      * Time.deltaTime;
        float speedAmount = (Input.GetAxis("Vertical") * moveSpeed) * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);




        transform.Translate(0, speedAmount, 0);
    }
}
