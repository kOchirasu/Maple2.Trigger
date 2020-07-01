namespace Maple2.Trigger._63000092_cs {
    public static class _bridge {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DayOfWeek(dayOfWeeks: new byte[] {1}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4023, 4024}, arg2: false);
                    context.SetMesh(arg1: new[] {4021, 4022, 4025, 4026, 4027}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: true);
                    context.State = new State일요일(context);
                    return;
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {2}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4024}, arg2: false);
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4025, 4026, 4027}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: true);
                    context.State = new State월요일(context);
                    return;
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {3}, desc: "화요일")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4025, 4026, 4027}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: false); // 바운딩 메쉬를 끈다
                    context.State = new State화요일(context);
                    return;
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {4}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4026, 4027}, arg2: false);
                    context.SetMesh(arg1: new[] {4025}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: true);
                    context.State = new State수요일(context);
                    return;
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {5}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4027}, arg2: false);
                    context.SetMesh(arg1: new[] {4025, 4026}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: true);
                    context.State = new State목요일(context);
                    return;
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {6}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4025, 4026}, arg2: false);
                    context.SetMesh(arg1: new[] {4025, 4026, 4027}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: true);
                    context.State = new State금요일(context);
                    return;
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {7}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4022, 4023, 4024}, arg2: false);
                    context.SetMesh(arg1: new[] {4021, 4025, 4026, 4027}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: true);
                    context.State = new State토요일(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일요일 : TriggerState {
            internal State일요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {1}, desc: "1(일)-7(토)")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State월요일 : TriggerState {
            internal State월요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {2}, desc: "1(일)-7(토)")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화요일 : TriggerState {
            internal State화요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {3}, desc: "1(일)-7(토)")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수요일 : TriggerState {
            internal State수요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {4}, desc: "1(일)-7(토)")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목요일 : TriggerState {
            internal State목요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {5}, desc: "1(일)-7(토)")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State금요일 : TriggerState {
            internal State금요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {6}, desc: "1(일)-7(토)")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State토요일 : TriggerState {
            internal State토요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {7}, desc: "1(일)-7(토)")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}