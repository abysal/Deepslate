﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConMaster.Bedrock.Enums
{
    [Flags]
    public enum AbilityFlag: uint
    {
        Build = 0x1,
        Mine = 0x2,
        DoorsAndSwitches = 0x4,
        OpenContainers = 0x8,//f
        AttackPlayers = 0x10,
        AttackMobs = 0x20,
        OperatorCommands = 0x40,
        Teleport = 0x80,//ff
        Invulnerable = 0x100,
        Flying = 0x200,
        MayFly = 0x400,
        InstantBuild = 0x800,//fff
        Lightning = 0x1000,
        FlySpeed = 0x2000,
        WalkSpeed = 0x4000,
        Muted = 0x8000,//ffff
        WorldBuilder = 0x10000,
        NoClip = 0x20000,
        PrivilegedBuilder = 0x40000,
        Count = 0x80000,
        All = 0xfffff
    }
}
