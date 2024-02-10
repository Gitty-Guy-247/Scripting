using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonTwo : MonoBehaviour
{
    //NPC Health
    public int health = 5;
    //NPC Level
    public int level = 1;
    //NPC Speed
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        // Adding the health and the level then printing health
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
