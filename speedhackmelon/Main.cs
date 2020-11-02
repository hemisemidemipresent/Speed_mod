using MelonLoader;
using NKHook6;
using NKHook6.Api.Events;
using Assets.Scripts.Utils;

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
