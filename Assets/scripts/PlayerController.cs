using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // 前進の速度
    private bool isMoving = true; // 前進中かどうか
    private Vector3 moveDirection = Vector3.forward; // 移動方向
    [SerializeField]
    [Tooltip("自動ドアのアニメーター")]
    private Animator automaticDoorAnimator;
    [SerializeField]
    private Animator automaticDoorAnimator_green;
    [SerializeField]
    private Animator automaticDoorAnimator_blue;
    [SerializeField]
    private Animator automaticDoorAnimator_pink;

    public float fallThreshold = -10f; // シーン遷移する高さの閾値
    public string gameover = "GameOver_fall"; // 遷移するシーン名

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        }

        // プレイヤーの高さをチェック
        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadScene(gameover); // シーンを遷移
        }
    }

    // プレイヤーを停止させる
    public void Stop()
    {
        isMoving = false;
    }

    public void MoveGo() // まっすぐ進む
    {
        automaticDoorAnimator.SetBool("Open", true);
        UpdateMoveDirection(); // 移動方向を更新
        isMoving = true;
    }

    // 左方向に移動を開始
    public void MoveLeft()
    {
        RotatePlayer(-90f); // 左に回転
        UpdateMoveDirection(); // 移動方向を更新
        isMoving = true;
    }

    // 右方向に移動を開始
    public void MoveRight()
    {
        RotatePlayer(90f); // 右に回転
        UpdateMoveDirection(); // 移動方向を更新
        isMoving = true;
    }

    public void MoveGo_Door() // まっすぐ進む
    {
        automaticDoorAnimator_pink.SetBool("Open2", true);
        UpdateMoveDirection(); // 移動方向を更新
        isMoving = true;
    }

    public void MoveLeft_Door()
    {
        automaticDoorAnimator_green.SetBool("Open3", true);
        RotatePlayer(-90f); // 左に回転
        UpdateMoveDirection(); // 移動方向を更新
        isMoving = true;
    }

    public void MoveRight_Door()
    {
        automaticDoorAnimator_blue.SetBool("Open", true);
        RotatePlayer(90f); // 右に回転
        UpdateMoveDirection(); // 移動方向を更新
        isMoving = true;
    }

    public void MoveGo_last() // まっすぐ進む
    {
        UpdateMoveDirection(); // 移動方向を更新
        isMoving = true;
    }

    // プレイヤーを回転
    private void RotatePlayer(float angle)
    {
        transform.Rotate(0, angle, 0, Space.Self); // ローカル空間で回転
    }

    // 移動方向を現在の前方方向に更新
    private void UpdateMoveDirection()
    {
        moveDirection = Vector3.forward; // ローカル座標の前方方向を維持
    }
}
