using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.Main;
using NKHook6.Api.Events;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;
using NKHook6.Api.Utilities;
using Assets.Scripts.Unity;

using NKHook6.Api.Enums;

using static NKHook6.Api.Events._Towers.TowerEvents;
using Assets.Scripts.Simulation.Towers;

using static NKHook6.Api.Events._Weapons.WeaponEvents;
using Assets.Scripts.Utils;

using static NKHook6.Api.Events._TimeManager.TimeManagerEvents;
using Il2CppSystem.Collections;
using NKHook6.Api.Events._Bloons;

namespace speedhackmelon
{
    public class Main : MelonMod
    {

        public static int speed = 3;

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            EventRegistry.subscriber.register(this.GetType());
            Logger.Log("speed mod loaded");
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            TimeManager.compromisedFastFowardRate = speed;
            TimeManager.maxSimulationStepsPerUpdate = speed;

        }



        [EventAttribute("KeyPressEvent")]
        public static void onEvent(KeyEvent e)
        {

            string key = e.key + "";

            if (key == "Alpha6")
            {
                speed = 3;
                Logger.Log("speed = 3");
            }
            if (key == "Alpha7")
            {
                speed = 10;
                Logger.Log("speed = 10");
            }
            if (key == "Alpha8")
            {
                speed = 50;
                Logger.Log("speed = 50");
            }
            if (key == "Alpha9")
            {
                speed = 100;
                Logger.Log("speed = 100");
            }



        }




    }

}