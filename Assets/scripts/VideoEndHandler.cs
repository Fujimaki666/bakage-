using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Video Player���A�^�b�`
    public string nextSceneName;   // ���̃V�[������Inspector�Ŏw��

    void Start()
    {
        // �Đ��I�����̃C�x���g�Ƀ��\�b�h��o�^
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // ����I�����ɌĂ΂�郁�\�b�h
    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName); // ���̃V�[���Ɉړ�
    }
}
