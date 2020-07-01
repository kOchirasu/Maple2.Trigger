using System;

namespace Maple2.Trigger._99999950 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetEventUI(arg1: 1, arg2: "$99999950__MAIN__0$", arg3: new int[] {2000}, arg4: "0");
                    context.State = new State1라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드 : TriggerState {
            internal State1라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101001}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101001})) {
                    context.State = new State1라운드02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드02 : TriggerState {
            internal State1라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101001}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101001})) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드대기 : TriggerState {
            internal State2라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetEventUI(arg1: 1, arg2: "$99999950__MAIN__1$", arg3: new int[] {2000}, arg4: "0");
                    context.State = new State2라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드 : TriggerState {
            internal State2라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101002}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101002})) {
                    context.State = new State2라운드02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드02 : TriggerState {
            internal State2라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101002}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101002})) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드대기 : TriggerState {
            internal State3라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetEventUI(arg1: 1, arg2: "$99999950__MAIN__2$", arg3: new int[] {2000}, arg4: "0");
                    context.State = new State3라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드 : TriggerState {
            internal State3라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101003}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101003})) {
                    context.State = new State3라운드02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드02 : TriggerState {
            internal State3라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101003}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101003})) {
                    context.State = new State4라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드대기 : TriggerState {
            internal State4라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetEventUI(arg1: 1, arg2: "$99999950__MAIN__3$", arg3: new int[] {2000}, arg4: "0");
                    context.State = new State4라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드 : TriggerState {
            internal State4라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101004}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101004})) {
                    context.State = new State4라운드02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드02 : TriggerState {
            internal State4라운드02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101004}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101004})) {
                    context.State = new State4라운드03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드03 : TriggerState {
            internal State4라운드03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101004}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101004})) {
                    context.State = new State5라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5라운드대기 : TriggerState {
            internal State5라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetEventUI(arg1: 1, arg2: "$99999950__MAIN__4$", arg3: new int[] {2000}, arg4: "0");
                    context.State = new State5라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5라운드 : TriggerState {
            internal State5라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101005}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101005})) {
                    // context.State = new State6라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}