using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private Vector2 movement;

    public GameObject bankScreen;
    public GameObject markerScreen;
    public GameObject comCenScreen;

    public bool canMove = true;

    private Vector3 baseScale;

    void Start()
    {
        baseScale = transform.localScale;
    }

    void Update()
    {
        if (canMove == false) return;

        var keyboard = Keyboard.current;

        float moveX = 0.0f;
        float moveY = 0.0f;

        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed) moveX -= 1.0f;
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed) moveX += 1.0f;
        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed) moveY += 1.0f;
        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed) moveY -= 1.0f;

        movement = new Vector2(moveX, moveY).normalized;

        transform.position += (Vector3)movement * moveSpeed;

        if (moveX < 0)
        {
            transform.localScale = new Vector3(-baseScale.x, baseScale.y, baseScale.z);
        }
        else if (moveX > 0)
        {
            transform.localScale = new Vector3(baseScale.x, baseScale.y, baseScale.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bank":
                OpenScreen(bankScreen);
                break;
            case "Marker":
                OpenScreen(markerScreen);
                break;
            case "ComCen":
                OpenScreen(comCenScreen);
                break;
        }
    }

    private void OpenScreen(GameObject screen)
    {
        if (screen == null) return;

        canMove = false;
        Time.timeScale = 0f;
        screen.SetActive(true);
    }

    public void CloseScreen(GameObject screen)
    {
        if (screen == null) return;

        screen.SetActive(false);
        Time.timeScale = 1f;
        canMove = true;
    }
}
