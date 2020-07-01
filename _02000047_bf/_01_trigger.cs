namespace Maple2.Trigger._02000047_bf {
    public static class _01_trigger {
        public class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000084, 10000085}, arg2: 1);
                context.SetMesh(arg1: new[] {10, 11, 12, 13, 14, 15, 16, 17}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000084, 10000085}, arg2: 0)) {
                    return new State다리생성1011(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리생성1011 : TriggerState {
            internal State다리생성1011(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10, 11}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State다리생성1213(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리생성1213 : TriggerState {
            internal State다리생성1213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {12, 13}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State다리생성1415(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리생성1415 : TriggerState {
            internal State다리생성1415(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {14, 15}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State다리생성1617(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리생성1617 : TriggerState {
            internal State다리생성1617(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {16, 17}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State다리제거(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리제거 : TriggerState {
            internal State다리제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.SetMesh(arg1: new[] {10, 11, 12, 13, 14, 15, 16, 17}, arg2: false);
                    return new State트리거초기화2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거초기화2 : TriggerState {
            internal State트리거초기화2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}