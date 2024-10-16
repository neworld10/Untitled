using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerController mPlayerController;
    void Start()
    {
        mPlayerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        getKeyInput();
    }

    private void getKeyInput()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        Vector3 moveVector = (Vector3.up * v) + (Vector3.right * h);
        mPlayerController.MoveVector3 = moveVector;
    }

}
