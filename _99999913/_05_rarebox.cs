using System;

namespace Maple2.Trigger._99999913 {
    public static class _05_rarebox {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxOnCount", value: 0);
                context.SetUserValue(key: "RareBoxOff", value: 0);
                context.SetInteractObject(arg1: new int[] {11000038}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxOnCount", value: 1)) {
                    context.State = new StateDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000038}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 180000)) {
                    context.State = new StateBoxOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoxOn : TriggerState {
            internal StateBoxOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"머쉬룸 타워 근처에 황금 상자가 나타났습니다!\n황금 상자를 차지해보세요!", arg3: new int[] {5000},
                    arg4: "0");
                context.SetInteractObject(arg1: new int[] {11000038}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000038}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateSetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}