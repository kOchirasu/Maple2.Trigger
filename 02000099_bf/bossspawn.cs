using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000099_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3101, 3102, 3103, 3104, 3105, 3106, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20000991, textId: 20000991, duration: 5000);
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 2000}, arg2: false);
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 301, enable: false);
                context.RemoveBuff(boxId: 199, skillId: 70000107);
            }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20000992, textId: 20000992, duration: 3000);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStartGuide2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartGuide2 : TriggerState {
            internal StateStartGuide2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State1차Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차Spawn : TriggerState {
            internal State1차Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SetSkillA") == 1) {
                    context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State2차SpawnWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차SpawnWait : TriggerState {
            internal State2차SpawnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State2차Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차Spawn : TriggerState {
            internal State2차Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SetSkillB") == 1) {
                    context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateEliteSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEliteSpawn : TriggerState {
            internal StateEliteSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2000})) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.ShowGuideSummary(entityId: 20000993, textId: 20000993, duration: 5000);
                    context.SetMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateElite처치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateElite처치 : TriggerState {
            internal StateElite처치(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.ShowGuideSummary(entityId: 20000994, textId: 20000994, duration: 3000);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
