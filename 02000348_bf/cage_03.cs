namespace Maple2.Trigger._02000348_bf {
    public static class _cage_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2103}, arg2: false, arg3: 0, arg4: 10);
                context.SetEffect(arg1: new[] {8003}, arg2: false);
                context.SetActor(arg1: 2203, arg2: false, arg3: "Sit_Ground_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "cage_03") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2103}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {8003}, arg2: true);
                context.SetActor(arg1: 2203, arg2: true, arg3: "Sit_Ground_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {213})) {
                    return new StateNpc(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc : TriggerState {
            internal StateNpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8003}, arg2: false);
                context.SetMesh(arg1: new[] {2103}, arg2: false, arg3: 0, arg4: 10);
                context.SetActor(arg1: 2203, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {223}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {223});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}