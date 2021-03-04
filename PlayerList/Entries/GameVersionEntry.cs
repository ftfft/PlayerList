﻿using System.Linq;
using UnityEngine;

namespace PlayerList.Entries
{
    class GameVersionEntry : EntryBase
    {
        public static int buildNumber = Resources.FindObjectsOfTypeAll<VRCApplicationSetup>().First().field_Public_Int32_0;

        public override void ProcessText(object[] parameters = null) => ChangeEntry("gameversion", buildNumber);
    }
}