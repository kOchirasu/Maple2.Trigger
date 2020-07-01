namespace Maple2.Trigger._02000397_bf {
    public static class _04_hallwaybattle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3800, 3900}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10001147}, arg2: 0);
                context.DestroyMonster(arg1: new[] {901, 902, 903});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobTrapOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn01 : TriggerState {
            internal StateMobTrapOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 901, arg3: "$02000397_BF__04_HALLWAYBATTLE__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$02000397_BF__04_HALLWAYBATTLE__1$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 903, arg3: "$02000397_BF__04_HALLWAYBATTLE__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobTrapOn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn02 : TriggerState {
            internal StateMobTrapOn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "MobWave", value: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039704, textId: 20039704, duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobTrapOn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn03 : TriggerState {
            internal StateMobTrapOn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 6, key: "BlockEnable", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGuideUseKey(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideUseKey : TriggerState {
            internal StateGuideUseKey(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039705, textId: 20039705);
                context.SetInteractObject(arg1: new[] {10001147}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001147}, arg2: 0)) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20039705);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}