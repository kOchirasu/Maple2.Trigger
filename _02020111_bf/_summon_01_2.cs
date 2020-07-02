using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _summon_01_2 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new State소환준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환준비 : TriggerState {
            internal State소환준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon") == 1) {
                    return new StateMonsterAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear : TriggerState {
            internal StateMonsterAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "Lapenta_Attack_Guide", value: 1);
                context.CreateMonster(arg1: new[] {115, 116, 117, 118});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMonsterAppear_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear_2 : TriggerState {
            internal StateMonsterAppear_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}