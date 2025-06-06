using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_07 : MonoBehaviour
{
    public float speed = 0f;
    public float maxSpeed = 2f;
    public Text s_text;
    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver && speed <= maxSpeed)
        {
            speed += 0.001f;
        }
        else if (isGameOver && speed > 0f)
        {
            speed = 0f; // �Q�[���I�[�o�[���͑��x��0�ɂ���
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0f, -90f, 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0f, 90f, 0);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Oni")
        {
            isGameOver = true; // �Q�[���I�[�o�[��Ԃɂ���
            speed = 0f; // �v���C���[�̑��x��0�ɂ���
            s_text.text = "Game Over";
        }
    }
}
