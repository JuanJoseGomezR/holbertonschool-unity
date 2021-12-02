using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebXR;
using Zinnia.Action;

public class WebTrigger : BooleanAction
{
    public WebXRController controller;
    void Update()
    {
        Receive( controller.GetButton(WebXRController.ButtonTypes.Trigger) );
    }
}
