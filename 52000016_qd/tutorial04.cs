namespace Maple2.Trigger._52000016_qd {
    public static class _tutorial04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {10000, 10001, 10002, 10003, 10004, 10005, 10010, 10006, 10007, 10008, 10009}, arg2: true);
                context.SetEffect(arg1: new[] {6000, 7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7010, 7020, 7011, 7021, 7030, 7040, 7050}, arg2: false);
                context.SetSkill(arg1: new[] {910, 911, 912, 913, 914}, arg2: false);
                context.SetMesh(arg1: new[] {2000, 3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000825}, arg2: 0);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(arg1: new[] {8200, 8300, 8201, 8301, 8202, 8302, 8203, 8303, 8000, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6200, 6201, 6202, 6203, 6210, 6211, 6212, 6300, 6301, 6302, 6400, 6401, 6402}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000417}, arg3: new byte[] {1})) {
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
                context.SetRandomMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015}, arg2: true, arg3: 16, arg4: 50, arg5: 80);
            }

            public override TriggerState Execute() {
                return new State막힌길발견01(context);
            }

            public override void OnExit() { }
        }

        private class State막힌길발견01 : TriggerState {
            internal State막힌길발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateDelay02(context);
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetSkill(arg1: new[] {910, 911, 912, 913, 914}, arg2: true);
                context.SetEffect(arg1: new[] {7010, 7020}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State막힌길발견02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State막힌길발견02 : TriggerState {
            internal State막힌길발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 4);
                context.SetEffect(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State척후병입장(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {2000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State척후병입장 : TriggerState {
            internal State척후병입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1000");
                context.SetEffect(arg1: new[] {6100}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001249, script: "$52000016_QD__TUTORIAL04__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State돌치우기안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌치우기안내01 : TriggerState {
            internal State돌치우기안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 3);
                context.SetEffect(arg1: new[] {6101}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1001");
                context.SetConversation(arg1: 2, arg2: 11001249, script: "$52000016_QD__TUTORIAL04__1$", arg4: 3);
                context.SetSkip(state: new State돌치우기안내03(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State돌치우기안내03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetEffect(arg1: new[] {7010, 7020}, arg2: false);
                context.SetSkill(arg1: new[] {910, 911, 912, 913, 914}, arg2: false);
            }
        }

        private class State돌치우기안내03 : TriggerState {
            internal State돌치우기안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return new State첫번째돌들기Guide01(context);
            }

            public override void OnExit() { }
        }

        private class State첫번째돌들기Guide01 : TriggerState {
            internal State첫번째돌들기Guide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.ShowGuideSummary(entityId: 10014010, textId: 10014010);
            }

            public override TriggerState Execute() {
                if (!context.DetectLiftableObject(triggerBoxIds: new[] {9001}, itemId: 30000440)) {
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
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.ShowGuideSummary(entityId: 10014020, textId: 10014020);
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {9011, 9012}, itemId: 30000440)) {
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
                context.CreateMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907}, arg2: false);
                context.SetRandomMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015}, arg2: false, arg3: 16, arg4: 100, arg5: 80);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {101})) {
                    return new State척후병이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State척후병이동02 : TriggerState {
            internal State척후병이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$52000016_QD__TUTORIAL04__2$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9005, arg2: new[] {101})) {
                    return new State척후병전투시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State척후병전투시작01 : TriggerState {
            internal State척후병전투시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "9", arg2: 1);
                context.SetAgent(arg1: new[] {10000, 10001, 10002, 10003, 10004, 10005, 10010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    return new State전투중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 101, script: "$52000016_QD__TUTORIAL04__3$", arg4: 2);
                context.SetEffect(arg1: new[] {6102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State전투중02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투중02 : TriggerState {
            internal State전투중02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$52000016_QD__TUTORIAL04__4$", arg4: 2);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.ShowGuideSummary(entityId: 10014030, textId: 10014030);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907})) {
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
                context.SetTimer(id: "11", arg2: 2);
                context.SetEffect(arg1: new[] {6103}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 101, script: "$52000016_QD__TUTORIAL04__5$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State전투종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료02 : TriggerState {
            internal State전투종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "12", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 101, script: "$52000016_QD__TUTORIAL04__6$", arg4: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State다리로이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리로이동01 : TriggerState {
            internal State다리로이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new[] {101})) {
                    return new StateSetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic01 : TriggerState {
            internal StateSetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "13", arg2: 3);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 602, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001249, script: "$52000016_QD__TUTORIAL04__7$", arg4: 3);
                context.SetEffect(arg1: new[] {6104}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    return new StateSetupCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic02 : TriggerState {
            internal StateSetupCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "14", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001249, script: "$52000016_QD__TUTORIAL04__8$", arg4: 2);
                context.SetEffect(arg1: new[] {6105}, arg2: true);
                context.CreateMonster(arg1: new[] {201, 301, 210, 211, 212, 213, 214, 215, 216, 217, 310, 311, 312, 313}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "14")) {
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

            public override TriggerState Execute() {
                return new StateStartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic01 : TriggerState {
            internal StateStartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateStopCinematic01_skip(context), arg2: "nextState");
                context.SetTimer(id: "16", arg2: 1);
                context.CameraSelectPath(pathIds: new[] {602, 603}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "16")) {
                    return new State대결Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic01 : TriggerState {
            internal State대결Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "18", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000016_QD__TUTORIAL04__9$", arg4: 3);
                context.SetEffect(arg1: new[] {6200}, arg2: true);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.SetSkip(state: new State대결Cinematic02Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "18")) {
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

            public override TriggerState Execute() {
                return new State대결Cinematic02(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic02 : TriggerState {
            internal State대결Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "19", arg2: 7);
                context.SetConversation(arg1: 2, arg2: 11001231, script: "$52000016_QD__TUTORIAL04__10$", arg4: 6);
                context.SetEffect(arg1: new[] {6200}, arg2: false);
                context.SetEffect(arg1: new[] {6210}, arg2: true);
                context.SetSkip(state: new State대결Cinematic03Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "19")) {
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

            public override TriggerState Execute() {
                return new State대결Cinematic03(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic03 : TriggerState {
            internal State대결Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "20", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000016_QD__TUTORIAL04__11$", arg4: 4);
                context.SetEffect(arg1: new[] {6210}, arg2: false);
                context.SetEffect(arg1: new[] {6201}, arg2: true);
                context.SetSkip(state: new State대결Cinematic04Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
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

            public override TriggerState Execute() {
                return new State대결Cinematic04(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic04 : TriggerState {
            internal State대결Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "21", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001231, script: "$52000016_QD__TUTORIAL04__12$", arg4: 5);
                context.SetEffect(arg1: new[] {6201}, arg2: false);
                context.SetEffect(arg1: new[] {6211}, arg2: true);
                context.SetSkip(state: new State대결Cinematic05Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
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

            public override TriggerState Execute() {
                return new State대결Cinematic05(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic05 : TriggerState {
            internal State대결Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "22", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000016_QD__TUTORIAL04__13$", arg4: 3);
                context.SetEffect(arg1: new[] {6211}, arg2: false);
                context.SetEffect(arg1: new[] {6202}, arg2: true);
                context.SetSkip(state: new State대결Cinematic06Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "22")) {
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

            public override TriggerState Execute() {
                return new State대결Cinematic06(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic06 : TriggerState {
            internal State대결Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "23", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001231, script: "$52000016_QD__TUTORIAL04__14$", arg4: 3);
                context.SetEffect(arg1: new[] {6202}, arg2: false);
                context.SetEffect(arg1: new[] {6212}, arg2: true);
                context.SetSkip(state: new State대결Cinematic07Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "23")) {
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

            public override TriggerState Execute() {
                return new State대결Cinematic07(context);
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic07 : TriggerState {
            internal State대결Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "24", arg2: 1);
                context.CameraSelect(arg1: 606, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "24")) {
                    return new State대결Cinematic08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대결Cinematic08 : TriggerState {
            internal State대결Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "25", arg2: 1);
                context.SetEffect(arg1: new[] {7050}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000016_QD__TUTORIAL04__15$", arg4: 2);
                context.SetEffect(arg1: new[] {6212}, arg2: false);
                context.SetEffect(arg1: new[] {6203, 8200, 8300}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    return new State이펙트Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Cinematic01 : TriggerState {
            internal State이펙트Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "26", arg2: 2);
                context.SetEffect(arg1: new[] {8201, 8301}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    return new State이펙트Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {8200, 8300}, arg2: false);
            }
        }

        private class State이펙트Cinematic02 : TriggerState {
            internal State이펙트Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "27", arg2: 1);
                context.SetEffect(arg1: new[] {8201, 8301}, arg2: false);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2100");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3100");
                context.SetEffect(arg1: new[] {8203, 8303}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "27")) {
                    return new State이펙트Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Cinematic03 : TriggerState {
            internal State이펙트Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "28", arg2: 1);
                context.SetEffect(arg1: new[] {8202, 8302}, arg2: true);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "28")) {
                    return new StateStopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic01 : TriggerState {
            internal StateStopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "30", arg2: 1);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(arg1: 606, arg2: false);
                context.CameraSelect(arg1: 602, arg2: false);
                context.CameraSelect(arg1: 603, arg2: false);
                context.SetEffect(arg1: new[] {8203, 8303, 8202, 8302}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new StateLeverPull01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7040, 7050, 8000}, arg2: false);
            }
        }

        private class StateStopCinematic01_skip : TriggerState {
            internal StateStopCinematic01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102});
                context.RemoveCinematicTalk();
                context.SetTimer(id: "30", arg2: 1);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(arg1: 606, arg2: false);
                context.CameraSelect(arg1: 602, arg2: false);
                context.CameraSelect(arg1: 603, arg2: false);
                context.SetEffect(arg1: new[] {8203, 8303, 8202, 8302}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new StateLeverPull01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7040, 7050, 8000}, arg2: false);
            }
        }

        private class StateLeverPull01 : TriggerState {
            internal StateLeverPull01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "31", arg2: 1);
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 605, arg2: true);
                context.SetInteractObject(arg1: new[] {10000825}, arg2: 1);
                context.SetEffect(arg1: new[] {7030}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new StateLeverPull02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverPull02 : TriggerState {
            internal StateLeverPull02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "35", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001249, script: "$52000016_QD__TUTORIAL04__16$", arg4: 3);
                context.SetEffect(arg1: new[] {6106}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    return new State다리만들기01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.ShowGuideSummary(entityId: 10014031, textId: 10014031);
            }
        }

        private class State다리만들기01 : TriggerState {
            internal State다리만들기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 605, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(arg1: new[] {301, 210, 211, 212, 213, 214, 215, 216, 217, 310, 311, 312, 313});
                context.CreateMonster(arg1: new[] {220, 221, 222, 223, 224, 225, 226, 227}, arg2: true);
                context.SetEffect(arg1: new[] {7030}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000825}, arg2: 0)) {
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
                context.SetTimer(id: "40", arg2: 1);
                context.SetRandomMesh(arg1: new[] {4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027}, arg2: true, arg3: 8, arg4: 120, arg5: 120);
                context.SetEffect(arg1: new[] {7011, 7021}, arg2: true);
                context.SetAgent(arg1: new[] {10006, 10007, 10008, 10009}, arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.ShowGuideSummary(entityId: 10014032, textId: 10014032);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2000");
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "40")) {
                    return new State다리건너기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너기01 : TriggerState {
            internal State다리건너기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1004");
                context.ChangeMonster(arg1: 201, arg2: 202);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9020, arg2: new[] {102})) {
                    return new State다리건너기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너기02 : TriggerState {
            internal State다리건너기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9021})) {
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
                context.SetTimer(id: "41", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "41")) {
                    return new State마무리Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic01 : TriggerState {
            internal State마무리Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "42", arg2: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 604, arg2: true);
                context.SetSceneSkip(state: new State마무리Cinematic08(context), arg2: "nextState");
                context.CreateMonster(arg1: new[] {401}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "42")) {
                    return new State마무리Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic02 : TriggerState {
            internal State마무리Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "43", arg2: 3);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4000");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "43")) {
                    return new State마무리Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic03 : TriggerState {
            internal State마무리Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "44", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001230, script: "$52000016_QD__TUTORIAL04__17$", arg4: 3);
                context.SetEffect(arg1: new[] {6300}, arg2: true);
                context.SetSkip(state: new State마무리Cinematic04Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "44")) {
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

            public override TriggerState Execute() {
                return new State마무리Cinematic04(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic04 : TriggerState {
            internal State마무리Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "45", arg2: 5);
                context.SetEffect(arg1: new[] {6300}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000016_QD__TUTORIAL04__18$", arg4: 4);
                context.SetEffect(arg1: new[] {6400}, arg2: true);
                context.SetSkip(state: new State마무리Cinematic05Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "45")) {
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

            public override TriggerState Execute() {
                return new State마무리Cinematic05(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic05 : TriggerState {
            internal State마무리Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "46", arg2: 5);
                context.SetEffect(arg1: new[] {6400}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001230, script: "$52000016_QD__TUTORIAL04__19$", arg4: 4);
                context.SetEffect(arg1: new[] {6301}, arg2: true);
                context.SetSkip(state: new State마무리Cinematic06Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "46")) {
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

            public override TriggerState Execute() {
                return new State마무리Cinematic06(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic06 : TriggerState {
            internal State마무리Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "47", arg2: 5);
                context.SetEffect(arg1: new[] {6301}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000016_QD__TUTORIAL04__20$", arg4: 4);
                context.SetEffect(arg1: new[] {6401}, arg2: true);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "47")) {
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

            public override TriggerState Execute() {
                return new State마무리Cinematic07(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic07 : TriggerState {
            internal State마무리Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "48", arg2: 5);
                context.SetEffect(arg1: new[] {6401}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001230, script: "$52000016_QD__TUTORIAL04__21$", arg4: 4);
                context.SetEffect(arg1: new[] {6302}, arg2: true);
                context.SetSkip(state: new State마무리Cinematic08Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "48")) {
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

            public override TriggerState Execute() {
                return new State마무리Cinematic08(context);
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic08 : TriggerState {
            internal State마무리Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4001");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1005");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new[] {401})) {
                    return new State마무리Cinematic09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리Cinematic09 : TriggerState {
            internal State마무리Cinematic09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "49", arg2: 5);
                context.DestroyMonster(arg1: new[] {102, 401});
                context.SetEffect(arg1: new[] {6302}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000016_QD__TUTORIAL04__22$", arg4: 3);
                context.SetEffect(arg1: new[] {6402}, arg2: true);
                context.SetSkip(state: new State퇴장Prepare01Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "49")) {
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

            public override TriggerState Execute() {
                return new State퇴장Prepare01(context);
            }

            public override void OnExit() { }
        }

        private class State퇴장Prepare01 : TriggerState {
            internal State퇴장Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "50", arg2: 1);
                context.CameraSelect(arg1: 604, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "50")) {
                    return new State퇴장Prepare02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {6402}, arg2: false);
                context.SetAchievement(arg1: 9040, arg2: "trigger", arg3: "complete_tombmission");
            }
        }

        private class State퇴장Prepare02 : TriggerState {
            internal State퇴장Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new[] {202})) {
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
                context.DestroyMonster(arg1: new[] {202});
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9040})) {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}