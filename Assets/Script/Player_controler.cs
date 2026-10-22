using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class Player_controler : MonoBehaviour
{
    public float moveSpeed = 5f; //Max speed of de paddles
    public float limitTop; //Top limit of the paddle's movement
    public float limitBottom; //Bottom limit of the paddle's movement
    public bool useArrowsKeys = false; //Selector of what player use arrow
    void Update()
    {
        movepaddle();
    }

    void movepaddle()
    {
        this.gameObject.transform.position = new Vector3(transform.position.x, limitpaddle(), transform.position.z);
    }
    float limitpaddle()
    {
        float nuevaY = this.gameObject.transform.position.y + (paddledirection() * moveSpeed * Time.deltaTime);
        if (nuevaY > limitTop)
        {
            nuevaY = limitTop;
        }
        if (nuevaY < limitBottom)
        {
            nuevaY = limitBottom;
        }
        return nuevaY;
    }
    float paddledirection()
    {
        float direccion = 0f;
        if (useArrowsKeys == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direccion = 1f;

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                direccion = -1f;
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                direccion = -1f;
            }
        }
        return direccion;
    }
}
