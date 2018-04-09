using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using VA.App.Scripts;

public class ModelController : MonoBehaviour , IInputClickHandler,IFocusable {

    public BeamState beamState;
    private GameObject defaultCursor;

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
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        defaultCursor = GameObject.Find("DefaultCursor");
    }
	
	// Update is called once per frame
	void Update () {
        if(beamState == BeamState.Active)
        {
            transform.position = defaultCursor.transform.position;
        }
	}
}
