using System;

namespace Maple2.Trigger._52000044_qd {
    public static class _10003040 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000390}, arg2: 0);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {10003042},
                    arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new int[] {1001});
                    context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                    context.State = new State오브젝트반응대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {10003041},
                    arg3: new byte[] {3})) {
                    context.DestroyMonster(arg1: new int[] {1001});
                    context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                    context.State = new State오브젝트반응조건(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {10003041},
                    arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new int[] {1001});
                    context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                    context.State = new State오브젝트반응조건(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {103}, arg2: new int[] {10003041},
                    arg3: new byte[] {1})) {
                    context.State = new State연출시작02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {10003041},
                    arg3: new byte[] {1})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.DestroyMonster(arg1: new int[] {1001});
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.CreateMonster(arg1: new int[] {2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State말풍선대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작02 : TriggerState {
            internal State연출시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1001});
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.CreateMonster(arg1: new int[] {2001, 2002, 2003, 2004, 2005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State1차전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사01 : TriggerState {
            internal State말풍선대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000044_QD__10003040__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State말풍선대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선대사02 : TriggerState {
            internal State말풍선대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData_2005");
                context.SetConversation(arg1: 1, arg2: 2003, arg3: "$52000044_QD__10003040__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State제이시대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이시대사01 : TriggerState {
            internal State제이시대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000515, arg3: "$52000044_QD__10003040__2$", arg4: 2);
                context.SetSkip(arg1: "제이시대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State제이시대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이시대사01스킵 : TriggerState {
            internal State제이시대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State제이시대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이시대사02 : TriggerState {
            internal State제이시대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000515, arg3: "$52000044_QD__10003040__3$", arg4: 4);
                context.SetSkip(arg1: "제이시대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이시대사02스킵 : TriggerState {
            internal State제이시대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State1차전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작 : TriggerState {
            internal State1차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25200441, textID: 25200441, duration: 4000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001, 2002, 2003, 2004, 2005})) {
                    context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002B");
                    context.State = new State2차전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작 : TriggerState {
            internal State2차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2006}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2006})) {
                    context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002C");
                    context.State = new StateNPC감지대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC감지대기 : TriggerState {
            internal StateNPC감지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new int[] {1002})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "EscapewithJacy");
                    context.DestroyMonster(arg1: new int[] {1002});
                    context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                    context.State = new State오브젝트반응조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응조건 : TriggerState {
            internal State오브젝트반응조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {10003042},
                    arg3: new byte[] {1})) {
                    context.State = new State오브젝트반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응대기 : TriggerState {
            internal State오브젝트반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000390}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000390}, arg2: 0)) {
                    context.MoveUser(arg1: 52000045, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}