using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000354_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7701}, arg2: false);
                context.SetEffect(arg1: new int[] {7702}, arg2: false);
                context.SetEffect(arg1: new int[] {7703}, arg2: false);
                context.SetEffect(arg1: new int[] {7704}, arg2: false);
                context.SetEffect(arg1: new int[] {7705}, arg2: false);
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

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_04 : TriggerState {
            internal State시작_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7701}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012},
                    arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new State시작_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_05 : TriggerState {
            internal State시작_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {11, 12, 13, 14, 15, 16, 17}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {11, 12, 13, 14, 15, 16, 17})) {
                    context.State = new State관문_01_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7702}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 113, textID: 40011);
                context.SetMesh(
                    arg1: new int[] {6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032, 6033},
                    arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 703, arg2: 1)) {
                    context.State = new State관문_02_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_02_시작 : TriggerState {
            internal State관문_02_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {21, 22, 23, 24, 25, 26, 27}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {21, 22, 23, 24, 25, 26, 27})) {
                    context.State = new State관문_02_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
            }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7703}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 113, textID: 40011);
                context.SetMesh(
                    arg1: new int[] {
                        6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066,
                        6067, 6068, 6069, 6070, 6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082,
                        6083
                    }, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 704, arg2: 1)) {
                    context.State = new State관문_03_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_03_시작 : TriggerState {
            internal State관문_03_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {31, 32, 33, 34, 35, 36, 37, 38, 39}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {31, 32, 33, 34, 35, 36, 37, 38, 39})) {
                    context.State = new State관문_03_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
            }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7704}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122, 6123},
                    arg2: false, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 113, textID: 40011);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new State관문_04_시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
            }
        }

        private class State관문_04_시작 : TriggerState {
            internal State관문_04_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {41, 42, 43, 44, 45, 46, 47, 48}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {341, 42, 43, 44, 45, 46, 47, 48})) {
                    context.State = new State관문_04_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
            }
        }

        private class State관문_04_개방 : TriggerState {
            internal State관문_04_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7705}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163, 6164, 6165, 6166
                    }, arg2: false, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 113, textID: 40011);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 706, arg2: 1)) {
                    context.State = new State관문_05_시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 113);
            }
        }

        private class State관문_05_시작 : TriggerState {
            internal State관문_05_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 110, textID: 40010);
                context.CreateMonster(arg1: new int[] {51}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {51})) {
                    context.State = new State관문_05_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 110);
            }
        }

        private class State관문_05_개방 : TriggerState {
            internal State관문_05_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityID: 112, textID: 40009);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 112);
            }
        }
    }
}