using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000334_bf {
    public static class _main {
        public class StateMain : TriggerState {
            internal StateMain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(arg1: new[] {13000012}, arg2: 2);
                context.SetEffect(arg1: new[] {98001, 98002, 98003, 98004, 98005, 98006, 90021, 90022}, arg2: false);
                context.SetEffect(arg1: new[] {98031}, arg2: true);
                context.CameraSelect(arg1: 8000, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 90001) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(arg1: new[] {199}, arg2: true);
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
                context.CreateMonster(arg1: new[] {401, 402, 403, 404, 405, 406, 801, 802, 803, 804, 805, 806, 807, 808, 809}, arg2: true);
                context.SetMesh(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(id: "5", arg2: 5, arg4: false);
                context.SetSkip(state: new StateStart_03(context));
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$02000334_BF__MAIN__1$", arg4: 3);
                context.CreateMonster(arg1: new[] {190}, arg2: false);
                context.SetSkip(state: new State1단계_시작(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State1단계_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.SetCinematicUI(type: 4);
            }
        }

        private class State1단계_시작 : TriggerState {
            internal State1단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8013, 8015}, arg2: false);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State1단계_시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계_시작02 : TriggerState {
            internal State1단계_시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 24001205, script: "$02000334_BF__MAIN__6$", arg4: 3);
                context.SetTimer(id: "3", arg2: 3);
                context.SetSkip(state: new State1단계_시작03(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State1단계_시작03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State1단계_시작03 : TriggerState {
            internal State1단계_시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "1,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 1, count: 5);
                context.SetTimer(id: "4", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State1단계_시작04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계_시작04 : TriggerState {
            internal State1단계_시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 199, script: "$02000334_BF__MAIN__3$", arg4: 3);
                context.CreateMonster(arg1: new[] {201, 203}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 203, script: "$02000334_BF__MAIN__4$", arg4: 3);
                context.SetConversation(arg1: 1, arg2: 201, script: "$02000334_BF__MAIN__5$", arg4: 3);
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State1단계_타이머(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계_타이머 : TriggerState {
            internal State1단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {90022}, arg2: true);
                context.CreateMonster(arg1: new[] {160, 150}, arg2: false);
                context.SetTimer(id: "60", arg2: 60, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    return new State2단계_Prepare(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                if (context.UserDetected(arg1: new[] {99999})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {90022}, arg2: false);
            }
        }

        private class State2단계_Prepare : TriggerState {
            internal State2단계_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 152, 991, 992, 993, 994, 995, 996, 997, 998});
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$02000334_BF__MAIN__7$", arg4: 3);
                context.SetSkip(state: new State2단계_시작(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State2단계_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State2단계_시작 : TriggerState {
            internal State2단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204, 205}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 199, script: "$02000334_BF__MAIN__8$", arg4: 3);
                context.SetMesh(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016}, arg2: false, arg4: 250, arg5: 1f);
                context.SetEventUI(arg1: 0, script: "2,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 2, count: 5);
                context.SetTimer(id: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State2단계_타이머(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_타이머 : TriggerState {
            internal State2단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {90022}, arg2: true);
                context.CameraSelect(arg1: 8000, arg2: true);
                context.CreateMonster(arg1: new[] {150, 151}, arg2: false);
                context.SetTimer(id: "60", arg2: 60, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    return new State3단계_Prepare(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {90022}, arg2: false);
            }
        }

        private class State3단계_Prepare : TriggerState {
            internal State3단계_Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 991, 992, 993, 994, 995, 996, 997, 998});
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$02000334_BF__MAIN__9$", arg4: 3);
                context.SetSkip(state: new State3단계_시작(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State3단계_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State3단계_시작 : TriggerState {
            internal State3단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {206, 207}, arg2: true);
                context.SetEventUI(arg1: 0, script: "3,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 3, count: 5);
                context.SetTimer(id: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State3단계_타이머(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3단계_타이머 : TriggerState {
            internal State3단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {90022}, arg2: true);
                context.CreateMonster(arg1: new[] {150, 151, 152}, arg2: false);
                context.SetTimer(id: "60", arg2: 60, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    return new State4단계_Prepare_01(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {90022}, arg2: false);
            }
        }

        private class State4단계_Prepare_01 : TriggerState {
            internal State4단계_Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 152, 991, 992, 993, 994, 995, 996, 997, 998});
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$02000334_BF__MAIN__10$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State4단계_Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4단계_Prepare_02 : TriggerState {
            internal State4단계_Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 24001205, script: "$02000334_BF__MAIN__11$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State4단계_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State4단계_시작 : TriggerState {
            internal State4단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 152, 991, 992, 993, 994, 995, 996, 997, 998});
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_2999");
                context.SetEventUI(arg1: 0, script: "4,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 4, count: 5);
                context.SetTimer(id: "6", arg2: 6);
                context.SetConversation(arg1: 1, arg2: 190, script: "$02000334_BF__WAVE__2$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State4단계_타이머(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {150, 151}, arg2: false);
            }
        }

        private class State4단계_타이머 : TriggerState {
            internal State4단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {90022}, arg2: true);
                context.SetTimer(id: "150", arg2: 150, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "150")) {
                    return new State게임오버(context);
                }

                if (context.MonsterDead(arg1: new[] {190})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {90022}, arg2: false);
            }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 152, 190, 991, 992, 993, 994, 995, 996, 997, 998});
                context.SetEventUI(arg1: 5, arg3: 3000);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.SetEffect(arg1: new[] {98031}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State게임오버_이벤트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버_이벤트 : TriggerState {
            internal State게임오버_이벤트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 152, 190, 991, 992, 993, 994, 995, 996, 997, 998});
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 24001205, script: "$02000334_BF__MAIN__13$", arg4: 3);
                context.SetSkip(state: new State게임오버_강퇴(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State게임오버_강퇴(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State게임오버_강퇴 : TriggerState {
            internal State게임오버_강퇴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5, arg4: true);
                context.SetEventUI(arg1: 1, script: "$02000334_BF__MAIN__14$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State강퇴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강퇴 : TriggerState {
            internal State강퇴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0, arg3: 90001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 90001, arg2: "trigger", arg3: "TaboKill");
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 152, 991, 992, 993, 994, 995, 996, 997, 998});
                context.SetEffect(arg1: new[] {98002, 98003, 98004, 98005}, arg2: true);
                context.SetTimer(id: "3", arg2: 3);
                context.SetEffect(arg1: new[] {98031}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateClear_이벤트(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {98002, 98003, 98004, 98005}, arg2: false);
            }
        }

        private class StateClear_이벤트 : TriggerState {
            internal StateClear_이벤트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151, 152, 991, 992, 993, 994, 995, 996, 997, 998});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$02000334_BF__MAIN__16$", arg4: 3);
                context.SetMesh(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016}, arg2: false, arg4: 250, arg5: 1f);
                context.SetSkip(state: new StateClear_보상(context));
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateClear_보상(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateClear_보상 : TriggerState {
            internal StateClear_보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 103, textId: 40009);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_2015");
                context.SetTimer(id: "10", arg2: 10, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {90099})) {
                    return new StateClear_보상_02(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new StateClear_보상_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 103);
            }
        }

        private class StateClear_보상_02 : TriggerState {
            internal StateClear_보상_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8003, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$02000334_BF__MAIN__18$", arg4: 3);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateClear_보상_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateClear_보상_03 : TriggerState {
            internal StateClear_보상_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 199, script: "$02000334_BF__MAIN__19$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.DungeonClear();
                    context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 103);
            }
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