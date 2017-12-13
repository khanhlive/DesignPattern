using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Builder
{
    public interface IRobotBuilder
    {
        void AddStart();
        void AddGetParts();
        void AddAssemble();
        void AddTest();
        void AddStop();
        RobotBuildable GetRobot();
    }
}
