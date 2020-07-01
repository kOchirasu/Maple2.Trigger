using System;

namespace Maple2.Trigger._52000016_qd {
    public static class _tutorial04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "10000", arg2: true);
                context.SetAgent(arg1: "10001", arg2: true);
                context.SetAgent(arg1: "10002", arg2: true);
                context.SetAgent(arg1: "10003", arg2: true);
                context.SetAgent(arg1: "10004", arg2: true);
                context.SetAgent(arg1: "10005", arg2: true);
                context.SetAgent(arg1: "10010", arg2: true);
                context.SetAgent(arg1: "10006", arg2: true);
                context.SetAgent(arg1: "10007", arg2: true);
                context.SetAgent(arg1: "10008", arg2: true);
                context.SetAgent(arg1: "10009", arg2: true);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {7000}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetEffect(arg1: new int[] {7004}, arg2: false);
                context.SetEffect(arg1: new int[] {7005}, arg2: false);
                context.SetEffect(arg1: new int[] {7006}, arg2: false);
                context.SetEffect(arg1: new int[] {7007}, arg2: false);
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
                context.SetEffect(arg1: new int[] {7020}, arg2: false);
                context.SetEffect(arg1: new int[] {7011}, arg2: false);
                context.SetEffect(arg1: new int[] {7021}, arg2: false);
                context.SetEffect(arg1: new int[] {7030}, arg2: false);
                context.SetEffect(arg1: new int[] {7040}, arg2: false);
                context.SetEffect(arg1: new int[] {7050}, arg2: false);
                context.SetSkill(arg1: new int[] {910}, arg2: false);
                context.SetSkill(arg1: new int[] {911}, arg2: false);
                context.SetSkill(arg1: new int[] {912}, arg2: false);
                context.SetSkill(arg1: new int[] {913}, arg2: false);
                context.SetSkill(arg1: new int[] {914}, arg2: false);
                context.SetMesh(arg1: new int[] {2000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000825}, arg2: 0);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {8200}, arg2: false);
                context.SetEffect(arg1: new int[] {8300}, arg2: false);
                context.SetEffect(arg1: new int[] {8201}, arg2: false);
                context.SetEffect(arg1: new int[] {8301}, arg2: false);
                context.SetEffect(arg1: new int[] {8202}, arg2: false);
                context.SetEffect(arg1: new int[] {8302}, arg2: false);
                context.SetEffect(arg1: new int[] {8203}, arg2: false);
                context.SetEffect(arg1: new int[] {8303}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
                context.SetEffect(arg1: new int[] {6100}, arg2: false);
                context.SetEffect(arg1: new int[] {6101}, arg2: false);
                context.SetEffect(arg1: new int[] {6102}, arg2: false);
                context.SetEffect(arg1: new int[] {6103}, arg2: false);
                context.SetEffect(arg1: new int[] {6104}, arg2: false);
                context.SetEffect(arg1: new int[] {6105}, arg2: false);
                context.SetEffect(arg1: new int[] {6106}, arg2: false);
                context.SetEffect(arg1: new int[] {6200}, arg2: false);
                context.SetEffect(arg1: new int[] {6201}, arg2: false);
                context.SetEffect(arg1: new int[] {6202}, arg2: false);
                context.SetEffect(arg1: new int[] {6203}, arg2: false);
                context.SetEffect(arg1: new int[] {6210}, arg2: false);
                context.SetEffect(arg1: new int[] {6211}, arg2: false);
                context.SetEffect(arg1: new int[] {6212}, arg2: false);
                context.SetEffect(arg1: new int[] {6300}, arg2: false);
                context.SetEffect(arg1: new int[] {6301}, arg2: false);
                context.SetEffect(arg1: new int[] {6302}, arg2: false);
                context.SetEffect(arg1: new int[] {6400}, arg2: false);
                context.SetEffect(arg1: new int[] {6401}, arg2: false);
                context.SetEffect(arg1: new int[] {6402}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000417},
                    arg3: new byte[] {1})) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetRandomMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015
                    }, arg2: true, arg3: 16, arg4: 50, arg5: 80);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State막힌길발견01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State막힌길발견01 : TriggerState {
            internal State막힌길발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State딜레이02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이02 : TriggerState {
            internal State딜레이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {910}, arg2: true);
                context.SetSkill(arg1: new int[] {911}, arg2: true);
                context.SetSkill(arg1: new int[] {912}, arg2: true);
                context.SetSkill(arg1: new int[] {913}, arg2: true);
                context.SetSkill(arg1: new int[] {914}, arg2: true);
                context.SetEffect(arg1: new int[] {7010}, arg2: true);
                context.SetEffect(arg1: new int[] {7020}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State막힌길발견02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State막힌길발견02 : TriggerState {
            internal State막힌길발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 4);
                context.SetEffect(arg1: new int[] {7000}, arg2: true);
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
                context.SetEffect(arg1: new int[] {7004}, arg2: true);
                context.SetEffect(arg1: new int[] {7005}, arg2: true);
                context.SetEffect(arg1: new int[] {7006}, arg2: true);
                context.SetEffect(arg1: new int[] {7007}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State척후병입장(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new int[] {2000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State척후병입장 : TriggerState {
            internal State척후병입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1000");
                context.SetEffect(arg1: new int[] {6100}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001249, arg3: "$52000016_QD__TUTORIAL04__0$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State돌치우기안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌치우기안내01 : TriggerState {
            internal State돌치우기안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 3);
                context.SetEffect(arg1: new int[] {6101}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1001");
                context.SetConversation(arg1: 2, arg2: 11001249, arg3: "$52000016_QD__TUTORIAL04__1$", arg4: 3);
                context.SetSkip(arg1: "돌치우기안내03");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State돌치우기안내03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
                context.SetEffect(arg1: new int[] {7020}, arg2: false);
                context.SetSkill(arg1: new int[] {910}, arg2: false);
                context.SetSkill(arg1: new int[] {911}, arg2: false);
                context.SetSkill(arg1: new int[] {912}, arg2: false);
                context.SetSkill(arg1: new int[] {913}, arg2: false);
                context.SetSkill(arg1: new int[] {914}, arg2: false);
            }
        }

        private class State돌치우기안내03 : TriggerState {
            internal State돌치우기안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State첫번째돌들기가이드01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째돌들기가이드01 : TriggerState {
            internal State첫번째돌들기가이드01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.ShowGuideSummary(entityID: 10014010, textID: 10014010);
            }

            public override void Execute() {
                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {9001}, itemID: 30000440)) {
                    context.State = new State첫번째돌놓기01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10014010);
            }
        }

        private class State첫번째돌놓기01 : TriggerState {
            internal State첫번째돌놓기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.ShowGuideSummary(entityID: 10014020, textID: 10014020);
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {9011, 9012}, itemID: 30000440)) {
                    context.State = new State척후병이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State척후병이동01 : TriggerState {
            internal State척후병이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10014020);
                context.CreateMonster(arg1: new int[] {901, 902, 903, 904, 905, 906, 907}, arg2: false);
                context.SetRandomMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015
                    }, arg2: false, arg3: 16, arg4: 100, arg5: 80);
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new int[] {101})) {
                    context.State = new State척후병이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State척후병이동02 : TriggerState {
            internal State척후병이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000016_QD__TUTORIAL04__2$", arg4: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9005, arg2: new int[] {101})) {
                    context.State = new State척후병전투시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State척후병전투시작01 : TriggerState {
            internal State척후병전투시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "9", arg2: 1);
                context.SetAgent(arg1: "10000", arg2: false);
                context.SetAgent(arg1: "10001", arg2: false);
                context.SetAgent(arg1: "10002", arg2: false);
                context.SetAgent(arg1: "10003", arg2: false);
                context.SetAgent(arg1: "10004", arg2: false);
                context.SetAgent(arg1: "10005", arg2: false);
                context.SetAgent(arg1: "10010", arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new State전투중01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000016_QD__TUTORIAL04__3$", arg4: 2);
                context.SetEffect(arg1: new int[] {6102}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State전투중02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투중02 : TriggerState {
            internal State전투중02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000016_QD__TUTORIAL04__4$", arg4: 2);
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.ShowGuideSummary(entityID: 10014030, textID: 10014030);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901, 902, 903, 904, 905, 906, 907})) {
                    context.State = new State전투종료01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10014030);
            }
        }

        private class State전투종료01 : TriggerState {
            internal State전투종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 2);
                context.SetEffect(arg1: new int[] {6103}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000016_QD__TUTORIAL04__5$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State전투종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료02 : TriggerState {
            internal State전투종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000016_QD__TUTORIAL04__6$", arg4: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1003");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State다리로이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리로이동01 : TriggerState {
            internal State다리로이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new int[] {101})) {
                    context.State = new State연출준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비01 : TriggerState {
            internal State연출준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 3);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 602, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001249, arg3: "$52000016_QD__TUTORIAL04__7$", arg4: 3);
                context.SetEffect(arg1: new int[] {6104}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State연출준비02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비02 : TriggerState {
            internal State연출준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001249, arg3: "$52000016_QD__TUTORIAL04__8$", arg4: 2);
                context.SetEffect(arg1: new int[] {6105}, arg2: true);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {301}, arg2: true);
                context.CreateMonster(arg1: new int[] {210, 211, 212, 213, 214, 215, 216, 217}, arg2: true);
                context.CreateMonster(arg1: new int[] {310, 311, 312, 313}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State연출시작01대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작01대기 : TriggerState {
            internal State연출시작01대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작01 : TriggerState {
            internal State연출시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "연출종료01_skip", arg2: "nextState");
                context.SetTimer(arg1: "16", arg2: 1);
                context.CameraSelectPath(arg1: new int[] {602, 603}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "16")) {
                    context.State = new State대결연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출01 : TriggerState {
            internal State대결연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "18", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000016_QD__TUTORIAL04__9$", arg4: 3);
                context.SetEffect(arg1: new int[] {6200}, arg2: true);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.SetSkip(arg1: "대결연출02대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "18")) {
                    context.State = new State대결연출02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출02대기 : TriggerState {
            internal State대결연출02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대결연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출02 : TriggerState {
            internal State대결연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "19", arg2: 7);
                context.SetConversation(arg1: 2, arg2: 11001231, arg3: "$52000016_QD__TUTORIAL04__10$", arg4: 6);
                context.SetEffect(arg1: new int[] {6200}, arg2: false);
                context.SetEffect(arg1: new int[] {6210}, arg2: true);
                context.SetSkip(arg1: "대결연출03대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "19")) {
                    context.State = new State대결연출03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출03대기 : TriggerState {
            internal State대결연출03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대결연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출03 : TriggerState {
            internal State대결연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000016_QD__TUTORIAL04__11$", arg4: 4);
                context.SetEffect(arg1: new int[] {6210}, arg2: false);
                context.SetEffect(arg1: new int[] {6201}, arg2: true);
                context.SetSkip(arg1: "대결연출04대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State대결연출04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출04대기 : TriggerState {
            internal State대결연출04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대결연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출04 : TriggerState {
            internal State대결연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11001231, arg3: "$52000016_QD__TUTORIAL04__12$", arg4: 5);
                context.SetEffect(arg1: new int[] {6201}, arg2: false);
                context.SetEffect(arg1: new int[] {6211}, arg2: true);
                context.SetSkip(arg1: "대결연출05대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    context.State = new State대결연출05대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출05대기 : TriggerState {
            internal State대결연출05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대결연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출05 : TriggerState {
            internal State대결연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000016_QD__TUTORIAL04__13$", arg4: 3);
                context.SetEffect(arg1: new int[] {6211}, arg2: false);
                context.SetEffect(arg1: new int[] {6202}, arg2: true);
                context.SetSkip(arg1: "대결연출06대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State대결연출06대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출06대기 : TriggerState {
            internal State대결연출06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대결연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출06 : TriggerState {
            internal State대결연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001231, arg3: "$52000016_QD__TUTORIAL04__14$", arg4: 3);
                context.SetEffect(arg1: new int[] {6202}, arg2: false);
                context.SetEffect(arg1: new int[] {6212}, arg2: true);
                context.SetSkip(arg1: "대결연출07대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    context.State = new State대결연출07대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출07대기 : TriggerState {
            internal State대결연출07대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대결연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출07 : TriggerState {
            internal State대결연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "24", arg2: 1);
                context.CameraSelect(arg1: 606, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "24")) {
                    context.State = new State대결연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대결연출08 : TriggerState {
            internal State대결연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 1);
                context.SetEffect(arg1: new int[] {7050}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000016_QD__TUTORIAL04__15$", arg4: 2);
                context.SetEffect(arg1: new int[] {6212}, arg2: false);
                context.SetEffect(arg1: new int[] {6203}, arg2: true);
                context.SetEffect(arg1: new int[] {8200}, arg2: true);
                context.SetEffect(arg1: new int[] {8300}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    context.State = new State이펙트연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트연출01 : TriggerState {
            internal State이펙트연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "26", arg2: 2);
                context.SetEffect(arg1: new int[] {8201}, arg2: true);
                context.SetEffect(arg1: new int[] {8301}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    context.State = new State이펙트연출02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {8200}, arg2: false);
                context.SetEffect(arg1: new int[] {8300}, arg2: false);
            }
        }

        private class State이펙트연출02 : TriggerState {
            internal State이펙트연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "27", arg2: 1);
                context.SetEffect(arg1: new int[] {8201}, arg2: false);
                context.SetEffect(arg1: new int[] {8301}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2100");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3100");
                context.SetEffect(arg1: new int[] {8203}, arg2: true);
                context.SetEffect(arg1: new int[] {8303}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "27")) {
                    context.State = new State이펙트연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트연출03 : TriggerState {
            internal State이펙트연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "28", arg2: 1);
                context.SetEffect(arg1: new int[] {8202}, arg2: true);
                context.SetEffect(arg1: new int[] {8302}, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "28")) {
                    context.State = new State연출종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료01 : TriggerState {
            internal State연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 1);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 606, arg2: false);
                context.CameraSelect(arg1: 602, arg2: false);
                context.CameraSelect(arg1: 603, arg2: false);
                context.SetEffect(arg1: new int[] {8203}, arg2: false);
                context.SetEffect(arg1: new int[] {8303}, arg2: false);
                context.SetEffect(arg1: new int[] {8202}, arg2: false);
                context.SetEffect(arg1: new int[] {8302}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State레버당기기01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {7040}, arg2: false);
                context.SetEffect(arg1: new int[] {7050}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
            }
        }

        private class State연출종료01_skip : TriggerState {
            internal State연출종료01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "30", arg2: 1);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 606, arg2: false);
                context.CameraSelect(arg1: 602, arg2: false);
                context.CameraSelect(arg1: 603, arg2: false);
                context.SetEffect(arg1: new int[] {8203}, arg2: false);
                context.SetEffect(arg1: new int[] {8303}, arg2: false);
                context.SetEffect(arg1: new int[] {8202}, arg2: false);
                context.SetEffect(arg1: new int[] {8302}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State레버당기기01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {7040}, arg2: false);
                context.SetEffect(arg1: new int[] {7050}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
            }
        }

        private class State레버당기기01 : TriggerState {
            internal State레버당기기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 1);
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 605, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000825}, arg2: 1);
                context.SetEffect(arg1: new int[] {7030}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    context.State = new State레버당기기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버당기기02 : TriggerState {
            internal State레버당기기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001249, arg3: "$52000016_QD__TUTORIAL04__16$", arg4: 3);
                context.SetEffect(arg1: new int[] {6106}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    context.State = new State다리만들기01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.ShowGuideSummary(entityID: 10014031, textID: 10014031);
            }
        }

        private class State다리만들기01 : TriggerState {
            internal State다리만들기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 605, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {301});
                context.DestroyMonster(arg1: new int[] {210, 211, 212, 213, 214, 215, 216, 217});
                context.DestroyMonster(arg1: new int[] {310, 311, 312, 313});
                context.CreateMonster(arg1: new int[] {220, 221, 222, 223, 224, 225, 226, 227}, arg2: true);
                context.SetEffect(arg1: new int[] {7030}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000825}, arg2: 0)) {
                    context.State = new State다리만들기02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10014031);
            }
        }

        private class State다리만들기02 : TriggerState {
            internal State다리만들기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "40", arg2: 1);
                context.SetRandomMesh(arg1: new int[] {4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027}, arg2: true,
                    arg3: 8, arg4: 120, arg5: 120);
                context.SetEffect(arg1: new int[] {7011}, arg2: true);
                context.SetEffect(arg1: new int[] {7021}, arg2: true);
                context.SetAgent(arg1: "10006", arg2: false);
                context.SetAgent(arg1: "10007", arg2: false);
                context.SetAgent(arg1: "10008", arg2: false);
                context.SetAgent(arg1: "10009", arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.ShowGuideSummary(entityID: 10014032, textID: 10014032);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2000");
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "40")) {
                    context.State = new State다리건너기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너기01 : TriggerState {
            internal State다리건너기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1004");
                context.ChangeMonster(arg1: 201, arg2: 202);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9020, arg2: new int[] {102})) {
                    context.State = new State다리건너기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너기02 : TriggerState {
            internal State다리건너기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9021})) {
                    context.State = new State마무리준비01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10014032);
            }
        }

        private class State마무리준비01 : TriggerState {
            internal State마무리준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "41", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "41")) {
                    context.State = new State마무리연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출01 : TriggerState {
            internal State마무리연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "42", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 604, arg2: true);
                context.SetSceneSkip(arg1: "마무리연출08", arg2: "nextState");
                context.CreateMonster(arg1: new int[] {401}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "42")) {
                    context.State = new State마무리연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출02 : TriggerState {
            internal State마무리연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "43", arg2: 3);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4000");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "43")) {
                    context.State = new State마무리연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출03 : TriggerState {
            internal State마무리연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "44", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000016_QD__TUTORIAL04__17$", arg4: 3);
                context.SetEffect(arg1: new int[] {6300}, arg2: true);
                context.SetSkip(arg1: "마무리연출04대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "44")) {
                    context.State = new State마무리연출04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출04대기 : TriggerState {
            internal State마무리연출04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State마무리연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출04 : TriggerState {
            internal State마무리연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "45", arg2: 5);
                context.SetEffect(arg1: new int[] {6300}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000016_QD__TUTORIAL04__18$", arg4: 4);
                context.SetEffect(arg1: new int[] {6400}, arg2: true);
                context.SetSkip(arg1: "마무리연출05대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "45")) {
                    context.State = new State마무리연출05대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출05대기 : TriggerState {
            internal State마무리연출05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State마무리연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출05 : TriggerState {
            internal State마무리연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "46", arg2: 5);
                context.SetEffect(arg1: new int[] {6400}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000016_QD__TUTORIAL04__19$", arg4: 4);
                context.SetEffect(arg1: new int[] {6301}, arg2: true);
                context.SetSkip(arg1: "마무리연출06대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "46")) {
                    context.State = new State마무리연출06대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출06대기 : TriggerState {
            internal State마무리연출06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State마무리연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출06 : TriggerState {
            internal State마무리연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "47", arg2: 5);
                context.SetEffect(arg1: new int[] {6301}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000016_QD__TUTORIAL04__20$", arg4: 4);
                context.SetEffect(arg1: new int[] {6401}, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "47")) {
                    context.State = new State마무리연출07대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출07대기 : TriggerState {
            internal State마무리연출07대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State마무리연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출07 : TriggerState {
            internal State마무리연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "48", arg2: 5);
                context.SetEffect(arg1: new int[] {6401}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001230, arg3: "$52000016_QD__TUTORIAL04__21$", arg4: 4);
                context.SetEffect(arg1: new int[] {6302}, arg2: true);
                context.SetSkip(arg1: "마무리연출08대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "48")) {
                    context.State = new State마무리연출08대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출08대기 : TriggerState {
            internal State마무리연출08대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State마무리연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출08 : TriggerState {
            internal State마무리연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_4001");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1005");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new int[] {401})) {
                    context.State = new State마무리연출09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출09 : TriggerState {
            internal State마무리연출09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "49", arg2: 5);
                context.DestroyMonster(arg1: new int[] {102, 401});
                context.SetEffect(arg1: new int[] {6302}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000016_QD__TUTORIAL04__22$", arg4: 3);
                context.SetEffect(arg1: new int[] {6402}, arg2: true);
                context.SetSkip(arg1: "퇴장준비01대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "49")) {
                    context.State = new State퇴장준비01대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장준비01대기 : TriggerState {
            internal State퇴장준비01대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State퇴장준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장준비01 : TriggerState {
            internal State퇴장준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "50", arg2: 1);
                context.CameraSelect(arg1: 604, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "50")) {
                    context.State = new State퇴장준비02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {6402}, arg2: false);
                context.SetAchievement(arg1: 9040, arg2: "trigger", arg3: "complete_tombmission");
            }
        }

        private class State퇴장준비02 : TriggerState {
            internal State퇴장준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new int[] {202})) {
                    context.State = new State퇴장완료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장완료01 : TriggerState {
            internal State퇴장완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10014040, textID: 10014040);
                context.DestroyMonster(arg1: new int[] {202});
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9040})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10014040);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}