using System;

namespace Maple2.Trigger._02000334_bf {
    public static class _wave_01_warning {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90099, arg2: new int[] {150})) {
                    context.State = new State1차타이머(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State돌격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌격 : TriggerState {
            internal State돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98001}, arg2: true);
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_3501");
                context.SetConversation(arg1: 1, arg2: 190, arg3: "$02000334_BF__WAVE__0$", arg4: 3);
                context.CreateMonster(arg1: new int[] {991, 992, 993}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State카메라복구(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라복구 : TriggerState {
            internal State카메라복구(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98006}, arg2: true);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_3502");
                context.AddBuff(arg1: new int[] {90001}, arg2: 70000068, arg3: 1);
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000334_BF__WAVE__1$", arg4: 3);
                context.CameraSelectPath(arg1: new int[] {8017}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}