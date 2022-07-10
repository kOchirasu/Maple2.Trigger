namespace Maple2.Trigger._50000006_dl {
    public static class _checkusercount {
        public class StateCheckUserCount : TriggerState {
            internal StateCheckUserCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonRoomOpened", value: 0);
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Interaction_vrmachine_A01_off");
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Interaction_vrmachine_A01_off");
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Interaction_vrmachine_A01_off");
            }

            public override TriggerState? Execute() {
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
                context.SetUserValue(triggerId: 3, key: "machineon", value: 1);
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Interaction_vrmachine_A01_on");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new StateDungeonStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart01 : TriggerState {
            internal StateDungeonStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "GuildRaid_Laboratory_DungeonOpen_01");
                context.ShowGuideSummary(entityId: 25100206, textId: 25100206, duration: 3000);
                context.SetActor(triggerId: 4002, visible: false, initialSequence: "Interaction_vrmachine_A01_on");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DungeonRoomOpened") == 1) {
                    return new StateDungeonStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart02 : TriggerState {
            internal StateDungeonStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "machineon", value: 1);
                context.SetUserValue(triggerId: 4, key: "machineon", value: 1);
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Interaction_vrmachine_A01_on");
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Interaction_vrmachine_A01_on");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new StateDungeonStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart03 : TriggerState {
            internal StateDungeonStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4001, visible: false, initialSequence: "Interaction_vrmachine_A01_on");
                context.SetActor(triggerId: 4003, visible: false, initialSequence: "Interaction_vrmachine_A01_on");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonStart04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart04 : TriggerState {
            internal StateDungeonStart04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "GuildRaid_Laboratory_DungeonOpen_01");
                context.ShowGuideSummary(entityId: 25100206, textId: 25100206, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDungeonStart04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon01 : TriggerState {
            internal StateWaitDungeon01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100204, textId: 25100204, duration: 3000);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.ShowGuideSummary(entityId: 25100205, textId: 25100205, duration: 3000);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.ShowGuideSummary(entityId: 25100204, textId: 25100204, duration: 3000);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.ShowGuideSummary(entityId: 25100205, textId: 25100205, duration: 3000);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.ShowGuideSummary(entityId: 25100204, textId: 25100204, duration: 3000);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.ShowGuideSummary(entityId: 25100205, textId: 25100205, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
