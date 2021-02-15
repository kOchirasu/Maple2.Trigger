namespace Maple2.Trigger._02010055_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new State난이도체크(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestDungeon(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonLevel() == 2) {
                    return new State레이드(context);
                }

                if (context.GetDungeonLevel() == 3) {
                    return new State카오스레이드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDungeon : TriggerState {
            internal StateQuestDungeon(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000118, arg3: 1, arg4: false, arg5: false);
                context.CreateMonster(arg1: new[] {2299}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2299})) {
                    return new StateEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레이드 : TriggerState {
            internal State레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2099}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new StateEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카오스레이드 : TriggerState {
            internal State카오스레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2199}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2199})) {
                    return new StateEndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                    context.DungeonClear();
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