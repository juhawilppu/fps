using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

    float speed = 3.0f, rot= 3.0f;
	// Use this for initialization
   
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        //bla-bla
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, Input.GetAxis("Horizontal") * rot, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        this.transform.Translate(forward * curSpeed * Time.deltaTime);
	}
}