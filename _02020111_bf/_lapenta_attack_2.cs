using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _lapenta_attack_2 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Lapenta_Attack_2") == 1) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 23501011, illust: "Turned_Renduebian_normal", script: "$02020111_BF__LAPENTA_ATTACK_2__0$", duration: 3525, voice: @"ko/Npc/00002200");
                context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3525)) {
                    return new State스킬발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬발동 : TriggerState {
            internal State스킬발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200001, 200002, 200003, 200004, 200005, 200011, 200012, 200013, 200014, 200015, 200021, 200022, 200023, 200024, 200025, 200031, 200032, 200033, 200034, 200035}, arg2: false);
                context.SetSkill(arg1: new[] {5002}, arg2: true);
                context.AddBuff(arg1: new[] {101}, arg2: 62100026, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1005}, arg2: 75000002, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State실패조건버프(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패조건버프 : TriggerState {
            internal State실패조건버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900204, key: "Message", value: 1);
                context.AddBuff(arg1: new[] {101}, arg2: 70002181, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Lapenta_Attack_2") == 0) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}