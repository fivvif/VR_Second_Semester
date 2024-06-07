using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float moveHorizontal = 0f;
        float moveVertical = 0f;
        float moveUpDown = 0f;

        // Обработка горизонтального движения
        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1f;
        }

        // Обработка вертикального движения
        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1f;
        }

        // Обработка движения вверх-вниз
        if (Input.GetKey(KeyCode.Q))
        {
            moveUpDown = -1f;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            moveUpDown = 1f;
        }

        Vector3 movement = new Vector3(moveHorizontal, moveUpDown, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
