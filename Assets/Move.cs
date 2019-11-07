using System.Collections;
using UnityEngine;

public class Move : MonoBehaviour {
    public GameObject player;
    public int speedRotation = 1;
    public int speed = 2;
    //public AnimationClip anima;
    public int jumpSpeed = 150;

    // Start is called before the first frame update
    void Start () {
        player = (GameObject) this.gameObject;
        // GetComponent<Animation> ().AddClip (anima, "animCube");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
            player.transform.position -= player.transform.up * speed * Time.deltaTime;
            //GetComponent<Animation> ().CrossFade ("animCube");
        }
        if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
            player.transform.position += player.transform.up * speed * Time.deltaTime;
            //player.transform.Rotate (Vector3.down * speedRotation);
        }
        if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
            player.transform.position -= player.transform.right * speedRotation * Time.deltaTime;
            //player.transform.Rotate (Vector3.left * speedRotation);
        }
        if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
            player.transform.position += player.transform.right * speedRotation * Time.deltaTime;
            //player.transform.Rotate (Vector3.right * speedRotation);
        }
        if (Input.GetKeyDown (KeyCode.Space)) {
            player.transform.position += player.transform.forward * jumpSpeed * Time.deltaTime;
        }
    }
}