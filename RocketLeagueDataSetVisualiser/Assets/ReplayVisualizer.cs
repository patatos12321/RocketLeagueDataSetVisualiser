using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayVisualizer : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Ball;
    public string ReplayFile;

    List<Frame> frames = new List<Frame>();
    int frameNumber = 0;

    // Use this for initialization
    void Start () {
        Debug.Log("ReplayFile");
        frames = Frame.GetListFrameFromDataSet(ReplayFile);
    }
    
	
	// Update is called once per frame
	void Update () {
        Frame frame = frames[frameNumber];

        //I have ot switch the Y and the X
        Vector3 positionPlayer1 = new Vector3(frame.PlayerY, frame.PlayerX, 0);
        Player1.transform.position = positionPlayer1;

        Vector3 positionPlayer2 = new Vector3(frame.EnemyPlayerY, frame.EnemyPlayerX, 0);
        Player2.transform.position = positionPlayer2;

        Vector3 positionBall = new Vector3(frame.BallY, frame.BallX, 0);
        Ball.transform.position = positionBall;
        
        if (frameNumber < frames.Count)
        {
            frameNumber++;
        }
    }
}
