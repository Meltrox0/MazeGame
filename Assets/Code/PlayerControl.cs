using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;

    int health = 3;
    public TMP_Text healthText;

  //public float speed;

  //public Vector3 start;
  //public Vector3 end;
  //Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();

      //target = end;
    }

    // Update is called once per frame
    void Update()
    {
       
       Vector3 newPos = transform.position;

       if(Input.GetKey(KeyCode.D)){
       newPos.x = newPos.x + speed * Time.deltaTime;}

       if(Input.GetKey(KeyCode.A)){
       newPos.x = newPos.x - speed * Time.deltaTime;}

       if(Input.GetKey(KeyCode.W)){
       newPos.z = newPos.z + speed * Time.deltaTime;}

       if(Input.GetKey(KeyCode.S)){
       newPos.z = newPos.z - speed * Time.deltaTime;}
       
       transform.position = newPos;
       
    }

    //int AddSomeNumbers(int a, int b){
    //    int sum = a+b;
    //}

    void OnCollisionEnter(Collision otherThing){
        Debug.Log(otherThing.gameObject.name);
        if(otherThing.gameObject.name == "NotABuddy"){
            health --;
            healthText.text = health.ToString();
        }

        if(otherThing.gameObject.name == "NotABuddy (1)"){
            health --;
            healthText.text = health.ToString();
        }

        if(otherThing.gameObject.name == "NotABuddy (2)"){
            health --;
            healthText.text = health.ToString();
        }
    }
}
