using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000290_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 3010, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 3020, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 3040, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3011, 3012, 3013, 3014, 3015, 3016, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 2001, 2002});
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 9991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 9992, isEnable: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State로딩Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로딩Delay : TriggerState {
            internal State로딩Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {802, 800}, arg2: false);
                context.SetSkip(state: new StateCameraWalk01(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {800, 802}, arg2: true);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000290_BF__MAIN__4$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger01시작 : TriggerState {
            internal StateTrigger01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger01진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger01진행 : TriggerState {
            internal StateTrigger01진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {3002, 3003, 3004, 3005, 3006, 3007, 3008}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new StateTrigger02시작(context);
                }

                if (context.WaitTick(waitTick: 7000)) {
                    return new StateTrigger02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger02시작 : TriggerState {
            internal StateTrigger02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3010, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3011}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1002, 1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger02진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger02진행 : TriggerState {
            internal StateTrigger02진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3010, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {3012, 3013, 3014, 3015, 3016}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1002, 1003})) {
                    return new StateTrigger03시작(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateTrigger03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger03시작 : TriggerState {
            internal StateTrigger03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3020, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3021}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger03진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger03진행 : TriggerState {
            internal StateTrigger03진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3020, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1004})) {
                    return new StateTrigger04시작(context);
                }

                if (context.WaitTick(waitTick: 7000)) {
                    return new StateTrigger04시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger04시작 : TriggerState {
            internal StateTrigger04시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3040, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3041}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTrigger04진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger04진행 : TriggerState {
            internal StateTrigger04진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002902);
                context.SetActor(arg1: 3040, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}