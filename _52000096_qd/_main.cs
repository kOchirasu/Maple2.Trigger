using System;

namespace Maple2.Trigger._52000096_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001514},
                    arg3: new byte[] {1})) {
                    context.State = new State몹소환01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50100040},
                    arg3: new byte[] {1})) {
                    context.State = new State몹소환01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹소환01 : TriggerState {
            internal State몹소환01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: false);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State위협당함01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위협당함01 : TriggerState {
            internal State위협당함01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52000096_QD__MAIN__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State위협당함02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위협당함02 : TriggerState {
            internal State위협당함02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$52000096_QD__MAIN__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State위협당함03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위협당함03 : TriggerState {
            internal State위협당함03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52000096_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State위협당함04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위협당함04 : TriggerState {
            internal State위협당함04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$52000096_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시점이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시점이동 : TriggerState {
            internal State시점이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State경로이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경로이동 : TriggerState {
            internal State경로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000096_QD__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몹말풍선01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹말풍선01 : TriggerState {
            internal State몹말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$52000096_QD__MAIN__5$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC_01");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터재스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터재스폰 : TriggerState {
            internal State몬스터재스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001}, arg2: true);
                context.CreateMonster(arg1: new int[] {1002}, arg2: true);
                context.CreateMonster(arg1: new int[] {1003}, arg2: true);
                context.CreateMonster(arg1: new int[] {1004}, arg2: true);
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