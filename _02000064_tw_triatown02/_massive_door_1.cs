namespace Maple2.Trigger._02000064_tw_triatown02 {
    public static class _massive_door_1 {
        public class State오픈대기중 : TriggerState {
            internal State오픈대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {11, 12, 13}, arg2: true);
                context.SetActor(arg1: 1, arg2: true, arg3: "Eff_MassiveEvent_Bridge_Opened");
                context.SetActor(arg1: 2, arg2: true, arg3: "Eff_MassiveEvent_Bridge_Opened");
                context.SetActor(arg1: 3, arg2: true, arg3: "Eff_MassiveEvent_Door_Closed");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State오픈중1 : TriggerState {
            internal State오픈중1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State오픈중2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State오픈중2 : TriggerState {
            internal State오픈중2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State클로즈대기중(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "2");
                context.SetActor(arg1: 3, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
            }
        }

        private class State클로즈대기중 : TriggerState {
            internal State클로즈대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 114);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State클로즈5초전(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "3");
            }
        }

        private class State클로즈5초전 : TriggerState {
            internal State클로즈5초전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.Notice(arg1: false, arg2: "$02000064_TW_Triatown02__MASSIVE_DOOR_1__0$", arg3: true);
                context.SetTimer(arg1: "4", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State클로즈중1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "4");
                context.SetActor(arg1: 3, arg2: true, arg3: "Eff_MassiveEvent_Door_Closed");
            }
        }

        private class State클로즈중1 : TriggerState {
            internal State클로즈중1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State클로즈중2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "5");
            }
        }

        private class State클로즈중2 : TriggerState {
            internal State클로즈중2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.Notice(arg1: false, arg2: "$02000064_TW_Triatown02__MASSIVE_DOOR_1__1$", arg3: true);
                context.SetTimer(arg1: "6", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State오픈대기중(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "6");
            }
        }
    }
}