namespace Maple2.Trigger._02000403_bf {
    public static class _magic_05 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000035}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: false);
                context.SetMesh(arg1: new[] {1105}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new[] {1205}, arg2: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(arg1: new[] {205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {205})) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 715, arg2: "trigger", arg3: "Hauntedmansion");
                context.CreateMonster(arg1: new[] {145, 146, 147}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_05_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_b : TriggerState {
            internal StateEvent_05_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 147, arg2: "MS2PatrolData_2136");
                context.SetConversation(arg1: 1, arg2: 147, script: "$02000403_BF__MAGIC_05__0$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 145, script: "$02000403_BF__MAGIC_05__1$", arg4: 3, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 146, script: "$02000403_BF__MAGIC_05__2$", arg4: 3, arg5: 5);
                context.SetConversation(arg1: 1, arg2: 147, script: "$02000403_BF__MAGIC_05__3$", arg4: 3, arg5: 6);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_05_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_c : TriggerState {
            internal StateEvent_05_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {148}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEvent_05_d(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_d : TriggerState {
            internal StateEvent_05_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 148, arg2: "MS2PatrolData_2137");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_05_e(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_e : TriggerState {
            internal StateEvent_05_e(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {145, 146, 147});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_05_f(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_05_f : TriggerState {
            internal StateEvent_05_f(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {148});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}