using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020111_bf {
    public static class _lapenta_attack {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Lapenta_Attack") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23501011, illust: "Turned_Renduebian_normal", script: "$02020111_BF__LAPENTA_ATTACK__0$", duration: 3432, voice: @"ko/Npc/00002199");
                context.SetAmbientLight(color: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(diffuseColor: default, specularColor: new Vector3(206f, 174f, 84f));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3432)) {
                    return new StateActivateSkill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivateSkill : TriggerState {
            internal StateActivateSkill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200001, 200002, 200003, 200004, 200005, 200011, 200012, 200013, 200014, 200015, 200021, 200022, 200023, 200024, 200025, 200031, 200032, 200033, 200034, 200035}, visible: false);
                context.SetSkill(triggerIds: new []{5001}, enabled: true);
                context.AddBuff(boxIds: new []{101}, skillId: 62100026, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{1001}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1002}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1003}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1004}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1005}, skillId: 75000002, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State실패조건Buff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패조건Buff : TriggerState {
            internal State실패조건Buff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900204, key: "Message", value: 1);
                context.AddBuff(boxIds: new []{101}, skillId: 70002181, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Lapenta_Attack") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
