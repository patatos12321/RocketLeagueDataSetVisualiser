using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Frame
{
    public int BallX;
    public int BallY;
    public int BallZ;
    public int BallVelocityX;
    public int BallVelocityY;
    public int BallVelocityZ;
    public int PlayerX;
    public int PlayerY;
    public int PlayerZ;
    public float PlayerRotationX;
    public float PlayerRotationY;
    public float PlayerRotationZ;
    public int EnemyPlayerX;
    public int EnemyPlayerY;
    public int EnemyPlayerZ;
    public float EnemyPlayerRotationX;
    public float EnemyPlayerRotationY;
    public float EnemyPlayerRotationZ;
    public int Label;

    public static List<Frame> GetListFrameFromDataSet(string dataSetFile)
    {
        //File format
        //BallX,BallY,BallZ,BallVelocityX,BallVelocityY,BallVelocityZ,PlayerX,PlayerY,PlayerZ,PlayerRotationX,PlayerRotationY,PlayerRotationZ,EnemyPlayerX,EnemyPlayerY,EnemyPlayerZ,EnemyPlayerRotationX,EnemyPlayerRotationY,EnemyPlayerRotatioZ,Label
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
                    BallZ = int.Parse(arrayDataSetLine[2]),
                    BallVelocityX = int.Parse(arrayDataSetLine[3]),
                    BallVelocityY = int.Parse(arrayDataSetLine[4]),
                    BallVelocityZ = int.Parse(arrayDataSetLine[5]),
                    PlayerX = int.Parse(arrayDataSetLine[6]),
                    PlayerY = int.Parse(arrayDataSetLine[7]),
                    PlayerZ = int.Parse(arrayDataSetLine[8]),
                    PlayerRotationX = float.Parse(arrayDataSetLine[9]),
                    PlayerRotationY = float.Parse(arrayDataSetLine[10]),
                    PlayerRotationZ = float.Parse(arrayDataSetLine[11]),
                    EnemyPlayerX = int.Parse(arrayDataSetLine[12]),
                    EnemyPlayerY = int.Parse(arrayDataSetLine[13]),
                    EnemyPlayerZ = int.Parse(arrayDataSetLine[14]),
                    EnemyPlayerRotationX = float.Parse(arrayDataSetLine[15]),
                    EnemyPlayerRotationY = float.Parse(arrayDataSetLine[16]),
                    EnemyPlayerRotationZ = float.Parse(arrayDataSetLine[17]),
                    Label = int.Parse(arrayDataSetLine[18]),
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
