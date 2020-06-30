using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000334_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statemain(context);

        private class Statemain : TriggerState {
            internal Statemain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {13000012}, arg2: 2);
                context.SetEffect(arg1: new int[] {98001}, arg2: false);
                context.SetEffect(arg1: new int[] {98002}, arg2: false);
                context.SetEffect(arg1: new int[] {98003}, arg2: false);
                context.SetEffect(arg1: new int[] {98004}, arg2: false);
                context.SetEffect(arg1: new int[] {98005}, arg2: false);
                context.SetEffect(arg1: new int[] {98006}, arg2: false);
                context.SetEffect(arg1: new int[] {90021}, arg2: false);
                context.SetEffect(arg1: new int[] {90022}, arg2: false);
                context.SetEffect(arg1: new int[] {98031}, arg2: true);
                context.CameraSelect(arg1: 8000, arg2: true);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 90001, arg2: 1)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {199}, arg2: true);
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
                context.CreateMonster(arg1: new int[] {401, 402, 403, 404, 405, 406}, arg2: true);
                context.CreateMonster(arg1: new int[] {801, 802, 803, 804, 805, 806, 807, 808, 809}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015,
                        6016
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_02 : TriggerState {
            internal State시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "5", arg2: 5, arg4: false);
                context.SetSkip(arg1: "시작_03");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State시작_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_03 : TriggerState {
            internal State시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$02000334_BF__MAIN__1$", arg4: 3);
                context.CreateMonster(arg1: new int[] {190}, arg2: false);
                context.SetSkip(arg1: "1단계_시작");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State1단계_시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
                context.SetProductionUI(arg1: 4);
            }
        }

        private class State1단계_시작 : TriggerState {
            internal State1단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8013, 8015}, arg2: 0);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State1단계_시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계_시작02 : TriggerState {
            internal State1단계_시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 24001205, arg3: "$02000334_BF__MAIN__6$", arg4: 3);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "1단계_시작03");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State1단계_시작03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State1단계_시작03 : TriggerState {
            internal State1단계_시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "1,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 1, count: 5);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State1단계_시작04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계_시작04 : TriggerState {
            internal State1단계_시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000334_BF__MAIN__3$", arg4: 3);
                context.CreateMonster(arg1: new int[] {201, 203}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000334_BF__MAIN__4$", arg4: 3);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000334_BF__MAIN__5$", arg4: 3);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State1단계_타이머(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계_타이머 : TriggerState {
            internal State1단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {90022}, arg2: true);
                context.CreateMonster(arg1: new int[] {160}, arg2: false);
                context.CreateMonster(arg1: new int[] {150}, arg2: false);
                context.SetTimer(arg1: "60", arg2: 60, arg4: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State2단계_준비(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.UserDetected(arg1: "99999")) {
                    context.State = new State클리어(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {90022}, arg2: false);
            }
        }

        private class State2단계_준비 : TriggerState {
            internal State2단계_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    152, 991, 992, 993, 994, 995, 996, 997, 998
                });
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$02000334_BF__MAIN__7$", arg4: 3);
                context.SetSkip(arg1: "2단계_시작");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State2단계_시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State2단계_시작 : TriggerState {
            internal State2단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {204, 205}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000334_BF__MAIN__8$", arg4: 3);
                context.SetMesh(
                    arg1: new int[] {
                        6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015,
                        6016
                    }, arg2: false, arg4: 250, arg5: 1f);
                context.SetEventUI(arg1: 0, arg2: "2,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 2, count: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State2단계_타이머(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_타이머 : TriggerState {
            internal State2단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {90022}, arg2: true);
                context.CameraSelect(arg1: 8000, arg2: true);
                context.CreateMonster(arg1: new int[] {150, 151}, arg2: false);
                context.SetTimer(arg1: "60", arg2: 60, arg4: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State3단계_준비(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {90022}, arg2: false);
            }
        }

        private class State3단계_준비 : TriggerState {
            internal State3단계_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    991, 992, 993, 994, 995, 996, 997, 998
                });
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$02000334_BF__MAIN__9$", arg4: 3);
                context.SetSkip(arg1: "3단계_시작");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State3단계_시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State3단계_시작 : TriggerState {
            internal State3단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {206, 207}, arg2: true);
                context.SetEventUI(arg1: 0, arg2: "3,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 3, count: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State3단계_타이머(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3단계_타이머 : TriggerState {
            internal State3단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {90022}, arg2: true);
                context.CreateMonster(arg1: new int[] {150, 151, 152}, arg2: false);
                context.SetTimer(arg1: "60", arg2: 60, arg4: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State4단계_준비_01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {90022}, arg2: false);
            }
        }

        private class State4단계_준비_01 : TriggerState {
            internal State4단계_준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    152, 991, 992, 993, 994, 995, 996, 997, 998
                });
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$02000334_BF__MAIN__10$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State4단계_준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4단계_준비_02 : TriggerState {
            internal State4단계_준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 24001205, arg3: "$02000334_BF__MAIN__11$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State4단계_시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State4단계_시작 : TriggerState {
            internal State4단계_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    152, 991, 992, 993, 994, 995, 996, 997, 998
                });
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_2999");
                context.SetEventUI(arg1: 0, arg2: "4,4");
                context.ShowCountUI(text: "$02000334_BF__MAIN__2$", stage: 4, count: 5);
                context.SetTimer(arg1: "6", arg2: 6);
                context.SetConversation(arg1: 1, arg2: 190, arg3: "$02000334_BF__WAVE__2$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State4단계_타이머(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {150, 151}, arg2: false);
            }
        }

        private class State4단계_타이머 : TriggerState {
            internal State4단계_타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {90022}, arg2: true);
                context.SetTimer(arg1: "150", arg2: 150, arg4: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "150")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {190})) {
                    context.State = new State클리어(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {90022}, arg2: false);
            }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    152, 190, 991, 992, 993, 994, 995, 996, 997, 998
                });
                context.SetEventUI(arg1: 5, arg3: new int[] {3000});
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetEffect(arg1: new int[] {98031}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State게임오버_이벤트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임오버_이벤트 : TriggerState {
            internal State게임오버_이벤트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    152, 190, 991, 992, 993, 994, 995, 996, 997, 998
                });
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetConversation(arg1: 2, arg2: 24001205, arg3: "$02000334_BF__MAIN__13$", arg4: 3);
                context.SetSkip(arg1: "게임오버_강퇴");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State게임오버_강퇴(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State게임오버_강퇴 : TriggerState {
            internal State게임오버_강퇴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5, arg4: true);
                context.SetEventUI(arg1: 1, arg2: "$02000334_BF__MAIN__14$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State강퇴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강퇴 : TriggerState {
            internal State강퇴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0, arg3: 90001);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State클리어 : TriggerState {
            internal State클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 90001, arg2: "trigger", arg3: "TaboKill");
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    152, 991, 992, 993, 994, 995, 996, 997, 998
                });
                context.SetEffect(arg1: new int[] {98002}, arg2: true);
                context.SetEffect(arg1: new int[] {98003}, arg2: true);
                context.SetEffect(arg1: new int[] {98004}, arg2: true);
                context.SetEffect(arg1: new int[] {98005}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new int[] {98031}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State클리어_이벤트(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {98002}, arg2: false);
                context.SetEffect(arg1: new int[] {98003}, arg2: false);
                context.SetEffect(arg1: new int[] {98004}, arg2: false);
                context.SetEffect(arg1: new int[] {98005}, arg2: false);
            }
        }

        private class State클리어_이벤트 : TriggerState {
            internal State클리어_이벤트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 131, 132, 133, 134, 135, 150, 151,
                    152, 991, 992, 993, 994, 995, 996, 997, 998
                });
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$02000334_BF__MAIN__16$", arg4: 3);
                context.SetMesh(
                    arg1: new int[] {
                        6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015,
                        6016
                    }, arg2: false, arg4: 250, arg5: 1f);
                context.SetSkip(arg1: "클리어_보상");
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State클리어_보상(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State클리어_보상 : TriggerState {
            internal State클리어_보상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 103, textID: 40009);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_2015");
                context.SetTimer(arg1: "10", arg2: 10, arg4: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "90099")) {
                    context.State = new State클리어_보상_02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State클리어_보상_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 103);
            }
        }

        private class State클리어_보상_02 : TriggerState {
            internal State클리어_보상_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8003, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$02000334_BF__MAIN__18$", arg4: 3);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State클리어_보상_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State클리어_보상_03 : TriggerState {
            internal State클리어_보상_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000334_BF__MAIN__19$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.DungeonClear();
                    context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 103);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}