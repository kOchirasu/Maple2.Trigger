namespace Maple2.Trigger._52000040_qd {
    public static class _main_02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {1})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {2})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003052}, arg3: new byte[] {3})) {
                    return new StateStart_05(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003052}, arg3: new byte[] {2})) {
                    return new StateStart_05(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003052}, arg3: new byte[] {1})) {
                    context.SetEffect(arg1: new[] {6002}, arg2: true);
                    context.CreateMonster(arg1: new[] {401}, arg2: false);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$52000040_QD__MAIN_02__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$52000040_QD__MAIN_02__1$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$52000040_QD__MAIN_02__2$", arg4: 2, arg5: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4001");
                    context.SetCinematicUI(arg1: 0);
                    context.SetCinematicUI(arg1: 2);
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {401})) {
                    return new StateNpc_exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_exit_01 : TriggerState {
            internal StateNpc_exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.DestroyMonster(arg1: new[] {401});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "FollowingLaoz");
                context.CreateMonster(arg1: new[] {501}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003053}, arg3: new byte[] {1})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {501});
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}