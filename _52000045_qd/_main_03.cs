using System;

namespace Maple2.Trigger._52000045_qd {
    public static class _main_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001, 1002, 2001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {10003042},
                    arg3: new byte[] {2})) {
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
                context.AddBuff(arg1: new int[] {199}, arg2: 70000095, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State자베스대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자베스대사01 : TriggerState {
            internal State자베스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000045_QD__MAIN_03__0$", arg4: 3);
                context.SetSkip(arg1: "자베스대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State브라보대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자베스대사01스킵 : TriggerState {
            internal State자베스대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State브라보대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State브라보대사01 : TriggerState {
            internal State브라보대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000045_QD__MAIN_03__1$", arg4: 3);
                context.SetSkip(arg1: "브라보대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State제이시대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State브라보대사01스킵 : TriggerState {
            internal State브라보대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State제이시대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제이시대사01 : TriggerState {
            internal State제이시대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000515, arg3: "$52000045_QD__MAIN_03__2$", arg4: 5);
                context.SetSkip(arg1: "제이시대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출종료(context);
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
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2001});
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.AddBuff(arg1: new int[] {199}, arg2: 70000096, arg3: 1);
                context.MoveUser(arg1: 52000046, arg2: 2);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_9000");
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