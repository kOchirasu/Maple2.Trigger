using System;
using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _light_on {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Light_On_1", value: 2)
                    && context.UserValue(key: "Light_On_2", value: 2)
                    && context.UserValue(key: "Light_On_3", value: 2)
                    && context.UserValue(key: "Light_On_4", value: 2)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "Light_On_1", value: 1)
                    && context.UserValue(key: "Light_On_2", value: 1)
                    && context.UserValue(key: "Light_On_3", value: 1)
                    && context.UserValue(key: "Light_On_4", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State라이트_변경(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라이트_변경 : TriggerState {
            internal State라이트_변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
            }

            public override void Execute() {
                if (context.UserValue(key: "Light_On_1", value: 1)
                    && context.UserValue(key: "Light_On_2", value: 1)
                    && context.UserValue(key: "Light_On_3", value: 1)
                    && context.UserValue(key: "Light_On_4", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}