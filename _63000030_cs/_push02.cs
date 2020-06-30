using System;

namespace Maple2.Trigger._63000030_cs {
    public static class _push02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6107}, arg2: false);
                context.SetEffect(arg1: new int[] {6006}, arg2: false);
                context.SetAgent(arg1: "8100", arg2: false);
                context.SetAgent(arg1: "8101", arg2: false);
                context.SetAgent(arg1: "8102", arg2: false);
                context.SetAgent(arg1: "8103", arg2: false);
                context.SetAgent(arg1: "8104", arg2: false);
                context.SetAgent(arg1: "8105", arg2: false);
                context.SetAgent(arg1: "8106", arg2: false);
                context.SetAgent(arg1: "8107", arg2: false);
                context.SetAgent(arg1: "8108", arg2: false);
                context.SetAgent(arg1: "8109", arg2: false);
                context.SetAgent(arg1: "8110", arg2: false);
                context.SetAgent(arg1: "8111", arg2: false);
                context.SetAgent(arg1: "8112", arg2: false);
                context.SetSkill(arg1: new int[] {7000}, arg2: false);
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "PushStart", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "PushStart", value: 1)) {
                    context.State = new StateEnter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "8100", arg2: true);
                context.SetAgent(arg1: "8101", arg2: true);
                context.SetAgent(arg1: "8102", arg2: true);
                context.SetAgent(arg1: "8103", arg2: true);
                context.SetAgent(arg1: "8104", arg2: true);
                context.SetAgent(arg1: "8105", arg2: true);
                context.SetAgent(arg1: "8106", arg2: true);
                context.SetAgent(arg1: "8107", arg2: true);
                context.SetAgent(arg1: "8108", arg2: true);
                context.SetAgent(arg1: "8109", arg2: true);
                context.SetAgent(arg1: "8110", arg2: true);
                context.SetAgent(arg1: "8111", arg2: true);
                context.SetAgent(arg1: "8112", arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9100")) {
                    context.State = new StatePush01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePush01 : TriggerState {
            internal StatePush01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNpcTalkRandom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcTalkRandom : TriggerState {
            internal StateNpcTalkRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateJuntaTalk01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateTinChaiTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJuntaTalk01 : TriggerState {
            internal StateJuntaTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new int[] {6107}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000030_CS__PUSH02__0$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk01 : TriggerState {
            internal StateTinChaiTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new int[] {6006}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__PUSH02__1$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset01 : TriggerState {
            internal StateReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9100")) {
                    context.State = new StatePush01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}