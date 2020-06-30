using System;
using System.Numerics;

namespace Maple2.Trigger._52010038_qd {
    public static class _allert {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(131f, 160f, 209f));
                context.SetDirectionalLight(arg1: new Vector3(134f, 160f, 143f), arg2: new Vector3(130f, 130f, 130f));
                context.SetEffect(arg1: new int[] {6000, 6299}, arg2: false);
                context.SetEffect(arg1: new int[] {6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109}, arg2: false);
                context.SetEffect(arg1: new int[] {6201, 6202, 6203, 6204}, arg2: false);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 209, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 210, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 211, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 212, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 213, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 214, arg2: true, arg3: "sf_quest_light_A01_Off");
            }

            public override void Execute() {
                if (context.UserValue(key: "AllertStart", value: 1)) {
                    context.State = new State이펙트시퀀스01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스01 : TriggerState {
            internal State이펙트시퀀스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {701}, arg2: true);
                context.SetSkill(arg1: new int[] {704}, arg2: true);
                context.SetEffect(arg1: new int[] {6101, 6104}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State이펙트시퀀스02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스02 : TriggerState {
            internal State이펙트시퀀스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {707}, arg2: true);
                context.SetSkill(arg1: new int[] {708}, arg2: true);
                context.SetEffect(arg1: new int[] {6107, 6108}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State이펙트시퀀스03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스03 : TriggerState {
            internal State이펙트시퀀스03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(arg1: new Vector3(41f, 21f, 18f), arg2: new Vector3(130f, 130f, 130f));
                context.SetSkill(arg1: new int[] {702}, arg2: true);
                context.SetSkill(arg1: new int[] {706}, arg2: true);
                context.SetEffect(arg1: new int[] {6102, 6106}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State경보(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {709}, arg2: true);
                context.SetEffect(arg1: new int[] {6109}, arg2: true);
                context.SideNpcTalk(npcID: 11003536, illust: "Neirin_normal", duration: 8000,
                    script: "$52010038_QD__allert__0$", voice: @"ko/Npc/00002104");
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 209, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 210, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 211, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 212, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 213, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 214, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4202)) {
                    context.State = new State이펙트시퀀스04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스04 : TriggerState {
            internal State이펙트시퀀스04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {703}, arg2: true);
                context.SetSkill(arg1: new int[] {705}, arg2: true);
                context.SetEffect(arg1: new int[] {6103, 6105}, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "AllertEnd", value: 1)) {
                    context.SetUserValue(triggerID: 999004, key: "AllertStart", value: 0);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}