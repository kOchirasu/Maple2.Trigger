namespace Maple2.Trigger._63000092_cs {
    public static class _bridge {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.DayOfWeek(dayOfWeeks: new byte[] {1}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4023, 4024}, arg2: false);
                    context.SetMesh(arg1: new[] {4021, 4022, 4025, 4026, 4027, 4030}, arg2: true);
                    return new State일요일(context);
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {2}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4024}, arg2: false);
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4025, 4026, 4027, 4030}, arg2: true);
                    return new State월요일(context);
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {3}, desc: "화요일")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4025, 4026, 4027}, arg2: true);
                    context.SetMesh(arg1: new[] {4030}, arg2: false); // 바운딩 메쉬를 끈다
                    return new State화요일(context);
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {4}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4026, 4027}, arg2: false);
                    context.SetMesh(arg1: new[] {4025, 4030}, arg2: true);
                    return new State수요일(context);
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {5}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4027}, arg2: false);
                    context.SetMesh(arg1: new[] {4025, 4026, 4030}, arg2: true);
                    return new State목요일(context);
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {6}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4021, 4022, 4023, 4024, 4025, 4026}, arg2: false);
                    context.SetMesh(arg1: new[] {4025, 4026, 4027, 4030}, arg2: true);
                    return new State금요일(context);
                }

                if (context.DayOfWeek(dayOfWeeks: new byte[] {7}, desc: "1(일)-7(토)")) {
                    context.SetMesh(arg1: new[] {4022, 4023, 4024}, arg2: false);
                    context.SetMesh(arg1: new[] {4021, 4025, 4026, 4027, 4030}, arg2: true);
                    return new State토요일(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일요일 : TriggerState {
            internal State일요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {1}, desc: "1(일)-7(토)")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State월요일 : TriggerState {
            internal State월요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {2}, desc: "1(일)-7(토)")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화요일 : TriggerState {
            internal State화요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {3}, desc: "1(일)-7(토)")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수요일 : TriggerState {
            internal State수요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {4}, desc: "1(일)-7(토)")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State목요일 : TriggerState {
            internal State목요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {5}, desc: "1(일)-7(토)")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State금요일 : TriggerState {
            internal State금요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {6}, desc: "1(일)-7(토)")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State토요일 : TriggerState {
            internal State토요일(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.DayOfWeek(dayOfWeeks: new byte[] {7}, desc: "1(일)-7(토)")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}