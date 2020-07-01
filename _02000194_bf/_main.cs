using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000194_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10001054}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001055}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001056}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001057}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {11000004}, arg2: 2);
                context.SetMesh(arg1: new int[] {3005, 3006, 3007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3201, 3202, 3203}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3301, 3302, 3303, 3304}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
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
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State던전시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시작 : TriggerState {
            internal State던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20001941, textID: 20001941, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new int[] {10001054}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001055}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001056}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001057}, arg2: 1);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004, 2000}, arg2: false);
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddBuff(arg1: new int[] {101}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.SetSkip(arg1: "시작");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetMesh(arg1: new int[] {3005, 3006, 3007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(arg1: 101, arg2: 70000107);
            }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20001942, textID: 20001942, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작2 : TriggerState {
            internal State시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001054}, arg2: 0)) {
                    context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State오브젝트2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트2 : TriggerState {
            internal State오브젝트2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001055}, arg2: 0)) {
                    context.SetMesh(arg1: new int[] {3201, 3202, 3203}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State오브젝트3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트3 : TriggerState {
            internal State오브젝트3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001056}, arg2: 0)) {
                    context.SetMesh(arg1: new int[] {3301, 3302, 3303, 3304}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State오브젝트4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트4 : TriggerState {
            internal State오브젝트4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001057}, arg2: 0)) {
                    context.ShowGuideSummary(entityID: 20001944, textID: 20001944, duration: 5000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.SetMesh(arg1: new int[] {3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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