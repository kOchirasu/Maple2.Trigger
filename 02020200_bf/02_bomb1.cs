namespace Maple2.Trigger._02020200_bf {
    public static class _02_bomb1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {111})) {
                    return new State폭탄_터짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭탄_터짐 : TriggerState {
            internal State폭탄_터짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    return new StateEnd(context);
                }

                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 40000)) {
                    context.SetMesh(arg1: new[] {2001}, arg2: true, arg5: 3f);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111});
                context.SetMesh(arg1: new[] {2001}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}