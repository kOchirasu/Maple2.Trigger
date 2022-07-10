namespace Maple2.Trigger._52100053_qd {
    public static class _04_hallwaybattle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3800, 3900}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10002098}, state: 0);
                context.DestroyMonster(spawnIds: new []{901, 902, 903});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9300})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 902, 903}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 901, script: "$52100053_QD__04_HALLWAYBATTLE__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 902, script: "$52100053_QD__04_HALLWAYBATTLE__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 903, script: "$52100053_QD__04_HALLWAYBATTLE__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039704, textId: 20039704, duration: 2000);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039705, textId: 20039705);
                context.SetInteractObject(interactIds: new []{10002098}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002098}, arg2: 0)) {
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
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
