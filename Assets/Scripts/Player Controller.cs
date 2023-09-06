using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SurfaceEffector2D surface;
    public float torqueAmount = 1f;

    public float boostSpeed = 30f;
    public float baseSpeed = 20f;

    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surface = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            AddRotation();
            AddBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void AddRotation()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueAmount);
        }
    }

    void AddBoost(){
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surface.speed = boostSpeed;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            surface.speed = baseSpeed;
        }
    }  
}
