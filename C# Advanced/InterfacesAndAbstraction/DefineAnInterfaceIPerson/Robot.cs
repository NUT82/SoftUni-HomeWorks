using PersonInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Robot : IRobot, IIdentifiable
    {
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public string Id { get ; set ; }
        public string Name { get ; set ; }
    }
}
