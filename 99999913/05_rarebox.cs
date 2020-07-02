namespace Maple2.Trigger._99999913 {
    public static class _05_rarebox {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxOnCount", value: 0);
                context.SetUserValue(key: "RareBoxOff", value: 0);
                context.SetInteractObject(arg1: new[] {11000038}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RareBoxOnCount") == 1) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000038}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 180000)) {
                    return new StateBoxOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoxOn : TriggerState {
            internal StateBoxOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"머쉬룸 타워 근처에 황금 상자가 나타났습니다!\n황금 상자를 차지해보세요!", arg3: 5000, arg4: "0");
                context.SetInteractObject(arg1: new[] {11000038}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RareBoxOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000038}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}