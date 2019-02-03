using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fileControler : MonoBehaviour
{
   // public Transform gameobject;

    public float movementSpeed = 10;
    // Start is called before the first frame update
    void Start()

    {





    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }

    }


    void OnCollisionEnter2D(Collision2D collision2D)
    {
        //If the object we collided with a tree
        Debug.Log("OnCollisionEnter2D");
        if (collision2D.gameObject.tag == "Tree")
        {
            Destroy(collision2D.collider.gameObject);
            gameObject.transform.localScale += new Vector3(1, 1, 1);
        }

        if (collision2D.gameObject.tag == "water")
        {
            Destroy(collision2D.collider.gameObject);
            gameObject.transform.localScale -= new Vector3(0.2f,0.2f,0.2f);
        }


    }







}
