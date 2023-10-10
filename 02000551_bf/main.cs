using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000551_bf {
    public static class _main {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateDefaultSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting : TriggerState {
            internal StateDefaultSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 24, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 25, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State난이도체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonId() == 23050003) {
                    return new StateEasyDifficultyBossSpawn(context);
                }

                if (context.GetDungeonId() == 23051003) {
                    return new StateHardDifficultyBossSpawn(context);
                }

                if (context.WaitTick(waitTick: 1100)) {
                    return new StateHardDifficultyBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHardDifficultyBossSpawn : TriggerState {
            internal StateHardDifficultyBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    return new State일러스트대화창(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEasyDifficultyBossSpawn : TriggerState {
            internal StateEasyDifficultyBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    return new State일러스트대화창(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일러스트대화창 : TriggerState {
            internal State일러스트대화창(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23000101, illust: "BlackBean_Smile", script: "$02000551_BF__BOSSSPAWN__0$", duration: 7000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2100)) {
                    return new State전투진행중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투진행중 : TriggerState {
            internal State전투진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GuideMessage", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GuideMessage") == 1) {
                    return new StateDisplayGuide(context);
                }

                if (context.GetUserValue(key: "NextPortal") == 1) {
                    return new StateNext진행Delay(context);
                }

                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDisplayGuide : TriggerState {
            internal StateDisplayGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200007, textId: 29200007, duration: 7000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State전투진행중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure : TriggerState {
            internal StateDungeonFailure(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(enabled: false);
                context.SetPortal(portalId: 21, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 22, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 23, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 24, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 25, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext진행Delay : TriggerState {
            internal StateNext진행Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5800)) {
                    return new StateNext맵가는PortalSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext맵가는PortalSpawn : TriggerState {
            internal StateNext맵가는PortalSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 9, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
