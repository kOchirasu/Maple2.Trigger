using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000356_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000259, 10000260, 10000261}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동01 : TriggerState {
            internal StateCamera이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.AddBuff(boxIds: new []{102}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20003563, textId: 20003563, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.CameraSelect(triggerId: 303, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동02 : TriggerState {
            internal StateCamera이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동03 : TriggerState {
            internal StateCamera이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enable: true);
                context.ShowGuideSummary(entityId: 20003562, textId: 20003562, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateInteractObjectWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObjectWait : TriggerState {
            internal StateInteractObjectWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enable: false);
                context.RemoveBuff(boxId: 102, skillId: 70000107);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000259, 10000260, 10000261}, arg2: 2)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1099});
                context.CameraSelect(triggerId: 306, enable: true);
                context.AddBuff(boxIds: new []{102}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20003561, textId: 20003561, duration: 6000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.CameraSelect(triggerId: 306, enable: false);
                    context.RemoveBuff(boxId: 102, skillId: 70000107);
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new StateEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonClear();
                    context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
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
