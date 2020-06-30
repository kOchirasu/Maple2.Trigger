using System;

namespace Maple2.Trigger._52010068_qd {
    public static class _act01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000074},
                    arg3: new byte[] {2})) {
                    context.State = new StateNPC리젠03_담당관과트리스탄_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000050},
                    arg3: new byte[] {2})) {
                    context.State = new StateNPC리젠02_담당관과트리스탄(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000037},
                    arg3: new byte[] {2})) {
                    context.State = new StateNPC리젠01_5대세력담당관(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000075},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000074},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC리젠03_담당관과트리스탄_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000063},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC리젠01_5대세력담당관(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000058},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000057},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC리젠01_5대세력담당관(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000050},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC리젠02_담당관과트리스탄(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000043},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC리젠03_트리스탄솔로(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000049},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC리젠02_담당관과트리스탄(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000046},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC리젠01_5대세력담당관(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000019},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠03_트리스탄솔로 : TriggerState {
            internal StateNPC리젠03_트리스탄솔로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠01_5대세력담당관 : TriggerState {
            internal StateNPC리젠01_5대세력담당관(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.CreateMonster(arg1: new int[] {2004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠02_담당관과트리스탄 : TriggerState {
            internal StateNPC리젠02_담당관과트리스탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.CreateMonster(arg1: new int[] {2004}, arg2: false);
                context.CreateMonster(arg1: new int[] {2005}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000057},
                    arg3: new byte[] {3})) {
                    context.State = new State트리스탄삐짐01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄삐짐01 : TriggerState {
            internal State트리스탄삐짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003790, illustID: "Tristan_normal", msg: "$52010052_QD__ACT01__0$",
                    duration: 4000);
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State트리스탄삐짐02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄삐짐02 : TriggerState {
            internal State트리스탄삐짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {2005});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC리젠03_담당관과트리스탄_02 : TriggerState {
            internal StateNPC리젠03_담당관과트리스탄_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.CreateMonster(arg1: new int[] {2004}, arg2: false);
                context.CreateMonster(arg1: new int[] {2005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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