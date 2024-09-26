﻿using System;
using System.Collections.Generic;
using System.Text;
using TheGorillaWatch.Models;
using UnityEngine;

namespace TheGorillaWatch.Mods
{
    class HighGravity : Page
    {
        public override string modName => "9) HighGravity";

        bool isHighGravity;

        public override void Enable()
        {
            base.Enable();
            Physics.gravity = new Vector3(0, -14f, 0);
        }

        public override void Disable()
        {
            base.Disable();
            Physics.gravity = new Vector3(0, -9.807f, 0);
        }
    }
}
