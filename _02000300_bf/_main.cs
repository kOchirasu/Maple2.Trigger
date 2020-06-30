using System;

namespace Maple2.Trigger._02000300_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000585}, arg2: 0);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003, 3004, 3005}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004}, arg2: false);
                context.CreateMonster(arg1: new int[] {1099}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State연출시작딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
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
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State트리스탄01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄01 : TriggerState {
            internal State트리스탄01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11000144, arg3: "$02000300_BF__MAIN__0$", arg4: 4);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {301}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State완료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료체크 : TriggerState {
            internal State완료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State또다른연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State또다른연출시작 : TriggerState {
            internal State또다른연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State트리스탄마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리스탄마무리 : TriggerState {
            internal State트리스탄마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11000144, arg3: "$02000300_BF__MAIN__1$", arg4: 4);
                context.SetSkip(arg1: "또다른연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State또다른연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State또다른연출종료 : TriggerState {
            internal State또다른연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State이동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동대기 : TriggerState {
            internal State이동대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000585}, arg2: 1);
                context.ShowGuideSummary(entityID: 20002999, textID: 20002999);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000585}, arg2: 0)) {
                    context.HideGuideSummary(entityID: 20002999);
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
                context.ShowCountUI(text: "$02000300_BF__MAIN__3$", stage: 1, count: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.MoveUser(arg1: 02000299, arg2: 2, arg3: 101);
                    context.State = new State이동대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}