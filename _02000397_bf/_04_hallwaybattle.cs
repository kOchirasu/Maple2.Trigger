using System;

namespace Maple2.Trigger._02000397_bf {
    public static class _04_hallwaybattle {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3800, 3900}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10001147}, arg2: 0);
                context.DestroyMonster(arg1: new int[] {901, 902, 903});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9300")) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {901, 902, 903}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobTrapOn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn01 : TriggerState {
            internal StateMobTrapOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 901, arg3: "$02000397_BF__04_HALLWAYBATTLE__0$", arg4: 2,
                    arg5: 0);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$02000397_BF__04_HALLWAYBATTLE__1$", arg4: 2,
                    arg5: 0);
                context.SetConversation(arg1: 1, arg2: 903, arg3: "$02000397_BF__04_HALLWAYBATTLE__2$", arg4: 2,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobTrapOn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn02 : TriggerState {
            internal StateMobTrapOn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 5, key: "MobWave", value: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039704, textID: 20039704, duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobTrapOn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn03 : TriggerState {
            internal StateMobTrapOn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 6, key: "BlockEnable", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGuideUseKey(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideUseKey : TriggerState {
            internal StateGuideUseKey(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039705, textID: 20039705);
                context.SetInteractObject(arg1: new int[] {10001147}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001147}, arg2: 0)) {
                    context.State = new StatePortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20039705);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}