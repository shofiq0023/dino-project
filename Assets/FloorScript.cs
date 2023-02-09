using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {

    private float moveSpeed;
    private float deadZone = -5;
    private float speedLimit;
    private LogicManager logicManager;

    // Start is called before the first frame update
    void Start() {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        moveSpeed = logicManager.floorMoveSpeed;
        speedLimit = logicManager.speedLimit;
    }

    // Update is called once per frame
    void FixedUpdate() {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}