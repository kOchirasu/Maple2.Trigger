namespace Maple2.Trigger._84000007_wd {
    public static class _03_gamblebonus {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "GamblePass") == 22) {
                    context.State = new StateGambleBonusDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "GamblePass") == 23) {
                    context.State = new StateGambleBonusDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "GamblePass") == 32) {
                    context.State = new StateGambleBonusDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "GamblePass") == 33) {
                    context.State = new StateGambleBonusDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "JackpotPass") == 22) {
                    context.State = new StateJackpotBonusDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "JackpotPass") == 23) {
                    context.State = new StateJackpotBonusDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "JackpotPass") == 32) {
                    context.State = new StateJackpotBonusDelay01(context);
                    return;
                }

                if (context.GetUserValue(key: "JackpotPass") == 33) {
                    context.State = new StateJackpotBonusDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleBonusDelay01 : TriggerState {
            internal StateGambleBonusDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "GambleSuccess", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGambleBonusDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleBonusDelay02 : TriggerState {
            internal StateGambleBonusDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateGambleBonus(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGambleBonus : TriggerState {
            internal StateGambleBonus(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameGiveExp(boxId: 9001, expRate: 0.1f, isOutSide: "false");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJackpotBonusDelay01 : TriggerState {
            internal StateJackpotBonusDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "GambleSuccess", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateJackpotBonusDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJackpotBonusDelay02 : TriggerState {
            internal StateJackpotBonusDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateJackpotBonus(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJackpotBonus : TriggerState {
            internal StateJackpotBonus(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameGiveExp(boxId: 9001, expRate: 0.1f, isOutSide: "false");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8001}, arg2: false);
                context.SetUserValue(key: "GamblePass", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}