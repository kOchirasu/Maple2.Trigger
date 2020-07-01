using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000318_bf {
    public static class _mobspawn_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "ShipMove", value: 0);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304, 305}, arg2: false);
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204, 205}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(arg1: "CameraWalk01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$02000318_BF__MOBSPAWN_01__0$", arg3: new int[] {3000}, arg4: "0");
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128
                    }, arg2: false, arg3: 29, arg4: 500, arg5: 30);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle01 : TriggerState {
            internal StateBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031801, textID: 20031801);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {301, 302, 303, 304, 305})) {
                    context.State = new StateBattle02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {301, 302, 303, 304, 305});
            }
        }

        private class StateBattle02 : TriggerState {
            internal StateBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111, 112, 113, 114, 115, 116, 501}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle03 : TriggerState {
            internal StateBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031801);
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031802, textID: 20031802);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {111, 112, 113, 114, 115, 116})) {
                    context.State = new StateMoveShip01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {111, 112, 113, 114, 115, 116, 501});
            }
        }

        private class StateMoveShip01 : TriggerState {
            internal StateMoveShip01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031802);
                context.SetUserValue(triggerID: 2, key: "ShipSet", value: 1);
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ShipMove", value: 1)) {
                    context.State = new StateMoveShip02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveShip02 : TriggerState {
            internal StateMoveShip02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {103})) {
                    context.State = new StateBattle11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle11 : TriggerState {
            internal StateBattle11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031801, textID: 20031801);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203, 204, 205})) {
                    context.State = new StateBattle12(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {201, 202, 203, 204, 205});
            }
        }

        private class StateBattle12 : TriggerState {
            internal StateBattle12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {211, 212, 213, 214, 215, 216, 217, 218, 219, 502, 503},
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateBattle13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle13 : TriggerState {
            internal StateBattle13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031801);
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031802, textID: 20031802);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {211, 212, 213, 214, 215, 216, 217, 218, 219})) {
                    context.State = new StateCannonSpawn01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {211, 212, 213, 214, 215, 216, 217, 218, 219, 502, 503});
            }
        }

        private class StateCannonSpawn01 : TriggerState {
            internal StateCannonSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {401}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCannonSpawn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCannonSpawn02 : TriggerState {
            internal StateCannonSpawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031802);
                context.PlaySystemSoundInBox(arg1: new int[] {102}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031804, textID: 20031804);
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {104})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031804);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}