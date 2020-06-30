using System;
using System.Numerics;

namespace Maple2.Trigger._52100106_qd {
    public static class _52100106 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {91000880},
                    arg3: new byte[] {3})) {
                    context.State = new State들킴(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {91000890},
                    arg3: new byte[] {2})) {
                    context.State = new State들킴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State들킴 : TriggerState {
            internal State들킴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(arg1: new Vector3(41f, 21f, 18f), arg2: new Vector3(130f, 130f, 130f));
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 211, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 212, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}