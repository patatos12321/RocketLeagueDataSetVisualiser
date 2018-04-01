using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Frame
{
    public int BallX;
    public int BallY;
    public int BallVelocityX;
    public int BallVelocityY;
    public int PlayerX;
    public int PlayerY;
    public float PlayerRotationX;
    public float PlayerRotationY;
    public float PlayerRotationZ;
    public int EnemyPlayerX;
    public int EnemyPlayerY;
    public float EnemyPlayerRotationX;
    public float EnemyPlayerRotationY;
    public float EnemyPlayerRotationZ;
    public int Label;

    public static List<Frame> GetListFrameFromDataSet(string dataSetFile)
    {
        //File format
        //BallX,BallY,BallVelocityX,BallVelocityY,PlayerX,PlayerY,PlayerRotationX,PlayerRotationY,EnemyPlayerX,EnemyPlayerY,EnemyPlayerRotationX,EnemyPlayerRotationY,Label
        Debug.Log("File.ReadAllLines(" + dataSetFile);
        string[] dataSetLines = File.ReadAllLines(dataSetFile);
        List<Frame> frames = new List<Frame>();

        foreach (string dataSetLine in dataSetLines)
        { 
            string[] arrayDataSetLine = dataSetLine.Split(',');
            try
            {
                Frame currentFrame = new Frame()
                {
                    BallX = int.Parse(arrayDataSetLine[0]),
                    BallY = int.Parse(arrayDataSetLine[1]),
                    BallVelocityX = int.Parse(arrayDataSetLine[2]),
                    BallVelocityY = int.Parse(arrayDataSetLine[3]),
                    PlayerX = int.Parse(arrayDataSetLine[4]),
                    PlayerY = int.Parse(arrayDataSetLine[5]),
                    PlayerRotationX = float.Parse(arrayDataSetLine[6]),
                    PlayerRotationY = float.Parse(arrayDataSetLine[7]),
                    PlayerRotationZ = float.Parse(arrayDataSetLine[8]),
                    EnemyPlayerX = int.Parse(arrayDataSetLine[9]),
                    EnemyPlayerY = int.Parse(arrayDataSetLine[10]),
                    EnemyPlayerRotationX = float.Parse(arrayDataSetLine[11]),
                    EnemyPlayerRotationY = float.Parse(arrayDataSetLine[12]),
                    EnemyPlayerRotationZ = float.Parse(arrayDataSetLine[13]),
                    Label = int.Parse(arrayDataSetLine[14]),
                };

                frames.Add(currentFrame);
            }
            catch
            {
                Debug.Log(dataSetLine);
            }
        }
        return frames;
    }
}
