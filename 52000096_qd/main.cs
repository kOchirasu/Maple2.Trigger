namespace Maple2.Trigger._52000096_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001514}, questStates: new byte[]{1})) {
                    return new State몹소환01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50100040}, questStates: new byte[]{1})) {
                    return new State몹소환01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹소환01 : TriggerState {
            internal State몹소환01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 1001, script: "$52000096_QD__MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 1002, script: "$52000096_QD__MAIN__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 1003, script: "$52000096_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 1004, script: "$52000096_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000096_QD__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 1003, script: "$52000096_QD__MAIN__5$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_01");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004}, arg2: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
