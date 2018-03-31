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
    public int EnemyPlayerX;
    public int EnemyPlayerY;
    public int Label;

    public static List<Frame> GetListFrameFromDataSet(string dataSetFile)
    {
        //File format
        //BallX,BallY,BallVelocityX,BallVelocityY,PlayerX,PlayerY,EnemyPlayerX,EnemyPlayerY,Label
        Debug.Log("File.ReadAllLines(" + dataSetFile);
        string[] dataSetLines = File.ReadAllLines(dataSetFile);
        List<Frame> frames = new List<Frame>();

        foreach (string dataSetLine in dataSetLines)
        {
            Debug.Log(dataSetLine);
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
                    EnemyPlayerX = int.Parse(arrayDataSetLine[6]),
                    EnemyPlayerY = int.Parse(arrayDataSetLine[7]),
                    Label = int.Parse(arrayDataSetLine[8]),
                };

                frames.Add(currentFrame);
            }
            catch
            {

            }
        }
        return frames;
    }
}
