using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000312_bf {
    public static class _mobspawn_11 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3005, 3006, 3007, 3008, 3009, 3010}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetLadder(arg1: 510, arg2: false, arg3: false);
                context.SetLadder(arg1: 511, arg2: false, arg3: false);
                context.SetLadder(arg1: 512, arg2: false, arg3: false);
                context.SetLadder(arg1: 513, arg2: false, arg3: false);
                context.SetMesh(arg1: new int[] {3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: true,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1120, 1121, 1122, 1123, 1124, 1125, 1126}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1140}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {1140}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetUserValue(key: "MobWaveStop", value: 0);
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

            public override void OnEnter() { }

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
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
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
                    context.State = new StateBattle01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetLadder(arg1: 510, arg2: true, arg3: true);
                context.SetLadder(arg1: 511, arg2: true, arg3: true);
                context.SetLadder(arg1: 512, arg2: true, arg3: true);
                context.SetLadder(arg1: 513, arg2: true, arg3: true);
                context.SetMesh(arg1: new int[] {3005, 3006, 3007, 3008, 3009, 3010}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateBattle01 : TriggerState {
            internal StateBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031201, textID: 20031201);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102, 103})) {
                    context.State = new StateBattle02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {101, 102, 103});
            }
        }

        private class StateBattle02 : TriggerState {
            internal StateBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031201);
                context.CreateMonster(arg1: new int[] {111, 112, 113, 114}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {111, 112, 113, 114})) {
                    context.State = new StateBattle03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {111, 112, 113, 114});
            }
        }

        private class StateBattle03 : TriggerState {
            internal StateBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031202, textID: 20031202);
                context.CreateMonster(arg1: new int[] {130}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {130})) {
                    context.State = new StateVineRemove01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {130});
            }
        }

        private class StateVineRemove01 : TriggerState {
            internal StateVineRemove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031202);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetMesh(arg1: new int[] {3002, 3003, 3004}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108},
                    arg2: false, arg3: 9, arg4: 0, arg5: 50);
                context.SetRandomMesh(arg1: new int[] {1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119},
                    arg2: false, arg3: 10, arg4: 300, arg5: 50);
                context.SetRandomMesh(arg1: new int[] {1120, 1121, 1122, 1123, 1124, 1125, 1126}, arg2: false, arg3: 7,
                    arg4: 200, arg5: 50);
                context.SetRandomMesh(arg1: new int[] {1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137}, arg2: false,
                    arg3: 8, arg4: 100, arg5: 50);
                context.SetMesh(arg1: new int[] {1140}, arg2: false, arg3: 200, arg4: 0, arg5: 10f);
                context.SetMeshAnimation(arg1: new int[] {1140}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {102})) {
                    context.State = new StateMobWaveStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobWaveStart : TriggerState {
            internal StateMobWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031203, textID: 20031203);
                context.CreateMonster(arg1: new int[] {121, 122, 123, 124, 125, 126, 127, 128}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {121, 122, 123, 124, 125, 126, 127, 128})) {
                    context.State = new StateMobWaveDelayRandom(context);
                    return;
                }

                if (context.UserValue(key: "MobWaveStop", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {121, 122, 123, 124, 125, 126, 127, 128});
            }
        }

        private class StateMobWaveDelayRandom : TriggerState {
            internal StateMobWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 60f)) {
                    context.State = new StateMobWaveDelay01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new StateMobWaveDelay02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new StateMobWaveDelay03(context);
                    return;
                }

                if (context.UserValue(key: "MobWaveStop", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobWaveDelay01 : TriggerState {
            internal StateMobWaveDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateMobWaveStart(context);
                    return;
                }

                if (context.UserValue(key: "MobWaveStop", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobWaveDelay02 : TriggerState {
            internal StateMobWaveDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    context.State = new StateMobWaveStart(context);
                    return;
                }

                if (context.UserValue(key: "MobWaveStop", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobWaveDelay03 : TriggerState {
            internal StateMobWaveDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateMobWaveStart(context);
                    return;
                }

                if (context.UserValue(key: "MobWaveStop", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031203);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}