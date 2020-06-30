using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010070_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 800, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {699}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718,
                        719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7004}, arg2: false);
                context.SetEffect(arg1: new int[] {7000}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
                context.SetEffect(arg1: new int[] {7011}, arg2: false);
                context.SetEffect(arg1: new int[] {7012}, arg2: false);
                context.DestroyMonster(arg1: new int[] {22201, 22202, 22203, 22204});
                context.DestroyMonster(arg1: new int[] {1000, 1001, 1002, 1003, 1004, 1005, 1006});
                context.SetEffect(arg1: new int[] {95222}, arg2: false);
                context.CreateMonster(arg1: new int[] {1007, 1008}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.SetActor(arg1: 800, arg2: true, arg3: "Opend");
                context.SetMesh(arg1: new int[] {699}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGateOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGateOpen : TriggerState {
            internal StateGateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 800, arg2: false, arg3: "Opend");
                context.SetRandomMesh(
                    arg1: new int[] {
                        700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718,
                        719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737
                    }, arg2: false, arg3: 38, arg4: 50, arg5: 2);
                context.SetEffect(arg1: new int[] {7010}, arg2: true);
                context.SetEffect(arg1: new int[] {7011}, arg2: true);
                context.SetEffect(arg1: new int[] {7012}, arg2: true);
                context.CreateMonster(arg1: new int[] {22201, 22202, 22203, 22204}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20100701, textID: 20100701, durationTime: 5000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "999992")) {
                    context.State = new State시작1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작1 : TriggerState {
            internal State시작1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {95222}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02010070_BF__MAIN__3$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작2 : TriggerState {
            internal State시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1007, 1008});
                context.CreateMonster(arg1: new int[] {1000, 1001, 1002}, arg2: true);
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
                context.SetEffect(arg1: new int[] {7011}, arg2: false);
                context.SetEffect(arg1: new int[] {7012}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20100702, textID: 20100702, durationTime: 7000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1000, 1001, 1002})) {
                    context.State = new State시작3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작3 : TriggerState {
            internal State시작3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1003, 1004, 1005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State시작4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작4 : TriggerState {
            internal State시작4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1006}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1003, 1004, 1005, 1006})) {
                    context.State = new State시간1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시간1 : TriggerState {
            internal State시간1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "150", arg2: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시작5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작5 : TriggerState {
            internal State시작5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(arg1: new int[] {7001}, arg2: true);
                    context.SetSkill(arg1: new int[] {7004}, arg2: true);
                    context.State = new State시작6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작6 : TriggerState {
            internal State시작6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 6);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUser(arg1: 02010070, arg2: 3);
                    context.State = new State시작7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작7 : TriggerState {
            internal State시작7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작8 : TriggerState {
            internal State시작8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}