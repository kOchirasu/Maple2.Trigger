using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000329_bf {
    public static class _01_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {701}, arg2: false);
                context.SetEffect(arg1: new int[] {6701}, arg2: true);
                context.CreateMonster(arg1: new int[] {5001, 5002, 1301, 1302, 1303, 1304}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 101, arg2: 1)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "scene_02");
                context.CameraSelectPath(arg1: new int[] {80001, 80002, 80003, 80004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "scene_02");
                context.SetConversation(arg1: 1, arg2: 1301, arg3: "$02000329_BF__01_MAIN__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
                context.CameraSelectPath(arg1: new int[] {80005}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000329_BF__01_MAIN__1$", arg3: new int[] {3000}, arg4: "0");
                context.CreateMonster(arg1: new int[] {2001, 2002, 2003, 2004, 2005}, arg2: false);
                context.SetMesh(arg1: new int[] {10000, 11001, 11002, 11003, 19999}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 105, arg2: 1)) {
                    context.State = new Statenpc_talk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_talk : TriggerState {
            internal Statenpc_talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1301, arg2: "Talk_A");
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 101, textID: 20000051, duration: 5000);
                context.SetConversation(arg1: 1, arg2: 1301, arg3: "$02000329_BF__01_MAIN__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statenpc_talk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc_talk_02 : TriggerState {
            internal Statenpc_talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1301, arg2: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 1301, arg3: "$02000329_BF__01_MAIN__3$", arg4: 2, arg5: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}