using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020120_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1920, 1921, 1922, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1932, 1933, 1934, 1935, 1936, 1937}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetUserValue(key: "DungeonReset", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 720);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23000113, illust: "Ishura_Dark_Idle", script: "$02020120_BF__BOSSSPAWN__0$", duration: 4000, voice: @"ko/Npc/00002192");
                context.CreateMonster(arg1: new[] {99}, arg2: false);
                context.SetPortal(portalId: 9901, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9902, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    return new State던전Reset진행(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new StateEndDelay(context);
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

        private class State던전Reset진행 : TriggerState {
            internal State던전Reset진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020120, arg2: 9903);
                context.SetSound(arg1: 19601, arg2: true);
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23000113, illust: "Ishura_Dark_smile", script: "$02020120_BF__BOSSSPAWN__1$", duration: 7000, voice: @"ko/Npc/00002193");
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State던전Reset시간등각종설정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전Reset시간등각종설정 : TriggerState {
            internal State던전Reset시간등각종설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.SetUserValue(key: "DungeonReset", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 23000113, illust: "Ishura_Dark_Idle", script: "$02020120_BF__BOSSSPAWN__2$", duration: 6576, voice: @"ko/Npc/00002194");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.SetSkill(arg1: new[] {2222, 1212}, arg2: false);
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.DungeonClear();
                    context.DungeonSetEndTime();
                    context.SetAchievement(arg3: "IshuraDungeonClear");
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure : TriggerState {
            internal StateDungeonFailure(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetSkill(arg1: new[] {2222, 1212}, arg2: false);
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2101, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3101, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3102, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3103, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3104, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3202, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3203, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3302, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3303, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3304, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3305, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3306, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4101, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4102, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4202, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 4302, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5101, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5102, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5202, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5203, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5204, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5205, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5206, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5302, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5303, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5304, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5401, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6101, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6302, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6303, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6304, visible: true, enabled: true, minimapVisible: true);
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}