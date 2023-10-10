namespace Maple2.Trigger._52010004_qd {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{10000, 10001, 10002, 10003}, visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetMesh(triggerIds: new []{7000, 7001, 7002, 7003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002800}, questStates: new byte[]{2})) {
                    return new State둔바교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바교체01 : TriggerState {
            internal State둔바교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetMesh(triggerIds: new []{7000, 7001, 7002, 7003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State둔바SetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바SetupCinematic01 : TriggerState {
            internal State둔바SetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.CameraSelect(triggerId: 601, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State둔바대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대화01 : TriggerState {
            internal State둔바대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 2);
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010004_QD__BATTLE01__0$", arg4: 2);
                context.SetSkip(state: new State둔바대화02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State둔바대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대화02Wait : TriggerState {
            internal State둔바대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State둔바대화02(context);
            }

            public override void OnExit() { }
        }

        private class State둔바대화02 : TriggerState {
            internal State둔바대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 2);
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010004_QD__BATTLE01__1$", arg4: 2);
                context.SetSkip(state: new State둔바대화03Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State둔바대화03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바대화03Wait : TriggerState {
            internal State둔바대화03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State둔바대화03(context);
            }

            public override void OnExit() { }
        }

        private class State둔바대화03 : TriggerState {
            internal State둔바대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 2);
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010004_QD__BATTLE01__2$", arg4: 2);
                context.SetSkip(state: new State둔바StopCinematic01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State둔바StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바StopCinematic01 : TriggerState {
            internal State둔바StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(timerId: "13", seconds: 1);
                context.CameraSelect(triggerId: 601, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new State전투Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare01 : TriggerState {
            internal State전투Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 1);
                context.SetAgent(triggerIds: new []{10000, 10001, 10002, 10003}, visible: true);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State전투중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010004, portalId: 50, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new State둔바교체Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바교체Wait02 : TriggerState {
            internal State둔바교체Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{7000, 7001, 7002, 7003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "30", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new State둔바교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바교체02 : TriggerState {
            internal State둔바교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
