using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using VA.App.Scripts;

public class ModelController : MonoBehaviour , IInputClickHandler,IFocusable,IInputHandler {

    public BeamState beamState;
    private GameObject defaultCursor;
    private Animator animator;
    private float faceWeightLayer;
    private bool onInputDown = false;

    public void OnFocusEnter()
    {
        throw new System.NotImplementedException();
    }

    public void OnFocusExit()
    {
        throw new System.NotImplementedException();
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        
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

    }
	
	// Update is called once per frame
	void Update () {
        if(beamState == BeamState.Active)
        {
            transform.position = defaultCursor.transform.position;
        }
        else
        {
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
	}


}
