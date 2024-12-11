using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // �O�i�̑��x
    private bool isMoving = true; // �O�i�����ǂ���
    private Vector3 moveDirection = Vector3.forward; // �ړ�����
    [SerializeField]
    [Tooltip("�����h�A�̃A�j���[�^�[")]
    private Animator automaticDoorAnimator;
    [SerializeField]
    private Animator automaticDoorAnimator_green;
    [SerializeField]
    private Animator automaticDoorAnimator_blue;
    [SerializeField]
    private Animator automaticDoorAnimator_pink;

    public float fallThreshold = -10f; // �V�[���J�ڂ��鍂����臒l
    public string gameover = "GameOver_fall"; // �J�ڂ���V�[����

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        }

        // �v���C���[�̍������`�F�b�N
        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadScene(gameover); // �V�[����J��
        }
    }

    // �v���C���[���~������
    public void Stop()
    {
        isMoving = false;
    }

    public void MoveGo() // �܂������i��
    {
        automaticDoorAnimator.SetBool("Open", true);
        UpdateMoveDirection(); // �ړ��������X�V
        isMoving = true;
    }

    // �������Ɉړ����J�n
    public void MoveLeft()
    {
        RotatePlayer(-90f); // ���ɉ�]
        UpdateMoveDirection(); // �ړ��������X�V
        isMoving = true;
    }

    // �E�����Ɉړ����J�n
    public void MoveRight()
    {
        RotatePlayer(90f); // �E�ɉ�]
        UpdateMoveDirection(); // �ړ��������X�V
        isMoving = true;
    }

    public void MoveGo_Door() // �܂������i��
    {
        automaticDoorAnimator_pink.SetBool("Open2", true);
        UpdateMoveDirection(); // �ړ��������X�V
        isMoving = true;
    }

    public void MoveLeft_Door()
    {
        automaticDoorAnimator_green.SetBool("Open3", true);
        RotatePlayer(-90f); // ���ɉ�]
        UpdateMoveDirection(); // �ړ��������X�V
        isMoving = true;
    }

    public void MoveRight_Door()
    {
        automaticDoorAnimator_blue.SetBool("Open", true);
        RotatePlayer(90f); // �E�ɉ�]
        UpdateMoveDirection(); // �ړ��������X�V
        isMoving = true;
    }

    public void MoveGo_last() // �܂������i��
    {
        UpdateMoveDirection(); // �ړ��������X�V
        isMoving = true;
    }

    // �v���C���[����]
    private void RotatePlayer(float angle)
    {
        transform.Rotate(0, angle, 0, Space.Self); // ���[�J����Ԃŉ�]
    }

    // �ړ����������݂̑O�������ɍX�V
    private void UpdateMoveDirection()
    {
        moveDirection = Vector3.forward; // ���[�J�����W�̑O���������ێ�
    }
}
