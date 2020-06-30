using System;

namespace Maple2.Trigger._50000006_dl {
    public static class _checkusercount {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateCheckUserCount(context);

        private class StateCheckUserCount : TriggerState {
            internal StateCheckUserCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonRoomOpened", value: 0);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_vrmachine_A01_off");
                context.SetActor(arg1: 4001, arg2: true, arg3: "Interaction_vrmachine_A01_off");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Interaction_vrmachine_A01_off");
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
                context.SetUserValue(triggerID: 3, key: "machineon", value: 1);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_vrmachine_A01_on");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new StateDungeonStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart01 : TriggerState {
            internal StateDungeonStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "GuildRaid_Laboratory_DungeonOpen_01");
                context.ShowGuideSummary(entityID: 25100206, textID: 25100206, duration: 3000);
                context.SetActor(arg1: 4002, arg2: false, arg3: "Interaction_vrmachine_A01_on");
            }

            public override void Execute() {
                if (context.UserValue(key: "DungeonRoomOpened", value: 1)) {
                    context.State = new StateDungeonStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart02 : TriggerState {
            internal StateDungeonStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2, key: "machineon", value: 1);
                context.SetUserValue(triggerID: 4, key: "machineon", value: 1);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Interaction_vrmachine_A01_on");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Interaction_vrmachine_A01_on");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new StateDungeonStart03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart03 : TriggerState {
            internal StateDungeonStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: false, arg3: "Interaction_vrmachine_A01_on");
                context.SetActor(arg1: 4003, arg2: false, arg3: "Interaction_vrmachine_A01_on");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDungeonStart04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart04 : TriggerState {
            internal StateDungeonStart04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "GuildRaid_Laboratory_DungeonOpen_01");
                context.ShowGuideSummary(entityID: 25100206, textID: 25100206, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDungeonStart04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitDungeon01 : TriggerState {
            internal StateWaitDungeon01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25100204, textID: 25100204, duration: 3000);
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
                context.ShowGuideSummary(entityID: 25100205, textID: 25100205, duration: 3000);
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
                context.ShowGuideSummary(entityID: 25100204, textID: 25100204, duration: 3000);
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
                context.ShowGuideSummary(entityID: 25100205, textID: 25100205, duration: 3000);
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
                context.ShowGuideSummary(entityID: 25100204, textID: 25100204, duration: 3000);
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
                context.ShowGuideSummary(entityID: 25100205, textID: 25100205, duration: 3000);
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