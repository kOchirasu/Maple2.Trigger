using System;

namespace Maple2.Trigger._52000037_qd {
    public static class _lookinto_soulbinder_12 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: false, arg3: "Dead_A");
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10000175}, arg2: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {60100065}, arg3: new byte[] {2},
                    arg4: 110)) {
                    context.State = new State연출01조건(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {60100065}, arg3: new byte[] {3},
                    arg4: 110)) {
                    context.State = new StateNPC만배치(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC만배치 : TriggerState {
            internal StateNPC만배치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000175}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출01조건 : TriggerState {
            internal State연출01조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000175}, arg2: 1);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9300}, arg2: new int[] {60100065}, arg3: new byte[] {2},
                    arg4: 110)) {
                    context.State = new State연출01시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출01시작 : TriggerState {
            internal State연출01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000037, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_PC1101A");
                    context.State = new StatePC말풍선01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__LOOKINTO_SOULBINDER_12__0$", arg4: 2,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC말풍선02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__LOOKINTO_SOULBINDER_12__1$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC말풍선03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선03 : TriggerState {
            internal StatePC말풍선03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__LOOKINTO_SOULBINDER_12__2$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC말풍선04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선04 : TriggerState {
            internal StatePC말풍선04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__LOOKINTO_SOULBINDER_12__3$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC말풍선05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선05 : TriggerState {
            internal StatePC말풍선05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__LOOKINTO_SOULBINDER_12__4$", arg4: 5,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State강제이동02조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동02조건 : TriggerState {
            internal State강제이동02조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9301}, arg2: new int[] {60100065}, arg3: new byte[] {2},
                    arg4: 110)) {
                    context.State = new StatePC말풍선07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선07 : TriggerState {
            internal StatePC말풍선07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__LOOKINTO_SOULBINDER_12__5$", arg4: 2,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State강제이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동02 : TriggerState {
            internal State강제이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC1101B");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9302}, arg2: new int[] {60100065}, arg3: new byte[] {2},
                    arg4: 110)) {
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
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
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