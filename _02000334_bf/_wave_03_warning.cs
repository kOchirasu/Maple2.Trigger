using System;

namespace Maple2.Trigger._02000334_bf {
    public static class _wave_03_warning {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90099, arg2: new int[] {152})) {
                    context.State = new State1차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
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
                context.SetConversation(arg1: 1, arg2: 190, arg3: "$02000334_BF__WAVE__6$", arg4: 3);
                context.CreateMonster(arg1: new int[] {991, 996}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State카메라_복구(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_복구 : TriggerState {
            internal State카메라_복구(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98006}, arg2: true);
                context.AddBuff(arg1: new int[] {90001}, arg2: 70000068, arg3: 1);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_3502");
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000334_BF__WAVE__7$", arg4: 3);
                context.SetTimer(arg1: "10", arg2: 10);
                context.CameraSelectPath(arg1: new int[] {8017}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State돌격2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌격2 : TriggerState {
            internal State돌격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98001}, arg2: true);
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_3501");
                context.SetConversation(arg1: 1, arg2: 190, arg3: "$02000334_BF__WAVE__8$", arg4: 3);
                context.CreateMonster(arg1: new int[] {992, 995, 997}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State카메라_복구2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_복구2 : TriggerState {
            internal State카메라_복구2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98006}, arg2: true);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_3502");
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000334_BF__WAVE__9$", arg4: 3);
                context.AddBuff(arg1: new int[] {90001}, arg2: 70000068, arg3: 1);
                context.SetTimer(arg1: "10", arg2: 10);
                context.CameraSelectPath(arg1: new int[] {8017}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State돌격3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌격3 : TriggerState {
            internal State돌격3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98001}, arg2: true);
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_3501");
                context.SetConversation(arg1: 1, arg2: 190, arg3: "$02000334_BF__WAVE__10$", arg4: 3);
                context.CreateMonster(arg1: new int[] {993, 994, 996}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State카메라_복구3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_복구3 : TriggerState {
            internal State카메라_복구3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {98006}, arg2: true);
                context.AddBuff(arg1: new int[] {90001}, arg2: 70000068, arg3: 1);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_3502");
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000334_BF__WAVE__11$", arg4: 3);
                context.CameraSelectPath(arg1: new int[] {8017}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}