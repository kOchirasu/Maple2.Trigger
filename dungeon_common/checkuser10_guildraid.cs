namespace Maple2.Trigger._dungeon_common {
    internal static class _checkuser10_guildraid {
        internal class StateCheckUser10_GuildRaid : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateCheckUser10_GuildRaid(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9900) >= 10) {
                    return new StateMaxCount10_Start(context, startDungeon);
                }

                if (context.GetUserCount(boxId: 9900) < 10) {
                    return new StateMaxCount10_Wait(context, startDungeon);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Wait : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount10_Wait(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9900) >= 10) {
                    return new StateMaxCount10_Start(context, startDungeon);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateMaxCount10_Start(context, startDungeon);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMaxCount10_Wait(context, startDungeon);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount10_Start : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount10_Start(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
            }

            public override TriggerState Execute() {
                return startDungeon;
            }

            public override void OnExit() { }
        }
    }
}