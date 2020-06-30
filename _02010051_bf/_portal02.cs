using System;

namespace Maple2.Trigger._02010051_bf {
    public static class _portal02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 30, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 31, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {836}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetMesh(arg1: new int[] {1201, 1202, 1203, 1204, 1205, 1206}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        12001, 12002, 12003, 12004, 12005, 12006, 12007, 12008, 12009, 12010, 12011, 12012, 12013,
                        12014, 12015, 12016, 12017, 12018, 12019, 12020, 12021, 12022, 12023, 12024, 12025, 12026,
                        12027, 12028
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000836}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9011")) {
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
                context.ShowGuideSummary(entityID: 20105101, textID: 20105101, durationTime: 4000);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000836}, arg2: 0)) {
                    context.State = new State포털개방01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털개방01 : TriggerState {
            internal State포털개방01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.SetEffect(arg1: new int[] {836}, arg2: true);
                context.SetEffect(arg1: new int[] {6002}, arg2: true);
                context.SetMesh(arg1: new int[] {1201, 1202, 1203, 1204, 1205, 1206}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 10f);
                context.SetMesh(
                    arg1: new int[] {
                        12001, 12002, 12003, 12004, 12005, 12006, 12007, 12008, 12009, 12010, 12011, 12012, 12013,
                        12014, 12015, 12016, 12017, 12018, 12019, 12020, 12021, 12022, 12023, 12024, 12025, 12026,
                        12027, 12028
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State포털개방02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털개방02 : TriggerState {
            internal State포털개방02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 30, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 31, arg2: true, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000837}, arg2: 0)) {
                    context.State = new State포털폐쇄(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털폐쇄 : TriggerState {
            internal State포털폐쇄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 30, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 31, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {1201, 1202, 1203, 1204, 1205, 1206}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 2f);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}