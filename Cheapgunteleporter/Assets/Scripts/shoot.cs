using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            GameObject bullet = Resources.Load("Bullet") as GameObject;
            Instantiate(bullet, transform.position, transform.rotation);
            
        }
    }
}
