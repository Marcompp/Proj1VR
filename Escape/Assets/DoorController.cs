using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;

public class DoorController : MonoBehaviour
{
    private Rigidbody rb;
    public int[] password = {1,2,3,4};
    private int[] inputed = {0,0,0,0};
    private bool open = false;
    static int input;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static public void teste() {
        print("A");
    }

    public void addInput(int input) 
    {
        if (!open) {
            for (int inn = 0; inn < inputed.Length; inn++) {
                if (inputed[inn] == 0) 
                {
                    inputed[inn] = input;
                    break;
                }
            }
            if (inputed[3] != 0) {
                if (inputed.SequenceEqual(password)) {
                    //Sucess se
                    open = true;
                    rb.velocity = new Vector3(0,2,0);
                }
                else {
                    //Buzzer
                    inputed = new int[] {0,0,0,0};
                }
            }
        }
    }
}
