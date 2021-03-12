using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmove : MonoBehaviour
{

    // [SerializeField]
    float Speed = 5.0f;
    float run = 1f; 
    

    private Rigidbody2D rig;
    private Animator anim;
    private Vector2 InputAxis;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // void Awake () {
	//     DontDestroyOnLoad(gameObject);
    // }

    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
            InputAxis = new Vector2(Input.GetAxis("Horizontal"), 0);
        else if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
            InputAxis = new Vector2(0, Input.GetAxis("Vertical"));
        else
            InputAxis = new Vector2(0, 0);

        anim.SetFloat("x", InputAxis.x);
        anim.SetFloat("y", InputAxis.y);
        
        if(Input.GetKey(KeyCode.LeftShift)) {
            run = 1.4f;
        }
        else {
            run = 1f;
        }
        if(Input.GetKeyDown(KeyCode.E)) {
            
        }
    }
    private void FixedUpdate()
    {
        rig.velocity = InputAxis.normalized * Speed * run;
    }

    void lastup()
    {
        anim.SetFloat("last_x",0);
        anim.SetFloat("last_y",1);
    }
    void lastdown()
    {
        anim.SetFloat("last_x",0);
        anim.SetFloat("last_y",-1);
    }
    void lastright()
    {
        anim.SetFloat("last_x",1);
        anim.SetFloat("last_y",0);
    }
    void lastleft()
    {
        anim.SetFloat("last_x",-1);
        anim.SetFloat("last_y",0);
    }
}
