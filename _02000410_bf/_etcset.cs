using System;

namespace Maple2.Trigger._02000410_bf {
    public static class _etcset {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    context.State = new State타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머 : TriggerState {
            internal State타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 28000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02000410_BF__BARRICADE_GIVEUP_0$", arg3: 5000);
                    context.DungeonEnableGiveUp(isEnable: true);
                    context.State = new State입구포탈제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입구포탈제거 : TriggerState {
            internal State입구포탈제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                    context.State = new State보스HP체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스HP체크 : TriggerState {
            internal State보스HP체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (Math.Abs(context.GetNpcDamageRate(spawnPointId: 102) - 1.0) < 0.00001f) {
                    context.AddBuff(arg1: new[] {102}, arg2: 50004522, arg3: 1, arg4: true);
                    context.DungeonMissionComplete(feature: "DungeonRankBalance_01", missionId: 24090004);
                    context.DungeonMissionComplete(feature: "DungeonRankBalance_02", missionId: 24090014);
                    context.State = new State메시지알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지알림 : TriggerState {
            internal State메시지알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041005, textId: 20041005);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041005);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}