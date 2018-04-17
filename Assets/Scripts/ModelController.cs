using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using VA.App.Scripts;

public class ModelController : MonoBehaviour , IInputClickHandler,IFocusable,IInputHandler,IHoldHandler {

    public BeamState beamState;
    private GameObject defaultCursor;
    private Animator animator;
    private float faceWeightLayer;
    private bool onInputDown = false;
    public bool alwaysFacePlayer = true;
    public string[] animationsString;

    public void OnFocusEnter()
    {
        
    }

    public void OnFocusExit()
    {
        
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        animator.Play(animationsString[Random.Range(0, animationsString.Length - 1)]);
    }

    public void OnInputDown(InputEventData eventData)
    {
        onInputDown = true;
    }

    public void OnInputUp(InputEventData eventData)
    {
        onInputDown = false;
    }

    // Use this for initialization
    void Start () {
        defaultCursor = GameObject.Find("DefaultCursor");
        animator = gameObject.GetComponent<Animator>();
        animationsString = new string[] { "WAIT02", "REFLESH00", "WAIT04", "WAIT03", "WIN00", "LOSE00", "WAIT01" };
    }
	
	// Update is called once per frame
	void Update () {
        if(beamState == BeamState.Active)
        {
            transform.position = defaultCursor.transform.position;
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = true;
            if (onInputDown)
            {
                faceWeightLayer = 1;
            }
            else
            {
                faceWeightLayer = Mathf.Lerp(faceWeightLayer, 0, 0.3f);
            }
            animator.SetLayerWeight(1, faceWeightLayer);
        }

        if (alwaysFacePlayer)
        {
            Vector3 playerPos = new Vector3(Camera.main.transform.position.x, gameObject.transform.position.y, Camera.main.transform.position.z);
            this.transform.LookAt(playerPos);
        }
	}

    public void OnHoldStarted(HoldEventData eventData)
    {
        alwaysFacePlayer = !alwaysFacePlayer;
    }

    public void OnHoldCompleted(HoldEventData eventData)
    {
        
    }

    public void OnHoldCanceled(HoldEventData eventData)
    {
        
    }
}
