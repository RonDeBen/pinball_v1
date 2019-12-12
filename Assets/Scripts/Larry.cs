using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Larry : MonoBehaviour
{
    public GameObject plunger;
    public Vector3 PlungerStartPos, PlungerEndPos;
    public float smoothTime, plungerDelta;
    private Vector3 velocity = Vector3.zero;
	private PinballControls controls = null;
    private float lastInput = 1f;

	private void Awake(){
		controls = new PinballControls();
	}

	private void OnEnable(){
		controls.Player.Enable();
	}

	private void OnDisable(){
		controls.Player.Disable();
	}

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     	Plunger();   
    }

    public void LeftTriggerPressed(InputAction.CallbackContext context){
    	if(context.performed){
	    	Debug.Log("left press");
	    }
    }

    public void RightTriggerPressed(InputAction.CallbackContext context){
    	if(context.performed){
	    	Debug.Log("right press");
	    }
    }

    public void LeftTriggerReleased(InputAction.CallbackContext context){
    	if(context.performed){
	    	Debug.Log("left release");
	    }
    }

    public void RightTriggerReleased(InputAction.CallbackContext context){
    	if(context.performed){
	    	Debug.Log("right release");
	    }
    }

    private void Plunger(){
    	//goes from -1 to 0
    	//-1 is no pull
    	//0 is pulled all the way back
    	float plungerInput = Mathf.Abs(controls.Player.Plunger.ReadValue<float>());
        // if(plungerInput - lastInput > plungerDelta){
        // 	plungerInput = 1f;
        // }
        // lastInput = plungerInput;

        Vector3 newPos = Vector3.Lerp(PlungerStartPos, PlungerEndPos, plungerInput);
        plunger.transform.position = Vector3.Lerp(PlungerStartPos, PlungerEndPos, plungerInput);
        // plunger.transform.position = Vector3.SmoothDamp(plunger.transform.position, newPos, ref velocity, smoothTime);
    }
}
