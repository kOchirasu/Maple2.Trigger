using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000290_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 3010, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 3020, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 3040, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002, 3003, 3004, 3005, 3006, 3007, 3008}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3011}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3012, 3013, 3014, 3015, 3016}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3021}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3041}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.DestroyMonster(arg1: new int[] {1001});
                context.DestroyMonster(arg1: new int[] {1002});
                context.DestroyMonster(arg1: new int[] {1003});
                context.DestroyMonster(arg1: new int[] {1004});
                context.DestroyMonster(arg1: new int[] {2001});
                context.DestroyMonster(arg1: new int[] {2002});
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 9991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 9992, isEnable: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State로딩딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로딩딜레이 : TriggerState {
            internal State로딩딜레이(ITriggerContext context) : base(context) { }

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
                context.CameraSelectPath(arg1: new int[] {802, 800}, arg2: 0);
                context.SetSkip(arg1: "CameraWalk01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {800, 802}, arg2: 1);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000290_BF__MAIN__4$", arg3: new int[] {5000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리거01시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거01시작 : TriggerState {
            internal State트리거01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리거01진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거01진행 : TriggerState {
            internal State트리거01진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3002, 3003, 3004, 3005, 3006, 3007, 3008}, arg2: false, arg3: 0,
                    arg4: 200, arg5: 2f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new State트리거02시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State트리거02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거02시작 : TriggerState {
            internal State트리거02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3010, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3011}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리거02진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거02진행 : TriggerState {
            internal State트리거02진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3010, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3012, 3013, 3014, 3015, 3016}, arg2: false, arg3: 0, arg4: 200,
                    arg5: 2f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1002, 1003})) {
                    context.State = new State트리거03시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State트리거03시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거03시작 : TriggerState {
            internal State트리거03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3020, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3021}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리거03진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거03진행 : TriggerState {
            internal State트리거03진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3020, arg2: false, arg3: "Opened");
                context.SetMesh(
                    arg1: new int[] {3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033},
                    arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1004})) {
                    context.State = new State트리거04시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State트리거04시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거04시작 : TriggerState {
            internal State트리거04시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3040, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3041}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리거04진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거04진행 : TriggerState {
            internal State트리거04진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002902);
                context.SetActor(arg1: 3040, arg2: false, arg3: "Opened");
                context.SetMesh(
                    arg1: new int[] {3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053},
                    arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}