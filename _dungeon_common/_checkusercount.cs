namespace Maple2.Trigger._dungeon_common {
    public static class _checkusercount {
        public class StateCheckUserCount : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateCheckUserCount(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonMaxUserCount() == 4) {
                    return new StateMaxCount04_Wait01(context, startDungeon);
                }

                if (context.GetDungeonMaxUserCount() == 3) {
                    return new StateMaxCount03_Wait01(context, startDungeon);
                }

                if (context.GetDungeonMaxUserCount() == 2) {
                    return new StateMaxCount02_Wait01(context, startDungeon);
                }

                if (context.GetDungeonMaxUserCount() == 1) {
                    return new StateMaxCount01_Wait01(context, startDungeon);
                }

                if (!context.IsDungeonRoom()) {
                    return startDungeon;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount04_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount04_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() == 4) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMaxCount04_Wait02(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 4) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMaxCount04_Wait03(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 4) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMaxCount04_Wait04(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 4) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return startDungeon;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount03_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount03_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() == 3) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMaxCount03_Wait02(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 3) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMaxCount03_Wait03(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 3) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMaxCount03_Wait04(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 3) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return startDungeon;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount02_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount02_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() == 2) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMaxCount02_Wait02(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 2) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMaxCount02_Wait03(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 2) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateMaxCount02_Wait04(context, startDungeon);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.GetUserCount() == 2) {
                    return startDungeon;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return startDungeon;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMaxCount01_Wait01 : TriggerState {
            private readonly TriggerState startDungeon;

            internal StateMaxCount01_Wait01(ITriggerContext context, TriggerState startDungeon) : base(context) {
                this.startDungeon = startDungeon;
            }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return startDungeon;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}