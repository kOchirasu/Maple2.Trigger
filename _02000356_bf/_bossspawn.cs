using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000356_bf {
    public static class _bossspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetMesh(
                    arg1: new int[]
                        {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "102")) {
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
                context.CreateMonster(
                    arg1: new int[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1010, 1011, 1012, 1013, 1014, 1015,
                        1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030
                    }, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000259, 10000260, 10000261}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동01 : TriggerState {
            internal State카메라이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[]
                        {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.AddBuff(arg1: new int[] {102}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityID: 20003563, textID: 20003563, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동02 : TriggerState {
            internal State카메라이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카메라이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동03 : TriggerState {
            internal State카메라이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.ShowGuideSummary(entityID: 20003562, textID: 20003562, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State오브젝트반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응대기 : TriggerState {
            internal State오브젝트반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: false);
                context.RemoveBuff(arg1: 102, arg2: 70000107);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000259, 10000260, 10000261}, arg2: 2)) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1099});
                context.CameraSelect(arg1: 306, arg2: true);
                context.AddBuff(arg1: new int[] {102}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityID: 20003561, textID: 20003561, duration: 6000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.CameraSelect(arg1: 306, arg2: false);
                    context.RemoveBuff(arg1: 102, arg2: 70000107);
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State종료딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.DungeonClear();
                    context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
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