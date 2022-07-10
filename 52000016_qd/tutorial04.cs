namespace Maple2.Trigger._52000016_qd {
    public static class _tutorial04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{10000, 10001, 10002, 10003, 10004, 10005, 10010, 10006, 10007, 10008, 10009}, visible: true);
                context.SetEffect(triggerIds: new []{6000, 7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7010, 7020, 7011, 7021, 7030, 7040, 7050}, visible: false);
                context.SetSkill(triggerIds: new []{910, 911, 912, 913, 914}, arg2: false);
                context.SetMesh(triggerIds: new []{2000, 3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000825}, state: 0);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{8200, 8300, 8201, 8301, 8202, 8302, 8203, 8303, 8000, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6200, 6201, 6202, 6203, 6210, 6211, 6212, 6300, 6301, 6302, 6400, 6401, 6402}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000417}, questStates: new byte[]{1})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetRandomMesh(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015}, visible: true, meshCount: 16, arg4: 50, delay: 80);
            }

            public override TriggerState? Execute() {
                return new State막힌길발견01(context);
            }

            public override void OnExit() { }
        }

        private class State막힌길발견01 : TriggerState {
            internal State막힌길발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: true);
            }

            public override TriggerState? Execute() {
                return new StateDelay02(context);
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{910, 911, 912, 913, 914}, arg2: true);
                context.SetEffect(triggerIds: new []{7010, 7020}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State막힌길발견02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State막힌길발견02 : TriggerState {
            internal State막힌길발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 4);
                context.SetEffect(triggerIds: new []{7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State척후병입장(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{2000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State척후병입장 : TriggerState {
            internal State척후병입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1000");
                context.SetEffect(triggerIds: new []{6100}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001249, script: "$52000016_QD__TUTORIAL04__0$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State돌치우기안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌치우기안내01 : TriggerState {
            internal State돌치우기안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 3);
                context.SetEffect(triggerIds: new []{6101}, visible: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1001");
                context.SetConversation(type: 2, spawnId: 11001249, script: "$52000016_QD__TUTORIAL04__1$", arg4: 3);
                context.SetSkip(state: new State돌치우기안내03(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State돌치우기안내03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetEffect(triggerIds: new []{7010, 7020}, visible: false);
                context.SetSkill(triggerIds: new []{910, 911, 912, 913, 914}, arg2: false);
            }
        }

        private class State돌치우기안내03 : TriggerState {
            internal State돌치우기안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new State첫번째돌들기Guide01(context);
            }

            public override void OnExit() { }
        }

        private class State첫번째돌들기Guide01 : TriggerState {
            internal State첫번째돌들기Guide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.ShowGuideSummary(entityId: 10014010, textId: 10014010);
            }

            public override TriggerState? Execute() {
                if (!context.DetectLiftableObject(boxIds: new []{9001}, itemId: 30000440)) {
                    return new State첫번째돌놓기01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10014010);
            }
        }

        private class State첫번째돌놓기01 : TriggerState {
            internal State첫번째돌놓기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.ShowGuideSummary(entityId: 10014020, textId: 10014020);
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{9011, 9012}, itemId: 30000440)) {
                    return new State척후병이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State척후병이동01 : TriggerState {
            internal State척후병이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10014020);
                context.CreateMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907}, arg2: false);
                context.SetRandomMesh(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015}, visible: false, meshCount: 16, arg4: 100, delay: 80);
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9004, spawnIds: new []{101})) {
                    return new State척후병이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State척후병이동02 : TriggerState {
            internal State척후병이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52000016_QD__TUTORIAL04__2$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9005, spawnIds: new []{101})) {
                    return new State척후병전투시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State척후병전투시작01 : TriggerState {
            internal State척후병전투시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "9", seconds: 1);
                context.SetAgent(triggerIds: new []{10000, 10001, 10002, 10003, 10004, 10005, 10010}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new State전투중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 2);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000016_QD__TUTORIAL04__3$", arg4: 2);
                context.SetEffect(triggerIds: new []{6102}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State전투중02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중02 : TriggerState {
            internal State전투중02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52000016_QD__TUTORIAL04__4$", arg4: 2);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.ShowGuideSummary(entityId: 10014030, textId: 10014030);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907})) {
                    return new State전투종료01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10014030);
            }
        }

        private class State전투종료01 : TriggerState {
            internal State전투종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 2);
                context.SetEffect(triggerIds: new []{6103}, visible: true);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000016_QD__TUTORIAL04__5$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State전투종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료02 : TriggerState {
            internal State전투종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 2);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000016_QD__TUTORIAL04__6$", arg4: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State다리로이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리로이동01 : TriggerState {
            internal State다리로이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9006, spawnIds: new []{101})) {
                    return new StateSetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic01 : TriggerState {
            internal StateSetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 3);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 602, enable: true);
                context.SetConversation(type: 2, spawnId: 11001249, script: "$52000016_QD__TUTORIAL04__7$", arg4: 3);
                context.SetEffect(triggerIds: new []{6104}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new StateSetupCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic02 : TriggerState {
            internal StateSetupCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 2);
                context.SetConversation(type: 2, spawnId: 11001249, script: "$52000016_QD__TUTORIAL04__8$", arg4: 2);
                context.SetEffect(triggerIds: new []{6105}, visible: true);
                context.CreateMonster(spawnIds: new []{201, 301, 210, 211, 212, 213, 214, 215, 216, 217, 310, 311, 312, 313}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new StateStartCinematic01Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic01Wait : TriggerState {
            internal StateStartCinematic01Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateStartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic01 : TriggerState {
            internal StateStartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateStopCinematic01_skip(context), arg2: "nextState");
                context.SetTimer(timerId: "16", seconds: 1);
                context.CameraSelectPath(pathIds: new []{602, 603}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "16")) {
                    return new State대결Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic01 : TriggerState {
            internal State대결Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "18", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000016_QD__TUTORIAL04__9$", arg4: 3);
                context.SetEffect(triggerIds: new []{6200}, visible: true);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.SetSkip(state: new State대결Cinematic02Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "18")) {
                    return new State대결Cinematic02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic02Wait : TriggerState {
            internal State대결Cinematic02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State대결Cinematic02(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic02 : TriggerState {
            internal State대결Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "19", seconds: 7);
                context.SetConversation(type: 2, spawnId: 11001231, script: "$52000016_QD__TUTORIAL04__10$", arg4: 6);
                context.SetEffect(triggerIds: new []{6200}, visible: false);
                context.SetEffect(triggerIds: new []{6210}, visible: true);
                context.SetSkip(state: new State대결Cinematic03Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "19")) {
                    return new State대결Cinematic03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic03Wait : TriggerState {
            internal State대결Cinematic03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State대결Cinematic03(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic03 : TriggerState {
            internal State대결Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000016_QD__TUTORIAL04__11$", arg4: 4);
                context.SetEffect(triggerIds: new []{6210}, visible: false);
                context.SetEffect(triggerIds: new []{6201}, visible: true);
                context.SetSkip(state: new State대결Cinematic04Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State대결Cinematic04Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic04Wait : TriggerState {
            internal State대결Cinematic04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State대결Cinematic04(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic04 : TriggerState {
            internal State대결Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "21", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11001231, script: "$52000016_QD__TUTORIAL04__12$", arg4: 5);
                context.SetEffect(triggerIds: new []{6201}, visible: false);
                context.SetEffect(triggerIds: new []{6211}, visible: true);
                context.SetSkip(state: new State대결Cinematic05Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new State대결Cinematic05Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic05Wait : TriggerState {
            internal State대결Cinematic05Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State대결Cinematic05(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic05 : TriggerState {
            internal State대결Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000016_QD__TUTORIAL04__13$", arg4: 3);
                context.SetEffect(triggerIds: new []{6211}, visible: false);
                context.SetEffect(triggerIds: new []{6202}, visible: true);
                context.SetSkip(state: new State대결Cinematic06Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new State대결Cinematic06Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic06Wait : TriggerState {
            internal State대결Cinematic06Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State대결Cinematic06(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic06 : TriggerState {
            internal State대결Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "23", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001231, script: "$52000016_QD__TUTORIAL04__14$", arg4: 3);
                context.SetEffect(triggerIds: new []{6202}, visible: false);
                context.SetEffect(triggerIds: new []{6212}, visible: true);
                context.SetSkip(state: new State대결Cinematic07Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "23")) {
                    return new State대결Cinematic07Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic07Wait : TriggerState {
            internal State대결Cinematic07Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State대결Cinematic07(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic07 : TriggerState {
            internal State대결Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "24", seconds: 1);
                context.CameraSelect(triggerId: 606, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "24")) {
                    return new State대결Cinematic08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic08 : TriggerState {
            internal State대결Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "25", seconds: 1);
                context.SetEffect(triggerIds: new []{7050}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000016_QD__TUTORIAL04__15$", arg4: 2);
                context.SetEffect(triggerIds: new []{6212}, visible: false);
                context.SetEffect(triggerIds: new []{6203, 8200, 8300}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "25")) {
                    return new State이펙트Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Cinematic01 : TriggerState {
            internal State이펙트Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "26", seconds: 2);
                context.SetEffect(triggerIds: new []{8201, 8301}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "26")) {
                    return new State이펙트Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{8200, 8300}, visible: false);
            }
        }

        private class State이펙트Cinematic02 : TriggerState {
            internal State이펙트Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "27", seconds: 1);
                context.SetEffect(triggerIds: new []{8201, 8301}, visible: false);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2100");
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_3100");
                context.SetEffect(triggerIds: new []{8203, 8303}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "27")) {
                    return new State이펙트Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Cinematic03 : TriggerState {
            internal State이펙트Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "28", seconds: 1);
                context.SetEffect(triggerIds: new []{8202, 8302}, visible: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "28")) {
                    return new StateStopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic01 : TriggerState {
            internal StateStopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 1);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 606, enable: false);
                context.CameraSelect(triggerId: 602, enable: false);
                context.CameraSelect(triggerId: 603, enable: false);
                context.SetEffect(triggerIds: new []{8203, 8303, 8202, 8302}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new StateLeverPull01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7040, 7050, 8000}, visible: false);
            }
        }

        private class StateStopCinematic01_skip : TriggerState {
            internal StateStopCinematic01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.RemoveCinematicTalk();
                context.SetTimer(timerId: "30", seconds: 1);
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 606, enable: false);
                context.CameraSelect(triggerId: 602, enable: false);
                context.CameraSelect(triggerId: 603, enable: false);
                context.SetEffect(triggerIds: new []{8203, 8303, 8202, 8302}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new StateLeverPull01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7040, 7050, 8000}, visible: false);
            }
        }

        private class StateLeverPull01 : TriggerState {
            internal StateLeverPull01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 1);
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 605, enable: true);
                context.SetInteractObject(interactIds: new []{10000825}, state: 1);
                context.SetEffect(triggerIds: new []{7030}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new StateLeverPull02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverPull02 : TriggerState {
            internal StateLeverPull02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "35", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001249, script: "$52000016_QD__TUTORIAL04__16$", arg4: 3);
                context.SetEffect(triggerIds: new []{6106}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "35")) {
                    return new State다리만들기01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.ShowGuideSummary(entityId: 10014031, textId: 10014031);
            }
        }

        private class State다리만들기01 : TriggerState {
            internal State다리만들기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 605, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{301, 210, 211, 212, 213, 214, 215, 216, 217, 310, 311, 312, 313});
                context.CreateMonster(spawnIds: new []{220, 221, 222, 223, 224, 225, 226, 227}, arg2: true);
                context.SetEffect(triggerIds: new []{7030}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000825}, arg2: 0)) {
                    return new State다리만들기02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10014031);
            }
        }

        private class State다리만들기02 : TriggerState {
            internal State다리만들기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "40", seconds: 1);
                context.SetRandomMesh(triggerIds: new []{4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027}, visible: true, meshCount: 8, arg4: 120, delay: 120);
                context.SetEffect(triggerIds: new []{7011, 7021}, visible: true);
                context.SetAgent(triggerIds: new []{10006, 10007, 10008, 10009}, visible: false);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.ShowGuideSummary(entityId: 10014032, textId: 10014032);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2000");
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "40")) {
                    return new State다리건너기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너기01 : TriggerState {
            internal State다리건너기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1004");
                context.ChangeMonster(removeSpawnId: 201, addSpawnId: 202);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9020, spawnIds: new []{102})) {
                    return new State다리건너기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너기02 : TriggerState {
            internal State다리건너기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9021})) {
                    return new State마무리Prepare01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10014032);
            }
        }

        private class State마무리Prepare01 : TriggerState {
            internal State마무리Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "41", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "41")) {
                    return new State마무리Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic01 : TriggerState {
            internal State마무리Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "42", seconds: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 604, enable: true);
                context.SetSceneSkip(state: new State마무리Cinematic08(context), arg2: "nextState");
                context.CreateMonster(spawnIds: new []{401}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "42")) {
                    return new State마무리Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic02 : TriggerState {
            internal State마무리Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "43", seconds: 3);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_4000");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "43")) {
                    return new State마무리Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic03 : TriggerState {
            internal State마무리Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "44", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000016_QD__TUTORIAL04__17$", arg4: 3);
                context.SetEffect(triggerIds: new []{6300}, visible: true);
                context.SetSkip(state: new State마무리Cinematic04Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "44")) {
                    return new State마무리Cinematic04Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic04Wait : TriggerState {
            internal State마무리Cinematic04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State마무리Cinematic04(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic04 : TriggerState {
            internal State마무리Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "45", seconds: 5);
                context.SetEffect(triggerIds: new []{6300}, visible: false);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000016_QD__TUTORIAL04__18$", arg4: 4);
                context.SetEffect(triggerIds: new []{6400}, visible: true);
                context.SetSkip(state: new State마무리Cinematic05Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "45")) {
                    return new State마무리Cinematic05Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic05Wait : TriggerState {
            internal State마무리Cinematic05Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State마무리Cinematic05(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic05 : TriggerState {
            internal State마무리Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "46", seconds: 5);
                context.SetEffect(triggerIds: new []{6400}, visible: false);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000016_QD__TUTORIAL04__19$", arg4: 4);
                context.SetEffect(triggerIds: new []{6301}, visible: true);
                context.SetSkip(state: new State마무리Cinematic06Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "46")) {
                    return new State마무리Cinematic06Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic06Wait : TriggerState {
            internal State마무리Cinematic06Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State마무리Cinematic06(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic06 : TriggerState {
            internal State마무리Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "47", seconds: 5);
                context.SetEffect(triggerIds: new []{6301}, visible: false);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000016_QD__TUTORIAL04__20$", arg4: 4);
                context.SetEffect(triggerIds: new []{6401}, visible: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "47")) {
                    return new State마무리Cinematic07Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic07Wait : TriggerState {
            internal State마무리Cinematic07Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State마무리Cinematic07(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic07 : TriggerState {
            internal State마무리Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "48", seconds: 5);
                context.SetEffect(triggerIds: new []{6401}, visible: false);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000016_QD__TUTORIAL04__21$", arg4: 4);
                context.SetEffect(triggerIds: new []{6302}, visible: true);
                context.SetSkip(state: new State마무리Cinematic08Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "48")) {
                    return new State마무리Cinematic08Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic08Wait : TriggerState {
            internal State마무리Cinematic08Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State마무리Cinematic08(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic08 : TriggerState {
            internal State마무리Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_4001");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1005");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9030, spawnIds: new []{401})) {
                    return new State마무리Cinematic09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic09 : TriggerState {
            internal State마무리Cinematic09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "49", seconds: 5);
                context.DestroyMonster(spawnIds: new []{102, 401});
                context.SetEffect(triggerIds: new []{6302}, visible: false);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000016_QD__TUTORIAL04__22$", arg4: 3);
                context.SetEffect(triggerIds: new []{6402}, visible: true);
                context.SetSkip(state: new State퇴장Prepare01Wait(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "49")) {
                    return new State퇴장Prepare01Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장Prepare01Wait : TriggerState {
            internal State퇴장Prepare01Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State퇴장Prepare01(context);
            }

            public override void OnExit() { }
        }

        private class State퇴장Prepare01 : TriggerState {
            internal State퇴장Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "50", seconds: 1);
                context.CameraSelect(triggerId: 604, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "50")) {
                    return new State퇴장Prepare02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{6402}, visible: false);
                context.SetAchievement(triggerId: 9040, type: "trigger", code: "complete_tombmission");
            }
        }

        private class State퇴장Prepare02 : TriggerState {
            internal State퇴장Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9030, spawnIds: new []{202})) {
                    return new State퇴장완료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장완료01 : TriggerState {
            internal State퇴장완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10014040, textId: 10014040);
                context.DestroyMonster(spawnIds: new []{202});
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9040})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10014040);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
