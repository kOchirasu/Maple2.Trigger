using System;

namespace Maple2.Trigger._52000037_qd {
    public static class _runaway_soulbinder_13 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9400}, arg2: new int[] {50001411}, arg3: new byte[] {2},
                    arg4: 110)) {
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
                context.CameraSelect(arg1: 603, arg2: true);
                context.MoveUser(arg1: 52000037, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new StatePC말풍선딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선딜레이 : TriggerState {
            internal StatePC말풍선딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_PC1102A");
                    context.State = new StatePC말풍선01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__0$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC말풍선02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__1$", arg4: 3,
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
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__2$", arg4: 4,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State말풍선딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선딜레이 : TriggerState {
            internal State말풍선딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_PC1102B");
                    context.State = new StatePC말풍선04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선04 : TriggerState {
            internal StatePC말풍선04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__3$", arg4: 4,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePC말풍선05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선05 : TriggerState {
            internal StatePC말풍선05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__4$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNPC등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC등장 : TriggerState {
            internal StateNPC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {211, 212, 213}, arg2: false);
                context.CameraSelect(arg1: 604, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNPC대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001727, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__5$",
                    arg4: 2);
                context.SetSkip(arg1: "NPC대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNPC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01스킵 : TriggerState {
            internal StateNPC대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001725, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__6$",
                    arg4: 2);
                context.SetSkip(arg1: "NPC대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC도주(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02스킵 : TriggerState {
            internal StateNPC대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StatePC도주(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC도주 : TriggerState {
            internal StatePC도주(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.CameraSelect(arg1: 605, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PC1102C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePC말풍선06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선06 : TriggerState {
            internal StatePC말풍선06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 211, arg2: "MS2PatrolData_NPC1102");
                context.MoveNpc(arg1: 212, arg2: "MS2PatrolData_NPC1102");
                context.MoveNpc(arg1: 213, arg2: "MS2PatrolData_NPC1102");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000037_QD__RUNAWAY_SOULBINDER_13__7$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000043, arg2: 5);
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