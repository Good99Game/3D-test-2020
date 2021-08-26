using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    public float sensitivity = 70f;

    void Update() {
        transform.position = player.transform.position;
    }
}