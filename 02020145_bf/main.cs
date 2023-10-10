using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020145_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
                context.SetEffect(triggerIds: new []{200031, 200032, 200033, 200034, 200035, 200001, 200002, 200003, 200004, 200005, 200021, 200022, 200023, 200024, 200025, 200011, 200012, 200013, 200014, 200015}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1007})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 1006, skillId: 70002151, arg3: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1007})) {
                    return new StateBoss_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_시작 : TriggerState {
            internal StateBoss_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23501011, illust: "Turned_Renduebian_normal", script: "$02020111_BF__MAIN__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.CreateMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5684)) {
                    return new State조명변경(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조명변경 : TriggerState {
            internal State조명변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(diffuseColor: default, specularColor: new Vector3(206f, 174f, 84f));
                context.AddBuff(boxIds: new []{101}, skillId: 62100014, level: 1, arg4: true);
                context.AddBuff(boxIds: new []{1001}, skillId: 75000001, level: 1);
                context.CreateMonster(spawnIds: new []{121, 123, 125, 131, 132, 133});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateBoss_Success(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateFadeIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeIn : TriggerState {
            internal StateFadeIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnId: 101, additionalEffectId: 62100014);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조명리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조명리셋 : TriggerState {
            internal State조명리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$02020111_BF__MOVEMENT_01__1$", arg4: 3, arg5: 0);
                context.DestroyMonster(spawnIds: new []{121, 122, 123, 124, 125, 131, 132, 133, 134});
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
                context.AddBuff(boxIds: new []{1001}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1002}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1003}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1004}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1005}, skillId: 75000002, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateBoss_Success(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new State조건확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건확인 : TriggerState {
            internal State조건확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateBoss_Success(context);
                }

                if (context.GetNpcHpRate(spawnId: 101) >= 0.50f) {
                    return new State조명변경(context);
                }

                if (context.GetNpcHpRate(spawnId: 101) <= 0.50f) {
                    return new State조건추가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateBoss_Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Success : TriggerState {
            internal StateBoss_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(type: "trigger", code: "ClearBlueLapenta_Quest");
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23501011, illust: "Turned_Renduebian_normal", script: "$02020111_BF__MAIN__1$", duration: 3176, voice: @"ko/Npc/00002202");
                context.DestroyMonster(spawnIds: new []{121, 122, 123, 124, 125, 131, 132, 133, 134});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3176)) {
                    return new State조명리셋2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조명리셋2 : TriggerState {
            internal State조명리셋2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
                context.AddBuff(boxIds: new []{1001}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1002}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1003}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1004}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1005}, skillId: 75000002, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetAchievement(type: "trigger", code: "ClearBlueLapenta_Quest");
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
