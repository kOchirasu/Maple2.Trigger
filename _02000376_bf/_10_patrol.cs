namespace Maple2.Trigger._02000376_bf {
    public static class _10_patrol {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PatrolStart", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PatrolStart") == 1) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNpcChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {100, 200});
                context.CreateMonster(arg1: new[] {101, 201}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9301, arg2: new[] {101})) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9302, arg2: new[] {101})) {
                    context.State = new StatePatrol02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9303, arg2: new[] {101})) {
                    context.State = new StatePatrol03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_103");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_203");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9304, arg2: new[] {101})) {
                    context.State = new StatePatrol04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol04 : TriggerState {
            internal StatePatrol04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_104");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_204");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9305, arg2: new[] {101})) {
                    context.State = new StatePatrol05Air(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol05Air : TriggerState {
            internal StatePatrol05Air(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000376_BF__10_PATROL__0$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_105");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_205");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNpcChange02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcChange02 : TriggerState {
            internal StateNpcChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {102, 202}, arg2: false);
                context.RemoveBalloonTalk(spawnPointId: 201);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "PatrolEnd", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}