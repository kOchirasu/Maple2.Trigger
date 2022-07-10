namespace Maple2.Trigger._84000007_wd {
    public static class _03_gamblebonus {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GamblePass") == 22) {
                    return new StateGambleBonusDelay01(context);
                }

                if (context.GetUserValue(key: "GamblePass") == 23) {
                    return new StateGambleBonusDelay01(context);
                }

                if (context.GetUserValue(key: "GamblePass") == 32) {
                    return new StateGambleBonusDelay01(context);
                }

                if (context.GetUserValue(key: "GamblePass") == 33) {
                    return new StateGambleBonusDelay01(context);
                }

                if (context.GetUserValue(key: "JackpotPass") == 22) {
                    return new StateJackpotBonusDelay01(context);
                }

                if (context.GetUserValue(key: "JackpotPass") == 23) {
                    return new StateJackpotBonusDelay01(context);
                }

                if (context.GetUserValue(key: "JackpotPass") == 32) {
                    return new StateJackpotBonusDelay01(context);
                }

                if (context.GetUserValue(key: "JackpotPass") == 33) {
                    return new StateJackpotBonusDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleBonusDelay01 : TriggerState {
            internal StateGambleBonusDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "GambleSuccess", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGambleBonusDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleBonusDelay02 : TriggerState {
            internal StateGambleBonusDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGambleBonus(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGambleBonus : TriggerState {
            internal StateGambleBonus(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameGiveExp(boxId: 9001, expRate: 0.1f, isOutSide: false);
            }

            public override TriggerState? Execute() {
                return new StateQuit(context);
            }

            public override void OnExit() { }
        }

        private class StateJackpotBonusDelay01 : TriggerState {
            internal StateJackpotBonusDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "GambleSuccess", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateJackpotBonusDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJackpotBonusDelay02 : TriggerState {
            internal StateJackpotBonusDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateJackpotBonus(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJackpotBonus : TriggerState {
            internal StateJackpotBonus(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameGiveExp(boxId: 9001, expRate: 0.1f, isOutSide: false);
            }

            public override TriggerState? Execute() {
                return new StateQuit(context);
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8001}, visible: false);
                context.SetUserValue(key: "GamblePass", value: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
