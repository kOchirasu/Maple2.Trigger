namespace Maple2.Trigger._02000551_bf {
    public static class _main {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 24, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 25, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SideNpcTalk(type: "talk", npcId: 23000101, illust: "BlackBean_Smile", script: "$02000551_BF__BOSSSPAWN__0$", duration: 7000);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
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
                context.DungeonEnableGiveUp(isEnable: false);
                context.SetPortal(arg1: 21, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 22, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 23, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 24, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 25, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext진행Delay : TriggerState {
            internal StateNext진행Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5800)) {
                    return new StateNext맵가는PortalAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext맵가는PortalAppear : TriggerState {
            internal StateNext맵가는PortalAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}