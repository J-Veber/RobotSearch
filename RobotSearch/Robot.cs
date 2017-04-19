using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSearch
{
    class Robot
    {
        public string RobotName;
        public string RobotMethodOfPiloting;
        public string RobotBobber;
        public string RobotDepth;
        public string RobotDiveMethod;
        public string RobotExitToWater;
        public string RobotCameras;
        public string RobotIllums;
        public string RobotConnectionWithSurface;
        public string RobotCapacity;
        public bool[] RobotSqlAtr;
        public int RobotFieldsNum;

        public Robot(string robotMethodOfPiloting, string robotBobber, string robotDepth,
            string robotDiveMethod, string robotExitToWater, 
            string robotCameras, string robotIllums, string robotConnectionWithSurface, string robotCapacity)
        {
            RobotMethodOfPiloting = robotMethodOfPiloting;
            RobotBobber = robotBobber;
            RobotDepth = robotDepth;
            RobotDiveMethod = robotDiveMethod;
            RobotExitToWater = robotExitToWater;
            RobotCameras = robotCameras;
            RobotIllums = robotIllums;
            RobotConnectionWithSurface = robotConnectionWithSurface;
            RobotCapacity = robotCapacity;
            RobotSqlAtr = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                RobotSqlAtr[i] = true;
            }
            RobotFieldsNum = 0;
        }

        public Robot()
        {
            RobotMethodOfPiloting = "";
            RobotBobber = "";
            RobotDepth = "";
            RobotDiveMethod = "";
            RobotExitToWater = "";
            RobotCameras = "";
            RobotIllums = "";
            RobotConnectionWithSurface = "";
            RobotCapacity = "";
        }

        public void CheckParameters()
        {
            if (this.RobotMethodOfPiloting.Equals(""))
                RobotSqlAtr[0] = false;
            else RobotFieldsNum++;
            if (this.RobotBobber.Equals(""))
                RobotSqlAtr[1] = false;
            else RobotFieldsNum++;
            if (this.RobotDepth.Equals(""))
                RobotSqlAtr[2] = false;
            else RobotFieldsNum++;
            if (this.RobotDiveMethod.Equals(""))
                RobotSqlAtr[3] = false;
            else RobotFieldsNum++;
            if (this.RobotExitToWater.Equals(""))
                RobotSqlAtr[4] = false;
            else RobotFieldsNum++;
            if (this.RobotCameras.Equals("-1"))
                RobotSqlAtr[5] = false;
            else RobotFieldsNum++;
            if (this.RobotIllums.Equals(""))
                RobotSqlAtr[6] = false;
            else RobotFieldsNum++;
            if (this.RobotConnectionWithSurface.Equals(""))
                RobotSqlAtr[7] = false;
            else RobotFieldsNum++;
            if (this.RobotCapacity.Equals("-1"))
                RobotSqlAtr[8] = false;
            else RobotFieldsNum++;
        }
    }
}
