namespace Maple2.Trigger._dungeon_common {
    public static class _checkusercount {
        public class StateCheckUserCount : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateCheckUserCount(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetDungeonMaxUserCount() == 4) {
                    context.State = new StateMaxCount04_Wait01(context, startDungeon);
                    return;
                }

                if (context.GetDungeonMaxUserCount() == 3) {
                    context.State = new StateMaxCount03_Wait01(context, startDungeon);
                    return;
                }

                if (context.GetDungeonMaxUserCount() == 2) {
                    context.State = new StateMaxCount02_Wait01(context, startDungeon);
                    return;
                }

                if (context.GetDungeonMaxUserCount() == 1) {
                    context.State = new StateMaxCount01_Wait01(context, startDungeon);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = startDungeon;
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount04_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount() == 4) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMaxCount04_Wait02(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait02 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount04_Wait02(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 4) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMaxCount04_Wait03(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait03 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount04_Wait03(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 4) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMaxCount04_Wait04(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait04 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount04_Wait04(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 4) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = startDungeon;
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount03_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount03_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount() == 3) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMaxCount03_Wait02(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount03_Wait02 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount03_Wait02(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 3) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMaxCount03_Wait03(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount03_Wait03 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount03_Wait03(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 3) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMaxCount03_Wait04(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount03_Wait04 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount03_Wait04(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 3) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = startDungeon;
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount02_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount02_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount() == 2) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMaxCount02_Wait02(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount02_Wait02 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount02_Wait02(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 2) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMaxCount02_Wait03(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount02_Wait03 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount02_Wait03(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 2) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMaxCount02_Wait04(context, startDungeon);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount02_Wait04 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount02_Wait04(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 40012, textId: 40012, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount() == 2) {
                    context.State = startDungeon;
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = startDungeon;
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMaxCount01_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount01_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = startDungeon;
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}