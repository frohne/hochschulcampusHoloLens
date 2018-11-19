using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace HoloToolkit.Unity.InputModule.Tests
{
    public class OwnTapResponder_small : MonoBehaviour, IInputClickHandler
    {
        public GameObject myCarBody;
        void Start()
        {
        }
        public void OnInputClicked(InputClickedEventData eventData)
        {
            myCarBody.transform.localScale -= 0.05f * myCarBody.transform.localScale;

            eventData.Use();
        }
    }
}