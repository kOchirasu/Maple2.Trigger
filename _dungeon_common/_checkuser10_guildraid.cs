using System;

namespace Maple2.Trigger._dungeon_common {
    public static class _checkuser10_guildraid {
        public class StateCheckUser10_GuildRaid : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateCheckUser10_GuildRaid(ITriggerContext context, TriggerState startDungeon) :
                base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: false, arg5: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9900, arg2: 10, arg3: "GreaterEqual")) {
                    context.State = new StateMaxCount10_Start(context, startDungeon);
                    return;
                }

                if (context.CountUsers(arg1: 9900, arg2: 10, arg3: "Less")) {
                    context.State = new StateMaxCount10_Wait(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Wait : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount10_Wait(ITriggerContext context, TriggerState startDungeon) :
                base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 40012, textID: 40012, durationTime: 3000);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9900, arg2: 10, arg3: "GreaterEqual")) {
                    context.State = new StateMaxCount10_Start(context, startDungeon);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateMaxCount10_Start(context, startDungeon);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateMaxCount10_Wait(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Start : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount10_Start(ITriggerContext context, TriggerState startDungeon) :
                base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (true) {
                    context.State = startDungeon;
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}