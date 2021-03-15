using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmove : MonoBehaviour
{

    // [SerializeField]
    float Speed = 5.0f;
    float run = 1f; 

    private Rigidbody2D rig;
    private Animator anim;
    private Vector2 InputAxis;

    public bool IsEncount = false;

    void Start(){
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        this.transform.position = new Vector2(PlayerPrefs.GetFloat("PPosX"), PlayerPrefs.GetFloat("PPosY"));
        anim.SetFloat("last_x",PlayerPrefs.GetFloat("PLastX"));
        anim.SetFloat("last_y",PlayerPrefs.GetFloat("PLastY"));
    }

    void Update(){
        if(!IsEncount){

            if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
                InputAxis = new Vector2(Input.GetAxis("Horizontal"), 0);
            else if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
                InputAxis = new Vector2(0, Input.GetAxis("Vertical"));
            else
                InputAxis = new Vector2(0, 0);

            anim.SetFloat("x", InputAxis.x);
            anim.SetFloat("y", InputAxis.y);

            if(Input.GetKey(KeyCode.LeftShift)) {
                run = 1.5f;
            }
            else {
                run = 1f;
            }
        }
        else
            InputAxis = new Vector2(0, 0);
    }
    private void FixedUpdate(){
        rig.velocity = InputAxis.normalized * Speed * run;
    }

    public void SetPos(){
        PlayerPrefs.SetFloat("PPosX",this.transform.position.x);
        PlayerPrefs.SetFloat("PPosY", this.transform.position.y);
        PlayerPrefs.SetFloat("PLastX", this.anim.GetFloat("last_x"));
        PlayerPrefs.SetFloat("PLastY", this.anim.GetFloat("last_y"));
        PlayerPrefs.Save();
    }

    /*Vector2 GetPos()
    {
        Vector2 pos = new Vector2(PlayerPrefs.GetInt("PPosX"), PlayerPrefs.GetInt("PPosY"));
        return pos;
    }*/

    void lastup(){
        anim.SetFloat("last_x",0);
        anim.SetFloat("last_y",1);
    }
    void lastdown(){
        anim.SetFloat("last_x",0);
        anim.SetFloat("last_y",-1);
    }
    void lastright(){
        anim.SetFloat("last_x",1);
        anim.SetFloat("last_y",0);
    }
    void lastleft(){
        anim.SetFloat("last_x",-1);
        anim.SetFloat("last_y",0);
    }
}