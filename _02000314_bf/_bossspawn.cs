namespace Maple2.Trigger._02000314_bf {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003140, textId: 20003140, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddBuff(arg1: new[] {102}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CreateMonster(arg1: new[] {99}, arg2: false);
                context.SetSkip(arg1: "종료체크");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 301, arg2: false);
                context.RemoveBuff(arg1: 102, arg2: 70000107);
            }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
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
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}