using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _pato {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new int[] {1299})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {103}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {1601}, arg2: false);
                context.CreateMonster(arg1: new int[] {1602}, arg2: false);
                context.CreateMonster(arg1: new int[] {1603}, arg2: false);
                context.CreateMonster(arg1: new int[] {1604}, arg2: false);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State연출진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출진행 : TriggerState {
            internal State연출진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__PATO__0$", arg4: 2);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2429)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 103, arg2: 70000107);
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}