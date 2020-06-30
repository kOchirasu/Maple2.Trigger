using System;

namespace Maple2.Trigger._02010051_bf {
    public static class _portal03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {837}, arg2: false);
                context.SetMesh(arg1: new int[] {2000, 2001, 2002, 2003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2100, 2101, 2102, 2103, 2104, 2105}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {2200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        13001, 13002, 13003, 13004, 13005, 13006, 13007, 13008, 13009, 13010, 13011, 13012, 13013,
                        13014, 13015, 13016, 13017, 13018, 13019, 13020, 13021, 13022, 13023, 13024, 13025, 13026,
                        13027, 13028, 13029, 13030, 13031, 13032, 13033, 13034, 13035, 13036, 13037, 13038, 13039
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000837}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9012")) {
                    context.State = new State입장딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장딜레이01 : TriggerState {
            internal State입장딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetMesh(arg1: new int[] {2000, 2001, 2002, 2003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2100, 2101, 2102, 2103, 2104, 2105}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State가이드준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드준비01 : TriggerState {
            internal State가이드준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20105101, textID: 20105101, duration: 4000);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000837}, arg2: 0)) {
                    context.State = new State포털개방01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털개방01 : TriggerState {
            internal State포털개방01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7, key: "timercheck", value: 1);
                context.SetTimer(arg1: "10", arg2: 2);
                context.SetPortal(arg1: 50, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new int[] {6003}, arg2: true);
                context.SetEffect(arg1: new int[] {837}, arg2: true);
                context.SetRandomMesh(arg1: new int[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009},
                    arg2: true, arg3: 10, arg4: 50, arg5: 50);
                context.SetMesh(
                    arg1: new int[] {
                        13001, 13002, 13003, 13004, 13005, 13006, 13007, 13008, 13009, 13010, 13011, 13012, 13013,
                        13014, 13015, 13016, 13017, 13018, 13019, 13020, 13021, 13022, 13023, 13024, 13025, 13026,
                        13027, 13028, 13029, 13030, 13031, 13032, 13033, 13034, 13035, 13036, 13037, 13038, 13039
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2200}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State대화연출준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화연출준비01 : TriggerState {
            internal State대화연출준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출대화01 : TriggerState {
            internal State연출대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$02010051_BF__PORTAL03__0$", arg4: 3);
                context.SetSkip(arg1: "대화연출종료01");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State대화연출종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화연출종료01 : TriggerState {
            internal State대화연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}