namespace Maple2.Trigger._02000314_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003140, textId: 20003140, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.CameraSelect(triggerId: 301, enable: true);
                context.AddBuff(boxIds: new []{102}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.CreateMonster(spawnIds: new []{99}, arg2: false);
                context.SetSkip(state: new StateEnd체크(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 301, enable: false);
                context.RemoveBuff(boxId: 102, skillId: 70000107);
            }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
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
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 13, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
