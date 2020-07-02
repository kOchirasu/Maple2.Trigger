namespace Maple2.Trigger._63000003_cs {
    public static class _50001475 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {50001475}, arg3: new byte[] {3})) {
                    return new State말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선01 : TriggerState {
            internal State말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$63000003_CS__50001475__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_A");
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}