using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000281_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301, 302}, arg2: true, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new[] {10000414}, arg2: 0);
                context.SetLadder(arg1: 321, arg2: false, arg3: false);
                context.SetLadder(arg1: 322, arg2: false, arg3: false);
                context.SetLadder(arg1: 323, arg2: false, arg3: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000414}, arg2: 1);
                context.CameraSelect(arg1: 3001, arg2: true);
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State카메라대기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State카메라대기 : TriggerState {
            internal State카메라대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002810, textId: 20002810, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State카메라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메라이동 : TriggerState {
            internal State카메라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 3002, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State생성(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveBuff(arg1: 199, arg2: 70000107);
                context.CameraSelect(arg1: 3002, arg2: false);
            }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301, 302}, arg2: false, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000414}, arg2: 0)) {
                    return new State보스(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스 : TriggerState {
            internal State보스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.ShowGuideSummary(entityId: 20002816, textId: 20002816, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.SetLadder(arg1: 321, arg2: true, arg3: true);
                    context.SetLadder(arg1: 322, arg2: true, arg3: true);
                    context.SetLadder(arg1: 323, arg2: true, arg3: true);
                    context.SetPortal(arg1: 2, arg2: false, arg3: true, arg4: true);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}