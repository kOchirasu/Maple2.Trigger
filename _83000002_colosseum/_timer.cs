namespace Maple2.Trigger._83000002_colosseum {
    public static class _timer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Timer") == 1) {
                    context.State = new State스테이지1(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 2) {
                    context.State = new State스테이지2(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 3) {
                    context.State = new State스테이지3(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 4) {
                    context.State = new State스테이지4(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 5) {
                    context.State = new State스테이지5(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 6) {
                    context.State = new State스테이지6(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 7) {
                    context.State = new State스테이지7(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 8) {
                    context.State = new State스테이지8(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 9) {
                    context.State = new State스테이지9(context);
                    return;
                }

                if (context.GetUserValue(key: "Timer") == 10) {
                    context.State = new State스테이지10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지1 : TriggerState {
            internal State스테이지1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer", arg2: 180, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크1 : TriggerState {
            internal State타이머체크1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SetUserValue(triggerId: 900001, key: "Fail", value: 1);
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지2 : TriggerState {
            internal State스테이지2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer2", arg2: 180, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크2 : TriggerState {
            internal State타이머체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SetUserValue(triggerId: 900001, key: "Fail", value: 1);
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {102})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3 : TriggerState {
            internal State스테이지3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer3", arg2: 180, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크3 : TriggerState {
            internal State타이머체크3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SetUserValue(triggerId: 900001, key: "Fail", value: 1);
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {103})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지4 : TriggerState {
            internal State스테이지4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer4", arg2: 180, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크4 : TriggerState {
            internal State타이머체크4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {104})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지5 : TriggerState {
            internal State스테이지5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer5", arg2: 180, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크5 : TriggerState {
            internal State타이머체크5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {105})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지6 : TriggerState {
            internal State스테이지6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer6", arg2: 180, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크6 : TriggerState {
            internal State타이머체크6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지7 : TriggerState {
            internal State스테이지7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer7", arg2: 180, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크7 : TriggerState {
            internal State타이머체크7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {107})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지8 : TriggerState {
            internal State스테이지8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer8", arg2: 300, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크8 : TriggerState {
            internal State타이머체크8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {108})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지9 : TriggerState {
            internal State스테이지9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer9", arg2: 300, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크9 : TriggerState {
            internal State타이머체크9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {109})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지10 : TriggerState {
            internal State스테이지10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "LimitTimer10", arg2: 300, arg3: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State타이머체크10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머체크10 : TriggerState {
            internal State타이머체크10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {110})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "LimitTimer");
                context.ResetTimer(arg1: "LimitTimer2");
                context.ResetTimer(arg1: "LimitTimer3");
                context.ResetTimer(arg1: "LimitTimer4");
                context.ResetTimer(arg1: "LimitTimer5");
                context.ResetTimer(arg1: "LimitTimer6");
                context.ResetTimer(arg1: "LimitTimer7");
                context.ResetTimer(arg1: "LimitTimer8");
                context.ResetTimer(arg1: "LimitTimer9");
                context.ResetTimer(arg1: "LimitTimer10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}