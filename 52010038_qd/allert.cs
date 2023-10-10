using System.Numerics;

namespace Maple2.Trigger._52010038_qd {
    public static class _allert {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(131f, 160f, 209f));
                context.SetDirectionalLight(diffuseColor: new Vector3(134f, 160f, 143f), specularColor: new Vector3(130f, 130f, 130f));
                context.SetEffect(triggerIds: new []{6000, 6299, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6201, 6202, 6203, 6204}, visible: false);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 209, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 210, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 211, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 212, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 213, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 214, visible: true, initialSequence: "sf_quest_light_A01_Off");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AllertStart") == 1) {
                    return new State이펙트시퀀스01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스01 : TriggerState {
            internal State이펙트시퀀스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{701, 704}, enabled: true);
                context.SetEffect(triggerIds: new []{6101, 6104}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State이펙트시퀀스02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스02 : TriggerState {
            internal State이펙트시퀀스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{707, 708}, enabled: true);
                context.SetEffect(triggerIds: new []{6107, 6108}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State이펙트시퀀스03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스03 : TriggerState {
            internal State이펙트시퀀스03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(diffuseColor: new Vector3(41f, 21f, 18f), specularColor: new Vector3(130f, 130f, 130f));
                context.SetSkill(triggerIds: new []{702, 706}, enabled: true);
                context.SetEffect(triggerIds: new []{6102, 6106}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State경보(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{709}, enabled: true);
                context.SetEffect(triggerIds: new []{6109}, visible: true);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 8000, script: "$52010038_QD__allert__0$", voice: @"ko/Npc/00002104");
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 209, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 210, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 211, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 212, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 213, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 214, visible: true, initialSequence: "sf_quest_light_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4202)) {
                    return new State이펙트시퀀스04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트시퀀스04 : TriggerState {
            internal State이펙트시퀀스04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{703, 705}, enabled: true);
                context.SetEffect(triggerIds: new []{6103, 6105}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "AllertEnd") == 1) {
                    context.SetUserValue(triggerId: 999004, key: "AllertStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
