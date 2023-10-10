namespace Maple2.Trigger._02020130_bf {
    public static class _debuff_ishurarenduebianyuperia {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraFirstSetEnd", value: 0);
                context.SetUserValue(key: "RenduebianFirstSetEnd", value: 0);
                context.SetUserValue(key: "YuperiaFirstSetEnd", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 601) == 1) {
                    return new State1셋트전투판스킬TriggerSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1셋트전투판스킬TriggerSetting : TriggerState {
            internal State1셋트전투판스킬TriggerSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1301, 1302, 1303}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 310)) {
                    return new State1셋트전투판마무리신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1셋트전투판마무리신호Wait : TriggerState {
            internal State1셋트전투판마무리신호Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "IshuraFirstSetEnd") == 1) {
                    return new StateIshura_디Buff스킬끄기(context);
                }

                if (context.GetUserValue(key: "RenduebianFirstSetEnd") == 1) {
                    return new State렌듀비앙_디Buff스킬끄기(context);
                }

                if (context.GetUserValue(key: "YuperiaFirstSetEnd") == 1) {
                    return new State유페리아_디Buff스킬끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura_디Buff스킬끄기 : TriggerState {
            internal StateIshura_디Buff스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraFirstSetEnd", value: 0);
                context.SetSkill(triggerIds: new []{1301}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 370)) {
                    return new State1셋트전투판마무리신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙_디Buff스킬끄기 : TriggerState {
            internal State렌듀비앙_디Buff스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RenduebianFirstSetEnd", value: 0);
                context.SetSkill(triggerIds: new []{1302}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 370)) {
                    return new State1셋트전투판마무리신호Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아_디Buff스킬끄기 : TriggerState {
            internal State유페리아_디Buff스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "YuperiaFirstSetEnd", value: 0);
                context.SetSkill(triggerIds: new []{1303}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 370)) {
                    return new State1셋트전투판마무리신호Wait(context);
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
    }
}
