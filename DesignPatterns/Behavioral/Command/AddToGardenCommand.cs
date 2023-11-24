﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Command
{
    internal class AddToGardenCommand : GardenCommand
    {
        public AddToGardenCommand(Garden receiver, string plantName) : base(receiver, plantName)
        {
        }

        public override bool Execute()
        {
            return Receiver.Add(PlantName);
        }

        public override void Reverse()
        {
            Receiver.Remove(PlantName);
        }
    }
}
