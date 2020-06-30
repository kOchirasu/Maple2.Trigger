using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000351_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {31, 32}, arg2: false);
                context.CreateMonster(arg1: new int[] {11, 12, 13, 14, 15, 16, 17}, arg2: false);
                context.CreateMonster(arg1: new int[] {21, 22, 23, 24, 25, 26, 27, 28, 29}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000818}, arg2: 0);
                context.SetEffect(arg1: new int[] {9000001}, arg2: false);
                context.SetEffect(arg1: new int[] {9000002}, arg2: false);
                context.SetEffect(arg1: new int[] {9000003}, arg2: false);
                context.SetEffect(arg1: new int[] {9000004}, arg2: false);
                context.SetEffect(arg1: new int[] {9000005}, arg2: false);
                context.SetEffect(arg1: new int[] {9000006}, arg2: false);
                context.SetEffect(arg1: new int[] {9000007}, arg2: false);
                context.SetEffect(arg1: new int[] {9000008}, arg2: false);
                context.SetEffect(arg1: new int[] {9000009}, arg2: false);
                context.SetEffect(arg1: new int[] {9000010}, arg2: false);
                context.SetMesh(arg1: new int[] {6007}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 1)) {
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
                context.SetSkip(arg1: "Start");
                context.CameraSelectPath(arg1: new int[] {80001, 80002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateStart(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000351_BF__MAIN__0$", arg3: new int[] {3000});
                context.CameraSelectPath(arg1: new int[] {80003}, arg2: true);
                context.SetMesh(arg1: new int[] {6900}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new State관문_01_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000818}, arg2: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 703, arg2: 1)) {
                    context.State = new State관문_02_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 111, textID: 20000080);
                context.SetInteractObject(arg1: new int[] {10000819}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000820}, arg2: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 704, arg2: 1)) {
                    context.State = new State관문_03_시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 111);
            }
        }

        private class State관문_03_시작 : TriggerState {
            internal State관문_03_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {33}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {31, 32})) {
                    context.State = new State관문_03_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 112, textID: 40009);
                context.SetMesh(arg1: new int[] {6006}, arg2: false, arg4: 0, arg5: 10f);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 112);
            }
        }
    }
}