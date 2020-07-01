using System;

namespace Maple2.Trigger._02010051_bf {
    public static class _portal01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {835}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetMesh(arg1: new int[] {1101, 1102, 1103, 1104, 1105, 1106}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013,
                        11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026,
                        11027, 11028
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000835}, arg2: 1);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9010})) {
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
                context.ShowGuideSummary(entityID: 20105101, textID: 20105101, duration: 4000);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000835}, arg2: 0)) {
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
                context.SetEffect(arg1: new int[] {835}, arg2: true);
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
                context.SetMesh(arg1: new int[] {1101, 1102, 1103, 1104, 1105, 1106}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 10f);
                context.SetMesh(
                    arg1: new int[] {
                        11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013,
                        11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026,
                        11027, 11028
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
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 21, arg2: true, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000836}, arg2: 0)) {
                    context.State = new State포털폐쇄(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털폐쇄 : TriggerState {
            internal State포털폐쇄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {1101, 1102, 1103, 1104, 1105, 1106}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 2f);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}