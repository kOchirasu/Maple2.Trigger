namespace Maple2.Trigger._02020120_bf {
    public static class _bgmchangeskillbreakreset {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1220, visible: false, enabled: false, minimapVisible: false);
                context.SetUserValue(key: "SkillBreakStart", value: 0);
                context.SetUserValue(key: "DungeonReset", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 299) == 1) {
                    return new State던전시간작동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전시간작동Wait : TriggerState {
            internal State던전시간작동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 399) == 1) {
                    return new StateSkill브레이크신호Wait_BGM교체(context);
                }

                if (context.GetUserValue(key: "BgmChangeTriggerCancel") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크신호Wait_BGM교체 : TriggerState {
            internal StateSkill브레이크신호Wait_BGM교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 19600, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakStart") >= 1) {
                    return new StateSkill브레이크로직작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크로직작동 : TriggerState {
            internal StateSkill브레이크로직작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6201, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSkill브레이크실패Reset처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크실패Reset처리 : TriggerState {
            internal StateSkill브레이크실패Reset처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1220, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateSkill브레이크실패Cinematic출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크실패Cinematic출력 : TriggerState {
            internal StateSkill브레이크실패Cinematic출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss한테보내는PortalCreation : TriggerState {
            internal StateBoss한테보내는PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 1220, visible: false, enabled: false, minimapVisible: false);
                context.SetUserValue(key: "SkillBreakStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateSkill브레이크신호Wait_시간다시Setting(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss한테보내는PortalCreation_시간Reset안함01 : TriggerState {
            internal StateBoss한테보내는PortalCreation_시간Reset안함01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateBoss한테보내는PortalCreation_시간Reset안함02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss한테보내는PortalCreation_시간Reset안함02 : TriggerState {
            internal StateBoss한테보내는PortalCreation_시간Reset안함02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 1220, visible: false, enabled: false, minimapVisible: false);
                context.SetUserValue(key: "SkillBreakStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateSkill브레이크신호Wait_시간Setting안함(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
