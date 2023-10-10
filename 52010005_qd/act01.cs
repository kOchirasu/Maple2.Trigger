namespace Maple2.Trigger._52010005_qd {
    public static class _act01 {
        public class StateQuest조건01 : TriggerState {
            internal StateQuest조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetInteractObject(interactIds: new []{10000872}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002820}, questStates: new byte[]{2})) {
                    return new StateQ1_마샤르교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르교체01 : TriggerState {
            internal StateQ1_마샤르교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateQ1_Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_Delay01 : TriggerState {
            internal StateQ1_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateQ1_미카Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_미카Spawn : TriggerState {
            internal StateQ1_미카Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2010");
            }

            public override TriggerState? Execute() {
                return new StateQ1_마샤르이동01(context);
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르이동01 : TriggerState {
            internal StateQ1_마샤르이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1020");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8001, spawnIds: new []{102})) {
                    return new StateQ1_마샤르대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르대화01 : TriggerState {
            internal StateQ1_마샤르대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$52010005_QD__ACT01__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8002, spawnIds: new []{102})) {
                    return new StateQ1_마샤르대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르대화02 : TriggerState {
            internal StateQ1_마샤르대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 3);
                context.SetConversation(type: 1, spawnId: 102, script: "$52010005_QD__ACT01__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateQ1_CameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_CameraCinematic01 : TriggerState {
            internal StateQ1_CameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 3);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.CameraSelect(triggerId: 1001, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateQ1_CameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_CameraCinematic02 : TriggerState {
            internal StateQ1_CameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 5);
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010005_QD__ACT01__2$", arg4: 4);
                context.SetSkip(state: new StateQ1_CameraCinematic03(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateQ1_CameraCinematic03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ1_CameraCinematic03 : TriggerState {
            internal StateQ1_CameraCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "7", seconds: 1);
                context.CameraSelect(triggerId: 1001, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new StateQ1_마샤르교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르교체02 : TriggerState {
            internal StateQ1_마샤르교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002821}, questStates: new byte[]{2})) {
                    return new StateQ1_Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQ1_Exit : TriggerState {
            internal StateQ1_Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103, 202});
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
