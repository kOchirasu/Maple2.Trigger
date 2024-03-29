using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _light_on {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Light_On_1") == 2 && context.GetUserValue(key: "Light_On_2") == 2 && context.GetUserValue(key: "Light_On_3") == 2 && context.GetUserValue(key: "Light_On_4") == 2) {
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "Light_On_1") == 1 && context.GetUserValue(key: "Light_On_2") == 1 && context.GetUserValue(key: "Light_On_3") == 1 && context.GetUserValue(key: "Light_On_4") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State라이트_변경(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라이트_변경 : TriggerState {
            internal State라이트_변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Light_On_1") == 1 && context.GetUserValue(key: "Light_On_2") == 1 && context.GetUserValue(key: "Light_On_3") == 1 && context.GetUserValue(key: "Light_On_4") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
