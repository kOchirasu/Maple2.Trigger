namespace Maple2.Trigger._52010008_qd {
    public static class _catchjailbreaker01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 902, 903, 904, 905, 906}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000851}, state: 0);
                context.SetMesh(triggerIds: new []{6000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State전투안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투안내01 : TriggerState {
            internal State전투안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 100, textId: 40010);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906})) {
                    return new State죄수찾기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죄수찾기01 : TriggerState {
            internal State죄수찾기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 100);
                context.SetInteractObject(interactIds: new []{10000851}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000851}, arg2: 0)) {
                    return new State죄수Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죄수Spawn01 : TriggerState {
            internal State죄수Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "11", seconds: 1);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1010");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State죄수Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State죄수Spawn02 : TriggerState {
            internal State죄수Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 2);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2010");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State벨마Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마Spawn01 : TriggerState {
            internal State벨마Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 1);
                context.CreateMonster(spawnIds: new []{301}, arg2: false);
                context.CameraSelect(triggerId: 601, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State벨마대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마대화01 : TriggerState {
            internal State벨마대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "21", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11000521, script: "$52010008_QD__CATCHJAILBREAKER01__0$", arg4: 3);
                context.SetSkip(state: new State벨마대화02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new State벨마대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마대화02Wait : TriggerState {
            internal State벨마대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State벨마대화02(context);
            }

            public override void OnExit() { }
        }

        private class State벨마대화02 : TriggerState {
            internal State벨마대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11000521, script: "$52010008_QD__CATCHJAILBREAKER01__1$", arg4: 3);
                context.SetSkip(state: new State벨마대화03Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new State벨마대화03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마대화03Wait : TriggerState {
            internal State벨마대화03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State벨마대화03(context);
            }

            public override void OnExit() { }
        }

        private class State벨마대화03 : TriggerState {
            internal State벨마대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "23", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11000521, script: "$52010008_QD__CATCHJAILBREAKER01__2$", arg4: 3);
                context.SetSkip(state: new State벨마StopCinematic01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "23")) {
                    return new State벨마StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨마StopCinematic01 : TriggerState {
            internal State벨마StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(timerId: "30", seconds: 1);
                context.CameraSelect(triggerId: 601, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "catchjailbreaker");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new State유저이동Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동Prepare : TriggerState {
            internal State유저이동Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new State유저이동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동시작 : TriggerState {
            internal State유저이동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02010019, portalId: 2, boxId: 9000);
                context.DestroyMonster(spawnIds: new []{101, 201, 301, 901, 902, 903, 904, 905, 906});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
