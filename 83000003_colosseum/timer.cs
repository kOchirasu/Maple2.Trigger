namespace Maple2.Trigger._83000003_colosseum {
    public static class _timer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Timer") == 1) {
                    return new StateStage1(context);
                }

                if (context.GetUserValue(key: "Timer") == 2) {
                    return new StateStage2(context);
                }

                if (context.GetUserValue(key: "Timer") == 3) {
                    return new StateStage3(context);
                }

                if (context.GetUserValue(key: "Timer") == 4) {
                    return new StateStage4(context);
                }

                if (context.GetUserValue(key: "Timer") == 5) {
                    return new StateStage5(context);
                }

                if (context.GetUserValue(key: "Timer") == 6) {
                    return new StateStage6(context);
                }

                if (context.GetUserValue(key: "Timer") == 7) {
                    return new StateStage7(context);
                }

                if (context.GetUserValue(key: "Timer") == 8) {
                    return new StateStage8(context);
                }

                if (context.GetUserValue(key: "Timer") == 9) {
                    return new StateStage9(context);
                }

                if (context.GetUserValue(key: "Timer") == 10) {
                    return new StateStage10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1 : TriggerState {
            internal StateStage1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer", arg2: 180, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크1(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크1 : TriggerState {
            internal State타이머체크1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SetUserValue(triggerId: 900001, key: "Fail", value: 1);
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2 : TriggerState {
            internal StateStage2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer2", arg2: 180, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크2(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크2 : TriggerState {
            internal State타이머체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SetUserValue(triggerId: 900001, key: "Fail", value: 1);
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {102})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3 : TriggerState {
            internal StateStage3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer3", arg2: 180, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크3(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크3 : TriggerState {
            internal State타이머체크3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    context.SetUserValue(triggerId: 900001, key: "Fail", value: 1);
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {103})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4 : TriggerState {
            internal StateStage4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer4", arg2: 180, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크4(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크4 : TriggerState {
            internal State타이머체크4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {104})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5 : TriggerState {
            internal StateStage5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer5", arg2: 180, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크5(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크5 : TriggerState {
            internal State타이머체크5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {105})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6 : TriggerState {
            internal StateStage6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer6", arg2: 180, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크6(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크6 : TriggerState {
            internal State타이머체크6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage7 : TriggerState {
            internal StateStage7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer7", arg2: 180, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크7(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크7 : TriggerState {
            internal State타이머체크7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {107})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage8 : TriggerState {
            internal StateStage8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer8", arg2: 300, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크8(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크8 : TriggerState {
            internal State타이머체크8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {108})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage9 : TriggerState {
            internal StateStage9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer9", arg2: 300, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크9(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크9 : TriggerState {
            internal State타이머체크9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {109})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage10 : TriggerState {
            internal StateStage10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "LimitTimer10", arg2: 300, arg3: true);
            }

            public override TriggerState Execute() {
                return new State타이머체크10(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크10 : TriggerState {
            internal State타이머체크10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "LimitTimer")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {110})) {
                    context.SetUserValue(triggerId: 900001, key: "Nextmonster", value: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "LimitTimer");
                context.ResetTimer(id: "LimitTimer2");
                context.ResetTimer(id: "LimitTimer3");
                context.ResetTimer(id: "LimitTimer4");
                context.ResetTimer(id: "LimitTimer5");
                context.ResetTimer(id: "LimitTimer6");
                context.ResetTimer(id: "LimitTimer7");
                context.ResetTimer(id: "LimitTimer8");
                context.ResetTimer(id: "LimitTimer9");
                context.ResetTimer(id: "LimitTimer10");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}