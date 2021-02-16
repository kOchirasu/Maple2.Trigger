namespace Maple2.Trigger._50000001_dl {
    public static class _checkusercount {
        public class StateCheckUserCount : TriggerState {
            internal StateCheckUserCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    return new StateDungeonStart(context);
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    return new StateWaitDungeon01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.ShowGuideSummary(entityId: 25100203, textId: 25100203, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDungeonStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart02 : TriggerState {
            internal StateDungeonStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100203, textId: 25100203, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDungeonStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon01 : TriggerState {
            internal StateWaitDungeon01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100201, textId: 25100201, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWaitDungeon02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon02 : TriggerState {
            internal StateWaitDungeon02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    return new StateDungeonStart(context);
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    return new StateWaitDungeon03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon03 : TriggerState {
            internal StateWaitDungeon03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100202, textId: 25100202, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWaitDungeon04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon04 : TriggerState {
            internal StateWaitDungeon04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    return new StateDungeonStart(context);
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    return new StateWaitDungeon05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon05 : TriggerState {
            internal StateWaitDungeon05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100201, textId: 25100201, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWaitDungeon06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon06 : TriggerState {
            internal StateWaitDungeon06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    return new StateDungeonStart(context);
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    return new StateWaitDungeon07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon07 : TriggerState {
            internal StateWaitDungeon07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100202, textId: 25100202, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWaitDungeon08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon08 : TriggerState {
            internal StateWaitDungeon08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    return new StateDungeonStart(context);
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    return new StateWaitDungeon09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon09 : TriggerState {
            internal StateWaitDungeon09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100201, textId: 25100201, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWaitDungeon10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon10 : TriggerState {
            internal StateWaitDungeon10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckDungeonLobbyUserCount()) {
                    return new StateDungeonStart(context);
                }

                if (!context.CheckDungeonLobbyUserCount()) {
                    return new StateWaitDungeon11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon11 : TriggerState {
            internal StateWaitDungeon11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100202, textId: 25100202, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}