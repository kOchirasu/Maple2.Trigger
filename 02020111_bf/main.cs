using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020111_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900012, key: "SkillBreakMissionReset", value: 0);
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
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
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new StateBoss_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_시작 : TriggerState {
            internal StateBoss_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900012, key: "SkillBreakMissionReset", value: 1);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23501011, illust: "Turned_Renduebian_normal", script: "$02020111_BF__MAIN__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.DungeonResetTime(seconds: 420);
                context.CreateMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5684)) {
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
                if (context.MonsterDead(spawnIds: new []{101}) && context.GetDungeonPlayTime() < 420) {
                    return new StateBoss_Success(context);
                }

                if (context.GetDungeonPlayTime() == 420) {
                    return new StateBoss_타임어택실패(context);
                }

                if (context.GetUserValue(key: "SkillBreakFail") == 1) {
                    return new StateBoss_스킬브레이크실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_스킬브레이크실패 : TriggerState {
            internal StateBoss_스킬브레이크실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBoss_리셋세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_타임어택실패 : TriggerState {
            internal StateBoss_타임어택실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss_타임어택실패세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_리셋세팅 : TriggerState {
            internal StateBoss_리셋세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900012, key: "SkillBreakMissionReset", value: 0);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.DestroyMonster(spawnIds: new []{-1});
                context.MoveUser(mapId: 2020111, portalId: 1, boxId: 1001);
                context.RemoveBuff(boxId: 1006, skillId: 70002151, arg3: true);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class StateBoss_타임어택실패세팅 : TriggerState {
            internal StateBoss_타임어택실패세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.RemoveBuff(boxId: 1006, skillId: 70002151, arg3: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Success : TriggerState {
            internal StateBoss_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039005);
                context.DungeonSetEndTime();
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23501011, illust: "Turned_Renduebian_normal", script: "$02020111_BF__MAIN__1$", duration: 3176, voice: @"ko/Npc/00002202");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3176)) {
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
                context.DungeonClear();
                context.SetAchievement(type: "trigger", code: "ClearBlueLapenta");
                context.RemoveBuff(boxId: 1006, skillId: 70002151, arg3: true);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 9, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
