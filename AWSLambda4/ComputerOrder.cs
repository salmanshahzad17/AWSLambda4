using System;
using System.Collections.Generic;
using System.Text;

namespace AWSLambda4
{
    public class ComputerOrder
    {
        public ComputerTypes? ComputerType { get; set; }
        public string ComputerDescription { get; set; }
        public string PickTime { get; set; }
        public string PickDate { get; set; }
    }
    public enum ComputerTypes
    {
        Desktop,
        MiniTower,
        Tower,
        Null
    }
}
