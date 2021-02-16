namespace Maple2.Trigger._80000008_bonus {
    public static class _trigger_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {801, 802, 803, 804, 805, 806, 807, 808, 809, 810}, arg2: false);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000212}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000212}, arg2: 0)) {
                    return new State소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_301");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 401, arg2: new[] {105})) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105});
                context.SetTimer(id: "5", arg2: 1);
                context.SetTimer(id: "6", arg2: 1, arg3: true);
                context.SetEffect(arg1: new[] {801, 802, 803, 804, 805, 806, 807, 808, 809, 810}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State꽝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽝 : TriggerState {
            internal State꽝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105});
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000208, 10000209, 10000210, 10000211, 10000212}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}