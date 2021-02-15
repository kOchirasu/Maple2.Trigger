namespace Maple2.Trigger._52000096_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001514}, arg3: new byte[] {1})) {
                    return new State몹소환01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50100040}, arg3: new byte[] {1})) {
                    return new State몹소환01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹소환01 : TriggerState {
            internal State몹소환01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State위협당함01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위협당함01 : TriggerState {
            internal State위협당함01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52000096_QD__MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State위협당함02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위협당함02 : TriggerState {
            internal State위협당함02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$52000096_QD__MAIN__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State위협당함03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위협당함03 : TriggerState {
            internal State위협당함03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52000096_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State위협당함04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위협당함04 : TriggerState {
            internal State위협당함04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$52000096_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State시점이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시점이동 : TriggerState {
            internal State시점이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State경로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경로이동 : TriggerState {
            internal State경로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000096_QD__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State몹말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹말풍선01 : TriggerState {
            internal State몹말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52000096_QD__MAIN__5$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC_01");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonster재Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster재Spawn : TriggerState {
            internal StateMonster재Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004}, arg2: true);
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