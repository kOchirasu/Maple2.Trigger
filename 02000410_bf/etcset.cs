using System;

namespace Maple2.Trigger._02000410_bf {
    public static class _etcset {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new State타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 28000)) {
                    context.SetEventUI(arg1: 1, script: "$02000410_BF__BARRICADE_GIVEUP_0$", duration: 5000);
                    context.DungeonEnableGiveUp(enable: true);
                    return new State입구PortalRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입구PortalRemove : TriggerState {
            internal State입구PortalRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                    return new StateBossHP체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossHP체크 : TriggerState {
            internal StateBossHP체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (Math.Abs(context.GetNpcDamageRate(spawnId: 102) - 1.0) < 0.00001f) {
                    context.AddBuff(boxIds: new []{102}, skillId: 50004522, level: 1, arg4: true);
                    context.DungeonMissionComplete(feature: "DungeonRankBalance_01", missionId: 24090004);
                    context.DungeonMissionComplete(feature: "DungeonRankBalance_02", missionId: 24090014);
                    return new State메시지알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지알림 : TriggerState {
            internal State메시지알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041005, textId: 20041005);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041005);
            }
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
