using System;

namespace Maple2.Trigger._52100022_qd {
    public static class _1122330_move {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215,
                        3216, 3217, 3218, 3219, 3220, 3221
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetAgent(arg1: "8009", arg2: true);
                context.SetAgent(arg1: "8010", arg2: true);
                context.SetAgent(arg1: "8011", arg2: true);
                context.SetAgent(arg1: "8012", arg2: true);
                context.SetAgent(arg1: "8013", arg2: true);
                context.SetAgent(arg1: "8014", arg2: true);
                context.SetAgent(arg1: "8015", arg2: true);
                context.SetAgent(arg1: "8016", arg2: true);
                context.SetAgent(arg1: "8017", arg2: true);
                context.SetAgent(arg1: "8018", arg2: true);
                context.SetAgent(arg1: "8019", arg2: true);
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetBreakable(arg1: new int[] {4001}, arg2: false);
                context.SetBreakable(arg1: new int[] {4002}, arg2: false);
                context.SetBreakable(arg1: new int[] {4003}, arg2: false);
                context.SetBreakable(arg1: new int[] {4004}, arg2: false);
                context.SetBreakable(arg1: new int[] {4005}, arg2: false);
                context.SetBreakable(arg1: new int[] {4006}, arg2: false);
                context.SetBreakable(arg1: new int[] {4007}, arg2: false);
                context.SetBreakable(arg1: new int[] {4008}, arg2: false);
                context.SetBreakable(arg1: new int[] {4009}, arg2: false);
                context.SetBreakable(arg1: new int[] {4010}, arg2: false);
                context.SetBreakable(arg1: new int[] {4011}, arg2: false);
                context.SetBreakable(arg1: new int[] {4012}, arg2: false);
                context.SetBreakable(arg1: new int[] {4013}, arg2: false);
                context.SetBreakable(arg1: new int[] {4014}, arg2: false);
                context.SetBreakable(arg1: new int[] {4015}, arg2: false);
                context.SetBreakable(arg1: new int[] {4016}, arg2: false);
                context.SetBreakable(arg1: new int[] {4017}, arg2: false);
                context.SetBreakable(arg1: new int[] {4018}, arg2: false);
                context.SetBreakable(arg1: new int[] {4019}, arg2: false);
                context.SetBreakable(arg1: new int[] {4020}, arg2: false);
                context.SetBreakable(arg1: new int[] {4021}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4001}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4002}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4003}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4004}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4005}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4006}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4007}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4008}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4009}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4010}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4011}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4012}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4013}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4014}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4015}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4016}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4017}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4018}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4019}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4020}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4021}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001107}, arg2: 2);
                context.SetUserValue(key: "ElevatorOn", value: 0);
                context.SetUserValue(key: "DungeonClear", value: 0);
                context.SetUserValue(key: "AgentOff", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "ElevatorOn", value: 1)) {
                    context.State = new StateBoardApp01(context);
                    return;
                }

                if (context.UserValue(key: "AgentOff", value: 1)) {
                    context.State = new StateAgentOff01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardApp01 : TriggerState {
            internal StateBoardApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20038102, textID: 20038102);
                context.SetInteractObject(arg1: new int[] {10001107}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001107}, arg2: 0)) {
                    context.State = new StateBoardGoUp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp01 : TriggerState {
            internal StateBoardGoUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20038102);
                context.SetInteractObject(arg1: new int[] {10001107}, arg2: 2);
                context.SetBreakable(arg1: new int[] {4000}, arg2: true);
                context.SetBreakable(arg1: new int[] {4001}, arg2: true);
                context.SetBreakable(arg1: new int[] {4002}, arg2: true);
                context.SetBreakable(arg1: new int[] {4003}, arg2: true);
                context.SetBreakable(arg1: new int[] {4004}, arg2: true);
                context.SetBreakable(arg1: new int[] {4005}, arg2: true);
                context.SetBreakable(arg1: new int[] {4006}, arg2: true);
                context.SetBreakable(arg1: new int[] {4007}, arg2: true);
                context.SetBreakable(arg1: new int[] {4008}, arg2: true);
                context.SetBreakable(arg1: new int[] {4009}, arg2: true);
                context.SetBreakable(arg1: new int[] {4010}, arg2: true);
                context.SetBreakable(arg1: new int[] {4011}, arg2: true);
                context.SetBreakable(arg1: new int[] {4012}, arg2: true);
                context.SetBreakable(arg1: new int[] {4013}, arg2: true);
                context.SetBreakable(arg1: new int[] {4014}, arg2: true);
                context.SetBreakable(arg1: new int[] {4015}, arg2: true);
                context.SetBreakable(arg1: new int[] {4016}, arg2: true);
                context.SetBreakable(arg1: new int[] {4017}, arg2: true);
                context.SetBreakable(arg1: new int[] {4018}, arg2: true);
                context.SetBreakable(arg1: new int[] {4019}, arg2: true);
                context.SetBreakable(arg1: new int[] {4020}, arg2: true);
                context.SetBreakable(arg1: new int[] {4021}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4001}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4002}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4003}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4004}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4005}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4006}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4007}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4008}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4009}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4010}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4011}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4012}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4013}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4014}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4015}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4016}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4017}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4018}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4019}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4020}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4021}, arg2: true);
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121
                    }, arg2: false, arg3: 200, arg4: 0, arg5: 2f);
                context.SetMesh(
                    arg1: new int[] {
                        3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215,
                        3216, 3217, 3218, 3219, 3220, 3221
                    }, arg2: false, arg3: 200, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateBoardGoUp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp02 : TriggerState {
            internal StateBoardGoUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121
                    }, arg2: true, arg3: 100, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBoardGoUp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp03 : TriggerState {
            internal StateBoardGoUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetBreakable(arg1: new int[] {4001}, arg2: false);
                context.SetBreakable(arg1: new int[] {4002}, arg2: false);
                context.SetBreakable(arg1: new int[] {4003}, arg2: false);
                context.SetBreakable(arg1: new int[] {4004}, arg2: false);
                context.SetBreakable(arg1: new int[] {4005}, arg2: false);
                context.SetBreakable(arg1: new int[] {4006}, arg2: false);
                context.SetBreakable(arg1: new int[] {4007}, arg2: false);
                context.SetBreakable(arg1: new int[] {4008}, arg2: false);
                context.SetBreakable(arg1: new int[] {4009}, arg2: false);
                context.SetBreakable(arg1: new int[] {4010}, arg2: false);
                context.SetBreakable(arg1: new int[] {4011}, arg2: false);
                context.SetBreakable(arg1: new int[] {4012}, arg2: false);
                context.SetBreakable(arg1: new int[] {4013}, arg2: false);
                context.SetBreakable(arg1: new int[] {4014}, arg2: false);
                context.SetBreakable(arg1: new int[] {4015}, arg2: false);
                context.SetBreakable(arg1: new int[] {4016}, arg2: false);
                context.SetBreakable(arg1: new int[] {4017}, arg2: false);
                context.SetBreakable(arg1: new int[] {4018}, arg2: false);
                context.SetBreakable(arg1: new int[] {4019}, arg2: false);
                context.SetBreakable(arg1: new int[] {4020}, arg2: false);
                context.SetBreakable(arg1: new int[] {4021}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4001}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4002}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4003}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4004}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4005}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4006}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4007}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4008}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4009}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4010}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4011}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4012}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4013}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4014}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4015}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4016}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4017}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4018}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4019}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4020}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4021}, arg2: false);
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.SetAgent(arg1: "8013", arg2: false);
                context.SetAgent(arg1: "8014", arg2: false);
                context.SetAgent(arg1: "8015", arg2: false);
                context.SetAgent(arg1: "8016", arg2: false);
                context.SetAgent(arg1: "8017", arg2: false);
                context.SetAgent(arg1: "8018", arg2: false);
                context.SetAgent(arg1: "8019", arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEmergencyPortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEmergencyPortalOn : TriggerState {
            internal StateEmergencyPortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateAgentOff01 : TriggerState {
            internal StateAgentOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.SetAgent(arg1: "8013", arg2: false);
                context.SetAgent(arg1: "8014", arg2: false);
                context.SetAgent(arg1: "8015", arg2: false);
                context.SetAgent(arg1: "8016", arg2: false);
                context.SetAgent(arg1: "8017", arg2: false);
                context.SetAgent(arg1: "8018", arg2: false);
                context.SetAgent(arg1: "8019", arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}