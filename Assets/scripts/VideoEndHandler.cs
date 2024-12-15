using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Video Playerをアタッチ
    public string nextSceneName;   // 次のシーン名をInspectorで指定

    void Start()
    {
        // 再生終了時のイベントにメソッドを登録
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // 動画終了時に呼ばれるメソッド
    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName); // 次のシーンに移動
    }
}
