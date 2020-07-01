namespace Maple2.Trigger._50000008_dl {
    public static class _checkusercount {
        public class StateCheckUserCount : TriggerState {
            internal StateCheckUserCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateDungeonStart(context);
                    return;
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateWaitDungeon01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.ShowGuideSummary(entityId: 25100203, textId: 25100203, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDungeonStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart02 : TriggerState {
            internal StateDungeonStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100203, textId: 25100203, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDungeonStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon01 : TriggerState {
            internal StateWaitDungeon01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100201, textId: 25100201, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWaitDungeon02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon02 : TriggerState {
            internal StateWaitDungeon02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateDungeonStart(context);
                    return;
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateWaitDungeon03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon03 : TriggerState {
            internal StateWaitDungeon03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100202, textId: 25100202, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWaitDungeon04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon04 : TriggerState {
            internal StateWaitDungeon04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateDungeonStart(context);
                    return;
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateWaitDungeon05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon05 : TriggerState {
            internal StateWaitDungeon05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100201, textId: 25100201, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWaitDungeon06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon06 : TriggerState {
            internal StateWaitDungeon06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateDungeonStart(context);
                    return;
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateWaitDungeon07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon07 : TriggerState {
            internal StateWaitDungeon07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100202, textId: 25100202, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWaitDungeon08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon08 : TriggerState {
            internal StateWaitDungeon08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateDungeonStart(context);
                    return;
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateWaitDungeon09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon09 : TriggerState {
            internal StateWaitDungeon09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100201, textId: 25100201, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWaitDungeon10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon10 : TriggerState {
            internal StateWaitDungeon10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateDungeonStart(context);
                    return;
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    context.State = new StateWaitDungeon11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon11 : TriggerState {
            internal StateWaitDungeon11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100202, textId: 25100202, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}